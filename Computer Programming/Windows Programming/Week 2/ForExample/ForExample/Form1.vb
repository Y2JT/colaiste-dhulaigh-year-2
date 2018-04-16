Public Class Form1
    'declare a counter
    Dim count As Integer = 0
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'clear the label
        lblDisplay.Text = "" 'make the text on the label the empty string
        'start loop to print out numbers 1 to 10
        For i = 1 To 10
            lblDisplay.Text = lblDisplay.Text & " " & i

        Next
        'if count is greater than or equal to 10 don't start the timer
        'i.e. if Enter button has already been pressed
        If count >= 10 Then
            Timer1.Enabled = False
        Else
            'starts timer
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'increment the counter
        count = count + 1   'or count += 1
        lblDisplay2.Text = lblDisplay2.Text & " " & count
        'Beep()
        'stop counting
        If count = 10 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblDisplay3.Text = ""
        'print the even numbers from 1 to 10
        For i = 2 To 10 Step 2  'step 2 means go up in 2's | For i = 10 To Step -2
            lblDisplay3.Text = lblDisplay3.Text & " " & i
        Next
    End Sub
End Class
