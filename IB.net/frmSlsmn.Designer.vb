﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSlsmn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSlsmn))
        Me.grdData = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SalesmanMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSalesmanMaster = New IB.net.dsSalesmanMaster()
        Me.SalesmanMasterTableAdapter = New IB.net.dsSalesmanMasterTableAdapters.SalesmanMasterTableAdapter()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesmanMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSalesmanMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.AllowAddNew = True
        Me.grdData.AllowDelete = True
        Me.grdData.DataSource = Me.SalesmanMasterBindingSource
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdData.Images.Add(CType(resources.GetObject("grdData.Images"), System.Drawing.Image))
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Name = "grdData"
        Me.grdData.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdData.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdData.PreviewInfo.ZoomFactor = 75.0R
        Me.grdData.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdData.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdData.PrintInfo.PageSettings = CType(resources.GetObject("grdData.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdData.Size = New System.Drawing.Size(431, 361)
        Me.grdData.TabIndex = 0
        Me.grdData.UseCompatibleTextRendering = False
        Me.grdData.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdData.PropBag = resources.GetString("grdData.PropBag")
        '
        'SalesmanMasterBindingSource
        '
        Me.SalesmanMasterBindingSource.DataMember = "SalesmanMaster"
        Me.SalesmanMasterBindingSource.DataSource = Me.DsSalesmanMaster
        '
        'DsSalesmanMaster
        '
        Me.DsSalesmanMaster.DataSetName = "dsSalesmanMaster"
        Me.DsSalesmanMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesmanMasterTableAdapter
        '
        Me.SalesmanMasterTableAdapter.ClearBeforeFill = True
        '
        'frmSlsmn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 361)
        Me.Controls.Add(Me.grdData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSlsmn"
        Me.Text = "Add/Edit Salespeople"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesmanMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSalesmanMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdData As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsSalesmanMaster As dsSalesmanMaster
    Friend WithEvents SalesmanMasterBindingSource As BindingSource
    Friend WithEvents SalesmanMasterTableAdapter As dsSalesmanMasterTableAdapters.SalesmanMasterTableAdapter
End Class
