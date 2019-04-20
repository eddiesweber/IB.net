<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFindItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindItem))
        Me.LstItemAlpha = New System.Windows.Forms.ListBox()
        Me.SpGetItemsAlphaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetItemsAlpha = New IB.net.dsspGetItemsAlpha()
        Me.LstItemNum = New System.Windows.Forms.ListBox()
        Me.SpGetItemsNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetItemsNum = New IB.net.dsspGetItemsNum()
        Me.OptType2 = New System.Windows.Forms.RadioButton()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.optType0 = New System.Windows.Forms.RadioButton()
        Me.lstVendItem = New System.Windows.Forms.ListBox()
        Me.SpGetItemsVend2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetItemsVend2 = New IB.net.dsspGetItemsVend2()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.SpGetItemsVend1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetItemsVend1 = New IB.net.dsspGetItemsVend1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.SpGetItemsNumTableAdapter = New IB.net.dsspGetItemsNumTableAdapters.spGetItemsNumTableAdapter()
        Me.SpGetItemsAlphaTableAdapter = New IB.net.dsspGetItemsAlphaTableAdapters.spGetItemsAlphaTableAdapter()
        Me.SpGetItemsVend1TableAdapter = New IB.net.dsspGetItemsVend1TableAdapters.spGetItemsVend1TableAdapter()
        Me.SpGetItemsVend2TableAdapter = New IB.net.dsspGetItemsVend2TableAdapters.spGetItemsVend2TableAdapter()
        CType(Me.SpGetItemsAlphaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetItemsAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetItemsNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetItemsNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetItemsVend2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetItemsVend2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetItemsVend1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetItemsVend1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstItemAlpha
        '
        Me.LstItemAlpha.DataSource = Me.SpGetItemsAlphaBindingSource
        Me.LstItemAlpha.DisplayMember = "DESCR"
        Me.LstItemAlpha.FormattingEnabled = True
        Me.LstItemAlpha.Location = New System.Drawing.Point(192, 10)
        Me.LstItemAlpha.Name = "LstItemAlpha"
        Me.LstItemAlpha.Size = New System.Drawing.Size(161, 95)
        Me.LstItemAlpha.TabIndex = 7
        Me.LstItemAlpha.ValueMember = "ITEM_NUM"
        '
        'SpGetItemsAlphaBindingSource
        '
        Me.SpGetItemsAlphaBindingSource.DataMember = "spGetItemsAlpha"
        Me.SpGetItemsAlphaBindingSource.DataSource = Me.DsspGetItemsAlpha
        '
        'DsspGetItemsAlpha
        '
        Me.DsspGetItemsAlpha.DataSetName = "dsspGetItemsAlpha"
        Me.DsspGetItemsAlpha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LstItemNum
        '
        Me.LstItemNum.DataSource = Me.SpGetItemsNumBindingSource
        Me.LstItemNum.DisplayMember = "ITEM_NUM"
        Me.LstItemNum.FormattingEnabled = True
        Me.LstItemNum.Location = New System.Drawing.Point(104, 10)
        Me.LstItemNum.Name = "LstItemNum"
        Me.LstItemNum.Size = New System.Drawing.Size(73, 95)
        Me.LstItemNum.TabIndex = 6
        Me.LstItemNum.ValueMember = "DESCR"
        '
        'SpGetItemsNumBindingSource
        '
        Me.SpGetItemsNumBindingSource.DataMember = "spGetItemsNum"
        Me.SpGetItemsNumBindingSource.DataSource = Me.DsspGetItemsNum
        '
        'DsspGetItemsNum
        '
        Me.DsspGetItemsNum.DataSetName = "dsspGetItemsNum"
        Me.DsspGetItemsNum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OptType2
        '
        Me.OptType2.AutoSize = True
        Me.OptType2.Location = New System.Drawing.Point(14, 63)
        Me.OptType2.Name = "OptType2"
        Me.OptType2.Size = New System.Drawing.Size(47, 17)
        Me.OptType2.TabIndex = 2
        Me.OptType2.TabStop = True
        Me.OptType2.Text = "Both"
        Me.OptType2.UseVisualStyleBackColor = True
        '
        'optType1
        '
        Me.optType1.AutoSize = True
        Me.optType1.Location = New System.Drawing.Point(14, 42)
        Me.optType1.Name = "optType1"
        Me.optType1.Size = New System.Drawing.Size(51, 17)
        Me.optType1.TabIndex = 1
        Me.optType1.TabStop = True
        Me.optType1.Text = "Other"
        Me.optType1.UseVisualStyleBackColor = True
        '
        'optType0
        '
        Me.optType0.AutoSize = True
        Me.optType0.Location = New System.Drawing.Point(14, 21)
        Me.optType0.Name = "optType0"
        Me.optType0.Size = New System.Drawing.Size(56, 17)
        Me.optType0.TabIndex = 0
        Me.optType0.TabStop = True
        Me.optType0.Text = "Rental"
        Me.optType0.UseVisualStyleBackColor = True
        '
        'lstVendItem
        '
        Me.lstVendItem.DataSource = Me.SpGetItemsVend2BindingSource
        Me.lstVendItem.DisplayMember = "VEND_ITEM"
        Me.lstVendItem.FormattingEnabled = True
        Me.lstVendItem.Location = New System.Drawing.Point(248, 112)
        Me.lstVendItem.Name = "lstVendItem"
        Me.lstVendItem.Size = New System.Drawing.Size(105, 69)
        Me.lstVendItem.TabIndex = 9
        Me.lstVendItem.ValueMember = "ITEM_NUM"
        '
        'SpGetItemsVend2BindingSource
        '
        Me.SpGetItemsVend2BindingSource.DataMember = "spGetItemsVend2"
        Me.SpGetItemsVend2BindingSource.DataSource = Me.DsspGetItemsVend2
        '
        'DsspGetItemsVend2
        '
        Me.DsspGetItemsVend2.DataSetName = "dsspGetItemsVend2"
        Me.DsspGetItemsVend2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbVendor
        '
        Me.cmbVendor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpGetItemsVend1BindingSource, "Vendor", True))
        Me.cmbVendor.DataSource = Me.SpGetItemsVend1BindingSource
        Me.cmbVendor.DisplayMember = "Vendor"
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(104, 112)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(136, 21)
        Me.cmbVendor.TabIndex = 10
        '
        'SpGetItemsVend1BindingSource
        '
        Me.SpGetItemsVend1BindingSource.DataMember = "spGetItemsVend1"
        Me.SpGetItemsVend1BindingSource.DataSource = Me.DsspGetItemsVend1
        '
        'DsspGetItemsVend1
        '
        Me.DsspGetItemsVend1.DataSetName = "dsspGetItemsVend1"
        Me.DsspGetItemsVend1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "By &Vendor:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(369, 70)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 78
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(369, 40)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 25)
        Me.cmdRefresh.TabIndex = 77
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdSelect
        '
        Me.cmdSelect.Enabled = False
        Me.cmdSelect.Location = New System.Drawing.Point(369, 10)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(85, 25)
        Me.cmdSelect.TabIndex = 76
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetItemsNumTableAdapter
        '
        Me.SpGetItemsNumTableAdapter.ClearBeforeFill = True
        '
        'SpGetItemsAlphaTableAdapter
        '
        Me.SpGetItemsAlphaTableAdapter.ClearBeforeFill = True
        '
        'SpGetItemsVend1TableAdapter
        '
        Me.SpGetItemsVend1TableAdapter.ClearBeforeFill = True
        '
        'SpGetItemsVend2TableAdapter
        '
        Me.SpGetItemsVend2TableAdapter.ClearBeforeFill = True
        '
        'frmFindItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 191)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbVendor)
        Me.Controls.Add(Me.lstVendItem)
        Me.Controls.Add(Me.optType0)
        Me.Controls.Add(Me.optType1)
        Me.Controls.Add(Me.OptType2)
        Me.Controls.Add(Me.LstItemNum)
        Me.Controls.Add(Me.LstItemAlpha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(123, 166)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindItem"
        Me.ShowInTaskbar = False
        Me.Text = "Find Item"
        CType(Me.SpGetItemsAlphaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetItemsAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetItemsNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetItemsNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetItemsVend2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetItemsVend2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetItemsVend1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetItemsVend1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstItemAlpha As ListBox
    Friend WithEvents LstItemNum As ListBox
    Friend WithEvents OptType2 As RadioButton
    Friend WithEvents optType1 As RadioButton
    Friend WithEvents optType0 As RadioButton
    Friend WithEvents lstVendItem As ListBox
    Friend WithEvents cmbVendor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents SpGetItemsNumBindingSource As BindingSource
    Friend WithEvents DsspGetItemsNum As dsspGetItemsNum
    Friend WithEvents SpGetItemsNumTableAdapter As dsspGetItemsNumTableAdapters.spGetItemsNumTableAdapter
    Friend WithEvents SpGetItemsAlphaBindingSource As BindingSource
    Friend WithEvents DsspGetItemsAlpha As dsspGetItemsAlpha
    Friend WithEvents SpGetItemsAlphaTableAdapter As dsspGetItemsAlphaTableAdapters.spGetItemsAlphaTableAdapter
    Friend WithEvents SpGetItemsVend1BindingSource As BindingSource
    Friend WithEvents DsspGetItemsVend1 As dsspGetItemsVend1
    Friend WithEvents SpGetItemsVend1TableAdapter As dsspGetItemsVend1TableAdapters.spGetItemsVend1TableAdapter
    Friend WithEvents SpGetItemsVend2BindingSource As BindingSource
    Friend WithEvents DsspGetItemsVend2 As dsspGetItemsVend2
    Friend WithEvents SpGetItemsVend2TableAdapter As dsspGetItemsVend2TableAdapters.spGetItemsVend2TableAdapter
End Class
