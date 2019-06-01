<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindCustSrch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindCustSrch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New C1.Win.C1Input.C1TextBox()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.lstDelName = New System.Windows.Forms.ListBox()
        Me.DsspGetCustsSrch = New IB.net.dsspGetCustsSrch()
        Me.SpGetCustsSrchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetCustsSrchTableAdapter = New IB.net.dsspGetCustsSrchTableAdapters.spGetCustsSrchTableAdapter()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustsSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustsSrchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Search For:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Delivery Name:"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(10, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(140, 18)
        Me.txtSearch.TabIndex = 7
        Me.txtSearch.Tag = Nothing
        Me.txtSearch.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(65, 54)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 25)
        Me.cmdRefresh.TabIndex = 8
        Me.cmdRefresh.Text = "&Go"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(340, 113)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(340, 30)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(85, 25)
        Me.cmdSelect.TabIndex = 10
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lstDelName
        '
        Me.lstDelName.DataSource = Me.SpGetCustsSrchBindingSource
        Me.lstDelName.DisplayMember = "DEL_NAME"
        Me.lstDelName.FormattingEnabled = True
        Me.lstDelName.Location = New System.Drawing.Point(163, 30)
        Me.lstDelName.Name = "lstDelName"
        Me.lstDelName.Size = New System.Drawing.Size(171, 108)
        Me.lstDelName.TabIndex = 11
        Me.lstDelName.ValueMember = "CUST_NUM"
        '
        'DsspGetCustsSrch
        '
        Me.DsspGetCustsSrch.DataSetName = "dsspGetCustsSrch"
        Me.DsspGetCustsSrch.EnforceConstraints = False
        Me.DsspGetCustsSrch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetCustsSrchBindingSource
        '
        Me.SpGetCustsSrchBindingSource.DataMember = "spGetCustsSrch"
        Me.SpGetCustsSrchBindingSource.DataSource = Me.DsspGetCustsSrch
        '
        'SpGetCustsSrchTableAdapter
        '
        Me.SpGetCustsSrchTableAdapter.ClearBeforeFill = True
        '
        'frmFindCustSrch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 149)
        Me.Controls.Add(Me.lstDelName)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCustSrch"
        Me.ShowInTaskbar = False
        Me.Tag = "`"
        Me.Text = "Search For Customer"
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustsSrch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustsSrchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents lstDelName As ListBox
    Friend WithEvents SpGetCustsSrchBindingSource As BindingSource
    Friend WithEvents DsspGetCustsSrch As dsspGetCustsSrch
    Friend WithEvents SpGetCustsSrchTableAdapter As dsspGetCustsSrchTableAdapters.spGetCustsSrchTableAdapter
End Class
