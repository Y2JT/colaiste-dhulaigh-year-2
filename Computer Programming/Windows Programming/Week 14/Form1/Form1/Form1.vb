Imports System.IO
Public Class Form1
    'GLOBAL VARIABLES
    Dim names(6) As String
    Dim ages(6) As Integer
    Dim address(6) As String

    Private OpenFile As FileStream          'needed to read from the file
    Private readerStream As StreamReader    'needed to read from the file

    Dim numrecords As Integer               'holds the number of refcords in the file
    Dim LineOfFile As String                'needed to read a line of the file
    Dim ArrayLine() As String               'needed to hold a line from the file

    Dim YourDetails As String = "Name " & vbTab & "Age " & vbTab & "Address " & vbNewLine & vbNewLine
    Dim DublinDetails As String = "Name " & vbTab & "Age " & vbTab & "Address " & vbNewLine & vbNewLine

    Dim position As Integer = 0             'holds onto the current records position

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open the file connections
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            readerStream = New StreamReader(OpenFile)

            'read from the file
            For i = 0 To 99
                'stream in the data line by line
                LineOfFile = readerStream.ReadLine()
                'check if the line is not blank
                If LineOfFile IsNot Nothing Then
                    numrecords = numrecords + 1 'increment numrecords
                    'split the line
                    ArrayLine = LineOfFile.Split(","c)
                    names(i) = ArrayLine(0)
                    ages(i) = ArrayLine(1)
                    address(i) = ArrayLine(2)

                    If address(i) = "Dublin" Then
                        DublinDetails += names(i) & vbTab & ages(i) & vbTab & address(i) & vbNewLine
                    Else
                        YourDetails += names(i) & vbTab & ages(i) & vbTab & address(i) & vbNewLine
                    End If

                End If
            Next

            'close the stream
            OpenFile.Close()
            readerStream.Close()

        Catch ex As Exception
            MessageBox.Show("Could not open file", "File Error")
        End Try

        'populate textboxes with the first record in each array
        txtName.Text = names(0)
        txtAge.Text = ages(0)
        txtAddress.Text = address(0)

        'update lblposition
        lblposition.Text = position + 1 & " of " & numrecords   'position  + 1 because I need to say "1" and not "0"

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        position = numrecords - 1
        'update the label
        lblposition.Text = position + 1 & " of " & numrecords

        'update textboxes
        txtName.Text = names(position)
        txtAge.Text = ages(position)
        txtAddress.Text = address(position)

        btnLast.Enabled = False
        btnNext.Enabled = False

        btnFirst.Enabled = True
        btnPrevious.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'increment position
        position = position + 1

        'update the label
        lblposition.Text = position + 1 & " of " & numrecords

        btnFirst.Enabled = True
        btnPrevious.Enabled = True

        'update textboxes
        txtName.Text = names(position)
        txtAge.Text = ages(position)
        txtAddress.Text = address(position)

        'check if we are at the last record
        If position = numrecords - 1 Then
            btnLast.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        'update positon
        position = 0
        btnFirst.Enabled = False
        btnPrevious.Enabled = False

        'update the label
        lblposition.Text = position + 1 & " of " & numrecords

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update textboxes
        txtName.Text = names(position)
        txtAge.Text = ages(position)
        txtAddress.Text = address(position)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'update position
        position = position - 1

        'update label
        lblposition.Text = position + 1 & " of " & numrecords

        If position = 0 Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
        End If

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update textboxes
        txtName.Text = names(position)
        txtAge.Text = ages(position)
        txtAddress.Text = address(position)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(YourDetails, "Outside Dublin")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(DublinDetails, "Dublin")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub lblposition_Click(sender As Object, e As EventArgs) Handles lblposition.Click

    End Sub
End Class
