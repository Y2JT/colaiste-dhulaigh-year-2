Public Class Form1
    Dim run As Integer = 0

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'if text box is empty
        If txtRun.Text = "" Or Not IsNumeric(txtRun.Text) Then
            Beep()
            MessageBox.Show("Please Enter Value", "Error")
            Exit Sub
        End If

        If txtRun.Text >= 45 Then
            MessageBox.Show("Fast! :D")
            Exit Sub
        Else
            MessageBox.Show("Too Slow! D:")
            Exit Sub
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub
End Class
