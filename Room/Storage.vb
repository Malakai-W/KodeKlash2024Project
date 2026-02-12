Option Strict On
Option Explicit On
Option Infer Off
Public Class frmStorage
    Private Sub pbForward_Click(sender As Object, e As EventArgs) Handles pbForward.Click
        ' User clicked forward arrow

        ' Declares a variable
        Dim intNum As Integer
        Dim intNum1 As Integer

        ' Calls a function and sets the value of intNum to the value returned
        intNum = AddToCount(intNum1)

        ' Checks the value of intNum
        Select Case intNum
            Case Is = 2
                ' Changes background image
                BackgroundImage = My.Resources.storagehallstrt
                ' Calls a private sub to play a sound
                PlaySound()
            Case Is = 3
                ' Changes background image
                BackgroundImage = My.Resources.storagehall
                ' Calls a private sub to play a sound
                PlaySound()
            Case Is = 4
                ' Changes background image
                BackgroundImage = My.Resources.storagehall2
                ' Calls a private sub to play a sound
                PlaySound()
            Case Is = 5
                ' Makes forward arrow not visible
                pbForward.Visible = False
                ' Changes background image
                BackgroundImage = My.Resources.ending2trigger
                ' Plays a sound and waits for sound to complete before moving on
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.WaitToComplete)
                ' Enables a timer
                timerEncounter.Enabled = True
        End Select
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        ' User clicked on back arrow

        ' Declares variable
        Dim intNum As Integer
        Dim intNum1 As Integer

        ' Checks that back arrow is visible
        If pbBack.Visible = True Then
            ' Calls function and sets value of intNum to the value returned
            intNum = AddToCount(intNum1)
            ' Makes sure intNum = 5
            If intNum = 5 Then
                ' Plays a private sub to play a sound
                PlaySound()
                ' Shows frmHallway
                frmHallway.Show()
                ' Closes current from
                Me.Close()
            End If
        End If
    End Sub
    Private Function AddToCount(ByVal intCount As Integer) As Integer
        ' Adds to intCount

        ' Declares variables
        Static intCount1 As Integer = 1

        ' Checks if intCount1 is less than 5
        If intCount1 < 5 Then
            ' Adds 1 to intCount1
            intCount1 += 1
        End If

        ' Sets value of intCount to value of intCount1
        intCount = intCount1

        ' Returns intCount
        Return intCount
    End Function
    Private Sub PlaySound()
        ' Plays a sound
        My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)
    End Sub

    Private Sub frmStorage_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sets background image
        BackgroundImage = My.Resources.storagestart
        ' Calls a private sub to play a sound
        PlaySound()
    End Sub

    Private Sub timerEncounter_Tick(sender As Object, e As EventArgs) Handles timerEncounter.Tick
        ' Adds one to a variable each second

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if 3 seconds have passed
        If intSeconds = 3 Then
            ' Changes background image
            BackgroundImage = My.Resources.storagebackrm
            ' Sets intEnding to -2
            frmStart.intEnding = -2
            ' Makes back arrow visible
            pbBack.Visible = True
            ' Disables timer
            timerEncounter.Enabled = False
        End If
    End Sub
End Class