Option Strict On
Option Explicit On
Option Infer Off
Public Class frmGameOver
    Private Sub lblYes_Click(sender As Object, e As EventArgs) Handles lblYes.Click
        ' Activitates frmEscape
        frmEscape.Show()
        ' Stops playing ambience
        My.Computer.Audio.Stop()
        ' Closes current form
        Me.Close()
    End Sub

    Private Sub lblNo_Click(sender As Object, e As EventArgs) Handles lblNo.Click
        ' Displays a messagebox, asking the user if they're sure they want to quit
        Dim dlgButton As DialogResult =
        MessageBox.Show("Are you sure? You'll lose all your progress.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dlgButton = DialogResult.Yes Then ' Checks if the user clicked yes
            ' Closes the application
            frmStart.Close()
        End If
    End Sub

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Plays background ambience
        My.Computer.Audio.Play(My.Resources.gameover, AudioPlayMode.BackgroundLoop)

    End Sub
End Class