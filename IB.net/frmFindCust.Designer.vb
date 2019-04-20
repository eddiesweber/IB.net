<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFindCust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindCust))
        Me.lstCustName = New System.Windows.Forms.ListBox()
        Me.SpGetCustsAlphaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustsAlpha = New IB.net.dsspGetCustsAlpha()
        Me.SpGetCustsNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustsNum = New IB.net.dsspGetCustsNum()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.SpGetCustsNumTableAdapter = New IB.net.dsspGetCustsNumTableAdapters.SpGetCustsNumTableAdapter()
        Me.SpGetCustsAlphaTableAdapter = New IB.net.dsspGetCustsAlphaTableAdapters.SpGetCustsAlphaTableAdapter()
        Me.lstCustNum = New System.Windows.Forms.ListBox()
        CType(Me.SpGetCustsAlphaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustsAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustsNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustsNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCustName
        '
        Me.lstCustName.DataSource = Me.SpGetCustsAlphaBindingSource
        Me.lstCustName.DisplayMember = "Bill_Name"
        Me.lstCustName.FormattingEnabled = True
        Me.lstCustName.Location = New System.Drawing.Point(90, 10)
        Me.lstCustName.Name = "lstCustName"
        Me.lstCustName.Size = New System.Drawing.Size(200, 95)
        Me.lstCustName.TabIndex = 5
        Me.lstCustName.ValueMember = "Cust_Num"
        '
        'SpGetCustsAlphaBindingSource
        '
        Me.SpGetCustsAlphaBindingSource.DataMember = "SpGetCustsAlpha"
        Me.SpGetCustsAlphaBindingSource.DataSource = Me.DsspGetCustsAlpha
        '
        'DsspGetCustsAlpha
        '
        Me.DsspGetCustsAlpha.DataSetName = "dsspGetCustsAlpha"
        Me.DsspGetCustsAlpha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetCustsNumBindingSource
        '
        Me.SpGetCustsNumBindingSource.DataMember = "SpGetCustsNum"
        Me.SpGetCustsNumBindingSource.DataSource = Me.DsspGetCustsNum
        '
        'DsspGetCustsNum
        '
        Me.DsspGetCustsNum.DataSetName = "dsspGetCustsNum"
        Me.DsspGetCustsNum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(300, 10)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 25)
        Me.cmdSelect.TabIndex = 1
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(300, 40)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 25)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(300, 80)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 25)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetCustsNumTableAdapter
        '
        Me.SpGetCustsNumTableAdapter.ClearBeforeFill = True
        '
        'SpGetCustsAlphaTableAdapter
        '
        Me.SpGetCustsAlphaTableAdapter.ClearBeforeFill = True
        '
        'lstCustNum
        '
        Me.lstCustNum.DataSource = Me.SpGetCustsNumBindingSource
        Me.lstCustNum.DisplayMember = "CUST_NUM"
        Me.lstCustNum.FormattingEnabled = True
        Me.lstCustNum.Location = New System.Drawing.Point(10, 10)
        Me.lstCustNum.Name = "lstCustNum"
        Me.lstCustNum.Size = New System.Drawing.Size(72, 95)
        Me.lstCustNum.TabIndex = 6
        Me.lstCustNum.ValueMember = "BILL_NAME"
        '
        'frmFindCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 113)
        Me.Controls.Add(Me.lstCustNum)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.lstCustName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCust"
        Me.ShowInTaskbar = False
        Me.Text = "Find Customer"
        CType(Me.SpGetCustsAlphaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustsAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustsNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustsNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCustName As ListBox
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents DsspGetCustsNum As dsspGetCustsNum
    Friend WithEvents SpGetCustsNumBindingSource As BindingSource
    Friend WithEvents SpGetCustsNumTableAdapter As dsspGetCustsNumTableAdapters.SpGetCustsNumTableAdapter
    Friend WithEvents DsspGetCustsAlpha As dsspGetCustsAlpha
    Friend WithEvents SpGetCustsAlphaBindingSource As BindingSource
    Friend WithEvents SpGetCustsAlphaTableAdapter As dsspGetCustsAlphaTableAdapters.SpGetCustsAlphaTableAdapter
    Friend WithEvents lstCustNum As ListBox
End Class
