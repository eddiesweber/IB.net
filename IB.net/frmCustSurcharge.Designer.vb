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
        Me.components = New System.ComponentModel.Container()
        Me.CustomerSurchargeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomerSurcharge = New IB.net.dsCustomerSurcharge()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.SpGetCustDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetCustDept = New IB.net.dsspGetCustDept()
        Me.lstItem = New System.Windows.Forms.ListBox()
        Me.lblCurItem = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.txtCustDept = New C1.Win.C1Input.C1TextBox()
        Me.txtItemDesc = New C1.Win.C1Input.C1TextBox()
        Me.txtData19 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.SpGetCustDeptTableAdapter = New IB.net.dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter()
        Me.CustomerSurchargeTableAdapter = New IB.net.dsCustomerSurchargeTableAdapters.CustomerSurchargeTableAdapter()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.cmdFindItem = New C1.Win.C1Input.C1Button()
        CType(Me.CustomerSurchargeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerSurcharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerSurchargeBindingSource
        '
        Me.CustomerSurchargeBindingSource.DataMember = "CustomerSurcharge"
        Me.CustomerSurchargeBindingSource.DataSource = Me.DsCustomerSurcharge
        '
        'DsCustomerSurcharge
        '
        Me.DsCustomerSurcharge.DataSetName = "dsCustomerSurcharge"
        Me.DsCustomerSurcharge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstDept
        '
        Me.lstDept.DataSource = Me.SpGetCustDeptBindingSource
        Me.lstDept.DisplayMember = "DEPT"
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(315, 13)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(45, 56)
        Me.lstDept.TabIndex = 21
        '
        'SpGetCustDeptBindingSource
        '
        Me.SpGetCustDeptBindingSource.DataMember = "SpGetCustDept"
        Me.SpGetCustDeptBindingSource.DataSource = Me.DsspGetCustDept
        '
        'DsspGetCustDept
        '
        Me.DsspGetCustDept.DataSetName = "dsspGetCustDept"
        Me.DsspGetCustDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstItem
        '
        Me.lstItem.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomerSurchargeBindingSource, "Item_Num", True))
        Me.lstItem.DataSource = Me.CustomerSurchargeBindingSource
        Me.lstItem.DisplayMember = "Item_Num"
        Me.lstItem.FormattingEnabled = True
        Me.lstItem.Location = New System.Drawing.Point(70, 75)
        Me.lstItem.Name = "lstItem"
        Me.lstItem.Size = New System.Drawing.Size(78, 56)
        Me.lstItem.TabIndex = 22
        '
        'lblCurItem
        '
        Me.lblCurItem.AutoSize = True
        Me.lblCurItem.Location = New System.Drawing.Point(343, 164)
        Me.lblCurItem.Name = "lblCurItem"
        Me.lblCurItem.Size = New System.Drawing.Size(39, 13)
        Me.lblCurItem.TabIndex = 20
        Me.lblCurItem.Text = "Label1"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(162, 137)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel6.TabIndex = 9
        Me.lblLabel6.Text = "&Rate:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 76)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel2.TabIndex = 5
        Me.lblLabel2.Text = "&Item:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 19)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Customer:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(276, 13)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "&Dept:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(388, 164)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 17
        Me.lblCurCust.Text = "Label1"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(375, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 80
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(375, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 79
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(375, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 78
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(375, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 77
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(375, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 76
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(160, 10)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 87
        Me.cmdFindCust.Text = "&Find Cust"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetCustDeptBindingSource, "CUST_NUM", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Location = New System.Drawing.Point(70, 14)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(70, 18)
        Me.txtData0.TabIndex = 88
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Location = New System.Drawing.Point(70, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(230, 13)
        Me.txtCustName.TabIndex = 89
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtCustDept.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.Location = New System.Drawing.Point(70, 54)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Size = New System.Drawing.Size(230, 13)
        Me.txtCustDept.TabIndex = 90
        Me.txtCustDept.Tag = Nothing
        Me.txtCustDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtItemDesc.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtItemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemDesc.Location = New System.Drawing.Point(130, 75)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(230, 13)
        Me.txtItemDesc.TabIndex = 91
        Me.txtItemDesc.Tag = Nothing
        Me.txtItemDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData19
        '
        Me.txtData19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData19.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerSurchargeBindingSource, "Rate", True))
        Me.txtData19.DataType = GetType(Single)
        Me.txtData19.Location = New System.Drawing.Point(195, 134)
        Me.txtData19.Name = "txtData19"
        Me.txtData19.Size = New System.Drawing.Size(50, 18)
        Me.txtData19.TabIndex = 92
        Me.txtData19.Tag = Nothing
        Me.txtData19.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData19.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerSurchargeBindingSource, "Item_Num", True))
        Me.txtData2.DataType = GetType(Integer)
        Me.txtData2.Location = New System.Drawing.Point(209, 161)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(75, 18)
        Me.txtData2.TabIndex = 93
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SpGetCustDeptTableAdapter
        '
        Me.SpGetCustDeptTableAdapter.ClearBeforeFill = True
        '
        'CustomerSurchargeTableAdapter
        '
        Me.CustomerSurchargeTableAdapter.ClearBeforeFill = True
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerSurchargeBindingSource, "Item_Type", True))
        Me.txtData3.Location = New System.Drawing.Point(433, 162)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(22, 18)
        Me.txtData3.TabIndex = 94
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerSurchargeBindingSource, "Dept", True))
        Me.txtData1.DataType = GetType(Short)
        Me.txtData1.Location = New System.Drawing.Point(294, 161)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(43, 18)
        Me.txtData1.TabIndex = 95
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFindItem
        '
        Me.cmdFindItem.Location = New System.Drawing.Point(70, 94)
        Me.cmdFindItem.Name = "cmdFindItem"
        Me.cmdFindItem.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindItem.TabIndex = 96
        Me.cmdFindItem.Text = "Find &Item"
        Me.cmdFindItem.UseVisualStyleBackColor = True
        Me.cmdFindItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmCustSurcharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 184)
        Me.Controls.Add(Me.cmdFindItem)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData19)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtCustDept)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblCurItem)
        Me.Controls.Add(Me.lstItem)
        Me.Controls.Add(Me.lstDept)
        Me.Location = New System.Drawing.Point(65, 153)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustSurcharge"
        Me.Text = "Add/Edit Customer Surcharge/Discount"
        CType(Me.CustomerSurchargeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerSurcharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetCustDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFindItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstDept As ListBox
    Friend WithEvents lstItem As ListBox
    Friend WithEvents lblCurItem As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurCust As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustDept As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtItemDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData19 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Private WithEvents DsspGetCustDept As dsspGetCustDept
    Friend WithEvents SpGetCustDeptTableAdapter As dsspGetCustDeptTableAdapters.SpGetCustDeptTableAdapter
    Private WithEvents SpGetCustDeptBindingSource As BindingSource
    Friend WithEvents CustomerSurchargeBindingSource As BindingSource
    Friend WithEvents DsCustomerSurcharge As dsCustomerSurcharge
    Friend WithEvents CustomerSurchargeTableAdapter As dsCustomerSurchargeTableAdapters.CustomerSurchargeTableAdapter
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFindItem As C1.Win.C1Input.C1Button
End Class
