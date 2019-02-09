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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindCustSrch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New C1.Win.C1Input.C1TextBox()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.lstDelName = New C1.Win.C1List.C1List()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDelName, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Location = New System.Drawing.Point(165, 10)
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
        Me.cmdCancel.Location = New System.Drawing.Point(346, 105)
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
        Me.cmdSelect.Location = New System.Drawing.Point(346, 30)
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
        Me.lstDelName.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstDelName.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstDelName.Images.Add(CType(resources.GetObject("lstDelName.Images"), System.Drawing.Image))
        Me.lstDelName.Location = New System.Drawing.Point(165, 30)
        Me.lstDelName.MatchEntryTimeout = CType(2000, Long)
        Me.lstDelName.Name = "lstDelName"
        Me.lstDelName.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstDelName.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstDelName.PreviewInfo.ZoomFactor = 75.0R
        Me.lstDelName.PrintInfo.PageSettings = CType(resources.GetObject("C1List1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstDelName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstDelName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstDelName.ShowHeaderCheckBox = False
        Me.lstDelName.Size = New System.Drawing.Size(175, 100)
        Me.lstDelName.TabIndex = 11
        Me.lstDelName.Text = "C1List1"
        Me.lstDelName.PropBag = resources.GetString("lstDelName.PropBag")
        '
        'frmFindCustSrch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 141)
        Me.Controls.Add(Me.lstDelName)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.lstDelName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents lstDelName As C1.Win.C1List.C1List
End Class
