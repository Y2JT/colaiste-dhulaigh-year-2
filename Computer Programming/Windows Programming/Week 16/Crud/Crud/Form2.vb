Imports System.IO
Public Class Form2

    Private OpenFile As FileStream
    Private FileOfStream As StreamReader
    Private WriteFile As StreamWriter

    Dim ArrayLine() As String
    Dim LineOfFile As String
    Dim numlength As Integer = 50

    Dim names(numlength) As String
    Dim county(numlength) As String
    Dim ages(numlength) As Integer
    Dim numrecords As Integer = 0

    Dim currentuser As Integer = 0
    Dim position As Integer

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End     'ends program
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'open the file and read the contents into the arrays
        Try
            'make a connection to the file
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            'give FileOfStream access to read file
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
                    county(i) = ArrayLine(1)
                    ages(i) = ArrayLine(2)
                End If
            Next

            txtName.Text = names(0)
            txtCounty.Text = county(1)
            txtAge.Text = ages(2)
            position = 0

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannont access file")

        End Try

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
        txtCounty.Enabled = True
        'clear the textboxes
        txtName.Text = ""
        txtCounty.Text = ""
        txtAge.Text = ""

        'put the cursor in the name textbox
        txtName.Focus()

        'add one to the length of the array
        numlength += 1
        position += 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'take 1 from the length of the array
        numlength -= 1

        btnCancel.Visible = False
        btnSave.Visible = False
        txtName.Enabled = False
        txtCounty.Enabled = False
        txtAge.Enabled = False

        'put the last record in the textboxes
        txtAge.Text = ages(position)    'ages(numlength - 1)
        txtName.Text = names(position)
        txtCounty.Text = county(position)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'open the stream to write to a file
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'write each record to the file
            For i = 0 To numrecords - 1
                WriteFile.WriteLine(names(i) & "," & county(i) & "," & ages(i))
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

        If txtCounty.Text = "" Then
            Beep()
            MessageBox.Show("Enter County")
            txtCounty.Focus()
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
        county(numrecords) = txtCounty.Text
        ages(numrecords) = txtAge.Text
        numrecords += 1

        'put the form back to normal mode
        btnSave.Visible = False
        btnCancel.Visible = False

        'make textboxes .enabled = false
        txtAge.Enabled = False
        txtName.Enabled = False
        txtCounty.Enabled = False
    End Sub
End Class