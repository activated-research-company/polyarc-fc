<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.COMPort = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShutDown = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HydrogenChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.StopPolling = New System.Windows.Forms.CheckBox()
        Me.AirChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HydrogenChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(537, 91)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 62)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Write"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'COMPort
        '
        Me.COMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.COMPort.FormattingEnabled = True
        Me.COMPort.Location = New System.Drawing.Point(849, 123)
        Me.COMPort.Margin = New System.Windows.Forms.Padding(4)
        Me.COMPort.Name = "COMPort"
        Me.COMPort.Size = New System.Drawing.Size(160, 33)
        Me.COMPort.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(79, 91)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(445, 66)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RichTextBox2.Location = New System.Drawing.Point(79, 190)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(445, 117)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(73, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(73, 161)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Output"
        '
        'ShutDown
        '
        Me.ShutDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ShutDown.Location = New System.Drawing.Point(849, 227)
        Me.ShutDown.Margin = New System.Windows.Forms.Padding(4)
        Me.ShutDown.Name = "ShutDown"
        Me.ShutDown.Size = New System.Drawing.Size(162, 62)
        Me.ShutDown.TabIndex = 8
        Me.ShutDown.Text = "Shut Down"
        Me.ShutDown.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(672, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select COM Port"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SerialCom.My.Resources.Resources.ARC_Full_Logo__print_
        Me.PictureBox1.Location = New System.Drawing.Point(767, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'HydrogenChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.HydrogenChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.HydrogenChart.Legends.Add(Legend1)
        Me.HydrogenChart.Location = New System.Drawing.Point(77, 439)
        Me.HydrogenChart.Margin = New System.Windows.Forms.Padding(4)
        Me.HydrogenChart.Name = "HydrogenChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.HydrogenChart.Series.Add(Series1)
        Me.HydrogenChart.Size = New System.Drawing.Size(932, 116)
        Me.HydrogenChart.TabIndex = 12
        '
        'StopPolling
        '
        Me.StopPolling.AutoSize = True
        Me.StopPolling.CausesValidation = False
        Me.StopPolling.Location = New System.Drawing.Point(849, 176)
        Me.StopPolling.Name = "StopPolling"
        Me.StopPolling.Size = New System.Drawing.Size(105, 21)
        Me.StopPolling.TabIndex = 13
        Me.StopPolling.Text = "Stop Polling"
        Me.StopPolling.UseVisualStyleBackColor = True
        '
        'AirChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.AirChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.AirChart.Legends.Add(Legend2)
        Me.AirChart.Location = New System.Drawing.Point(77, 315)
        Me.AirChart.Margin = New System.Windows.Forms.Padding(4)
        Me.AirChart.Name = "AirChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.AirChart.Series.Add(Series2)
        Me.AirChart.Size = New System.Drawing.Size(932, 116)
        Me.AirChart.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1060, 554)
        Me.Controls.Add(Me.AirChart)
        Me.Controls.Add(Me.StopPolling)
        Me.Controls.Add(Me.HydrogenChart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShutDown)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.COMPort)
        Me.Controls.Add(Me.Button2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HydrogenChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents COMPort As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShutDown As System.Windows.Forms.Button
    'Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HydrogenChart As DataVisualization.Charting.Chart
    Friend WithEvents StopPolling As CheckBox
    Friend WithEvents AirChart As DataVisualization.Charting.Chart
End Class
