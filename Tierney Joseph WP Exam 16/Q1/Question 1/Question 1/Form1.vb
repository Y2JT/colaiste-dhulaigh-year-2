Public Class Form1
    Dim quote As Integer = 250
    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        quote = 250

        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Name", "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.Text) Or Val(txtAge.Text) < 18 Then
            Beep()
            MessageBox.Show("Please Enter Age (18+)", "Error")
            txtAge.Focus()
            Exit Sub
        ElseIf rdoFemale.Checked = False And rdoMale.Checked = False Then
            Beep()
            MessageBox.Show("Please Select Gender", "Error")
            Exit Sub
        ElseIf cboEngine.Text = "Please select" Then
            Beep()
            MessageBox.Show("Please Select Engine Size", "Error")
            cboEngine.Focus()
            Exit Sub
        End If

        If Val(txtAge.Text) > 35 Then
            quote += 150
        Else
            quote += 100
        End If
        If rdoFemale.Checked = True Then
            quote += 200
        Else
            quote += 100
        End If
        If cboEngine.Text = "1000cc" Then
            quote += 75
        Else
            quote += 130
        End If
        If chkBreak.Checked = True Then
            quote += 250
        End If
        If chkWind.Checked = True Then
            quote += 50
        End If

        lblQuote.Text = "Your Quote is: €" & quote

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub
End Class
