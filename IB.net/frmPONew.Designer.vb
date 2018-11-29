<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPONew
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
        Me.txtVendAcct = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.cmdRecAll = New System.Windows.Forms.Button()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtTotal3 = New System.Windows.Forms.TextBox()
        Me.txtTotal2 = New System.Windows.Forms.TextBox()
        Me.txtTotal1 = New System.Windows.Forms.TextBox()
        Me.txtTotal0 = New System.Windows.Forms.TextBox()
        Me.cmdDelItem = New System.Windows.Forms.Button()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txtVendName = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdFindPO = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurPO = New System.Windows.Forms.Label()
        Me.lblCurVend = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVendAcct
        '
        Me.txtVendAcct.BackColor = System.Drawing.Color.Silver
        Me.txtVendAcct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVendAcct.ForeColor = System.Drawing.Color.Navy
        Me.txtVendAcct.Location = New System.Drawing.Point(272, 8)
        Me.txtVendAcct.Name = "txtVendAcct"
        Me.txtVendAcct.Size = New System.Drawing.Size(16, 13)
        Me.txtVendAcct.TabIndex = 33
        Me.txtVendAcct.TabStop = False
        Me.txtVendAcct.Visible = False
        '
        'txtData3
        '
        Me.txtData3.ForeColor = System.Drawing.Color.Navy
        Me.txtData3.Location = New System.Drawing.Point(432, 56)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(102, 20)
        Me.txtData3.TabIndex = 31
        '
        'cmdRecAll
        '
        Me.cmdRecAll.Location = New System.Drawing.Point(648, 280)
        Me.cmdRecAll.Name = "cmdRecAll"
        Me.cmdRecAll.Size = New System.Drawing.Size(71, 22)
        Me.cmdRecAll.TabIndex = 20
        Me.cmdRecAll.Text = "&Receive All"
        Me.cmdRecAll.UseVisualStyleBackColor = True
        '
        'txtData2
        '
        Me.txtData2.Enabled = False
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(520, 8)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(102, 20)
        Me.txtData2.TabIndex = 30
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(648, 344)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(71, 22)
        Me.cmdPrint.TabIndex = 29
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'txtTotal3
        '
        Me.txtTotal3.Enabled = False
        Me.txtTotal3.ForeColor = System.Drawing.Color.Navy
        Me.txtTotal3.Location = New System.Drawing.Point(544, 528)
        Me.txtTotal3.Name = "txtTotal3"
        Me.txtTotal3.Size = New System.Drawing.Size(78, 20)
        Me.txtTotal3.TabIndex = 27
        '
        'txtTotal2
        '
        Me.txtTotal2.Enabled = False
        Me.txtTotal2.ForeColor = System.Drawing.Color.Navy
        Me.txtTotal2.Location = New System.Drawing.Point(416, 528)
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.Size = New System.Drawing.Size(46, 20)
        Me.txtTotal2.TabIndex = 25
        '
        'txtTotal1
        '
        Me.txtTotal1.Enabled = False
        Me.txtTotal1.ForeColor = System.Drawing.Color.Navy
        Me.txtTotal1.Location = New System.Drawing.Point(296, 528)
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.Size = New System.Drawing.Size(46, 20)
        Me.txtTotal1.TabIndex = 23
        '
        'txtTotal0
        '
        Me.txtTotal0.Enabled = False
        Me.txtTotal0.ForeColor = System.Drawing.Color.Navy
        Me.txtTotal0.Location = New System.Drawing.Point(192, 528)
        Me.txtTotal0.Name = "txtTotal0"
        Me.txtTotal0.Size = New System.Drawing.Size(46, 20)
        Me.txtTotal0.TabIndex = 21
        '
        'cmdDelItem
        '
        Me.cmdDelItem.Location = New System.Drawing.Point(648, 212)
        Me.cmdDelItem.Name = "cmdDelItem"
        Me.cmdDelItem.Size = New System.Drawing.Size(71, 22)
        Me.cmdDelItem.TabIndex = 19
        Me.cmdDelItem.Text = "De&lete Item"
        Me.cmdDelItem.UseVisualStyleBackColor = True
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(648, 184)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(71, 22)
        Me.cmdAddItem.TabIndex = 18
        Me.cmdAddItem.Text = "&Add Item"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'txtData1
        '
        Me.txtData1.Enabled = False
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(78, 32)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(102, 20)
        Me.txtData1.TabIndex = 4
        '
        'txtVendName
        '
        Me.txtVendName.BackColor = System.Drawing.Color.Silver
        Me.txtVendName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVendName.ForeColor = System.Drawing.Color.Navy
        Me.txtVendName.Location = New System.Drawing.Point(192, 32)
        Me.txtVendName.Name = "txtVendName"
        Me.txtVendName.Size = New System.Drawing.Size(232, 13)
        Me.txtVendName.TabIndex = 5
        Me.txtVendName.TabStop = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(648, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 22)
        Me.cmdUpdate.TabIndex = 14
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(648, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 22)
        Me.cmdExit.TabIndex = 15
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdFindPO
        '
        Me.cmdFindPO.Location = New System.Drawing.Point(192, 7)
        Me.cmdFindPO.Name = "cmdFindPO"
        Me.cmdFindPO.Size = New System.Drawing.Size(75, 22)
        Me.cmdFindPO.TabIndex = 2
        Me.cmdFindPO.Text = "&Find"
        Me.cmdFindPO.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(648, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 22)
        Me.cmdNew.TabIndex = 11
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(648, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 22)
        Me.cmdReset.TabIndex = 13
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(648, 35)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 22)
        Me.cmdDelete.TabIndex = 12
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtData0
        '
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(78, 7)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(102, 20)
        Me.txtData0.TabIndex = 1
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(376, 58)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel4.TabIndex = 32
        Me.lblLabel4.Text = "&Invoice:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(192, 58)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(51, 13)
        Me.lblLabel3.TabIndex = 8
        Me.lblLabel3.Text = "&Location:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(8, 56)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(74, 13)
        Me.lblLabel2.TabIndex = 6
        Me.lblLabel2.Text = "Delivery Da&te:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Back Order:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Received:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total Ordered:"
        '
        'lblCurPO
        '
        Me.lblCurPO.Location = New System.Drawing.Point(520, 32)
        Me.lblCurPO.Name = "lblCurPO"
        Me.lblCurPO.Size = New System.Drawing.Size(73, 17)
        Me.lblCurPO.TabIndex = 17
        Me.lblCurPO.Visible = False
        '
        'lblCurVend
        '
        Me.lblCurVend.Location = New System.Drawing.Point(424, 32)
        Me.lblCurVend.Name = "lblCurVend"
        Me.lblCurVend.Size = New System.Drawing.Size(73, 17)
        Me.lblCurVend.TabIndex = 16
        Me.lblCurVend.Visible = False
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(8, 34)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "&Vendor:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 10)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&PO #:"
        '
        'frmPONew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 555)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblCurVend)
        Me.Controls.Add(Me.lblCurPO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdFindPO)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtVendName)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.cmdDelItem)
        Me.Controls.Add(Me.txtTotal0)
        Me.Controls.Add(Me.txtTotal1)
        Me.Controls.Add(Me.txtTotal2)
        Me.Controls.Add(Me.txtTotal3)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.cmdRecAll)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtVendAcct)
        Me.Location = New System.Drawing.Point(87, 78)
        Me.Name = "frmPONew"
        Me.Text = "Add/Edit Purchase Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVendAcct As TextBox
    Friend WithEvents txtData3 As TextBox
    Friend WithEvents cmdRecAll As Button
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents cmdPrint As Button
    Friend WithEvents txtTotal3 As TextBox
    Friend WithEvents txtTotal2 As TextBox
    Friend WithEvents txtTotal1 As TextBox
    Friend WithEvents txtTotal0 As TextBox
    Friend WithEvents cmdDelItem As Button
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txtVendName As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdFindPO As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurPO As Label
    Friend WithEvents lblCurVend As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
End Class
