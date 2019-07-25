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
        Me.lblCurItem = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdFindItem = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.txtItem = New C1.Win.C1Input.C1TextBox()
        Me.txtType = New C1.Win.C1Input.C1TextBox()
        Me.txtItemDesc = New C1.Win.C1Input.C1TextBox()
        Me.txtQty = New C1.Win.C1Input.C1TextBox()
        Me.lstAction = New System.Windows.Forms.ListBox()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurItem
        '
        Me.lblCurItem.Location = New System.Drawing.Point(263, 131)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(58, 15)
        Me.lblCurItem.TabIndex = 14
        Me.lblCurItem.Text = "CurItem"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(10, 200)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(325, 15)
        Me.lblStatus.TabIndex = 11
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(10, 177)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(26, 13)
        Me.lblLabel3.TabIndex = 3
        Me.lblLabel3.Text = "&Qty:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(10, 91)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(40, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "&Action:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(10, 41)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel1.TabIndex = 2
        Me.lblLabel1.Text = "&Item:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(11, 12)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Date:"
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(140, 34)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindItem.TabIndex = 45
        Me.cmdFindItem.Text = "&Find"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        Me.cmdFindItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate
        '
        Me.datDate.AllowSpinLoop = False
        Me.datDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate.Location = New System.Drawing.Point(50, 10)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 46
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(250, 10)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 49
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(250, 40)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 50
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtItem
        '
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.DataType = GetType(Integer)
        Me.txtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(50, 39)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(75, 18)
        Me.txtItem.TabIndex = 54
        Me.txtItem.Tag = Nothing
        Me.txtItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtType.DataType = GetType(Integer)
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(266, 110)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(25, 18)
        Me.txtType.TabIndex = 55
        Me.txtType.Tag = Nothing
        Me.txtType.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtType.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtItemDesc
        '
        Me.txtItemDesc.AutoSize = False
        Me.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtItemDesc.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(50, 63)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Padding = New System.Windows.Forms.Padding(1)
        Me.txtItemDesc.Size = New System.Drawing.Size(175, 15)
        Me.txtItemDesc.TabIndex = 65
        Me.txtItemDesc.Tag = Nothing
        Me.txtItemDesc.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtItemDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.DataType = GetType(Integer)
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(50, 175)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(50, 18)
        Me.txtQty.TabIndex = 67
        Me.txtQty.Tag = Nothing
        Me.txtQty.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtQty.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lstAction
        '
        Me.lstAction.FormattingEnabled = True
        Me.lstAction.Location = New System.Drawing.Point(50, 91)
        Me.lstAction.Name = "lstAction"
        Me.lstAction.Size = New System.Drawing.Size(125, 69)
        Me.lstAction.TabIndex = 68
        '
        'frmInvAdj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 226)
        Me.Controls.Add(Me.lstAction)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblCurItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(265, 197)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvAdj"
        Me.ShowInTaskbar = False
        Me.Text = "Inventory Adjustments"
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurItem As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents cmdFindItem As C1.Win.C1Input.C1Button
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents txtItem As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtType As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtItemDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtQty As C1.Win.C1Input.C1TextBox
    Friend WithEvents lstAction As ListBox
End Class
