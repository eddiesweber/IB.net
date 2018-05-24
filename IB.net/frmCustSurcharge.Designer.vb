<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustSurcharge
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
        Me.txtData19 = New System.Windows.Forms.TextBox()
        Me.cmdFindItem = New System.Windows.Forms.Button()
        Me.txtCustDept = New System.Windows.Forms.TextBox()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdFindCust = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lblCurItem = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtData19
        '
        Me.txtData19.ForeColor = System.Drawing.Color.Navy
        Me.txtData19.Location = New System.Drawing.Point(193, 151)
        Me.txtData19.Multiline = True
        Me.txtData19.Name = "txtData19"
        Me.txtData19.Size = New System.Drawing.Size(50, 20)
        Me.txtData19.TabIndex = 10
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(49, 91)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(71, 20)
        Me.cmdFindItem.TabIndex = 7
        Me.cmdFindItem.Text = "&Find"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        Me.cmdFindItem.Visible = False
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.Silver
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.ForeColor = System.Drawing.Color.Navy
        Me.txtCustDept.Location = New System.Drawing.Point(70, 42)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Size = New System.Drawing.Size(232, 13)
        Me.txtCustDept.TabIndex = 19
        Me.txtCustDept.TabStop = False
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.Silver
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.ForeColor = System.Drawing.Color.Navy
        Me.txtItemDesc.Location = New System.Drawing.Point(140, 70)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(225, 13)
        Me.txtItemDesc.TabIndex = 18
        Me.txtItemDesc.TabStop = False
        '
        'txtData3
        '
        Me.txtData3.ForeColor = System.Drawing.Color.Navy
        Me.txtData3.Location = New System.Drawing.Point(21, 112)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(15, 20)
        Me.txtData3.TabIndex = 8
        Me.txtData3.Visible = False
        '
        'txtData2
        '
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(49, 70)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(78, 20)
        Me.txtData2.TabIndex = 6
        Me.txtData2.Visible = False
        '
        'txtData0
        '
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(70, 7)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 20)
        Me.txtData0.TabIndex = 1
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(392, 35)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(71, 22)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(392, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 13
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(392, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(71, 22)
        Me.cmdNew.TabIndex = 11
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(161, 7)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(71, 20)
        Me.cmdFindCust.TabIndex = 2
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(392, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(392, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 14
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtData1
        '
        Me.txtData1.Enabled = False
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(315, 7)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(43, 20)
        Me.txtData1.TabIndex = 4
        Me.txtData1.Visible = False
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Silver
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.ForeColor = System.Drawing.Color.Navy
        Me.txtCustName.Location = New System.Drawing.Point(70, 28)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(232, 13)
        Me.txtCustName.TabIndex = 16
        Me.txtCustName.TabStop = False
        '
        'lstDept
        '
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(315, 7)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 56)
        Me.lstDept.TabIndex = 21
        '
        'lstItem
        '
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(49, 70)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(78, 56)
        Me.lstItem.TabIndex = 22
        '
        'lblCurItem
        '
        Me.lblCurItem.AutoSize = True
        Me.lblCurItem.Location = New System.Drawing.Point(7, 91)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(39, 13)
        Me.lblCurItem.TabIndex = 20
        Me.lblCurItem.Text = "Label1"
        Me.lblCurItem.Visible = False
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(148, 151)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel6.TabIndex = 9
        Me.lblLabel6.Text = "&Rate:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 70)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "&Item:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 7)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Customer:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(273, 7)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "&Dept:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(251, 7)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 17
        Me.lblCurCust.Text = "Label1"
        Me.lblCurCust.Visible = False
        '
        'frmCustSurcharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 190)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblCurItem)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.txtData19)
        Me.Location = New System.Drawing.Point(65, 153)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustSurcharge"
        Me.Text = "Add/Edit Customer Surcharge/Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtData19 As TextBox
    Friend WithEvents cmdFindItem As Button
    Friend WithEvents txtCustDept As TextBox
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents txtData3 As TextBox
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdFindCust As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lstDept As ListBox
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lblCurItem As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurCust As Label
End Class
