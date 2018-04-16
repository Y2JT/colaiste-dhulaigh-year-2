Public Class Form2
    Dim counter As Integer = 0
    Dim temp1 As String
    Dim temp2 As Integer

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)
        MessageBox.Show("Save Successful", "Alert")

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Beep()
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.BankDataSet.customers)
        IdTextBox.Enabled = False
        NameTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        OverdraftCheckBox.Enabled = False

    End Sub

    Private Sub Balance_Ascending_ToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_Ascending_ToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Balance_Ascending_(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Balance_Descending_ToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_Descending_ToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Balance_Descending_(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Name_searchToolStripButton_Click(sender As Object, e As EventArgs) Handles Name_searchToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Name_search(Me.BankDataSet.customers, NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ResetToolStripButton_Click(sender As Object, e As EventArgs) Handles ResetToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Reset(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'reset the search field
        NameToolStripTextBox.Text = ""

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        temp1 = NameTextBox.Text
        temp2 = Val(BalanceTextBox.Text)

        'show Done and Cancel buttons
        btnDone.Visible = True
        btnCancel.Visible = True
        'hide Edit Details button
        btnDetails.Visible = False

        'enable name, balance and overdraft
        NameTextBox.Enabled = True
        BalanceTextBox.Enabled = True
        OverdraftCheckBox.Enabled = True

        'clear search box
        NameToolStripTextBox.Text = ""

        Balance_Ascending_ToolStripButton.Enabled = False
        Balance_Descending_ToolStripButton.Enabled = False
        NameToolStripLabel.Enabled = False
        NameToolStripTextBox.Enabled = False
        Name_searchToolStripButton.Enabled = False
        ResetToolStripButton.Enabled = False
        CustomersBindingNavigator.Enabled = False

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'validate NameTextBox
        If NameTextBox.Text = "" Or IsNumeric(NameTextBox.Text) Then
            Beep()
            MessageBox.Show("Please Enter a Valid Name", "Error")
            NameTextBox.Focus()
            Exit Sub
        End If
        'validate BalanceTextBox
        If BalanceTextBox.Text = "" Or Not IsNumeric(BalanceTextBox.Text) Then
            Beep()
            MessageBox.Show("Please Enter a Valid Balance", "Error")
            BalanceTextBox.Focus()
            Exit Sub
        End If

        'validate OverdraftCheckBox
        If OverdraftCheckBox.CheckState = CheckState.Indeterminate Then
            Beep()
            MessageBox.Show("Please select an Overdraft option", "Error")
            Exit Sub
        End If
        'check for non digits and minus
        If OverdraftCheckBox.CheckState = CheckState.Unchecked And Val(BalanceTextBox.Text) < 0 Then
            Beep()
            MessageBox.Show("Cannont have a NEGATIVE value with NO Overdraft selected", "Error")
            Exit Sub
        End If

        'update the record
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.BankDataSet.AcceptChanges()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

        MessageBox.Show("Entry Added", "Alert")

        'make the database menustrip disabled
        CustomersBindingNavigator.Enabled = True

        'show edit details button
        btnDetails.Visible = True

        'hide done and cancel button
        btnDone.Visible = False
        btnCancel.Visible = False

        'enable name, balance and overdraft
        NameTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        OverdraftCheckBox.Enabled = False

        'clear search box
        NameToolStripTextBox.Text = ""

        'Enable queries
        Balance_Ascending_ToolStripButton.Enabled = True
        Balance_Descending_ToolStripButton.Enabled = True
        NameToolStripLabel.Enabled = True
        NameToolStripTextBox.Enabled = True
        Name_searchToolStripButton.Enabled = True
        ResetToolStripButton.Enabled = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'enable timer
        Timer1.Enabled = True

        'disable binding navigator
        CustomersBindingNavigator.Enabled = False

        'enable name, balance and overdraft
        NameTextBox.Enabled = True
        BalanceTextBox.Enabled = True
        OverdraftCheckBox.Enabled = True

        'disable queries
        Balance_Ascending_ToolStripButton.Enabled = False
        Balance_Descending_ToolStripButton.Enabled = False
        NameToolStripLabel.Enabled = False
        NameToolStripTextBox.Enabled = False
        Name_searchToolStripButton.Enabled = False
        ResetToolStripButton.Enabled = False

        'show Done and Cancel buttons
        btnDone.Visible = True
        btnCancel.Visible = True
        'hide Edite Details button
        btnDetails.Visible = False

        'clear search box
        NameToolStripTextBox.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'increment the counter
        counter += 1
        'when count is 2 update the value in the IdTextBox
        If counter = 2 Then
            IdTextBox.Text = BindingNavigatorPositionItem.Text
            'stop the timer
            Timer1.Enabled = False
            'reset the counter
            counter = 0
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        NameTextBox.Text = temp1
        BalanceTextBox.Text = temp2

        MessageBox.Show("Action Canceled", "Alert")

        'hide done and cancel buttons
        btnDone.Visible = False
        btnCancel.Visible = False
        'show edit details
        btnDetails.Visible = True

        'disable the name, balance and overdraft
        NameTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        OverdraftCheckBox.Enabled = False

        'enable queries
        Balance_Ascending_ToolStripButton.Enabled = True
        Balance_Descending_ToolStripButton.Enabled = True
        NameToolStripLabel.Enabled = True
        NameToolStripTextBox.Enabled = True
        Name_searchToolStripButton.Enabled = True
        ResetToolStripButton.Enabled = True
        CustomersBindingNavigator.Enabled = True

        'reset the search field
        NameToolStripTextBox.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Program Ending", "Alert")
        End     'closes the program
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("© Joey Tierney 2015", "Created by")
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        MessageBox.Show("Entry Deleted", "Alert")
    End Sub
End Class