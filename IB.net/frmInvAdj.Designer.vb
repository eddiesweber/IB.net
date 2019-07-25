<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvAdj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvAdj))
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.cmdFindItem = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lstAction = New System.Windows.Forms.ListBox()
        Me.lblCurItem = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.ForeColor = System.Drawing.Color.Navy
        Me.txtItem.Location = New System.Drawing.Point(49, 35)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(78, 20)
        Me.txtItem.TabIndex = 3
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.ForeColor = System.Drawing.Color.Navy
        Me.txtType.Location = New System.Drawing.Point(210, 35)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(15, 20)
        Me.txtType.TabIndex = 13
        Me.txtType.Visible = False
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.Silver
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.ForeColor = System.Drawing.Color.Navy
        Me.txtItemDesc.Location = New System.Drawing.Point(49, 56)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(190, 13)
        Me.txtItemDesc.TabIndex = 12
        Me.txtItemDesc.TabStop = False
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(133, 35)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(71, 20)
        Me.cmdFindItem.TabIndex = 4
        Me.cmdFindItem.Text = "&Find"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(266, 7)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(64, 22)
        Me.cmdUpdate.TabIndex = 9
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(266, 42)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.ForeColor = System.Drawing.Color.Navy
        Me.txtQty.Location = New System.Drawing.Point(49, 161)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(64, 20)
        Me.txtQty.TabIndex = 8
        '
        'lstAction
        '
        Me.lstAction.ForeColor = System.Drawing.Color.Navy
        Me.lstAction.FormattingEnabled = True
        Me.lstAction.Location = New System.Drawing.Point(49, 84)
        Me.lstAction.Name = "lstAction"
        Me.lstAction.Size = New System.Drawing.Size(120, 69)
        Me.lstAction.TabIndex = 6
        '
        'lblCurItem
        '
        Me.lblCurItem.Location = New System.Drawing.Point(7, 49)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(22, 15)
        Me.lblCurItem.TabIndex = 14
        Me.lblCurItem.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(7, 189)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(323, 15)
        Me.lblStatus.TabIndex = 11
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 163)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(26, 13)
        Me.lblLabel3.TabIndex = 3
        Me.lblLabel3.Text = "&Qty:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 86)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(40, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "&Action:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 37)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel1.TabIndex = 2
        Me.lblLabel1.Text = "&Item:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 9)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Date:"
        '
        'frmInvAdj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 209)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblCurItem)
        Me.Controls.Add(Me.lstAction)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(265, 197)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvAdj"
        Me.ShowInTaskbar = False
        Me.Text = "Inventory Adjustments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents cmdFindItem As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lstAction As ListBox
    Friend WithEvents lblCurItem As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
End Class
