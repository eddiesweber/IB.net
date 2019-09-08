<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommEdit))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.datRange1 = New C1.Win.Calendar.C1DateEdit()
        Me.datRange0 = New C1.Win.Calendar.C1DateEdit()
        Me.optSort1 = New System.Windows.Forms.RadioButton()
        Me.optSort0 = New System.Windows.Forms.RadioButton()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.cmdFind = New C1.Win.C1Input.C1Button()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        Me.chkAllCust = New System.Windows.Forms.CheckBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.chkAllSales = New System.Windows.Forms.CheckBox()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.SpGetSalesmenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetSalesmen = New IB.net.dsspGetSalesmen()
        Me.SpGetSalesmenTableAdapter = New IB.net.dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter()
        Me.TDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommission = New IB.net.dsCommission()
        Me.CommissionTableAdapter = New IB.net.dsCommissionTableAdapters.CommissionTableAdapter()
        Me.ddSales = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.SpGetSalesmenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCommRate = New IB.net.dsCommRate()
        Me.CommRateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommRateTableAdapter = New IB.net.dsCommRateTableAdapters.CommRateTableAdapter()
        CType(Me.datRange1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datRange0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetSalesmenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCommRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommRateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datRange1
        '
        Me.datRange1.AllowSpinLoop = False
        Me.datRange1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datRange1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datRange1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datRange1.Location = New System.Drawing.Point(410, 47)
        Me.datRange1.Name = "datRange1"
        Me.datRange1.Size = New System.Drawing.Size(125, 18)
        Me.datRange1.TabIndex = 41
        Me.datRange1.Tag = Nothing
        '
        'datRange0
        '
        Me.datRange0.AllowSpinLoop = False
        Me.datRange0.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datRange0.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datRange0.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datRange0.Location = New System.Drawing.Point(245, 47)
        Me.datRange0.Name = "datRange0"
        Me.datRange0.Size = New System.Drawing.Size(125, 18)
        Me.datRange0.TabIndex = 40
        Me.datRange0.Tag = Nothing
        '
        'optSort1
        '
        Me.optSort1.AutoSize = True
        Me.optSort1.Location = New System.Drawing.Point(325, 73)
        Me.optSort1.Name = "optSort1"
        Me.optSort1.Size = New System.Drawing.Size(69, 17)
        Me.optSort1.TabIndex = 39
        Me.optSort1.Text = "Customer"
        Me.optSort1.UseVisualStyleBackColor = True
        '
        'optSort0
        '
        Me.optSort0.AutoSize = True
        Me.optSort0.Checked = True
        Me.optSort0.Location = New System.Drawing.Point(245, 73)
        Me.optSort0.Name = "optSort0"
        Me.optSort0.Size = New System.Drawing.Size(71, 17)
        Me.optSort0.TabIndex = 38
        Me.optSort0.TabStop = True
        Me.optSort0.Text = "Salesman"
        Me.optSort0.UseVisualStyleBackColor = True
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(175, 75)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel3.TabIndex = 37
        Me.lblLabel3.Text = "Sort By:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(378, 49)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(23, 13)
        Me.lblLabel2.TabIndex = 36
        Me.lblLabel2.Text = "To:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(175, 49)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(64, 13)
        Me.lblLabel4.TabIndex = 35
        Me.lblLabel4.Text = "Dates From:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(425, 18)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(54, 13)
        Me.lblCurCust.TabIndex = 34
        Me.lblCurCust.Text = "lblCurCust"
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(319, 12)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 25)
        Me.cmdFind.TabIndex = 33
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        Me.cmdFind.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFind.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(580, 15)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 32
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkAllCust
        '
        Me.chkAllCust.AutoSize = True
        Me.chkAllCust.Checked = True
        Me.chkAllCust.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllCust.Location = New System.Drawing.Point(245, 14)
        Me.chkAllCust.Name = "chkAllCust"
        Me.chkAllCust.Size = New System.Drawing.Size(37, 17)
        Me.chkAllCust.TabIndex = 31
        Me.chkAllCust.Text = "All"
        Me.chkAllCust.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(175, 15)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel1.TabIndex = 30
        Me.lblLabel1.Text = "Customer:"
        '
        'chkAllSales
        '
        Me.chkAllSales.AutoSize = True
        Me.chkAllSales.Checked = True
        Me.chkAllSales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAllSales.Location = New System.Drawing.Point(101, 14)
        Me.chkAllSales.Name = "chkAllSales"
        Me.chkAllSales.Size = New System.Drawing.Size(37, 17)
        Me.chkAllSales.TabIndex = 29
        Me.chkAllSales.Text = "All"
        Me.chkAllSales.UseVisualStyleBackColor = True
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(15, 15)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(68, 13)
        Me.lblLabel0.TabIndex = 28
        Me.lblLabel0.Text = "Salesperson:"
        '
        'lstSales
        '
        Me.lstSales.DataSource = Me.SpGetSalesmenBindingSource
        Me.lstSales.DisplayMember = "Sales"
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(15, 35)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(120, 56)
        Me.lstSales.TabIndex = 42
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
        'SpGetSalesmenTableAdapter
        '
        Me.SpGetSalesmenTableAdapter.ClearBeforeFill = True
        '
        'TDBGrid1
        '
        Me.TDBGrid1.AllowAddNew = True
        Me.TDBGrid1.AllowDelete = True
        Me.TDBGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDBGrid1.DataSource = Me.CommissionBindingSource
        Me.TDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid1.Images.Add(CType(resources.GetObject("TDBGrid1.Images"), System.Drawing.Image))
        Me.TDBGrid1.Location = New System.Drawing.Point(15, 100)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.TDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.TDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.TDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid1.Size = New System.Drawing.Size(650, 585)
        Me.TDBGrid1.TabIndex = 44
        Me.TDBGrid1.UseCompatibleTextRendering = False
        Me.TDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.TDBGrid1.PropBag = resources.GetString("TDBGrid1.PropBag")
        '
        'CommissionBindingSource
        '
        Me.CommissionBindingSource.DataMember = "Commission"
        Me.CommissionBindingSource.DataSource = Me.DsCommission
        '
        'DsCommission
        '
        Me.DsCommission.DataSetName = "dsCommission"
        Me.DsCommission.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommissionTableAdapter
        '
        Me.CommissionTableAdapter.ClearBeforeFill = True
        '
        'ddSales
        '
        Me.ddSales.AllowColMove = True
        Me.ddSales.AllowColSelect = True
        Me.ddSales.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.ddSales.AlternatingRows = False
        Me.ddSales.CaptionStyle = Style1
        Me.ddSales.ColumnCaptionHeight = 17
        Me.ddSales.ColumnFooterHeight = 17
        Me.ddSales.ColumnSelectorStyle = Style2
        Me.ddSales.DataSource = Me.SpGetSalesmenBindingSource1
        Me.ddSales.DisplayMember = "FSALESNUM"
        Me.ddSales.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
        Me.ddSales.EvenRowStyle = Style3
        Me.ddSales.FetchRowStyles = False
        Me.ddSales.FooterStyle = Style4
        Me.ddSales.HeadingStyle = Style5
        Me.ddSales.HighLightRowStyle = Style6
        Me.ddSales.Images.Add(CType(resources.GetObject("ddSales.Images"), System.Drawing.Image))
        Me.ddSales.Location = New System.Drawing.Point(23, 108)
        Me.ddSales.Name = "ddSales"
        Me.ddSales.OddRowStyle = Style7
        Me.ddSales.RecordSelectorStyle = Style8
        Me.ddSales.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ddSales.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.ddSales.RowSelectorStyle = Style9
        Me.ddSales.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ddSales.ScrollTips = False
        Me.ddSales.Size = New System.Drawing.Size(100, 150)
        Me.ddSales.Style = Style10
        Me.ddSales.TabIndex = 45
        Me.ddSales.TabStop = False
        Me.ddSales.UseCompatibleTextRendering = False
        Me.ddSales.ValueMember = "FSALESNUM"
        Me.ddSales.Visible = False
        Me.ddSales.PropBag = resources.GetString("ddSales.PropBag")
        '
        'SpGetSalesmenBindingSource1
        '
        Me.SpGetSalesmenBindingSource1.DataMember = "spGetSalesmen"
        Me.SpGetSalesmenBindingSource1.DataSource = Me.DsspGetSalesmen
        '
        'DsCommRate
        '
        Me.DsCommRate.DataSetName = "dsCommRate"
        Me.DsCommRate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommRateBindingSource
        '
        Me.CommRateBindingSource.DataMember = "CommRate"
        Me.CommRateBindingSource.DataSource = Me.DsCommRate
        '
        'CommRateTableAdapter
        '
        Me.CommRateTableAdapter.ClearBeforeFill = True
        '
        'frmCommEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 701)
        Me.Controls.Add(Me.ddSales)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.lstSales)
        Me.Controls.Add(Me.datRange1)
        Me.Controls.Add(Me.datRange0)
        Me.Controls.Add(Me.optSort1)
        Me.Controls.Add(Me.optSort0)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.chkAllCust)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.chkAllSales)
        Me.Controls.Add(Me.lblLabel0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommEdit"
        Me.Text = "Edit Commissions"
        CType(Me.datRange1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datRange0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetSalesmenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCommRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommRateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datRange1 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datRange0 As C1.Win.Calendar.C1DateEdit
    Friend WithEvents optSort1 As RadioButton
    Friend WithEvents optSort0 As RadioButton
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents cmdFind As C1.Win.C1Input.C1Button
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
    Friend WithEvents chkAllCust As CheckBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents chkAllSales As CheckBox
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lstSales As ListBox
    Friend WithEvents DsspGetSalesmen As dsspGetSalesmen
    Friend WithEvents SpGetSalesmenBindingSource As BindingSource
    Friend WithEvents SpGetSalesmenTableAdapter As dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter
    Friend WithEvents TDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsCommission As dsCommission
    Friend WithEvents CommissionBindingSource As BindingSource
    Friend WithEvents CommissionTableAdapter As dsCommissionTableAdapters.CommissionTableAdapter
    Friend WithEvents ddSales As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents SpGetSalesmenBindingSource1 As BindingSource
    Friend WithEvents DsCommRate As dsCommRate
    Friend WithEvents CommRateBindingSource As BindingSource
    Friend WithEvents CommRateTableAdapter As dsCommRateTableAdapters.CommRateTableAdapter
End Class
