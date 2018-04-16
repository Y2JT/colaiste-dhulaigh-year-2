Public Class frmLogin

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'stop the program
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the text boxes
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'check username and password
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            form2.show()    'show the next form
            Me.Hide()       'hide the current form
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
