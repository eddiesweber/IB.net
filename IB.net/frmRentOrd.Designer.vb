<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRentOrd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRentOrd))
        Me.scrChange3 = New System.Windows.Forms.VScrollBar()
        Me.scrChange2 = New System.Windows.Forms.VScrollBar()
        Me.scrChange1 = New System.Windows.Forms.VScrollBar()
        Me.scrChange0 = New System.Windows.Forms.VScrollBar()
        Me.scrQty13 = New System.Windows.Forms.VScrollBar()
        Me.scrQty12 = New System.Windows.Forms.VScrollBar()
        Me.scrQty11 = New System.Windows.Forms.VScrollBar()
        Me.scrQty10 = New System.Windows.Forms.VScrollBar()
        Me.fraSales = New System.Windows.Forms.GroupBox()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.SpGetSalesmenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetSalesmen = New IB.net.dsspGetSalesmen()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.CustomerInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomerInventory = New IB.net.dsCustomerInventory()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.optSales0 = New System.Windows.Forms.RadioButton()
        Me.optSales1 = New System.Windows.Forms.RadioButton()
        Me.optSales2 = New System.Windows.Forms.RadioButton()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel14 = New System.Windows.Forms.Label()
        Me.lblLabel13 = New System.Windows.Forms.Label()
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblCurItem = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindItem = New C1.Win.C1Input.C1Button()
        Me.SpGetCustDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustDept = New IB.net.dsspGetCustDept()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.txtItemDesc = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.txtData20 = New C1.Win.C1Input.C1TextBox()
        Me.chkLoan = New C1.Win.C1Input.C1CheckBox()
        Me.txtData14 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtMemo = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent3 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent2 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent1 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent0 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange0 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange1 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange2 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.txtData12 = New C1.Win.C1Input.C1TextBox()
        Me.txtData13 = New C1.Win.C1Input.C1TextBox()
        Me.txtData19 = New C1.Win.C1Input.C1TextBox()
        Me.txtTotal = New C1.Win.C1Input.C1TextBox()
        Me.chkData0 = New C1.Win.C1Input.C1CheckBox()
        Me.C1RadialMenu1 = New C1.Win.C1Command.C1RadialMenu()
        Me.SpGetSalesmenTableAdapter = New IB.net.dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter()
        Me.SpGetCustDeptTableAdapter = New IB.net.dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter()
        Me.CustomerInventoryTableAdapter = New IB.net.dsCustomerInventoryTableAdapters.CustomerInventoryTableAdapter()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.fraSales.SuspendLayout()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLoan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkData0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'scrChange3
        '
        Me.scrChange3.Location = New System.Drawing.Point(192, 210)
        Me.scrChange3.Minimum = -32000
        Me.scrChange3.Name = "scrChange3"
        Me.scrChange3.Size = New System.Drawing.Size(15, 19)
        Me.scrChange3.TabIndex = 64
        '
        'scrChange2
        '
        Me.scrChange2.Location = New System.Drawing.Point(192, 190)
        Me.scrChange2.Minimum = -32000
        Me.scrChange2.Name = "scrChange2"
        Me.scrChange2.Size = New System.Drawing.Size(15, 19)
        Me.scrChange2.TabIndex = 63
        '
        'scrChange1
        '
        Me.scrChange1.Location = New System.Drawing.Point(192, 170)
        Me.scrChange1.Minimum = -32000
        Me.scrChange1.Name = "scrChange1"
        Me.scrChange1.Size = New System.Drawing.Size(15, 19)
        Me.scrChange1.TabIndex = 62
        '
        'scrChange0
        '
        Me.scrChange0.Location = New System.Drawing.Point(192, 150)
        Me.scrChange0.Minimum = -32000
        Me.scrChange0.Name = "scrChange0"
        Me.scrChange0.Size = New System.Drawing.Size(15, 19)
        Me.scrChange0.TabIndex = 61
        '
        'scrQty13
        '
        Me.scrQty13.Location = New System.Drawing.Point(270, 210)
        Me.scrQty13.Minimum = -32000
        Me.scrQty13.Name = "scrQty13"
        Me.scrQty13.Size = New System.Drawing.Size(15, 19)
        Me.scrQty13.TabIndex = 60
        '
        'scrQty12
        '
        Me.scrQty12.Location = New System.Drawing.Point(270, 190)
        Me.scrQty12.Minimum = -32000
        Me.scrQty12.Name = "scrQty12"
        Me.scrQty12.Size = New System.Drawing.Size(15, 19)
        Me.scrQty12.TabIndex = 59
        '
        'scrQty11
        '
        Me.scrQty11.Location = New System.Drawing.Point(270, 170)
        Me.scrQty11.Minimum = -32000
        Me.scrQty11.Name = "scrQty11"
        Me.scrQty11.Size = New System.Drawing.Size(15, 19)
        Me.scrQty11.TabIndex = 58
        '
        'scrQty10
        '
        Me.scrQty10.Location = New System.Drawing.Point(270, 150)
        Me.scrQty10.Minimum = -32000
        Me.scrQty10.Name = "scrQty10"
        Me.scrQty10.Size = New System.Drawing.Size(15, 19)
        Me.scrQty10.TabIndex = 57
        '
        'fraSales
        '
        Me.fraSales.Controls.Add(Me.lstSales)
        Me.fraSales.Controls.Add(Me.txtData8)
        Me.fraSales.Controls.Add(Me.txtData9)
        Me.fraSales.Controls.Add(Me.txtData7)
        Me.fraSales.Controls.Add(Me.txtData5)
        Me.fraSales.Controls.Add(Me.txtData6)
        Me.fraSales.Controls.Add(Me.txtData4)
        Me.fraSales.Controls.Add(Me.Label1)
        Me.fraSales.Controls.Add(Me.label2)
        Me.fraSales.Controls.Add(Me.optSales0)
        Me.fraSales.Controls.Add(Me.optSales1)
        Me.fraSales.Controls.Add(Me.optSales2)
        Me.fraSales.Location = New System.Drawing.Point(9, 280)
        Me.fraSales.Name = "fraSales"
        Me.fraSales.Size = New System.Drawing.Size(358, 85)
        Me.fraSales.TabIndex = 33
        Me.fraSales.TabStop = False
        Me.fraSales.Text = "&Salesperson(s)"
        '
        'lstSales
        '
        Me.lstSales.DataSource = Me.SpGetSalesmenBindingSource
        Me.lstSales.DisplayMember = "Sales"
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(10, 20)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(190, 56)
        Me.lstSales.TabIndex = 116
        '
        'SpGetSalesmenBindingSource
        '
        Me.SpGetSalesmenBindingSource.DataMember = "spGetSalesmen"
        Me.SpGetSalesmenBindingSource.DataSource = Me.DsspGetSalesmen
        '
        'DsspGetSalesmen
        '
        Me.DsspGetSalesmen.DataSetName = "dsspGetSalesmen"
        Me.DsspGetSalesmen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_2PCT", True))
        Me.txtData8.DataType = GetType(Single)
        Me.txtData8.Location = New System.Drawing.Point(295, 41)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(50, 18)
        Me.txtData8.TabIndex = 115
        Me.txtData8.Tag = Nothing
        Me.txtData8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CustomerInventoryBindingSource
        '
        Me.CustomerInventoryBindingSource.DataMember = "CustomerInventory"
        Me.CustomerInventoryBindingSource.DataSource = Me.DsCustomerInventory
        '
        'DsCustomerInventory
        '
        Me.DsCustomerInventory.DataSetName = "dsCustomerInventory"
        Me.DsCustomerInventory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData9
        '
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_3PCT", True))
        Me.txtData9.DataType = GetType(Single)
        Me.txtData9.Location = New System.Drawing.Point(295, 61)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(50, 18)
        Me.txtData9.TabIndex = 114
        Me.txtData9.Tag = Nothing
        Me.txtData9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_1PCT", True))
        Me.txtData7.DataType = GetType(Single)
        Me.txtData7.Location = New System.Drawing.Point(295, 21)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(50, 18)
        Me.txtData7.TabIndex = 113
        Me.txtData7.Tag = Nothing
        Me.txtData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_2", True))
        Me.txtData5.Location = New System.Drawing.Point(230, 41)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(50, 18)
        Me.txtData5.TabIndex = 112
        Me.txtData5.Tag = Nothing
        Me.txtData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_3", True))
        Me.txtData6.Location = New System.Drawing.Point(230, 61)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(50, 18)
        Me.txtData6.TabIndex = 111
        Me.txtData6.Tag = Nothing
        Me.txtData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "SALES_1", True))
        Me.txtData4.Location = New System.Drawing.Point(230, 22)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(50, 18)
        Me.txtData4.TabIndex = 110
        Me.txtData4.Tag = Nothing
        Me.txtData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Code:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(294, 7)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(47, 13)
        Me.label2.TabIndex = 49
        Me.label2.Text = "Percent:"
        '
        'optSales0
        '
        Me.optSales0.AutoSize = True
        Me.optSales0.Location = New System.Drawing.Point(210, 24)
        Me.optSales0.Name = "optSales0"
        Me.optSales0.Size = New System.Drawing.Size(14, 13)
        Me.optSales0.TabIndex = 72
        Me.optSales0.TabStop = True
        Me.optSales0.UseVisualStyleBackColor = True
        '
        'optSales1
        '
        Me.optSales1.AutoSize = True
        Me.optSales1.Location = New System.Drawing.Point(210, 44)
        Me.optSales1.Name = "optSales1"
        Me.optSales1.Size = New System.Drawing.Size(14, 13)
        Me.optSales1.TabIndex = 73
        Me.optSales1.TabStop = True
        Me.optSales1.UseVisualStyleBackColor = True
        '
        'optSales2
        '
        Me.optSales2.AutoSize = True
        Me.optSales2.Location = New System.Drawing.Point(210, 64)
        Me.optSales2.Name = "optSales2"
        Me.optSales2.Size = New System.Drawing.Size(14, 13)
        Me.optSales2.TabIndex = 74
        Me.optSales2.TabStop = True
        Me.optSales2.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(276, 16)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "De&pt:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(14, 373)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(79, 13)
        Me.lblLabel5.TabIndex = 40
        Me.lblLabel5.Text = "Change &Memo:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblLabel14
        '
        Me.lblLabel14.AutoSize = True
        Me.lblLabel14.Location = New System.Drawing.Point(139, 101)
        Me.lblLabel14.Name = "lblLabel14"
        Me.lblLabel14.Size = New System.Drawing.Size(34, 13)
        Me.lblLabel14.TabIndex = 8
        Me.lblLabel14.Text = "L&oan:"
        '
        'lblLabel13
        '
        Me.lblLabel13.AutoSize = True
        Me.lblLabel13.Location = New System.Drawing.Point(12, 215)
        Me.lblLabel13.Name = "lblLabel13"
        Me.lblLabel13.Size = New System.Drawing.Size(67, 13)
        Me.lblLabel13.TabIndex = 25
        Me.lblLabel13.Text = "Deliver&y Qty:"
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(12, 195)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(67, 13)
        Me.lblLabel12.TabIndex = 21
        Me.lblLabel12.Text = "Minimum &Bill:"
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.Location = New System.Drawing.Point(12, 175)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel11.TabIndex = 17
        Me.lblLabel11.Text = "In&ventory:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(12, 155)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel10.TabIndex = 13
        Me.lblLabel10.Text = "&Loaned Qty:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(220, 139)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(51, 13)
        Me.lblLabel9.TabIndex = 37
        Me.lblLabel9.Text = "New Qty:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(147, 139)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel4.TabIndex = 40
        Me.lblLabel4.Text = "Change:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(78, 139)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel3.TabIndex = 65
        Me.lblLabel3.Text = "Current:"
        '
        'lblCurItem
        '
        Me.lblCurItem.AutoSize = True
        Me.lblCurItem.Location = New System.Drawing.Point(411, 210)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(53, 13)
        Me.lblCurItem.TabIndex = 56
        Me.lblCurItem.Text = "lblCurItem"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(160, 235)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel6.TabIndex = 29
        Me.lblLabel6.Text = "Unit &Price:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(12, 253)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel7.TabIndex = 31
        Me.lblLabel7.Text = "&Taxable:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(216, 101)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel8.TabIndex = 11
        Me.lblLabel8.Text = "&Identity:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(10, 79)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "&Item:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(411, 190)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(54, 13)
        Me.lblCurCust.TabIndex = 53
        Me.lblCurCust.Text = "lblCurCust"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(395, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 75
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(395, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 74
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(395, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 73
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(395, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 72
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(395, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 71
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "CUST_NUM", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Enabled = False
        Me.txtData0.Location = New System.Drawing.Point(70, 14)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(80, 18)
        Me.txtData0.TabIndex = 76
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(395, 241)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindItem.TabIndex = 77
        Me.cmdFindItem.Text = "&Find"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        Me.cmdFindItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetCustDeptBindingSource
        '
        Me.SpGetCustDeptBindingSource.DataMember = "SpGetCustDept"
        Me.SpGetCustDeptBindingSource.DataSource = Me.DsspGetCustDept
        '
        'DsspGetCustDept
        '
        Me.DsspGetCustDept.DataSetName = "dsspGetCustDept"
        Me.DsspGetCustDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "DEPT", True))
        Me.txtData1.DataType = GetType(Short)
        Me.txtData1.Location = New System.Drawing.Point(414, 299)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(61, 18)
        Me.txtData1.TabIndex = 79
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1})
        Me.C1ContextMenu1.Name = "C1ContextMenu1"
        Me.C1ContextMenu1.ShortcutText = ""
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Text = "New Command"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1ContextMenu1)
        Me.C1CommandHolder1.Owner = Me
        '
        'txtCustName
        '
        Me.txtCustName.AutoSize = False
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Location = New System.Drawing.Point(70, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustName.Size = New System.Drawing.Size(230, 15)
        Me.txtCustName.TabIndex = 80
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustDept
        '
        Me.txtCustDept.AutoSize = False
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.Location = New System.Drawing.Point(70, 55)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustDept.Size = New System.Drawing.Size(230, 15)
        Me.txtCustDept.TabIndex = 81
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtItemDesc
        '
        Me.txtItemDesc.AutoSize = False
        Me.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtItemDesc.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.Location = New System.Drawing.Point(130, 80)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Padding = New System.Windows.Forms.Padding(1)
        Me.txtItemDesc.Size = New System.Drawing.Size(230, 15)
        Me.txtItemDesc.TabIndex = 82
        Me.txtItemDesc.Tag = Nothing
        Me.txtItemDesc.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtItemDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "ITEM_NUM", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtData2.DataType = GetType(Integer)
        Me.txtData2.Location = New System.Drawing.Point(414, 323)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(60, 18)
        Me.txtData2.TabIndex = 84
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(10, 16)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 85
        Me.lblLabel0.Text = "&Customer:"
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(159, 10)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 86
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData20
        '
        Me.txtData20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData20.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "NAME_SIZE", True))
        Me.txtData20.Location = New System.Drawing.Point(260, 99)
        Me.txtData20.Name = "txtData20"
        Me.txtData20.Size = New System.Drawing.Size(100, 18)
        Me.txtData20.TabIndex = 87
        Me.txtData20.Tag = Nothing
        Me.txtData20.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData20.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkLoan
        '
        Me.chkLoan.BackColor = System.Drawing.Color.Transparent
        Me.chkLoan.BorderColor = System.Drawing.Color.Transparent
        Me.chkLoan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkLoan.ForeColor = System.Drawing.Color.Black
        Me.chkLoan.Location = New System.Drawing.Point(175, 97)
        Me.chkLoan.Name = "chkLoan"
        Me.chkLoan.Padding = New System.Windows.Forms.Padding(1)
        Me.chkLoan.Size = New System.Drawing.Size(22, 25)
        Me.chkLoan.TabIndex = 88
        Me.chkLoan.UseVisualStyleBackColor = True
        Me.chkLoan.Value = Nothing
        Me.chkLoan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkLoan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData14
        '
        Me.txtData14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData14.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "LINE_TYPE", True))
        Me.txtData14.DataType = GetType(Short)
        Me.txtData14.Location = New System.Drawing.Point(414, 371)
        Me.txtData14.Name = "txtData14"
        Me.txtData14.Size = New System.Drawing.Size(60, 18)
        Me.txtData14.TabIndex = 89
        Me.txtData14.Tag = Nothing
        Me.txtData14.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "ITEM_TYPE", True))
        Me.txtData3.Location = New System.Drawing.Point(414, 347)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(60, 18)
        Me.txtData3.TabIndex = 90
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtMemo
        '
        Me.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemo.Location = New System.Drawing.Point(93, 371)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(260, 18)
        Me.txtMemo.TabIndex = 91
        Me.txtMemo.Tag = Nothing
        Me.txtMemo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMemo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent3
        '
        Me.txtCurrent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent3.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent3.Location = New System.Drawing.Point(77, 213)
        Me.txtCurrent3.Name = "txtCurrent3"
        Me.txtCurrent3.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent3.TabIndex = 92
        Me.txtCurrent3.Tag = Nothing
        Me.txtCurrent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent2
        '
        Me.txtCurrent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent2.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent2.Location = New System.Drawing.Point(77, 193)
        Me.txtCurrent2.Name = "txtCurrent2"
        Me.txtCurrent2.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent2.TabIndex = 93
        Me.txtCurrent2.Tag = Nothing
        Me.txtCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent1
        '
        Me.txtCurrent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent1.Location = New System.Drawing.Point(77, 173)
        Me.txtCurrent1.Name = "txtCurrent1"
        Me.txtCurrent1.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent1.TabIndex = 94
        Me.txtCurrent1.Tag = Nothing
        Me.txtCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent0
        '
        Me.txtCurrent0.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent0.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent0.Location = New System.Drawing.Point(77, 153)
        Me.txtCurrent0.Name = "txtCurrent0"
        Me.txtCurrent0.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent0.TabIndex = 95
        Me.txtCurrent0.Tag = Nothing
        Me.txtCurrent0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange0
        '
        Me.txtChange0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange0.Location = New System.Drawing.Point(144, 153)
        Me.txtChange0.Name = "txtChange0"
        Me.txtChange0.Size = New System.Drawing.Size(50, 18)
        Me.txtChange0.TabIndex = 96
        Me.txtChange0.Tag = Nothing
        Me.txtChange0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange1
        '
        Me.txtChange1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange1.Location = New System.Drawing.Point(144, 173)
        Me.txtChange1.Name = "txtChange1"
        Me.txtChange1.Size = New System.Drawing.Size(50, 18)
        Me.txtChange1.TabIndex = 99
        Me.txtChange1.Tag = Nothing
        Me.txtChange1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange2
        '
        Me.txtChange2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange2.Location = New System.Drawing.Point(144, 193)
        Me.txtChange2.Name = "txtChange2"
        Me.txtChange2.Size = New System.Drawing.Size(50, 18)
        Me.txtChange2.TabIndex = 98
        Me.txtChange2.Tag = Nothing
        Me.txtChange2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange3
        '
        Me.txtChange3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange3.Location = New System.Drawing.Point(144, 213)
        Me.txtChange3.Name = "txtChange3"
        Me.txtChange3.Size = New System.Drawing.Size(50, 18)
        Me.txtChange3.TabIndex = 97
        Me.txtChange3.Tag = Nothing
        Me.txtChange3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "LOAN_QTY", True))
        Me.txtData10.DataType = GetType(Single)
        Me.txtData10.Location = New System.Drawing.Point(221, 153)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(50, 18)
        Me.txtData10.TabIndex = 103
        Me.txtData10.Tag = Nothing
        Me.txtData10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "INV_QTY", True))
        Me.txtData11.DataType = GetType(Single)
        Me.txtData11.Location = New System.Drawing.Point(221, 173)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(50, 18)
        Me.txtData11.TabIndex = 102
        Me.txtData11.Tag = Nothing
        Me.txtData11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData11.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData12
        '
        Me.txtData12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "MIN_QTY", True))
        Me.txtData12.DataType = GetType(Single)
        Me.txtData12.Location = New System.Drawing.Point(221, 193)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Size = New System.Drawing.Size(50, 18)
        Me.txtData12.TabIndex = 101
        Me.txtData12.Tag = Nothing
        Me.txtData12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData12.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData12.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData13
        '
        Me.txtData13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData13.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "DEL_QTY", True))
        Me.txtData13.DataType = GetType(Single)
        Me.txtData13.Location = New System.Drawing.Point(221, 213)
        Me.txtData13.Name = "txtData13"
        Me.txtData13.Size = New System.Drawing.Size(50, 18)
        Me.txtData13.TabIndex = 100
        Me.txtData13.Tag = Nothing
        Me.txtData13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData13.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData13.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData19
        '
        Me.txtData19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData19.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "UNIT_PRICE", True))
        Me.txtData19.DataType = GetType(Single)
        Me.txtData19.Location = New System.Drawing.Point(221, 233)
        Me.txtData19.Name = "txtData19"
        Me.txtData19.Size = New System.Drawing.Size(50, 18)
        Me.txtData19.TabIndex = 104
        Me.txtData19.Tag = Nothing
        Me.txtData19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData19.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData19.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtTotal.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(207, 258)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(65, 18)
        Me.txtTotal.TabIndex = 105
        Me.txtTotal.Tag = Nothing
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkData0
        '
        Me.chkData0.BackColor = System.Drawing.Color.Transparent
        Me.chkData0.BorderColor = System.Drawing.Color.Transparent
        Me.chkData0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerInventoryBindingSource, "TAXABLE", True))
        Me.chkData0.ForeColor = System.Drawing.Color.Black
        Me.chkData0.Location = New System.Drawing.Point(77, 248)
        Me.chkData0.Name = "chkData0"
        Me.chkData0.Padding = New System.Windows.Forms.Padding(1)
        Me.chkData0.Size = New System.Drawing.Size(22, 24)
        Me.chkData0.TabIndex = 106
        Me.chkData0.UseVisualStyleBackColor = True
        Me.chkData0.Value = Nothing
        Me.chkData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetSalesmenTableAdapter
        '
        Me.SpGetSalesmenTableAdapter.ClearBeforeFill = True
        '
        'SpGetCustDeptTableAdapter
        '
        Me.SpGetCustDeptTableAdapter.ClearBeforeFill = True
        '
        'CustomerInventoryTableAdapter
        '
        Me.CustomerInventoryTableAdapter.ClearBeforeFill = True
        '
        'lstDept
        '
        Me.lstDept.DataSource = Me.SpGetCustDeptBindingSource
        Me.lstDept.DisplayMember = "DEPT"
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(313, 10)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(47, 56)
        Me.lstDept.TabIndex = 117
        '
        'lstItem
        '
        Me.lstItem.DataSource = Me.CustomerInventoryBindingSource
        Me.lstItem.DisplayMember = "ITEM_NUM"
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(46, 80)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(76, 56)
        Me.lstItem.TabIndex = 118
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(492, 397)
        Me.ShapeContainer1.TabIndex = 119
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 380
        Me.Line1.X2 = 380
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 385
        '
        'frmRentOrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 397)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.chkData0)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtData19)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData12)
        Me.Controls.Add(Me.txtData13)
        Me.Controls.Add(Me.txtChange1)
        Me.Controls.Add(Me.txtChange2)
        Me.Controls.Add(Me.txtChange3)
        Me.Controls.Add(Me.txtChange0)
        Me.Controls.Add(Me.txtCurrent0)
        Me.Controls.Add(Me.txtCurrent1)
        Me.Controls.Add(Me.txtCurrent2)
        Me.Controls.Add(Me.txtCurrent3)
        Me.Controls.Add(Me.txtMemo)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData14)
        Me.Controls.Add(Me.chkLoan)
        Me.Controls.Add(Me.txtData20)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel8)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblCurItem)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.lblLabel10)
        Me.Controls.Add(Me.lblLabel11)
        Me.Controls.Add(Me.lblLabel12)
        Me.Controls.Add(Me.lblLabel13)
        Me.Controls.Add(Me.lblLabel14)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.fraSales)
        Me.Controls.Add(Me.scrQty10)
        Me.Controls.Add(Me.scrQty11)
        Me.Controls.Add(Me.scrQty12)
        Me.Controls.Add(Me.scrQty13)
        Me.Controls.Add(Me.scrChange0)
        Me.Controls.Add(Me.scrChange1)
        Me.Controls.Add(Me.scrChange2)
        Me.Controls.Add(Me.scrChange3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(65, 153)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRentOrd"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Customer Dialog"
        Me.fraSales.ResumeLayout(False)
        Me.fraSales.PerformLayout()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLoan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkData0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scrChange3 As VScrollBar
    Friend WithEvents scrChange2 As VScrollBar
    Friend WithEvents scrChange1 As VScrollBar
    Friend WithEvents scrChange0 As VScrollBar
    Friend WithEvents scrQty13 As VScrollBar
    Friend WithEvents scrQty12 As VScrollBar
    Friend WithEvents scrQty11 As VScrollBar
    Friend WithEvents scrQty10 As VScrollBar
    Friend WithEvents fraSales As GroupBox
    Friend WithEvents optSales2 As RadioButton
    Friend WithEvents optSales1 As RadioButton
    Friend WithEvents optSales0 As RadioButton
    Friend WithEvents label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel14 As Label
    Friend WithEvents lblLabel13 As Label
    Friend WithEvents lblLabel12 As Label
    Friend WithEvents lblLabel11 As Label
    Friend WithEvents lblLabel10 As Label
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblCurItem As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindItem As C1.Win.C1Input.C1Button
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtItemDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkLoan As C1.Win.C1Input.C1CheckBox
    Friend WithEvents txtData20 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData14 As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkData0 As C1.Win.C1Input.C1CheckBox
    Friend WithEvents txtTotal As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData19 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData12 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData13 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMemo As C1.Win.C1Input.C1TextBox
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1RadialMenu1 As C1.Win.C1Command.C1RadialMenu
    Friend WithEvents SpGetSalesmenTableAdapter As dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter
    Friend WithEvents SpGetCustDeptTableAdapter As dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter
    Friend WithEvents CustomerInventoryTableAdapter As dsCustomerInventoryTableAdapters.CustomerInventoryTableAdapter
    Private WithEvents DsspGetSalesmen As dsspGetSalesmen
    Private WithEvents SpGetSalesmenBindingSource As BindingSource
    Private WithEvents SpGetCustDeptBindingSource As BindingSource
    Private WithEvents DsspGetCustDept As dsspGetCustDept
    Private WithEvents DsCustomerInventory As dsCustomerInventory
    Private WithEvents CustomerInventoryBindingSource As BindingSource
    Friend WithEvents lstDept As ListBox
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lstSales As ListBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Line1 As PowerPacks.LineShape
End Class
