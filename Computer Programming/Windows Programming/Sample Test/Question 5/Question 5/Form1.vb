Imports System.IO
Public Class Form1

    Private OpenFile As FileStream
    Private FileOfStream As StreamReader
    Private WriteFile As StreamWriter

    Dim ArrayLine() As String
    Dim numInFile = 0
    Dim LineOfFile As String
    Dim numlength As Integer = 50

    Dim numrecords As Integer = 0
    Dim names(numlength) As String
    Dim ages(numlength) As Integer

    Dim output As String = "Name" & vbTab & "Age" & vbNewLine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            FileOFStream = New StreamReader(OpenFile)

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
            FileOFStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannot access file", "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        MessageBox.Show(output, "File Details")
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        txtName.Enabled = True
        txtAge.Enabled = True
        btnSave.Enabled = True
        btnDetails.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            OpenFile = New FileStream("details.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & ages(i))
            Next
            WriteFile.Close()
            'OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())
        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try
        btnDetails.Enabled = True
        txtName.Enabled = False
        txtAge.Enabled = False
        btnSave.Enabled = False
        txtName.Text = ""
        txtAge.Text = ""
    End Sub
End Class
