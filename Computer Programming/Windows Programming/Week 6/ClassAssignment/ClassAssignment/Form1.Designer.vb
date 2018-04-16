<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAssign1 = New System.Windows.Forms.Label()
        Me.lblAssign2 = New System.Windows.Forms.Label()
        Me.lblAssign3 = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAssign1 = New System.Windows.Forms.TextBox()
        Me.txtAssign2 = New System.Windows.Forms.TextBox()
        Me.txtAssign3 = New System.Windows.Forms.TextBox()
        Me.btnPunk = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(283, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblAssign1
        '
        Me.lblAssign1.AutoSize = True
        Me.lblAssign1.Location = New System.Drawing.Point(12, 84)
        Me.lblAssign1.Name = "lblAssign1"
        Me.lblAssign1.Size = New System.Drawing.Size(70, 13)
        Me.lblAssign1.TabIndex = 2
        Me.lblAssign1.Text = "Assignment 1"
        '
        'lblAssign2
        '
        Me.lblAssign2.AutoSize = True
        Me.lblAssign2.Location = New System.Drawing.Point(12, 115)
        Me.lblAssign2.Name = "lblAssign2"
        Me.lblAssign2.Size = New System.Drawing.Size(70, 13)
        Me.lblAssign2.TabIndex = 3
        Me.lblAssign2.Text = "Assignment 2"
        '
        'lblAssign3
        '
        Me.lblAssign3.AutoSize = True
        Me.lblAssign3.Location = New System.Drawing.Point(12, 147)
        Me.lblAssign3.Name = "lblAssign3"
        Me.lblAssign3.Size = New System.Drawing.Size(70, 13)
        Me.lblAssign3.TabIndex = 4
        Me.lblAssign3.Text = "Assignment 3"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(97, 187)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 5
        Me.btnTotal.Text = "Get Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(82, 226)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(97, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 7
        '
        'txtAssign1
        '
        Me.txtAssign1.Location = New System.Drawing.Point(97, 81)
        Me.txtAssign1.MaxLength = 3
        Me.txtAssign1.Name = "txtAssign1"
        Me.txtAssign1.Size = New System.Drawing.Size(100, 20)
        Me.txtAssign1.TabIndex = 8
        '
        'txtAssign2
        '
        Me.txtAssign2.Location = New System.Drawing.Point(97, 112)
        Me.txtAssign2.MaxLength = 3
        Me.txtAssign2.Name = "txtAssign2"
        Me.txtAssign2.Size = New System.Drawing.Size(100, 20)
        Me.txtAssign2.TabIndex = 9
        '
        'txtAssign3
        '
        Me.txtAssign3.Location = New System.Drawing.Point(97, 144)
        Me.txtAssign3.MaxLength = 3
        Me.txtAssign3.Name = "txtAssign3"
        Me.txtAssign3.Size = New System.Drawing.Size(100, 20)
        Me.txtAssign3.TabIndex = 10
        '
        'btnPunk
        '
        Me.btnPunk.Location = New System.Drawing.Point(7, 226)
        Me.btnPunk.Name = "btnPunk"
        Me.btnPunk.Size = New System.Drawing.Size(264, 23)
        Me.btnPunk.TabIndex = 11
        Me.btnPunk.Text = "Button1"
        Me.btnPunk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 268)
        Me.Controls.Add(Me.btnPunk)
        Me.Controls.Add(Me.txtAssign3)
        Me.Controls.Add(Me.txtAssign2)
        Me.Controls.Add(Me.txtAssign1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblAssign3)
        Me.Controls.Add(Me.lblAssign2)
        Me.Controls.Add(Me.lblAssign1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Grade Check"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAssign1 As System.Windows.Forms.Label
    Friend WithEvents lblAssign2 As System.Windows.Forms.Label
    Friend WithEvents lblAssign3 As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAssign1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAssign2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAssign3 As System.Windows.Forms.TextBox
    Friend WithEvents btnPunk As System.Windows.Forms.Button

End Class
