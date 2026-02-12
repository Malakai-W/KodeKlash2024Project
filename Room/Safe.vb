Option Strict On
Option Explicit On
Option Infer Off
Public Class frmSafe
    ' Declares class level variables
    Private intNum As Integer
    Private intCount As Integer
    Private Sub pbUp_Click(sender As Object, e As EventArgs) Handles pbUp.Click
        ' User clicked up arrow

        ' Declares variables
        Const int1stNum As Integer = 8
        Const int3rdNum As Integer = 3

        ' Checks that intCount is less than 3
        If intCount < 3 Then
            ' Calls a private sub to play a sound
            PlaySound()

            ' Checks if intNum is 10
            If intNum = 10 Then
                ' Sets intNum to 0
                intNum = 0
            Else
                ' Adds 1 to intNum
                intNum += 1
            End If

            ' Displays intNum
            lblNum.Text = intNum.ToString

            ' Checks the value of intCount
            Select Case intCount
                Case Is = 0
                    ' Checks if intNum is equal to the first number of the code
                    If intNum = int1stNum Then
                        ' Adds 1 to intCount
                        intCount += 1
                    End If
                Case Is = 1
                    ' Sets intCount to 0
                    intCount = 0
                Case Is = 2
                    ' Checks if intNum is equal to the 3rd number of the code
                    If intNum = int3rdNum Then
                        ' Adds 1 to intCount
                        intCount += 1
                        ' Calls private sub
                        Unlocked()
                    End If
            End Select
        End If
    End Sub

    Private Sub pbDown_Click(sender As Object, e As EventArgs) Handles pbDown.Click
        ' User clicked down arrow

        ' Declares a variable
        Const int2ndNum As Integer = 9

        ' Checks that intCount is less than 3
        If intCount < 3 Then
            ' Calls a private sub to play a sound
            PlaySound()

            ' Checks if intNum is 0
            If intNum = 0 Then
                ' Sets intNum to 10
                intNum = 10
            Else
                ' Subtracts 1 from intNum
                intNum -= 1
            End If

            ' Displays intNum
            lblNum.Text = intNum.ToString
            ' Checks the value of intCount
            Select Case intCount
                Case Is = 1
                    ' Checks if intNum matches the 2nd number of the code
                    If intNum = int2ndNum Then
                        intCount += 1
                    End If
                Case Is = 2
                    ' Sets intCount to 0
                    intCount = 0
            End Select
        End If
    End Sub
    Private Sub PlaySound()
        ' Plays a sound when the user clicks an arrow
        My.Computer.Audio.Play(My.Resources.cbolock, AudioPlayMode.Background)
    End Sub

    Private Sub frmSafe_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads the background image & sets the label to the number 0

        ' Displays 0 in the label
        lblNum.Text = "0"

        ' Sets background image
        BackgroundImage = My.Resources.lockedsafecloseup
    End Sub
    Private Sub Unlocked()
        ' Player gets key from safe

        ' Adds 1 to intEnding
        frmStart.intEnding += 1

        ' Makes pictureboxes not visible and clears label
        pbBack.Visible = False
        pbUp.Visible = False
        pbDown.Visible = False
        pbSafeBox.Visible = False
        lblNum.Text = String.Empty

        ' Plays a sound
        My.Computer.Audio.Play(My.Resources.safeunlock, AudioPlayMode.Background)

        ' Changes background image
        BackgroundImage = My.Resources.unlockedsafewkey

        ' Enables unlock timer
        timerUnlock.Enabled = True
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' Exits frmSafe

        ' Checks that intCOunt is less than 3
        If intCount < 3 Then
            ' Shows frmEscape
            frmEscape.Show()
            ' Closes current form
            Me.Close()
        End If
    End Sub

    Private Sub timerUnlock_Tick(sender As Object, e As EventArgs) Handles timerUnlock.Tick
        ' Displays images & plays sounds following the event of the safe being unlocked

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if intSeconds is 3
        If intSeconds = 3 Then
            ' Plays sound
            My.Computer.Audio.Play(My.Resources.pickupkey, AudioPlayMode.Background)
            ' Changes background image
            BackgroundImage = My.Resources.unlockedsafe
        ElseIf intSeconds = 6 Then ' Checks if intSeconds is 6
            ' Shows frmEscape
            frmEscape.Show()
            ' Changes background image of frmEscape
            frmEscape.BackgroundImage = My.Resources.unlockedsafe2
            ' Makes forward arrow not visible in frmEscape
            frmEscape.pbForward.Visible = False
            ' Closes current form
            Me.Close()
        End If
    End Sub
End Class