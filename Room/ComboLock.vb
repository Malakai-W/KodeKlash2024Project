Option Strict On
Option Explicit On
Option Infer Off
Public Class frmComboLock
    ' Declares class level variables
    Private strCombo As String = "S"
    Private strUserC As String
    Private intNum1 As Integer
    Private intNum2 As Integer
    Private intNum3 As Integer
    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' Goes back (closes form)
        ' Shows frmRoom
        frmRoom.Show()

        ' Closes frmComboLock
        Me.Close()
    End Sub

    Private Sub frmComboLock_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads the randomized code

        ' Declares a variable
        Dim inCombo As IO.StreamReader

        ' Checks if the user completed the "Follow" minigame
        If frmRoom.intC = 1 Then
            ' Checks that the file exists
            If IO.File.Exists("code.txt") Then
                ' Opens file for input
                inCombo = IO.File.OpenText("code.txt")
                ' Reads from the file
                strCombo = inCombo.ReadLine
                ' Closes the file
                inCombo.Close()
            Else ' Displays the error and the possible causes, and closes the application
                MsgBox("Error: Text file could not be found; Please don't move, rename, or delete files.")
                MsgBox("Game will be closed. You may reopen it once it's closed.")
                frmStart.Close()
            End If
        End If
    End Sub

    Private Sub pbNum1Up_Click(sender As Object, e As EventArgs) Handles pbNum1Up.Click
        ' Displays and adds 1 to intNum1

        ' Checks if intNum1 is 9
        If intNum1 = 9 Then
            intNum1 = 0 ' Sets intNum1 to 0
            lblNum1.Text = intNum1.ToString ' Displays new value of intNum1
        Else
            intNum1 += 1 ' Adds 1 to intNum1
            lblNum1.Text = intNum1.ToString ' Displays new value of intNum1
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub

    Private Sub pbNum1Down_Click(sender As Object, e As EventArgs) Handles pbNum1Down.Click
        ' Displays and subtracts 1 from intNum1

        ' Checks if intNum1 is 0
        If intNum1 = 0 Then
            intNum1 = 9 ' Sets intNum1 to 9
            lblNum1.Text = intNum1.ToString ' Displays new value of intNum1
        Else
            intNum1 -= 1 ' Subtracts 1 from intNum1
            lblNum1.Text = intNum1.ToString ' Displays new value of intNum1
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub

    Private Sub pbNum2Up_Click(sender As Object, e As EventArgs) Handles pbNum2Up.Click
        ' Displays and adds 1 to intNum2

        ' Checks if intNum2 is 9
        If intNum2 = 9 Then
            intNum2 = 0 ' Sets intNum2 to 0
            lblNum2.Text = intNum2.ToString ' Displays new value of intNum2
        Else
            intNum2 += 1 ' Adds 1 to intNum2
            lblNum2.Text = intNum2.ToString ' Displays new value of intNum2
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub

    Private Sub pbNum2Down_Click(sender As Object, e As EventArgs) Handles pbNum2Down.Click
        ' Displays and subtracts 1 from intNum2

        ' Checks if intNum2 is 0
        If intNum2 = 0 Then
            intNum2 = 9 ' Sets intNum2 to 9
            lblNum2.Text = intNum2.ToString ' Displays new value of intNum2
        Else
            intNum2 -= 1 ' Subtracts 1 from intNum2
            lblNum2.Text = intNum2.ToString ' Displays new value of intNum2
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub

    Private Sub pbNum3Up_Click(sender As Object, e As EventArgs) Handles pbNum3Up.Click
        ' Displays and adds 1 to intNum3

        ' Checks if intNum3 is 9
        If intNum3 = 9 Then
            intNum3 = 0 ' Sets intNum3 to 0
            lblNum3.Text = intNum3.ToString ' Displays new value of intNum3
        Else
            intNum3 += 1 ' Adds 1 to intNum3
            lblNum3.Text = intNum3.ToString ' Displays new value of intNum3
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub

    Private Sub pbNum3Down_Click(sender As Object, e As EventArgs) Handles pbNum3Down.Click
        ' Displays and subtracts 1 from intNum3

        ' Checks if intNum3 is 0
        If intNum3 = 0 Then
            intNum3 = 9 ' Sets intNum3 to 9
            lblNum3.Text = intNum3.ToString ' Displays new value of intNum3
        Else
            intNum3 -= 1 ' Subtracts 1 from intNum3
            lblNum3.Text = intNum3.ToString ' Displays new value of intNum3
        End If

        ' Calls a sub to play a sound
        PlaySound()

        ' Calls to private sub
        Check()
    End Sub
    Private Sub PlaySound()
        ' Plays a sound effect
        ' Checks that intC is equal to 1; meaning that user completed minigame
        If frmRoom.intC = 1 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.cbolock, AudioPlayMode.Background)
        End If
    End Sub
    Private Sub Check()
        ' Checks if the combination is correct

        ' Puts intNum1's, intNum2's, and intNum3's value into a string together
        strUserC = intNum1.ToString & intNum2.ToString & intNum3.ToString
        ' Checks if the combination matches the generated combination
        If strCombo = strUserC Then
            ' Sets intC's value to 2
            frmRoom.intC = 2

            ' Sets strT's value to "F"
            frmRoom.strT = "F"

            ' Changes the background image of frmRoom
            frmRoom.BackgroundImage = My.Resources.UnlockedClosetWShovel
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.closetunlocked, AudioPlayMode.WaitToComplete)
            ' Shows frmRoom
            frmRoom.Show()

            ' Makes back arrow not visible and makes right & left arrow visible
            frmRoom.pbBackArrow.Visible = False
            frmRoom.pbLeftArrow.Visible = True
            frmRoom.pbRightArrow.Visible = True

            ' Closes frmComboLock
            Me.Close()
        End If
    End Sub
End Class