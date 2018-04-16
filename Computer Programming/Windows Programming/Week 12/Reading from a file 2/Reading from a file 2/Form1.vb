Imports System.IO   'needed for reading files
Public Class Form1
    'GLOBAL VARIABLES

    Dim names(8) As String
    Dim subject(8) As String
    Dim grades(8) As Integer

    Private OpenFile As FileStream          'needed to read from the file
    Private readerStream As StreamReader    'needed to read from the file

    Dim numrecords As Integer               'holds the number of records in the file
    Dim LineOfFile As String                'needed to read a line of the file
    Dim ArrayLine() As String               'needed to hold a line from the file

    Dim Alloutput As String = "Name " & vbTab & "Subject " & vbTab & "Grade " & vbNewLine & vbNewLine
    Dim Passoutput As String = "Programming Passes " & vbNewLine & "Name " & vbTab & "Grade " & vbNewLine & vbNewLine
    Dim Failoutput As String = vbNewLine & "Programming Fails " & vbNewLine & "Name " & vbTab & "Grade " & vbNewLine & vbNewLine
    Dim WebPassoutput As String = "Web Passes " & vbNewLine & "Name " & vbTab & "Grade " & vbNewLine & vbNewLine
    Dim WebFailoutput As String = vbNewLine & "Web Fails " & vbNewLine & "Name " & vbTab & "Grade " & vbNewLine & vbNewLine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open the file connections
            OpenFile = New FileStream("namesubjectgrade.txt", FileMode.Open, FileAccess.Read)
            readerStream = New StreamReader(OpenFile)

            'read from the file
            For i = 0 To 99
                'stream in the data line by line
                LineOfFile = readerStream.ReadLine()
                'check if the line is not blank
                If LineOfFile IsNot Nothing Then
                    numrecords = numrecords + 1
                    'split the line
                    ArrayLine = LineOfFile.Split(","c)
                    names(i) = ArrayLine(0)
                    subject(i) = ArrayLine(1)
                    grades(i) = ArrayLine(2)

                    Alloutput += names(i) & vbTab & subject(i) & vbTab & grades(i) & vbNewLine
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
        MessageBox.Show(Alloutput, "File Details")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To numrecords
            If subject(i) = "Prog" Then
                If grades(i) > 49 Then
                    Passoutput += names(i) & vbTab & grades(i) & vbNewLine
                Else
                    Failoutput += names(i) & vbTab & grades(i) & vbNewLine
                End If
            End If
        Next
        MessageBox.Show(Passoutput & Failoutput, "File Details")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 0 To numrecords
            If subject(i) = "Web" Then
                If grades(i) > 49 Then
                    WebPassoutput += names(i) & vbTab & grades(i) & vbNewLine
                Else
                    WebFailoutput += names(i) & vbTab & grades(i) & vbNewLine
                End If
            End If
        Next
        MessageBox.Show(WebPassoutput & WebFailoutput, "File Details")
    End Sub
End Class
