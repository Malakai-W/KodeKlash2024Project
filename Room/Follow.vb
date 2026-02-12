' This was cut out from the final project and is not used; kept it here though to archive it.
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmFollow
    Private Sub frmFollow_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads what needs to visible and not

        ' Plays music in the background
        My.Computer.Audio.Play("M:\KodeKlash\TM 02\Room\Room\Resources\pixelsong.wav",
        AudioPlayMode.BackgroundLoop)

        ' Makes images invisible
        pbCharEnd.Visible = False
        pbChar2.Visible = False
        pbChar3.Visible = False
        pbCharDown.Visible = False
        pbCharUp.Visible = False
        pbLeftDown.Visible = False
        pbLeftUp.Visible = False
        pbDeadEnd.Visible = False
        pbRightDown.Visible = False
        pbRightUp.Visible = False
    End Sub

    Private Sub frmFollow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Moves the player's character

        ' Declares variables
        Static intArea As Integer = 1
        Static intChar As Integer = 1
        Static intPerson As Integer

        ' Checks which area the player is in
        Select Case True
            Case intArea = 1
                ' Checks where the player is
                If intChar = 1 Then ' Will check which key is pressed & makes pictureboxes invisible and visible (code for other case & if statements is practically the same)
                    If e.KeyChar = "D" Or e.KeyChar = "d" Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar1.Visible = False
                        pbChar2.Visible = True
                    End If
                ElseIf intChar = 2 Then
                    If e.KeyChar = "D" Or e.KeyChar = "d" Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar2.Visible = False
                        pbChar3.Visible = True
                    ElseIf e.KeyChar = "A" Or e.KeyChar = "a" Then
                        intChar -= 1 ' Subtracts 1 from intChar
                        pbChar1.Visible = True
                        pbChar2.Visible = False
                    End If
                ElseIf intChar = 3 Then
                    If e.KeyChar = "D" Or e.KeyChar = "d" Then
                        intChar = 1 ' Makes the value of intChar 1
                        intArea += 1 ' Adds 1 to intArea
                        pbChar3.Visible = False
                        pbChar1.Visible = True
                        pbDeadEnd.Visible = True
                        pbDown.Visible = False
                        pbLeftDown.Visible = True
                        pbRightDown.Visible = True
                        pbStart.Visible = False
                    ElseIf e.KeyChar = "A" Or e.KeyChar = "a" Then
                        intChar -= 1 ' Substracts 1 from intChar
                        pbChar2.Visible = True
                        pbChar3.Visible = False
                    End If
                End If
            Case intArea = 2
                If intChar = 1 Then ' Will check which key is pressed & makes pictureboxes invisible and visible (code for other case & if statements is practically the same)
                    If e.KeyChar = "D" Or e.KeyChar = "d" Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar1.Visible = False
                        pbChar2.Visible = True
                    ElseIf e.KeyChar = "A" Or e.KeyChar = "a" Then
                        intChar = 3 ' Makes the value of intChar 3
                        intArea -= 1 ' Subtracts 1 from intArea
                        pbChar3.Visible = True
                        pbChar1.Visible = False
                        pbDeadEnd.Visible = False
                        pbDown.Visible = True
                        pbLeftDown.Visible = False
                        pbRightDown.Visible = False
                        pbStart.Visible = True
                    End If
                ElseIf intChar = 2 Then
                    If e.KeyChar = “D” Or e.KeyChar = “d” Then
                        intChar += 1 ' adds 1 to intChar
                        pbChar2.Visible = False
                        pbChar3.Visible = True
                    ElseIf e.KeyChar = “A” Or e.KeyChar = “a” Then
                        intChar -= 1 ' Subtracts 1 from intChar
                        pbChar2.Visible = False
                        pbChar1.Visible = True
                    ElseIf e.KeyChar = “S” Or e.KeyChar = “s” Then
                        intChar = 4 ' Sets intChar to 4
                        pbChar2.Visible = False
                        pbCharDown.Visible = True
                    End If
                ElseIf intChar = 3 Then
                    If e.KeyChar = "A" Or e.KeyChar = "a" Then
                        pbChar2.Visible = True
                        pbChar3.Visible = False
                        intChar -= 1 ' Subtracts 1 from intChar
                    End If
                ElseIf intChar = 4 Then ' Player is at pbChar.Down
                    If e.KeyChar = "S" Or e.KeyChar = "s" Then
                        intArea += 1 ' Adds 1 to intArea
                        intChar = 1 ' Sets intChar to 1
                        pbCharDown.Visible = False
                        pbChar1.Visible = True
                        pbDown.Visible = True
                        pbLeftDown.Visible = False
                        pbRightDown.Visible = False
                        pbUp.Visible = False
                        pbLeftUp.Visible = True
                        pbRightUp.Visible = True
                        If intPerson = 0 Then ' Checks if "Person" has already been displayed
                            pbPerson.Visible = True
                            intPerson += 1 ' Adds 1 to intPerson to signal that "Person" has been displayed
                        End If
                    ElseIf e.KeyChar = “W” Or e.KeyChar = “w” Then
                        intChar = 2 ' Sets intChar to 2
                        pbCharDown.Visible = False
                        pbChar2.Visible = True
                    End If
                End If
            Case intArea = 3
                If intChar = 1 Then ' Will check which key is pressed & makes pictureboxes invisible and visible (code for other case & if statements is practically the same)
                    If e.KeyChar = “D” Or e.KeyChar = “d” Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar2.Visible = True
                        pbChar1.Visible = False
                        pbPerson.Visible = False
                    ElseIf e.KeyChar = “A” Or e.KeyChar = “a” Then
                        intChar = 4 ' Sets intChar to 4
                        intArea -= 1 ' Subtracts 1 from intArea
                        pbCharDown.Visible = True
                        pbChar1.Visible = False
                        pbDown.Visible = False
                        pbLeftDown.Visible = True
                        pbRightDown.Visible = True
                        pbUp.Visible = True
                        pbLeftUp.Visible = False
                        pbRightUp.Visible = False
                        pbPerson.Visible = False
                    End If
                ElseIf intChar = 2 Then
                    If e.KeyChar = “D” Or e.KeyChar = “d” Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar3.Visible = True
                        pbChar2.Visible = False
                    ElseIf e.KeyChar = “A” Or e.KeyChar = “a” Then
                        intChar -= 1 ' Subtracts 1 from intChar
                        pbChar2.Visible = False
                        pbChar1.Visible = True
                    End If
                ElseIf intChar = 3 Then
                    If e.KeyChar = “W” Or e.KeyChar = “w” Then
                        intChar += 1 ' Adds 1 to intChar
                        pbCharUp.Visible = True
                        pbChar3.Visible = False
                    ElseIf e.KeyChar = “A” Or e.KeyChar = “a” Then
                        intChar -= 1 ' Subtracts 1 from intChar
                        pbChar3.Visible = False
                        pbChar2.Visible = True
                    End If
                ElseIf intChar = 4 Then
                    If e.KeyChar = “W” Or e.KeyChar = “w” Then
                        intChar = 1 ' Sets intChar to 1
                        intArea += 1 ' Adds 1 to intArea
                        pbUp.Visible = True
                        pbCharUp.Visible = False
                        pbChar1.Visible = True
                        pbLeftUp.Visible = False
                        pbRightUp.Visible = False
                        pbDeadEnd.Visible = True

                        ' Stops playing music in the background=
                        My.Computer.Audio.Stop()
                    ElseIf e.KeyChar = “S” Or e.KeyChar = “s” Then
                        intChar -= 1 ' Subtracts 1 from intChar
                        pbCharUp.Visible = False
                        pbChar3.Visible = True
                    End If
                End If
            Case intArea = 4
                If intChar = 1 Then ' Will check which key is pressed & makes pictureboxes invisible and visible (code for other case & if statements is practically the same)
                    If e.KeyChar = “D” Or e.KeyChar = “d” Then
                        intChar += 1 ' Adds 1 to intChar
                        pbChar2.Visible = True
                        pbChar1.Visible = False
                    End If
                ElseIf intChar = 2 Then
                    If e.KeyChar = "D" Or e.KeyChar = "d" Then
                        pbChar2.Visible = False
                        pbCharEnd.Visible = True
                        ' NOTE TO SELF PUT SOMETHING HERE
                        GenerateCode()
                        frmRoom.Show()
                        Me.Close()
                    End If
                End If
        End Select
    End Sub
    Private Sub GenerateCode()
        ' Generates a random piece of code

        ' Declares variables
        Dim outCode As IO.StreamWriter
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim randomCode As New Random

        ' Sets the values of the variables (intNum1, intNum2, intNum3) to a random number
        intNum1 = randomCode.Next(0, 10)
        intNum2 = randomCode.Next(0, 10)
        intNum3 = randomCode.Next(0, 10)

        ' Creates and opens a file for output
        outCode = IO.File.CreateText("code.txt")

        ' Writes the randomized code into the file
        outCode.WriteLine(intNum1 & intNum2 & intNum3)

        ' Closes the file
        outCode.Close()

        ' Display combolock code
        MessageBox.Show("For my closet: " & intNum1 & intNum2 & intNum3, "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Sets intC's value to 1
        frmRoom.intC = 1
    End Sub
End Class