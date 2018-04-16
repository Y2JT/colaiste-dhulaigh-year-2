Public Class Form2
    Dim counter As Integer = 0

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

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

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
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
        If NameTextBox.Text = "" Then
            Beep()
            MessageBox.Show("Please Enter Name", "Alert")
            NameTextBox.Focus()
            Exit Sub
        End If
        'validate BalanceTextBox
        If BalanceTextBox.Text = "" Or Not IsNumeric(BalanceTextBox.Text) Then
            Beep()
            MessageBox.Show("Please Enter a Valid Balance", "Alert")
            BalanceTextBox.Focus()
            Exit Sub
            If OverdraftCheckBox.Checked = False And Val(BalanceTextBox.Text) < 0 Then
                Beep()
                MessageBox.Show("Cannot have negative balance")
                Exit Sub
            End If
        End If

        'update the record
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.BankDataSet.AcceptChanges()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

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

        'disable
        Balance_Ascending_ToolStripButton.Enabled = False
        Balance_Descending_ToolStripButton.Enabled = False
        NameToolStripLabel.Enabled = False
        NameToolStripTextBox.Enabled = False
        Name_searchToolStripButton.Enabled = False
        ResetToolStripButton.Enabled = False

        'show Done and Cancel buttons
        btnDone.Visible = True
        btnCancel.Visible = True
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

    End Sub
End Class