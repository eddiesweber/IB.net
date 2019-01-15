<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouteMast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRouteMast))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.RouteMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsRouteMaster = New IB.net.dsRouteMaster()
        Me.RouteMasterTableAdapter = New IB.net.dsRouteMasterTableAdapters.RouteMasterTableAdapter()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RouteMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsRouteMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.AllowDelete = True
        Me.C1TrueDBGrid1.AlternatingRows = True
        Me.C1TrueDBGrid1.DataSource = Me.RouteMasterBindingSource
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
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(334, 98)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'RouteMasterBindingSource
        '
        Me.RouteMasterBindingSource.DataMember = "RouteMaster"
        Me.RouteMasterBindingSource.DataSource = Me.DsRouteMaster
        '
        'DsRouteMaster
        '
        Me.DsRouteMaster.DataSetName = "dsRouteMaster"
        Me.DsRouteMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RouteMasterTableAdapter
        '
        Me.RouteMasterTableAdapter.ClearBeforeFill = True
        '
        'frmRouteMast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 98)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Location = New System.Drawing.Point(147, 165)
        Me.Name = "frmRouteMast"
        Me.Text = "Route Master"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RouteMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsRouteMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsRouteMaster As dsRouteMaster
    Friend WithEvents RouteMasterBindingSource As BindingSource
    Friend WithEvents RouteMasterTableAdapter As dsRouteMasterTableAdapters.RouteMasterTableAdapter
End Class
