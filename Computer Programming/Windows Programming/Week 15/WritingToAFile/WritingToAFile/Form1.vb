Imports System.IO
Public Class Form1

    Private OpenFile As FileStream          'needed to open the file
    Private FileOfStream As StreamReader    'used to read from the file
    Private WriteFile As StreamWriter       'used to write to the file

    Dim ArrayLine() As String               'used to store a line from the file
    Dim LineOfFile As String                'used to read a line from the file
    Dim numlength As Integer = 50

    Dim names(numlength) As String
    Dim ages(numlength) As Integer
    Dim numrecords As Integer = 0

    Dim currentuser As Integer = 0
    Dim position As Integer

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'open the file and read the contents into the arrays
        Try
            'make a connection to the file
            OpenFile = New FileStream("nameage.txt", FileMode.Open, FileAccess.Read)
            'give FileOfStream access to read from the file
            FileOfStream = New StreamReader(OpenFile)

            For i = 0 To numlength
                'read the file line by line
                LineOfFile = FileOfStream.ReadLine()
                'check the line has data in it
                If LineOfFile IsNot Nothing Then
                    numrecords += 1     'increment the record
                    'split the line where there is a comma
                    ArrayLine = LineOfFile.Split(","c)
                    'populate the arrays
                    names(i) = ArrayLine(0)
                    ages(i) = ArrayLine(1)
                End If
            Next

            txtName.Text = names(0)
            txtAge.Text = ages(0)
            position = 0

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannot access file")
        End Try

        'MessageBox.Show(numrecords)

        btnSave.Visible = False
        btnCancel.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        btnSave.Visible = True
        btnCancel.Visible = True

        'make textboxes .enable true
        txtName.Enabled = True
        txtAge.Enabled = True
        'clear the textboxes
        txtName.Text = ""
        txtAge.Text = ""

        'put the cursor in the name textbox
        txtName.Focus()

        'add one to the length of the array
        numlength += 1
        position += 1
        'txtname.text = names(numlength)
        'txtage.text = ages(numlength)

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'take 1 from the length of the array
        numlength -= 1

        btnCancel.Visible = False
        btnSave.Visible = False
        txtName.Enabled = False
        txtAge.Enabled = False

        'put the last record in the textboxes
        txtAge.Text = ages(position)    'ages(numlength - 1)
        txtName.Text = names(position)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'open the stream to write to a file
            OpenFile = New FileStream("nameage.txt", FileMode.Open, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'write each record to the file
            For i = 0 To numrecords - 1
                WriteFile.WriteLine(names(i) & "," & ages(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            OpenFile.Close()
            MessageBox.Show("File Update on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try


        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Enter Name")
            txtName.Focus()
            Exit Sub
        End If

        If txtAge.Text = "" Or Not IsNumeric(txtAge.Text) Then
            Beep()
            MessageBox.Show("Error, enter a valid age")
            txtAge.Focus()
            Exit Sub
        End If

        'set position to the last element in the array
        position = numrecords

        'display the last record
        names(numrecords) = txtName.Text
        ages(numrecords) = txtAge.Text
        numrecords += 1

        'put the form back to normal mode
        btnSave.Visible = False
        btnCancel.Visible = False

        'make textboxes .enabled = false
        txtAge.Enabled = False
        txtName.Enabled = False

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
