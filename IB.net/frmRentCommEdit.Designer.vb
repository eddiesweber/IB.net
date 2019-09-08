<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRentCommEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRentCommEdit))
        Me.lstSales2 = New System.Windows.Forms.ListBox()
        Me.SpGetSalesmenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetSalesmen = New IB.net.dsspGetSalesmen()
        Me.optCust1 = New System.Windows.Forms.RadioButton()
        Me.optCust0 = New System.Windows.Forms.RadioButton()
        Me.SpGetSalesmenTableAdapter = New IB.net.dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        Me.TDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.RevenueByCustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsRevenuebyCust = New IB.net.dsRevenuebyCust()
        Me.RevenueByCustTableAdapter = New IB.net.dsRevenuebyCustTableAdapters.RevenueByCustTableAdapter()
        Me.DsRevenuebyCust_Change = New IB.net.dsRevenuebyCust_Change()
        Me.RevenueByCust_ChangeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RevenueByCust_ChangeTableAdapter = New IB.net.dsRevenuebyCust_ChangeTableAdapters.RevenueByCustTableAdapter()
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevenueByCustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRevenuebyCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRevenuebyCust_Change, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevenueByCust_ChangeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstSales2
        '
        Me.lstSales2.DataSource = Me.SpGetSalesmenBindingSource
        Me.lstSales2.DisplayMember = "FSALESNUM"
        Me.lstSales2.FormattingEnabled = True
        Me.lstSales2.Location = New System.Drawing.Point(620, 50)
        Me.lstSales2.Name = "lstSales2"
        Me.lstSales2.Size = New System.Drawing.Size(43, 82)
        Me.lstSales2.TabIndex = 4
        Me.lstSales2.ValueMember = "FSALESNUM"
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
        'optCust1
        '
        Me.optCust1.AutoSize = True
        Me.optCust1.Location = New System.Drawing.Point(120, 19)
        Me.optCust1.Name = "optCust1"
        Me.optCust1.Size = New System.Drawing.Size(92, 17)
        Me.optCust1.TabIndex = 1
        Me.optCust1.TabStop = True
        Me.optCust1.Text = "&Changed Only"
        Me.optCust1.UseVisualStyleBackColor = True
        '
        'optCust0
        '
        Me.optCust0.AutoSize = True
        Me.optCust0.Location = New System.Drawing.Point(15, 19)
        Me.optCust0.Name = "optCust0"
        Me.optCust0.Size = New System.Drawing.Size(88, 17)
        Me.optCust0.TabIndex = 0
        Me.optCust0.TabStop = True
        Me.optCust0.Text = "&All Customers"
        Me.optCust0.UseVisualStyleBackColor = True
        '
        'SpGetSalesmenTableAdapter
        '
        Me.SpGetSalesmenTableAdapter.ClearBeforeFill = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(529, 15)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 18
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TDBGrid1
        '
        Me.TDBGrid1.AllowAddNew = True
        Me.TDBGrid1.AllowDelete = True
        Me.TDBGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDBGrid1.DataSource = Me.RevenueByCustBindingSource
        Me.TDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid1.Images.Add(CType(resources.GetObject("TDBGrid1.Images"), System.Drawing.Image))
        Me.TDBGrid1.Location = New System.Drawing.Point(15, 50)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.TDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.TDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.TDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid1.Size = New System.Drawing.Size(599, 332)
        Me.TDBGrid1.TabIndex = 19
        Me.TDBGrid1.UseCompatibleTextRendering = False
        Me.TDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.TDBGrid1.PropBag = resources.GetString("TDBGrid1.PropBag")
        '
        'RevenueByCustBindingSource
        '
        Me.RevenueByCustBindingSource.DataMember = "RevenueByCust"
        Me.RevenueByCustBindingSource.DataSource = Me.DsRevenuebyCust
        '
        'DsRevenuebyCust
        '
        Me.DsRevenuebyCust.DataSetName = "dsRevenuebyCust"
        Me.DsRevenuebyCust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RevenueByCustTableAdapter
        '
        Me.RevenueByCustTableAdapter.ClearBeforeFill = True
        '
        'DsRevenuebyCust_Change
        '
        Me.DsRevenuebyCust_Change.DataSetName = "dsRevenuebyCust_Change"
        Me.DsRevenuebyCust_Change.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RevenueByCust_ChangeBindingSource
        '
        Me.RevenueByCust_ChangeBindingSource.DataMember = "RevenueByCust"
        Me.RevenueByCust_ChangeBindingSource.DataSource = Me.DsRevenuebyCust_Change
        '
        'RevenueByCust_ChangeTableAdapter
        '
        Me.RevenueByCust_ChangeTableAdapter.ClearBeforeFill = True
        '
        'frmRentCommEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 402)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.optCust0)
        Me.Controls.Add(Me.optCust1)
        Me.Controls.Add(Me.lstSales2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(55, 95)
        Me.Name = "frmRentCommEdit"
        Me.Text = "Edit Rental Commissions"
        CType(Me.SpGetSalesmenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetSalesmen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevenueByCustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRevenuebyCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRevenuebyCust_Change, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevenueByCust_ChangeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSales2 As ListBox
    Friend WithEvents optCust1 As RadioButton
    Friend WithEvents optCust0 As RadioButton
    Friend WithEvents DsspGetSalesmen As dsspGetSalesmen
    Friend WithEvents SpGetSalesmenBindingSource As BindingSource
    Friend WithEvents SpGetSalesmenTableAdapter As dsspGetSalesmenTableAdapters.spGetSalesmenTableAdapter
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
    Friend WithEvents TDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsRevenuebyCust As dsRevenuebyCust
    Friend WithEvents RevenueByCustBindingSource As BindingSource
    Friend WithEvents RevenueByCustTableAdapter As dsRevenuebyCustTableAdapters.RevenueByCustTableAdapter
    Friend WithEvents DsRevenuebyCust_Change As dsRevenuebyCust_Change
    Friend WithEvents RevenueByCust_ChangeBindingSource As BindingSource
    Friend WithEvents RevenueByCust_ChangeTableAdapter As dsRevenuebyCust_ChangeTableAdapters.RevenueByCustTableAdapter
End Class
