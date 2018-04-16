Imports System.IO
Public Class Form1
    Private OpenFile As FileStream
    Private FileOfStream As StreamReader
    Private WriteFile As StreamWriter

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numlength As Integer = 50
    Dim numrecords As Integer
    Dim numInFile = 0

    Dim names(numlength) As String
    Dim pps(numlength) As String
    Dim address(numlength) As String

    Dim dubout As String = "Name" & vbTab & "PPSN" & vbTab & "Address" & vbNewLine
    Dim output As String = "Name" & vbTab & "PPSN" & vbTab & "Address" & vbNewLine

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
                    pps(i) = ArrayLine(1)
                    address(i) = ArrayLine(2)
                    output += names(i) & vbTab & pps(i) & vbTab & address(i) & vbNewLine
                    If address(i) = "Dublin" Then
                        dubout += names(i) & vbTab & pps(i) & vbTab & address(i) & vbNewLine
                    End If
                End If
            Next

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(dubout, "Dublin")

        Try
            OpenFile = New FileStream("dublin.txt", FileMode.Create, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & pps(i) & "," & address(i))
                ArrayLine = LineOfFile.Split(","c)
                names(i) = ArrayLine(0)
                pps(i) = ArrayLine(1)
                address(i) = ArrayLine(2)
            Next

            MessageBox.Show("New File Created dublin.txt at " & Now())

            WriteFile.Close()
            OpenFile.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(output, "File Details")
    End Sub
End Class
