Option Strict On
Option Explicit On
Option Infer Off
Public Class frmDeath
    Private Sub frmDeath_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ' Shows gameover screen
        frmGameOver.Show()
        ' Closes form
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Adds 1 to a variable for each second that goes by
        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if intSeconds is 1
        If intSeconds = 2 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.lethal, AudioPlayMode.WaitToComplete)
            ' Disables Timer1
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmDeath_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Displays a hint (on not getting caught or riddle regarding safe)

        ' Declares variables
        Dim rHint As New Random ' Used if user has already seen all hints
        Dim intHints As Integer


        ' Assigns a random number to intHint
        intHints = rHint.Next(1, 6)

        ' Displays a tip based off the value of intHints
        Select Case intHints
            Case Is = 1
                lblHint.Text = "Try moving to another room before hiding."
            Case Is = 2
                lblHint.Text = "Remain hidden until the music stops."
            Case Is = 3
                lblHint.Text = "Up, down, and up for the safe."
            Case Is = 4
                lblHint.Text = "Having trouble with the safe? Go to the living room. It might have something that'll help you."
            Case Is = 5
                lblHint.Text = "There's only 2 spots to hide; the closet in the bedroom and the table by the front door."
        End Select
    End Sub
End Class