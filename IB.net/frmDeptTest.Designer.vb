<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeptTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeptTest))
        Me.C1List1 = New C1.Win.C1List.C1List()
        Me.CustomerDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomerDepartment = New IB.net.dsCustomerDepartment()
        Me.CustomerDepartmentTableAdapter = New IB.net.dsCustomerDepartmentTableAdapters.CustomerDepartmentTableAdapter()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1List1
        '
        Me.C1List1.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.ColumnWidth = 100
        Me.C1List1.DataSource = Me.CustomerDepartmentBindingSource
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.DisplayMember = "DEPT"
        Me.C1List1.Images.Add(CType(resources.GetObject("C1List1.Images"), System.Drawing.Image))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(57, 30)
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1List1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1List1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1List1.PrintInfo.PageSettings = CType(resources.GetObject("C1List1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1List1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ShowHeaderCheckBox = False
        Me.C1List1.Size = New System.Drawing.Size(650, 164)
        Me.C1List1.TabIndex = 0
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = resources.GetString("C1List1.PropBag")
        '
        'CustomerDepartmentBindingSource
        '
        Me.CustomerDepartmentBindingSource.DataMember = "CustomerDepartment"
        Me.CustomerDepartmentBindingSource.DataSource = Me.DsCustomerDepartment
        '
        'DsCustomerDepartment
        '
        Me.DsCustomerDepartment.DataSetName = "dsCustomerDepartment"
        Me.DsCustomerDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDepartmentTableAdapter
        '
        Me.CustomerDepartmentTableAdapter.ClearBeforeFill = True
        '
        'frmDeptTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1List1)
        Me.Name = "frmDeptTest"
        Me.Text = "frmDeptTest"
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1List1 As C1.Win.C1List.C1List
    Friend WithEvents CustomerDepartmentBindingSource As BindingSource
    Friend WithEvents DsCustomerDepartment As dsCustomerDepartment
    Friend WithEvents CustomerDepartmentTableAdapter As dsCustomerDepartmentTableAdapters.CustomerDepartmentTableAdapter
End Class
