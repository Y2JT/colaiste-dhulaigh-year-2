Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End     'ends program
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear textboxes
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Then
            Beep()
            MessageBox.Show("Please enter your username")
            txtUser.Focus()
            Exit Sub 'break
        End If
        If txtPass.Text = "" Then
            Beep()
            MessageBox.Show("Please enter password")
            txtPass.Focus()
            Exit Sub
        End If
        If txtUser.Text = "admin" And txtPass.Text = "password" Then
            Form2.Show()
            Me.Hide()
        Else
            Beep()
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
