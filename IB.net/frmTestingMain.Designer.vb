<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestingMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingMain))
        Me.C1DataSet1 = New C1.Data.C1DataSet()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        CType(Me.C1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataSet1
        '
        Me.C1DataSet1.BindingContextCtrl = Me
        Me.C1DataSet1.DataLibrary = ""
        Me.C1DataSet1.DataLibraryUrl = ""
        Me.C1DataSet1.DataSetDef = ""
        Me.C1DataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.C1DataSet1.Name = "C1DataSet1"
        Me.C1DataSet1.SchemaClassName = ""
        Me.C1DataSet1.SchemaDef = Nothing
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(45, 174)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.C1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(681, 150)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'C1TextBox1
        '
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.Location = New System.Drawing.Point(45, 63)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox1.TabIndex = 1
        Me.C1TextBox1.Tag = Nothing
        Me.C1TextBox1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1TextBox2
        '
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox2.Location = New System.Drawing.Point(45, 100)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox2.TabIndex = 2
        Me.C1TextBox2.Tag = Nothing
        Me.C1TextBox2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BackColor = System.Drawing.Color.Transparent
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.ForeColor = System.Drawing.Color.Black
        Me.C1Label1.Location = New System.Drawing.Point(48, 84)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(52, 13)
        Me.C1Label1.TabIndex = 3
        Me.C1Label1.Tag = Nothing
        Me.C1Label1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BackColor = System.Drawing.Color.Transparent
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.ForeColor = System.Drawing.Color.Black
        Me.C1Label2.Location = New System.Drawing.Point(48, 47)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(52, 13)
        Me.C1Label2.TabIndex = 4
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmTestingMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1Label2)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1TextBox2)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTestingMain"
        Me.Text = "frmTestingMain"
        CType(Me.C1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1DataSet1 As C1.Data.C1DataSet
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
End Class
