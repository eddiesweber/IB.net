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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptInv))
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New C1.Win.C1Input.C1Button()
        Me.optFormat0 = New System.Windows.Forms.RadioButton()
        Me.optFormat1 = New System.Windows.Forms.RadioButton()
        Me.optFormat2 = New System.Windows.Forms.RadioButton()
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.txtRoute5 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute4 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute3 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute2 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute1 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute0 = New C1.Win.C1Input.C1TextBox()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.txtNumber0 = New C1.Win.C1Input.C1TextBox()
        Me.txtNumber1 = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkNumber = New System.Windows.Forms.CheckBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.txtMemo = New C1.Win.C1Input.C1TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.DsCalcLogOrderbyRunDate = New IB.net.dsCalcLogOrderbyRunDate()
        Me.CalcLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalcLogTableAdapter = New IB.net.dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter()
        Me.DsCompany_CompanyID = New IB.net.dsCompany_CompanyID()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New IB.net.dsCompany_CompanyIDTableAdapters.CompanyTableAdapter()
        Me.Frame2.SuspendLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraRoute.SuspendLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.Button1)
        Me.Frame2.Controls.Add(Me.optFormat0)
        Me.Frame2.Controls.Add(Me.optFormat1)
        Me.Frame2.Controls.Add(Me.optFormat2)
        Me.Frame2.Location = New System.Drawing.Point(10, 205)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(300, 100)
        Me.Frame2.TabIndex = 15
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "&Format"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 25)
        Me.Button1.TabIndex = 220
        Me.Button1.Text = "&Select Form Printer"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optFormat0
        '
        Me.optFormat0.AutoSize = True
        Me.optFormat0.Checked = True
        Me.optFormat0.Location = New System.Drawing.Point(15, 20)
        Me.optFormat0.Name = "optFormat0"
        Me.optFormat0.Size = New System.Drawing.Size(99, 17)
        Me.optFormat0.TabIndex = 16
        Me.optFormat0.TabStop = True
        Me.optFormat0.Text = "Preprinted Form"
        Me.optFormat0.UseVisualStyleBackColor = True
        '
        'optFormat1
        '
        Me.optFormat1.AutoSize = True
        Me.optFormat1.Location = New System.Drawing.Point(15, 45)
        Me.optFormat1.Name = "optFormat1"
        Me.optFormat1.Size = New System.Drawing.Size(133, 17)
        Me.optFormat1.TabIndex = 18
        Me.optFormat1.Text = "Laser Customer Format"
        Me.optFormat1.UseVisualStyleBackColor = True
        '
        'optFormat2
        '
        Me.optFormat2.AutoSize = True
        Me.optFormat2.Location = New System.Drawing.Point(15, 70)
        Me.optFormat2.Name = "optFormat2"
        Me.optFormat2.Size = New System.Drawing.Size(113, 17)
        Me.optFormat2.TabIndex = 19
        Me.optFormat2.Text = "Laser Plant Format"
        Me.optFormat2.UseVisualStyleBackColor = True
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.txtRoute5)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute1)
        Me.fraRoute.Controls.Add(Me.txtRoute0)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Location = New System.Drawing.Point(10, 95)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(300, 100)
        Me.fraRoute.TabIndex = 16
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'txtRoute5
        '
        Me.txtRoute5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute5.Location = New System.Drawing.Point(207, 45)
        Me.txtRoute5.Name = "txtRoute5"
        Me.txtRoute5.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute5.TabIndex = 26
        Me.txtRoute5.Tag = Nothing
        Me.txtRoute5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute4
        '
        Me.txtRoute4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute4.Location = New System.Drawing.Point(182, 45)
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute4.TabIndex = 25
        Me.txtRoute4.Tag = Nothing
        Me.txtRoute4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute3
        '
        Me.txtRoute3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute3.Location = New System.Drawing.Point(157, 45)
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute3.TabIndex = 24
        Me.txtRoute3.Tag = Nothing
        Me.txtRoute3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute2
        '
        Me.txtRoute2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute2.Location = New System.Drawing.Point(132, 45)
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute2.TabIndex = 23
        Me.txtRoute2.Tag = Nothing
        Me.txtRoute2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute1
        '
        Me.txtRoute1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute1.Location = New System.Drawing.Point(107, 45)
        Me.txtRoute1.Name = "txtRoute1"
        Me.txtRoute1.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute1.TabIndex = 22
        Me.txtRoute1.Tag = Nothing
        Me.txtRoute1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute0
        '
        Me.txtRoute0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute0.Location = New System.Drawing.Point(115, 70)
        Me.txtRoute0.Name = "txtRoute0"
        Me.txtRoute0.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute0.TabIndex = 21
        Me.txtRoute0.Tag = Nothing
        Me.txtRoute0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(15, 70)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 14
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(15, 45)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 8
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Checked = True
        Me.optRoute0.Location = New System.Drawing.Point(15, 20)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 7
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.datDate)
        Me.Frame1.Controls.Add(Me.txtNumber0)
        Me.Frame1.Controls.Add(Me.txtNumber1)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblDate)
        Me.Frame1.Controls.Add(Me.chkNumber)
        Me.Frame1.Controls.Add(Me.chkDate)
        Me.Frame1.Location = New System.Drawing.Point(10, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(300, 75)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Include:"
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
        Me.datDate.Location = New System.Drawing.Point(138, 19)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(107, 18)
        Me.datDate.TabIndex = 223
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtNumber0
        '
        Me.txtNumber0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber0.Location = New System.Drawing.Point(145, 45)
        Me.txtNumber0.Name = "txtNumber0"
        Me.txtNumber0.Size = New System.Drawing.Size(60, 18)
        Me.txtNumber0.TabIndex = 29
        Me.txtNumber0.Tag = Nothing
        Me.txtNumber0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtNumber0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtNumber1
        '
        Me.txtNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber1.Location = New System.Drawing.Point(230, 45)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(60, 18)
        Me.txtNumber1.TabIndex = 28
        Me.txtNumber1.Tag = Nothing
        Me.txtNumber1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtNumber1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(210, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "to"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(252, 21)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 27
        '
        'chkNumber
        '
        Me.chkNumber.AutoSize = True
        Me.chkNumber.Location = New System.Drawing.Point(15, 45)
        Me.chkNumber.Name = "chkNumber"
        Me.chkNumber.Size = New System.Drawing.Size(133, 17)
        Me.chkNumber.TabIndex = 3
        Me.chkNumber.Text = "Only Invoice &Numbers:"
        Me.chkNumber.UseVisualStyleBackColor = True
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(15, 20)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(125, 17)
        Me.chkDate.TabIndex = 1
        Me.chkDate.Text = "Only Invoices &Dated:"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "&Message:"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(71, 380)
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
        Me.cmdCancel.Location = New System.Drawing.Point(162, 380)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 219
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtMemo
        '
        Me.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemo.Location = New System.Drawing.Point(10, 330)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(300, 18)
        Me.txtMemo.TabIndex = 221
        Me.txtMemo.Tag = Nothing
        Me.txtMemo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMemo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(10, 355)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(300, 13)
        Me.lblStatus.TabIndex = 222
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
        'frmRptInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 416)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.fraRoute)
        Me.Controls.Add(Me.Frame2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(129, 125)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptInv"
        Me.ShowInTaskbar = False
        Me.Text = "Print Invoices"
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents optFormat2 As RadioButton
    Friend WithEvents optFormat1 As RadioButton
    Friend WithEvents optFormat0 As RadioButton
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents chkDate As CheckBox
    Friend WithEvents chkNumber As CheckBox
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents txtNumber0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNumber1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents txtMemo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents lblStatus As Label
    Friend WithEvents DsCalcLogOrderbyRunDate As dsCalcLogOrderbyRunDate
    Friend WithEvents CalcLogBindingSource As BindingSource
    Friend WithEvents CalcLogTableAdapter As dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter
    Friend WithEvents DsCompany_CompanyID As dsCompany_CompanyID
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As dsCompany_CompanyIDTableAdapters.CompanyTableAdapter
End Class
