Imports System.IO.Ports

Public Class SerialWrapper
	Private ReadOnly _locker As New Object()
	Private ReadOnly _serialPort As SerialPort

	Public Sub New(comPort As String, baudRate As Integer, timeOut As TimeSpan)
		_serialPort = New SerialPort(comPort, baudRate, Parity.None, 8, StopBits.One)
			_serialPort.NewLine = vbCr
			_serialPort.ReadTimeout = CInt(Math.Truncate(timeOut.TotalMilliseconds))
			_serialPort.WriteTimeout = CInt(Math.Truncate(timeOut.TotalMilliseconds))
			_serialPort.Handshake = Handshake.None
			_serialPort.DtrEnable = True
			_serialPort.RtsEnable = True
			_serialPort.ReceivedBytesThreshold = 1
		_serialPort.Open()
	End Sub

    Public Function Transact(toSend As String) As String
        SyncLock _locker
            _serialPort.DiscardInBuffer()
            _serialPort.DiscardOutBuffer()
            _serialPort.WriteLine(toSend)
            Return _serialPort.ReadLine()
        End SyncLock
    End Function

    Public Function Close() As String
        _serialPort.Close()
        Return "Serial Port is Closed"
    End Function
End Class
