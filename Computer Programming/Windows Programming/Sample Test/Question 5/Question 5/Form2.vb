Imports System.IO
Public Class Form2

    Private OpenFile As FileStream
    Private FileOfStream As StreamReader
    Private WriteFile As StreamWriter

    Dim ArrayLine() As String
    Dim numInFile = 0
    Dim LineOfFile As String
    Dim numlength As Integer = 50

    Dim numrecords As Integer
    Dim names(numlength) As String
    Dim ages(numlength) As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            FileOfStream = New StreamReader(OpenFile)

            For i = 0 To numInFile - 1
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
            MessageBox.Show("Cannont access file")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            OpenFile = New FileStream("details.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & ages(i))
            Next
            WriteFile.Close()
            MessageBox.Show("File Updated On " & Now())

        Catch ex As Exception
            MessageBox.Show("Cannot access file", "Error")
        End Try

        Form1.Show()
        Me.Hide()

    End Sub
End Class