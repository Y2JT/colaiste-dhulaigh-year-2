Public Class Form1
    Dim total As Integer = 0

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now()
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        total = 0

        If txtAssign.Text = "" Or Not IsNumeric(txtAssign.Text) Or Val(txtAssign.Text) > 60 Then
            Beep()
            MessageBox.Show("Please Enter Assignment Grade (Max 60)", "Error")
            txtAssign.Focus()
            Exit Sub
        ElseIf txtGrade.Text = "" Or Not IsNumeric(txtGrade.Text) Or Val(txtGrade.Text) > 40 Then
            Beep()
            MessageBox.Show("Please Enter Exam Grade (Max 40)", "Error")
            txtGrade.Focus()
            Exit Sub
        End If

        total += Val(txtAssign.Text) + Val(txtGrade.Text)

        If total > 79 Then
            lblResults.Text = "You got a Distinction: " & total & "%"
        ElseIf total > 64 And total < 80 Then
            lblResults.Text = "You got a Merit: " & total & "%"
        ElseIf total > 49 And total < 65 Then
            lblResults.Text = "You got a Pass: " & total & "%"
        Else
            lblResults.Text = "You were Unsuccessful: " & total & "%"
        End If

    End Sub
End Class
