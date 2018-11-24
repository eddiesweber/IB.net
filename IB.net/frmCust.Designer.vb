<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCust
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chkData = New System.Windows.Forms.CheckBox()
        Me.CustomerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CustomerMaster1 = New IB.net.DS_CustomerMaster()
        Me.optData1 = New System.Windows.Forms.RadioButton()
        Me.optData0 = New System.Windows.Forms.RadioButton()
        Me.txtData12 = New System.Windows.Forms.TextBox()
        Me.txtData11 = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.txtData10 = New System.Windows.Forms.TextBox()
        Me.cmdEditDept = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.txtData9 = New System.Windows.Forms.TextBox()
        Me.txtData8 = New System.Windows.Forms.TextBox()
        Me.txtData7 = New System.Windows.Forms.TextBox()
        Me.txtData6 = New System.Windows.Forms.TextBox()
        Me.txtData5 = New System.Windows.Forms.TextBox()
        Me.txtData4 = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txmData1 = New System.Windows.Forms.MaskedTextBox()
        Me.txmData0 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.CustomerMasterTableAdapter = New IB.net.DS_CustomerMasterTableAdapters.CustomerMasterTableAdapter()
        Me.C1SuperErrorProvider1 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CustomerMaster1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkData
        '
        Me.chkData.AutoSize = True
        Me.chkData.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustomerMasterBindingSource, "MAIL_STATEMENT", True))
        Me.chkData.Location = New System.Drawing.Point(242, 291)
        Me.chkData.Name = "chkData"
        Me.chkData.Size = New System.Drawing.Size(72, 17)
        Me.chkData.TabIndex = 41
        Me.chkData.Text = "Mail Stmt:"
        Me.chkData.UseVisualStyleBackColor = True
        '
        'CustomerMasterBindingSource
        '
        Me.CustomerMasterBindingSource.DataMember = "CustomerMaster"
        Me.CustomerMasterBindingSource.DataSource = Me.DS_CustomerMaster1
        '
        'DS_CustomerMaster1
        '
        Me.DS_CustomerMaster1.DataSetName = "DS_CustomerMaster"
        Me.DS_CustomerMaster1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'optData1
        '
        Me.optData1.AutoSize = True
        Me.optData1.Location = New System.Drawing.Point(135, 291)
        Me.optData1.Name = "optData1"
        Me.optData1.Size = New System.Drawing.Size(86, 17)
        Me.optData1.TabIndex = 40
        Me.optData1.TabStop = True
        Me.optData1.Tag = "I"
        Me.optData1.Text = "Cash or Card"
        Me.optData1.UseVisualStyleBackColor = True
        '
        'optData0
        '
        Me.optData0.AutoSize = True
        Me.optData0.Location = New System.Drawing.Point(78, 291)
        Me.optData0.Name = "optData0"
        Me.optData0.Size = New System.Drawing.Size(52, 17)
        Me.optData0.TabIndex = 39
        Me.optData0.TabStop = True
        Me.optData0.Tag = "A"
        Me.optData0.Text = "Credit"
        Me.optData0.UseVisualStyleBackColor = True
        '
        'txtData12
        '
        Me.txtData12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "Last_Change", True))
        Me.txtData12.ForeColor = System.Drawing.Color.Navy
        Me.txtData12.Location = New System.Drawing.Point(364, 273)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Size = New System.Drawing.Size(57, 20)
        Me.txtData12.TabIndex = 38
        Me.txtData12.Visible = False
        '
        'txtData11
        '
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "CC_NUM", True))
        Me.txtData11.ForeColor = System.Drawing.Color.Navy
        Me.txtData11.Location = New System.Drawing.Point(77, 315)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(162, 20)
        Me.txtData11.TabIndex = 28
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(503, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 37
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(503, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 36
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(238, 7)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(71, 22)
        Me.cmdFind.TabIndex = 34
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtData10
        '
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "COUNTY", True))
        Me.txtData10.ForeColor = System.Drawing.Color.Navy
        Me.txtData10.Location = New System.Drawing.Point(77, 147)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(113, 20)
        Me.txtData10.TabIndex = 13
        '
        'cmdEditDept
        '
        Me.cmdEditDept.Location = New System.Drawing.Point(77, 350)
        Me.cmdEditDept.Name = "cmdEditDept"
        Me.cmdEditDept.Size = New System.Drawing.Size(176, 22)
        Me.cmdEditDept.TabIndex = 33
        Me.cmdEditDept.Text = "&Departments/Routes"
        Me.cmdEditDept.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "PAY_TYPE", True))
        Me.txtOption.Location = New System.Drawing.Point(49, 287)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(20, 20)
        Me.txtOption.TabIndex = 29
        Me.txtOption.Visible = False
        '
        'txtData9
        '
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "URL", True))
        Me.txtData9.ForeColor = System.Drawing.Color.Navy
        Me.txtData9.Location = New System.Drawing.Point(77, 259)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(162, 20)
        Me.txtData9.TabIndex = 23
        '
        'txtData8
        '
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "EMAIL", True))
        Me.txtData8.ForeColor = System.Drawing.Color.Navy
        Me.txtData8.Location = New System.Drawing.Point(77, 231)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(162, 20)
        Me.txtData8.TabIndex = 21
        '
        'txtData7
        '
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "CONTACT", True))
        Me.txtData7.ForeColor = System.Drawing.Color.Navy
        Me.txtData7.Location = New System.Drawing.Point(77, 175)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(162, 20)
        Me.txtData7.TabIndex = 15
        '
        'txtData6
        '
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "CARE_OF", True))
        Me.txtData6.ForeColor = System.Drawing.Color.Navy
        Me.txtData6.Location = New System.Drawing.Point(77, 119)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(162, 20)
        Me.txtData6.TabIndex = 11
        '
        'txtData5
        '
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "BILL_ZIP", True))
        Me.txtData5.ForeColor = System.Drawing.Color.Navy
        Me.txtData5.Location = New System.Drawing.Point(231, 91)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(78, 20)
        Me.txtData5.TabIndex = 9
        '
        'txtData4
        '
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "BILL_STATE", True))
        Me.txtData4.ForeColor = System.Drawing.Color.Navy
        Me.txtData4.Location = New System.Drawing.Point(196, 91)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(29, 20)
        Me.txtData4.TabIndex = 8
        '
        'txtData3
        '
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "BILL_CTY", True))
        Me.txtData3.ForeColor = System.Drawing.Color.Navy
        Me.txtData3.Location = New System.Drawing.Point(77, 91)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(92, 20)
        Me.txtData3.TabIndex = 3
        '
        'txtData2
        '
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "BILL_STR", True))
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(77, 63)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(232, 20)
        Me.txtData2.TabIndex = 5
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(503, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(71, 22)
        Me.cmdNew.TabIndex = 30
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(503, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 42
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(503, 35)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(71, 22)
        Me.cmdDelete.TabIndex = 31
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'txtData0
        '
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "CUST_NUM", True))
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(112, 7)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 20)
        Me.txtData0.TabIndex = 1
        '
        'txtData1
        '
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "BILL_NAME", True))
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(77, 35)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(232, 20)
        Me.txtData1.TabIndex = 3
        '
        'txmData1
        '
        Me.txmData1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "FAX_NO", True))
        Me.txmData1.ForeColor = System.Drawing.Color.Navy
        Me.txmData1.Location = New System.Drawing.Point(217, 203)
        Me.txmData1.Name = "txmData1"
        Me.txmData1.Size = New System.Drawing.Size(92, 20)
        Me.txmData1.TabIndex = 19
        '
        'txmData0
        '
        Me.txmData0.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerMasterBindingSource, "PHONE", True))
        Me.txmData0.ForeColor = System.Drawing.Color.Navy
        Me.txmData0.Location = New System.Drawing.Point(77, 203)
        Me.txmData0.Name = "txmData0"
        Me.txmData0.Size = New System.Drawing.Size(92, 20)
        Me.txmData0.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Notes:"
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(7, 315)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(69, 13)
        Me.lblLabel12.TabIndex = 27
        Me.lblLabel12.Text = "C&redit Card #"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(203, 7)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 35
        Me.lblCurCust.Text = "Label2"
        Me.lblCurCust.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.Location = New System.Drawing.Point(7, 147)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel11.TabIndex = 12
        Me.lblLabel11.Text = "Count&y:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(7, 231)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel10.TabIndex = 20
        Me.lblLabel10.Text = "&E-mail:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(7, 259)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(32, 13)
        Me.lblLabel9.TabIndex = 22
        Me.lblLabel9.Text = "&URL:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(7, 287)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel8.TabIndex = 24
        Me.lblLabel8.Text = "Pay &By:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(182, 203)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel7.TabIndex = 18
        Me.lblLabel7.Text = "&Fax:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(7, 175)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel6.TabIndex = 14
        Me.lblLabel6.Text = "Con&tact:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 91)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel3.TabIndex = 6
        Me.lblLabel3.Text = "C&ity/St/ Zip:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 63)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel2.TabIndex = 4
        Me.lblLabel2.Text = "&Address:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(7, 119)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel5.TabIndex = 10
        Me.lblLabel5.Text = "Care/&Of:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 203)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel4.TabIndex = 16
        Me.lblLabel4.Text = "&Phone:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(7, 35)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel.TabIndex = 2
        Me.lblLabel.Text = "&Name:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 7)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Customer Number:"
        '
        'CustomerMasterTableAdapter
        '
        Me.CustomerMasterTableAdapter.ClearBeforeFill = True
        '
        'C1SuperErrorProvider1
        '
        Me.C1SuperErrorProvider1.ContainerControl = Me
        Me.C1SuperErrorProvider1.ToolTip = Me.C1SuperTooltip1
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        '
        'frmCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 378)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel8)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.lblLabel10)
        Me.Controls.Add(Me.lblLabel11)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txmData0)
        Me.Controls.Add(Me.txmData1)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.cmdEditDept)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData12)
        Me.Controls.Add(Me.optData0)
        Me.Controls.Add(Me.optData1)
        Me.Controls.Add(Me.chkData)
        Me.Location = New System.Drawing.Point(134, 111)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCust"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Customers"
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CustomerMaster1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkData As CheckBox
    Friend WithEvents optData1 As RadioButton
    Friend WithEvents optData0 As RadioButton
    Friend WithEvents txtData12 As TextBox
    Friend WithEvents txtData11 As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdFind As Button
    Friend WithEvents txtData10 As TextBox
    Friend WithEvents cmdEditDept As Button
    Friend WithEvents txtOption As TextBox
    Friend WithEvents txtData9 As TextBox
    Friend WithEvents txtData8 As TextBox
    Friend WithEvents txtData7 As TextBox
    Friend WithEvents txtData6 As TextBox
    Friend WithEvents txtData5 As TextBox
    Friend WithEvents txtData4 As TextBox
    Friend WithEvents txtData3 As TextBox
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txmData1 As MaskedTextBox
    Friend WithEvents txmData0 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLabel12 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents lblLabel11 As Label
    Friend WithEvents lblLabel10 As Label
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblLabel8 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents DS_CustomerMaster1 As DS_CustomerMaster
    Friend WithEvents CustomerMasterBindingSource As BindingSource
    Friend WithEvents CustomerMasterTableAdapter As DS_CustomerMasterTableAdapters.CustomerMasterTableAdapter
    Friend WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
End Class
