Imports System.IO
Public Class Form1
    Private OpenFile As FileStream
    Private FileOfStream As StreamReader

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numrecords As Integer

    Dim names(5) As String
    Dim address(5) As String
    Dim ages(5) As Integer

    Dim output As String = "Name" & vbTab & "Address" & vbTab & "Age" & vbNewLine
    Dim u20output As String = "Name" & vbTab & "Address" & vbTab & "Age" & vbNewLine

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
                    address(i) = ArrayLine(1)
                    ages(i) = ArrayLine(2)
                    output += names(i) & vbTab & address(i) & vbTab & ages(i) & vbNewLine
                    If ages(i) < 20 Then
                        u20output += names(i) & vbTab & address(i) & vbTab & ages(i) & vbNewLine
                    End If
                End If
            Next

            OpenFile.Close()
            FileOfStream.Close()


        Catch ex As Exception
            MessageBox.Show("Cannot access file", "Error")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Created by Joseph Tierney", "Alert")
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        MessageBox.Show(output, "Details")
    End Sub

    Private Sub btnUnder_Click(sender As Object, e As EventArgs) Handles btnUnder.Click
        MessageBox.Show(u20output, "Details")
    End Sub
End Class
