Option Strict On
Imports System.Net.Sockets
Imports System.Text
Module udp_Send
    Dim UDPClient As UdpClient
    Dim bytesSent As Byte() = New Byte() {}

    ' Make a connection before use.
    Public Sub connect(url As String, port As Integer)
        Try
            UDPClient = New UdpClient
            UDPClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)

            UDPClient.Connect(url, port)

        Catch e As Exception

            Form1.ToolStripStatusLabel1.Text = "Error setting up send: " + e.ToString()
        End Try
    End Sub
    ' Send a string message
    Public Sub send(msg As String)
        Try
            ' Encode the string as binary bytes to send
            bytesSent = Encoding.ASCII.GetBytes(msg)

            ' Send it over UDP
            UDPClient.Send(bytesSent, bytesSent.Length)

        Catch e As Exception

            Form1.ToolStripStatusLabel1.Text = "Error Sending: " + e.ToString()
        End Try
    End Sub
      
    Public Sub closeConnection()
        UDPClient.Close()
    End Sub

End Module
