<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvHist))
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.SpGetInvHistHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvHistHeader = New IB.net.dsspGetInvHistHeader()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.TDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetInvoiceHist2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvoiceHist2 = New IB.net.dsspGetInvoiceHist2()
        Me.SpGetInvoiceHist2TableAdapter = New IB.net.dsspGetInvoiceHist2TableAdapters.spGetInvoiceHist2TableAdapter()
        Me.SpGetInvHistHeaderTableAdapter = New IB.net.dsspGetInvHistHeaderTableAdapters.spGetInvHistHeaderTableAdapter()
        Me.cmdSearch = New C1.Win.C1Input.C1Button()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvHistHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvHistHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvoiceHist2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvoiceHist2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(180, 106)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(72, 13)
        Me.lblLabel8.TabIndex = 13
        Me.lblLabel8.Text = "Invoice Total:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(10, 106)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel7.TabIndex = 12
        Me.lblLabel7.Text = "Pay By:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(10, 92)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(52, 13)
        Me.lblLabel6.TabIndex = 11
        Me.lblLabel6.Text = "Tracking:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(10, 78)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel5.TabIndex = 10
        Me.lblLabel5.Text = "Tax Code:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(10, 64)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(64, 13)
        Me.lblLabel4.TabIndex = 9
        Me.lblLabel4.Text = "Route/stop:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(10, 36)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel3.TabIndex = 8
        Me.lblLabel3.Text = "Customer:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(218, 14)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel2.TabIndex = 7
        Me.lblLabel2.Text = "Date:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(10, 13)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Invoice:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(10, 50)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 23
        Me.lblLabel0.Text = "Dept:"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(387, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 84
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(387, 41)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 25)
        Me.cmdPrint.TabIndex = 85
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtInvoice
        '
        Me.txtInvoice.ForeColor = System.Drawing.Color.Navy
        Me.txtInvoice.Location = New System.Drawing.Point(60, 10)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(75, 20)
        Me.txtInvoice.TabIndex = 86
        '
        'txtData1
        '
        Me.txtData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "BILL_NAME", True))
        Me.txtData1.Location = New System.Drawing.Point(124, 36)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(190, 13)
        Me.txtData1.TabIndex = 95
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetInvHistHeaderBindingSource
        '
        Me.SpGetInvHistHeaderBindingSource.DataMember = "spGetInvHistHeader"
        Me.SpGetInvHistHeaderBindingSource.DataSource = Me.DsspGetInvHistHeader
        '
        'DsspGetInvHistHeader
        '
        Me.DsspGetInvHistHeader.DataSetName = "dsspGetInvHistHeader"
        Me.DsspGetInvHistHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData3
        '
        Me.txtData3.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData3.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "ROUTE", True))
        Me.txtData3.DataType = GetType(Short)
        Me.txtData3.Location = New System.Drawing.Point(75, 64)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(50, 13)
        Me.txtData3.TabIndex = 96
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData4.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "SEQUENCE", True))
        Me.txtData4.DataType = GetType(Single)
        Me.txtData4.Location = New System.Drawing.Point(141, 64)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(50, 13)
        Me.txtData4.TabIndex = 97
        Me.txtData4.Tag = Nothing
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData9
        '
        Me.txtData9.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData9.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "DATE", True))
        Me.txtData9.DataType = GetType(Date)
        Me.txtData9.Location = New System.Drawing.Point(254, 14)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(60, 13)
        Me.txtData9.TabIndex = 98
        Me.txtData9.Tag = Nothing
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData0.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "CUST_NUM", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Location = New System.Drawing.Point(75, 36)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(50, 13)
        Me.txtData0.TabIndex = 100
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData2.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "DEPT", True))
        Me.txtData2.DataType = GetType(Short)
        Me.txtData2.Location = New System.Drawing.Point(75, 50)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(50, 13)
        Me.txtData2.TabIndex = 101
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData10.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "DEL_NAME", True))
        Me.txtData10.Location = New System.Drawing.Point(124, 50)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(190, 13)
        Me.txtData10.TabIndex = 102
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData5.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "TAX_LOCODE", True))
        Me.txtData5.Location = New System.Drawing.Point(75, 78)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(50, 13)
        Me.txtData5.TabIndex = 103
        Me.txtData5.Tag = Nothing
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData6.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "TAX_ST", True))
        Me.txtData6.Location = New System.Drawing.Point(141, 78)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(50, 13)
        Me.txtData6.TabIndex = 104
        Me.txtData6.Tag = Nothing
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1TextBox1
        '
        Me.C1TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.C1TextBox1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "TRACK", True))
        Me.C1TextBox1.Location = New System.Drawing.Point(75, 92)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(239, 13)
        Me.C1TextBox1.TabIndex = 105
        Me.C1TextBox1.Tag = Nothing
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData8
        '
        Me.txtData8.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData8.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "TOTAL", True))
        Me.txtData8.DataType = GetType(Decimal)
        Me.txtData8.Location = New System.Drawing.Point(254, 96)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(60, 13)
        Me.txtData8.TabIndex = 106
        Me.txtData8.Tag = Nothing
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtData7.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetInvHistHeaderBindingSource, "PAYBY", True))
        Me.txtData7.Location = New System.Drawing.Point(75, 106)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(50, 13)
        Me.txtData7.TabIndex = 107
        Me.txtData7.Tag = Nothing
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TDBGrid1
        '
        Me.TDBGrid1.DataSource = Me.SpGetInvoiceHist2BindingSource
        Me.TDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid1.Location = New System.Drawing.Point(13, 125)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.TDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.TDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.TDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid1.PropBag = resources.GetString("TDBGrid1.PropBag")
        Me.TDBGrid1.Size = New System.Drawing.Size(459, 225)
        Me.TDBGrid1.TabIndex = 108
        Me.TDBGrid1.UseCompatibleTextRendering = False
        Me.TDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'SpGetInvoiceHist2BindingSource
        '
        Me.SpGetInvoiceHist2BindingSource.DataMember = "spGetInvoiceHist2"
        Me.SpGetInvoiceHist2BindingSource.DataSource = Me.DsspGetInvoiceHist2
        '
        'DsspGetInvoiceHist2
        '
        Me.DsspGetInvoiceHist2.DataSetName = "dsspGetInvoiceHist2"
        Me.DsspGetInvoiceHist2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetInvoiceHist2TableAdapter
        '
        Me.SpGetInvoiceHist2TableAdapter.ClearBeforeFill = True
        '
        'SpGetInvHistHeaderTableAdapter
        '
        Me.SpGetInvHistHeaderTableAdapter.ClearBeforeFill = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(141, 10)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(50, 20)
        Me.cmdSearch.TabIndex = 109
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        Me.cmdSearch.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmInvHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 402)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(113, 151)
        Me.Name = "frmInvHist"
        Me.Text = "View Historic Invoice"
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvHistHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvHistHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvoiceHist2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvoiceHist2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
    Friend WithEvents txtInvoice As TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents TDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetInvoiceHist2BindingSource As BindingSource
    Friend WithEvents DsspGetInvoiceHist2 As dsspGetInvoiceHist2
    Friend WithEvents SpGetInvoiceHist2TableAdapter As dsspGetInvoiceHist2TableAdapters.spGetInvoiceHist2TableAdapter
    Friend WithEvents SpGetInvHistHeaderBindingSource As BindingSource
    Friend WithEvents DsspGetInvHistHeader As dsspGetInvHistHeader
    Friend WithEvents SpGetInvHistHeaderTableAdapter As dsspGetInvHistHeaderTableAdapters.spGetInvHistHeaderTableAdapter
    Friend WithEvents cmdSearch As C1.Win.C1Input.C1Button
End Class
