Public Class Form1
    Dim ages(5) As Integer
    Dim total As Integer = 0
    Dim average As Integer
    Dim highest As Integer = 0
    Dim lowest As Integer = 100
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAges_Click(sender As Object, e As EventArgs) Handles btnAges.Click
        For i = 0 To 4
            ages(i) = InputBox("Enter age " & (i + 1))
            'add the age to the total
            total += ages(i)
            'check for highest
            If ages(i) > highest Then
                highest = ages(i)
            End If
            If ages(i) < lowest Then
                lowest = ages(i)
            End If
        Next
        'get average
        average = total / 5
        'display the average
        MessageBox.Show("Average is " & average)
        'display the highest
        MessageBox.Show("Highest is " & highest)
        'display the lowest
        MessageBox.Show("Lowest is" & lowest)
    End Sub
End Class
