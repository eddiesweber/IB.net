<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvRebill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvRebill))
        Me.fraOption = New System.Windows.Forms.GroupBox()
        Me.optAction0 = New System.Windows.Forms.RadioButton()
        Me.optAction1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblData3 = New System.Windows.Forms.Label()
        Me.lblData2 = New System.Windows.Forms.Label()
        Me.lblData1 = New System.Windows.Forms.Label()
        Me.lblData8 = New System.Windows.Forms.Label()
        Me.lblData9 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lbllabel11 = New System.Windows.Forms.Label()
        Me.lblCurInvoice = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.cmdFindInv = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.SpGetInvoiceHeadingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvoiceHeading = New IB.net.dsspGetInvoiceHeading()
        Me.txtMemo = New C1.Win.C1Input.C1TextBox()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData12 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtdata1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.datNewDate = New C1.Win.Calendar.C1DateEdit()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SpGetInvoiceHeadingTableAdapter = New IB.net.dsspGetInvoiceHeadingTableAdapters.spGetInvoiceHeadingTableAdapter()
        Me.fraOption.SuspendLayout()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvoiceHeadingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvoiceHeading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdata1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datNewDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraOption
        '
        Me.fraOption.Controls.Add(Me.optAction0)
        Me.fraOption.Controls.Add(Me.optAction1)
        Me.fraOption.Location = New System.Drawing.Point(10, 125)
        Me.fraOption.Name = "fraOption"
        Me.fraOption.Size = New System.Drawing.Size(300, 70)
        Me.fraOption.TabIndex = 5
        Me.fraOption.TabStop = False
        Me.fraOption.Text = "&Action:"
        '
        'optAction0
        '
        Me.optAction0.AutoSize = True
        Me.optAction0.Location = New System.Drawing.Point(14, 20)
        Me.optAction0.Name = "optAction0"
        Me.optAction0.Size = New System.Drawing.Size(265, 17)
        Me.optAction0.TabIndex = 6
        Me.optAction0.TabStop = True
        Me.optAction0.Text = "Delivered as scheduled, bill on new date (recollect)"
        Me.optAction0.UseVisualStyleBackColor = True
        '
        'optAction1
        '
        Me.optAction1.AutoSize = True
        Me.optAction1.Location = New System.Drawing.Point(14, 43)
        Me.optAction1.Name = "optAction1"
        Me.optAction1.Size = New System.Drawing.Size(217, 17)
        Me.optAction1.TabIndex = 7
        Me.optAction1.TabStop = True
        Me.optAction1.Text = "Deliver and bill on new date (reschedule)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.optAction1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(168, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 26
        '
        'lblData3
        '
        Me.lblData3.AutoSize = True
        Me.lblData3.Location = New System.Drawing.Point(100, 46)
        Me.lblData3.Name = "lblData3"
        Me.lblData3.Size = New System.Drawing.Size(33, 13)
        Me.lblData3.TabIndex = 24
        Me.lblData3.Text = "Dept:"
        '
        'lblData2
        '
        Me.lblData2.AutoSize = True
        Me.lblData2.Location = New System.Drawing.Point(10, 46)
        Me.lblData2.Name = "lblData2"
        Me.lblData2.Size = New System.Drawing.Size(31, 13)
        Me.lblData2.TabIndex = 23
        Me.lblData2.Text = "Cust:"
        '
        'lblData1
        '
        Me.lblData1.AutoSize = True
        Me.lblData1.Location = New System.Drawing.Point(192, 46)
        Me.lblData1.Name = "lblData1"
        Me.lblData1.Size = New System.Drawing.Size(33, 13)
        Me.lblData1.TabIndex = 22
        Me.lblData1.Text = "Date:"
        '
        'lblData8
        '
        Me.lblData8.AutoSize = True
        Me.lblData8.Location = New System.Drawing.Point(191, 61)
        Me.lblData8.Name = "lblData8"
        Me.lblData8.Size = New System.Drawing.Size(39, 13)
        Me.lblData8.TabIndex = 21
        Me.lblData8.Text = "Route:"
        '
        'lblData9
        '
        Me.lblData9.AutoSize = True
        Me.lblData9.Location = New System.Drawing.Point(192, 76)
        Me.lblData9.Name = "lblData9"
        Me.lblData9.Size = New System.Drawing.Size(32, 13)
        Me.lblData9.TabIndex = 20
        Me.lblData9.Text = "Stop:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(10, 270)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 13)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "lblStatus"
        '
        'lbllabel11
        '
        Me.lbllabel11.AutoSize = True
        Me.lbllabel11.Location = New System.Drawing.Point(7, 207)
        Me.lbllabel11.Name = "lbllabel11"
        Me.lbllabel11.Size = New System.Drawing.Size(39, 13)
        Me.lbllabel11.TabIndex = 12
        Me.lbllabel11.Text = "&Memo:"
        '
        'lblCurInvoice
        '
        Me.lblCurInvoice.AutoSize = True
        Me.lblCurInvoice.Location = New System.Drawing.Point(234, 16)
        Me.lblCurInvoice.Name = "lblCurInvoice"
        Me.lblCurInvoice.Size = New System.Drawing.Size(68, 13)
        Me.lblCurInvoice.TabIndex = 11
        Me.lblCurInvoice.Text = "lblCurInvoice"
        Me.lblCurInvoice.Visible = False
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 103)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(58, 13)
        Me.lblLabel4.TabIndex = 3
        Me.lblLabel4.Text = "New &Date:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(10, 16)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel5.TabIndex = 0
        Me.lblLabel5.Text = "&Invoice:"
        '
        'cmdFindInv
        '
        Me.cmdFindInv.Location = New System.Drawing.Point(135, 10)
        Me.cmdFindInv.Name = "cmdFindInv"
        Me.cmdFindInv.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindInv.TabIndex = 84
        Me.cmdFindInv.Text = "&Find"
        Me.cmdFindInv.UseVisualStyleBackColor = True
        Me.cmdFindInv.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "INV_NUMBER", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(53, 14)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(75, 18)
        Me.txtData0.TabIndex = 85
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetInvoiceHeadingBindingSource
        '
        Me.SpGetInvoiceHeadingBindingSource.DataMember = "spGetInvoiceHeading"
        Me.SpGetInvoiceHeadingBindingSource.DataSource = Me.DsspGetInvoiceHeading
        '
        'DsspGetInvoiceHeading
        '
        Me.DsspGetInvoiceHeading.DataSetName = "dsspGetInvoiceHeading"
        Me.DsspGetInvoiceHeading.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMemo
        '
        Me.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "CHANGE_MEMO", True))
        Me.txtMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(50, 205)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(260, 18)
        Me.txtMemo.TabIndex = 91
        Me.txtMemo.Tag = Nothing
        Me.txtMemo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMemo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(67, 235)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 92
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(172, 235)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 93
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData2.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "DEL_NAME", True))
        Me.txtData2.Location = New System.Drawing.Point(10, 60)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData2.Size = New System.Drawing.Size(175, 15)
        Me.txtData2.TabIndex = 94
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData5.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "CUST_NUM", True))
        Me.txtData5.DataType = GetType(Integer)
        Me.txtData5.Location = New System.Drawing.Point(45, 45)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData5.Size = New System.Drawing.Size(50, 15)
        Me.txtData5.TabIndex = 95
        Me.txtData5.Tag = Nothing
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData12
        '
        Me.txtData12.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData12.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "SEQUENCE", True))
        Me.txtData12.DataType = GetType(Single)
        Me.txtData12.Location = New System.Drawing.Point(230, 75)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData12.Size = New System.Drawing.Size(50, 15)
        Me.txtData12.TabIndex = 96
        Me.txtData12.Tag = Nothing
        Me.txtData12.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData11.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "ROUTE", True))
        Me.txtData11.DataType = GetType(Short)
        Me.txtData11.Location = New System.Drawing.Point(230, 60)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData11.Size = New System.Drawing.Size(50, 15)
        Me.txtData11.TabIndex = 97
        Me.txtData11.Tag = Nothing
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData10.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "DATE", True))
        Me.txtData10.DataType = GetType(Date)
        Me.txtData10.Location = New System.Drawing.Point(230, 45)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData10.Size = New System.Drawing.Size(60, 15)
        Me.txtData10.TabIndex = 98
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtdata1
        '
        Me.txtdata1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtdata1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtdata1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdata1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "DEPT", True))
        Me.txtdata1.DataType = GetType(Short)
        Me.txtdata1.Location = New System.Drawing.Point(135, 45)
        Me.txtdata1.Name = "txtdata1"
        Me.txtdata1.Padding = New System.Windows.Forms.Padding(1)
        Me.txtdata1.Size = New System.Drawing.Size(30, 15)
        Me.txtdata1.TabIndex = 99
        Me.txtdata1.Tag = Nothing
        Me.txtdata1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData3.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvoiceHeadingBindingSource, "WEEKDAY", True))
        Me.txtData3.Location = New System.Drawing.Point(290, 45)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData3.Size = New System.Drawing.Size(25, 15)
        Me.txtData3.TabIndex = 100
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datNewDate
        '
        Me.datNewDate.AllowSpinLoop = False
        Me.datNewDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datNewDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datNewDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datNewDate.Location = New System.Drawing.Point(65, 100)
        Me.datNewDate.Name = "datNewDate"
        Me.datNewDate.Size = New System.Drawing.Size(125, 18)
        Me.datNewDate.TabIndex = 101
        Me.datNewDate.Tag = Nothing
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(201, 103)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 13)
        Me.lblDate.TabIndex = 102
        Me.lblDate.Text = "lblDate"
        Me.lblDate.Visible = False
        '
        'SpGetInvoiceHeadingTableAdapter
        '
        Me.SpGetInvoiceHeadingTableAdapter.ClearBeforeFill = True
        '
        'frmInvRebill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 291)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.datNewDate)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtdata1)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData12)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdFindInv)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblCurInvoice)
        Me.Controls.Add(Me.lbllabel11)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblData9)
        Me.Controls.Add(Me.lblData8)
        Me.Controls.Add(Me.lblData1)
        Me.Controls.Add(Me.lblData2)
        Me.Controls.Add(Me.lblData3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fraOption)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(158, 14)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvRebill"
        Me.ShowInTaskbar = False
        Me.Text = "Rebill Invoice"
        Me.fraOption.ResumeLayout(False)
        Me.fraOption.PerformLayout()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvoiceHeadingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvoiceHeading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdata1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datNewDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fraOption As GroupBox
    Friend WithEvents optAction1 As RadioButton
    Friend WithEvents optAction0 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblData3 As Label
    Friend WithEvents lblData2 As Label
    Friend WithEvents lblData1 As Label
    Friend WithEvents lblData8 As Label
    Friend WithEvents lblData9 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lbllabel11 As Label
    Friend WithEvents lblCurInvoice As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents cmdFindInv As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMemo As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData12 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtdata1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents datNewDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents lblDate As Label
    Friend WithEvents SpGetInvoiceHeadingBindingSource As BindingSource
    Friend WithEvents DsspGetInvoiceHeading As dsspGetInvoiceHeading
    Friend WithEvents SpGetInvoiceHeadingTableAdapter As dsspGetInvoiceHeadingTableAdapters.spGetInvoiceHeadingTableAdapter
End Class
