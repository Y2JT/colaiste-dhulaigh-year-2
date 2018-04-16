Public Class Form1
    Dim quote As Integer = 250
    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        'reset quote
        quote = 250
        'remove the stars
        lblStarName.Visible = False
        lblStarAge.Visible = False
        lblStarEngine.Visible = False
        lblStarGender.Visible = False

        'ALL VALIDATION DONE FIRST
        'check txtname is filled
        If txtName.Text = "" Then   ' "" is the empty string
            'display star
            lblStarName.Visible = True
            'give user an error message
            MessageBox.Show("Please enter a name", "Insurance Quote")
            'put the cursor in the textbox
            txtName.Focus()

            'check if the age has an empty string, or non-numeric characters or is less than 17
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.Text) Or Val(txtAge.Text) < 17 Then
            'display the star
            lblStarAge.Visible = True
            'display message box
            MessageBox.Show("Please enter a valid age", "Insurance Quote")
            'put the cursor in the textbox
            txtAge.Focus()

            'check for Engine Size
        ElseIf cboEngine.Text = "Please select" Then
            'display the star
            lblStarEngine.Visible = True
            'display message box
            MessageBox.Show("Please select an engine size", "Insurance Quote")
            'put the cursor on the combo box
            cboEngine.Focus()

            'check for raido buttons
        ElseIf rdoFemale.Checked = False And rdoMale.Checked = False Then
            'display the star
            lblStarGender.Visible = True
            'display the message box
            MessageBox.Show("Please select a gender", "Insurance Quote")
        End If

        'calculate quote
        If Val(txtAge.Text) < 30 Then
            'add to the quote
            quote += 200
        Else
            quote += 100
        End If

        If cboEngine.Text = "1000cc" Then
            quote += 100
        Else
            quote += 200
        End If

        If rdoFemale.Checked = True Then
            quote += 100
        End If
        If rdoMale.Checked = True Then
            quote += 200
        End If

        If chkBreakdown.Checked = True Then
            quote += 50
        End If
        If chkWindscreen.Checked = True Then
            quote += 75
        End If

        'display the quote
        lblQuote.Text = "Your Quote is: €" & quote
    End Sub
End Class
