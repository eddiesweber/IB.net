<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmiscrpt
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
        Me.frm2 = New System.Windows.Forms.GroupBox()
        Me.optPriorperiod = New System.Windows.Forms.RadioButton()
        Me.optNewpaper = New System.Windows.Forms.RadioButton()
        Me.optSca = New System.Windows.Forms.RadioButton()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.txtItemNumOpt = New System.Windows.Forms.TextBox()
        Me.optCurrentPeriod = New System.Windows.Forms.RadioButton()
        Me.optMonthlyitem = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdDisrpt = New System.Windows.Forms.Button()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.Option4 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdLytd = New System.Windows.Forms.Button()
        Me.cmdYtd = New System.Windows.Forms.Button()
        Me.txtItemNum = New System.Windows.Forms.TextBox()
        Me.cmdItemActivity = New System.Windows.Forms.Button()
        Me.lblItemNumEnter = New System.Windows.Forms.Label()
        Me.frm2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm2
        '
        Me.frm2.Controls.Add(Me.Label1)
        Me.frm2.Controls.Add(Me.optMonthlyitem)
        Me.frm2.Controls.Add(Me.optCurrentPeriod)
        Me.frm2.Controls.Add(Me.txtItemNumOpt)
        Me.frm2.Controls.Add(Me.Command3)
        Me.frm2.Controls.Add(Me.optPriorperiod)
        Me.frm2.Controls.Add(Me.optNewpaper)
        Me.frm2.Controls.Add(Me.optSca)
        Me.frm2.Location = New System.Drawing.Point(16, 16)
        Me.frm2.Name = "frm2"
        Me.frm2.Size = New System.Drawing.Size(329, 169)
        Me.frm2.TabIndex = 13
        Me.frm2.TabStop = False
        Me.frm2.Text = "Select Report"
        '
        'optPriorperiod
        '
        Me.optPriorperiod.AutoSize = True
        Me.optPriorperiod.Location = New System.Drawing.Point(24, 64)
        Me.optPriorperiod.Name = "optPriorperiod"
        Me.optPriorperiod.Size = New System.Drawing.Size(182, 17)
        Me.optPriorperiod.TabIndex = 19
        Me.optPriorperiod.TabStop = True
        Me.optPriorperiod.Text = "Paper Comparison by Prior Period"
        Me.optPriorperiod.UseVisualStyleBackColor = True
        '
        'optNewpaper
        '
        Me.optNewpaper.AutoSize = True
        Me.optNewpaper.Location = New System.Drawing.Point(24, 80)
        Me.optNewpaper.Name = "optNewpaper"
        Me.optNewpaper.Size = New System.Drawing.Size(153, 17)
        Me.optNewpaper.TabIndex = 20
        Me.optNewpaper.TabStop = True
        Me.optNewpaper.Text = "New Monthly Paper Report"
        Me.optNewpaper.UseVisualStyleBackColor = True
        '
        'optSca
        '
        Me.optSca.AutoSize = True
        Me.optSca.Location = New System.Drawing.Point(24, 96)
        Me.optSca.Name = "optSca"
        Me.optSca.Size = New System.Drawing.Size(131, 17)
        Me.optSca.TabIndex = 21
        Me.optSca.TabStop = True
        Me.optSca.Text = "SCA Dispenser Report"
        Me.optSca.UseVisualStyleBackColor = True
        '
        'Command3
        '
        Me.Command3.Location = New System.Drawing.Point(96, 128)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(97, 34)
        Me.Command3.TabIndex = 21
        Me.Command3.Text = "View Selected Report"
        Me.Command3.UseVisualStyleBackColor = True
        '
        'txtItemNumOpt
        '
        Me.txtItemNumOpt.Location = New System.Drawing.Point(224, 32)
        Me.txtItemNumOpt.Name = "txtItemNumOpt"
        Me.txtItemNumOpt.Size = New System.Drawing.Size(73, 20)
        Me.txtItemNumOpt.TabIndex = 19
        '
        'optCurrentPeriod
        '
        Me.optCurrentPeriod.AutoSize = True
        Me.optCurrentPeriod.Location = New System.Drawing.Point(24, 48)
        Me.optCurrentPeriod.Name = "optCurrentPeriod"
        Me.optCurrentPeriod.Size = New System.Drawing.Size(195, 17)
        Me.optCurrentPeriod.TabIndex = 15
        Me.optCurrentPeriod.TabStop = True
        Me.optCurrentPeriod.Text = "Paper Comparison by Current Period"
        Me.optCurrentPeriod.UseVisualStyleBackColor = True
        '
        'optMonthlyitem
        '
        Me.optMonthlyitem.AutoSize = True
        Me.optMonthlyitem.Location = New System.Drawing.Point(24, 32)
        Me.optMonthlyitem.Name = "optMonthlyitem"
        Me.optMonthlyitem.Size = New System.Drawing.Size(157, 17)
        Me.optMonthlyitem.TabIndex = 14
        Me.optMonthlyitem.TabStop = True
        Me.optMonthlyitem.Text = "Monthly Item Activity Report"
        Me.optMonthlyitem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enter Item Number"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.Controls.Add(Me.Option3)
        Me.Frame1.Controls.Add(Me.Option4)
        Me.Frame1.Controls.Add(Me.Command4)
        Me.Frame1.Location = New System.Drawing.Point(16, 200)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(329, 161)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "BobM Report Seattle Only"
        Me.Frame1.Visible = False
        '
        'cmdDisrpt
        '
        Me.cmdDisrpt.Location = New System.Drawing.Point(232, 16)
        Me.cmdDisrpt.Name = "cmdDisrpt"
        Me.cmdDisrpt.Size = New System.Drawing.Size(89, 36)
        Me.cmdDisrpt.TabIndex = 12
        Me.cmdDisrpt.Text = "SCA Dispensor Report"
        Me.cmdDisrpt.UseVisualStyleBackColor = True
        Me.cmdDisrpt.Visible = False
        '
        'Command4
        '
        Me.Command4.Location = New System.Drawing.Point(8, 40)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(113, 29)
        Me.Command4.TabIndex = 22
        Me.Command4.Text = "View BobM Report"
        Me.Command4.UseVisualStyleBackColor = True
        '
        'Option4
        '
        Me.Option4.AutoSize = True
        Me.Option4.Location = New System.Drawing.Point(136, 120)
        Me.Option4.Name = "Option4"
        Me.Option4.Size = New System.Drawing.Size(84, 17)
        Me.Option4.TabIndex = 11
        Me.Option4.TabStop = True
        Me.Option4.Text = "AWPR +City"
        Me.Option4.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Location = New System.Drawing.Point(136, 96)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(61, 17)
        Me.Option3.TabIndex = 10
        Me.Option3.TabStop = True
        Me.Option3.Text = "City + #"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Location = New System.Drawing.Point(136, 72)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(80, 17)
        Me.Option2.TabIndex = 9
        Me.Option2.TabStop = True
        Me.Option2.Text = "AWR + City"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Location = New System.Drawing.Point(136, 46)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(72, 17)
        Me.Option1.TabIndex = 8
        Me.Option1.TabStop = True
        Me.Option1.Text = "Name + #"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Select Sort"
        '
        'Command2
        '
        Me.Command2.Location = New System.Drawing.Point(344, 0)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(89, 68)
        Me.Command2.TabIndex = 6
        Me.Command2.Text = "BobM Report SEATTLE ONLY"
        Me.Command2.UseVisualStyleBackColor = True
        Me.Command2.Visible = False
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(128, 80)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(89, 65)
        Me.Command1.TabIndex = 5
        Me.Command1.Text = "New Monthly Paper Report"
        Me.Command1.UseVisualStyleBackColor = True
        Me.Command1.Visible = False
        '
        'cmdLytd
        '
        Me.cmdLytd.Location = New System.Drawing.Point(344, 74)
        Me.cmdLytd.Name = "cmdLytd"
        Me.cmdLytd.Size = New System.Drawing.Size(89, 65)
        Me.cmdLytd.TabIndex = 4
        Me.cmdLytd.Text = "Paper Comparison Report (sorted by prior period)"
        Me.cmdLytd.UseVisualStyleBackColor = True
        Me.cmdLytd.Visible = False
        '
        'cmdYtd
        '
        Me.cmdYtd.Location = New System.Drawing.Point(16, 56)
        Me.cmdYtd.Name = "cmdYtd"
        Me.cmdYtd.Size = New System.Drawing.Size(89, 73)
        Me.cmdYtd.TabIndex = 3
        Me.cmdYtd.Text = "Paper Comparison Report (sorted by current period)"
        Me.cmdYtd.UseVisualStyleBackColor = True
        Me.cmdYtd.Visible = False
        '
        'txtItemNum
        '
        Me.txtItemNum.Location = New System.Drawing.Point(352, 176)
        Me.txtItemNum.Name = "txtItemNum"
        Me.txtItemNum.Size = New System.Drawing.Size(89, 20)
        Me.txtItemNum.TabIndex = 1
        Me.txtItemNum.Visible = False
        '
        'cmdItemActivity
        '
        Me.cmdItemActivity.Location = New System.Drawing.Point(16, 16)
        Me.cmdItemActivity.Name = "cmdItemActivity"
        Me.cmdItemActivity.Size = New System.Drawing.Size(89, 42)
        Me.cmdItemActivity.TabIndex = 0
        Me.cmdItemActivity.Text = "Monthly Item Activity Report"
        Me.cmdItemActivity.UseVisualStyleBackColor = True
        Me.cmdItemActivity.Visible = False
        '
        'lblItemNumEnter
        '
        Me.lblItemNumEnter.AutoSize = True
        Me.lblItemNumEnter.Location = New System.Drawing.Point(352, 160)
        Me.lblItemNumEnter.Name = "lblItemNumEnter"
        Me.lblItemNumEnter.Size = New System.Drawing.Size(65, 13)
        Me.lblItemNumEnter.TabIndex = 2
        Me.lblItemNumEnter.Text = "Enter Item #"
        '
        'frmmiscrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 374)
        Me.Controls.Add(Me.lblItemNumEnter)
        Me.Controls.Add(Me.cmdItemActivity)
        Me.Controls.Add(Me.txtItemNum)
        Me.Controls.Add(Me.cmdYtd)
        Me.Controls.Add(Me.cmdLytd)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.cmdDisrpt)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.frm2)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmmiscrpt"
        Me.Text = "Misc Reports"
        Me.frm2.ResumeLayout(False)
        Me.frm2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frm2 As GroupBox
    Friend WithEvents optPriorperiod As RadioButton
    Friend WithEvents optNewpaper As RadioButton
    Friend WithEvents optSca As RadioButton
    Friend WithEvents Command3 As Button
    Friend WithEvents optCurrentPeriod As RadioButton
    Friend WithEvents txtItemNumOpt As TextBox
    Friend WithEvents optMonthlyitem As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents cmdDisrpt As Button
    Friend WithEvents Command4 As Button
    Friend WithEvents Option3 As RadioButton
    Friend WithEvents Option4 As RadioButton
    Friend WithEvents Option2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Option1 As RadioButton
    Friend WithEvents Command2 As Button
    Friend WithEvents Command1 As Button
    Friend WithEvents cmdLytd As Button
    Friend WithEvents cmdYtd As Button
    Friend WithEvents txtItemNum As TextBox
    Friend WithEvents cmdItemActivity As Button
    Friend WithEvents lblItemNumEnter As Label
End Class
