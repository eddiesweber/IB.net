<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDept
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
        Me.txtData9 = New System.Windows.Forms.TextBox()
        Me.cmdSurcharge = New System.Windows.Forms.Button()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.cmbTax = New System.Windows.Forms.ComboBox()
        Me.txtTaxState = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txtData10 = New System.Windows.Forms.TextBox()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdFindCust = New System.Windows.Forms.Button()
        Me.cmdItem = New System.Windows.Forms.Button()
        Me.txtData8 = New System.Windows.Forms.TextBox()
        Me.txtData7 = New System.Windows.Forms.TextBox()
        Me.txtData11 = New System.Windows.Forms.TextBox()
        Me.txtData6 = New System.Windows.Forms.TextBox()
        Me.txtData5 = New System.Windows.Forms.TextBox()
        Me.txtData4 = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.txmData0 = New System.Windows.Forms.MaskedTextBox()
        Me.txmData1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtData9
        '
        Me.txtData9.ForeColor = System.Drawing.Color.Navy
        Me.txtData9.Location = New System.Drawing.Point(213, 189)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(161, 20)
        Me.txtData9.TabIndex = 22
        '
        'cmdSurcharge
        '
        Me.cmdSurcharge.Location = New System.Drawing.Point(216, 400)
        Me.cmdSurcharge.Name = "cmdSurcharge"
        Me.cmdSurcharge.Size = New System.Drawing.Size(155, 23)
        Me.cmdSurcharge.TabIndex = 42
        Me.cmdSurcharge.Text = "S&urcharge/Discount"
        Me.cmdSurcharge.UseVisualStyleBackColor = True
        '
        'lstDept
        '
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(329, 7)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 69)
        Me.lstDept.TabIndex = 41
        '
        'cmbTax
        '
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Location = New System.Drawing.Point(77, 217)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(57, 21)
        Me.cmbTax.TabIndex = 25
        '
        'txtTaxState
        '
        Me.txtTaxState.Location = New System.Drawing.Point(420, 217)
        Me.txtTaxState.Name = "txtTaxState"
        Me.txtTaxState.Size = New System.Drawing.Size(22, 20)
        Me.txtTaxState.TabIndex = 26
        Me.txtTaxState.Visible = False
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Silver
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.ForeColor = System.Drawing.Color.Navy
        Me.txtCustName.Location = New System.Drawing.Point(77, 28)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(232, 13)
        Me.txtCustName.TabIndex = 40
        Me.txtCustName.TabStop = False
        '
        'txtData1
        '
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(322, 7)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(50, 20)
        Me.txtData1.TabIndex = 4
        Me.txtData1.Visible = False
        '
        'txtData10
        '
        Me.txtData10.ForeColor = System.Drawing.Color.Navy
        Me.txtData10.Location = New System.Drawing.Point(64, 217)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(22, 20)
        Me.txtData10.TabIndex = 24
        Me.txtData10.Visible = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(399, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 37
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(399, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 38
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(168, 7)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(71, 20)
        Me.cmdFindCust.TabIndex = 2
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        '
        'cmdItem
        '
        Me.cmdItem.Location = New System.Drawing.Point(40, 400)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(155, 20)
        Me.cmdItem.TabIndex = 33
        Me.cmdItem.Text = "&Items"
        Me.cmdItem.UseVisualStyleBackColor = True
        '
        'txtData8
        '
        Me.txtData8.ForeColor = System.Drawing.Color.Navy
        Me.txtData8.Location = New System.Drawing.Point(77, 273)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(295, 20)
        Me.txtData8.TabIndex = 31
        '
        'txtData7
        '
        Me.txtData7.ForeColor = System.Drawing.Color.Navy
        Me.txtData7.Location = New System.Drawing.Point(77, 133)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(162, 20)
        Me.txtData7.TabIndex = 14
        '
        'txtData11
        '
        Me.txtData11.ForeColor = System.Drawing.Color.Navy
        Me.txtData11.Location = New System.Drawing.Point(261, 160)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(113, 20)
        Me.txtData11.TabIndex = 18
        '
        'txtData6
        '
        Me.txtData6.ForeColor = System.Drawing.Color.Navy
        Me.txtData6.Location = New System.Drawing.Point(231, 105)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(78, 20)
        Me.txtData6.TabIndex = 12
        '
        'txtData5
        '
        Me.txtData5.ForeColor = System.Drawing.Color.Navy
        Me.txtData5.Location = New System.Drawing.Point(196, 105)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(29, 20)
        Me.txtData5.TabIndex = 11
        '
        'txtData4
        '
        Me.txtData4.ForeColor = System.Drawing.Color.Navy
        Me.txtData4.Location = New System.Drawing.Point(77, 105)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(113, 20)
        Me.txtData4.TabIndex = 10
        '
        'txtData3
        '
        Me.txtData3.ForeColor = System.Drawing.Color.Navy
        Me.txtData3.Location = New System.Drawing.Point(77, 77)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(232, 20)
        Me.txtData3.TabIndex = 8
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(399, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(71, 22)
        Me.cmdNew.TabIndex = 34
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(399, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 36
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(399, 35)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(71, 22)
        Me.cmdDelete.TabIndex = 35
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtData0
        '
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(77, 7)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 20)
        Me.txtData0.TabIndex = 1
        '
        'txtData2
        '
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(77, 49)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(232, 20)
        Me.txtData2.TabIndex = 6
        '
        'txmData0
        '
        Me.txmData0.ForeColor = System.Drawing.Color.Navy
        Me.txmData0.Location = New System.Drawing.Point(77, 161)
        Me.txmData0.Name = "txmData0"
        Me.txmData0.Size = New System.Drawing.Size(92, 20)
        Me.txmData0.TabIndex = 16
        '
        'txmData1
        '
        Me.txmData1.ForeColor = System.Drawing.Color.Navy
        Me.txmData1.Location = New System.Drawing.Point(77, 189)
        Me.txmData1.Name = "txmData1"
        Me.txmData1.Size = New System.Drawing.Size(92, 20)
        Me.txmData1.TabIndex = 20
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(8, 189)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel12.TabIndex = 19
        Me.lblLabel12.Text = "&Fax:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(175, 189)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel5.TabIndex = 21
        Me.lblLabel5.Text = "&Email:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(245, 9)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 39
        Me.lblCurCust.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.ForeColor = System.Drawing.Color.Black
        Me.lblLabel11.Location = New System.Drawing.Point(7, 273)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(53, 13)
        Me.lblLabel11.TabIndex = 30
        Me.lblLabel11.Text = "&Message:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(182, 161)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(68, 13)
        Me.lblLabel10.TabIndex = 17
        Me.lblLabel10.Text = "&Salesperson:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(7, 245)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(99, 13)
        Me.lblLabel9.TabIndex = 27
        Me.lblLabel9.Text = "Cont&ract Start/End:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(280, 7)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel8.TabIndex = 3
        Me.lblLabel8.Text = "&Dept:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(7, 217)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel7.TabIndex = 23
        Me.lblLabel7.Text = "&Tax Code:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(7, 133)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel6.TabIndex = 13
        Me.lblLabel6.Text = "Con&tact:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 105)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel3.TabIndex = 9
        Me.lblLabel3.Text = "C&ity, ST Zip:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 77)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel2.TabIndex = 7
        Me.lblLabel2.Text = "&Address:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 161)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel4.TabIndex = 15
        Me.lblLabel4.Text = "&Phone:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 49)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel1.TabIndex = 5
        Me.lblLabel1.Text = "&Name:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 7)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Customer:"
        '
        'frmDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 425)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel8)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.lblLabel10)
        Me.Controls.Add(Me.lblLabel11)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel12)
        Me.Controls.Add(Me.txmData1)
        Me.Controls.Add(Me.txmData0)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.cmdItem)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtTaxState)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.cmdSurcharge)
        Me.Controls.Add(Me.txtData9)
        Me.Location = New System.Drawing.Point(87, 78)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDept"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Departments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtData9 As TextBox
    Friend WithEvents cmdSurcharge As Button
    Friend WithEvents lstDept As ListBox
    Friend WithEvents cmbTax As ComboBox
    Friend WithEvents txtTaxState As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txtData10 As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdFindCust As Button
    Friend WithEvents cmdItem As Button
    Friend WithEvents txtData8 As TextBox
    Friend WithEvents txtData7 As TextBox
    Friend WithEvents txtData11 As TextBox
    Friend WithEvents txtData6 As TextBox
    Friend WithEvents txtData5 As TextBox
    Friend WithEvents txtData4 As TextBox
    Friend WithEvents txtData3 As TextBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents txmData0 As MaskedTextBox
    Friend WithEvents txmData1 As MaskedTextBox
    Friend WithEvents lblLabel12 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents lblLabel11 As Label
    Friend WithEvents lblLabel10 As Label
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
End Class
