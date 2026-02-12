Option Strict On
Option Explicit On
Option Infer Off
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Checks if the user entered the right username and password

        ' Declares variables
        Const strPassword As String = "fear"
        Const strUsername As String = "shadow"
        Dim strPass As String
        Dim strUser As String

        ' Checks if one of the textboxes is empty
        If txtUsername.Text = String.Empty Or txtPassword.Text = String.Empty Then
            MessageBox.Show("Please enter both a password and your username", "Error: Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Reads from the textboxes
            strUser = txtUsername.Text
            strPass = txtPassword.Text

            ' Checks if username is correct
            If strUsername = strUser.ToLower Then
                ' Checks if password is correct
                If strPassword = strPass.ToLower Then
                    GenerateCode() ' Calls sub to generate code
                    ' Makes backarrow visible in frmRoom
                    frmRoom.pbBackArrow.Visible = True
                    ' Sets strT in frmRoom to "T"
                    frmRoom.strT = "T"
                    Me.Close() ' Closes current form
                Else ' Displays a message indicating that the user incorrectly entered the password
                    MessageBox.Show("Incorrect password.", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else ' Displays a message indicating that the user incorrectly entered the username or password
                MessageBox.Show("Incorrect password or username.", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub GenerateCode()
        ' Generates a random piece of code (for the combolock on the closet)

        ' Declares variables
        Dim outCode As IO.StreamWriter
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim randomCode As New Random

        ' Sets the values of the variables (intNum1, intNum2, intNum3) to a random number
        intNum1 = randomCode.Next(0, 10)
        intNum2 = randomCode.Next(0, 10)
        intNum3 = randomCode.Next(0, 10)

        ' Creates and opens a file for output
        outCode = IO.File.CreateText("code.txt")

        ' Writes the randomized code into the file
        outCode.WriteLine(intNum1 & intNum2 & intNum3)

        ' Closes the file
        outCode.Close()

        ' Display combolock code
        MessageBox.Show("For my closet: " & intNum1 & intNum2 & intNum3, "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Sets intC's value to 1
        frmRoom.intC = 1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Closes form

        ' Makes backarrow visible in frmRoom
        frmRoom.pbBackArrow.Visible = True
        ' Sets strT in frmRoom to "T"
        frmRoom.strT = "T"
        ' Closes form
        Me.Close()
    End Sub
End Class