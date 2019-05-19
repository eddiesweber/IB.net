<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPONew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPONew))
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.cmdRecAll = New C1.Win.C1Input.C1Button()
        Me.cmdDelItem = New C1.Win.C1Input.C1Button()
        Me.cmdAddItem = New C1.Win.C1Input.C1Button()
        Me.txtVendName = New C1.Win.C1Input.C1TextBox()
        Me.VendMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVendMaster_Vendor = New IB.net.dsVendMaster_Vendor()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.POMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPOMaster = New IB.net.dsPOMaster()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtVendAcct = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindPO = New C1.Win.C1Input.C1Button()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtTotal0 = New C1.Win.C1Input.C1TextBox()
        Me.SpTotalPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspTotalPO = New IB.net.dsspTotalPO()
        Me.txtTotal2 = New C1.Win.C1Input.C1TextBox()
        Me.txtTotal1 = New C1.Win.C1Input.C1TextBox()
        Me.txtTotal3 = New C1.Win.C1Input.C1TextBox()
        Me.lblCurVend = New C1.Win.C1Input.C1TextBox()
        Me.lblCurPO = New C1.Win.C1Input.C1TextBox()
        Me.POMasterTableAdapter = New IB.net.dsPOMasterTableAdapters.POMasterTableAdapter()
        Me.grdPO = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.POItemTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPOItemTemp_ItemMasterO = New IB.net.dsPOItemTemp_ItemMasterO()
        Me.POItemTempTableAdapter = New IB.net.dsPOItemTemp_ItemMasterOTableAdapters.POItemTempTableAdapter()
        Me.SpTotalPOTableAdapter = New IB.net.dsspTotalPOTableAdapters.spTotalPOTableAdapter()
        Me.VendMasterTableAdapter = New IB.net.dsVendMaster_VendorTableAdapters.VendMasterTableAdapter()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.C1DateEdit1 = New C1.Win.Calendar.C1DateEdit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRecAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdAddItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVendMaster_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPOMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVendAcct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpTotalPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspTotalPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurVend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblCurPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POItemTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPOItemTemp_ItemMasterO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(482, 62)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel4.TabIndex = 32
        Me.lblLabel4.Text = "&Invoice:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(316, 62)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(51, 13)
        Me.lblLabel3.TabIndex = 8
        Me.lblLabel3.Text = "&Location:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(10, 62)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(74, 13)
        Me.lblLabel2.TabIndex = 6
        Me.lblLabel2.Text = "Delivery Da&te:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Back Order:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Received:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total Ordered:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(10, 37)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "&Vendor:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(10, 10)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&PO #:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(650, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 54
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(650, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 53
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(650, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 52
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(650, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 51
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(650, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 50
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(650, 345)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 25)
        Me.cmdPrint.TabIndex = 55
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRecAll
        '
        Me.cmdRecAll.Location = New System.Drawing.Point(650, 275)
        Me.cmdRecAll.Name = "cmdRecAll"
        Me.cmdRecAll.Size = New System.Drawing.Size(85, 25)
        Me.cmdRecAll.TabIndex = 56
        Me.cmdRecAll.Text = "&Receive All"
        Me.cmdRecAll.UseVisualStyleBackColor = True
        Me.cmdRecAll.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRecAll.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelItem
        '
        Me.cmdDelItem.Location = New System.Drawing.Point(650, 211)
        Me.cmdDelItem.Name = "cmdDelItem"
        Me.cmdDelItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelItem.TabIndex = 57
        Me.cmdDelItem.Text = "De&lete Item"
        Me.cmdDelItem.UseVisualStyleBackColor = True
        Me.cmdDelItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(650, 180)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdAddItem.TabIndex = 58
        Me.cmdAddItem.Text = "&Add Item"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        Me.cmdAddItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdAddItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtVendName
        '
        Me.txtVendName.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtVendName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVendName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "VEND_NAME", True))
        Me.txtVendName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendName.Location = New System.Drawing.Point(192, 38)
        Me.txtVendName.Name = "txtVendName"
        Me.txtVendName.Padding = New System.Windows.Forms.Padding(1)
        Me.txtVendName.Size = New System.Drawing.Size(230, 15)
        Me.txtVendName.TabIndex = 66
        Me.txtVendName.Tag = Nothing
        Me.txtVendName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'VendMasterBindingSource
        '
        Me.VendMasterBindingSource.DataMember = "VendMaster"
        Me.VendMasterBindingSource.DataSource = Me.DsVendMaster_Vendor
        '
        'DsVendMaster_Vendor
        '
        Me.DsVendMaster_Vendor.DataSetName = "dsVendMaster_Vendor"
        Me.DsVendMaster_Vendor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Seq", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(75, 10)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(100, 18)
        Me.txtData0.TabIndex = 65
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'POMasterBindingSource
        '
        Me.POMasterBindingSource.DataMember = "POMaster"
        Me.POMasterBindingSource.DataSource = Me.DsPOMaster
        '
        'DsPOMaster
        '
        Me.DsPOMaster.DataSetName = "dsPOMaster"
        Me.DsPOMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Vendor", True))
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(75, 35)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(100, 18)
        Me.txtData1.TabIndex = 67
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtVendAcct
        '
        Me.txtVendAcct.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtVendAcct.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVendAcct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVendAcct.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Acct", True))
        Me.txtVendAcct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendAcct.Location = New System.Drawing.Point(660, 407)
        Me.txtVendAcct.Name = "txtVendAcct"
        Me.txtVendAcct.Padding = New System.Windows.Forms.Padding(1)
        Me.txtVendAcct.Size = New System.Drawing.Size(65, 15)
        Me.txtVendAcct.TabIndex = 68
        Me.txtVendAcct.Tag = Nothing
        Me.txtVendAcct.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindPO
        '
        Me.cmdFindPO.Location = New System.Drawing.Point(192, 8)
        Me.cmdFindPO.Name = "cmdFindPO"
        Me.cmdFindPO.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindPO.TabIndex = 69
        Me.cmdFindPO.Text = "&Find"
        Me.cmdFindPO.UseVisualStyleBackColor = True
        Me.cmdFindPO.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindPO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Date", True))
        Me.txtData2.DataType = GetType(Date)
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtData2.Location = New System.Drawing.Point(530, 10)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(100, 18)
        Me.txtData2.TabIndex = 70
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Invoice", True))
        Me.txtData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData3.Location = New System.Drawing.Point(530, 60)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(100, 18)
        Me.txtData3.TabIndex = 71
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTotal0
        '
        Me.txtTotal0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpTotalPOBindingSource, "Ordered", True))
        Me.txtTotal0.DataType = GetType(Double)
        Me.txtTotal0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal0.Location = New System.Drawing.Point(194, 528)
        Me.txtTotal0.Name = "txtTotal0"
        Me.txtTotal0.Size = New System.Drawing.Size(45, 18)
        Me.txtTotal0.TabIndex = 72
        Me.txtTotal0.Tag = Nothing
        Me.txtTotal0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTotal0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpTotalPOBindingSource
        '
        Me.SpTotalPOBindingSource.DataMember = "spTotalPO"
        Me.SpTotalPOBindingSource.DataSource = Me.DsspTotalPO
        '
        'DsspTotalPO
        '
        Me.DsspTotalPO.DataSetName = "dsspTotalPO"
        Me.DsspTotalPO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTotal2
        '
        Me.txtTotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpTotalPOBindingSource, "Backordered", True))
        Me.txtTotal2.DataType = GetType(Double)
        Me.txtTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal2.Location = New System.Drawing.Point(416, 528)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Size = New System.Drawing.Size(45, 18)
        Me.txtTotal2.TabIndex = 73
        Me.txtTotal2.Tag = Nothing
        Me.txtTotal2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTotal2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTotal1
        '
        Me.txtTotal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpTotalPOBindingSource, "Received", True))
        Me.txtTotal1.DataType = GetType(Double)
        Me.txtTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal1.Location = New System.Drawing.Point(297, 528)
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.Size = New System.Drawing.Size(45, 18)
        Me.txtTotal1.TabIndex = 74
        Me.txtTotal1.Tag = Nothing
        Me.txtTotal1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTotal1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTotal3
        '
        Me.txtTotal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpTotalPOBindingSource, "Price", True))
        Me.txtTotal3.DataType = GetType(Double)
        Me.txtTotal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal3.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotal3.Location = New System.Drawing.Point(545, 528)
        Me.txtTotal3.Name = "txtTotal3"
        Me.txtTotal3.Size = New System.Drawing.Size(75, 18)
        Me.txtTotal3.TabIndex = 75
        Me.txtTotal3.Tag = Nothing
        Me.txtTotal3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTotal3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblCurVend
        '
        Me.lblCurVend.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblCurVend.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.lblCurVend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCurVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurVend.Location = New System.Drawing.Point(660, 428)
        Me.lblCurVend.Name = "lblCurVend"
        Me.lblCurVend.Padding = New System.Windows.Forms.Padding(1)
        Me.lblCurVend.Size = New System.Drawing.Size(65, 15)
        Me.lblCurVend.TabIndex = 76
        Me.lblCurVend.Tag = Nothing
        Me.lblCurVend.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblCurPO
        '
        Me.lblCurPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblCurPO.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.lblCurPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCurPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurPO.Location = New System.Drawing.Point(660, 449)
        Me.lblCurPO.Name = "lblCurPO"
        Me.lblCurPO.Padding = New System.Windows.Forms.Padding(1)
        Me.lblCurPO.Size = New System.Drawing.Size(65, 15)
        Me.lblCurPO.TabIndex = 77
        Me.lblCurPO.Tag = Nothing
        Me.lblCurPO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'POMasterTableAdapter
        '
        Me.POMasterTableAdapter.ClearBeforeFill = True
        '
        'grdPO
        '
        Me.grdPO.AllowUpdate = False
        Me.grdPO.DataSource = Me.POItemTempBindingSource
        Me.grdPO.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdPO.Images.Add(CType(resources.GetObject("grdPO.Images"), System.Drawing.Image))
        Me.grdPO.Location = New System.Drawing.Point(10, 90)
        Me.grdPO.Name = "grdPO"
        Me.grdPO.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPO.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPO.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPO.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdPO.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdPO.PrintInfo.PageSettings = CType(resources.GetObject("grdPO.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPO.Size = New System.Drawing.Size(620, 420)
        Me.grdPO.TabIndex = 78
        Me.grdPO.UseCompatibleTextRendering = False
        Me.grdPO.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdPO.PropBag = resources.GetString("grdPO.PropBag")
        '
        'POItemTempBindingSource
        '
        Me.POItemTempBindingSource.DataMember = "POItemTemp"
        Me.POItemTempBindingSource.DataSource = Me.DsPOItemTemp_ItemMasterO
        '
        'DsPOItemTemp_ItemMasterO
        '
        Me.DsPOItemTemp_ItemMasterO.DataSetName = "dsPOItemTemp_ItemMasterO"
        Me.DsPOItemTemp_ItemMasterO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'POItemTempTableAdapter
        '
        Me.POItemTempTableAdapter.ClearBeforeFill = True
        '
        'SpTotalPOTableAdapter
        '
        Me.SpTotalPOTableAdapter.ClearBeforeFill = True
        '
        'VendMasterTableAdapter
        '
        Me.VendMasterTableAdapter.ClearBeforeFill = True
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Location", True))
        Me.txtData4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData4.Location = New System.Drawing.Point(369, 60)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(100, 18)
        Me.txtData4.TabIndex = 79
        Me.txtData4.Tag = Nothing
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1DateEdit1
        '
        Me.C1DateEdit1.AllowSpinLoop = False
        Me.C1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DateEdit1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.C1DateEdit1.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.POMasterBindingSource, "Del_Date", True))
        Me.C1DateEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEdit1.Location = New System.Drawing.Point(90, 60)
        Me.C1DateEdit1.Name = "C1DateEdit1"
        Me.C1DateEdit1.Size = New System.Drawing.Size(187, 18)
        Me.C1DateEdit1.TabIndex = 80
        Me.C1DateEdit1.Tag = Nothing
        Me.C1DateEdit1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmPONew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 555)
        Me.Controls.Add(Me.C1DateEdit1)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.grdPO)
        Me.Controls.Add(Me.lblCurPO)
        Me.Controls.Add(Me.lblCurVend)
        Me.Controls.Add(Me.txtTotal3)
        Me.Controls.Add(Me.txtTotal1)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.txtTotal0)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.cmdFindPO)
        Me.Controls.Add(Me.txtVendAcct)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtVendName)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.cmdDelItem)
        Me.Controls.Add(Me.cmdRecAll)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Location = New System.Drawing.Point(87, 78)
        Me.Name = "frmPONew"
        Me.Text = "Add/Edit Purchase Order"
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRecAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdAddItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVendMaster_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPOMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVendAcct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpTotalPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspTotalPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurVend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblCurPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POItemTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPOItemTemp_ItemMasterO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRecAll As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelItem As C1.Win.C1Input.C1Button
    Friend WithEvents cmdAddItem As C1.Win.C1Input.C1Button
    Friend WithEvents txtVendName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtVendAcct As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindPO As C1.Win.C1Input.C1Button
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTotal0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTotal2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTotal1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTotal3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCurVend As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCurPO As C1.Win.C1Input.C1TextBox
    Friend WithEvents DsPOMaster As dsPOMaster
    Friend WithEvents POMasterBindingSource As BindingSource
    Friend WithEvents POMasterTableAdapter As dsPOMasterTableAdapters.POMasterTableAdapter
    Friend WithEvents grdPO As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents POItemTempBindingSource As BindingSource
    Friend WithEvents DsPOItemTemp_ItemMasterO As dsPOItemTemp_ItemMasterO
    Friend WithEvents POItemTempTableAdapter As dsPOItemTemp_ItemMasterOTableAdapters.POItemTempTableAdapter
    Friend WithEvents SpTotalPOBindingSource As BindingSource
    Friend WithEvents DsspTotalPO As dsspTotalPO
    Friend WithEvents SpTotalPOTableAdapter As dsspTotalPOTableAdapters.spTotalPOTableAdapter
    Friend WithEvents VendMasterBindingSource As BindingSource
    Friend WithEvents DsVendMaster_Vendor As dsVendMaster_Vendor
    Friend WithEvents VendMasterTableAdapter As dsVendMaster_VendorTableAdapters.VendMasterTableAdapter
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1DateEdit1 As C1.Win.Calendar.C1DateEdit
End Class
