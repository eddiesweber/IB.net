﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewCust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewCust))
        Me.fraEdit = New System.Windows.Forms.GroupBox()
        Me.cmdEditDept = New System.Windows.Forms.Button()
        Me.cmdEditCust = New System.Windows.Forms.Button()
        Me.cmdEditItem = New System.Windows.Forms.Button()
        Me.txtAverage2 = New System.Windows.Forms.TextBox()
        Me.txtData12 = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.txtData11 = New System.Windows.Forms.TextBox()
        Me.SpGetCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IBPortlandDataSet = New IB.net.IBPortlandDataSet()
        Me.txtData10 = New System.Windows.Forms.TextBox()
        Me.txtData9 = New System.Windows.Forms.TextBox()
        Me.txtData8 = New System.Windows.Forms.TextBox()
        Me.txtData7 = New System.Windows.Forms.TextBox()
        Me.txtData6 = New System.Windows.Forms.TextBox()
        Me.txtData5 = New System.Windows.Forms.TextBox()
        Me.txtData4 = New System.Windows.Forms.TextBox()
        Me.txtdata3 = New System.Windows.Forms.TextBox()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.grdDept = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetCustDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdRoute = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetCustRouteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdItem = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetCustItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetCustTableAdapter = New IB.net.IBPortlandDataSetTableAdapters.spGetCustTableAdapter()
        Me.SpGetCustDeptTableAdapter = New IB.net.IBPortlandDataSetTableAdapters.SpGetCustDeptTableAdapter()
        Me.SpGetCustRouteTableAdapter = New IB.net.IBPortlandDataSetTableAdapters.SpGetCustRouteTableAdapter()
        Me.SpGetCustItemTableAdapter = New IB.net.IBPortlandDataSetTableAdapters.SpGetCustItemTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SALESHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fraEdit.SuspendLayout()
        CType(Me.SpGetCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBPortlandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustRouteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraEdit
        '
        Me.fraEdit.Controls.Add(Me.cmdEditDept)
        Me.fraEdit.Controls.Add(Me.cmdEditCust)
        Me.fraEdit.Controls.Add(Me.cmdEditItem)
        Me.fraEdit.Location = New System.Drawing.Point(460, 121)
        Me.fraEdit.Name = "fraEdit"
        Me.fraEdit.Size = New System.Drawing.Size(92, 106)
        Me.fraEdit.TabIndex = 0
        Me.fraEdit.TabStop = False
        Me.fraEdit.Text = "Add/Edit"
        '
        'cmdEditDept
        '
        Me.cmdEditDept.Location = New System.Drawing.Point(7, 46)
        Me.cmdEditDept.Name = "cmdEditDept"
        Me.cmdEditDept.Size = New System.Drawing.Size(78, 22)
        Me.cmdEditDept.TabIndex = 28
        Me.cmdEditDept.Text = "&Depts/Routes"
        Me.cmdEditDept.UseVisualStyleBackColor = True
        '
        'cmdEditCust
        '
        Me.cmdEditCust.Location = New System.Drawing.Point(9, 18)
        Me.cmdEditCust.Name = "cmdEditCust"
        Me.cmdEditCust.Size = New System.Drawing.Size(78, 22)
        Me.cmdEditCust.TabIndex = 29
        Me.cmdEditCust.Text = "&Customer"
        Me.cmdEditCust.UseVisualStyleBackColor = True
        '
        'cmdEditItem
        '
        Me.cmdEditItem.Location = New System.Drawing.Point(7, 74)
        Me.cmdEditItem.Name = "cmdEditItem"
        Me.cmdEditItem.Size = New System.Drawing.Size(78, 22)
        Me.cmdEditItem.TabIndex = 30
        Me.cmdEditItem.Text = "&Item"
        Me.cmdEditItem.UseVisualStyleBackColor = True
        '
        'txtAverage2
        '
        Me.txtAverage2.BackColor = System.Drawing.Color.Silver
        Me.txtAverage2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAverage2.ForeColor = System.Drawing.Color.Navy
        Me.txtAverage2.Location = New System.Drawing.Point(161, 100)
        Me.txtAverage2.Multiline = True
        Me.txtAverage2.Name = "txtAverage2"
        Me.txtAverage2.Size = New System.Drawing.Size(57, 15)
        Me.txtAverage2.TabIndex = 36
        Me.txtAverage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtData12
        '
        Me.txtData12.BackColor = System.Drawing.Color.Silver
        Me.txtData12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData12.ForeColor = System.Drawing.Color.Navy
        Me.txtData12.Location = New System.Drawing.Point(224, 401)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Size = New System.Drawing.Size(169, 13)
        Me.txtData12.TabIndex = 34
        Me.txtData12.Visible = False
        '
        'txtAverage
        '
        Me.txtAverage.BackColor = System.Drawing.Color.Silver
        Me.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAverage.ForeColor = System.Drawing.Color.Navy
        Me.txtAverage.Location = New System.Drawing.Point(371, 100)
        Me.txtAverage.Multiline = True
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(64, 15)
        Me.txtAverage.TabIndex = 33
        Me.txtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(467, 233)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(78, 23)
        Me.cmdPrint.TabIndex = 31
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(467, 86)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 22)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(467, 58)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(78, 22)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(467, 30)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(78, 22)
        Me.cmdFind.TabIndex = 1
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtData11
        '
        Me.txtData11.BackColor = System.Drawing.Color.Silver
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "CARE_OF", True))
        Me.txtData11.ForeColor = System.Drawing.Color.Navy
        Me.txtData11.Location = New System.Drawing.Point(56, 72)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(162, 13)
        Me.txtData11.TabIndex = 26
        '
        'SpGetCustBindingSource
        '
        Me.SpGetCustBindingSource.DataMember = "spGetCust"
        Me.SpGetCustBindingSource.DataSource = Me.IBPortlandDataSet
        '
        'IBPortlandDataSet
        '
        Me.IBPortlandDataSet.DataSetName = "IBPortlandDataSet"
        Me.IBPortlandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData10
        '
        Me.txtData10.BackColor = System.Drawing.Color.Silver
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "URL", True))
        Me.txtData10.ForeColor = System.Drawing.Color.Navy
        Me.txtData10.Location = New System.Drawing.Point(287, 86)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(148, 13)
        Me.txtData10.TabIndex = 25
        '
        'txtData9
        '
        Me.txtData9.BackColor = System.Drawing.Color.Silver
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "EMAIL", True))
        Me.txtData9.ForeColor = System.Drawing.Color.Navy
        Me.txtData9.Location = New System.Drawing.Point(287, 72)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(148, 13)
        Me.txtData9.TabIndex = 24
        '
        'txtData8
        '
        Me.txtData8.BackColor = System.Drawing.Color.Silver
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "FAX_NO", True))
        Me.txtData8.ForeColor = System.Drawing.Color.Navy
        Me.txtData8.Location = New System.Drawing.Point(287, 58)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(148, 13)
        Me.txtData8.TabIndex = 23
        '
        'txtData7
        '
        Me.txtData7.BackColor = System.Drawing.Color.Silver
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "PHONE", True))
        Me.txtData7.ForeColor = System.Drawing.Color.Navy
        Me.txtData7.Location = New System.Drawing.Point(287, 44)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(148, 13)
        Me.txtData7.TabIndex = 22
        '
        'txtData6
        '
        Me.txtData6.BackColor = System.Drawing.Color.Silver
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "CONTACT", True))
        Me.txtData6.ForeColor = System.Drawing.Color.Navy
        Me.txtData6.Location = New System.Drawing.Point(287, 30)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(148, 13)
        Me.txtData6.TabIndex = 21
        '
        'txtData5
        '
        Me.txtData5.BackColor = System.Drawing.Color.Silver
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "COUNTY", True))
        Me.txtData5.ForeColor = System.Drawing.Color.Navy
        Me.txtData5.Location = New System.Drawing.Point(161, 86)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(57, 13)
        Me.txtData5.TabIndex = 20
        '
        'txtData4
        '
        Me.txtData4.BackColor = System.Drawing.Color.Silver
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "PAYBY", True))
        Me.txtData4.ForeColor = System.Drawing.Color.Navy
        Me.txtData4.Location = New System.Drawing.Point(56, 86)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(57, 13)
        Me.txtData4.TabIndex = 19
        '
        'txtdata3
        '
        Me.txtdata3.BackColor = System.Drawing.Color.Silver
        Me.txtdata3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdata3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "CSZ", True))
        Me.txtdata3.ForeColor = System.Drawing.Color.Navy
        Me.txtdata3.Location = New System.Drawing.Point(56, 58)
        Me.txtdata3.Name = "txtdata3"
        Me.txtdata3.Size = New System.Drawing.Size(162, 13)
        Me.txtdata3.TabIndex = 18
        '
        'txtData2
        '
        Me.txtData2.BackColor = System.Drawing.Color.Silver
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "BILL_STR", True))
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(56, 44)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(162, 13)
        Me.txtData2.TabIndex = 17
        '
        'txtData1
        '
        Me.txtData1.BackColor = System.Drawing.Color.Silver
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "BILL_NAME", True))
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(56, 30)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(162, 13)
        Me.txtData1.TabIndex = 16
        '
        'txtData0
        '
        Me.txtData0.BackColor = System.Drawing.Color.Silver
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustBindingSource, "CUST_NUM", True))
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(7, 30)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(43, 13)
        Me.txtData0.TabIndex = 15
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(4, 100)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(150, 13)
        Me.lblLabel9.TabIndex = 35
        Me.lblLabel9.Text = "Average Monthly Paper Sales:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(235, 100)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(136, 13)
        Me.lblLabel8.TabIndex = 32
        Me.lblLabel8.Text = "Average Weekly Revenue:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(116, 86)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel7.TabIndex = 13
        Me.lblLabel7.Text = "County:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(235, 86)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(32, 13)
        Me.lblLabel6.TabIndex = 9
        Me.lblLabel6.Text = "URL:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(235, 72)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel5.TabIndex = 8
        Me.lblLabel5.Text = "e-Mail:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(235, 58)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel4.TabIndex = 7
        Me.lblLabel4.Text = "Fax:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(235, 44)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel3.TabIndex = 6
        Me.lblLabel3.Text = "Phone:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(235, 31)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "Contact:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(4, 86)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel1.TabIndex = 4
        Me.lblLabel1.Text = "Pay By:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(4, 72)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "C/O:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(9, 46)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 0
        Me.lblCurCust.Visible = False
        '
        'grdDept
        '
        Me.grdDept.AllowUpdate = False
        Me.grdDept.Caption = "DEPARTMENTS"
        Me.grdDept.DataSource = Me.SpGetCustDeptBindingSource
        Me.grdDept.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.grdDept.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdDept.Images.Add(CType(resources.GetObject("grdDept.Images"), System.Drawing.Image))
        Me.grdDept.Location = New System.Drawing.Point(7, 121)
        Me.grdDept.Name = "grdDept"
        Me.grdDept.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDept.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDept.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDept.PrintInfo.PageSettings = CType(resources.GetObject("grdDept.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDept.PropBag = resources.GetString("grdDept.PropBag")
        Me.grdDept.Size = New System.Drawing.Size(445, 85)
        Me.grdDept.TabIndex = 37
        Me.grdDept.UseCompatibleTextRendering = False
        Me.grdDept.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'SpGetCustDeptBindingSource
        '
        Me.SpGetCustDeptBindingSource.DataMember = "SpGetCustDept"
        Me.SpGetCustDeptBindingSource.DataSource = Me.IBPortlandDataSet
        '
        'grdRoute
        '
        Me.grdRoute.AllowUpdate = False
        Me.grdRoute.Caption = "ROUTES"
        Me.grdRoute.DataSource = Me.SpGetCustRouteBindingSource
        Me.grdRoute.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdRoute.Images.Add(CType(resources.GetObject("grdRoute.Images"), System.Drawing.Image))
        Me.grdRoute.Location = New System.Drawing.Point(7, 212)
        Me.grdRoute.Name = "grdRoute"
        Me.grdRoute.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRoute.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRoute.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRoute.PrintInfo.PageSettings = CType(resources.GetObject("grdRoute.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRoute.PropBag = resources.GetString("grdRoute.PropBag")
        Me.grdRoute.Size = New System.Drawing.Size(445, 70)
        Me.grdRoute.TabIndex = 38
        Me.grdRoute.UseCompatibleTextRendering = False
        Me.grdRoute.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'SpGetCustRouteBindingSource
        '
        Me.SpGetCustRouteBindingSource.DataMember = "SpGetCustRoute"
        Me.SpGetCustRouteBindingSource.DataSource = Me.IBPortlandDataSet
        '
        'grdItem
        '
        Me.grdItem.AllowUpdate = False
        Me.grdItem.Caption = "ITEMS (STANDING ORDERS)"
        Me.grdItem.DataSource = Me.SpGetCustItemBindingSource
        Me.grdItem.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdItem.Images.Add(CType(resources.GetObject("grdItem.Images"), System.Drawing.Image))
        Me.grdItem.Location = New System.Drawing.Point(7, 288)
        Me.grdItem.Name = "grdItem"
        Me.grdItem.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdItem.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdItem.PreviewInfo.ZoomFactor = 75.0R
        Me.grdItem.PrintInfo.PageSettings = CType(resources.GetObject("grdItem.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdItem.PropBag = resources.GetString("grdItem.PropBag")
        Me.grdItem.Size = New System.Drawing.Size(545, 161)
        Me.grdItem.TabIndex = 39
        Me.grdItem.UseCompatibleTextRendering = False
        Me.grdItem.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'SpGetCustItemBindingSource
        '
        Me.SpGetCustItemBindingSource.DataMember = "SpGetCustItem"
        Me.SpGetCustItemBindingSource.DataSource = Me.IBPortlandDataSet
        '
        'SpGetCustTableAdapter
        '
        Me.SpGetCustTableAdapter.ClearBeforeFill = True
        '
        'SpGetCustDeptTableAdapter
        '
        Me.SpGetCustDeptTableAdapter.ClearBeforeFill = True
        '
        'SpGetCustRouteTableAdapter
        '
        Me.SpGetCustRouteTableAdapter.ClearBeforeFill = True
        '
        'SpGetCustItemTableAdapter
        '
        Me.SpGetCustItemTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SALESHISTORYToolStripMenuItem, Me.ITEMHISTORYToolStripMenuItem, Me.ARHISTORYToolStripMenuItem, Me.NOTESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(559, 24)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SALESHISTORYToolStripMenuItem
        '
        Me.SALESHISTORYToolStripMenuItem.Name = "SALESHISTORYToolStripMenuItem"
        Me.SALESHISTORYToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.SALESHISTORYToolStripMenuItem.Text = "&SALES HISTORY"
        '
        'ITEMHISTORYToolStripMenuItem
        '
        Me.ITEMHISTORYToolStripMenuItem.Name = "ITEMHISTORYToolStripMenuItem"
        Me.ITEMHISTORYToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ITEMHISTORYToolStripMenuItem.Text = "ITEM &HISTORY"
        '
        'ARHISTORYToolStripMenuItem
        '
        Me.ARHISTORYToolStripMenuItem.Name = "ARHISTORYToolStripMenuItem"
        Me.ARHISTORYToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ARHISTORYToolStripMenuItem.Text = "&AR HISTORY"
        '
        'NOTESToolStripMenuItem
        '
        Me.NOTESToolStripMenuItem.Name = "NOTESToolStripMenuItem"
        Me.NOTESToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.NOTESToolStripMenuItem.Text = "&NOTES"
        '
        'frmViewCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 461)
        Me.Controls.Add(Me.grdItem)
        Me.Controls.Add(Me.grdRoute)
        Me.Controls.Add(Me.grdDept)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel8)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtdata3)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtData12)
        Me.Controls.Add(Me.txtAverage2)
        Me.Controls.Add(Me.fraEdit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(62, 101)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmViewCust"
        Me.Text = "Customer View"
        Me.fraEdit.ResumeLayout(False)
        CType(Me.SpGetCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBPortlandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustRouteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fraEdit As GroupBox
    Friend WithEvents txtAverage2 As TextBox
    Friend WithEvents txtData12 As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdFind As Button
    Friend WithEvents cmdEditDept As Button
    Friend WithEvents cmdEditCust As Button
    Friend WithEvents cmdEditItem As Button
    Friend WithEvents txtData11 As TextBox
    Friend WithEvents txtData10 As TextBox
    Friend WithEvents txtData9 As TextBox
    Friend WithEvents txtData8 As TextBox
    Friend WithEvents txtData7 As TextBox
    Friend WithEvents txtData6 As TextBox
    Friend WithEvents txtData5 As TextBox
    Friend WithEvents txtData4 As TextBox
    Friend WithEvents txtdata3 As TextBox
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents SpGetCustBindingSource As BindingSource
    Friend WithEvents IBPortlandDataSet As IBPortlandDataSet
    Friend WithEvents SpGetCustTableAdapter As IBPortlandDataSetTableAdapters.spGetCustTableAdapter
    Friend WithEvents grdDept As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetCustDeptBindingSource As BindingSource
    Friend WithEvents SpGetCustDeptTableAdapter As IBPortlandDataSetTableAdapters.SpGetCustDeptTableAdapter
    Friend WithEvents grdRoute As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetCustRouteBindingSource As BindingSource
    Friend WithEvents SpGetCustRouteTableAdapter As IBPortlandDataSetTableAdapters.SpGetCustRouteTableAdapter
    Friend WithEvents grdItem As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetCustItemBindingSource As BindingSource
    Friend WithEvents SpGetCustItemTableAdapter As IBPortlandDataSetTableAdapters.SpGetCustItemTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SALESHISTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITEMHISTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARHISTORYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTESToolStripMenuItem As ToolStripMenuItem
End Class
