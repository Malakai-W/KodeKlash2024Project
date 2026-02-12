Public Class frmEnding
    Private Sub lblRestart_Click(sender As Object, e As EventArgs) Handles lblRestart.Click
        ' Sets intEnding to 0
        frmStart.intEnding = 0
        ' Shows frmRoom
        frmRoom.Show()
        ' Closes current form
        Me.Close()
    End Sub

    Private Sub lblQuit_Click(sender As Object, e As EventArgs) Handles lblQuit.Click
        ' Closes application
        frmStart.Close()
    End Sub

    Private Sub Ending_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Plays ambience in the background
        My.Computer.Audio.Play(My.Resources.ending2ambient, AudioPlayMode.BackgroundLoop)
    End Sub
End Class