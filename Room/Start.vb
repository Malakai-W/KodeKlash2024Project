
' Name: Rooms
' Date: 5/10/24
' Programmers: Steven Crum, Isaac Saylor, Malakai Wicker
' Images from https://www.freeimages.com/ & https://pixabay.com
' Sounds/Music from https://pixabay.com/
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmStart
    ' Declares a class-level variable
    Public intEnding As Integer ' Used to determine which ending the player will get
    Public strArea As String ' Used to determine which form (area) user is on
    Private Sub lblQuit_Click(sender As Object, e As EventArgs) Handles lblQuit.Click
        ' Closes the application
        Me.Close()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Random chance (25%) of something appearing in the background of the menu

        ' Declares variables
        Dim rChance As New Random
        Dim intNum As Integer

        ' Gets a random number
        intNum = rChance.Next(1, 5)

        ' Checks if intNum is 1
        If intNum = 1 Then
            pbManInBackground.Visible = True ' Makes an image visible
        End If

        ' Plays sound in the background
        My.Computer.Audio.Play(My.Resources.softambient, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        ' Starts the game

        ' Stops playing the audio
        My.Computer.Audio.Stop()
        ' Activates another form and hides the main form
        frmRoom.Show()
        Me.Hide()
    End Sub
End Class
