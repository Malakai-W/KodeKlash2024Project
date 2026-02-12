Option Strict On
Option Explicit On
Option Infer Off
Public Class frmRoom
    Private intCount As Integer ' Declares class-level variables
    Private intLock As Integer ' Used to check if the user has the combolock displayed on their screen (0 = combolock not displayed, 1 = combolock is displayed)

    Public strT As String = "F" ' Will be used to know if the user is close up to computer desk, vase, or closet
    Public intC As Integer = 0 ' Declares a variable which'll be used to know if the user completed the riddle, combolock etc. (1 = riddle completed, 2 = combolock unlocked,
    ' 3 = shovel picked up, 4 = key picked up)
    ' intCount: 0 is RoomStart, 1 Is ComputerDesk, -1 Is LockedCloset
    Private Sub frmRoom_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads background image
        BackgroundImage = My.Resources.RoomStart
        ' Plays ambience in the background
        My.Computer.Audio.Play(My.Resources.room, AudioPlayMode.BackgroundLoop)

        ' Sets strArea's value to "R"
        frmStart.strArea = "R"
    End Sub

    Private Sub pbLeftArrow_Click(sender As Object, e As EventArgs) Handles pbLeftArrow.Click
        ' Checks where the user is and moves them to left of where they were
        If strT = "F" Then ' Checks that user isn't close up to computer desk, vase, or closet
            If intCount = 0 Then ' Sets image to the corresponding area of where the user would be
                BackgroundImage = My.Resources.ComputerDesk
                intCount += 1 ' Adds 1 to intCount
            ElseIf intCount = -1 Then
                BackgroundImage = My.Resources.RoomStart
                intCount += 1 ' Adds 1 to intCount
            ElseIf intCount = 1 Then
                If intC = 2 Then ' Checks if closet is unlocked
                    BackgroundImage = My.Resources.UnlockedClosetWShovel
                ElseIf intC >= 3 Then ' Checks if closet is empty
                    BackgroundImage = My.Resources.EmptyCloset
                Else
                    BackgroundImage = My.Resources.LockedCloset
                End If
                intCount = -1 ' Sets intCount to -1
            End If
            If intC >= 1 Then ' Checks if user has completed riddle - the log-in screen giving the code for the combolock on the closet
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub pbRightArrow_Click(sender As Object, e As EventArgs) Handles pbRightArrow.Click
        ' Checks where the user is and moves them to the right of where they were
        If strT = "F" Then ' Checks that user isn't close up to computer desk, vase, or closet
            If intCount = 0 Then ' Sets the image to the corresponding area of where the user would be
                If intC = 2 Then ' Checks if closet is unlocked
                    BackgroundImage = My.Resources.UnlockedClosetWShovel
                ElseIf intC >= 3 Then ' Checks if closet is empty
                    BackgroundImage = My.Resources.EmptyCloset
                Else
                    BackgroundImage = My.Resources.LockedCloset
                End If
                intCount -= 1 ' Substracts 1 from intCount
            ElseIf intCount = 1 Then
                BackgroundImage = My.Resources.RoomStart
                intCount -= 1 ' Substracts 1 from intCount
            ElseIf intCount = -1 Then
                BackgroundImage = My.Resources.ComputerDesk
                intCount = 1 ' Sets intCount to 1
            End If
            If intC >= 1 Then ' Checks if user has completed riddle - the log-in screen giving the code for the combolock on the closet
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub lblVase_Click(sender As Object, e As EventArgs) Handles lblVase.Click
        ' User clicked on vase
        ' Checks that user is in the right spot
        If intCount = 0 Then ' Makes certain pictureboxes not visible, makes one visible, and sets background to a different image
            strT = "T" ' Sets strT's value to "T"
            pbRightArrow.Visible = False
            pbLeftArrow.Visible = False
            pbBackArrow.Visible = True
            If intC = 3 Then ' Checks that user got the shovel from the closet
                BackgroundImage = My.Resources.VaseWithSand
                pbBackArrow.Visible = False ' Makes back arrow not visible
                strT = "V" ' Sets strT to V so user can't use arrows for the time being
                Timer1.Enabled = True ' Enables timer1
            ElseIf intC = 4 Then
                BackgroundImage = My.Resources.EmptyVase
            Else
                BackgroundImage = My.Resources.VaseWithSand
            End If
        End If
    End Sub

    Private Sub lblComputer_Click(sender As Object, e As EventArgs) Handles lblComputer.Click
        ' User clicked on computer
        ' Checks that user is in the right spot
        If intCount = 1 And strT = "T" Then ' Checks if user is already close up
            ' Makes back arrow not visible
            pbBackArrow.Visible = False
            ' Sets strT to "C"
            strT = "C"
            frmLogin.Show() ' Activitates login form
        ElseIf intCount = 1 And strT = "F" Then ' Makes certain pictureboxes not visible, makes one visible, and sets background to a different image
            strT = "T" ' Sets strT's value to "T"
            pbRightArrow.Visible = False
            pbLeftArrow.Visible = False
            pbBackArrow.Visible = True
            BackgroundImage = My.Resources.monitor2
        ElseIf intCount = 0 And strT = "F" Then ' Checks if user at room start
            If intC = 4 Then ' Checks if user has collected key; by checking if intC = 4
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.unlockdoor, AudioPlayMode.WaitToComplete)
                ' Shows frmHallway
                frmHallway.Show()
                ' Closes frmRoom
                Me.Close()
            End If
        End If
    End Sub

    Private Sub lblCloset_Click(sender As Object, e As EventArgs) Handles lblCloset.Click
        ' User clicked on closet
        ' Checks that user is in the right spot
        If intCount = -1 And intC = 2 Then ' Checks if user unlocked closet
            BackgroundImage = My.Resources.EmptyCloset
            intC = 3 ' Sets intC's value to 3
        ElseIf intCount = -1 And strT = "T" Then ' Checks if user is already closeup to closet
            If intC <= 1 Then ' Makes sure the user hasn't already unlocked the closet
                frmComboLock.Show() ' Activates combolock form
                ' Makes back arrow visible
                pbBackArrow.Visible = True
                Me.Hide() ' Hides frmRoom
            End If
        ElseIf intCount = -1 And intC <= 1 Then ' Makes sure user hasn't already unlocked closet
            ' Makes certain pictureboxes not visible, makes one visible, and sets background to a different image
            strT = "T" ' Sets strT's value to "T"
            pbRightArrow.Visible = False
            pbLeftArrow.Visible = False
            pbBackArrow.Visible = True
            BackgroundImage = My.Resources.LockedClosetCloseUp
        End If
    End Sub

    Private Sub lblBook_Click(sender As Object, e As EventArgs) Handles lblBook.Click
        ' User clicked on book
        ' Checks that user is in the right spot
        If intCount = 1 Then ' Makes certain pictureboxes not visible, makes one visible, and
            strT = "B" ' Sets strT's value to B
            ' Makes right and left arrow not visible
            pbRightArrow.Visible = False
            pbLeftArrow.Visible = False

            frmJournal.Show() ' Activitates form
        End If
    End Sub

    Private Sub pbBackArrow_Click(sender As Object, e As EventArgs) Handles pbBackArrow.Click
        ' User clicked on backward arrow
        ' Checks that user is close-up to something
        If strT = "T" Then ' Makes pictureboxes visibles and a picturebox not visible
            pbBackArrow.Visible = False
            pbRightArrow.Visible = True
            pbLeftArrow.Visible = True
            If intCount = 0 Then ' Checks which spot the user is at
                BackgroundImage = My.Resources.RoomStart
            ElseIf intCount = 1 Then
                BackgroundImage = My.Resources.ComputerDesk
            Else
                BackgroundImage = My.Resources.LockedCloset
            End If
            strT = "F" ' Puts the value "F" into the string strT
            If intC >= 1 Then ' Checks if user has completed riddle - the log-in screen giving the code for the combolock on the closet
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Counts the seconds & used for vase

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if intSeconds is 1
        If intSeconds = 1 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.sandinvase, AudioPlayMode.WaitToComplete)
            ' Changes background image
            BackgroundImage = My.Resources.VaseWithKey
            ' Sets intC to 4
            intC = 4
        End If

        ' Checks if intSeconds is 4
        If intSeconds = 4 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.pickupkey, AudioPlayMode.Background)
            ' Changes background image
            BackgroundImage = My.Resources.EmptyVase
            pbBackArrow.Visible = True ' Makes backarrow visible
            strT = "T" ' Sets strT to T
            Timer1.Enabled = False ' Disables Timer1
        End If
    End Sub

    Private Sub frmRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Checks if user pressed X or Q
        If e.KeyChar = "Q" Or e.KeyChar = "q" Then
            ' Displays a messagebox, asking the user if they're sure they want to quit
            Dim dlgButton As DialogResult =
            MessageBox.Show("Are you sure? You'll lose all your progress.", "Are You Sure You Want To Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dlgButton = DialogResult.Yes Then ' Checks if the user clicked yes
                ' Closes the application
                frmStart.Close()
            End If
        End If
    End Sub

    Private Sub timerTip_Tick(sender As Object, e As EventArgs) Handles timerTip.Tick
        ' Displays a label for 5 seconds

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if 5 seconds have passed
        If intSeconds = 5 Then
            ' Makes label not visible
            lblTip.Visible = False
            ' Disables timer
            timerTip.Enabled = False
        End If
    End Sub
End Class