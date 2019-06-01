<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelQty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelQty))
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.SpGetCustDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustDept = New IB.net.dsspGetCustDept()
        Me.txtdata1 = New System.Windows.Forms.TextBox()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.SpGetCustDeptTableAdapter = New IB.net.dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter()
        Me.DsspGetCustDept1 = New IB.net.dsspGetCustDept()
        Me.grdItems = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.VwGetDelQtyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwGetDelQtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwGetDelQty = New IB.net.dsvwGetDelQty()
        Me.VwGetDelQtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwGetDelQtyTableAdapter = New IB.net.dsvwGetDelQtyTableAdapters.vwGetDelQtyTableAdapter()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwGetDelQtyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwGetDelQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtData0
        '
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustDeptBindingSource, "CUST_NUM", True))
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(70, 10)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 20)
        Me.txtData0.TabIndex = 1
        '
        'SpGetCustDeptBindingSource
        '
        Me.SpGetCustDeptBindingSource.DataMember = "SpGetCustDept"
        Me.SpGetCustDeptBindingSource.DataSource = Me.DsspGetCustDept
        '
        'DsspGetCustDept
        '
        Me.DsspGetCustDept.DataSetName = "dsspGetCustDept"
        Me.DsspGetCustDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtdata1
        '
        Me.txtdata1.Enabled = False
        Me.txtdata1.ForeColor = System.Drawing.Color.Navy
        Me.txtdata1.Location = New System.Drawing.Point(315, 7)
        Me.txtdata1.Name = "txtdata1"
        Me.txtdata1.Size = New System.Drawing.Size(22, 20)
        Me.txtdata1.TabIndex = 4
        Me.txtdata1.Visible = False
        '
        'lstDept
        '
        Me.lstDept.DataSource = Me.SpGetCustDeptBindingSource
        Me.lstDept.DisplayMember = "DEPT"
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(315, 10)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 56)
        Me.lstDept.TabIndex = 12
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(10, 13)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Customer:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(273, 7)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "&Dept:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(386, 163)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 9
        Me.lblCurCust.Text = "Label1"
        Me.lblCurCust.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(375, 72)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 83
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(375, 41)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 82
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(375, 10)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 81
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Location = New System.Drawing.Point(70, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(230, 13)
        Me.txtCustName.TabIndex = 90
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(160, 10)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 91
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.Location = New System.Drawing.Point(70, 56)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Size = New System.Drawing.Size(230, 13)
        Me.txtCustDept.TabIndex = 92
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetCustDeptTableAdapter
        '
        Me.SpGetCustDeptTableAdapter.ClearBeforeFill = True
        '
        'DsspGetCustDept1
        '
        Me.DsspGetCustDept1.DataSetName = "dsspGetCustDept"
        Me.DsspGetCustDept1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdItems
        '
        Me.grdItems.DataSource = Me.VwGetDelQtyBindingSource1
        Me.grdItems.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdItems.Images.Add(CType(resources.GetObject("grdItems.Images"), System.Drawing.Image))
        Me.grdItems.Location = New System.Drawing.Point(13, 75)
        Me.grdItems.Name = "grdItems"
        Me.grdItems.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdItems.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdItems.PreviewInfo.ZoomFactor = 75.0R
        Me.grdItems.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdItems.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdItems.PrintInfo.PageSettings = CType(resources.GetObject("grdItems.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdItems.Size = New System.Drawing.Size(345, 161)
        Me.grdItems.TabIndex = 93
        Me.grdItems.UseCompatibleTextRendering = False
        Me.grdItems.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdItems.PropBag = resources.GetString("grdItems.PropBag")
        '
        'VwGetDelQtyBindingSource1
        '
        Me.VwGetDelQtyBindingSource1.DataMember = "vwGetDelQty"
        Me.VwGetDelQtyBindingSource1.DataSource = Me.DsvwGetDelQtyBindingSource
        '
        'DsvwGetDelQtyBindingSource
        '
        Me.DsvwGetDelQtyBindingSource.DataSource = Me.DsvwGetDelQty
        Me.DsvwGetDelQtyBindingSource.Position = 0
        '
        'DsvwGetDelQty
        '
        Me.DsvwGetDelQty.DataSetName = "dsvwGetDelQty"
        Me.DsvwGetDelQty.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwGetDelQtyBindingSource
        '
        Me.VwGetDelQtyBindingSource.DataMember = "vwGetDelQty"
        Me.VwGetDelQtyBindingSource.DataSource = Me.DsvwGetDelQty
        '
        'VwGetDelQtyTableAdapter
        '
        Me.VwGetDelQtyTableAdapter.ClearBeforeFill = True
        '
        'frmDelQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 245)
        Me.Controls.Add(Me.grdItems)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.txtdata1)
        Me.Controls.Add(Me.txtData0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(64, 134)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelQty"
        Me.ShowInTaskbar = False
        Me.Text = "Change Delivery Quantities"
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwGetDelQtyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwGetDelQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents txtdata1 As TextBox
    Friend WithEvents lstDept As ListBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Private WithEvents DsspGetCustDept As dsspGetCustDept
    Friend WithEvents SpGetCustDeptTableAdapter As dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter
    Private WithEvents SpGetCustDeptBindingSource As BindingSource
    Private WithEvents DsspGetCustDept1 As dsspGetCustDept
    Friend WithEvents grdItems As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DsvwGetDelQtyBindingSource As BindingSource
    Friend WithEvents DsvwGetDelQty As dsvwGetDelQty
    Friend WithEvents VwGetDelQtyBindingSource As BindingSource
    Friend WithEvents VwGetDelQtyTableAdapter As dsvwGetDelQtyTableAdapters.vwGetDelQtyTableAdapter
    Friend WithEvents VwGetDelQtyBindingSource1 As BindingSource
End Class
