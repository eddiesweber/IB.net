<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInvPhys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvPhys))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optSort0 = New System.Windows.Forms.RadioButton()
        Me.optSort1 = New System.Windows.Forms.RadioButton()
        Me.optSort2 = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.grdItemTemp = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.DsItemTemp = New IB.net.dsItemTemp()
        Me.ItemTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTempTableAdapter = New IB.net.dsItemTempTableAdapters.ItemTempTableAdapter()
        Me.Frame1.SuspendLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItemTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optSort0)
        Me.Frame1.Controls.Add(Me.optSort1)
        Me.Frame1.Controls.Add(Me.optSort2)
        Me.Frame1.Location = New System.Drawing.Point(10, 15)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(337, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Sort By:"
        '
        'optSort0
        '
        Me.optSort0.AutoSize = True
        Me.optSort0.Location = New System.Drawing.Point(64, 16)
        Me.optSort0.Name = "optSort0"
        Me.optSort0.Size = New System.Drawing.Size(71, 17)
        Me.optSort0.TabIndex = 1
        Me.optSort0.TabStop = True
        Me.optSort0.Text = "&IB Item #:"
        Me.optSort0.UseVisualStyleBackColor = True
        '
        'optSort1
        '
        Me.optSort1.AutoSize = True
        Me.optSort1.Location = New System.Drawing.Point(144, 16)
        Me.optSort1.Name = "optSort1"
        Me.optSort1.Size = New System.Drawing.Size(78, 17)
        Me.optSort1.TabIndex = 2
        Me.optSort1.TabStop = True
        Me.optSort1.Text = "&Description"
        Me.optSort1.UseVisualStyleBackColor = True
        '
        'optSort2
        '
        Me.optSort2.AutoSize = True
        Me.optSort2.Location = New System.Drawing.Point(240, 16)
        Me.optSort2.Name = "optSort2"
        Me.optSort2.Size = New System.Drawing.Size(59, 17)
        Me.optSort2.TabIndex = 3
        Me.optSort2.TabStop = True
        Me.optSort2.Text = "&Vendor"
        Me.optSort2.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(432, 32)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(121, 17)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(432, 33)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 15)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "As of:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(627, 138)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 57
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(627, 108)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 56
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(627, 78)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 55
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(627, 209)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(85, 25)
        Me.cmdPrint.TabIndex = 58
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'grdItemTemp
        '
        Me.grdItemTemp.AllowAddNew = True
        Me.grdItemTemp.AllowDelete = True
        Me.grdItemTemp.DataSource = Me.ItemTempBindingSource
        Me.grdItemTemp.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdItemTemp.Images.Add(CType(resources.GetObject("grdItemTemp.Images"), System.Drawing.Image))
        Me.grdItemTemp.Location = New System.Drawing.Point(10, 65)
        Me.grdItemTemp.Name = "grdItemTemp"
        Me.grdItemTemp.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdItemTemp.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdItemTemp.PreviewInfo.ZoomFactor = 75.0R
        Me.grdItemTemp.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdItemTemp.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdItemTemp.PrintInfo.PageSettings = CType(resources.GetObject("grdItemTemp.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdItemTemp.Size = New System.Drawing.Size(594, 446)
        Me.grdItemTemp.TabIndex = 59
        Me.grdItemTemp.UseCompatibleTextRendering = False
        Me.grdItemTemp.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdItemTemp.PropBag = resources.GetString("grdItemTemp.PropBag")
        '
        'DsItemTemp
        '
        Me.DsItemTemp.DataSetName = "dsItemTemp"
        Me.DsItemTemp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemTempBindingSource
        '
        Me.ItemTempBindingSource.DataMember = "ItemTemp"
        Me.ItemTempBindingSource.DataSource = Me.DsItemTemp
        '
        'ItemTempTableAdapter
        '
        Me.ItemTempTableAdapter.ClearBeforeFill = True
        '
        'frmInvPhys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 520)
        Me.Controls.Add(Me.grdItemTemp)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Frame1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(87, 78)
        Me.Name = "frmInvPhys"
        Me.Text = "Physical Inventory Adjustment"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItemTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optSort2 As RadioButton
    Friend WithEvents optSort1 As RadioButton
    Friend WithEvents optSort0 As RadioButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
    Friend WithEvents grdItemTemp As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsItemTemp As dsItemTemp
    Friend WithEvents ItemTempBindingSource As BindingSource
    Friend WithEvents ItemTempTableAdapter As dsItemTempTableAdapters.ItemTempTableAdapter
End Class
