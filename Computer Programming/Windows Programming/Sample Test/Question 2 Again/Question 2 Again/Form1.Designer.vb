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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDMC = New System.Windows.Forms.Button()
        Me.btnCrash = New System.Windows.Forms.Button()
        Me.btnRE = New System.Windows.Forms.Button()
        Me.btnMK = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem1})
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ResetToolStripMenuItem1
        '
        Me.ResetToolStripMenuItem1.Name = "ResetToolStripMenuItem1"
        Me.ResetToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem1.Text = "Reset"
        '
        'btnDMC
        '
        Me.btnDMC.Location = New System.Drawing.Point(12, 53)
        Me.btnDMC.Name = "btnDMC"
        Me.btnDMC.Size = New System.Drawing.Size(96, 46)
        Me.btnDMC.TabIndex = 1
        Me.btnDMC.Text = "Devil May Cry [5]"
        Me.btnDMC.UseVisualStyleBackColor = True
        '
        'btnCrash
        '
        Me.btnCrash.Location = New System.Drawing.Point(12, 105)
        Me.btnCrash.Name = "btnCrash"
        Me.btnCrash.Size = New System.Drawing.Size(96, 46)
        Me.btnCrash.TabIndex = 2
        Me.btnCrash.Text = "Crash Bandicoot [5]"
        Me.btnCrash.UseVisualStyleBackColor = True
        '
        'btnRE
        '
        Me.btnRE.Location = New System.Drawing.Point(12, 157)
        Me.btnRE.Name = "btnRE"
        Me.btnRE.Size = New System.Drawing.Size(96, 46)
        Me.btnRE.TabIndex = 3
        Me.btnRE.Text = "Resident Evil [5]"
        Me.btnRE.UseVisualStyleBackColor = True
        '
        'btnMK
        '
        Me.btnMK.Location = New System.Drawing.Point(12, 209)
        Me.btnMK.Name = "btnMK"
        Me.btnMK.Size = New System.Drawing.Size(96, 46)
        Me.btnMK.TabIndex = 4
        Me.btnMK.Text = "Mortal Kombat [5]"
        Me.btnMK.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(142, 53)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Label1"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 285)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnMK)
        Me.Controls.Add(Me.btnRE)
        Me.Controls.Add(Me.btnCrash)
        Me.Controls.Add(Me.btnDMC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnDMC As Button
    Friend WithEvents btnCrash As Button
    Friend WithEvents btnRE As Button
    Friend WithEvents btnMK As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
End Class
