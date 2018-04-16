Public Class Form2
    Dim counter As Integer = 0

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.BankDataSet.customers)

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
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
        CustomersBindingNavigator.Enabled = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Timer1.Enabled = True
        CustomersBindingNavigator.Enabled = False
    End Sub

    'the BindingNavigatorPositionItem takes a second to update with the proper value
    'so this timer will create a delay before the IdTextBox is updated
    'with the value from the BindingNavigatorPositionItem
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

    Private Sub AscendToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CustomersTableAdapter.ascend(Me.BankDataSet.customers)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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

    Private Sub CustomersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomersBindingNavigator.RefreshItems

    End Sub
End Class
