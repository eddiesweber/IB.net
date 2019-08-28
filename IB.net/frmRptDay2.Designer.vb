<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDay2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptDay2))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optSince0 = New System.Windows.Forms.RadioButton()
        Me.optSince1 = New System.Windows.Forms.RadioButton()
        Me.chkRpt4 = New System.Windows.Forms.CheckBox()
        Me.chkRpt3 = New System.Windows.Forms.CheckBox()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.datQtr = New C1.Win.Calendar.C1DateEdit()
        Me.DsCalcLogOrderbyRunDate = New IB.net.dsCalcLogOrderbyRunDate()
        Me.CalcLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalcLogTableAdapter = New IB.net.dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter()
        Me.DsCompany_CompanyID = New IB.net.dsCompany_CompanyID()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New IB.net.dsCompany_CompanyIDTableAdapters.CompanyTableAdapter()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datQtr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optSince0)
        Me.Frame1.Controls.Add(Me.optSince1)
        Me.Frame1.Location = New System.Drawing.Point(235, 40)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(150, 50)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Since"
        '
        'optSince0
        '
        Me.optSince0.AutoSize = True
        Me.optSince0.Location = New System.Drawing.Point(10, 20)
        Me.optSince0.Name = "optSince0"
        Me.optSince0.Size = New System.Drawing.Size(69, 17)
        Me.optSince0.TabIndex = 5
        Me.optSince0.Text = "Calculate"
        Me.optSince0.UseVisualStyleBackColor = True
        '
        'optSince1
        '
        Me.optSince1.AutoSize = True
        Me.optSince1.Checked = True
        Me.optSince1.Location = New System.Drawing.Point(80, 20)
        Me.optSince1.Name = "optSince1"
        Me.optSince1.Size = New System.Drawing.Size(69, 17)
        Me.optSince1.TabIndex = 6
        Me.optSince1.TabStop = True
        Me.optSince1.Text = "Tripsheet"
        Me.optSince1.UseVisualStyleBackColor = True
        '
        'chkRpt4
        '
        Me.chkRpt4.AutoSize = True
        Me.chkRpt4.Location = New System.Drawing.Point(25, 172)
        Me.chkRpt4.Name = "chkRpt4"
        Me.chkRpt4.Size = New System.Drawing.Size(103, 17)
        Me.chkRpt4.TabIndex = 13
        Me.chkRpt4.Text = "&Monthly Reports"
        Me.chkRpt4.UseVisualStyleBackColor = True
        '
        'chkRpt3
        '
        Me.chkRpt3.AutoSize = True
        Me.chkRpt3.Location = New System.Drawing.Point(25, 139)
        Me.chkRpt3.Name = "chkRpt3"
        Me.chkRpt3.Size = New System.Drawing.Size(102, 17)
        Me.chkRpt3.TabIndex = 10
        Me.chkRpt3.Text = "&Weekly Reports"
        Me.chkRpt3.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(25, 107)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(127, 17)
        Me.chkRpt2.TabIndex = 9
        Me.chkRpt2.Text = "Daily &Volume Reports"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(25, 75)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(135, 17)
        Me.chkRpt1.TabIndex = 7
        Me.chkRpt1.Text = "Route Reciepts &Recap"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(25, 43)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(106, 17)
        Me.chkRpt0.TabIndex = 2
        Me.chkRpt0.Text = "&Invoice Changes"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Quarter Began:"
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(15, 200)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(369, 13)
        Me.lblStatus1.TabIndex = 3
        Me.lblStatus1.Text = "lblStatus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(111, 225)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 220
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(202, 225)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 219
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(170, 70)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 222
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(170, 40)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 221
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate
        '
        Me.datDate.AllowSpinLoop = False
        Me.datDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate.Location = New System.Drawing.Point(55, 10)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 223
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datQtr
        '
        Me.datQtr.AllowSpinLoop = False
        Me.datQtr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datQtr.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datQtr.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datQtr.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datQtr.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datQtr.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datQtr.Location = New System.Drawing.Point(245, 123)
        Me.datQtr.Name = "datQtr"
        Me.datQtr.Size = New System.Drawing.Size(125, 18)
        Me.datQtr.TabIndex = 224
        Me.datQtr.Tag = Nothing
        Me.datQtr.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datQtr.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'DsCalcLogOrderbyRunDate
        '
        Me.DsCalcLogOrderbyRunDate.DataSetName = "dsCalcLogOrderbyRunDate"
        Me.DsCalcLogOrderbyRunDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalcLogBindingSource
        '
        Me.CalcLogBindingSource.DataMember = "CalcLog"
        Me.CalcLogBindingSource.DataSource = Me.DsCalcLogOrderbyRunDate
        '
        'CalcLogTableAdapter
        '
        Me.CalcLogTableAdapter.ClearBeforeFill = True
        '
        'DsCompany_CompanyID
        '
        Me.DsCompany_CompanyID.DataSetName = "dsCompany_CompanyID"
        Me.DsCompany_CompanyID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.DsCompany_CompanyID
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(186, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(68, 13)
        Me.lblDate.TabIndex = 225
        Me.lblDate.Text = "lblDate"
        '
        'frmRptDay2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 261)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.datQtr)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.chkRpt3)
        Me.Controls.Add(Me.chkRpt4)
        Me.Controls.Add(Me.Frame1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(163, 176)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptDay2"
        Me.ShowInTaskbar = False
        Me.Text = "Recap Reports"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datQtr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optSince0 As RadioButton
    Friend WithEvents optSince1 As RadioButton
    Friend WithEvents chkRpt4 As CheckBox
    Friend WithEvents chkRpt3 As CheckBox
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datQtr As C1.Win.Calendar.C1DateEdit
    Friend WithEvents DsCalcLogOrderbyRunDate As dsCalcLogOrderbyRunDate
    Friend WithEvents CalcLogBindingSource As BindingSource
    Friend WithEvents CalcLogTableAdapter As dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter
    Friend WithEvents DsCompany_CompanyID As dsCompany_CompanyID
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As dsCompany_CompanyIDTableAdapters.CompanyTableAdapter
    Friend WithEvents lblDate As Label
End Class
