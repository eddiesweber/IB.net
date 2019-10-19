<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptComm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptComm))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.datDate1 = New C1.Win.Calendar.C1DateEdit()
        Me.datDate0 = New C1.Win.Calendar.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.Frame1.SuspendLayout()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.datDate1)
        Me.Frame1.Controls.Add(Me.datDate0)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(15, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(307, 50)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Date Range:"
        '
        'datDate1
        '
        Me.datDate1.AllowSpinLoop = False
        Me.datDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate1.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate1.Location = New System.Drawing.Point(166, 20)
        Me.datDate1.Name = "datDate1"
        Me.datDate1.Size = New System.Drawing.Size(125, 18)
        Me.datDate1.TabIndex = 4
        Me.datDate1.Tag = Nothing
        Me.datDate1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate0
        '
        Me.datDate0.AllowSpinLoop = False
        Me.datDate0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate0.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate0.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate0.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate0.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate0.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate0.Location = New System.Drawing.Point(15, 20)
        Me.datDate0.Name = "datDate0"
        Me.datDate0.Size = New System.Drawing.Size(125, 18)
        Me.datDate0.TabIndex = 3
        Me.datDate0.Tag = Nothing
        Me.datDate0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "to"
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Checked = True
        Me.chkRpt0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRpt0.Location = New System.Drawing.Point(35, 75)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(53, 17)
        Me.chkRpt0.TabIndex = 4
        Me.chkRpt0.Text = "D&etail"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Checked = True
        Me.chkRpt1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRpt1.Location = New System.Drawing.Point(35, 105)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(69, 17)
        Me.chkRpt1.TabIndex = 5
        Me.chkRpt1.Text = "&Summary"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(15, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(307, 15)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "lblStatus"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(170, 165)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(80, 165)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 11
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(250, 100)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 82
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(250, 70)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 81
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRptComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 201)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.Frame1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(237, 226)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptComm"
        Me.ShowInTaskbar = False
        Me.Text = "Commission Reports"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.datDate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents datDate1 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datDate0 As C1.Win.Calendar.C1DateEdit
End Class
