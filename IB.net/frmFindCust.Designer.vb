<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindCust
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lstCustName = New System.Windows.Forms.ListBox()
        Me.lstCustNum = New System.Windows.Forms.ListBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(280, 77)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'lstCustName
        '
        Me.lstCustName.FormattingEnabled = True
        Me.lstCustName.Location = New System.Drawing.Point(80, 8)
        Me.lstCustName.Name = "lstCustName"
        Me.lstCustName.Size = New System.Drawing.Size(193, 95)
        Me.lstCustName.TabIndex = 4
        '
        'lstCustNum
        '
        Me.lstCustNum.FormattingEnabled = True
        Me.lstCustNum.Location = New System.Drawing.Point(8, 8)
        Me.lstCustNum.Name = "lstCustNum"
        Me.lstCustNum.Size = New System.Drawing.Size(69, 95)
        Me.lstCustNum.TabIndex = 3
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(280, 35)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(64, 22)
        Me.cmdRefresh.TabIndex = 1
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(280, 7)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(64, 22)
        Me.cmdSelect.TabIndex = 0
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'frmFindCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 178)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lstCustNum)
        Me.Controls.Add(Me.lstCustName)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCust"
        Me.ShowInTaskbar = False
        Me.Text = "Find Customer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents lstCustName As ListBox
    Friend WithEvents lstCustNum As ListBox
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdSelect As Button
End Class
