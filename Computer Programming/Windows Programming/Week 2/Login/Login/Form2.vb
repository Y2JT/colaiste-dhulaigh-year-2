Public Class Form2
    Dim count As Integer = 0

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'start timer
        Timer1.Enabled = True
        'don't allow the user to click on the start button
        btnStart.Enabled = False
        'allow the user to click on the stop buttom
        btnStop.Enabled = True
        btnStop.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'increment the counter
        count += 1
        'display the time
        lblDisplay.Text = count
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        'stop timer
        Timer1.Enabled = False
        'allow the user to click on start
        btnStart.Enabled = True
        'don't allow the user to click on the stop buttom
        btnStop.Enabled = False
        'show the clear button
        btnClear.Visible = True
        btnStop.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the counter
        count = 0
        'display the timer is cleared
        lblDisplay.Text = 0
        'hide clear button
        btnClear.Visible = False
    End Sub
End Class