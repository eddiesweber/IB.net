<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvItem))
        Me.chkData = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmbCode = New C1.Win.C1List.C1Combo()
        Me.SpGetVolCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetVolCodes = New IB.net.dsspGetVolCodes()
        Me.optAction0 = New System.Windows.Forms.RadioButton()
        Me.optAction1 = New System.Windows.Forms.RadioButton()
        Me.optAction2 = New System.Windows.Forms.RadioButton()
        Me.optAction3 = New System.Windows.Forms.RadioButton()
        Me.optAction4 = New System.Windows.Forms.RadioButton()
        Me.scrChange3 = New System.Windows.Forms.VScrollBar()
        Me.scrChange2 = New System.Windows.Forms.VScrollBar()
        Me.scrChange1 = New System.Windows.Forms.VScrollBar()
        Me.scrChange0 = New System.Windows.Forms.VScrollBar()
        Me.scrQty13 = New System.Windows.Forms.VScrollBar()
        Me.scrQty12 = New System.Windows.Forms.VScrollBar()
        Me.scrQty11 = New System.Windows.Forms.VScrollBar()
        Me.scrQty10 = New System.Windows.Forms.VScrollBar()
        Me.fraSales = New System.Windows.Forms.GroupBox()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.SpGetSalesmenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetSalesmen = New IB.net.dsspGetSalesmen()
        Me.optSales0 = New System.Windows.Forms.RadioButton()
        Me.optSales1 = New System.Windows.Forms.RadioButton()
        Me.optSales2 = New System.Windows.Forms.RadioButton()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurInvoice = New System.Windows.Forms.Label()
        Me.lblLabel13 = New System.Windows.Forms.Label()
        Me.lbllabel12 = New System.Windows.Forms.Label()
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
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindInv = New C1.Win.C1Input.C1Button()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindItem = New C1.Win.C1Input.C1Button()
        Me.txtItemDesc = New C1.Win.C1Input.C1TextBox()
        Me.txtData20 = New C1.Win.C1Input.C1TextBox()
        Me.txtMemo = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent0 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent1 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent2 = New C1.Win.C1Input.C1TextBox()
        Me.txtCurrent3 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange1 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange2 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange3 = New C1.Win.C1Input.C1TextBox()
        Me.txtChange0 = New C1.Win.C1Input.C1TextBox()
        Me.txtData19 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.txtData12 = New C1.Win.C1Input.C1TextBox()
        Me.txtData13 = New C1.Win.C1Input.C1TextBox()
        Me.txtTotal = New C1.Win.C1Input.C1TextBox()
        Me.SpGetVolCodesTableAdapter = New IB.net.dsspGetVolCodesTableAdapters.spGetVolCodesTableAdapter()
        Me.SpGetSalesmenTableAdapter = New IB.net.dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter()
        Me.C1EditorToolStripTable1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable()
        Me.DsspGetInvItems = New IB.net.dsspGetInvItems()
        Me.SpGetInvItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetInvItemsTableAdapter = New IB.net.dsspGetInvItemsTableAdapters.spGetInvItemsTableAdapter()
        Me.DsspGetInvName = New IB.net.dsspGetInvName()
        Me.SpGetInvNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetInvNameTableAdapter = New IB.net.dsspGetInvNameTableAdapters.spGetInvNameTableAdapter()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData14 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData15 = New C1.Win.C1Input.C1TextBox()
        Me.Frame1.SuspendLayout()
        CType(Me.cmbCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetVolCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetVolCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraSales.SuspendLayout()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCurrent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChange0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.Location = New System.Drawing.Point(80, 274)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(15, 14)
        Me.chkData.TabIndex = 75
        Me.chkData.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cmbCode)
        Me.Frame1.Controls.Add(Me.optAction0)
        Me.Frame1.Controls.Add(Me.optAction1)
        Me.Frame1.Controls.Add(Me.optAction2)
        Me.Frame1.Controls.Add(Me.optAction3)
        Me.Frame1.Controls.Add(Me.optAction4)
        Me.Frame1.Location = New System.Drawing.Point(255, 60)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(155, 106)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Action:"
        '
        'cmbCode
        '
        Me.cmbCode.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCode.AllowColSelect = True
        Me.cmbCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCode.Caption = ""
        Me.cmbCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCode.ColumnHeaders = False
        Me.cmbCode.ColumnWidth = 135
        Me.cmbCode.DataSource = Me.SpGetVolCodesBindingSource
        Me.cmbCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCode.DisplayMember = "DESC"
        Me.cmbCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCode.Images.Add(CType(resources.GetObject("cmbCode.Images"), System.Drawing.Image))
        Me.cmbCode.Location = New System.Drawing.Point(10, 75)
        Me.cmbCode.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCode.MaxDropDownItems = CType(5, Short)
        Me.cmbCode.MaxLength = 32767
        Me.cmbCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCode.Name = "cmbCode"
        Me.cmbCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCode.Size = New System.Drawing.Size(135, 21)
        Me.cmbCode.TabIndex = 96
        Me.cmbCode.ValueMember = "VOL_CD"
        Me.cmbCode.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbCode.PropBag = resources.GetString("cmbCode.PropBag")
        '
        'SpGetVolCodesBindingSource
        '
        Me.SpGetVolCodesBindingSource.DataMember = "spGetVolCodes"
        Me.SpGetVolCodesBindingSource.DataSource = Me.DsspGetVolCodes
        '
        'DsspGetVolCodes
        '
        Me.DsspGetVolCodes.DataSetName = "dsspGetVolCodes"
        Me.DsspGetVolCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'optAction0
        '
        Me.optAction0.AutoSize = True
        Me.optAction0.ForeColor = System.Drawing.Color.Black
        Me.optAction0.Location = New System.Drawing.Point(7, 16)
        Me.optAction0.Name = "optAction0"
        Me.optAction0.Size = New System.Drawing.Size(68, 17)
        Me.optAction0.TabIndex = 6
        Me.optAction0.TabStop = True
        Me.optAction0.Text = "Standard"
        Me.optAction0.UseVisualStyleBackColor = True
        '
        'optAction1
        '
        Me.optAction1.AutoSize = True
        Me.optAction1.ForeColor = System.Drawing.Color.Black
        Me.optAction1.Location = New System.Drawing.Point(7, 35)
        Me.optAction1.Name = "optAction1"
        Me.optAction1.Size = New System.Drawing.Size(49, 17)
        Me.optAction1.TabIndex = 7
        Me.optAction1.TabStop = True
        Me.optAction1.Text = "Loan"
        Me.optAction1.UseVisualStyleBackColor = True
        '
        'optAction2
        '
        Me.optAction2.AutoSize = True
        Me.optAction2.ForeColor = System.Drawing.Color.Black
        Me.optAction2.Location = New System.Drawing.Point(77, 16)
        Me.optAction2.Name = "optAction2"
        Me.optAction2.Size = New System.Drawing.Size(76, 17)
        Me.optAction2.TabIndex = 8
        Me.optAction2.TabStop = True
        Me.optAction2.Text = "Retail Sale"
        Me.optAction2.UseVisualStyleBackColor = True
        '
        'optAction3
        '
        Me.optAction3.AutoSize = True
        Me.optAction3.ForeColor = System.Drawing.Color.Black
        Me.optAction3.Location = New System.Drawing.Point(77, 35)
        Me.optAction3.Name = "optAction3"
        Me.optAction3.Size = New System.Drawing.Size(69, 17)
        Me.optAction3.TabIndex = 9
        Me.optAction3.TabStop = True
        Me.optAction3.Text = "Loss Chg"
        Me.optAction3.UseVisualStyleBackColor = True
        '
        'optAction4
        '
        Me.optAction4.AutoSize = True
        Me.optAction4.ForeColor = System.Drawing.Color.Black
        Me.optAction4.Location = New System.Drawing.Point(77, 54)
        Me.optAction4.Name = "optAction4"
        Me.optAction4.Size = New System.Drawing.Size(51, 17)
        Me.optAction4.TabIndex = 10
        Me.optAction4.TabStop = True
        Me.optAction4.Text = "Other"
        Me.optAction4.UseVisualStyleBackColor = True
        '
        'scrChange3
        '
        Me.scrChange3.Location = New System.Drawing.Point(189, 247)
        Me.scrChange3.Minimum = -32000
        Me.scrChange3.Name = "scrChange3"
        Me.scrChange3.Size = New System.Drawing.Size(15, 19)
        Me.scrChange3.TabIndex = 60
        '
        'scrChange2
        '
        Me.scrChange2.Location = New System.Drawing.Point(189, 227)
        Me.scrChange2.Minimum = -32000
        Me.scrChange2.Name = "scrChange2"
        Me.scrChange2.Size = New System.Drawing.Size(15, 19)
        Me.scrChange2.TabIndex = 59
        '
        'scrChange1
        '
        Me.scrChange1.Location = New System.Drawing.Point(189, 207)
        Me.scrChange1.Minimum = -32000
        Me.scrChange1.Name = "scrChange1"
        Me.scrChange1.Size = New System.Drawing.Size(15, 19)
        Me.scrChange1.TabIndex = 58
        '
        'scrChange0
        '
        Me.scrChange0.Location = New System.Drawing.Point(189, 187)
        Me.scrChange0.Minimum = -32000
        Me.scrChange0.Name = "scrChange0"
        Me.scrChange0.Size = New System.Drawing.Size(15, 19)
        Me.scrChange0.TabIndex = 57
        '
        'scrQty13
        '
        Me.scrQty13.Location = New System.Drawing.Point(266, 247)
        Me.scrQty13.Minimum = -32000
        Me.scrQty13.Name = "scrQty13"
        Me.scrQty13.Size = New System.Drawing.Size(15, 19)
        Me.scrQty13.TabIndex = 56
        '
        'scrQty12
        '
        Me.scrQty12.Location = New System.Drawing.Point(266, 227)
        Me.scrQty12.Minimum = -32000
        Me.scrQty12.Name = "scrQty12"
        Me.scrQty12.Size = New System.Drawing.Size(15, 19)
        Me.scrQty12.TabIndex = 55
        '
        'scrQty11
        '
        Me.scrQty11.Location = New System.Drawing.Point(266, 207)
        Me.scrQty11.Minimum = -32000
        Me.scrQty11.Name = "scrQty11"
        Me.scrQty11.Size = New System.Drawing.Size(15, 19)
        Me.scrQty11.TabIndex = 54
        '
        'scrQty10
        '
        Me.scrQty10.Location = New System.Drawing.Point(266, 187)
        Me.scrQty10.Minimum = -32000
        Me.scrQty10.Name = "scrQty10"
        Me.scrQty10.Size = New System.Drawing.Size(15, 19)
        Me.scrQty10.TabIndex = 53
        '
        'fraSales
        '
        Me.fraSales.Controls.Add(Me.txtData8)
        Me.fraSales.Controls.Add(Me.txtData9)
        Me.fraSales.Controls.Add(Me.txtData7)
        Me.fraSales.Controls.Add(Me.txtData5)
        Me.fraSales.Controls.Add(Me.txtData6)
        Me.fraSales.Controls.Add(Me.txtData4)
        Me.fraSales.Controls.Add(Me.Label1)
        Me.fraSales.Controls.Add(Me.Label2)
        Me.fraSales.Controls.Add(Me.lstSales)
        Me.fraSales.Controls.Add(Me.optSales0)
        Me.fraSales.Controls.Add(Me.optSales1)
        Me.fraSales.Controls.Add(Me.optSales2)
        Me.fraSales.ForeColor = System.Drawing.Color.Black
        Me.fraSales.Location = New System.Drawing.Point(10, 315)
        Me.fraSales.Name = "fraSales"
        Me.fraSales.Size = New System.Drawing.Size(360, 95)
        Me.fraSales.TabIndex = 33
        Me.fraSales.TabStop = False
        Me.fraSales.Text = "&Salesperson(s)"
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_2PCT", True))
        Me.txtData8.DataType = GetType(Single)
        Me.txtData8.Location = New System.Drawing.Point(295, 45)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(50, 18)
        Me.txtData8.TabIndex = 121
        Me.txtData8.Tag = Nothing
        Me.txtData8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData9
        '
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_3PCT", True))
        Me.txtData9.DataType = GetType(Single)
        Me.txtData9.Location = New System.Drawing.Point(295, 65)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(50, 18)
        Me.txtData9.TabIndex = 120
        Me.txtData9.Tag = Nothing
        Me.txtData9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_1PCT", True))
        Me.txtData7.DataType = GetType(Single)
        Me.txtData7.Location = New System.Drawing.Point(295, 25)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(50, 18)
        Me.txtData7.TabIndex = 119
        Me.txtData7.Tag = Nothing
        Me.txtData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_2", True))
        Me.txtData5.Location = New System.Drawing.Point(230, 45)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(50, 18)
        Me.txtData5.TabIndex = 118
        Me.txtData5.Tag = Nothing
        Me.txtData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_3", True))
        Me.txtData6.Location = New System.Drawing.Point(230, 65)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(50, 18)
        Me.txtData6.TabIndex = 117
        Me.txtData6.Tag = Nothing
        Me.txtData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "SALES_1", True))
        Me.txtData4.Location = New System.Drawing.Point(230, 26)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(50, 18)
        Me.txtData4.TabIndex = 116
        Me.txtData4.Tag = Nothing
        Me.txtData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Percent:"
        '
        'lstSales
        '
        Me.lstSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lstSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSales.DataSource = Me.SpGetSalesmenBindingSource
        Me.lstSales.DisplayMember = "Sales"
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(15, 28)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(183, 54)
        Me.lstSales.TabIndex = 71
        Me.lstSales.ValueMember = "FSALESNUM"
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
        'optSales0
        '
        Me.optSales0.AutoSize = True
        Me.optSales0.Location = New System.Drawing.Point(210, 28)
        Me.optSales0.Name = "optSales0"
        Me.optSales0.Size = New System.Drawing.Size(14, 13)
        Me.optSales0.TabIndex = 72
        Me.optSales0.TabStop = True
        Me.optSales0.UseVisualStyleBackColor = True
        '
        'optSales1
        '
        Me.optSales1.AutoSize = True
        Me.optSales1.Location = New System.Drawing.Point(210, 49)
        Me.optSales1.Name = "optSales1"
        Me.optSales1.Size = New System.Drawing.Size(14, 13)
        Me.optSales1.TabIndex = 73
        Me.optSales1.TabStop = True
        Me.optSales1.UseVisualStyleBackColor = True
        '
        'optSales2
        '
        Me.optSales2.AutoSize = True
        Me.optSales2.Location = New System.Drawing.Point(210, 70)
        Me.optSales2.Name = "optSales2"
        Me.optSales2.Size = New System.Drawing.Size(14, 13)
        Me.optSales2.TabIndex = 74
        Me.optSales2.TabStop = True
        Me.optSales2.UseVisualStyleBackColor = True
        '
        'lstItem
        '
        Me.lstItem.DataSource = Me.SpGetInvItemsBindingSource
        Me.lstItem.DisplayMember = "ITEM_NUM"
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(60, 65)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(78, 43)
        Me.lstItem.TabIndex = 70
        Me.lstItem.ValueMember = "ITEM_NUM"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.ForeColor = System.Drawing.Color.Black
        Me.lblLabel1.Location = New System.Drawing.Point(252, 16)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "De&pt:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.ForeColor = System.Drawing.Color.Black
        Me.lblLabel5.Location = New System.Drawing.Point(10, 422)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(79, 13)
        Me.lblLabel5.TabIndex = 40
        Me.lblLabel5.Text = "Change &Memo:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.ForeColor = System.Drawing.Color.Black
        Me.lblLabel0.Location = New System.Drawing.Point(10, 16)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel0.TabIndex = 67
        Me.lblLabel0.Text = "&Invoice:"
        '
        'lblCurInvoice
        '
        Me.lblCurInvoice.ForeColor = System.Drawing.Color.Black
        Me.lblCurInvoice.Location = New System.Drawing.Point(438, 275)
        Me.lblCurInvoice.Name = "lblCurInvoice"
        Me.lblCurInvoice.Size = New System.Drawing.Size(74, 15)
        Me.lblCurInvoice.TabIndex = 66
        Me.lblCurInvoice.Text = "lblCurInvoice"
        '
        'lblLabel13
        '
        Me.lblLabel13.AutoSize = True
        Me.lblLabel13.ForeColor = System.Drawing.Color.Black
        Me.lblLabel13.Location = New System.Drawing.Point(10, 232)
        Me.lblLabel13.Name = "lblLabel13"
        Me.lblLabel13.Size = New System.Drawing.Size(67, 13)
        Me.lblLabel13.TabIndex = 25
        Me.lblLabel13.Text = "Deliver&y Qty:"
        '
        'lbllabel12
        '
        Me.lbllabel12.AutoSize = True
        Me.lbllabel12.ForeColor = System.Drawing.Color.Black
        Me.lbllabel12.Location = New System.Drawing.Point(10, 252)
        Me.lbllabel12.Name = "lbllabel12"
        Me.lbllabel12.Size = New System.Drawing.Size(42, 13)
        Me.lbllabel12.TabIndex = 21
        Me.lbllabel12.Text = "&Bill Qty:"
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.ForeColor = System.Drawing.Color.Black
        Me.lblLabel11.Location = New System.Drawing.Point(10, 212)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel11.TabIndex = 17
        Me.lblLabel11.Text = "In&ventory:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.ForeColor = System.Drawing.Color.Black
        Me.lblLabel10.Location = New System.Drawing.Point(10, 192)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel10.TabIndex = 13
        Me.lblLabel10.Text = "&Loaned Qty:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.ForeColor = System.Drawing.Color.Black
        Me.lblLabel9.Location = New System.Drawing.Point(217, 175)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(51, 13)
        Me.lblLabel9.TabIndex = 63
        Me.lblLabel9.Text = "New Qty:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.ForeColor = System.Drawing.Color.Black
        Me.lblLabel4.Location = New System.Drawing.Point(140, 175)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel4.TabIndex = 62
        Me.lblLabel4.Text = "Change:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.ForeColor = System.Drawing.Color.Black
        Me.lblLabel3.Location = New System.Drawing.Point(77, 175)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel3.TabIndex = 61
        Me.lblLabel3.Text = "Current:"
        '
        'lblCurItem
        '
        Me.lblCurItem.ForeColor = System.Drawing.Color.Black
        Me.lblCurItem.Location = New System.Drawing.Point(438, 296)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(74, 15)
        Me.lblCurItem.TabIndex = 52
        Me.lblCurItem.Text = "lblCurItem"
        Me.lblCurItem.Visible = False
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.ForeColor = System.Drawing.Color.Black
        Me.lblLabel6.Location = New System.Drawing.Point(156, 275)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel6.TabIndex = 29
        Me.lblLabel6.Text = "Unit &Price:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.ForeColor = System.Drawing.Color.Black
        Me.lblLabel7.Location = New System.Drawing.Point(10, 275)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel7.TabIndex = 31
        Me.lblLabel7.Text = "&Taxable:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.ForeColor = System.Drawing.Color.Black
        Me.lblLabel8.Location = New System.Drawing.Point(10, 142)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel8.TabIndex = 11
        Me.lblLabel8.Text = "Id&entity:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.ForeColor = System.Drawing.Color.Black
        Me.lblLabel2.Location = New System.Drawing.Point(10, 65)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel2.TabIndex = 2
        Me.lblLabel2.Text = "Ite&m:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(434, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 81
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(434, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 80
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(434, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 79
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(434, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 78
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(434, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 77
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "INV_NUMBER", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(60, 14)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(75, 18)
        Me.txtData0.TabIndex = 82
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindInv
        '
        Me.cmdFindInv.Location = New System.Drawing.Point(150, 10)
        Me.cmdFindInv.Name = "cmdFindInv"
        Me.cmdFindInv.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindInv.TabIndex = 83
        Me.cmdFindInv.Text = "&Find"
        Me.cmdFindInv.UseVisualStyleBackColor = True
        Me.cmdFindInv.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "DEPT", True))
        Me.txtData1.DataType = GetType(Short)
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(288, 14)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(75, 18)
        Me.txtData1.TabIndex = 84
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvNameBindingSource, "DEL_NAME", True))
        Me.txtCustDept.Location = New System.Drawing.Point(60, 40)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustDept.Size = New System.Drawing.Size(175, 15)
        Me.txtCustDept.TabIndex = 85
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(150, 65)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindItem.TabIndex = 86
        Me.cmdFindItem.Text = "&Find"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        Me.cmdFindItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtItemDesc.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "ITEM_DESC", True))
        Me.txtItemDesc.Location = New System.Drawing.Point(60, 115)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Padding = New System.Windows.Forms.Padding(1)
        Me.txtItemDesc.Size = New System.Drawing.Size(175, 15)
        Me.txtItemDesc.TabIndex = 87
        Me.txtItemDesc.Tag = Nothing
        Me.txtItemDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData20
        '
        Me.txtData20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData20.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "NAME_SIZE", True))
        Me.txtData20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData20.Location = New System.Drawing.Point(60, 140)
        Me.txtData20.Name = "txtData20"
        Me.txtData20.Size = New System.Drawing.Size(100, 18)
        Me.txtData20.TabIndex = 89
        Me.txtData20.Tag = Nothing
        Me.txtData20.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData20.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtMemo
        '
        Me.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemo.Location = New System.Drawing.Point(100, 420)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(270, 18)
        Me.txtMemo.TabIndex = 90
        Me.txtMemo.Tag = Nothing
        Me.txtMemo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMemo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent0
        '
        Me.txtCurrent0.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent0.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent0.Location = New System.Drawing.Point(80, 190)
        Me.txtCurrent0.Name = "txtCurrent0"
        Me.txtCurrent0.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent0.TabIndex = 99
        Me.txtCurrent0.Tag = Nothing
        Me.txtCurrent0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent1
        '
        Me.txtCurrent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent1.Location = New System.Drawing.Point(80, 210)
        Me.txtCurrent1.Name = "txtCurrent1"
        Me.txtCurrent1.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent1.TabIndex = 98
        Me.txtCurrent1.Tag = Nothing
        Me.txtCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent2
        '
        Me.txtCurrent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent2.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent2.Location = New System.Drawing.Point(80, 230)
        Me.txtCurrent2.Name = "txtCurrent2"
        Me.txtCurrent2.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent2.TabIndex = 97
        Me.txtCurrent2.Tag = Nothing
        Me.txtCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCurrent3
        '
        Me.txtCurrent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCurrent3.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrent3.Location = New System.Drawing.Point(80, 250)
        Me.txtCurrent3.Name = "txtCurrent3"
        Me.txtCurrent3.Size = New System.Drawing.Size(50, 18)
        Me.txtCurrent3.TabIndex = 96
        Me.txtCurrent3.Tag = Nothing
        Me.txtCurrent3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCurrent3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange1
        '
        Me.txtChange1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange1.Location = New System.Drawing.Point(140, 210)
        Me.txtChange1.Name = "txtChange1"
        Me.txtChange1.Size = New System.Drawing.Size(50, 18)
        Me.txtChange1.TabIndex = 103
        Me.txtChange1.Tag = Nothing
        Me.txtChange1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange2
        '
        Me.txtChange2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange2.Location = New System.Drawing.Point(140, 230)
        Me.txtChange2.Name = "txtChange2"
        Me.txtChange2.Size = New System.Drawing.Size(50, 18)
        Me.txtChange2.TabIndex = 102
        Me.txtChange2.Tag = Nothing
        Me.txtChange2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange3
        '
        Me.txtChange3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange3.Location = New System.Drawing.Point(140, 250)
        Me.txtChange3.Name = "txtChange3"
        Me.txtChange3.Size = New System.Drawing.Size(50, 18)
        Me.txtChange3.TabIndex = 101
        Me.txtChange3.Tag = Nothing
        Me.txtChange3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChange0
        '
        Me.txtChange0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChange0.Location = New System.Drawing.Point(140, 190)
        Me.txtChange0.Name = "txtChange0"
        Me.txtChange0.Size = New System.Drawing.Size(50, 18)
        Me.txtChange0.TabIndex = 100
        Me.txtChange0.Tag = Nothing
        Me.txtChange0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChange0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData19
        '
        Me.txtData19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData19.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "UNIT_PRICE", True))
        Me.txtData19.DataType = GetType(Single)
        Me.txtData19.Location = New System.Drawing.Point(218, 273)
        Me.txtData19.Name = "txtData19"
        Me.txtData19.Size = New System.Drawing.Size(50, 18)
        Me.txtData19.TabIndex = 109
        Me.txtData19.Tag = Nothing
        Me.txtData19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData19.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData19.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "LOAN_QTY", True))
        Me.txtData10.DataType = GetType(Single)
        Me.txtData10.Location = New System.Drawing.Point(218, 190)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(50, 18)
        Me.txtData10.TabIndex = 108
        Me.txtData10.Tag = Nothing
        Me.txtData10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "INV_QTY", True))
        Me.txtData11.DataType = GetType(Single)
        Me.txtData11.Location = New System.Drawing.Point(218, 210)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(50, 18)
        Me.txtData11.TabIndex = 107
        Me.txtData11.Tag = Nothing
        Me.txtData11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData11.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData12
        '
        Me.txtData12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "REQ_QTY", True))
        Me.txtData12.DataType = GetType(Single)
        Me.txtData12.Location = New System.Drawing.Point(218, 230)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Size = New System.Drawing.Size(50, 18)
        Me.txtData12.TabIndex = 106
        Me.txtData12.Tag = Nothing
        Me.txtData12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData12.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData12.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData13
        '
        Me.txtData13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData13.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "BILL_QTY", True))
        Me.txtData13.DataType = GetType(Single)
        Me.txtData13.Location = New System.Drawing.Point(218, 250)
        Me.txtData13.Name = "txtData13"
        Me.txtData13.Size = New System.Drawing.Size(50, 18)
        Me.txtData13.TabIndex = 105
        Me.txtData13.Tag = Nothing
        Me.txtData13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtData13.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData13.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtTotal.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(203, 296)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(65, 18)
        Me.txtTotal.TabIndex = 110
        Me.txtTotal.Tag = Nothing
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetVolCodesTableAdapter
        '
        Me.SpGetVolCodesTableAdapter.ClearBeforeFill = True
        '
        'SpGetSalesmenTableAdapter
        '
        Me.SpGetSalesmenTableAdapter.ClearBeforeFill = True
        '
        'C1EditorToolStripTable1
        '
        Me.C1EditorToolStripTable1.Editor = Nothing
        Me.C1EditorToolStripTable1.Location = New System.Drawing.Point(0, 0)
        Me.C1EditorToolStripTable1.Name = "C1EditorToolStripTable1"
        Me.C1EditorToolStripTable1.Size = New System.Drawing.Size(100, 25)
        Me.C1EditorToolStripTable1.TabIndex = 0
        Me.C1EditorToolStripTable1.Text = "C1EditorToolStripTable1"
        '
        'DsspGetInvItems
        '
        Me.DsspGetInvItems.DataSetName = "dsspGetInvItems"
        Me.DsspGetInvItems.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetInvItemsBindingSource
        '
        Me.SpGetInvItemsBindingSource.DataMember = "spGetInvItems"
        Me.SpGetInvItemsBindingSource.DataSource = Me.DsspGetInvItems
        '
        'SpGetInvItemsTableAdapter
        '
        Me.SpGetInvItemsTableAdapter.ClearBeforeFill = True
        '
        'DsspGetInvName
        '
        Me.DsspGetInvName.DataSetName = "dsspGetInvName"
        Me.DsspGetInvName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetInvNameBindingSource
        '
        Me.SpGetInvNameBindingSource.DataMember = "spGetInvName"
        Me.SpGetInvNameBindingSource.DataSource = Me.DsspGetInvName
        '
        'SpGetInvNameTableAdapter
        '
        Me.SpGetInvNameTableAdapter.ClearBeforeFill = True
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "VOL_CD", True))
        Me.txtData3.Location = New System.Drawing.Point(441, 199)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(60, 18)
        Me.txtData3.TabIndex = 113
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData14
        '
        Me.txtData14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData14.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "LINE_TYPE", True))
        Me.txtData14.DataType = GetType(Short)
        Me.txtData14.Location = New System.Drawing.Point(441, 223)
        Me.txtData14.Name = "txtData14"
        Me.txtData14.Size = New System.Drawing.Size(60, 18)
        Me.txtData14.TabIndex = 112
        Me.txtData14.Tag = Nothing
        Me.txtData14.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "ITEM_NUM", True))
        Me.txtData2.DataType = GetType(Integer)
        Me.txtData2.Location = New System.Drawing.Point(441, 175)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(60, 18)
        Me.txtData2.TabIndex = 111
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData15
        '
        Me.txtData15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData15.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvItemsBindingSource, "BULK_LOAD", True))
        Me.txtData15.DataType = GetType(Boolean)
        Me.txtData15.Location = New System.Drawing.Point(441, 247)
        Me.txtData15.Name = "txtData15"
        Me.txtData15.Size = New System.Drawing.Size(60, 18)
        Me.txtData15.TabIndex = 114
        Me.txtData15.Tag = Nothing
        Me.txtData15.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData15.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmInvItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 458)
        Me.Controls.Add(Me.txtData15)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData14)
        Me.Controls.Add(Me.txtData2)
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
        Me.Controls.Add(Me.txtData20)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.cmdFindInv)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
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
        Me.Controls.Add(Me.lbllabel12)
        Me.Controls.Add(Me.lblLabel13)
        Me.Controls.Add(Me.lblCurInvoice)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.fraSales)
        Me.Controls.Add(Me.scrQty10)
        Me.Controls.Add(Me.scrQty11)
        Me.Controls.Add(Me.scrQty12)
        Me.Controls.Add(Me.scrQty13)
        Me.Controls.Add(Me.scrChange0)
        Me.Controls.Add(Me.scrChange1)
        Me.Controls.Add(Me.scrChange2)
        Me.Controls.Add(Me.scrChange3)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.chkData)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(64, 108)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvItem"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Invoice Items"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cmbCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetVolCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetVolCodes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraSales.ResumeLayout(False)
        Me.fraSales.PerformLayout()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCurrent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChange0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkData As CheckBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optAction4 As RadioButton
    Friend WithEvents optAction3 As RadioButton
    Friend WithEvents optAction2 As RadioButton
    Friend WithEvents optAction1 As RadioButton
    Friend WithEvents optAction0 As RadioButton
    Friend WithEvents scrChange3 As VScrollBar
    Friend WithEvents scrChange2 As VScrollBar
    Friend WithEvents scrChange1 As VScrollBar
    Friend WithEvents scrChange0 As VScrollBar
    Friend WithEvents scrQty13 As VScrollBar
    Friend WithEvents scrQty12 As VScrollBar
    Friend WithEvents scrQty11 As VScrollBar
    Friend WithEvents scrQty10 As VScrollBar
    Friend WithEvents fraSales As GroupBox
    Friend WithEvents optSales1 As RadioButton
    Friend WithEvents optSales2 As RadioButton
    Friend WithEvents optSales0 As RadioButton
    Friend WithEvents lstSales As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurInvoice As Label
    Friend WithEvents lblLabel13 As Label
    Friend WithEvents lbllabel12 As Label
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
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindInv As C1.Win.C1Input.C1Button
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindItem As C1.Win.C1Input.C1Button
    Friend WithEvents txtItemDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData20 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmbCode As C1.Win.C1List.C1Combo
    Friend WithEvents txtMemo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCurrent3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtChange0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData19 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData12 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData13 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTotal As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents DsspGetVolCodes As dsspGetVolCodes
    Friend WithEvents SpGetVolCodesBindingSource As BindingSource
    Friend WithEvents SpGetVolCodesTableAdapter As dsspGetVolCodesTableAdapters.spGetVolCodesTableAdapter
    Friend WithEvents DsspGetSalesmen As dsspGetSalesmen
    Friend WithEvents SpGetSalesmenBindingSource As BindingSource
    Friend WithEvents SpGetSalesmenTableAdapter As dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter
    Friend WithEvents C1EditorToolStripTable1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable
    Friend WithEvents SpGetInvItemsBindingSource As BindingSource
    Friend WithEvents DsspGetInvItems As dsspGetInvItems
    Friend WithEvents SpGetInvItemsTableAdapter As dsspGetInvItemsTableAdapters.spGetInvItemsTableAdapter
    Friend WithEvents SpGetInvNameBindingSource As BindingSource
    Friend WithEvents DsspGetInvName As dsspGetInvName
    Friend WithEvents SpGetInvNameTableAdapter As dsspGetInvNameTableAdapters.spGetInvNameTableAdapter
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData14 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData15 As C1.Win.C1Input.C1TextBox
End Class
