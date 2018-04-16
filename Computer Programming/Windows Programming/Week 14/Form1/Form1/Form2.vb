Imports System.IO
Public Class Form2

    Private OpenFile As FileStream          'needed to open the file
    Private FileOfStream As StreamReader    'used to read from the file
    Private WriteFile As StreamWriter       'used to write to the file

    Dim ArrayLine() As String               'used to store a line from the file
    Dim LineOfFile As String                'used to check that the line is not blank
    Dim ArrayLength As Integer = 50         'used to set the length of the array
    Dim numInFile = 0                       'used to store the number in the file

    Dim names(ArrayLength) As String        'array names
    Dim ages(ArrayLength) As Integer        'array ages
    Dim address(ArrayLength) As Integer     'array address

    Dim Details As String

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'open the file and read the contents into the arrays
        Try
            'make a connection to the file
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Read)
            'give FileOfStream access to read from the file
            FileOfStream = New StreamReader(OpenFile)

            For i = 0 To ArrayLength
                'read the file line by line
                LineOfFile = FileOfStream.ReadLine()
                'check the line has data in it
                If LineOfFile IsNot Nothing Then
                    numInFile += 1     'increment the record
                    'split the line where there is a comma
                    ArrayLine = LineOfFile.Split(","c)
                    'populate the arrays
                    names(i) = ArrayLine(0)
                    ages(i) = ArrayLine(0)
                End If
            Next

            txtName.Text = names(0)
            txtAge.Text = ages(0)
            numInFile = 0

        Catch ex As Exception
            MessageBox.Show(Details)
        End Try

        'MessageBox.Show(numrecords)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'open the stream to write to a file 
            OpenFile = New FileStream("details.txt", FileMode.Open, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'names(numInFile) = txtName.Text
            'ages(numInFile) = txtAge.Text
            'address(numInFile) = txtAddress.Text
            'WriteFile.WriteLine(names(numInFile) & "," & ages(numInFile) & "," & address(numInFile))

            'numInFile += 1

            'write each record to the file
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & ages(i) & "," & address(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try

        Details = "Name" & vbTab & "Age" & vbTab & "Address" & vbNewLine
        For i = 0 To numInFile - 1
            Details += names(i) & vbTab & ages(i) & vbTab & address(i) & vbNewLine
        Next
        MessageBox.Show(Details)
    End Sub
End Class