Option Strict On
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Module udp_Receive
    Dim UDPClient As UdpClient = New UdpClient() ' Object to do the UDP communication.
    Public ThreadReceive As System.Threading.Thread ' Setup a thread to listen for the receiving data so the form UI does not hang waiting for it.
    Public strRecError As String ' Displayed on the form when errors occur.
    Public strReturnData As String ' What is displayed on the form as a recevied message
    Dim iepRemoteEndPoint As IPEndPoint ' Used to setup the exact ip and port to listen on
    Private strLocalReceivingIP As String
    Private intLocalPort As Integer

    Public Sub connect(localIP As String, port As Integer)
        Try
            strLocalReceivingIP = localIP
            intLocalPort = port

            UDPClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, True)
            'UDPClient.Client.ReceiveTimeout = 2500 ' 2.5 second timeout waiting for data.
            UDPClient.Client.Bind(New IPEndPoint(IPAddress.Parse(localIP), port))

            iepRemoteEndPoint = New System.Net.IPEndPoint(System.Net.IPAddress.Parse(strLocalReceivingIP), intLocalPort)

        Catch e As Exception

            Form1.ToolStripStatusLabel1.Text = "Error setting up receive: " + e.ToString()
        End Try
    End Sub
    ' Send the remote address we are receiving from and port number.
    Public Sub receive()

        ' Setup a new processing thread in the program. 
        ThreadReceive = New System.Threading.Thread(AddressOf ReceiveMessages) ' Goes to the function 'ReceiveMessages' as a new thread.
        ThreadReceive.Start() ' Now Spawn

    End Sub

    ' The receiving thread goes here to get messages
    Private Function ReceiveMessages() As Boolean

        ' Check if we are shutting down the thread
        If checkThreadShutdown() = True Then
            Return False
        End If

        Try
            Dim bytesReceived As Byte() = UDPClient.Receive(iepRemoteEndPoint) ' When shutting down the program, this is going to generate an error "A first chance exception of type 'System.Net.Sockets.SocketException' occurred in System.dll" since it is stuck waiting for data to come in. To get around this, Remake the program to use events properly with async calls instead.

            ' Check if we are shutting down the thread
            If checkThreadShutdown() = True Then
                Return False
            End If

            Dim BitDet As BitArray
            BitDet = New BitArray(bytesReceived)

            ' Decode from binary to ASCII, since it was encode from ASCII.
            ' Assign the received text to a variable for the form1 timer tick to pick up.
            strReturnData = System.Text.Encoding.ASCII.GetString(bytesReceived)
            Return True

        Catch err As System.Net.Sockets.SocketException ' Should?? fire when thread is shutting down(like when the program is exiting), because the UDPClient.Receive(iepRemoteEndPoint) above was waiting for data.
            ' Might never fire due to thread shutting all of this down

            ' Mark a variable that we have an error here.
            strRecError = err.ToString()
            Return False
        Catch ex As Exception
            ' The following will not work since the UI is on another thread.
            'Form1.ToolStripStatusLabel1.Text = "Error Receiving: " + ex.ToString()

            ' Mark a variable that we have an error here.
            strRecError = ex.ToString()
            Return False
        End Try

    End Function
    Private Function checkThreadShutdown() As Boolean
        If Form1.blnEndingProgram = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub closeConnection()

        If ThreadReceive.IsAlive = True Then
            'ThreadReceive.Abort() ' Correct as a catch? Thread is checking to shutdown too.
        End If

        ' Close up the UDP Socket
        ' Will spawn an error as we aborted the receive socket that was stuck waiting for more data. Version 2 will use UDPClient.BeginReceive
        UDPClient.Close()
    End Sub
End Module
