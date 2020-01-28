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
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Off = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.FlowChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPolyarcFCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SaveCheck = New System.Windows.Forms.CheckBox()
        Me.GraphPoints = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RefreshTime = New System.Windows.Forms.NumericUpDown()
        Me.Tare = New System.Windows.Forms.Button()
        Me.Run = New System.Windows.Forms.Button()
        Me.H2Carrier = New System.Windows.Forms.CheckBox()
        Me.AirAdjust = New System.Windows.Forms.NumericUpDown()
        Me.H2Adjust = New System.Windows.Forms.NumericUpDown()
        Me.H2FlowBox = New System.Windows.Forms.RichTextBox()
        Me.AirFlowBox = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StopPolling = New System.Windows.Forms.CheckBox()
        CType(Me.FlowChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GraphPoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.H2Adjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Off
        '
        Me.Off.AutoSize = True
        Me.Off.BackColor = System.Drawing.Color.Gray
        Me.Off.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Off.ForeColor = System.Drawing.Color.White
        Me.Off.Location = New System.Drawing.Point(755, 302)
        Me.Off.Name = "Off"
        Me.Off.Size = New System.Drawing.Size(201, 38)
        Me.Off.TabIndex = 8
        Me.Off.Text = "Turn off all flows"
        Me.Off.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 38400
        Me.SerialPort1.PortName = "COM6"
        '
        'FlowChart
        '
        Me.FlowChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(169, Byte), Integer))
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisX.IsStartedFromZero = False
        ChartArea1.AxisX.LabelAutoFitMinFontSize = 10
        ChartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LabelStyle.Format = "hh:mm"
        ChartArea1.AxisX.LabelStyle.Interval = 0R
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX.MaximumAutoSize = 10.0!
        ChartArea1.AxisX.Title = "Time"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Arial", 14.0!)
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.Interval = 10.0R
        ChartArea1.AxisY.LabelAutoFitMaxFontSize = 14
        ChartArea1.AxisY.LabelAutoFitMinFontSize = 10
        ChartArea1.AxisY.LabelAutoFitStyle = CType(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
            Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Interval = 0R
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.Maximum = 60.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.AxisY.Title = "Hydrogen Flow (sccm)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Arial", 14.0!)
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.IsLabelAutoFit = False
        ChartArea1.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ChartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.Maximum = 15.0R
        ChartArea1.AxisY2.Minimum = 0R
        ChartArea1.AxisY2.Title = "Air Flow (sccm)"
        ChartArea1.AxisY2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.CursorX.AxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.FlowChart.ChartAreas.Add(ChartArea1)
        Me.FlowChart.Cursor = System.Windows.Forms.Cursors.Cross
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Name = "Legend1"
        Me.FlowChart.Legends.Add(Legend1)
        Me.FlowChart.Location = New System.Drawing.Point(17, 166)
        Me.FlowChart.Name = "FlowChart"
        Series1.BackImage = "C:\Users\Andrew\Dropbox\A.R.C\Graphics\Logo\ARC Full Logo (print).jpg"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.EmptyPointStyle.AxisLabel = "Time"
        Series1.EmptyPointStyle.BackImage = "C:\Users\Andrew\Dropbox\A.R.C\Graphics\Logo\ARC Full Logo (print).jpg"
        Series1.Font = New System.Drawing.Font("Arial", 14.0!)
        Series1.Legend = "Legend1"
        Series1.Name = "Hydrogen"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Series2.Legend = "Legend1"
        Series2.Name = "Air"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Me.FlowChart.Series.Add(Series1)
        Me.FlowChart.Series.Add(Series2)
        Me.FlowChart.Size = New System.Drawing.Size(689, 393)
        Me.FlowChart.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(281, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Actual (sccm)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Setpoint (sccm)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Air (sccm)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "H  (sccm)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.UserManualToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPolyarcFCToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutPolyarcFCToolStripMenuItem
        '
        Me.AboutPolyarcFCToolStripMenuItem.Name = "AboutPolyarcFCToolStripMenuItem"
        Me.AboutPolyarcFCToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.AboutPolyarcFCToolStripMenuItem.Text = "About PolyarcFC"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.UserManualToolStripMenuItem.Text = "User Manual"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(715, 561)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(280, 25)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.activatedresearch.com"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveCheck
        '
        Me.SaveCheck.AutoSize = True
        Me.SaveCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCheck.Location = New System.Drawing.Point(476, 139)
        Me.SaveCheck.Name = "SaveCheck"
        Me.SaveCheck.Size = New System.Drawing.Size(93, 21)
        Me.SaveCheck.TabIndex = 22
        Me.SaveCheck.Text = "Save Data"
        Me.SaveCheck.UseVisualStyleBackColor = True
        '
        'GraphPoints
        '
        Me.GraphPoints.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphPoints.Location = New System.Drawing.Point(123, 565)
        Me.GraphPoints.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.GraphPoints.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.GraphPoints.Name = "GraphPoints"
        Me.GraphPoints.Size = New System.Drawing.Size(72, 24)
        Me.GraphPoints.TabIndex = 23
        Me.GraphPoints.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 569)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Graph Points"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(230, 569)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Refresh rate (s)"
        '
        'RefreshTime
        '
        Me.RefreshTime.DecimalPlaces = 1
        Me.RefreshTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshTime.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RefreshTime.Location = New System.Drawing.Point(345, 565)
        Me.RefreshTime.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.RefreshTime.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.RefreshTime.Name = "RefreshTime"
        Me.RefreshTime.Size = New System.Drawing.Size(65, 24)
        Me.RefreshTime.TabIndex = 26
        Me.RefreshTime.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'Tare
        '
        Me.Tare.AutoSize = True
        Me.Tare.BackColor = System.Drawing.Color.DarkRed
        Me.Tare.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Tare.ForeColor = System.Drawing.Color.White
        Me.Tare.Location = New System.Drawing.Point(791, 346)
        Me.Tare.Name = "Tare"
        Me.Tare.Size = New System.Drawing.Size(128, 38)
        Me.Tare.TabIndex = 27
        Me.Tare.Text = "Auto-tare"
        Me.Tare.UseVisualStyleBackColor = False
        '
        'Run
        '
        Me.Run.AutoSize = True
        Me.Run.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Run.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Run.ForeColor = System.Drawing.Color.White
        Me.Run.Location = New System.Drawing.Point(740, 182)
        Me.Run.Name = "Run"
        Me.Run.Size = New System.Drawing.Size(230, 70)
        Me.Run.TabIndex = 28
        Me.Run.Text = "Run"
        Me.Run.UseVisualStyleBackColor = False
        '
        'H2Carrier
        '
        Me.H2Carrier.AutoSize = True
        Me.H2Carrier.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H2Carrier.Location = New System.Drawing.Point(775, 155)
        Me.H2Carrier.Name = "H2Carrier"
        Me.H2Carrier.Size = New System.Drawing.Size(161, 21)
        Me.H2Carrier.TabIndex = 30
        Me.H2Carrier.Text = "Hydrogen Carrier Gas"
        Me.H2Carrier.UseVisualStyleBackColor = True
        '
        'AirAdjust
        '
        Me.AirAdjust.DecimalPlaces = 1
        Me.AirAdjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirAdjust.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.AirAdjust.Location = New System.Drawing.Point(149, 117)
        Me.AirAdjust.Margin = New System.Windows.Forms.Padding(2)
        Me.AirAdjust.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.AirAdjust.Name = "AirAdjust"
        Me.AirAdjust.Size = New System.Drawing.Size(124, 38)
        Me.AirAdjust.TabIndex = 16
        '
        'H2Adjust
        '
        Me.H2Adjust.DecimalPlaces = 1
        Me.H2Adjust.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H2Adjust.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.H2Adjust.Location = New System.Drawing.Point(149, 74)
        Me.H2Adjust.Margin = New System.Windows.Forms.Padding(2)
        Me.H2Adjust.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.H2Adjust.Name = "H2Adjust"
        Me.H2Adjust.Size = New System.Drawing.Size(124, 38)
        Me.H2Adjust.TabIndex = 15
        '
        'H2FlowBox
        '
        Me.H2FlowBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H2FlowBox.Location = New System.Drawing.Point(277, 74)
        Me.H2FlowBox.Margin = New System.Windows.Forms.Padding(2)
        Me.H2FlowBox.Name = "H2FlowBox"
        Me.H2FlowBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.H2FlowBox.Size = New System.Drawing.Size(124, 39)
        Me.H2FlowBox.TabIndex = 17
        Me.H2FlowBox.Text = ""
        '
        'AirFlowBox
        '
        Me.AirFlowBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirFlowBox.Location = New System.Drawing.Point(277, 117)
        Me.AirFlowBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AirFlowBox.Name = "AirFlowBox"
        Me.AirFlowBox.Size = New System.Drawing.Size(124, 39)
        Me.AirFlowBox.TabIndex = 17
        Me.AirFlowBox.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 12)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SerialCom.My.Resources.Resources.ARC_Full_Logo__print_
        Me.PictureBox2.Location = New System.Drawing.Point(715, 421)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(280, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'StopPolling
        '
        Me.StopPolling.AutoSize = True
        Me.StopPolling.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopPolling.Location = New System.Drawing.Point(586, 139)
        Me.StopPolling.Name = "StopPolling"
        Me.StopPolling.Size = New System.Drawing.Size(66, 21)
        Me.StopPolling.TabIndex = 35
        Me.StopPolling.Text = "Pause"
        Me.StopPolling.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 599)
        Me.Controls.Add(Me.StopPolling)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AirFlowBox)
        Me.Controls.Add(Me.H2FlowBox)
        Me.Controls.Add(Me.H2Adjust)
        Me.Controls.Add(Me.AirAdjust)
        Me.Controls.Add(Me.H2Carrier)
        Me.Controls.Add(Me.Run)
        Me.Controls.Add(Me.Tare)
        Me.Controls.Add(Me.RefreshTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GraphPoints)
        Me.Controls.Add(Me.SaveCheck)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FlowChart)
        Me.Controls.Add(Me.Off)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Polyarc Flow Control"
        CType(Me.FlowChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GraphPoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.H2Adjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Off As System.Windows.Forms.Button
    'Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents FlowChart As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SaveCheck As CheckBox
    Friend WithEvents GraphPoints As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RefreshTime As NumericUpDown
    Friend WithEvents Tare As Button
    Friend WithEvents Run As Button
    Friend WithEvents H2Carrier As CheckBox
    Friend WithEvents AirAdjust As NumericUpDown
    Friend WithEvents H2Adjust As NumericUpDown
    Friend WithEvents H2FlowBox As RichTextBox
    Friend WithEvents AirFlowBox As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutPolyarcFCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopPolling As CheckBox
End Class
