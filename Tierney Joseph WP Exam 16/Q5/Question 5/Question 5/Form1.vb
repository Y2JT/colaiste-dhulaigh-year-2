Imports System.IO
Public Class Form1
    Private OpenFile As FileStream
    Private FileOfStream As StreamReader

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numlength As Integer = 50
    Dim numrecords As Integer
    Dim numInFile = 0

    Dim names(numlength) As String
    Dim ages(numlength) As Integer

    Dim output As String = "Name" & vbTab & "Age" & vbNewLine

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            FileOfStream = New StreamReader(OpenFile)

            For i = 0 To numlength
                LineOfFile = FileOfStream.ReadLine()
                If LineOfFile IsNot Nothing Then
                    numrecords += 1
                    ArrayLine = LineOfFile.Split(","c)
                    names(i) = ArrayLine(0)
                    ages(i) = ArrayLine(1)
                    output += names(i) & vbTab & ages(i) & vbNewLine
                End If
            Next

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(output, "File Details")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
