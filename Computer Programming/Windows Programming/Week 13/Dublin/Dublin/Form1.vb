Imports System.IO
Public Class Form1
    'GLOBAL VARIABLES

    Dim names(8) As String
    Dim address(8) As String
    Dim id(8) As Integer

    Private OpenFile As FileStream          'needed to read from the file
    Private readerStream As StreamReader    'needed to read from the file

    Dim numrecords As Integer               'holds the number of records in the file
    Dim LineOfFile As String                'needed to read a line of the file
    Dim ArrayLine() As String               'needed to hold a line from the file

    Dim output As String = "Name " & vbTab & "Address " & vbTab & "ID " & vbNewLine & vbNewLine
    Dim duboutput As String = "Name " & vbTab & "Address " & vbTab & "ID " & vbNewLine & vbNewLine
    Dim oduboutput As String = "Name " & vbTab & "Address " & vbTab & "ID " & vbNewLine & vbNewLine

    Dim position As Integer = 0     'holds onto the current records position


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'open the file connections
            OpenFile = New FileStream("namesaddress.txt", FileMode.Open, FileAccess.Read)
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
                    address(i) = ArrayLine(1)
                    id(i) = ArrayLine(2)
                    If address(i) = "Dublin" Then
                        duboutput += names(i) & vbTab & address(i) & vbTab & id(i) & vbNewLine
                    Else
                        oduboutput += names(i) & vbTab & address(i) & vbTab & id(i) & vbNewLine
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
        txtname.Text = names(0)
        txtaddress.Text = address(0)
        txtid.Text = id(0)

        'update lblposition
        lblPosition.Text = position + 1 & " of " & numrecords   'position  + 1 because I need to say "1" and not "0"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("People inside Dublin " & vbNewLine & vbNewLine & duboutput, "People in Dublin")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("People outside Dublin " & vbNewLine & vbNewLine & oduboutput, "People outside Dublin")
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        position = numrecords - 1
        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        'update the textboxes
        txtname.Text = names(position)
        txtaddress.Text = address(position)
        txtid.Text = id(position)

        btnLast.Enabled = False
        btnNext.Enabled = False

        btnFirst.Enabled = True
        btnPrevious.Enabled = True
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'increment position
        position = position + 1
        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        btnFirst.Enabled = True
        btnPrevious.Enabled = True

        'update the textboxes
        txtname.Text = names(position)
        txtaddress.Text = address(position)
        txtid.Text = id(position)

        'check if we are at the last record
        If position = numrecords - 1 Then
            btnLast.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        'update position
        position = 0

        btnFirst.Enabled = False
        btnPrevious.Enabled = False

        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update the textboxes
        txtname.Text = names(position)
        txtaddress.Text = address(position)
        txtid.Text = id(position)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'update position
        position = position - 1

        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        If position = 0 Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
        End If

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update the textboxes
        txtname.Text = names(position)
        txtaddress.Text = address(position)
        txtid.Text = id(position)
    End Sub
End Class
