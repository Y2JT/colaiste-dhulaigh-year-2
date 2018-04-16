Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Program Ending", "Alert")
        End     'closes the program
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Text = ""   'clear text box Username
        txtPassword.Text = ""   'clear text box Password
        txtUsername.Focus()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtUsername.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Username", "Error")
            txtUsername.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Or IsNumeric(txtPassword.Text) Then
            Beep()
            MessageBox.Show("Please Enter Password", "Error")
            txtPassword.Focus()
            Exit Sub
        End If
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            Me.Hide()
            Form2.Show()
        Else
            Beep()
            MessageBox.Show("Invalid Username or Password", "Error")
            txtUsername.Focus()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        MessageBox.Show("© Joey Tierney 2015", "Created by")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub
End Class
