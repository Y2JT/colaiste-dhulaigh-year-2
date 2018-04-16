Imports System.IO
Public Class Form2
    'GLOBAL VARIABLES
    Private OpenFile As FileStream          'needed to open the file
    Private FileOfStream As StreamReader    'used to read from the file
    Private WriteFile As StreamWriter       'used to write to the file

    Dim ArrayLine() As String               'used to store a line from the file
    Dim LineOfFile As String                'used to read a line from the file
    Dim numlength As Integer = 50           'used to set the length of the array
    Dim numInFile = 0                       'used to store the number in the file

    Dim id(numlength) As Integer            'array id
    Dim names(numlength) As String          'array names
    Dim address(numlength) As String        'array address
    Dim phone(numlength) As Integer         'array phone
    Dim course(numlength) As String         'array course
    Dim grade(numlength) As Integer         'array grade
    Dim numrecords As Integer = 0

    'Dim currentuser As Integer = 0
    Dim position As Integer                 'holds onto the current records position

    Dim temp1 As String                     'temporary value for editing details (name)
    Dim temp2 As String                     'temporary value for editing details (address)
    Dim temp3 As Integer                    'temporary value for editing details (phone)
    Dim temp4 As String                     'temporary value for editing details (course)
    Dim temp5 As Integer                    'temporary value for editing details (grade)

    Dim array As Integer = 0                'used to hold onto the value of i for search
    Dim flag As Boolean = False             'used to search the array

    Dim Passoutput As String = "ID" & vbTab & "Name " & vbTab & "Address" & vbTab & "Phone" & vbTab & "Course" & vbTab & vbTab & "Grade " & vbNewLine & vbNewLine
    Dim Failoutput As String = "ID" & vbTab & "Name " & vbTab & "Address" & vbTab & "Phone" & vbTab & "Course" & vbTab & vbTab & "Grade " & vbNewLine & vbNewLine

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            OpenFile = New FileStream("studentdetails.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'write each record to the file
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(id(i) & "," & names(i) & "," & address(i) & "," & phone(i) & "," & course(i) & "," & grade(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())
        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'open the file and read the contents into the arrays
        Try
            'make a connection to the file
            OpenFile = New FileStream("studentdetails.txt", FileMode.Open, FileAccess.Read)
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
                    id(i) = ArrayLine(0)
                    names(i) = ArrayLine(1)
                    address(i) = ArrayLine(2)
                    phone(i) = ArrayLine(3)
                    course(i) = ArrayLine(4)
                    grade(i) = ArrayLine(5)
                    If grade(i) >= 50 Then
                        Passoutput += id(i) & vbTab & names(i) & vbTab & address(i) & vbTab & phone(i) & vbTab & course(i) & vbTab & grade(i) & vbNewLine
                    Else
                        Failoutput += id(i) & vbTab & names(i) & vbTab & address(i) & vbTab & phone(i) & vbTab & course(i) & vbTab & grade(i) & vbNewLine
                    End If
                    'If grade(i) >= 50 Then
                    'txtName.BackColor = DefaultBackColor
                    'Else
                    'txtName.BackColor = Color.Cyan
                    'End If
                End If
            Next

            'populate form with first array
            txtID.Text = id(0)
            txtName.Text = names(0)
            txtAddress.Text = address(0)
            txtPhone.Text = phone(0)
            txtCourse.Text = course(0)
            txtGrade.Text = grade(0)
            position = 0

            OpenFile.Close()
            FileOfStream.Close()

        Catch ex As Exception
            MessageBox.Show("Cannot access file")
        End Try

        'update lblposition
        lblPosition.Text = position + 1 & " of " & numrecords   'position  + 1 because I need to say "1" and not "0"

        btnSave.Visible = False
        btnCancel.Visible = False

        btnFirst.Enabled = False
        btnPrevious.Enabled = False
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        'update positon
        position = 0
        btnFirst.Enabled = False
        btnPrevious.Enabled = False

        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update textboxes
        txtID.Text = id(position)
        txtName.Text = names(position)
        txtAddress.Text = address(position)
        txtPhone.Text = phone(position)
        txtCourse.Text = course(position)
        txtGrade.Text = grade(position)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'update position
        position = position - 1

        'update label
        lblPosition.Text = position + 1 & " of " & numrecords

        'if on the first record, disable the first and previous buttons
        If position = 0 Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
        End If

        btnLast.Enabled = True
        btnNext.Enabled = True

        'update textboxes
        txtID.Text = id(position)
        txtName.Text = names(position)
        txtAddress.Text = address(position)
        txtPhone.Text = phone(position)
        txtCourse.Text = course(position)
        txtGrade.Text = grade(position)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'increment position
        position = position + 1

        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        btnFirst.Enabled = True
        btnPrevious.Enabled = True

        'update textboxes
        txtID.Text = id(position)
        txtName.Text = names(position)
        txtAddress.Text = address(position)
        txtPhone.Text = phone(position)
        txtCourse.Text = course(position)
        txtGrade.Text = grade(position)

        'check if we are at the last record
        If position = numrecords - 1 Then
            btnLast.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        position = numrecords - 1
        'update the label
        lblPosition.Text = position + 1 & " of " & numrecords

        'update textboxes
        txtID.Text = id(position)
        txtName.Text = names(position)
        txtAddress.Text = address(position)
        txtPhone.Text = phone(position)
        txtCourse.Text = course(position)
        txtGrade.Text = grade(position)

        'disable last and next buttons
        btnLast.Enabled = False
        btnNext.Enabled = False

        'enable first and previous buttons
        btnFirst.Enabled = True
        btnPrevious.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'validate Name
        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Name", "Alert")
            txtName.Focus()
            Exit Sub
        End If
        'validate Address
        If txtAddress.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Address", "Alert")
            txtAddress.Focus()
            Exit Sub
        End If
        'validate Phone
        If txtPhone.Text = "" Or Not IsNumeric(txtPhone.Text) Then
            Beep()
            MessageBox.Show("Please Enter Phone No.", "Alert")
            txtPhone.Focus()
            Exit Sub
        End If
        'validate Course
        If txtCourse.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Course", "Alert")
            txtCourse.Focus()
            Exit Sub
        End If
        'validate Grade
        If txtGrade.Text = "" Or Not IsNumeric(txtGrade.Text) Then
            Beep()
            MessageBox.Show("Please Enter Grade", "Alert")
            txtGrade.Focus()
            Exit Sub
        End If

        Try
            OpenFile = New FileStream("studentdetails.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'write each record to the file
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(id(i) & "," & names(i) & "," & address(i) & "," & phone(i) & "," & course(i) & "," & grade(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            'OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try

        'disable textboxes
        txtName.Enabled = False
        txtAddress.Enabled = False
        txtPhone.Enabled = False
        txtCourse.Enabled = False
        txtGrade.Enabled = False

        'show nav buttons
        btnNext.Visible = True
        btnLast.Visible = True
        btnFirst.Visible = True
        btnPrevious.Visible = True

        'hide save and cancel
        btnSave.Visible = False
        btnCancel.Visible = False
        btnSave.Enabled = False
        btnCancel.Enabled = False

        'enable menustrip
        MenuStrip1.Enabled = True

    End Sub

    Private Sub EditStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentToolStripMenuItem.Click
        'assign temp values
        temp1 = txtName.Text
        temp2 = txtAddress.Text
        temp3 = Val(txtPhone.Text)
        temp4 = txtCourse.Text
        temp5 = Val(txtGrade.Text)

        'disable menustrip
        MenuStrip1.Enabled = False

        'show Done and Cancel buttons
        btnSave.Visible = True
        btnCancel.Visible = True

        'hide nav buttons button
        btnFirst.Visible = False
        btnLast.Visible = False
        btnNext.Visible = False
        btnPrevious.Visible = False

        'enable name, address, phone, course, grade
        txtName.Enabled = True
        txtAddress.Enabled = True
        txtPhone.Enabled = True
        txtCourse.Enabled = True
        txtGrade.Enabled = True

        'enable save and cancel
        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtName.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'take 1 from the length of the array
        numlength -= 1

        txtName.Text = temp1
        txtAddress.Text = temp2
        txtPhone.Text = temp3
        txtCourse.Text = temp4
        txtGrade.Text = temp5

        MessageBox.Show("Action Cancelled", "Alert")

        'hide done and cancel buttons
        btnSave.Visible = False
        btnCancel.Visible = False

        'show nav buttons
        btnFirst.Visible = True
        btnLast.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True

        'disable name, address, phone, course, grade
        txtName.Enabled = False
        txtAddress.Enabled = False
        txtPhone.Enabled = False
        txtCourse.Enabled = False
        txtGrade.Enabled = False

        'disable save and cancel
        btnSave.Enabled = False
        btnCancel.Enabled = False

        'enable menu tool strip
        MenuStrip1.Enabled = True
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        position = numrecords - 1
        'add one to the length of the array
        numlength += 1
        position += 1

        'update lblposition
        lblPosition.Text = position + 1 & " of " & numrecords + 1

        'update ID textbox
        txtID.Text = position + 1

        'hide nav buttons
        btnFirst.Visible = False
        btnLast.Visible = False
        btnNext.Visible = False
        btnPrevious.Visible = False

        'show cancel button
        btnCancel.Visible = True
        btnCancel.Enabled = True

        'make textboxes .enable true
        txtName.Enabled = True
        txtAddress.Enabled = True
        txtPhone.Enabled = True
        txtCourse.Enabled = True
        txtGrade.Enabled = True

        'clear the textboxes
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtCourse.Text = ""
        txtGrade.Text = ""

        'put the cursor in the name textbox
        txtName.Focus()

        MessageBox.Show("Please Save Through File Menu", "Alert")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            OpenFile = New FileStream("studentdetails.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            'write each record to the file
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(id(i) & "," & names(i) & "," & address(i) & "," & phone(i) & "," & course(i) & "," & grade(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'validate Name
        If txtName.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Name", "Alert")
            txtName.Focus()
            Exit Sub
        End If
        'validate Address
        If txtAddress.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Address", "Alert")
            txtAddress.Focus()
            Exit Sub
        End If
        'validate Phone
        If txtPhone.Text = "" Or Not IsNumeric(txtPhone.Text) Then
            Beep()
            MessageBox.Show("Please Enter Phone No.", "Alert")
            txtPhone.Focus()
            Exit Sub
        End If
        'validate Course
        If txtCourse.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Course", "Alert")
            txtCourse.Focus()
            Exit Sub
        End If
        'validate Grade
        If txtGrade.Text = "" Or Not IsNumeric(txtGrade.Text) Then
            Beep()
            MessageBox.Show("Please Enter Grade", "Alert")
            txtGrade.Focus()
            Exit Sub
        End If

        Try
            OpenFile = New FileStream("studentdetails.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter(OpenFile)

            id(numInFile) = txtID.Text
            names(numInFile) = txtName.Text
            address(numInFile) = txtAddress.Text
            phone(numInFile) = txtPhone.Text
            course(numInFile) = txtCourse.Text
            grade(numInFile) = txtGrade.Text
            'numInFile += 1
            WriteFile.WriteLine(id(numInFile) & "," & names(numInFile) & "," & address(numInFile) & "," & phone(numInFile) & "," & course(numInFile) & "," & grade(numInFile))
            numrecords = numrecords + 1

            'write each record to the file
            For i = 0 To numInFile - 1
                WriteFile.WriteLine(names(i) & "," & address(i) & "," & phone(i) & "," & course(i) & "," & grade(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try

        'hide done and cancel buttons
        btnSave.Visible = False
        btnCancel.Visible = False
        'show edit details
        btnFirst.Visible = True
        btnLast.Visible = True
        btnNext.Visible = True
        btnPrevious.Visible = True

        'disable name, address, phone, course, grade
        txtName.Enabled = False
        txtAddress.Enabled = False
        txtPhone.Enabled = False
        txtCourse.Enabled = False
        txtGrade.Enabled = False

        'disable save and cancel
        btnSave.Enabled = False
        btnCancel.Enabled = False

        btnFirst.Enabled = True
        btnPrevious.Enabled = true

    End Sub

    Private Sub DeleteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        'if on the last record
        If position = numrecords - 1 Then
            numrecords -= 1
        Else
            For i = position To numrecords - 1
                id(i) = id(i + 1)
                names(i) = names(i + 1)
                address(i) = address(i + 1)
                phone(i) = phone(i + 1)
                course(i) = course(i + 1)
                grade(i) = grade(i + 1)
            Next
            numrecords -= 1
        End If

        MessageBox.Show("Student Deleted", "Alert")

        Try
            'OpenFile = New FileStream("studentdetails.txt", FileMode.Append, FileAccess.Write)
            WriteFile = New StreamWriter("studentdetails.txt")

            'write each record to the file
            For i = 0 To numrecords - 1
                WriteFile.WriteLine(id(i) & "," & names(i) & "," & address(i) & "," & phone(i) & "," & course(i) & "," & grade(i))
            Next

            'close the stream to the file
            WriteFile.Close()
            'OpenFile.Close()
            MessageBox.Show("File Updated on " & Now())

        Catch ex As Exception
            MessageBox.Show("Could not access file")
        End Try

    End Sub

    Private Sub ShowPassesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPassesToolStripMenuItem.Click
        MessageBox.Show(Passoutput, "File Details")
        Exit Sub
    End Sub

    Private Sub ShowFailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowFailsToolStripMenuItem.Click
        MessageBox.Show(Failoutput, "File Details")
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        'Enable the search feautres
        btnSearch.Enabled = True
        txtSearch.Enabled = True
        'put cursor on search text box
        txtSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'if search text box is empty
        If txtSearch.Text = "" Then
            Beep()
            MessageBox.Show("Please enter a student name", "Error")
            'put cursor on Search text box
            txtSearch.Focus()
            Exit Sub
        End If

        While flag = False
            'for loop
            For i = 0 To numrecords
                If UCase(names(i)) = UCase(txtSearch.Text) Then
                    'change flag to true
                    flag = True
                    'update text boxes with record
                    txtID.Text = id(array)
                    txtName.Text = names(array)
                    txtAddress.Text = address(array)
                    txtPhone.Text = phone(array)
                    txtCourse.Text = course(array)
                    txtGrade.Text = grade(array)

                    'give array value of i
                    array = i

                    'clear search text box
                    txtSearch.Text = ""

                    'update the label
                    lblPosition.Text = position + 1 & " of " & numrecords
                End If
            Next
            If flag = False Then
                Beep()
                MessageBox.Show("Student Not Found", "Alert")
                Exit Sub
            End If
        End While

        'reset flag to false
        flag = False

        'disable search button and text box
        btnSearch.Enabled = False
        txtSearch.Enabled = False
    End Sub
End Class