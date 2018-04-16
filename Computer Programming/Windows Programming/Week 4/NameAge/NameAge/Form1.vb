Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please enter your name")
            txtName.Focus()
            Exit Sub 'break
        End If
        If txtPassword.Text = "" Then
            Beep()
            MessageBox.Show("Please enter password")
            txtPassword.Focus()
            Exit Sub
        End If
        If txtName.Text = "admin" And txtPassword.Text = "password" Then
            Form2.Show()
            Me.Hide()
        Else
            Beep()
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

End Class
