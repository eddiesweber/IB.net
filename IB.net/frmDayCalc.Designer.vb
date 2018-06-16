<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDayCalc
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.txtRoute5 = New System.Windows.Forms.TextBox()
        Me.txtRoute4 = New System.Windows.Forms.TextBox()
        Me.txtRoute3 = New System.Windows.Forms.TextBox()
        Me.txtRoute2 = New System.Windows.Forms.TextBox()
        Me.txtRoute1 = New System.Windows.Forms.TextBox()
        Me.txtRoute0 = New System.Windows.Forms.TextBox()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.fraRoute.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(168, 175)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(49, 175)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 12
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute0)
        Me.fraRoute.Controls.Add(Me.txtRoute1)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute5)
        Me.fraRoute.Location = New System.Drawing.Point(7, 70)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(253, 92)
        Me.fraRoute.TabIndex = 12
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'txtRoute5
        '
        Me.txtRoute5.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute5.Location = New System.Drawing.Point(217, 42)
        Me.txtRoute5.Multiline = True
        Me.txtRoute5.Name = "txtRoute5"
        Me.txtRoute5.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute5.TabIndex = 9
        '
        'txtRoute4
        '
        Me.txtRoute4.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute4.Location = New System.Drawing.Point(189, 42)
        Me.txtRoute4.Multiline = True
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute4.TabIndex = 8
        '
        'txtRoute3
        '
        Me.txtRoute3.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute3.Location = New System.Drawing.Point(161, 42)
        Me.txtRoute3.Multiline = True
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute3.TabIndex = 7
        '
        'txtRoute2
        '
        Me.txtRoute2.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute2.Location = New System.Drawing.Point(133, 42)
        Me.txtRoute2.Multiline = True
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute2.TabIndex = 6
        '
        'txtRoute1
        '
        Me.txtRoute1.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute1.Location = New System.Drawing.Point(105, 42)
        Me.txtRoute1.Multiline = True
        Me.txtRoute1.Name = "txtRoute1"
        Me.txtRoute1.Size = New System.Drawing.Size(22, 19)
        Me.txtRoute1.TabIndex = 5
        '
        'txtRoute0
        '
        Me.txtRoute0.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute0.Location = New System.Drawing.Point(112, 63)
        Me.txtRoute0.Multiline = True
        Me.txtRoute0.Name = "txtRoute0"
        Me.txtRoute0.Size = New System.Drawing.Size(22, 20)
        Me.txtRoute0.TabIndex = 11
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(14, 63)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 10
        Me.optRoute2.TabStop = True
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(14, 42)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 14
        Me.optRoute1.TabStop = True
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Location = New System.Drawing.Point(14, 21)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 3
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(14, 231)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
        '
        'lblStatus0
        '
        Me.lblStatus0.AutoSize = True
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(14, 210)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus0.TabIndex = 15
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.ForeColor = System.Drawing.Color.Maroon
        Me.lblLast.Location = New System.Drawing.Point(14, 7)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(0, 13)
        Me.lblLast.TabIndex = 14
        '
        'frmDayCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 247)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.fraRoute)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Location = New System.Drawing.Point(58, 140)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDayCalc"
        Me.ShowInTaskbar = False
        Me.Text = "frmDayCalc"
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents txtRoute0 As TextBox
    Friend WithEvents txtRoute1 As TextBox
    Friend WithEvents txtRoute2 As TextBox
    Friend WithEvents txtRoute3 As TextBox
    Friend WithEvents txtRoute4 As TextBox
    Friend WithEvents txtRoute5 As TextBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents lblLast As Label
End Class
