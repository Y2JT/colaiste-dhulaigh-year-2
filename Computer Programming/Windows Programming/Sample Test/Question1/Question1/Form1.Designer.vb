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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.lblEngine = New System.Windows.Forms.Label()
        Me.cboEngine = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkWindscreen = New System.Windows.Forms.CheckBox()
        Me.chkBreakdown = New System.Windows.Forms.CheckBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(22, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(66, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(22, 79)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(66, 76)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 3
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(6, 116)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender:"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(73, 114)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 5
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(73, 137)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 6
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'lblEngine
        '
        Me.lblEngine.AutoSize = True
        Me.lblEngine.Location = New System.Drawing.Point(1, 168)
        Me.lblEngine.Name = "lblEngine"
        Me.lblEngine.Size = New System.Drawing.Size(66, 13)
        Me.lblEngine.TabIndex = 7
        Me.lblEngine.Text = "Engine Size:"
        '
        'cboEngine
        '
        Me.cboEngine.FormattingEnabled = True
        Me.cboEngine.Items.AddRange(New Object() {"1000cc", "2000cc"})
        Me.cboEngine.Location = New System.Drawing.Point(73, 165)
        Me.cboEngine.Name = "cboEngine"
        Me.cboEngine.Size = New System.Drawing.Size(93, 21)
        Me.cboEngine.TabIndex = 8
        Me.cboEngine.Text = "Please select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Extras:"
        '
        'chkWindscreen
        '
        Me.chkWindscreen.AutoSize = True
        Me.chkWindscreen.Location = New System.Drawing.Point(73, 204)
        Me.chkWindscreen.Name = "chkWindscreen"
        Me.chkWindscreen.Size = New System.Drawing.Size(114, 17)
        Me.chkWindscreen.TabIndex = 10
        Me.chkWindscreen.Text = "Windscreen Cover"
        Me.chkWindscreen.UseVisualStyleBackColor = True
        '
        'chkBreakdown
        '
        Me.chkBreakdown.AutoSize = True
        Me.chkBreakdown.Location = New System.Drawing.Point(73, 227)
        Me.chkBreakdown.Name = "chkBreakdown"
        Me.chkBreakdown.Size = New System.Drawing.Size(134, 17)
        Me.chkBreakdown.TabIndex = 11
        Me.chkBreakdown.Text = "Breakdown Assistance"
        Me.chkBreakdown.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(82, 265)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 13
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(1, 260)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(66, 23)
        Me.btnQuote.TabIndex = 14
        Me.btnQuote.Text = "Get Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 298)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.chkBreakdown)
        Me.Controls.Add(Me.chkWindscreen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboEngine)
        Me.Controls.Add(Me.lblEngine)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(270, 337)
        Me.Name = "Form1"
        Me.Text = "Question 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents lblEngine As Label
    Friend WithEvents cboEngine As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkWindscreen As CheckBox
    Friend WithEvents chkBreakdown As CheckBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnQuote As Button
End Class
