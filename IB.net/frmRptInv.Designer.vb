<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptInv
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
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.optFormat2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.optFormat1 = New System.Windows.Forms.RadioButton()
        Me.optFormat0 = New System.Windows.Forms.RadioButton()
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtRoute1 = New System.Windows.Forms.TextBox()
        Me.txtRoute2 = New System.Windows.Forms.TextBox()
        Me.txtRoute3 = New System.Windows.Forms.TextBox()
        Me.txtRoute4 = New System.Windows.Forms.TextBox()
        Me.txtRoute5 = New System.Windows.Forms.TextBox()
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.chkNumber = New System.Windows.Forms.CheckBox()
        Me.txtNumber0 = New System.Windows.Forms.TextBox()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        Me.fraRoute.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.optFormat0)
        Me.Frame2.Controls.Add(Me.optFormat1)
        Me.Frame2.Controls.Add(Me.Button1)
        Me.Frame2.Controls.Add(Me.optFormat2)
        Me.Frame2.Location = New System.Drawing.Point(8, 200)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(301, 89)
        Me.Frame2.TabIndex = 15
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "&Format"
        '
        'optFormat2
        '
        Me.optFormat2.AutoSize = True
        Me.optFormat2.Location = New System.Drawing.Point(16, 63)
        Me.optFormat2.Name = "optFormat2"
        Me.optFormat2.Size = New System.Drawing.Size(113, 17)
        Me.optFormat2.TabIndex = 19
        Me.optFormat2.TabStop = True
        Me.optFormat2.Text = "Laser Plant Format"
        Me.optFormat2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 22)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Select Form Printer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'optFormat1
        '
        Me.optFormat1.AutoSize = True
        Me.optFormat1.Location = New System.Drawing.Point(16, 42)
        Me.optFormat1.Name = "optFormat1"
        Me.optFormat1.Size = New System.Drawing.Size(133, 17)
        Me.optFormat1.TabIndex = 18
        Me.optFormat1.TabStop = True
        Me.optFormat1.Text = "Laser Customer Format"
        Me.optFormat1.UseVisualStyleBackColor = True
        '
        'optFormat0
        '
        Me.optFormat0.AutoSize = True
        Me.optFormat0.Location = New System.Drawing.Point(16, 21)
        Me.optFormat0.Name = "optFormat0"
        Me.optFormat0.Size = New System.Drawing.Size(99, 17)
        Me.optFormat0.TabIndex = 16
        Me.optFormat0.TabStop = True
        Me.optFormat0.Text = "Preprinted Form"
        Me.optFormat0.UseVisualStyleBackColor = True
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.txtRoute5)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute1)
        Me.fraRoute.Controls.Add(Me.TextBox1)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Location = New System.Drawing.Point(7, 98)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(301, 89)
        Me.fraRoute.TabIndex = 16
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Location = New System.Drawing.Point(16, 21)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 7
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(16, 42)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 8
        Me.optRoute1.TabStop = True
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(16, 63)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 14
        Me.optRoute2.TabStop = True
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(112, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 20)
        Me.TextBox1.TabIndex = 20
        '
        'txtRoute1
        '
        Me.txtRoute1.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute1.Location = New System.Drawing.Point(105, 41)
        Me.txtRoute1.Name = "txtRoute1"
        Me.txtRoute1.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute1.TabIndex = 9
        '
        'txtRoute2
        '
        Me.txtRoute2.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute2.Location = New System.Drawing.Point(133, 41)
        Me.txtRoute2.Multiline = True
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute2.TabIndex = 10
        '
        'txtRoute3
        '
        Me.txtRoute3.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute3.Location = New System.Drawing.Point(161, 41)
        Me.txtRoute3.Multiline = True
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute3.TabIndex = 11
        '
        'txtRoute4
        '
        Me.txtRoute4.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute4.Location = New System.Drawing.Point(189, 41)
        Me.txtRoute4.Multiline = True
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute4.TabIndex = 12
        '
        'txtRoute5
        '
        Me.txtRoute5.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute5.Location = New System.Drawing.Point(217, 41)
        Me.txtRoute5.Multiline = True
        Me.txtRoute5.Name = "txtRoute5"
        Me.txtRoute5.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute5.TabIndex = 13
        '
        'txtMemo
        '
        Me.txtMemo.ForeColor = System.Drawing.Color.Navy
        Me.txtMemo.Location = New System.Drawing.Point(7, 318)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(302, 20)
        Me.txtMemo.TabIndex = 22
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblDate)
        Me.Frame1.Controls.Add(Me.txtNumber1)
        Me.Frame1.Controls.Add(Me.txtNumber0)
        Me.Frame1.Controls.Add(Me.chkNumber)
        Me.Frame1.Controls.Add(Me.chkDate)
        Me.Frame1.Location = New System.Drawing.Point(7, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(301, 89)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Include:"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(14, 21)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(125, 17)
        Me.chkDate.TabIndex = 1
        Me.chkDate.Text = "Only Invoices &Dated:"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'chkNumber
        '
        Me.chkNumber.AutoSize = True
        Me.chkNumber.Location = New System.Drawing.Point(14, 49)
        Me.chkNumber.Name = "chkNumber"
        Me.chkNumber.Size = New System.Drawing.Size(133, 17)
        Me.chkNumber.TabIndex = 3
        Me.chkNumber.Text = "Only Invoice &Numbers:"
        Me.chkNumber.UseVisualStyleBackColor = True
        '
        'txtNumber0
        '
        Me.txtNumber0.Enabled = False
        Me.txtNumber0.ForeColor = System.Drawing.Color.Navy
        Me.txtNumber0.Location = New System.Drawing.Point(147, 49)
        Me.txtNumber0.Multiline = True
        Me.txtNumber0.Name = "txtNumber0"
        Me.txtNumber0.Size = New System.Drawing.Size(57, 19)
        Me.txtNumber0.TabIndex = 4
        '
        'txtNumber1
        '
        Me.txtNumber1.Enabled = False
        Me.txtNumber1.ForeColor = System.Drawing.Color.Navy
        Me.txtNumber1.Location = New System.Drawing.Point(238, 49)
        Me.txtNumber1.Multiline = True
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(57, 19)
        Me.txtNumber1.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(245, 28)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(217, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "to"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(77, 346)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 23
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(175, 346)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 24
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "&Message:"
        '
        'frmRptInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.fraRoute)
        Me.Controls.Add(Me.Frame2)
        Me.Location = New System.Drawing.Point(129, 125)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptInv"
        Me.ShowInTaskbar = False
        Me.Text = "Print Invoices"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents optFormat2 As RadioButton
    Friend WithEvents optFormat1 As RadioButton
    Friend WithEvents optFormat0 As RadioButton
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents txtRoute1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtRoute4 As TextBox
    Friend WithEvents txtRoute3 As TextBox
    Friend WithEvents txtRoute2 As TextBox
    Friend WithEvents txtRoute5 As TextBox
    Friend WithEvents txtMemo As TextBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents chkDate As CheckBox
    Friend WithEvents txtNumber0 As TextBox
    Friend WithEvents chkNumber As CheckBox
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label2 As Label
End Class
