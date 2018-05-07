<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.MasterDataSet = New IB.net.masterDataSet()
        Me.MasterDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IBconfigBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IBconfigTableAdapter = New IB.net.masterDataSetTableAdapters.IBconfigTableAdapter()
        Me.TableAdapterManager = New IB.net.masterDataSetTableAdapters.TableAdapterManager()
        Me.lstCompany = New System.Windows.Forms.ListBox()
        Me.IBconfigBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBconfigBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBconfigBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(381, 95)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(171, 52)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(381, 29)
        Me.cmdOpen.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(171, 52)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'MasterDataSet
        '
        Me.MasterDataSet.DataSetName = "masterDataSet"
        Me.MasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterDataSetBindingSource
        '
        Me.MasterDataSetBindingSource.DataSource = Me.MasterDataSet
        Me.MasterDataSetBindingSource.Position = 0
        '
        'IBconfigBindingSource
        '
        Me.IBconfigBindingSource.DataMember = "IBconfig"
        Me.IBconfigBindingSource.DataSource = Me.MasterDataSet
        '
        'IBconfigTableAdapter
        '
        Me.IBconfigTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.IBconfigTableAdapter = Me.IBconfigTableAdapter
        Me.TableAdapterManager.UpdateOrder = IB.net.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lstCompany
        '
        Me.lstCompany.DataSource = Me.IBconfigBindingSource1
        Me.lstCompany.DisplayMember = "Location_ID"
        Me.lstCompany.FormattingEnabled = True
        Me.lstCompany.ItemHeight = 31
        Me.lstCompany.Location = New System.Drawing.Point(27, 29)
        Me.lstCompany.Name = "lstCompany"
        Me.lstCompany.Size = New System.Drawing.Size(326, 159)
        Me.lstCompany.TabIndex = 3
        '
        'IBconfigBindingSource1
        '
        Me.IBconfigBindingSource1.DataMember = "IBconfig"
        Me.IBconfigBindingSource1.DataSource = Me.MasterDataSetBindingSource
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 205)
        Me.Controls.Add(Me.lstCompany)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(76, 73)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmCompany"
        Me.Text = "Select Division"
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBconfigBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBconfigBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOpen As Button
    Friend WithEvents MasterDataSet As masterDataSet
    Friend WithEvents MasterDataSetBindingSource As BindingSource
    Friend WithEvents IBconfigBindingSource As BindingSource
    Friend WithEvents IBconfigTableAdapter As masterDataSetTableAdapters.IBconfigTableAdapter
    Friend WithEvents TableAdapterManager As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lstCompany As ListBox
    Friend WithEvents IBconfigBindingSource1 As BindingSource
End Class
