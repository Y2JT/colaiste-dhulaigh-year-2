Public Class Form1
    Dim Total As Double = 0
    Dim num1 As Double = 0
    Dim num2 As Double = 0
    Dim num3 As Double = 0
    Dim mgrade As Double
    Dim mname As String

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please Enter Name")
            txtName.Focus()
            'check for empty String and non-numeric characters
        ElseIf txtAssign1.Text = "" Or Not IsNumeric(txtAssign1.Text) Then
            MessageBox.Show("Please Enter Grade 1 (Digits Only)")
            txtAssign1.Focus()
            'check for empty String and non-numeric characters
        ElseIf txtAssign2.Text = "" Or Not IsNumeric(txtAssign2.Text) Then
            MessageBox.Show("Please Enter Grade 2 (Digits Only)")
            txtAssign2.Focus()
            'check for empty String and non-numeric characters
        ElseIf txtAssign3.Text = "" Or Not IsNumeric(txtAssign1.Text) Then
            MessageBox.Show("Please Enter Grade 3 (Digits Only)")
            txtAssign3.Focus()
        End If
        mname = txtName.Text        'assign name to a string
        num1 = Val(txtAssign1.Text) 'assign to the double
        num2 = Val(txtAssign2.Text) 'assign to the double
        num3 = Val(txtAssign3.Text) 'assign to the double

        If num1 > 100 Or num1 < 0 Then
            MessageBox.Show("Invalid Grade")
            txtAssign1.Focus()
        ElseIf num2 > 100 Or num2 < 0 Then
            MessageBox.Show("Invalid Grade")
        ElseIf num3 > 100 Or num3 < 0 Then
            MessageBox.Show("Invalid Grade")
        Else
            mgrade = (num1 * 0.3) + (num2 * 0.4) + (num3 * 0.3)
            lblTotal.Text = mname + ": grade is " + mgrade.ToString + "% " 'convert grade to String
        End If
        btnPunk.Visible = False
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        txtName.Text = ""
        txtAssign1.Text = ""
        txtAssign2.Text = ""
        txtAssign3.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnPunk_Click(sender As Object, e As EventArgs) Handles btnPunk.Click
        btnPunk.Visible = False
        Me.Hide()
        Form2.Show()
    End Sub
End Class
