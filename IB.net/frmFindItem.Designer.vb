<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindItem
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
        Me.LstItemAlpha = New System.Windows.Forms.ListBox()
        Me.LstItemNum = New System.Windows.Forms.ListBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.OptType2 = New System.Windows.Forms.RadioButton()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.optType0 = New System.Windows.Forms.RadioButton()
        Me.lstVendItem = New System.Windows.Forms.ListBox()
        Me.cmdVendor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstItemAlpha
        '
        Me.LstItemAlpha.FormattingEnabled = True
        Me.LstItemAlpha.Location = New System.Drawing.Point(192, 8)
        Me.LstItemAlpha.Name = "LstItemAlpha"
        Me.LstItemAlpha.Size = New System.Drawing.Size(161, 95)
        Me.LstItemAlpha.TabIndex = 7
        '
        'LstItemNum
        '
        Me.LstItemNum.FormattingEnabled = True
        Me.LstItemNum.Location = New System.Drawing.Point(104, 8)
        Me.LstItemNum.Name = "LstItemNum"
        Me.LstItemNum.Size = New System.Drawing.Size(73, 95)
        Me.LstItemNum.TabIndex = 6
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(364, 77)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(364, 35)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(64, 22)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(364, 7)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(64, 22)
        Me.cmdSelect.TabIndex = 3
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
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
        Me.lstVendItem.FormattingEnabled = True
        Me.lstVendItem.Location = New System.Drawing.Point(248, 112)
        Me.lstVendItem.Name = "lstVendItem"
        Me.lstVendItem.Size = New System.Drawing.Size(105, 69)
        Me.lstVendItem.TabIndex = 9
        '
        'cmdVendor
        '
        Me.cmdVendor.FormattingEnabled = True
        Me.cmdVendor.Location = New System.Drawing.Point(104, 112)
        Me.cmdVendor.Name = "cmdVendor"
        Me.cmdVendor.Size = New System.Drawing.Size(136, 21)
        Me.cmdVendor.TabIndex = 10
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
        'frmFindItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 185)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVendor)
        Me.Controls.Add(Me.lstVendItem)
        Me.Controls.Add(Me.optType0)
        Me.Controls.Add(Me.optType1)
        Me.Controls.Add(Me.OptType2)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.LstItemNum)
        Me.Controls.Add(Me.LstItemAlpha)
        Me.Location = New System.Drawing.Point(123, 166)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindItem"
        Me.ShowInTaskbar = False
        Me.Text = "Find Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstItemAlpha As ListBox
    Friend WithEvents LstItemNum As ListBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdSelect As Button
    Friend WithEvents OptType2 As RadioButton
    Friend WithEvents optType1 As RadioButton
    Friend WithEvents optType0 As RadioButton
    Friend WithEvents lstVendItem As ListBox
    Friend WithEvents cmdVendor As ComboBox
    Friend WithEvents Label1 As Label
End Class
