<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvHead
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chkCC = New System.Windows.Forms.CheckBox()
        Me.chkData0 = New System.Windows.Forms.CheckBox()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblCurInvoice = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.cmbTax = New System.Windows.Forms.ComboBox()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.SpGetCustDeptsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustDepts = New IB.net.dsspGetCustDepts()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.InvoiceHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInvoiceHeader = New IB.net.dsInvoiceHeader()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.cmdFindInv = New C1.Win.C1Input.C1Button()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.cmdCalc = New C1.Win.C1Input.C1Button()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.cmdItem = New C1.Win.C1Input.C1Button()
        Me.cmdLoad = New C1.Win.C1Input.C1Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtData15 = New C1.Win.C1Input.C1TextBox()
        Me.txtData14 = New C1.Win.C1Input.C1TextBox()
        Me.txtData13 = New C1.Win.C1Input.C1TextBox()
        Me.lblData12 = New System.Windows.Forms.Label()
        Me.lblData11 = New System.Windows.Forms.Label()
        Me.lblData10 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.datData0 = New C1.Win.Calendar.C1DateEdit()
        Me.InvoiceHeaderTableAdapter = New IB.net.dsInvoiceHeaderTableAdapters.InvoiceHeaderTableAdapter()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SpGetCustDeptsTableAdapter = New IB.net.dsspGetCustDeptsTableAdapters.spGetCustDeptsTableAdapter()
        Me.DS_CustomerMaster = New IB.net.DS_CustomerMaster()
        Me.CustomerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerMasterTableAdapter = New IB.net.DS_CustomerMasterTableAdapters.CustomerMasterTableAdapter()
        Me.DsspGetTaxCodes = New IB.net.dsspGetTaxCodes()
        Me.SpGetTaxCodesTableAdapter = New IB.net.dsspGetTaxCodesTableAdapters.spGetTaxCodesTableAdapter()
        CType(Me.SpGetCustDeptsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDepts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInvoiceHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtData15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CustomerMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetTaxCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkCC
        '
        Me.chkCC.AutoSize = True
        Me.chkCC.Location = New System.Drawing.Point(240, 141)
        Me.chkCC.Name = "chkCC"
        Me.chkCC.Size = New System.Drawing.Size(15, 14)
        Me.chkCC.TabIndex = 48
        Me.chkCC.UseVisualStyleBackColor = True
        '
        'chkData0
        '
        Me.chkData0.AutoSize = True
        Me.chkData0.Location = New System.Drawing.Point(258, 206)
        Me.chkData0.Name = "chkData0"
        Me.chkData0.Size = New System.Drawing.Size(15, 14)
        Me.chkData0.TabIndex = 17
        Me.chkData0.UseVisualStyleBackColor = True
        Me.chkData0.Visible = False
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(154, 141)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(62, 13)
        Me.lblLabel10.TabIndex = 16
        Me.lblLabel10.Text = "Cr&edit Card:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(70, 267)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 43
        '
        'lblCurInvoice
        '
        Me.lblCurInvoice.AutoSize = True
        Me.lblCurInvoice.Location = New System.Drawing.Point(417, 225)
        Me.lblCurInvoice.Name = "lblCurInvoice"
        Me.lblCurInvoice.Size = New System.Drawing.Size(68, 13)
        Me.lblCurInvoice.TabIndex = 34
        Me.lblCurInvoice.Text = "lblCurInvoice"
        Me.lblCurInvoice.Visible = False
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(10, 18)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel5.TabIndex = 0
        Me.lblLabel5.Text = "&Invoice:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(245, 16)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel4.TabIndex = 3
        Me.lblLabel4.Text = "&Date:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(154, 112)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(32, 13)
        Me.lblLabel1.TabIndex = 12
        Me.lblLabel1.Text = "Sto&p:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(10, 236)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(52, 13)
        Me.lblLabel9.TabIndex = 22
        Me.lblLabel9.Text = "Trac&king:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(424, 212)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(54, 13)
        Me.lblCurCust.TabIndex = 31
        Me.lblCurCust.Text = "lblCurCust"
        Me.lblCurCust.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.Location = New System.Drawing.Point(10, 261)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel11.TabIndex = 11
        Me.lblLabel11.Text = "&Memo:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(245, 47)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel8.TabIndex = 8
        Me.lblLabel8.Text = "&Dept:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(10, 174)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel7.TabIndex = 18
        Me.lblLabel7.Text = "&Tax Code:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(10, 206)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(67, 13)
        Me.lblLabel6.TabIndex = 20
        Me.lblLabel6.Text = "Tax Am&ount:"
        '
        'cmbTax
        '
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Location = New System.Drawing.Point(75, 170)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(57, 21)
        Me.cmbTax.TabIndex = 46
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(10, 141)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel3.TabIndex = 14
        Me.lblLabel3.Text = "&State:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(10, 111)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 10
        Me.lblLabel2.Text = "&Route:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(10, 47)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 5
        Me.lblLabel0.Text = "&Customer:"
        '
        'lstDept
        '
        Me.lstDept.DataSource = Me.SpGetCustDeptsBindingSource
        Me.lstDept.DisplayMember = "DEPT"
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(282, 47)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 69)
        Me.lstDept.TabIndex = 47
        Me.lstDept.ValueMember = "DEPT"
        '
        'SpGetCustDeptsBindingSource
        '
        Me.SpGetCustDeptsBindingSource.DataMember = "spGetCustDepts"
        Me.SpGetCustDeptsBindingSource.DataSource = Me.DsspGetCustDepts
        '
        'DsspGetCustDepts
        '
        Me.DsspGetCustDepts.DataSetName = "dsspGetCustDepts"
        Me.DsspGetCustDepts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Location = New System.Drawing.Point(75, 72)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustName.Size = New System.Drawing.Size(200, 15)
        Me.txtCustName.TabIndex = 92
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "PAY_TYPE", True))
        Me.txtData10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData10.Location = New System.Drawing.Point(418, 170)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(65, 18)
        Me.txtData10.TabIndex = 93
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'InvoiceHeaderBindingSource
        '
        Me.InvoiceHeaderBindingSource.DataMember = "InvoiceHeader"
        Me.InvoiceHeaderBindingSource.DataSource = Me.DsInvoiceHeader
        '
        'DsInvoiceHeader
        '
        Me.DsInvoiceHeader.DataSetName = "dsInvoiceHeader"
        Me.DsInvoiceHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "ROUTE", True))
        Me.txtData3.DataType = GetType(Short)
        Me.txtData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData3.Location = New System.Drawing.Point(75, 110)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(65, 18)
        Me.txtData3.TabIndex = 94
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "CUST_NUM", True))
        Me.txtData1.DataType = GetType(Integer)
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(75, 45)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(65, 18)
        Me.txtData1.TabIndex = 95
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "INV_NUMBER", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(75, 15)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(65, 18)
        Me.txtData0.TabIndex = 96
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "TAX_MON", True))
        Me.txtData7.DataType = GetType(Decimal)
        Me.txtData7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData7.Location = New System.Drawing.Point(75, 204)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(65, 18)
        Me.txtData7.TabIndex = 97
        Me.txtData7.Tag = Nothing
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "SEQUENCE", True))
        Me.txtData4.DataType = GetType(Single)
        Me.txtData4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData4.Location = New System.Drawing.Point(190, 110)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(65, 18)
        Me.txtData4.TabIndex = 98
        Me.txtData4.Tag = Nothing
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdExit.Location = New System.Drawing.Point(398, 132)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 103
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(398, 102)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 102
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(398, 72)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 101
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdDelete.Location = New System.Drawing.Point(398, 42)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 100
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdNew.Location = New System.Drawing.Point(398, 12)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 99
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(150, 40)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 104
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindInv
        '
        Me.cmdFindInv.Location = New System.Drawing.Point(150, 10)
        Me.cmdFindInv.Name = "cmdFindInv"
        Me.cmdFindInv.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindInv.TabIndex = 105
        Me.cmdFindInv.Text = "&Find"
        Me.cmdFindInv.UseVisualStyleBackColor = True
        Me.cmdFindInv.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindInv.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.Location = New System.Drawing.Point(75, 87)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustDept.Size = New System.Drawing.Size(200, 15)
        Me.txtCustDept.TabIndex = 106
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "TAX_ST", True))
        Me.txtData5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData5.Location = New System.Drawing.Point(75, 139)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(30, 18)
        Me.txtData5.TabIndex = 107
        Me.txtData5.Tag = Nothing
        Me.txtData5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "TAX_LOCODE", True))
        Me.txtData6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData6.Location = New System.Drawing.Point(170, 170)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(25, 18)
        Me.txtData6.TabIndex = 108
        Me.txtData6.Tag = Nothing
        Me.txtData6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "DEPT", True))
        Me.txtData2.DataType = GetType(Short)
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Location = New System.Drawing.Point(418, 189)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(65, 18)
        Me.txtData2.TabIndex = 109
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(150, 200)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(85, 25)
        Me.cmdCalc.TabIndex = 110
        Me.cmdCalc.Text = "C&alculate"
        Me.cmdCalc.UseVisualStyleBackColor = True
        Me.cmdCalc.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCalc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData9
        '
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "CHANGE_MEMO", True))
        Me.txtData9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData9.Location = New System.Drawing.Point(75, 260)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(300, 18)
        Me.txtData9.TabIndex = 111
        Me.txtData9.Tag = Nothing
        Me.txtData9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "TRACK", True))
        Me.txtData8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData8.Location = New System.Drawing.Point(75, 235)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(300, 18)
        Me.txtData8.TabIndex = 112
        Me.txtData8.Tag = Nothing
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdItem
        '
        Me.cmdItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdItem.Location = New System.Drawing.Point(230, 375)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(145, 25)
        Me.cmdItem.TabIndex = 113
        Me.cmdItem.Text = "Add/&Edit Items"
        Me.cmdItem.UseVisualStyleBackColor = True
        Me.cmdItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdLoad.Location = New System.Drawing.Point(75, 375)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(145, 25)
        Me.cmdLoad.TabIndex = 114
        Me.cmdLoad.Text = "&Load Standing Items"
        Me.cmdLoad.UseVisualStyleBackColor = True
        Me.cmdLoad.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdLoad.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtData15)
        Me.GroupBox1.Controls.Add(Me.txtData14)
        Me.GroupBox1.Controls.Add(Me.txtData13)
        Me.GroupBox1.Controls.Add(Me.lblData12)
        Me.GroupBox1.Controls.Add(Me.lblData11)
        Me.GroupBox1.Controls.Add(Me.lblData10)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(240, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 80)
        Me.GroupBox1.TabIndex = 115
        Me.GroupBox1.TabStop = False
        '
        'txtData15
        '
        Me.txtData15.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData15.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData15.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "INV_TOTAL", True))
        Me.txtData15.DataType = GetType(Decimal)
        Me.txtData15.Location = New System.Drawing.Point(60, 55)
        Me.txtData15.Name = "txtData15"
        Me.txtData15.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData15.Size = New System.Drawing.Size(65, 15)
        Me.txtData15.TabIndex = 120
        Me.txtData15.Tag = Nothing
        Me.txtData15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData15.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData14
        '
        Me.txtData14.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData14.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData14.Location = New System.Drawing.Point(60, 30)
        Me.txtData14.Name = "txtData14"
        Me.txtData14.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData14.Size = New System.Drawing.Size(65, 15)
        Me.txtData14.TabIndex = 119
        Me.txtData14.Tag = Nothing
        Me.txtData14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData13
        '
        Me.txtData13.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData13.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData13.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "SUBTOTAL", True))
        Me.txtData13.DataType = GetType(Decimal)
        Me.txtData13.Location = New System.Drawing.Point(60, 15)
        Me.txtData13.Name = "txtData13"
        Me.txtData13.Padding = New System.Windows.Forms.Padding(1)
        Me.txtData13.Size = New System.Drawing.Size(65, 15)
        Me.txtData13.TabIndex = 117
        Me.txtData13.Tag = Nothing
        Me.txtData13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData13.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblData12
        '
        Me.lblData12.AutoSize = True
        Me.lblData12.Location = New System.Drawing.Point(10, 16)
        Me.lblData12.Name = "lblData12"
        Me.lblData12.Size = New System.Drawing.Size(49, 13)
        Me.lblData12.TabIndex = 46
        Me.lblData12.Text = "Subtotal:"
        '
        'lblData11
        '
        Me.lblData11.AutoSize = True
        Me.lblData11.Location = New System.Drawing.Point(10, 31)
        Me.lblData11.Name = "lblData11"
        Me.lblData11.Size = New System.Drawing.Size(28, 13)
        Me.lblData11.TabIndex = 47
        Me.lblData11.Text = "Tax:"
        '
        'lblData10
        '
        Me.lblData10.AutoSize = True
        Me.lblData10.Location = New System.Drawing.Point(10, 56)
        Me.lblData10.Name = "lblData10"
        Me.lblData10.Size = New System.Drawing.Size(34, 13)
        Me.lblData10.TabIndex = 48
        Me.lblData10.Text = "Total:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(129, 61)
        Me.ShapeContainer1.TabIndex = 121
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 50
        Me.LineShape1.X2 = 130
        Me.LineShape1.Y1 = 34
        Me.LineShape1.Y2 = 34
        '
        'datData0
        '
        Me.datData0.AllowSpinLoop = False
        Me.datData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datData0.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datData0.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datData0.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceHeaderBindingSource, "DATE", True))
        Me.datData0.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datData0.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datData0.Location = New System.Drawing.Point(282, 14)
        Me.datData0.Name = "datData0"
        Me.datData0.Size = New System.Drawing.Size(93, 18)
        Me.datData0.TabIndex = 116
        Me.datData0.Tag = Nothing
        Me.datData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'InvoiceHeaderTableAdapter
        '
        Me.InvoiceHeaderTableAdapter.ClearBeforeFill = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(494, 411)
        Me.ShapeContainer2.TabIndex = 117
        Me.ShapeContainer2.TabStop = False
        '
        'Line1
        '
        Me.Line1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Line1.BorderColor = System.Drawing.Color.DarkBlue
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 385
        Me.Line1.X2 = 385
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 397
        '
        'SpGetCustDeptsTableAdapter
        '
        Me.SpGetCustDeptsTableAdapter.ClearBeforeFill = True
        '
        'DS_CustomerMaster
        '
        Me.DS_CustomerMaster.DataSetName = "DS_CustomerMaster"
        Me.DS_CustomerMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerMasterBindingSource
        '
        Me.CustomerMasterBindingSource.DataMember = "CustomerMaster"
        Me.CustomerMasterBindingSource.DataSource = Me.DS_CustomerMaster
        '
        'CustomerMasterTableAdapter
        '
        Me.CustomerMasterTableAdapter.ClearBeforeFill = True
        '
        'DsspGetTaxCodes
        '
        Me.DsspGetTaxCodes.DataSetName = "dsspGetTaxCodes"
        Me.DsspGetTaxCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetTaxCodesTableAdapter
        '
        Me.SpGetTaxCodesTableAdapter.ClearBeforeFill = True
        '
        'frmInvHead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 411)
        Me.Controls.Add(Me.datData0)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdItem)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.cmdCalc)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.cmdFindInv)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel8)
        Me.Controls.Add(Me.lblLabel11)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblCurInvoice)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblLabel10)
        Me.Controls.Add(Me.chkData0)
        Me.Controls.Add(Me.chkCC)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Location = New System.Drawing.Point(101, 122)
        Me.MinimizeBox = False
        Me.Name = "frmInvHead"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Invoice Header"
        CType(Me.SpGetCustDeptsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDepts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInvoiceHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtData15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CustomerMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetTaxCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkCC As CheckBox
    Friend WithEvents chkData0 As CheckBox
    Friend WithEvents lblLabel10 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCurInvoice As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents lblLabel11 As Label
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents cmbTax As ComboBox
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lstDept As ListBox
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFindInv As C1.Win.C1Input.C1Button
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdCalc As C1.Win.C1Input.C1Button
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdItem As C1.Win.C1Input.C1Button
    Friend WithEvents cmdLoad As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblData12 As Label
    Friend WithEvents lblData11 As Label
    Friend WithEvents lblData10 As Label
    Friend WithEvents txtData15 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData14 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData13 As C1.Win.C1Input.C1TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents datData0 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents InvoiceHeaderBindingSource As BindingSource
    Friend WithEvents DsInvoiceHeader As dsInvoiceHeader
    Friend WithEvents InvoiceHeaderTableAdapter As dsInvoiceHeaderTableAdapters.InvoiceHeaderTableAdapter
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents Line1 As PowerPacks.LineShape
    Friend WithEvents SpGetCustDeptsBindingSource As BindingSource
    Friend WithEvents DsspGetCustDepts As dsspGetCustDepts
    Friend WithEvents SpGetCustDeptsTableAdapter As dsspGetCustDeptsTableAdapters.spGetCustDeptsTableAdapter
    Friend WithEvents DS_CustomerMaster As DS_CustomerMaster
    Friend WithEvents CustomerMasterBindingSource As BindingSource
    Friend WithEvents CustomerMasterTableAdapter As DS_CustomerMasterTableAdapters.CustomerMasterTableAdapter
    Friend WithEvents DsspGetTaxCodes As dsspGetTaxCodes
    Friend WithEvents SpGetTaxCodesTableAdapter As dsspGetTaxCodesTableAdapters.spGetTaxCodesTableAdapter
End Class
