Option Strict On
Option Explicit On
Option Infer Off
Public Class frmJournal
    Private Sub pbArrowExit_Click(sender As Object, e As EventArgs) Handles pbArrowExit.Click
        ' Closes the form

        ' Checks which form is open
        If frmStart.strArea = "R" Then ' frmRoom is open


            ' Plays ambience in the background
            My.Computer.Audio.Play(My.Resources.room, AudioPlayMode.BackgroundLoop)

            ' Makes left and right arrow inside frmRoom visible
            frmRoom.pbLeftArrow.Visible = True
            frmRoom.pbRightArrow.Visible = True

            ' Sets strT to F
            frmRoom.strT = "F"
        Else ' frmEscape is open
            ' Makes back and front arrow inside frmEscape visible
            frmEscape.pbForward.Visible = True
            frmEscape.pbBackward.Visible = True

            ' Changes background image
            frmEscape.BackgroundImage = My.Resources.livingroom
            ' Sets intNum in frmEscape to 0
            frmEscape.intNum = 0
        End If
        ' Closes form
        Me.Close()

    End Sub

    Private Sub pbArrow_Click(sender As Object, e As EventArgs) Handles pbArrow.Click
        ' Goes to the next page of the journal

        ' Checks if user is on correct form
        If frmStart.strArea = "R" Then
            ' Declares a variable
            Static intPage As Integer = 1

            ' Adds 1 to intPage
            intPage += 1

            ' Checks that intPage is less than or equal to 9
            If intPage <= 2 Then
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.book, AudioPlayMode.Background)
            End If

            ' Checks which page the user is on
            Select Case intPage
                Case Is = 2
                    lblJournal.Text = "Belief of danger creates the unpleasant feeling."
                    pbArrow.Visible = False
            End Select
        End If
    End Sub

    Private Sub frmJournal_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads the first set of text into the label

        ' Plays a sound
        My.Computer.Audio.Play(My.Resources.book, AudioPlayMode.Background)

        ' Checks what area (form) the user is on
        If frmStart.strArea = "R" Then
            ' Displays text in a label
            lblJournal.Text = "I take the form of your shape. I always follow you wherever you go. What am I?"
        Else
            ' Makes arrow not visible
            pbArrow.Visible = False
            ' Displays text inside the label
            lblJournal.Text = "I started off with no flowers, then I gained 8 flowers. I then gained 1 more flower. Finally I gave away 6 of those flowers."
        End If
    End Sub
End Class