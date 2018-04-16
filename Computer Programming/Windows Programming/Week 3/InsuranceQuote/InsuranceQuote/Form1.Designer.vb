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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStarName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblStarAge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEngine = New System.Windows.Forms.ComboBox()
        Me.lblStarEngine = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.lblStarGender = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkBreakdown = New System.Windows.Forms.CheckBox()
        Me.chkWindscreen = New System.Windows.Forms.CheckBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'lblStarName
        '
        Me.lblStarName.AutoSize = True
        Me.lblStarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarName.ForeColor = System.Drawing.Color.Red
        Me.lblStarName.Location = New System.Drawing.Point(203, 26)
        Me.lblStarName.Name = "lblStarName"
        Me.lblStarName.Size = New System.Drawing.Size(18, 24)
        Me.lblStarName.TabIndex = 1
        Me.lblStarName.Text = "*"
        Me.lblStarName.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(97, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(97, 63)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 20)
        Me.txtAge.TabIndex = 6
        '
        'lblStarAge
        '
        Me.lblStarAge.AutoSize = True
        Me.lblStarAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarAge.ForeColor = System.Drawing.Color.Red
        Me.lblStarAge.Location = New System.Drawing.Point(203, 66)
        Me.lblStarAge.Name = "lblStarAge"
        Me.lblStarAge.Size = New System.Drawing.Size(18, 24)
        Me.lblStarAge.TabIndex = 7
        Me.lblStarAge.Text = "*"
        Me.lblStarAge.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Engine Size"
        '
        'cboEngine
        '
        Me.cboEngine.FormattingEnabled = True
        Me.cboEngine.Items.AddRange(New Object() {"1000cc", "2000cc"})
        Me.cboEngine.Location = New System.Drawing.Point(97, 102)
        Me.cboEngine.Name = "cboEngine"
        Me.cboEngine.Size = New System.Drawing.Size(100, 21)
        Me.cboEngine.TabIndex = 9
        Me.cboEngine.Text = "Please select"
        '
        'lblStarEngine
        '
        Me.lblStarEngine.AutoSize = True
        Me.lblStarEngine.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarEngine.ForeColor = System.Drawing.Color.Red
        Me.lblStarEngine.Location = New System.Drawing.Point(203, 105)
        Me.lblStarEngine.Name = "lblStarEngine"
        Me.lblStarEngine.Size = New System.Drawing.Size(18, 24)
        Me.lblStarEngine.TabIndex = 10
        Me.lblStarEngine.Text = "*"
        Me.lblStarEngine.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Gender"
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(97, 140)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 12
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(97, 163)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 13
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'lblStarGender
        '
        Me.lblStarGender.AutoSize = True
        Me.lblStarGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStarGender.ForeColor = System.Drawing.Color.Red
        Me.lblStarGender.Location = New System.Drawing.Point(203, 156)
        Me.lblStarGender.Name = "lblStarGender"
        Me.lblStarGender.Size = New System.Drawing.Size(18, 24)
        Me.lblStarGender.TabIndex = 14
        Me.lblStarGender.Text = "*"
        Me.lblStarGender.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Extras"
        '
        'chkBreakdown
        '
        Me.chkBreakdown.AutoSize = True
        Me.chkBreakdown.Location = New System.Drawing.Point(97, 199)
        Me.chkBreakdown.Name = "chkBreakdown"
        Me.chkBreakdown.Size = New System.Drawing.Size(110, 17)
        Me.chkBreakdown.TabIndex = 16
        Me.chkBreakdown.Text = "Breakdown Assist"
        Me.chkBreakdown.UseVisualStyleBackColor = True
        '
        'chkWindscreen
        '
        Me.chkWindscreen.AutoSize = True
        Me.chkWindscreen.Location = New System.Drawing.Point(97, 222)
        Me.chkWindscreen.Name = "chkWindscreen"
        Me.chkWindscreen.Size = New System.Drawing.Size(114, 17)
        Me.chkWindscreen.TabIndex = 17
        Me.chkWindscreen.Text = "Windscreen Cover"
        Me.chkWindscreen.UseVisualStyleBackColor = True
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(107, 262)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnQuote.TabIndex = 18
        Me.btnQuote.Text = "Get Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuote.Location = New System.Drawing.Point(40, 297)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(0, 17)
        Me.lblQuote.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 332)
        Me.Controls.Add(Me.lblQuote)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.chkWindscreen)
        Me.Controls.Add(Me.chkBreakdown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStarGender)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStarEngine)
        Me.Controls.Add(Me.cboEngine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStarAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStarName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Insurance Quote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStarName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblStarAge As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEngine As System.Windows.Forms.ComboBox
    Friend WithEvents lblStarEngine As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblStarGender As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkBreakdown As System.Windows.Forms.CheckBox
    Friend WithEvents chkWindscreen As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuote As System.Windows.Forms.Button
    Friend WithEvents lblQuote As System.Windows.Forms.Label

End Class
