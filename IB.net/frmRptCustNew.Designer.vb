<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCustNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptCustNew))
        Me.chkRpt5 = New System.Windows.Forms.CheckBox()
        Me.chkRpt4 = New System.Windows.Forms.CheckBox()
        Me.chkFullCust = New System.Windows.Forms.CheckBox()
        Me.chkRpt3 = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.datDate0 = New C1.Win.Calendar.C1DateEdit()
        Me.datDate1 = New C1.Win.Calendar.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdView0 = New C1.Win.C1Input.C1Button()
        Me.cmdView6 = New C1.Win.C1Input.C1Button()
        Me.cmdView5 = New C1.Win.C1Input.C1Button()
        Me.cmdView4 = New C1.Win.C1Input.C1Button()
        Me.cmdView3 = New C1.Win.C1Input.C1Button()
        Me.cmdView2 = New C1.Win.C1Input.C1Button()
        Me.cmdView1 = New C1.Win.C1Input.C1Button()
        Me.Frame1.SuspendLayout()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRpt5
        '
        Me.chkRpt5.AutoSize = True
        Me.chkRpt5.Location = New System.Drawing.Point(20, 285)
        Me.chkRpt5.Name = "chkRpt5"
        Me.chkRpt5.Size = New System.Drawing.Size(106, 17)
        Me.chkRpt5.TabIndex = 20
        Me.chkRpt5.Text = "Recollect Report"
        Me.chkRpt5.UseVisualStyleBackColor = True
        '
        'chkRpt4
        '
        Me.chkRpt4.AutoSize = True
        Me.chkRpt4.Location = New System.Drawing.Point(20, 250)
        Me.chkRpt4.Name = "chkRpt4"
        Me.chkRpt4.Size = New System.Drawing.Size(97, 17)
        Me.chkRpt4.TabIndex = 7
        Me.chkRpt4.Text = "Stop Deliveries"
        Me.chkRpt4.UseVisualStyleBackColor = True
        '
        'chkFullCust
        '
        Me.chkFullCust.AutoSize = True
        Me.chkFullCust.Location = New System.Drawing.Point(20, 208)
        Me.chkFullCust.Name = "chkFullCust"
        Me.chkFullCust.Size = New System.Drawing.Size(124, 30)
        Me.chkFullCust.TabIndex = 8
        Me.chkFullCust.Text = "Full Customer Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (very long)"
        Me.chkFullCust.UseVisualStyleBackColor = True
        '
        'chkRpt3
        '
        Me.chkRpt3.AutoSize = True
        Me.chkRpt3.Location = New System.Drawing.Point(20, 180)
        Me.chkRpt3.Name = "chkRpt3"
        Me.chkRpt3.Size = New System.Drawing.Size(89, 17)
        Me.chkRpt3.TabIndex = 9
        Me.chkRpt3.Text = "&Cancellations"
        Me.chkRpt3.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.datDate0)
        Me.Frame1.Controls.Add(Me.datDate1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(10, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(250, 50)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Date Range:"
        '
        'datDate0
        '
        Me.datDate0.AllowSpinLoop = False
        Me.datDate0.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate0.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate0.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate0.Location = New System.Drawing.Point(10, 20)
        Me.datDate0.Name = "datDate0"
        Me.datDate0.Size = New System.Drawing.Size(105, 18)
        Me.datDate0.TabIndex = 88
        Me.datDate0.Tag = Nothing
        '
        'datDate1
        '
        Me.datDate1.AllowSpinLoop = False
        Me.datDate1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate1.Location = New System.Drawing.Point(135, 20)
        Me.datDate1.Name = "datDate1"
        Me.datDate1.Size = New System.Drawing.Size(105, 18)
        Me.datDate1.TabIndex = 87
        Me.datDate1.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "to"
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(20, 75)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(100, 17)
        Me.chkRpt0.TabIndex = 4
        Me.chkRpt0.Text = "&New Customers"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(20, 145)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(120, 17)
        Me.chkRpt2.TabIndex = 6
        Me.chkRpt2.Text = "Contract E&xpirations"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(20, 110)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(132, 17)
        Me.chkRpt1.TabIndex = 5
        Me.chkRpt1.Text = "Contract &Anniversaries"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(10, 320)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(250, 15)
        Me.lblStatus1.TabIndex = 12
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(137, 350)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 76
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(46, 350)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 77
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView0
        '
        Me.cmdView0.Location = New System.Drawing.Point(200, 70)
        Me.cmdView0.Name = "cmdView0"
        Me.cmdView0.Size = New System.Drawing.Size(50, 25)
        Me.cmdView0.TabIndex = 78
        Me.cmdView0.Text = "View"
        Me.cmdView0.UseVisualStyleBackColor = True
        Me.cmdView0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView6
        '
        Me.cmdView6.Location = New System.Drawing.Point(200, 280)
        Me.cmdView6.Name = "cmdView6"
        Me.cmdView6.Size = New System.Drawing.Size(50, 25)
        Me.cmdView6.TabIndex = 79
        Me.cmdView6.Text = "View"
        Me.cmdView6.UseVisualStyleBackColor = True
        Me.cmdView6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView5
        '
        Me.cmdView5.Location = New System.Drawing.Point(200, 245)
        Me.cmdView5.Name = "cmdView5"
        Me.cmdView5.Size = New System.Drawing.Size(50, 25)
        Me.cmdView5.TabIndex = 80
        Me.cmdView5.Text = "View"
        Me.cmdView5.UseVisualStyleBackColor = True
        Me.cmdView5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView4
        '
        Me.cmdView4.Location = New System.Drawing.Point(200, 210)
        Me.cmdView4.Name = "cmdView4"
        Me.cmdView4.Size = New System.Drawing.Size(50, 25)
        Me.cmdView4.TabIndex = 81
        Me.cmdView4.Text = "View"
        Me.cmdView4.UseVisualStyleBackColor = True
        Me.cmdView4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView3
        '
        Me.cmdView3.Location = New System.Drawing.Point(200, 175)
        Me.cmdView3.Name = "cmdView3"
        Me.cmdView3.Size = New System.Drawing.Size(50, 25)
        Me.cmdView3.TabIndex = 82
        Me.cmdView3.Text = "View"
        Me.cmdView3.UseVisualStyleBackColor = True
        Me.cmdView3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView2
        '
        Me.cmdView2.Location = New System.Drawing.Point(200, 140)
        Me.cmdView2.Name = "cmdView2"
        Me.cmdView2.Size = New System.Drawing.Size(50, 25)
        Me.cmdView2.TabIndex = 83
        Me.cmdView2.Text = "View"
        Me.cmdView2.UseVisualStyleBackColor = True
        Me.cmdView2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdView1
        '
        Me.cmdView1.Location = New System.Drawing.Point(200, 105)
        Me.cmdView1.Name = "cmdView1"
        Me.cmdView1.Size = New System.Drawing.Size(50, 25)
        Me.cmdView1.TabIndex = 84
        Me.cmdView1.Text = "View"
        Me.cmdView1.UseVisualStyleBackColor = True
        Me.cmdView1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdView1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRptCustNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 386)
        Me.Controls.Add(Me.cmdView1)
        Me.Controls.Add(Me.cmdView2)
        Me.Controls.Add(Me.cmdView3)
        Me.Controls.Add(Me.cmdView4)
        Me.Controls.Add(Me.cmdView5)
        Me.Controls.Add(Me.cmdView6)
        Me.Controls.Add(Me.cmdView0)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.chkRpt3)
        Me.Controls.Add(Me.chkFullCust)
        Me.Controls.Add(Me.chkRpt4)
        Me.Controls.Add(Me.chkRpt5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(170, 99)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptCustNew"
        Me.ShowInTaskbar = False
        Me.Text = "Customer Reports"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkRpt5 As CheckBox
    Friend WithEvents chkRpt4 As CheckBox
    Friend WithEvents chkFullCust As CheckBox
    Friend WithEvents chkRpt3 As CheckBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView0 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView6 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView5 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView4 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView3 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView2 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdView1 As C1.Win.C1Input.C1Button
    Friend WithEvents datDate0 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datDate1 As C1.Win.Calendar.C1DateEdit
End Class
