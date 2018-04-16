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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAssign = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assignment:"
        '
        'txtAssign
        '
        Me.txtAssign.Location = New System.Drawing.Point(91, 64)
        Me.txtAssign.Name = "txtAssign"
        Me.txtAssign.Size = New System.Drawing.Size(100, 20)
        Me.txtAssign.TabIndex = 1
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(17, 99)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(68, 13)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Exam Grade:"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(91, 96)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtGrade.TabIndex = 3
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(21, 26)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 4
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(24, 139)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(75, 23)
        Me.btnResults.TabIndex = 5
        Me.btnResults.Text = "Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(105, 144)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 13)
        Me.lblResults.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 183)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtAssign)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(271, 221)
        Me.Name = "Form1"
        Me.Text = "Question 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAssign As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents lblResults As System.Windows.Forms.Label

End Class
