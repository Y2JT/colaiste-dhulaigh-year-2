Public Class Form1
    Dim quote As Integer = 250

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'reset quote
        quote = 250

        'VALIDATION
        'check if name text box is blank
        If txtname.Text = "" Then
            MessageBox.Show("Please Enter Name", "Error")
            txtname.Focus()
            'check if age is blank, not a number or less than 17
        ElseIf txtage.Text = "" Or Not IsNumeric(txtage.Text) Or Val(txtage.Text) < 17 Then
            MessageBox.Show("Please Enter Valid Age", "Error")
            txtage.Focus()
            'check raido buttons for gender
        ElseIf rdomale.Checked = False And rdofemale.Checked = False Then
            MessageBox.Show("Please Select Gender", "Error")
            'check for engine size
        ElseIf cmbSize.Text = "Please select" Then
            MessageBox.Show("Please Select Engine Size", "Error")
            cmbSize.Focus()
        End If

        'calculate quote
        If Val(txtage.Text) < 30 Then
            'add to the quote
            quote += 200
        Else
            quote += 100
        End If

        If cmbSize.Text = "1000cc" Then
            quote += 100
        Else
            quote += 200
        End If

        If rdofemale.Checked = True Then
            quote += 400
        End If
        If rdomale.Checked = True Then
            quote += 200
        End If

        If chkBreakdown.Checked = True Then
            quote += 50
        End If
        If chkWindscreen.Checked = True Then
            quote += 75
        End If

        'display the quote
        lblquote.Text = "Your Quote is: €" & quote
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Closing", "Alert")
    End Sub
End Class
