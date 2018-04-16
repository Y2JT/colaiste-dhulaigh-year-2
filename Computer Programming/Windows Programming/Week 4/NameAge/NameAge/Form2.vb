Public Class Form2

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAge.Text = ""
        lblAgeStar.Text = ""
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtAge.Text = "" Then
            Beep()
            MessageBox.Show("Please enter an age")
            txtAge.Focus()
            Exit Sub
        End If

        'clear label
        lblAgeStar.Text = ""

        'put txtage.text stars on the label
        For i = 1 To Val(txtAge.Text)
            lblAgeStar.Text = lblAgeStar.Text & "*"
        Next
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class