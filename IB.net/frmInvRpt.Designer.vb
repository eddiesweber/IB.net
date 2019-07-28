<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvRpt))
        Me.chkRpt5 = New System.Windows.Forms.CheckBox()
        Me.chkRpt4 = New System.Windows.Forms.CheckBox()
        Me.chkRpt3 = New System.Windows.Forms.CheckBox()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview2 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview3 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview4 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview5 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.datDate0 = New C1.Win.Calendar.C1DateEdit()
        Me.datDate1 = New C1.Win.Calendar.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRpt5
        '
        Me.chkRpt5.AutoSize = True
        Me.chkRpt5.Location = New System.Drawing.Point(30, 225)
        Me.chkRpt5.Name = "chkRpt5"
        Me.chkRpt5.Size = New System.Drawing.Size(130, 17)
        Me.chkRpt5.TabIndex = 0
        Me.chkRpt5.Text = "Sales/&Delivery Recon"
        Me.chkRpt5.UseVisualStyleBackColor = True
        '
        'chkRpt4
        '
        Me.chkRpt4.AutoSize = True
        Me.chkRpt4.Location = New System.Drawing.Point(30, 190)
        Me.chkRpt4.Name = "chkRpt4"
        Me.chkRpt4.Size = New System.Drawing.Size(95, 17)
        Me.chkRpt4.TabIndex = 15
        Me.chkRpt4.Text = "Special &Orders"
        Me.chkRpt4.UseVisualStyleBackColor = True
        '
        'chkRpt3
        '
        Me.chkRpt3.AutoSize = True
        Me.chkRpt3.Location = New System.Drawing.Point(30, 155)
        Me.chkRpt3.Name = "chkRpt3"
        Me.chkRpt3.Size = New System.Drawing.Size(122, 17)
        Me.chkRpt3.TabIndex = 13
        Me.chkRpt3.Text = "Sales &History Report"
        Me.chkRpt3.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(30, 120)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(99, 17)
        Me.chkRpt2.TabIndex = 8
        Me.chkRpt2.Text = "&Reorder Report"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(30, 50)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(106, 17)
        Me.chkRpt0.TabIndex = 4
        Me.chkRpt0.Text = "&Sales by Product"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(30, 85)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(105, 17)
        Me.chkRpt1.TabIndex = 6
        Me.chkRpt1.Text = "&Inventory Report"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&From Date:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(65, 290)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 79
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(156, 290)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 78
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(220, 80)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 90
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview2
        '
        Me.cmdPreview2.Location = New System.Drawing.Point(220, 115)
        Me.cmdPreview2.Name = "cmdPreview2"
        Me.cmdPreview2.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview2.TabIndex = 89
        Me.cmdPreview2.Text = "View"
        Me.cmdPreview2.UseVisualStyleBackColor = True
        Me.cmdPreview2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview3
        '
        Me.cmdPreview3.Location = New System.Drawing.Point(220, 150)
        Me.cmdPreview3.Name = "cmdPreview3"
        Me.cmdPreview3.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview3.TabIndex = 88
        Me.cmdPreview3.Text = "View"
        Me.cmdPreview3.UseVisualStyleBackColor = True
        Me.cmdPreview3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview4
        '
        Me.cmdPreview4.Location = New System.Drawing.Point(220, 185)
        Me.cmdPreview4.Name = "cmdPreview4"
        Me.cmdPreview4.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview4.TabIndex = 87
        Me.cmdPreview4.Text = "View"
        Me.cmdPreview4.UseVisualStyleBackColor = True
        Me.cmdPreview4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview5
        '
        Me.cmdPreview5.Location = New System.Drawing.Point(220, 220)
        Me.cmdPreview5.Name = "cmdPreview5"
        Me.cmdPreview5.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview5.TabIndex = 86
        Me.cmdPreview5.Text = "View"
        Me.cmdPreview5.UseVisualStyleBackColor = True
        Me.cmdPreview5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(220, 45)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 85
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate0
        '
        Me.datDate0.AllowSpinLoop = False
        Me.datDate0.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate0.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate0.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate0.Location = New System.Drawing.Point(67, 15)
        Me.datDate0.Name = "datDate0"
        Me.datDate0.Size = New System.Drawing.Size(105, 18)
        Me.datDate0.TabIndex = 93
        Me.datDate0.Tag = Nothing
        '
        'datDate1
        '
        Me.datDate1.AllowSpinLoop = False
        Me.datDate1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate1.Location = New System.Drawing.Point(192, 15)
        Me.datDate1.Name = "datDate1"
        Me.datDate1.Size = New System.Drawing.Size(105, 18)
        Me.datDate1.TabIndex = 92
        Me.datDate1.Tag = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "to"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(29, 260)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(241, 19)
        Me.lblStatus.TabIndex = 94
        '
        'frmInvRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 326)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.datDate0)
        Me.Controls.Add(Me.datDate1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview2)
        Me.Controls.Add(Me.cmdPreview3)
        Me.Controls.Add(Me.cmdPreview4)
        Me.Controls.Add(Me.cmdPreview5)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.chkRpt3)
        Me.Controls.Add(Me.chkRpt4)
        Me.Controls.Add(Me.chkRpt5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(203, 289)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvRpt"
        Me.ShowInTaskbar = False
        Me.Text = "Inventory Reports"
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkRpt5 As CheckBox
    Friend WithEvents chkRpt4 As CheckBox
    Friend WithEvents chkRpt3 As CheckBox
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview2 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview3 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview4 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview5 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents datDate0 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datDate1 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
End Class
