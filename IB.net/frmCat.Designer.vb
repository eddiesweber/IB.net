<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCat))
        Me.DsCategoryMaster = New IB.net.dsCategoryMaster()
        Me.CategoryMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryMasterTableAdapter = New IB.net.dsCategoryMasterTableAdapters.CategoryMasterTableAdapter()
        Me.DsTaxMaster = New IB.net.dsTaxMaster()
        Me.TaxMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaxMasterTableAdapter = New IB.net.dsTaxMasterTableAdapters.TaxMasterTableAdapter()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.DsCategoryMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTaxMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsCategoryMaster
        '
        Me.DsCategoryMaster.DataSetName = "dsCategoryMaster"
        Me.DsCategoryMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryMasterBindingSource
        '
        Me.CategoryMasterBindingSource.DataMember = "CategoryMaster"
        Me.CategoryMasterBindingSource.DataSource = Me.DsCategoryMaster
        '
        'CategoryMasterTableAdapter
        '
        Me.CategoryMasterTableAdapter.ClearBeforeFill = True
        '
        'DsTaxMaster
        '
        Me.DsTaxMaster.DataSetName = "dsTaxMaster"
        Me.DsTaxMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaxMasterBindingSource
        '
        Me.TaxMasterBindingSource.DataMember = "TaxMaster"
        Me.TaxMasterBindingSource.DataSource = Me.DsTaxMaster
        '
        'TaxMasterTableAdapter
        '
        Me.TaxMasterTableAdapter.ClearBeforeFill = True
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.AllowDelete = True
        Me.C1TrueDBGrid1.AlternatingRows = True
        Me.C1TrueDBGrid1.DataSource = Me.CategoryMasterBindingSource
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(861, 211)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'frmCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 211)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "frmCat"
        Me.Text = "frmCat"
        CType(Me.DsCategoryMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTaxMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsCategoryMaster As dsCategoryMaster
    Friend WithEvents CategoryMasterBindingSource As BindingSource
    Friend WithEvents CategoryMasterTableAdapter As dsCategoryMasterTableAdapters.CategoryMasterTableAdapter
    Friend WithEvents DsTaxMaster As dsTaxMaster
    Friend WithEvents TaxMasterBindingSource As BindingSource
    Friend WithEvents TaxMasterTableAdapter As dsTaxMasterTableAdapters.TaxMasterTableAdapter
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
