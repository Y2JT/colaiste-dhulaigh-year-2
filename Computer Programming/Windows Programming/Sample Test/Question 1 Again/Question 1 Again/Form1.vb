Public Class Form1
    Dim quote As Integer = 250
    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        'reset quote 250
        quote = 250

        'VALIDATION
        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Name", "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.text) Or Val(txtAge.text) < 17 Then
            MessageBox.Show("Please Enter Valid Age (17+)", "Error")
            txtAge.Focus()
            Exit Sub
        ElseIf rdoFemale.Checked = False And rdoMale.Checked = False Then
            MessageBox.Show("Please Select Gender", "Error")
            Exit Sub
        ElseIf cboEngine.Text = "Please select" Then
            MessageBox.Show("Please Select Engine Size", "Error")
            cboEngine.Focus()
            Exit Sub
        End If

        'ADD TO QUOTE
        If Val(txtAge.Text) < 30 Then
            quote += 150
        Else
            quote += 250
        End If
        If rdoFemale.Checked = True Then
            quote += 100
        Else
            quote += 150
        End If
        If cboEngine.Text = "1000cc" Then
            quote += 50
        Else
            quote += 75
        End If
        If chkBreakdown.Checked = True Then
            quote += 200
        End If
        If chkWindscreen.Checked = True Then
            quote += 100
        End If

        lblTotal.Text = "Your Quote is: €" & quote

    End Sub
End Class
