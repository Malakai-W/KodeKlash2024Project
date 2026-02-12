Option Strict On
Option Explicit On
Option Infer Off
Public Class frmEscape
    ' Declares a public variable
    Public intNum As Integer ' 1 = player is hiding, 0 = player is not hiding & -1 = player is close up to something
    ' Declares class-level variables
    Private intRun As Integer ' 2 = player needs to move to another area, 1 = player encounters it, 0 = player is not currently encountering anything
    Private intCount As Integer ' used to know where the player is
    ' ^ 0 = the very start, 1 = start, 2 = three directional hall, 3 = front door, 4 = bedroom door, 5 = bedroom, 6 = living room
    Private intCounter As Integer ' Used to count the times the player didn't encounter anything
    Private intEncounter As Integer = -1 ' Used to keep track of where "ghost" is (in the event of an encounter)

    Private Sub pbForward_Click(sender As Object, e As EventArgs) Handles pbForward.Click
        ' Player moved forward

        ' Makes sure the player isn't hiding or isn't close-up to something
        If intNum = 0 Then
            ' Checks where the player is (& if they're at the correct spot to move forward)
            Select Case intCount
                Case Is = 0 ' Player is at the very start
                    ' Changes background image
                    BackgroundImage = My.Resources.escapestart
                    ' Adds 1 to intCount
                    intCount += 1
                    ' Calls sub to play sound
                    PlaySound()
                Case Is = 1 ' Player is at the start
                    ' Changes background image
                    BackgroundImage = My.Resources._3direction
                    ' Adds 1 to intCount
                    intCount += 1
                    ' Calls sub to play sound
                    PlaySound()
                    ' Makes right arrow and left arrow visible
                    pbLeft.Visible = True
                    pbRight.Visible = True
                Case Is = 2 ' Player is at a spot with 3 directions to take
                    ' Sets intCount to 7
                    intCount = 7
                    ' Calls a private sub to determine if there'll be an encounter
                    RandomChance()
                    ' Checks if intRun is 1; If player will experience an encounter
                    If intRun = 1 Or intCount = intEncounter Then
                        ' Changes background image
                        BackgroundImage = My.Resources.livingroomwghost
                        ' Makes sure intRun is equal to 1
                        If intRun = 1 Then
                            ' Sets intRun's value to 2
                            intRun = 2
                        End If
                    Else
                        ' Changes background image
                        BackgroundImage = My.Resources.livingroom
                    End If
                    ' Calls sub to play sound
                    PlaySound()
                    ' Makes back arrow visible & left and right arrow not visible
                    pbBackward.Visible = True
                    pbLeft.Visible = False
                    pbRight.Visible = False
                Case Is = 3 ' Player is facing the front door
                    ' Checks if player is experiencing an encounter
                    If intRun = 1 Or intCount = intEncounter Then
                        ' Calls private sub
                        Caught()
                    ElseIf intEncounter < 0 Then ' Makes sure that intEncounter is less than 0; indicating user is not being chased
                        ' Checks if user has the key (and which ending they will get)
                        Select Case frmStart.intEnding
                            Case Is = -1 ' Ending 1
                                ' Makes forward arrow & back arrow not visible
                                pbBackward.Visible = False
                                pbForward.Visible = False
                                ' Changes background image
                                BackgroundImage = My.Resources.ending1wtext
                                ' Enables timer
                                timerEnd.Enabled = True
                            Case Is = 1 ' Ending 2
                                ' Plays a sound
                                My.Computer.Audio.Play(My.Resources.unlockdoor, AudioPlayMode.WaitToComplete)
                                ' Shows ending 2 form
                                frmEnding.Show()
                                ' Closes current form
                                Me.Close()
                        End Select
                    End If
                Case Is = 4 ' Player is facing bedroom door
                    ' Checks if player is experiencing an encounter
                    If intRun = 1 Or intEncounter = intCount Then
                        ' Calls private sub
                        Caught()
                    Else
                        ' Adds 1 to intCount
                        intCount += 1
                        ' Calls a private sub to determine if there'll be an encounter
                        RandomChance()
                        ' Checks if intRun is 1; If player will experience an encounter & if they've unlocked safe
                        Select Case True
                        ' Changes background image
                            Case intEncounter = intCount And frmStart.intEnding = 0 Or intEncounter = intCount And frmStart.intEnding = -2 ' Encounter, safe still locked
                                BackgroundImage = My.Resources.bedroomwghost
                                ' Makes sure intRun is equal to 1
                                If intRun = 1 Then
                                    ' Sets intRun's value to 2
                                    intRun = 2
                                End If
                            Case intEncounter = intCount And frmStart.intEnding = 1 Or intEncounter = intCount And frmStart.intEnding = -1 ' Encounter, safe is unlocked
                                BackgroundImage = My.Resources.bdrmunlockedwghost
                                ' Makes sure intRun is equal to 1
                                If intRun = 1 Then
                                    ' Sets intRun's value to 2
                                    intRun = 2
                                End If
                            Case intEncounter <> intCount And frmStart.intEnding = 0 Or intEncounter <> intCount And frmStart.intEnding = -2 ' No encounter (inside the bedroom at least), safe still locked
                                BackgroundImage = My.Resources.bedroom
                            Case intEncounter <> intCount And frmStart.intEnding = 1 Or intEncounter <> intCount And frmStart.intEnding = -1 ' No encounter (inside the bedroom at least), safe is unlocked
                                BackgroundImage = My.Resources.bdrmunlocked
                        End Select
                        ' Calls sub to play sound
                        PlaySound()
                        ' Makes hide arrow visible
                        pbHide.Visible = True
                    End If
                Case Is = 5 ' Player is in the bedroom
                    ' Checks if player is experiencing an encounter
                    If intRun = 1 Or intCount = intEncounter Then
                        ' Calls private sub
                        Caught()
                    ElseIf frmStart.intEnding = 0 Or frmStart.intEnding = -2 Then ' Checks if safe is still locked - Player doesn't have key
                        ' Changes background image
                        BackgroundImage = My.Resources.lockedsafe
                    Else ' Safe is unlocked
                        ' Changes background image
                        BackgroundImage = My.Resources.unlockedsafe2
                        ' Makes forward arrow not visible
                        pbForward.Visible = False
                    End If
                    ' Calls sub to play sound
                    PlaySound()
                    ' Adds 1 to intCount
                    intCount += 1
                    ' Makes hide arrow not visible
                    pbHide.Visible = False
                Case Is = 6 ' Player is facing safe
                    ' Checks that player hasn't unlocked safe yet (and also that intRun is 0) - still doesn't have key & that they aren't already close up to safe
                    If frmStart.intEnding = 0 And intRun = 0 Or frmStart.intEnding = -2 And intRun = 0 Then
                        ' Calls sub to play sound
                        PlaySound()
                        ' Shows form
                        frmSafe.Show()
                        ' Hides current form
                        Me.Hide()
                    End If
                Case Is = 7 ' Player is in the living room
                    ' Checks if player is experiencing an encounter
                    If intRun = 1 Or intCount = intEncounter Then
                        ' Calls private sub
                        Caught()
                    Else
                        ' Calls sub to play sound
                        PlaySound()
                        ' Changes background image
                        BackgroundImage = My.Resources.papercloseup
                        ' Makes forward arrow and back arrow not visible
                        pbForward.Visible = False
                        pbBackward.Visible = False
                        ' Sets intNum to -1
                        intNum = -1
                        ' Shows form
                        frmJournal.Show()
                    End If
            End Select
        ElseIf intNum = 1 Then ' Checks if player is hiding
            ' Checks if regret timer is not enabled
            If timerRegret.Enabled = False Then
                Select Case intCount ' Checks where user is hiding
                    Case Is = 5 ' User is hiding in bedroom
                        ' Checks if they've unlocked safe
                        Select Case True
                        ' Changes background image
                            Case frmStart.intEnding = 0 Or frmStart.intEnding = -2 ' Safe still locked
                                BackgroundImage = My.Resources.bedroom
                            Case frmStart.intEnding = 1 Or frmStart.intEnding = -1 ' Safe unlocked
                                BackgroundImage = My.Resources.bdrmunlocked
                        End Select
                        ' Calls a private sub to play sound
                        PlaySound()
                        ' Makes hide arrow and back arrow visible
                        pbHide.Visible = True
                        pbBackward.Visible = True
                    Case Is = 3 ' User is hiding by front door
                        ' Changes background image
                        BackgroundImage = My.Resources.frontdoor
                        ' Checks if user does not have key
                        If frmStart.intEnding = 0 Or frmStart.intEnding = -2 Then
                            ' Makes forward arrow not visible
                            pbForward.Visible = False
                        End If
                        ' Makes hide arrow visible
                        pbHide.Visible = True
                        ' Calls a private sub to play sound
                        PlaySound()
                End Select
                ' Sets intNum to 0
                intNum = 0
                ' Makes back arrow visible
                pbBackward.Visible = True
            End If
        End If
    End Sub

    Private Sub pbLeft_Click(sender As Object, e As EventArgs) Handles pbLeft.Click
        ' Player moved to the left

        ' Makes sure the player isn't hiding or isn't close up to something
        If intNum = 0 Then
            ' Makes sure the user is at the right spot to go left
            If intCount = 2 Then
                ' Adds 1 to intCount
                intCount += 1
                ' Makes left, right, and forward arrow not visible, makes back arrow visible
                pbForward.Visible = False
                pbLeft.Visible = False
                pbRight.Visible = False
                pbBackward.Visible = True
                ' Calls a private sub to determine if there'll be an encounter
                RandomChance()
                ' Checks if player encountered something
                If intRun = 1 Or intEncounter = intCount Then
                    ' Changes background image
                    BackgroundImage = My.Resources.frontdoorwghost
                    ' Makes sure intRun is equal to 1
                    If intRun = 1 Then
                        ' Sets intRun's value to 2
                        intRun = 2
                    End If
                Else
                    ' Changes background image
                    BackgroundImage = My.Resources.frontdoor
                    ' Checks that intEncounter is less than 0; user is not currently being chased
                    If intEncounter <= 0 Then
                        ' Checks if user has key
                        If frmStart.intEnding = 1 Or frmStart.intEnding = -1 Then
                            ' Makes forward arrow visible
                            pbForward.Visible = True
                        End If
                    End If
                End If
                ' Makes hide arrow visible
                pbHide.Visible = True
                ' Calls a private sub to play sound
                PlaySound()
            End If
        End If
    End Sub

    Private Sub pbRight_Click(sender As Object, e As EventArgs) Handles pbRight.Click
        ' Player moved to the right

        ' Makes sure the player isn't hiding or isn't close up to something
        If intNum = 0 Then
            ' Makes sure the user is at the right spot to go right
            If intCount = 2 Then
                ' Adds 2 to intCount
                intCount += 2
                ' Makes left and right arrow not visible, makes back arrow visible
                pbLeft.Visible = False
                pbRight.Visible = False
                pbBackward.Visible = True
                ' Calls a private sub to determine if there'll be an encounter
                RandomChance()
                ' Checks if player encountered something
                If intRun = 1 Or intEncounter = intCount Then
                    ' Changes background image
                    BackgroundImage = My.Resources.bedroomdoorwghost
                    ' Makes sure intRun is equal to 1
                    If intRun = 1 Then
                        ' Sets intRun's value to 2
                        intRun = 2
                    End If
                Else
                    ' Changes background image
                    BackgroundImage = My.Resources.bedroomdoor
                End If
                ' Calls a private sub to play sound
                PlaySound()
            End If
        End If
    End Sub

    Private Sub pbBackward_Click(sender As Object, e As EventArgs) Handles pbBackward.Click
        ' Player moved backwards

        ' Makes sure player isn't hiding or close up
        If intNum = 0 Then
            ' Checks where player is
            Select Case intCount
                Case Is = 3 ' User is facing front door
                    ' Changes background image
                    BackgroundImage = My.Resources._3direction
                    ' Sets intCount to 2
                    intCount = 2
                    ' Calls sub to play sound
                    PlaySound()
                    ' Makes right arrow and left arrow visible, makes back and hide arrow not visible
                    pbLeft.Visible = True
                    pbRight.Visible = True
                    pbBackward.Visible = False
                    pbHide.Visible = False
                    ' Checks if forward arrow was not visible
                    If pbForward.Visible = False Then
                        ' Makes forward arrow visible
                        pbForward.Visible = True
                    End If
                Case Is = 4 ' User is facing bedroom door
                    ' Changes background image
                    BackgroundImage = My.Resources._3direction
                    ' Sets intCount to 2
                    intCount = 2
                    ' Calls sub to play sound
                    PlaySound()
                    ' Makes right arrow and left arrow visible, makes back arrow not visible
                    pbLeft.Visible = True
                    pbRight.Visible = True
                    pbBackward.Visible = False
                Case Is = 5 ' User is in bedroom
                    ' Changes background image
                    BackgroundImage = My.Resources.bedroomdoor
                    ' Subtracts 1 from intCount
                    intCount -= 1
                    ' Makes hide arrow not visible 
                    pbHide.Visible = False
                    ' Calls a private sub to play sound
                    PlaySound()
                Case Is = 6 ' User is facing safe
                    ' Checks if they've unlocked safe
                    Select Case True
                        ' Changes background image
                        Case frmStart.intEnding = 0 Or frmStart.intEnding = -2 ' Safe still locked
                            BackgroundImage = My.Resources.bedroom
                        Case frmStart.intEnding = 1 Or frmStart.intEnding = -1 ' Safe unlocked
                            BackgroundImage = My.Resources.bdrmunlocked
                            ' Makes forward arrow visible
                            pbForward.Visible = True
                    End Select
                    ' Makes hide arrow visible
                    pbHide.Visible = True
                    ' Calls a private sub to play sound
                    PlaySound()
                    ' Subtracts 1 from intCount
                    intCount -= 1
                Case Is = 7 ' User is in living room
                    ' Changes background image
                    BackgroundImage = My.Resources._3direction
                    ' Sets intCount to 2
                    intCount = 2
                    ' Calls sub to play sound
                    PlaySound()
                    ' Makes right arrow and left arrow visible, makes back arrow not visible
                    pbLeft.Visible = True
                    pbRight.Visible = True
                    pbBackward.Visible = False
            End Select
        ElseIf intNum = -1 Then ' Checks if user is close up
            ' Checks which spot they're "close up" to
            If intCount = 7 Then
                ' Sets intNum to 0
                intNum = 0
                ' Changes background image
                BackgroundImage = My.Resources.livingroom
            ElseIf intCount = 6 Then
                ' Sets intNum to 0
                intNum = 0
                ' Checks if safe is locked or unlocked
                Select Case True
                        ' Changes background image
                    Case frmStart.intEnding = 0 Or frmStart.intEnding = -2 ' Safe still locked
                        BackgroundImage = My.Resources.bedroom
                    Case frmStart.intEnding = 1 Or frmStart.intEnding = -1 ' Safe unlocked
                        BackgroundImage = My.Resources.bdrmunlocked
                End Select
                ' Calls a private sub to play sound
                PlaySound()
            End If
        End If
    End Sub
    Private Sub RandomChance()
        ' Comes up with a random number

        ' Declares variables
        Dim rChance As New Random
        Dim intRandom As Integer

        ' Makes sure intRun is 0; that there isn't any encounters
        If intRun = 0 Then
            ' Determines how high the odds should be based off of intCounter
            Select Case intCounter
                Case Is = 0
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 15)
                Case Is = 1
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 10)
                Case Is = 2
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 8)
                Case Is = 3
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 5)
                Case Is = 4
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 4)
                Case Is = 5
                    ' Sets the value of intRandom to a random number
                    intRandom = rChance.Next(1, 3)
                Case Is = 6
                    ' Sets the value of intRandom to 1
                    intRandom = 1
            End Select

            ' Checks if intRandom is 1
            If intRandom = 1 Then
                ' Resets intCounter to 0
                intCounter = 0
                ' Sets intRun to 1
                intRun = 1
                ' Sets intEncounter to the value of intCount
                intEncounter = intCount
                ' Sets intRandom to -1 (To avoid errors)
                intRandom = -1
            ElseIf intRandom > 1 Then ' Checks that intRandom is greater than 1
                ' Adds 1 to intCounter
                intCounter += 1
            End If
        End If
    End Sub
    Private Sub Caught()
        ' Player failed to hide & was caught

        ' Sets intEnding to 0 if intEnding is equal to 1 and intEnding to -2 if it's -1
        If frmStart.intEnding = 1 Then
            frmStart.intEnding = 0
        ElseIf frmStart.intEnding = -1 Then
            frmStart.intEnding = -2
        End If
        ' Checks if frmJournal is showing
        If frmJournal.Visible = True Then
            ' Closes frmJournal
            frmJournal.Close()
        End If
        ' Shows form
        frmDeath.Show()
        ' Closes current form
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' Adds 1 to intSeconds for the amount of time the user has till they're caught

        ' Declares a variable
        Static intSeconds As Integer

        ' Checks if intRun is 1
        If intRun = 1 Or intRun = 2 Then
            ' Adds 1 to intSeconds
            intSeconds += 1
            ' Checks if the amount of time player has is up
            If intSeconds = 14 Then
                ' Checks if user is hiding
                If intNum = 1 Then
                    ' Checks if intEncounter is equal to the value of intCount
                    If intEncounter = intCount Then
                        ' Makes front arrow not visible
                        pbForward.Visible = False
                        ' Checks where user is hiding
                        Select Case intCount
                            Case Is = 3 ' Player is hiding by the front door
                                ' Changes background image
                                BackgroundImage = My.Resources.undertablewghost
                            Case Is = 5 ' Player is hiding in the bedroom
                                ' Changes background image
                                BackgroundImage = My.Resources.closetghoststaring
                        End Select
                        ' Enables regret timer and disables current timer
                        timerRegret.Enabled = True
                        Timer.Enabled = False
                        ' Stops playing chase ambience
                        My.Computer.Audio.Stop()
                    Else
                        ' Sets intRun & intSeconds to 0 and intEncounter to -1
                        intRun = 0
                        intSeconds = 0
                        intEncounter = -1
                        ' Calls private sub to stop playing ambience
                        PlaySound()
                    End If
                Else ' Checks if the amount of time left is up
                    ' Calls private sub
                    Caught()
                End If
            End If
        End If
    End Sub
    Private Sub PlaySound()
        ' Plays sounds

        ' Declares a variable
        Static intM As Integer ' Used to check if ambience is playing; 0 = ambience is not playing, 1 = ambience is playing

        ' Checks if ambience isn't playing
        If intM = 0 Then
            ' Checks if intRun is greater than or equal to 1
            If intRun >= 1 Then
                ' Adds 1 to intM
                intM += 1
                ' Plays chase ambience
                My.Computer.Audio.Play(My.Resources.chaseambience, AudioPlayMode.BackgroundLoop)
            Else
                ' Plays a sound
                My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.Background)
            End If
        Else
            ' Checks if intRun is 0; Chase has stopped
            If intRun = 0 Then
                'Sets intM to 0
                intM = 0
                ' Stops playing the chase ambience
                My.Computer.Audio.Stop()
            End If
        End If
    End Sub

    Private Sub frmEscape_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Sets up starting values of variables & makes certain picture boxes not visible

        ' Declares variables
        Dim rChance As New Random
        Dim intChance As Integer

        ' Sets the value of intChance to a random value
        intChance = rChance.Next(1, 10)
        ' Makes backwards, left, right, and hide arrows not visible
        pbBackward.Visible = False
        pbLeft.Visible = False
        pbRight.Visible = False
        pbHide.Visible = False

        ' Checks if strArea's value isn't already "ES" and sets it to "ES"
        If frmStart.strArea = "R" Then
            frmStart.strArea = "ES"
        End If

        ' Checks if intChance is 1
        If intChance = 1 Then ' Changes background images (to a specific image depending on if the statement is true)
            BackgroundImage = My.Resources.start0ES
        Else
            BackgroundImage = My.Resources.escapestart0
        End If
    End Sub

    Private Sub pbHide_Click(sender As Object, e As EventArgs) Handles pbHide.Click
        ' Allows user to hide

        ' Makes sure user is in the right area
        Select Case intCount
            Case Is = 3 ' User is by front door
                ' Sets intNum to 1
                intNum = 1
                ' Makes back arrow and hide arrow not visible & makes forward arrow visible
                pbForward.Visible = True
                pbBackward.Visible = False
                pbHide.Visible = False
                ' Changes background image
                BackgroundImage = My.Resources.undertable
            Case Is = 5 ' User is in bedroom
                ' Sets intNum to 1
                intNum = 1
                ' Makes back arrow and hide arrow not visible
                pbBackward.Visible = False
                pbHide.Visible = False
                ' Changes background image
                BackgroundImage = My.Resources.closet
        End Select
    End Sub

    Private Sub timerRegret_Tick(sender As Object, e As EventArgs) Handles timerRegret.Tick
        ' Adds 1 to a variable for each second

        ' Declares a variable
        Static intRegret As Integer

        ' Adds 1 to intRegret
        intRegret += 1

        ' Checks if intRegret is 6
        If intRegret = 6 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.woodcreak, AudioPlayMode.WaitToComplete)
            ' Calls a private sub
            Caught()
        End If
    End Sub

    Private Sub timerEnd_Tick(sender As Object, e As EventArgs) Handles timerEnd.Tick
        ' For ending 1

        ' Declares a variable
        Static intSeconds As Integer

        ' Adds 1 to intSeconds
        intSeconds += 1

        ' Checks if intSeconds is 2
        If intSeconds = 2 Then
            ' Plays a sound
            My.Computer.Audio.Play(My.Resources.caught, AudioPlayMode.WaitToComplete)
        ElseIf intSeconds = 5 Then ' Checks if intSeconds is 5
            ' Makes intEnding = 0
            frmStart.intEnding = 0
            ' Shows frmStart
            frmStart.Show()
            ' Closes current form
            Me.Close()
        End If
    End Sub
End Class