<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim OverdraftLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New DataBaseAssignment.bankDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.OverdraftCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomersTableAdapter = New DataBaseAssignment.bankDataSetTableAdapters.customersTableAdapter()
        Me.TableAdapterManager = New DataBaseAssignment.bankDataSetTableAdapters.TableAdapterManager()
        Me.Balance_Ascending_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Balance_Ascending_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Balance_Descending_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Balance_Descending_ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Name_searchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Name_searchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ResetToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ResetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        OverdraftLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Balance_Ascending_ToolStrip.SuspendLayout()
        Me.Balance_Descending_ToolStrip.SuspendLayout()
        Me.Name_searchToolStrip.SuspendLayout()
        Me.ResetToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 175)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 213)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(12, 253)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 6
        BalanceLabel.Text = "Balance:"
        '
        'OverdraftLabel
        '
        OverdraftLabel.AutoSize = True
        OverdraftLabel.Location = New System.Drawing.Point(12, 297)
        OverdraftLabel.Name = "OverdraftLabel"
        OverdraftLabel.Size = New System.Drawing.Size(54, 13)
        OverdraftLabel.TabIndex = 8
        OverdraftLabel.Text = "Overdraft:"
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(706, 25)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "bankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Enabled = False
        Me.CustomersDataGridView.Location = New System.Drawing.Point(240, 140)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(443, 221)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn3.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "overdraft"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "overdraft"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(67, 172)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(67, 210)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(67, 250)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BalanceTextBox.TabIndex = 7
        '
        'OverdraftCheckBox
        '
        Me.OverdraftCheckBox.Checked = True
        Me.OverdraftCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.OverdraftCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustomersBindingSource, "overdraft", True))
        Me.OverdraftCheckBox.Location = New System.Drawing.Point(67, 292)
        Me.OverdraftCheckBox.Name = "OverdraftCheckBox"
        Me.OverdraftCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.OverdraftCheckBox.TabIndex = 9
        Me.OverdraftCheckBox.UseVisualStyleBackColor = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataBaseAssignment.bankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Balance_Ascending_ToolStrip
        '
        Me.Balance_Ascending_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Balance_Ascending_ToolStripButton})
        Me.Balance_Ascending_ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.Balance_Ascending_ToolStrip.Name = "Balance_Ascending_ToolStrip"
        Me.Balance_Ascending_ToolStrip.Size = New System.Drawing.Size(706, 25)
        Me.Balance_Ascending_ToolStrip.TabIndex = 10
        Me.Balance_Ascending_ToolStrip.Text = "Balance_Ascending_ToolStrip"
        '
        'Balance_Ascending_ToolStripButton
        '
        Me.Balance_Ascending_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Balance_Ascending_ToolStripButton.Name = "Balance_Ascending_ToolStripButton"
        Me.Balance_Ascending_ToolStripButton.Size = New System.Drawing.Size(118, 22)
        Me.Balance_Ascending_ToolStripButton.Text = "Balance_Ascending_"
        '
        'Balance_Descending_ToolStrip
        '
        Me.Balance_Descending_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Balance_Descending_ToolStripButton})
        Me.Balance_Descending_ToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.Balance_Descending_ToolStrip.Name = "Balance_Descending_ToolStrip"
        Me.Balance_Descending_ToolStrip.Size = New System.Drawing.Size(706, 25)
        Me.Balance_Descending_ToolStrip.TabIndex = 11
        Me.Balance_Descending_ToolStrip.Text = "Balance_Descending_ToolStrip"
        '
        'Balance_Descending_ToolStripButton
        '
        Me.Balance_Descending_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Balance_Descending_ToolStripButton.Name = "Balance_Descending_ToolStripButton"
        Me.Balance_Descending_ToolStripButton.Size = New System.Drawing.Size(124, 22)
        Me.Balance_Descending_ToolStripButton.Text = "Balance_Descending_"
        '
        'Name_searchToolStrip
        '
        Me.Name_searchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripLabel, Me.NameToolStripTextBox, Me.Name_searchToolStripButton})
        Me.Name_searchToolStrip.Location = New System.Drawing.Point(0, 75)
        Me.Name_searchToolStrip.Name = "Name_searchToolStrip"
        Me.Name_searchToolStrip.Size = New System.Drawing.Size(706, 25)
        Me.Name_searchToolStrip.TabIndex = 12
        Me.Name_searchToolStrip.Text = "Name_searchToolStrip"
        '
        'NameToolStripLabel
        '
        Me.NameToolStripLabel.Name = "NameToolStripLabel"
        Me.NameToolStripLabel.Size = New System.Drawing.Size(42, 22)
        Me.NameToolStripLabel.Text = "Name:"
        '
        'NameToolStripTextBox
        '
        Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
        Me.NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Name_searchToolStripButton
        '
        Me.Name_searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Name_searchToolStripButton.Name = "Name_searchToolStripButton"
        Me.Name_searchToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.Name_searchToolStripButton.Text = "Search"
        '
        'ResetToolStrip
        '
        Me.ResetToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripButton})
        Me.ResetToolStrip.Location = New System.Drawing.Point(0, 100)
        Me.ResetToolStrip.Name = "ResetToolStrip"
        Me.ResetToolStrip.Size = New System.Drawing.Size(706, 25)
        Me.ResetToolStrip.TabIndex = 13
        Me.ResetToolStrip.Text = "ResetToolStrip"
        '
        'ResetToolStripButton
        '
        Me.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetToolStripButton.Name = "ResetToolStripButton"
        Me.ResetToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.ResetToolStripButton.Text = "Reset"
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(80, 360)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnDetails.TabIndex = 14
        Me.btnDetails.Text = "Edit Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(127, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(24, 360)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 17
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        Me.btnDone.Visible = False
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 437)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.ResetToolStrip)
        Me.Controls.Add(Me.Name_searchToolStrip)
        Me.Controls.Add(Me.Balance_Descending_ToolStrip)
        Me.Controls.Add(Me.Balance_Ascending_ToolStrip)
        Me.Controls.Add(OverdraftLabel)
        Me.Controls.Add(Me.OverdraftCheckBox)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Database"
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Balance_Ascending_ToolStrip.ResumeLayout(False)
        Me.Balance_Ascending_ToolStrip.PerformLayout()
        Me.Balance_Descending_ToolStrip.ResumeLayout(False)
        Me.Balance_Descending_ToolStrip.PerformLayout()
        Me.Name_searchToolStrip.ResumeLayout(False)
        Me.Name_searchToolStrip.PerformLayout()
        Me.ResetToolStrip.ResumeLayout(False)
        Me.ResetToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As DataBaseAssignment.bankDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As DataBaseAssignment.bankDataSetTableAdapters.customersTableAdapter
    Friend WithEvents TableAdapterManager As DataBaseAssignment.bankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OverdraftCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Balance_Ascending_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Balance_Ascending_ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Balance_Descending_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Balance_Descending_ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Name_searchToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NameToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Name_searchToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResetToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ResetToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Timer1 As Timer
End Class
