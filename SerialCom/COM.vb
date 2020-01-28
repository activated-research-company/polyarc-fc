Public Class COM
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        COMPort.Items.AddRange(IO.Ports.SerialPort.GetPortNames())
    End Sub

    Private Sub COMPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMPort.SelectedIndexChanged
        If COMPort.Text = String.Empty Then Exit Sub
        'setup serial port name and close box
        SerialPort1.PortName = COMPort.Text
        Me.Hide()
    End Sub
End Class