Option Strict On

Imports System.Net

Public Class Form1
    Public blnEndingProgram As Boolean = False
    Private intDefaultPort As Integer = 11111

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' Disable the timer on the Key Logger
        'keyStrokes.timer1.Enabled = False

        ' Let the threads see that we are shutting down so they can do so themselves
        blnEndingProgram = True

        ' Safely close up connections.
        udp_Receive.closeConnection()
        udp_Send.closeConnection()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        udp_Receive.connect("0.0.0.0", intDefaultPort) ' 0.0.0.0 means to listen on ALL IP addresses
        udp_Send.connect("127.0.0.1", intDefaultPort) ' By default, send on Localhost, aka 127.0.0.1

        ' If all is good, start listening for messages
        udp_Receive.receive()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' Clear the error display area
        ToolStripStatusLabel1.Text = ""

        If txtInput.Text <> "" Then
            ' Send message
            udp_Send.send(txtInput.Text + vbCrLf)

            ' clear the input box
            txtInput.Text = ""

            
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Not udp_Receive.ThreadReceive.IsAlive And udp_Receive.strReturnData <> "" Then

            ' Assign the newly received data to the form1 textbox.
            txtRecMsg.Text += udp_Receive.strReturnData

            ' Restart the Receiving Thread to get more data
            ' Check if we are shutting down the threads to end the program
            If blnEndingProgram = False Then
                udp_Receive.receive()
            End If

        End If

        ' Look for any errors and display in the status bar.
        If udp_Receive.strRecError <> "" Then
            ToolStripStatusLabel1.Text = udp_Receive.strRecError
            udp_Receive.strRecError = "" ' Clear old error

            ' Restart the Receiving Thread to get more data, if we are not shutting down the threads to end the program
            If blnEndingProgram = False And Not udp_Receive.ThreadReceive.IsAlive Then
                udp_Receive.receive() ' Restart if it was not started above after receiving a normal text message
            End If


        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub SendChatMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendChatMessageToolStripMenuItem.Click

        ' Set Checkmarks in the Menu
        SendChatMessageToolStripMenuItem.Checked = True
        SendKeyStrokesToolStripMenuItem.Checked = False

        ' Disable the timer on the Key Logger
        keyStrokes.timer1.Enabled = False

        ' Enable the submit button
        btnSubmit.Enabled = True

    End Sub

    Private Sub SendKeyStrokesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendKeyStrokesToolStripMenuItem.Click

        ' Set Checkmarks in the Menu
        SendChatMessageToolStripMenuItem.Checked = False
        SendKeyStrokesToolStripMenuItem.Checked = True

        ' Enable the timer on the Key Logger
        keyStrokes.timer1.Enabled = True

        ' Disable the submit button
        btnSubmit.Enabled = False


    End Sub

    Private Sub LocalHostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalHostToolStripMenuItem.Click

        LocalHostToolStripMenuItem.Checked = True
        NetworkAddressToolStripMenuItem.Checked = False

        ' Close any working connections
        udp_Send.closeConnection()

        ' Make new connection with new settings
        udp_Send.connect("127.0.0.1", intDefaultPort)

    End Sub

    Private Sub NetworkAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NetworkAddressToolStripMenuItem.Click

        If blnValidateAddress(ToolStripTextBoxIP.Text) = False Then
            MsgBox("Please check the entry. IP or DNS resolve of the Host Name has failed.")
        Else

            NetworkAddressToolStripMenuItem.Checked = True
            LocalHostToolStripMenuItem.Checked = False

            ' Close any working connections
            udp_Send.closeConnection()

            ' Make new connection with new settings
            udp_Send.connect(ToolStripTextBoxIP.Text, 11111)
        End If
        
    End Sub

    Private Function blnValidateAddress(ByVal strAddress As String) As Boolean

        ' No blank addresses allowed
        If strAddress = "" Then Return False

        Dim host As New Net.IPHostEntry

        Try
            ' Check passed string if it is a valid address or IP
            host = Dns.GetHostEntry(strAddress) ' Issue #2: This is returning an IP for me, resolving to a Time Warner Cable IP website dealing with unknown domain names. In other words, Timer Warner is hijacking bad DNS resolves, so this function is not working as expected. It could be fixed if we could specify a DNS resolver, but the .net framework does not seem to allow it.

        Catch ex As System.Net.Sockets.SocketException ' Catch unknown host names
            MsgBox(ex.Message)
            Return False
        Catch ex1 As System.ArgumentException
            MsgBox(ex1.Message)
            Return False
        Catch ex2 As Exception
            MsgBox(ex2.Message)
            Return False
        End Try

        ' If we reached here, we should have a good DNS resolve
        Return True


    End Function

    Private Sub SethsProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SethsProgramToolStripMenuItem.Click
        MsgBox("Seth's Visual Basic Final, Summer 2016")
    End Sub

    ' Issue #1: Trying to use the built in Validating event subroutines did not work. Why offer them for the menu items when they don't fire???
    ' So Validate it on losing the focus in the textbox.
    Private Sub ToolStripTextBoxIP_LostFocus(sender As Object, e As EventArgs) Handles ToolStripTextBoxIP.LostFocus

        If ToolStripTextBoxIP.Text <> "" And blnValidateAddress(ToolStripTextBoxIP.Text) = False Then

            MsgBox("Please check the entry. The IP is incorrect or the DNS resolve of the Host Name has failed.")

            ' Select the text to retype
            ToolStripTextBoxIP.Select(0, ToolStripTextBoxIP.Text.Length)

            ErrorProvider1.SetError(MenuStrip1, "Invalid remote IP or DNS Host Name")
        End If

    End Sub

    Private Sub TutorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorialToolStripMenuItem.Click
        ' Open browser to view this program information
        Process.Start("https://docs.google.com/document/d/1o8sQjMvdmgObgAFaWsAHn_voqwbGvqGax0u6ZUuvo4Y/edit?usp=sharing")
    End Sub
End Class
