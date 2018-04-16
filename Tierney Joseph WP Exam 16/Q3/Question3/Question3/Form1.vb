Imports System.IO
Public Class Form1
    Private OpenFile As FileStream
    Private FileOfStream As StreamReader

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numrecords As Integer

    Dim names(6) As String
    Dim course(6) As String
    Dim grades(6) As Integer

    Dim passoutput As String = "Passes: " & vbNewLine & vbNewLine & "Name" & vbTab & "Course" & vbTab & "Grade" & vbNewLine
    Dim failoutput As String = "Fails: " & vbNewLine & vbNewLine & "Name" & vbTab & "Course" & vbTab & "Grade" & vbNewLine

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            FileOfStream = New StreamReader(OpenFile)

            For i = 0 To 99
                LineOfFile = FileOfStream.ReadLine()
                If LineOfFile IsNot Nothing Then
                    numrecords += 1
                    ArrayLine = LineOfFile.Split(","c)
                    names(i) = ArrayLine(0)
                    course(i) = ArrayLine(1)
                    grades(i) = ArrayLine(2)
                    If grades(i) > 49 Then
                        passoutput += names(i) & vbTab & course(i) & vbTab & grades(i) & vbNewLine
                    Else
                        failoutput += names(i) & vbTab & course(i) & vbTab & grades(i) & vbNewLine
                    End If
                End If
            Next

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file", "Error")
        End Try
    End Sub

    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        MessageBox.Show(passoutput, "File Details")
    End Sub

    Private Sub btnFail_Click(sender As Object, e As EventArgs) Handles btnFail.Click
        MessageBox.Show(failoutput, "File Details")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by Joseph Tierney", "About")
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub
End Class
