Public Class Form1
    'create counter variables to count down
    Dim counter1 As Integer = 5
    Dim counter2 As Integer = 7
    Dim counter3 As Integer = 5
    Dim counter4 As Integer = 7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'take 1 from the counter if its greater than zero
        If counter1 > 0 Then
            counter1 = counter1 - 1
        End If

        Button1.Text = "Mars " & counter1

        'if the counter is less than 1 disable the button
        If counter1 < 1 Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'enable the timer
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'take 1 from the counter if its greater than zero
        If counter2 > 0 Then
            counter2 = counter2 - 1
        End If

        Button2.Text = "Twix " & counter2

        'if the counter is less than 1 disable the button
        If counter2 < 1 Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'take 1 from the counter if its greater than zero
        If counter3 > 0 Then
            counter3 = counter3 - 1
        End If

        Button3.Text = "Kitkat " & counter3

        'if the counter is less than 1 disable the button
        If counter3 < 1 Then
            Button3.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'take 1 from the counter if its greater than zero
        If counter4 > 0 Then
            counter4 = counter4 - 1
        End If

        Button4.Text = "Snickers " & counter4

        'if the counter is less than 1 disable the button
        If counter4 < 1 Then
            Button4.Enabled = False
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by: Joey Tierney", "Alert")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'reset the form
        MessageBox.Show("Form Reset", "Alert")

        'set the counters to their original state
        counter1 = 5
        counter2 = 7
        counter3 = 5
        counter4 = 7

        'set the text on the buttons to their original state
        Button1.Text = "Mars " & counter1
        Button2.Text = "Twix " & counter2
        Button3.Text = "Kitkat " & counter3
        Button4.Text = "Snickers " & counter4

        'enable the buttons
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub
End Class
