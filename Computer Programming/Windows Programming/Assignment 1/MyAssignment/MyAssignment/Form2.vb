Public Class Form2
    Dim counter As Integer = 0

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.BankDataSet.AcceptChanges()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending")
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.BankDataSet.customers)
        IDTextBox.Enabled = False
        NameTextBox.Enabled = False
        BalanceTextBox.Enabled = False
        CheckBoxOD.Enabled = False

    End Sub

    Private Sub CustomersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomersBindingNavigator.RefreshItems

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        'validate NameTextBox
        If NameTextBox.Text = "" Then
            MessageBox.Show("Please enter a name")
            NameTextBox.Focus()
            Exit Sub
        End If
        'validate BalanceTextBox
        If BalanceTextBox.Text = "" Or Not IsNumeric(BalanceTextBox.Text) Then
            MessageBox.Show("Please enter a valid balance")
            BalanceTextBox.Focus()
            Exit Sub
        End If

        'update the record
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.BankDataSet.AcceptChanges()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

        'make the database menustrip enabled
        CustomersBindingNavigator.Enabled = False

        'disable edit details button
        btnDetails.Enabled = False

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Timer1.Enabled = True
        CustomersBindingNavigator.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'increment the counter
        counter += 1
        'when count is 2 update the value in the IdTextBox
        If counter = 2 Then
            IDTextBox.Text = BindingNavigatorPositionItem.Text
            'stop the timer
            Timer1.Enabled = False
            'reset the counter
            counter = 0
        End If
    End Sub

    Private Sub Balance_AscendingToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_AscendingToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Balance_Ascending(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Balance_DescendingToolStripButton_Click(sender As Object, e As EventArgs) Handles Balance_DescendingToolStripButton.Click
        Try
            Me.CustomersTableAdapter.Balance_Descending(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        'show Done and Cancel buttons
        btnDone.Visible = True
        btnCancel.Visible = True
        'hide Edit Details button
        btnDetails.Visible = False

        'enabled text and balance text box, and overdraft check box
        NameTextBox.Enabled = True
        BalanceTextBox.Enabled = True
        CheckBoxOD.Enabled = True
    End Sub
End Class