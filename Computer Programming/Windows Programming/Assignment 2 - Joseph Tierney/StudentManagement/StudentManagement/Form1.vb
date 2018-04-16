Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear textboxes
        txtUsername.Text = ""
        txtPassword.Text = ""

        'focus cursor on txtUsername
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'if the username text box is blank
        If txtUsername.Text = "" Then
            Beep()
            MessageBox.Show("Please enter your Username", "Error")
            'focus cursor on username text box
            txtUsername.Focus()
            Exit Sub 'break
        End If
        'if the password text box is blank
        If txtPassword.Text = "" Then
            Beep()
            MessageBox.Show("Please enter your Password", "Error")
            'focus cursor on password text box
            txtPassword.Focus()
            Exit Sub 'break
        End If

        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            MessageBox.Show("Welcome Admin, to the Student Management System", "Alert")
            Form2.Show() 'show form 2
            Me.Hide()   'hide this form
        Else
            Beep()
            MessageBox.Show("Invalid Username or Password", "Error")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by Joseph Tierney", "Info")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub
End Class
