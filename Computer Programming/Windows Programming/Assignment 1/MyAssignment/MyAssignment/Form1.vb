Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""   'clear the text box
        txtPassword.Text = ""
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please enter username")
            txtName.Focus()
            Exit Sub
        End If
        If txtPassword.Text = "" Or IsNumeric(txtPassword.Text) Then
            Beep()
            MessageBox.Show("Please enter password")
            txtPassword.Focus()
            Exit Sub
        End If
        If txtName.Text = "admin" And txtPassword.Text = "password" Then
            Me.Hide()
            Form2.show()
        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub
End Class
