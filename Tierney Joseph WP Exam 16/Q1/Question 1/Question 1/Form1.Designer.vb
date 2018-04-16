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
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.chkWind = New System.Windows.Forms.CheckBox()
        Me.chkBreak = New System.Windows.Forms.CheckBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(68, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(12, 81)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(68, 78)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 3
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(12, 123)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender:"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(68, 121)
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
        Me.rdoFemale.Location = New System.Drawing.Point(68, 144)
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
        Me.lblEngine.Location = New System.Drawing.Point(12, 176)
        Me.lblEngine.Name = "lblEngine"
        Me.lblEngine.Size = New System.Drawing.Size(66, 13)
        Me.lblEngine.TabIndex = 7
        Me.lblEngine.Text = "Engine Size:"
        '
        'cboEngine
        '
        Me.cboEngine.FormattingEnabled = True
        Me.cboEngine.Items.AddRange(New Object() {"1000cc", "2000cc"})
        Me.cboEngine.Location = New System.Drawing.Point(84, 173)
        Me.cboEngine.Name = "cboEngine"
        Me.cboEngine.Size = New System.Drawing.Size(121, 21)
        Me.cboEngine.TabIndex = 8
        Me.cboEngine.Text = "Please select"
        '
        'lblExtra
        '
        Me.lblExtra.AutoSize = True
        Me.lblExtra.Location = New System.Drawing.Point(12, 219)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(39, 13)
        Me.lblExtra.TabIndex = 9
        Me.lblExtra.Text = "Extras:"
        '
        'chkWind
        '
        Me.chkWind.AutoSize = True
        Me.chkWind.Location = New System.Drawing.Point(68, 219)
        Me.chkWind.Name = "chkWind"
        Me.chkWind.Size = New System.Drawing.Size(114, 17)
        Me.chkWind.TabIndex = 10
        Me.chkWind.Text = "Windscreen Cover"
        Me.chkWind.UseVisualStyleBackColor = True
        '
        'chkBreak
        '
        Me.chkBreak.AutoSize = True
        Me.chkBreak.Location = New System.Drawing.Point(68, 242)
        Me.chkBreak.Name = "chkBreak"
        Me.chkBreak.Size = New System.Drawing.Size(134, 17)
        Me.chkBreak.TabIndex = 11
        Me.chkBreak.Text = "Breakdown Assistance"
        Me.chkBreak.UseVisualStyleBackColor = True
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(15, 285)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnQuote.TabIndex = 12
        Me.btnQuote.Text = "Get Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Location = New System.Drawing.Point(107, 290)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(0, 13)
        Me.lblQuote.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 333)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.chkBreak)
        Me.Controls.Add(Me.chkWind)
        Me.Controls.Add(Me.lblExtra)
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
        Me.MaximumSize = New System.Drawing.Size(271, 371)
        Me.Name = "Form1"
        Me.Text = "Question 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblEngine As System.Windows.Forms.Label
    Friend WithEvents cboEngine As System.Windows.Forms.ComboBox
    Friend WithEvents lblExtra As System.Windows.Forms.Label
    Friend WithEvents chkWind As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreak As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuote As System.Windows.Forms.Button
    Friend WithEvents lblQuote As System.Windows.Forms.Label

End Class
