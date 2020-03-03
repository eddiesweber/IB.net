<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TestingHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingHeaderWithTesters = New IB.net.dsTestingHeaderWithTesters()
        Me.TestingHeaderTableAdapter = New IB.net.dsTestingHeaderWithTestersTableAdapters.TestingHeaderTableAdapter()
        Me.C1List1 = New C1.Win.C1List.C1List()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingHeaderWithTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowAddNew = True
        Me.C1TrueDBGrid1.AllowDelete = True
        Me.C1TrueDBGrid1.DataSource = Me.TestingHeaderBindingSource
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.C1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(593, 150)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'TestingHeaderBindingSource
        '
        Me.TestingHeaderBindingSource.DataMember = "TestingHeader"
        Me.TestingHeaderBindingSource.DataSource = Me.DsTestingHeaderWithTesters
        '
        'DsTestingHeaderWithTesters
        '
        Me.DsTestingHeaderWithTesters.DataSetName = "dsTestingHeaderWithTesters"
        Me.DsTestingHeaderWithTesters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestingHeaderTableAdapter
        '
        Me.TestingHeaderTableAdapter.ClearBeforeFill = True
        '
        'C1List1
        '
        Me.C1List1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.ColumnWidth = 100
        Me.C1List1.DataSource = Me.TestingHeaderBindingSource
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("C1List1.Images"), System.Drawing.Image))
        Me.C1List1.Location = New System.Drawing.Point(107, 201)
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1List1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1List1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1List1.PrintInfo.PageSettings = CType(resources.GetObject("C1List1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ShowHeaderCheckBox = False
        Me.C1List1.Size = New System.Drawing.Size(231, 150)
        Me.C1List1.TabIndex = 1
        Me.C1List1.Text = "C1List1"
        Me.C1List1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.C1List1.PropBag = resources.GetString("C1List1.PropBag")
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1List1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingHeaderWithTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsTestingHeaderWithTesters As dsTestingHeaderWithTesters
    Friend WithEvents TestingHeaderBindingSource As BindingSource
    Friend WithEvents TestingHeaderTableAdapter As dsTestingHeaderWithTestersTableAdapters.TestingHeaderTableAdapter
    Friend WithEvents C1List1 As C1.Win.C1List.C1List
End Class
