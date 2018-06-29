<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDay1
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
        Me.cmdPreview2 = New System.Windows.Forms.Button()
        Me.cmdPreview1 = New System.Windows.Forms.Button()
        Me.cmdPreview0 = New System.Windows.Forms.Button()
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.txtRoute0 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtRoute2 = New System.Windows.Forms.TextBox()
        Me.txtRoute3 = New System.Windows.Forms.TextBox()
        Me.txtRoute4 = New System.Windows.Forms.TextBox()
        Me.txtRout5 = New System.Windows.Forms.TextBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fraRoute.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPreview2
        '
        Me.cmdPreview2.Location = New System.Drawing.Point(126, 203)
        Me.cmdPreview2.Name = "cmdPreview2"
        Me.cmdPreview2.Size = New System.Drawing.Size(42, 22)
        Me.cmdPreview2.TabIndex = 21
        Me.cmdPreview2.Text = "View"
        Me.cmdPreview2.UseVisualStyleBackColor = True
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(126, 175)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(42, 22)
        Me.cmdPreview1.TabIndex = 20
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(126, 147)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(42, 22)
        Me.cmdPreview0.TabIndex = 19
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.txtRout5)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.TextBox1)
        Me.fraRoute.Controls.Add(Me.txtRoute0)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Location = New System.Drawing.Point(7, 42)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(253, 92)
        Me.fraRoute.TabIndex = 212
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Location = New System.Drawing.Point(14, 21)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 5
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(14, 44)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 6
        Me.optRoute1.TabStop = True
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(14, 67)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 7
        Me.optRoute2.TabStop = True
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'txtRoute0
        '
        Me.txtRoute0.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute0.Location = New System.Drawing.Point(112, 67)
        Me.txtRoute0.Multiline = True
        Me.txtRoute0.Name = "txtRoute0"
        Me.txtRoute0.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute0.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 20)
        Me.TextBox1.TabIndex = 17
        '
        'txtRoute2
        '
        Me.txtRoute2.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute2.Location = New System.Drawing.Point(133, 44)
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute2.TabIndex = 16
        '
        'txtRoute3
        '
        Me.txtRoute3.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute3.Location = New System.Drawing.Point(161, 44)
        Me.txtRoute3.Multiline = True
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute3.TabIndex = 15
        '
        'txtRoute4
        '
        Me.txtRoute4.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute4.Location = New System.Drawing.Point(189, 44)
        Me.txtRoute4.Multiline = True
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute4.TabIndex = 14
        '
        'txtRout5
        '
        Me.txtRout5.ForeColor = System.Drawing.Color.Navy
        Me.txtRout5.Location = New System.Drawing.Point(217, 44)
        Me.txtRout5.Multiline = True
        Me.txtRout5.Name = "txtRout5"
        Me.txtRout5.Size = New System.Drawing.Size(22, 20)
        Me.txtRout5.TabIndex = 13
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(43, 259)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(161, 259)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(14, 203)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(85, 17)
        Me.chkRpt2.TabIndex = 4
        Me.chkRpt2.Text = "&Load Report"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(14, 175)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(105, 17)
        Me.chkRpt1.TabIndex = 3
        Me.chkRpt1.Text = "Tripsheet &Recap"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(14, 147)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(75, 17)
        Me.chkRpt0.TabIndex = 2
        Me.chkRpt0.Text = "&Tripsheets"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(14, 238)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus1.TabIndex = 11
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(161, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
        '
        'frmRptDay1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.fraRoute)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview2)
        Me.Location = New System.Drawing.Point(257, 88)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptDay1"
        Me.ShowInTaskbar = False
        Me.Text = "Tripsheets/Load Reports"
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPreview2 As Button
    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents cmdPreview0 As Button
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents txtRoute0 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtRout5 As TextBox
    Friend WithEvents txtRoute4 As TextBox
    Friend WithEvents txtRoute3 As TextBox
    Friend WithEvents txtRoute2 As TextBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
End Class
