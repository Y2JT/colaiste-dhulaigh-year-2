Public Class Form1
    'take in 5 ages and store them in arrays
    'tell the user if anyone is under 18
    'display the average age

    Dim ages(5) As Integer  'array to hold the ages, length is 5
    Dim total As Integer = 0
    Dim average As Integer
    Dim flag As Boolean = False 'to tell us if someone is under 18
    Dim numbers() As Integer = {18, 19, 20}

    Private Sub btnInputAges_Click(sender As Object, e As EventArgs) Handles btnInputAges.Click
        'start the loop
        For i = 0 To 4
            ages(i) = InputBox("Enter age " & (i + 1))
            'add the age to the total
            total += ages(i)
            'check if the person is under 18
            If ages(i) < 18 Then
                'change the value of the flag
                flag = True
            End If
        Next
        'get the average
        average = total / 5
        'display the average
        MessageBox.Show("Average is " & average)

        'tell the user if anyone is under 18
        If flag = True Then
            MessageBox.Show("At least one person is under 18")
        Else
            MessageBox.Show("No one is under 18")
        End If

        MessageBox.Show("Middle value in 'numbers' array is " & numbers(1))

        'add all ages to a string and display the string
        Dim output As String = "Ages are: " & vbNewLine
        For i = 0 To 4
            output += vbNewLine & String.Format(ages(i))
        Next

        'display output
        MessageBox.Show(output)

    End Sub
End Class
