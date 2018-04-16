Public Class Form1
    Dim quote As Integer = 250
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'reset quote
        quote = 250

        'VALIDATION
        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Name", "Alert")
            txtName.Focus()
            Exit Sub
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.text) Or Val(txtAge.text) < 17 Then
            MessageBox.Show("Please Enter Age (17+)", "Alert")
            txtAge.Focus()
            Exit Sub
        ElseIf rdoFemale.Checked = False And rdoMale.Checked = False Then
            MessageBox.Show("Please Select Gender", "Alert")
            Exit Sub
        ElseIf cboEngine.Text = "Please select" Then
            MessageBox.Show("Please Select Engine Size", "Alert")
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
            quote += 300
        Else
            quote += 200
        End If
        If cboEngine.Text = "1000cc" Then
            quote += 75
        Else
            quote += 140
        End If
        If chkBreak.Checked = True Then
            quote += 250
        End If
        If chkWind.Checked = True Then
            quote += 100
        End If

        lblQuote.Text = "Your Quote is: €" & quote

    End Sub
End Class
