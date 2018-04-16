Public Class Form1
    Dim num1 As Integer = 0
    Dim num2 As Integer = 0
    Dim total As Integer = 0
    Dim sign As String
    Dim flag As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1Zero_Click(sender As Object, e As EventArgs) Handles btn1Zero.Click
        txtMainDis.Text = txtMainDis.Text & 0
    End Sub

    Private Sub btn2One_Click(sender As Object, e As EventArgs) Handles btn2One.Click
        txtMainDis.Text = txtMainDis.Text & 1
    End Sub

    Private Sub btn3Two_Click(sender As Object, e As EventArgs) Handles btn3Two.Click
        txtMainDis.Text = txtMainDis.Text & 2
    End Sub

    Private Sub btn4Three_Click(sender As Object, e As EventArgs) Handles btn4Three.Click
        txtMainDis.Text = txtMainDis.Text & 3
    End Sub

    Private Sub btn5Four_Click(sender As Object, e As EventArgs) Handles btn5Four.Click
        txtMainDis.Text = txtMainDis.Text & 4
    End Sub

    Private Sub btn6Five_Click(sender As Object, e As EventArgs) Handles btn6Five.Click
        txtMainDis.Text = txtMainDis.Text & 5
    End Sub

    Private Sub btn7Six_Click(sender As Object, e As EventArgs) Handles btn7Six.Click
        txtMainDis.Text = txtMainDis.Text & 6
    End Sub

    Private Sub btn8Seven_Click(sender As Object, e As EventArgs) Handles btn8Seven.Click
        txtMainDis.Text = txtMainDis.Text & 7
    End Sub

    Private Sub btn9Eight_Click(sender As Object, e As EventArgs) Handles btn9Eight.Click
        txtMainDis.Text = txtMainDis.Text & 8
    End Sub

    Private Sub btn10Nine_Click(sender As Object, e As EventArgs) Handles btn10Nine.Click
        txtMainDis.Text = txtMainDis.Text & 9

    End Sub

    Private Sub btn14Clear_Click(sender As Object, e As EventArgs) Handles btn14Clear.Click
        txtMainDis.Text = ""
        num1 = 0
        num2 = 0
        sign = ""
    End Sub

    Private Sub btn11Plus_Click(sender As Object, e As EventArgs) Handles btn11Plus.Click
        num1 = Val(txtMainDis.Text)
        txtMainDis.Text = ""
        sign = "+"
    End Sub

    Private Sub btn12Equals_Click(sender As Object, e As EventArgs) Handles btn12Equals.Click
        num2 = Val(txtMainDis.Text)
        If sign Is "+" Then
            total = num1 + num2
            txtMainDis.Text = total
        End If
        If sign Is "-" Then
            total = num1 - num2
            txtMainDis.Text = total
        End If
        If sign Is "*" Then
            total = num1 * num2
            txtMainDis.Text = total
        End If
        If sign Is "/" Then
            total = num1 / num2
            txtMainDis.Text = total
        End If
    End Sub

    Private Sub btn13Minus_Click(sender As Object, e As EventArgs) Handles btn13Minus.Click
        num1 = Val(txtMainDis.Text)
        txtMainDis.Text = ""
        sign = "-"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        num1 = Val(txtMainDis.Text)
        txtMainDis.Text = ""
        sign = "*"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        num1 = Val(txtMainDis.Text)
        txtMainDis.Text = ""
        sign = "/"
    End Sub
End Class
