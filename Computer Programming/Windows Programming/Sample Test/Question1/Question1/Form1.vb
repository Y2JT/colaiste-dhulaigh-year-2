Public Class Form1
    Dim quote As Integer = 250
    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        'reset quote
        quote = 250

        'VALIDATION
        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Name", "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.text) Or Val(txtAge.text) < 17 Then
            MessageBox.Show("Please Enter Valid Age (17+)", "Error")
            Exit Sub
        ElseIf rdoFemale.Checked = False And rdoMale.Checked = False
            MessageBox.Show("Please Select Gender", "Error")
            Exit Sub
        ElseIf cboEngine.Text = "Please select" Then
            MessageBox.Show("Please Select Engine Size", "Error")
            cboEngine.Focus()
            Exit Sub
        End If

        'ADD TO QUOTE
        If Val(txtAge.Text) < 35 Then
            quote += 150
        Else
            quote += 250
        End If
        If rdoFemale.Checked = True Then
            quote += 200
        Else
            quote += 100
        End If
        If cboEngine.Text = "1000cc" Then
            quote += 100
        Else
            quote += 200
        End If
        If chkBreakdown.Checked = True Then
            quote += 150
        End If
        If chkWindscreen.Checked = True Then
            quote += 200
        End If

        lblTotal.Text = "Your Quote is: €" & quote
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub
End Class
