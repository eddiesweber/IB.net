<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindVend
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
        Me.lstCustName = New System.Windows.Forms.ListBox()
        Me.lstCustNum = New System.Windows.Forms.ListBox()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.DsVendMasterFind_Vendor = New IB.net.dsVendMasterFind_Vendor()
        Me.VendMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendMasterTableAdapter = New IB.net.dsVendMasterFind_VendorTableAdapters.VendMasterTableAdapter()
        Me.DsVendMasterFind_VendorName = New IB.net.dsVendMasterFind_VendorName()
        Me.VendMasterBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendMasterTableAdapter1 = New IB.net.dsVendMasterFind_VendorNameTableAdapters.VendMasterTableAdapter()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVendMasterFind_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVendMasterFind_VendorName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendMasterBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCustName
        '
        Me.lstCustName.DataSource = Me.VendMasterBindingSource1
        Me.lstCustName.DisplayMember = "VEND_NAME"
        Me.lstCustName.FormattingEnabled = True
        Me.lstCustName.Location = New System.Drawing.Point(75, 10)
        Me.lstCustName.Name = "lstCustName"
        Me.lstCustName.Size = New System.Drawing.Size(193, 95)
        Me.lstCustName.Sorted = True
        Me.lstCustName.TabIndex = 4
        Me.lstCustName.ValueMember = "VENDOR"
        '
        'lstCustNum
        '
        Me.lstCustNum.DataSource = Me.VendMasterBindingSource
        Me.lstCustNum.DisplayMember = "VENDOR"
        Me.lstCustNum.FormattingEnabled = True
        Me.lstCustNum.Location = New System.Drawing.Point(10, 10)
        Me.lstCustNum.Name = "lstCustNum"
        Me.lstCustNum.Size = New System.Drawing.Size(57, 95)
        Me.lstCustNum.Sorted = True
        Me.lstCustNum.TabIndex = 3
        Me.lstCustNum.ValueMember = "VENDOR"
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(280, 10)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(85, 25)
        Me.cmdSelect.TabIndex = 82
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(280, 79)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 81
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(280, 40)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 25)
        Me.cmdRefresh.TabIndex = 80
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'DsVendMasterFind_Vendor
        '
        Me.DsVendMasterFind_Vendor.DataSetName = "dsVendMasterFind_Vendor"
        Me.DsVendMasterFind_Vendor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendMasterBindingSource
        '
        Me.VendMasterBindingSource.DataMember = "VendMaster"
        Me.VendMasterBindingSource.DataSource = Me.DsVendMasterFind_Vendor
        '
        'VendMasterTableAdapter
        '
        Me.VendMasterTableAdapter.ClearBeforeFill = True
        '
        'DsVendMasterFind_VendorName
        '
        Me.DsVendMasterFind_VendorName.DataSetName = "dsVendMasterFind_VendorName"
        Me.DsVendMasterFind_VendorName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendMasterBindingSource1
        '
        Me.VendMasterBindingSource1.DataMember = "VendMaster"
        Me.VendMasterBindingSource1.DataSource = Me.DsVendMasterFind_VendorName
        '
        'VendMasterTableAdapter1
        '
        Me.VendMasterTableAdapter1.ClearBeforeFill = True
        '
        'frmFindVend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 116)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lstCustNum)
        Me.Controls.Add(Me.lstCustName)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindVend"
        Me.ShowInTaskbar = False
        Me.Text = "Find Vendor"
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVendMasterFind_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVendMasterFind_VendorName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendMasterBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCustName As ListBox
    Friend WithEvents lstCustNum As ListBox
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents DsVendMasterFind_Vendor As dsVendMasterFind_Vendor
    Friend WithEvents VendMasterBindingSource As BindingSource
    Friend WithEvents VendMasterTableAdapter As dsVendMasterFind_VendorTableAdapters.VendMasterTableAdapter
    Friend WithEvents DsVendMasterFind_VendorName As dsVendMasterFind_VendorName
    Friend WithEvents VendMasterBindingSource1 As BindingSource
    Friend WithEvents VendMasterTableAdapter1 As dsVendMasterFind_VendorNameTableAdapters.VendMasterTableAdapter
End Class
