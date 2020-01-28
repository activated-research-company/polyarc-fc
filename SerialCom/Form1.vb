Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form1

    Dim PortArray As Array
    Dim PollingFrequency As New Int16
    Dim WithEvents PollingTimer As New System.Windows.Forms.Timer With {.Interval = 1000}

    Private Poll As New PollingResults.Poll

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PortArray = IO.Ports.SerialPort.GetPortNames()

        COMPort.Items.Add(String.Empty)
        COMPort.Items.AddRange(PortArray)

        Button2.Enabled = False
        StopPolling.Enabled = False
        ShutDown.Enabled = False

        AirChart.Legends.Add("Air Flow Rate")
        AirChart.Series.Add("AirFlow")
        AirChart.Series("AirFlow").ChartType = DataVisualization.Charting.SeriesChartType.Line
        AirChart.Series("AirFlow").XValueType = DataVisualization.Charting.ChartValueType.Time
        AirChart.Series("AirFlow").LabelFormat = "HH:ss"
        HydrogenChart.Legends.Add("Hydrogen Flow Rate")
        HydrogenChart.Series.Add("HydrogenFlow")
        HydrogenChart.Series("HydrogenFlow").ChartType = DataVisualization.Charting.SeriesChartType.Line
        HydrogenChart.Series("HydrogenFlow").XValueType = DataVisualization.Charting.ChartValueType.Time
        HydrogenChart.Series("HydrogenFlow").LabelFormat = "HH:ss"

    End Sub

    Private Sub PollingTimer_Expire() Handles PollingTimer.Tick

        If StopPolling.Checked Then Exit Sub

        Dim returnStr As String = Communicate("A", 31)

        If returnStr.Length <> 31 Then Exit Sub

        Dim AirFlow, HydrogenFLow As Decimal

        Dim Elements As String() = System.Text.RegularExpressions.Regex.Split(returnStr, "\s+")
        RichTextBox2.Text = Now.ToString() & System.Environment.NewLine
        RichTextBox2.Text &= Elements(1) & System.Environment.NewLine
        RichTextBox2.Text &= Elements(2) & System.Environment.NewLine
        RichTextBox2.Text &= Elements(3)

        AirFlow = Convert.ToDecimal(Elements(2).Substring(0, 6))

        returnStr = Communicate("H", 31)

        Elements = System.Text.RegularExpressions.Regex.Split(returnStr, "\s+")
        RichTextBox2.Text &= Elements(1) & System.Environment.NewLine
        RichTextBox2.Text &= Elements(2) & System.Environment.NewLine
        RichTextBox2.Text &= Elements(3)

        HydrogenFLow = Convert.ToDecimal(Elements(2).Substring(0, 6))

        Poll.NewResult(Now.ToString(),
                       AirFlow,
                       HydrogenFLow,
                       Convert.ToDecimal(Elements(1).Substring(0, 3)))

        AirChart.Series("AirFlow").Points.AddXY(Poll.LastResult.TimeStamp, Poll.LastResult.AirFlow)
        HydrogenChart.Series("HydrogenFlow").Points.AddXY(Poll.LastResult.TimeStamp, Poll.LastResult.HydrogenFlow)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Communicate(RichTextBox1.Text, 13)

    End Sub

    Private Function Communicate(ByVal InputString As String,
                                 ByVal ExpectedOutputLength As Int16) As String

        PollingTimer.Stop()

        SerialPort1.Write(InputString & vbCr) 'concatenate with \n

        Threading.Thread.Sleep(150)

        Dim returnStr As String = ""

        Dim Start As DateTime = Now

        Do

            If Start.AddSeconds(5) < Now Then
                returnStr = "Error: Serial Port read timed out."

                MessageBox.Show("There was a problem during communication with the device." & System.Environment.NewLine & System.Environment.NewLine &
                    "Is the device plugged in?" & System.Environment.NewLine &
                    "Is the device switched on?" & System.Environment.NewLine &
                    "Are the cables properly attached between the device and computer?" & System.Environment.NewLine &
                    "Did you select the correct COM port?" & System.Environment.NewLine &
                    "Are the device drivers installed correctly?",
                    "Communication Failure")

                StopPolling.Checked = True
                SerialPort1.Close()
                COMPort.Text = ""

                Exit Do
            End If

            Dim Incoming As String = SerialPort1.ReadExisting()
            If returnStr <> "" AndAlso (Incoming Is Nothing OrElse Incoming = String.Empty) Then
                Exit Do
            Else
                returnStr &= Incoming.Trim
            End If

        Loop While returnStr.Length < ExpectedOutputLength

        PollingTimer.Start()

        Return returnStr

    End Function

    Private Sub ShutDown_Click(sender As System.Object, e As System.EventArgs) Handles ShutDown.Click

        StopPolling.Enabled = False
        StopPolling.Checked = True

        RichTextBox2.Text = Communicate("A0", 13)
        RichTextBox2.Text = Communicate("H0", 13)

        StopPolling.Checked = False

    End Sub

    Private Sub COMPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMPort.SelectedIndexChanged

        If COMPort.Text = String.Empty Then Exit Sub

        SerialPort1.PortName = COMPort.Text
        SerialPort1.BaudRate = 38400
        SerialPort1.Open()

        Button2.Enabled = True
        ShutDown.Enabled = True
        StopPolling.Enabled = True
        StopPolling.Checked = False

        PollingTimer.Start()

        Poll.NewResult(Now, 0, 0, 0)

    End Sub

End Class
