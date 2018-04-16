Imports System.IO   'needed for reading files
Public Class Form1
    'GLOBAL VARIABLES

    Dim names(5) As String
    Dim ages(5) As Integer

    Dim numrecords As Integer               'holds the number of records in the file
    Private OpenFile As FileStream          'needed to read from the file
    Private readerStream As StreamReader    'needed to read from the file

    Dim LineOfFile As String                'needed to read a line of the file
    Dim ArrayLine() As String               'needed to hold a line from the file

    Dim output As String = "Name " & vbTab & "Age " & vbNewLine & vbNewLine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open the file connections
            OpenFile = New FileStream("nameage.txt", FileMode.Open, FileAccess.Read)
            readerStream = New StreamReader(OpenFile)

            'read from the file
            For i = 0 To 99
                'stream in the data line by line
                LineOfFile = readerStream.ReadLine()
                'check if the line is blank
                If LineOfFile IsNot Nothing Then
                    numrecords = numrecords + 1     'increment numrecords
                    'split the line
                    ArrayLine = LineOfFile.Split(","c)
                    names(i) = ArrayLine(0)
                    ages(i) = ArrayLine(1)

                    output += names(i) & vbTab & ages(i) & vbNewLine
                End If
            Next

            'close the stream
            OpenFile.Close()
            readerStream.Close()

        Catch ex As Exception
            MessageBox.Show("Could not open file", "File Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(output, "File Details")
    End Sub
End Class
