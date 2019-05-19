<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindPO))
        Me.lstCustName = New System.Windows.Forms.ListBox()
        Me.SpGetPOsAlphaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetPOsAlpha = New IB.net.dsspGetPOsAlpha()
        Me.lstCustNum = New System.Windows.Forms.ListBox()
        Me.SpGetPOsNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetPOsNum = New IB.net.dsspGetPOsNum()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.SpGetPOsNumTableAdapter = New IB.net.dsspGetPOsNumTableAdapters.SpGetPOsNumTableAdapter()
        Me.SpGetPOsAlphaTableAdapter = New IB.net.dsspGetPOsAlphaTableAdapters.SpGetPOsAlphaTableAdapter()
        CType(Me.SpGetPOsAlphaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetPOsAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetPOsNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetPOsNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCustName
        '
        Me.lstCustName.DataSource = Me.SpGetPOsAlphaBindingSource
        Me.lstCustName.DisplayMember = "List"
        Me.lstCustName.FormattingEnabled = True
        Me.lstCustName.Location = New System.Drawing.Point(130, 10)
        Me.lstCustName.Name = "lstCustName"
        Me.lstCustName.Size = New System.Drawing.Size(137, 95)
        Me.lstCustName.TabIndex = 4
        Me.lstCustName.ValueMember = "Seq"
        '
        'SpGetPOsAlphaBindingSource
        '
        Me.SpGetPOsAlphaBindingSource.DataMember = "SpGetPOsAlpha"
        Me.SpGetPOsAlphaBindingSource.DataSource = Me.DsspGetPOsAlpha
        '
        'DsspGetPOsAlpha
        '
        Me.DsspGetPOsAlpha.DataSetName = "dsspGetPOsAlpha"
        Me.DsspGetPOsAlpha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstCustNum
        '
        Me.lstCustNum.DataSource = Me.SpGetPOsNumBindingSource
        Me.lstCustNum.DisplayMember = "List"
        Me.lstCustNum.FormattingEnabled = True
        Me.lstCustNum.Location = New System.Drawing.Point(10, 10)
        Me.lstCustNum.Name = "lstCustNum"
        Me.lstCustNum.Size = New System.Drawing.Size(115, 95)
        Me.lstCustNum.TabIndex = 3
        Me.lstCustNum.ValueMember = "Seq"
        '
        'SpGetPOsNumBindingSource
        '
        Me.SpGetPOsNumBindingSource.DataMember = "SpGetPOsNum"
        Me.SpGetPOsNumBindingSource.DataSource = Me.DsspGetPOsNum
        '
        'DsspGetPOsNum
        '
        Me.DsspGetPOsNum.DataSetName = "dsspGetPOsNum"
        Me.DsspGetPOsNum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(275, 10)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(85, 25)
        Me.cmdSelect.TabIndex = 85
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(275, 79)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 84
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(275, 40)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 25)
        Me.cmdRefresh.TabIndex = 83
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetPOsNumTableAdapter
        '
        Me.SpGetPOsNumTableAdapter.ClearBeforeFill = True
        '
        'SpGetPOsAlphaTableAdapter
        '
        Me.SpGetPOsAlphaTableAdapter.ClearBeforeFill = True
        '
        'frmFindPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 114)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lstCustNum)
        Me.Controls.Add(Me.lstCustName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindPO"
        Me.ShowInTaskbar = False
        Me.Text = "Find Purchase Order"
        CType(Me.SpGetPOsAlphaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetPOsAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetPOsNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetPOsNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCustName As ListBox
    Friend WithEvents lstCustNum As ListBox
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents DsspGetPOsNum As dsspGetPOsNum
    Friend WithEvents SpGetPOsNumBindingSource As BindingSource
    Friend WithEvents SpGetPOsNumTableAdapter As dsspGetPOsNumTableAdapters.SpGetPOsNumTableAdapter
    Friend WithEvents DsspGetPOsAlpha As dsspGetPOsAlpha
    Friend WithEvents SpGetPOsAlphaBindingSource As BindingSource
    Friend WithEvents SpGetPOsAlphaTableAdapter As dsspGetPOsAlphaTableAdapters.SpGetPOsAlphaTableAdapter
End Class
