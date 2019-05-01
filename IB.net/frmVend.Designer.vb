<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVend
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
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblCurVend = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel6 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdFind = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.VendMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVendMaster_Vendor = New IB.net.dsVendMaster_Vendor()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.C1ContextMenu1 = New C1.Win.C1Command.C1ContextMenu()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.txmData0 = New C1.Win.C1Input.C1TextBox()
        Me.txmData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txmData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.VendMasterTableAdapter = New IB.net.dsVendMaster_VendorTableAdapters.VendMasterTableAdapter()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVendMaster_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(7, 237)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel12.TabIndex = 21
        Me.lblLabel12.Text = "E-mail:"
        '
        'lblCurVend
        '
        Me.lblCurVend.Location = New System.Drawing.Point(416, 174)
        Me.lblCurVend.Name = "lblCurVend"
        Me.lblCurVend.Size = New System.Drawing.Size(53, 15)
        Me.lblCurVend.TabIndex = 26
        Me.lblCurVend.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.Location = New System.Drawing.Point(7, 37)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel11.TabIndex = 3
        Me.lblLabel11.Text = "&Name:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(7, 112)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel10.TabIndex = 11
        Me.lblLabel10.Text = "&E-mail:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(7, 212)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel9.TabIndex = 19
        Me.lblLabel9.Text = "Phone:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(197, 87)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel7.TabIndex = 9
        Me.lblLabel7.Text = "&Fax:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(7, 187)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel6.TabIndex = 17
        Me.lblLabel6.Text = "Con&tact:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 162)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(62, 13)
        Me.lblLabel3.TabIndex = 15
        Me.lblLabel3.Text = "C&ity/St/Zip:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 137)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel2.TabIndex = 13
        Me.lblLabel2.Text = "&Address:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 87)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel4.TabIndex = 7
        Me.lblLabel4.Text = "&Phone:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 62)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(42, 13)
        Me.lblLabel1.TabIndex = 5
        Me.lblLabel1.Text = "A&cct #:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 12)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Vendor:"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(400, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 59
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(400, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 58
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(400, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 57
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(400, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 56
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(400, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 55
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(300, 10)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 25)
        Me.cmdFind.TabIndex = 60
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        Me.cmdFind.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFind.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "VENDOR", True))
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(75, 10)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(125, 18)
        Me.txtData0.TabIndex = 61
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'VendMasterBindingSource
        '
        Me.VendMasterBindingSource.DataMember = "VendMaster"
        Me.VendMasterBindingSource.DataSource = Me.DsVendMaster_Vendor
        '
        'DsVendMaster_Vendor
        '
        Me.DsVendMaster_Vendor.DataSetName = "dsVendMaster_Vendor"
        Me.DsVendMaster_Vendor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "VEND_NAME", True))
        Me.txtData10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData10.Location = New System.Drawing.Point(75, 35)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(200, 18)
        Me.txtData10.TabIndex = 63
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Acct", True))
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(75, 60)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(200, 18)
        Me.txtData1.TabIndex = 64
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1ContextMenu1
        '
        Me.C1ContextMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1})
        Me.C1ContextMenu1.Name = "C1ContextMenu1"
        Me.C1ContextMenu1.ShortcutText = ""
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Text = "New Command"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.C1ContextMenu1)
        Me.C1CommandHolder1.Owner = Me
        '
        'txmData0
        '
        Me.txmData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Phone", True))
        Me.txmData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData0.Location = New System.Drawing.Point(75, 85)
        Me.txmData0.Name = "txmData0"
        Me.txmData0.Size = New System.Drawing.Size(110, 18)
        Me.txmData0.TabIndex = 65
        Me.txmData0.Tag = Nothing
        Me.txmData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData1
        '
        Me.txmData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Fax", True))
        Me.txmData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData1.Location = New System.Drawing.Point(230, 85)
        Me.txmData1.Name = "txmData1"
        Me.txmData1.Size = New System.Drawing.Size(110, 18)
        Me.txmData1.TabIndex = 66
        Me.txmData1.Tag = Nothing
        Me.txmData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_email", True))
        Me.txtData8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData8.Location = New System.Drawing.Point(75, 110)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(175, 18)
        Me.txtData8.TabIndex = 68
        Me.txtData8.Tag = Nothing
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Add1", True))
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Location = New System.Drawing.Point(75, 135)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(200, 18)
        Me.txtData2.TabIndex = 69
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Add2", True))
        Me.txtData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData3.Location = New System.Drawing.Point(75, 160)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(200, 18)
        Me.txtData3.TabIndex = 70
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Contact", True))
        Me.txtData7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData7.Location = New System.Drawing.Point(75, 185)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(175, 18)
        Me.txtData7.TabIndex = 71
        Me.txtData7.Tag = Nothing
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData2
        '
        Me.txmData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Contact_Phone", True))
        Me.txmData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData2.Location = New System.Drawing.Point(75, 210)
        Me.txmData2.Name = "txmData2"
        Me.txmData2.Size = New System.Drawing.Size(110, 18)
        Me.txmData2.TabIndex = 72
        Me.txmData2.Tag = Nothing
        Me.txmData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VendMasterBindingSource, "Vend_Contact_email", True))
        Me.txtData11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData11.Location = New System.Drawing.Point(75, 235)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(175, 18)
        Me.txtData11.TabIndex = 73
        Me.txtData11.Tag = Nothing
        Me.txtData11.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'VendMasterTableAdapter
        '
        Me.VendMasterTableAdapter.ClearBeforeFill = True
        '
        'frmVend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 266)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txmData2)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.txmData1)
        Me.Controls.Add(Me.txmData0)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel6)
        Me.Controls.Add(Me.lblLabel7)
        Me.Controls.Add(Me.lblLabel9)
        Me.Controls.Add(Me.lblLabel10)
        Me.Controls.Add(Me.lblLabel11)
        Me.Controls.Add(Me.lblCurVend)
        Me.Controls.Add(Me.lblLabel12)
        Me.Location = New System.Drawing.Point(135, 112)
        Me.Name = "frmVend"
        Me.Text = "Add/Edit Vendors"
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVendMaster_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLabel12 As Label
    Friend WithEvents lblCurVend As Label
    Friend WithEvents lblLabel11 As Label
    Friend WithEvents lblLabel10 As Label
    Friend WithEvents lblLabel9 As Label
    Friend WithEvents lblLabel7 As Label
    Friend WithEvents lblLabel6 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFind As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents VendMasterBindingSource As BindingSource
    Friend WithEvents VendMasterTableAdapter As dsVendMaster_VendorTableAdapters.VendMasterTableAdapter
    Private WithEvents C1ContextMenu1 As C1.Win.C1Command.C1ContextMenu
    Private WithEvents DsVendMaster_Vendor As dsVendMaster_Vendor
End Class
