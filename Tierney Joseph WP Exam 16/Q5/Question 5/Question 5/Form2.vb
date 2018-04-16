Imports System.IO
Public Class Form2
    Private OpenFile As FileStream
    Private FileOfStream As StreamReader
    Private WriteFile As StreamWriter

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numlength As Integer = 50
    Dim numrecords As Integer
    Dim numInFile = 0

    Dim names(numlength) As String
    Dim ages(numlength) As Integer

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                End If
            Next

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Name", "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAge.Text = "" Or Not IsNumeric(txtAge.Text) Then
            Beep()
            MessageBox.Show("Please Enter Age", "Error")
            txtAge.Focus()
            Exit Sub
        End If

        Try
            OpenFile = New FileStream("details.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & ages(i))
            Next

            MessageBox.Show("File Updated on " & Now())

            WriteFile.Close()
            OpenFile.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try

        Form1.Show()
        Me.Hide()

        txtName.Text = ""
        txtAge.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class