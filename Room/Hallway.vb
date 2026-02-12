Option Strict On
Option Explicit On
Option Infer Off
Public Class frmHallway
    ' Declares class-level variables
    Private intCount As Integer ' Used to know where the user is in the highway
    Private intHide As Integer = 0 ' Used to know if the user is hiding, 0 = not hiding & 1 = hiding
    ' intCount; 0 is hallway.png, 1 is hallwaytwodirections.png, 2 is hallwayfacingleftdoor.png, 3 is hallwayfacing2nddoor.png
    Private Sub pbLeftArrow_Click(sender As Object, e As EventArgs) Handles pbLeftArrow.Click
        ' Moves user to the left of them
        ' Checks to make sure the user isn't hiding
        If intHide <= 0 Then
            If intCount = 1 Then ' Checks if the user is in the right spot
                intCount += 1 ' Adds 1 to intCount
                BackgroundImage = My.Resources.hallwayfacingleftdoor ' Changes background image
                ' Makes arrow(s) visible and not visible
                pbLeftArrow.Visible = False
                pbForwardArrow.Visible = True
                pbRightArrow.Visible = False
            End If
        End If
    End Sub

    Private Sub frmHallway_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Loads
        BackgroundImage = My.Resources.hallway
        ' Makes left arrow, right arrow, and backarrow not visible
        pbBackArrow.Visible = False
        pbLeftArrow.Visible = False
        pbRightArrow.Visible = False
    End Sub

    Private Sub pbRightArrow_Click(sender As Object, e As EventArgs) Handles pbRightArrow.Click
        ' Moves user to the right of them
        ' Checks to make sure the user isn't hiding
        If intHide <= 0 Then
            If intCount = 1 Then ' Checks if the user is in the right spot
                intCount = 3 ' Sets intCount to 3
                BackgroundImage = My.Resources.hallwayfacing2nddoor ' Changes background image
                ' Makes arrow(s) visible and not visible
                pbForwardArrow.Visible = True
                pbLeftArrow.Visible = False
                pbRightArrow.Visible = False
                ' Checks if user has already been in there
                If frmStart.intEnding = -2 Then
                    ' Makes forward arrow not visible
                    pbForwardArrow.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub pbForwardArrow_Click(sender As Object, e As EventArgs) Handles pbForwardArrow.Click
        ' Moves user forward
        ' Checks to make sure the user isn't hiding
        If intHide <= 0 Then
            ' Checks to make sure the user is in the right spot
            If intCount = 0 Then
                intCount += 1 ' Adds 1 to intCount
                BackgroundImage = My.Resources.hallwaytwodirections ' Changes background image
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)

                ' Makes arrow(s) visible and not visible 
                pbForwardArrow.Visible = False
                pbBackArrow.Visible = True
                pbRightArrow.Visible = True
                pbLeftArrow.Visible = True
            ElseIf intCount = 2 Then
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)

                ' Activates other form
                frmEscape.Show()
                ' Closes current form
                Me.Close()
            ElseIf intCount = 3 Then
                ' Checks that user hasn't already been in there
                If frmStart.intEnding = 0 Then
                    ' Makes forward arrow not visible
                    pbForwardArrow.Visible = False
                    ' Shows storage form
                    frmStorage.Show()
                    ' Hides current form
                    Me.Hide()
                End If
            End If
        Else
            ' Changes background image
            BackgroundImage = My.Resources.hallwaytwodirections
            ' Sets intHide to -1
            intHide = -1
            ' Makes forward arrow not visible & back arrow, right arrow, left arrow visible
            pbForwardArrow.Visible = False
            pbBackArrow.Visible = True
            pbRightArrow.Visible = True
            pbLeftArrow.Visible = True
        End If
    End Sub

    Private Sub pbBackArrow_Click(sender As Object, e As EventArgs) Handles pbBackArrow.Click
        ' Moves user backward
        ' Checks to make sure the user isn't hiding
        If intHide <= 0 Then
            ' Checks to make sure the user is in the right spot
            If intCount = 1 Then
                intCount -= 1 ' Subtracts 1 from intCount
                BackgroundImage = My.Resources.hallway ' Changes background image
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)

                ' Makes arrow(s) visible and not visible
                pbForwardArrow.Visible = True
                pbRightArrow.Visible = False
                pbLeftArrow.Visible = False
                pbBackArrow.Visible = False
            ElseIf intCount = 2 Then
                intCount -= 1 ' Subtracts 1 from intCount
                BackgroundImage = My.Resources.hallwaytwodirections ' Changes background image
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)

                ' Makes arrow(s) visible and not visible 
                pbForwardArrow.Visible = False
                pbBackArrow.Visible = True
                pbRightArrow.Visible = True
                pbLeftArrow.Visible = True
            ElseIf intCount = 3 Then
                intCount = 1 ' Sets intCount to 1
                BackgroundImage = My.Resources.hallwaytwodirections ' Changes background image

                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)

                ' Makes arrow(s) visible and not visible 
                pbForwardArrow.Visible = False
                pbBackArrow.Visible = True
                pbRightArrow.Visible = True
                pbLeftArrow.Visible = True
            End If
        End If
    End Sub

    Private Sub lblClosetSecret_Click(sender As Object, e As EventArgs) Handles lblClosetSecret.Click
        ' User clicked on clost

        ' Checks that user hasn't already been in closet
        If intHide = 0 Then
            ' Checks that user is in the right spot
            If intCount = 1 Then
                ' Adds 1 to intHide
                intHide += 1
                ' Changes background image
                BackgroundImage = My.Resources.hallwayhidinginthecloset
                ' Makes back arrow, right arrow, and left arrow not visible
                pbBackArrow.Visible = False
                pbRightArrow.Visible = False
                pbLeftArrow.Visible = False
                ' Enables timer
                timerSecret.Enabled = True
            End If
        End If
    End Sub

    Private Sub timerSecret_Tick(sender As Object, e As EventArgs) Handles timerSecret.Tick
        ' Gives the application 2 seconds to load the background image & continues on

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if 2 seconds have passed
        If intSeconds = 2 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.footsteps, AudioPlayMode.WaitToComplete)
            ' Plays another sound
            My.Computer.Audio.Play(My.Resources.doorcloseLeft_v2, AudioPlayMode.WaitToComplete)
            ' Makes forward arrow visible
            pbForwardArrow.Visible = True
            ' Disables the timer
            timerSecret.Enabled = False
        End If
    End Sub
End Class