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
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.rdomale = New System.Windows.Forms.RadioButton()
        Me.rdofemale = New System.Windows.Forms.RadioButton()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.lblEngine = New System.Windows.Forms.Label()
        Me.chkWindscreen = New System.Windows.Forms.CheckBox()
        Me.chkBreakdown = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblquote = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Age:"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(93, 71)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(100, 20)
        Me.txtage.TabIndex = 2
        '
        'rdomale
        '
        Me.rdomale.AutoSize = True
        Me.rdomale.Location = New System.Drawing.Point(93, 119)
        Me.rdomale.Name = "rdomale"
        Me.rdomale.Size = New System.Drawing.Size(48, 17)
        Me.rdomale.TabIndex = 3
        Me.rdomale.TabStop = True
        Me.rdomale.Text = "Male"
        Me.rdomale.UseVisualStyleBackColor = True
        '
        'rdofemale
        '
        Me.rdofemale.AutoSize = True
        Me.rdofemale.Location = New System.Drawing.Point(93, 142)
        Me.rdofemale.Name = "rdofemale"
        Me.rdofemale.Size = New System.Drawing.Size(59, 17)
        Me.rdofemale.TabIndex = 4
        Me.rdofemale.TabStop = True
        Me.rdofemale.Text = "Female"
        Me.rdofemale.UseVisualStyleBackColor = True
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"1000cc", "2000cc"})
        Me.cmbSize.Location = New System.Drawing.Point(93, 198)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(121, 21)
        Me.cmbSize.TabIndex = 5
        Me.cmbSize.Text = "Please select"
        '
        'lblEngine
        '
        Me.lblEngine.AutoSize = True
        Me.lblEngine.Location = New System.Drawing.Point(21, 201)
        Me.lblEngine.Name = "lblEngine"
        Me.lblEngine.Size = New System.Drawing.Size(66, 13)
        Me.lblEngine.TabIndex = 5
        Me.lblEngine.Text = "Engine Size:"
        '
        'chkWindscreen
        '
        Me.chkWindscreen.AutoSize = True
        Me.chkWindscreen.Location = New System.Drawing.Point(93, 247)
        Me.chkWindscreen.Name = "chkWindscreen"
        Me.chkWindscreen.Size = New System.Drawing.Size(114, 17)
        Me.chkWindscreen.TabIndex = 6
        Me.chkWindscreen.Text = "Windscreen Cover"
        Me.chkWindscreen.UseVisualStyleBackColor = True
        '
        'chkBreakdown
        '
        Me.chkBreakdown.AutoSize = True
        Me.chkBreakdown.Location = New System.Drawing.Point(93, 270)
        Me.chkBreakdown.Name = "chkBreakdown"
        Me.chkBreakdown.Size = New System.Drawing.Size(134, 17)
        Me.chkBreakdown.TabIndex = 7
        Me.chkBreakdown.Text = "Breakdown Assistance"
        Me.chkBreakdown.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Get Quote"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(201, 320)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Extras:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(93, 37)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 1
        '
        'lblquote
        '
        Me.lblquote.AutoSize = True
        Me.lblquote.Location = New System.Drawing.Point(99, 355)
        Me.lblquote.Name = "lblquote"
        Me.lblquote.Size = New System.Drawing.Size(0, 13)
        Me.lblquote.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 387)
        Me.Controls.Add(Me.lblquote)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkBreakdown)
        Me.Controls.Add(Me.chkWindscreen)
        Me.Controls.Add(Me.lblEngine)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.rdofemale)
        Me.Controls.Add(Me.rdomale)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(295, 425)
        Me.Name = "Form1"
        Me.Text = "Q1 2014"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents rdomale As System.Windows.Forms.RadioButton
    Friend WithEvents rdofemale As System.Windows.Forms.RadioButton
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblEngine As System.Windows.Forms.Label
    Friend WithEvents chkWindscreen As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreakdown As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents lblquote As System.Windows.Forms.Label

End Class
