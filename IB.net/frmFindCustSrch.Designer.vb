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
        Me.lstDelName = New System.Windows.Forms.ListBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstDelName
        '
        Me.lstDelName.FormattingEnabled = True
        Me.lstDelName.Location = New System.Drawing.Point(168, 21)
        Me.lstDelName.Name = "lstDelName"
        Me.lstDelName.Size = New System.Drawing.Size(176, 95)
        Me.lstDelName.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(7, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(141, 20)
        Me.txtSearch.TabIndex = 1
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(357, 91)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(84, 63)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(64, 22)
        Me.cmdRefresh.TabIndex = 2
        Me.cmdRefresh.Text = "&Go"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(357, 21)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(64, 22)
        Me.cmdSelect.TabIndex = 4
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Search For:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Delivery Name:"
        '
        'frmFindCustSrch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 122)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstDelName)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCustSrch"
        Me.ShowInTaskbar = False
        Me.Tag = "`"
        Me.Text = "Search For Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDelName As ListBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdSelect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
