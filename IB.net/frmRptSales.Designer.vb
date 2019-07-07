<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptSales))
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaus0 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmbCat = New C1.Win.C1List.C1Combo()
        Me.CategoryMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCategoryMaster = New IB.net.dsCategoryMaster()
        Me.CategoryMasterTableAdapter = New IB.net.dsCategoryMasterTableAdapters.CategoryMasterTableAdapter()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCategoryMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(15, 90)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(149, 17)
        Me.chkRpt0.TabIndex = 0
        Me.chkRpt0.Text = "&Production (Sales by Item)"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(15, 125)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(162, 17)
        Me.chkRpt1.TabIndex = 1
        Me.chkRpt1.Text = "&Top 100 (Sales by Customer)"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Category:"
        '
        'lblStaus0
        '
        Me.lblStaus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStaus0.Location = New System.Drawing.Point(10, 15)
        Me.lblStaus0.Name = "lblStaus0"
        Me.lblStaus0.Size = New System.Drawing.Size(240, 15)
        Me.lblStaus0.TabIndex = 6
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(10, 160)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(240, 15)
        Me.lblStatus1.TabIndex = 5
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(185, 120)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 80
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(185, 85)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 81
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(133, 190)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 83
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(42, 190)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 82
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbCat
        '
        Me.cmbCat.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCat.AllowColSelect = True
        Me.cmbCat.Caption = ""
        Me.cmbCat.CaptionHeight = 0
        Me.cmbCat.CaptionVisible = False
        Me.cmbCat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCat.ColumnHeaders = False
        Me.cmbCat.ColumnWidth = 100
        Me.cmbCat.DataSource = Me.CategoryMasterBindingSource
        Me.cmbCat.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCat.DisplayMember = "VOL_CAT"
        Me.cmbCat.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCat.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCat.Images.Add(CType(resources.GetObject("cmbCat.Images"), System.Drawing.Image))
        Me.cmbCat.Location = New System.Drawing.Point(75, 45)
        Me.cmbCat.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCat.MaxDropDownItems = CType(5, Short)
        Me.cmbCat.MaxLength = 32767
        Me.cmbCat.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCat.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCat.Size = New System.Drawing.Size(100, 21)
        Me.cmbCat.TabIndex = 84
        Me.cmbCat.ValueMember = "VOL_CAT"
        Me.cmbCat.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbCat.PropBag = resources.GetString("cmbCat.PropBag")
        '
        'CategoryMasterBindingSource
        '
        Me.CategoryMasterBindingSource.DataMember = "CategoryMaster"
        Me.CategoryMasterBindingSource.DataSource = Me.DsCategoryMaster
        '
        'DsCategoryMaster
        '
        Me.DsCategoryMaster.DataSetName = "dsCategoryMaster"
        Me.DsCategoryMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryMasterTableAdapter
        '
        Me.CategoryMasterTableAdapter.ClearBeforeFill = True
        '
        'frmRptSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 226)
        Me.Controls.Add(Me.cmbCat)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.lblStaus0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(237, 226)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptSales"
        Me.ShowInTaskbar = False
        Me.Text = "Sales Reports"
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCategoryMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStaus0 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmbCat As C1.Win.C1List.C1Combo
    Friend WithEvents DsCategoryMaster As dsCategoryMaster
    Friend WithEvents CategoryMasterBindingSource As BindingSource
    Friend WithEvents CategoryMasterTableAdapter As dsCategoryMasterTableAdapters.CategoryMasterTableAdapter
End Class
