<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COM))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.COMPort = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(83, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Select COM Port"
        '
        'COMPort
        '
        Me.COMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.COMPort.FormattingEnabled = True
        Me.COMPort.Location = New System.Drawing.Point(99, 71)
        Me.COMPort.Name = "COMPort"
        Me.COMPort.Size = New System.Drawing.Size(99, 33)
        Me.COMPort.TabIndex = 11
        '
        'COM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 154)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.COMPort)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "COM"
        Me.Text = "Select your COM port"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents COMPort As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
