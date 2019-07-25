<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouteEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRouteEdit))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstDays1 = New System.Windows.Forms.ListBox()
        Me.lstDays0 = New System.Windows.Forms.ListBox()
        Me.fraSort = New System.Windows.Forms.GroupBox()
        Me.optSort0 = New System.Windows.Forms.RadioButton()
        Me.optSort1 = New System.Windows.Forms.RadioButton()
        Me.optSort2 = New System.Windows.Forms.RadioButton()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        Me.TDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetRouteTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetRouteTemp = New IB.net.dsspGetRouteTemp()
        Me.SpGetRouteTempTableAdapter = New IB.net.dsspGetRouteTempTableAdapters.spGetRouteTempTableAdapter()
        Me.fraSort.SuspendLayout()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetRouteTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetRouteTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'lstDays1
        '
        Me.lstDays1.ForeColor = System.Drawing.Color.Maroon
        Me.lstDays1.FormattingEnabled = True
        Me.lstDays1.Location = New System.Drawing.Point(666, 12)
        Me.lstDays1.Name = "lstDays1"
        Me.lstDays1.Size = New System.Drawing.Size(53, 225)
        Me.lstDays1.TabIndex = 7
        '
        'lstDays0
        '
        Me.lstDays0.ForeColor = System.Drawing.Color.Maroon
        Me.lstDays0.FormattingEnabled = True
        Me.lstDays0.Location = New System.Drawing.Point(666, 248)
        Me.lstDays0.Name = "lstDays0"
        Me.lstDays0.Size = New System.Drawing.Size(53, 134)
        Me.lstDays0.TabIndex = 6
        '
        'fraSort
        '
        Me.fraSort.Controls.Add(Me.optSort0)
        Me.fraSort.Controls.Add(Me.optSort1)
        Me.fraSort.Controls.Add(Me.optSort2)
        Me.fraSort.Location = New System.Drawing.Point(7, 7)
        Me.fraSort.Name = "fraSort"
        Me.fraSort.Size = New System.Drawing.Size(274, 50)
        Me.fraSort.TabIndex = 0
        Me.fraSort.TabStop = False
        Me.fraSort.Text = "&Sort by:"
        '
        'optSort0
        '
        Me.optSort0.AutoSize = True
        Me.optSort0.Location = New System.Drawing.Point(14, 21)
        Me.optSort0.Name = "optSort0"
        Me.optSort0.Size = New System.Drawing.Size(78, 17)
        Me.optSort0.TabIndex = 1
        Me.optSort0.TabStop = True
        Me.optSort0.Text = "Route/&Day"
        Me.optSort0.UseVisualStyleBackColor = True
        '
        'optSort1
        '
        Me.optSort1.AutoSize = True
        Me.optSort1.Location = New System.Drawing.Point(105, 21)
        Me.optSort1.Name = "optSort1"
        Me.optSort1.Size = New System.Drawing.Size(88, 17)
        Me.optSort1.TabIndex = 2
        Me.optSort1.TabStop = True
        Me.optSort1.Text = "&Week/Route"
        Me.optSort1.UseVisualStyleBackColor = True
        '
        'optSort2
        '
        Me.optSort2.AutoSize = True
        Me.optSort2.Location = New System.Drawing.Point(203, 21)
        Me.optSort2.Name = "optSort2"
        Me.optSort2.Size = New System.Drawing.Size(40, 17)
        Me.optSort2.TabIndex = 3
        Me.optSort2.TabStop = True
        Me.optSort2.Text = "&Zip"
        Me.optSort2.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(546, 15)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 23)
        Me.cmdClose.TabIndex = 91
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TDBGrid1
        '
        Me.TDBGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDBGrid1.DataSource = Me.SpGetRouteTempBindingSource
        Me.TDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid1.Images.Add(CType(resources.GetObject("TDBGrid1.Images"), System.Drawing.Image))
        Me.TDBGrid1.Location = New System.Drawing.Point(10, 63)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.TDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.TDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.TDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid1.Size = New System.Drawing.Size(620, 319)
        Me.TDBGrid1.TabIndex = 92
        Me.TDBGrid1.UseCompatibleTextRendering = False
        Me.TDBGrid1.PropBag = resources.GetString("TDBGrid1.PropBag")
        '
        'SpGetRouteTempBindingSource
        '
        Me.SpGetRouteTempBindingSource.DataMember = "spGetRouteTemp"
        Me.SpGetRouteTempBindingSource.DataSource = Me.DsspGetRouteTemp
        '
        'DsspGetRouteTemp
        '
        Me.DsspGetRouteTemp.DataSetName = "dsspGetRouteTemp"
        Me.DsspGetRouteTemp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetRouteTempTableAdapter
        '
        Me.SpGetRouteTempTableAdapter.ClearBeforeFill = True
        '
        'frmRouteEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 394)
        Me.Controls.Add(Me.TDBGrid1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.fraSort)
        Me.Controls.Add(Me.lstDays0)
        Me.Controls.Add(Me.lstDays1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(76, 103)
        Me.Name = "frmRouteEdit"
        Me.Text = "Edit Routing"
        Me.fraSort.ResumeLayout(False)
        Me.fraSort.PerformLayout()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetRouteTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetRouteTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lstDays1 As ListBox
    Friend WithEvents lstDays0 As ListBox
    Friend WithEvents fraSort As GroupBox
    Friend WithEvents optSort2 As RadioButton
    Friend WithEvents optSort1 As RadioButton
    Friend WithEvents optSort0 As RadioButton
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
    Friend WithEvents TDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetRouteTempBindingSource As BindingSource
    Friend WithEvents DsspGetRouteTemp As dsspGetRouteTemp
    Friend WithEvents SpGetRouteTempTableAdapter As dsspGetRouteTempTableAdapters.spGetRouteTempTableAdapter
End Class
