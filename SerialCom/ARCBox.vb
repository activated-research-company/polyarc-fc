Imports System
Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Threading
Imports System.Windows.Forms

Public Class Form1
    Dim polltiming As Integer = 500
    Dim firsttime As Integer = 1
    Dim saveFileDialog1 As New SaveFileDialog()
    Dim airWithH2 As Double = 7.5
    Dim version As String = ""
    Dim messagenum As Integer = 1

    Dim WithEvents PollingTimer As New Windows.Forms.Timer With {.Interval = polltiming}

    Private Property SerialWrapper As SerialWrapper

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StopPolling.Enabled = False
        Off.Enabled = False
        H2Adjust.Enabled = False
        H2FlowBox.Enabled = False
        AirAdjust.Enabled = False
        AirFlowBox.Enabled = False
        SaveCheck.Enabled = False
        H2Carrier.Enabled = False
        Run.Enabled = False
        Off.Enabled = False
        Tare.Enabled = False

        Dim time As String = TimeOfDay.ToString("hh:mm:ss")
        FlowChart.Series("Air").Points.AddXY(time, 0)
        FlowChart.Series("Hydrogen").Points.AddXY(time, 0)
        FlowChart.ChartAreas("ChartArea1").AxisX.LabelStyle.Format = "hh:mm:ss"

        If SerialPort.GetPortNames.Count = 0 Then
            ShowErrorMessage("We could not find any available serial ports.")
            Application.Exit()
        ElseIf SerialPort.GetPortNames.Count = 1 Then
            SerialWrapper = New SerialWrapper(SerialPort.GetPortNames(0), 38400, TimeSpan.FromMilliseconds(250))
        Else
            Try
                Dim frmCOM As New COM
                frmCOM.ShowDialog()
                SerialWrapper = New SerialWrapper(frmCOM.SerialPort1.PortName, 38400, TimeSpan.FromMilliseconds(250))
            Catch exception As Exception
                ShowErrorMessage(exception.Message)
                Application.Exit()
            End Try
        End If

        Try
            If Not SerialWrapper Is Nothing Then
                'enable buttons and polling
                Off.Enabled = True
                H2Adjust.Enabled = True
                H2FlowBox.Enabled = True
                AirAdjust.Enabled = True
                AirFlowBox.Enabled = True
                SaveCheck.Enabled = True
                H2Carrier.Enabled = True
                Run.Enabled = True
                Off.Enabled = True
                Tare.Enabled = True

                'determine flow controller version
                Dim returnStr As String = SerialWrapper.Transact("a")
                Dim Elements As String() = System.Text.RegularExpressions.Regex.Split(returnStr, "\s+")
                If Elements.Length > 5 Then
                    version = "standard"
                Else
                    version = "MEMS"
                End If

                'Change default mode to nonvolatile setpoints if applicable
                If version.Equals("standard") Then
                    Dim tempvol As String = SerialWrapper.Transact("A$$R18")
                    If Not tempvol.Substring(tempvol.Length - 5).Equals("33792") Then
                        SerialWrapper.Transact("A$$W18=33792") 'set the flow controller to use non-volatile setpoints if it is not setup already
                    End If
                    tempvol = SerialWrapper.Transact("H$$R18")
                    If Not tempvol.Substring(tempvol.Length - 5).Equals("33792") Then
                        SerialWrapper.Transact("H$$W18=33792") 'set the flow controller to use non-volatile setpoints if it is not setup already
                    End If
                End If

                'set initial values
                Dim air As Double() = ReadFlow("a")
                AirFlowBox.Text = air(1)
                AirAdjust.Value = air(2)
                Dim h2 As Double() = ReadFlow("h")
                H2FlowBox.Text = h2(1)
                H2Adjust.Value = h2(2)
            Else
                Application.Exit()
            End If
        Catch exception As Exception
            ShowErrorMessage(exception.Message)
            Application.Exit()
        End Try

        PollingTimer.Start()
        StopPolling.Enabled = True
        StopPolling.Checked = False

    End Sub

    Private Sub ShowErrorMessage(message)
        MessageBox.Show(
            $"{message}{vbCr}{vbCr}Please check your power and communication connections and restart the program.",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
    End Sub

    Private Function ReadFlow(InputString) As Double()
        Try
            Dim returnStr As String = SerialWrapper.Transact(InputString)

            Dim temp As Double
            Dim flow As Double
            Dim sp As Double

            Dim Elements As String() = System.Text.RegularExpressions.Regex.Split(returnStr, "\s+")
            If version.Equals("standard") Then
                temp = Convert.ToDouble(Elements(2).Substring(1, 6))
                flow = Convert.ToDouble(Elements(4).Substring(1, 6))
                sp = Convert.ToDouble(Elements(5).Substring(0, 6))
            ElseIf version.Equals("MEMS") Then
                temp = Convert.ToDouble(Elements(1).Substring(0, 4))
                flow = Convert.ToDouble(Elements(2).Substring(0, 6))
                sp = Convert.ToDouble(Elements(3).Substring(0, 6))
            End If
            flow = Math.Round(flow, 1)

            Return {temp, flow, sp}
        Catch ex As Exception
            StopPolling.Checked = True
            PollingTimer.Stop()
            If messagenum = 1 Then
                messagenum = messagenum + 1
                Dim response = MessageBox.Show("Communication Error - Program Has Been Paused!" & vbCr & vbCr & "Please check your power and communication connections and press Retry to restart the program or cancel to shutdown", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                If response = MsgBoxResult.Retry Then
                    SerialWrapper.Close()
                    Application.Restart()
                ElseIf response = MsgBoxResult.Cancel Then
                    Application.Exit()
                End If
            End If
            Return {0, 0, 0}
        End Try
    End Function

    Private Sub PollingTimer_Expire() Handles PollingTimer.Tick
        If StopPolling.Checked Then
            Exit Sub
        Else
            'call airflowrate and set output to graphs and text boxes
            Dim air As Double() = ReadFlow("a")
            AirFlowBox.Text = air(1)
            If version.Equals("MEMS") Then
                Thread.Sleep(100)
            End If
            Dim h2 As Double() = ReadFlow("h")
            H2FlowBox.Text = h2(1)
            If version.Equals("MEMS") Then
                Thread.Sleep(100)
            End If

            Dim time As String = TimeOfDay.ToString("hh:mm:ss")

            FlowChart.Series("Hydrogen").Points.AddXY(time, h2(1))
            FlowChart.Series("Air").Points.AddXY(time, air(1))

            If FlowChart.Series("Hydrogen").Points.Count > GraphPoints.Value Then
                Do
                    FlowChart.Series("Hydrogen").Points.RemoveAt(0)
                    FlowChart.Series("Air").Points.RemoveAt(0)
                Loop While FlowChart.Series("Hydrogen").Points.Count > GraphPoints.Value
            End If

            If SaveCheck.Checked Then
                My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, Now.ToString & "," & air(0) & "," & air(1) & "," & air(2) & "," & h2(1) & "," & h2(2) & vbCr, True)
            End If
        End If
    End Sub

    Private Sub AirAdjust_ValueChanged(sender As Object, e As EventArgs) Handles AirAdjust.ValueChanged
        If version.Equals("standard") Then
            SerialWrapper.Transact("as" & AirAdjust.Value.ToString)
        ElseIf version.Equals("MEMS") Then
            'take value and multiply by 40 then add a in front and convert to string"
            SerialWrapper.Transact("a" & (CInt(AirAdjust.Value * 40).ToString))
        End If
    End Sub

    Private Sub H2Adjust_ValueChanged(sender As Object, e As EventArgs) Handles H2Adjust.ValueChanged
        If version.Equals("standard") Then
            SerialWrapper.Transact("hs" & H2Adjust.Value.ToString)
        ElseIf version.Equals("MEMS") Then
            'take value and multiply by 40 then add h in front and convert to string"
            SerialWrapper.Transact("h" & (CInt(H2Adjust.Value * 40).ToString))
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the Serial Port
        PollingTimer.Stop()
        StopPolling.Checked = True
        SerialPort1.Close()
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Close the Serial Port
        PollingTimer.Stop()
        StopPolling.Checked = True
        SerialPort1.Close()
        Application.Exit()
    End Sub

    Private Sub RefreshTime_ValueChanged(sender As Object, e As EventArgs) Handles RefreshTime.ValueChanged
        PollingTimer.Interval = RefreshTime.Value * 1000
    End Sub

    Private Sub SaveCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SaveCheck.CheckedChanged
        PollingTimer.Stop()
        If SaveCheck.Checked AndAlso firsttime = 1 Then
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|TXT files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialog1.Title = "Save data file"
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, "Date and Time,Temperature (C),Air Flow (sccm),Air Setpoint (sccm),Hydrogen Flow (sccm),Hydrogen Setpoint (sccm)" & vbCr, True)
                firsttime = firsttime + 1
            Else
                MessageBox.Show("Error: no filename selected. Please try again.")
                SaveCheck.Checked = 0
            End If
        End If
        PollingTimer.Start()
    End Sub

    Private Sub Shutoff_Click(sender As System.Object, e As System.EventArgs) Handles Off.Click
        If MessageBox.Show("Has the reactor been cooled to room temperature?", "Confirm Reactor Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            AirAdjust.Value = 0
            'Wait for air to purge (1 min)
            MessageBox.Show("Click OK to purge system for 10 seconds before hydrogen is shut off")
            Thread.Sleep(10000)
            H2Adjust.Value = 0
        End If
    End Sub

    Private Sub Run_Click(sender As Object, e As EventArgs) Handles Run.Click
        'If H2 carrier is selected use those flows instead
        If H2Carrier.CheckState() Then
            H2Adjust.Value = 40
            If version.Equals("MEMS") Then
                Thread.Sleep(100)
            End If
            AirAdjust.Value = airWithH2
        Else
            H2Adjust.Value = 35
            If version.Equals("MEMS") Then
                Thread.Sleep(100)
            End If
            AirAdjust.Value = 2.5
        End If
    End Sub

    Private Sub Tare_Click(sender As Object, e As EventArgs) Handles Tare.Click
        'Need to zero out flows, send tare command and show progress bar to prevent other user action
        If MessageBox.Show("Are you sure you want to set the flow rates to 0 and tare your device? Please cancel the operation if the Polyarc is still above 50C.", "Auto-tare Operation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Ok Then
            AirAdjust.Value = 0
            MessageBox.Show("Click OK to purge system for 10 seconds and then complete the autotare. The process will take 30 seconds to complete.")
            Thread.Sleep(10000)
            H2Adjust.Value = 0
            Thread.Sleep(1000)
            If version.Equals("MEMS") Then
                SerialWrapper.Transact("a$$V")
                Thread.Sleep(1000)
                SerialWrapper.Transact("h$$V")
                Thread.Sleep(1000)
            End If
            Thread.Sleep(30000)
            MessageBox.Show("Auto-tare complete! Please change flows to desired values or select Run")
        End If
    End Sub

    Private Sub H2Carrier_CheckedChanged(sender As Object, e As EventArgs) Handles H2Carrier.CheckedChanged
        If H2Carrier.CheckState() Then
            'If checking for the first time, send new flows for H2 carrier. Ask user for flow values. 
            Dim response = MessageBox.Show("If your hydrogen carrier flow rate <1.05 sccm, select YES." & vbCr & "If it is between 1.05-2.1 sccm, select NO?" & vbCr & vbCr & "If it is outside of these ranges, contact ARC.​", "Hydrogen carrier gas flow rate configuration menu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                airWithH2 = 5.0
                H2Adjust.Value = 40
                If version.Equals("MEMS") Then
                    Thread.Sleep(100)
                End If
                AirAdjust.Value = airWithH2
            ElseIf response = MsgBoxResult.No Then
                airWithH2 = 7.5
                H2Adjust.Value = 40
                If version.Equals("MEMS") Then
                    Thread.Sleep(100)
                End If
                AirAdjust.Value = airWithH2
            Else
                H2Carrier.Checked = False
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.activatedresearch.com")
    End Sub

    Private Sub UserManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManualToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.activatedresearch.com/Documents/")
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        MessageBox.Show("1. Select the COM port created by the USB connection." & Chr(13) &
                        "2. Manually change flows in the setpoint boxes, or use the buttons on the right for quick control." & Chr(13) &
                        "3. Adjust the refresh rate and number of points shown on the graph as needed." & Chr(13) &
                        "4. Data can be saved to a comma-separated text file use the checkbox." & Chr(13) &
                        "5. If you are using hydrogen as a carrier gas, please select the checkbox and then 'Run' to adjust the flow rates accordingly.")
    End Sub

    Private Sub AboutPolyarcFCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPolyarcFCToolStripMenuItem.Click
        MessageBox.Show("Polyarc Flow Control" & Chr(13) & "Version 5.0" & Chr(13) & Chr(169) & " 2016 Activated Research Company, LLC." & Chr(13) & "All rights reserved.")
    End Sub
End Class