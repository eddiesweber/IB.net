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
        Me.SpGetCustDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustDept = New IB.net.dsspGetCustDept()
        Me.SpGetCustDeptTableAdapter = New IB.net.dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter()
        Me.DsspGetCustDept1 = New IB.net.dsspGetCustDept()
        Me.VwGetDelQtyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwGetDelQtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvwGetDelQty = New IB.net.dsvwGetDelQty()
        Me.VwGetDelQtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwGetDelQtyTableAdapter = New IB.net.dsvwGetDelQtyTableAdapters.vwGetDelQtyTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdata1 = New System.Windows.Forms.TextBox()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdItems = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwGetDelQtyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvwGetDelQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'SpGetCustDeptTableAdapter
        '
        Me.SpGetCustDeptTableAdapter.ClearBeforeFill = True
        '
        'DsspGetCustDept1
        '
        Me.DsspGetCustDept1.DataSetName = "dsspGetCustDept"
        Me.DsspGetCustDept1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtdata1)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdReset)
        Me.GroupBox1.Controls.Add(Me.lblCurCust)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 315)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        '
        'txtdata1
        '
        Me.txtdata1.Enabled = False
        Me.txtdata1.ForeColor = System.Drawing.Color.Navy
        Me.txtdata1.Location = New System.Drawing.Point(41, 145)
        Me.txtdata1.Name = "txtdata1"
        Me.txtdata1.Size = New System.Drawing.Size(22, 20)
        Me.txtdata1.TabIndex = 88
        Me.txtdata1.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(10, 279)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 87
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(10, 51)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 86
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReset.Enabled = False
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(10, 20)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 85
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(16, 173)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 84
        Me.lblCurCust.Text = "Label1"
        Me.lblCurCust.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdItems)
        Me.GroupBox2.Controls.Add(Me.txtCustDept)
        Me.GroupBox2.Controls.Add(Me.cmdFindCust)
        Me.GroupBox2.Controls.Add(Me.txtCustName)
        Me.GroupBox2.Controls.Add(Me.lblLabel0)
        Me.GroupBox2.Controls.Add(Me.lblLabel1)
        Me.GroupBox2.Controls.Add(Me.lstDept)
        Me.GroupBox2.Controls.Add(Me.txtData0)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 315)
        Me.GroupBox2.TabIndex = 95
        Me.GroupBox2.TabStop = False
        '
        'grdItems
        '
        Me.grdItems.AlternatingRows = True
        Me.grdItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItems.CaptionHeight = 17
        Me.grdItems.DataSource = Me.VwGetDelQtyBindingSource1
        Me.grdItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdItems.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdItems.Images.Add(CType(resources.GetObject("grdItems.Images"), System.Drawing.Image))
        Me.grdItems.Location = New System.Drawing.Point(10, 90)
        Me.grdItems.Name = "grdItems"
        Me.grdItems.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdItems.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdItems.PreviewInfo.ZoomFactor = 75.0R
        Me.grdItems.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdItems.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdItems.PrintInfo.PageSettings = CType(resources.GetObject("grdItems.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdItems.RowHeight = 15
        Me.grdItems.Size = New System.Drawing.Size(387, 214)
        Me.grdItems.TabIndex = 101
        Me.grdItems.UseCompatibleTextRendering = False
        Me.grdItems.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdItems.PropBag = resources.GetString("grdItems.PropBag")
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustDept.Location = New System.Drawing.Point(10, 66)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Size = New System.Drawing.Size(250, 16)
        Me.txtCustDept.TabIndex = 100
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFindCust.Location = New System.Drawing.Point(175, 20)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 99
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(10, 50)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(250, 16)
        Me.txtCustName.TabIndex = 98
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel0.Location = New System.Drawing.Point(306, 23)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(42, 17)
        Me.lblLabel0.TabIndex = 96
        Me.lblLabel0.Text = "&Dept:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(7, 23)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(72, 17)
        Me.lblLabel1.TabIndex = 94
        Me.lblLabel1.Text = "&Customer:"
        '
        'lstDept
        '
        Me.lstDept.DataSource = Me.SpGetCustDeptBindingSource
        Me.lstDept.DisplayMember = "DEPT"
        Me.lstDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.ItemHeight = 16
        Me.lstDept.Location = New System.Drawing.Point(354, 20)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 52)
        Me.lstDept.TabIndex = 97
        '
        'txtData0
        '
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetCustDeptBindingSource, "CUST_NUM", True))
        Me.txtData0.Enabled = False
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(80, 21)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 23)
        Me.txtData0.TabIndex = 95
        '
        'frmDelQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 326)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(64, 134)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelQty"
        Me.ShowInTaskbar = False
        Me.Text = "Change Delivery Quantities"
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwGetDelQtyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvwGetDelQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwGetDelQtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DsspGetCustDept As dsspGetCustDept
    Friend WithEvents SpGetCustDeptTableAdapter As dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter
    Private WithEvents SpGetCustDeptBindingSource As BindingSource
    Private WithEvents DsspGetCustDept1 As dsspGetCustDept
    Friend WithEvents DsvwGetDelQtyBindingSource As BindingSource
    Friend WithEvents DsvwGetDelQty As dsvwGetDelQty
    Friend WithEvents VwGetDelQtyBindingSource As BindingSource
    Friend WithEvents VwGetDelQtyTableAdapter As dsvwGetDelQtyTableAdapters.vwGetDelQtyTableAdapter
    Friend WithEvents VwGetDelQtyBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdata1 As TextBox
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents lblCurCust As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdItems As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lstDept As ListBox
    Friend WithEvents txtData0 As TextBox
End Class
