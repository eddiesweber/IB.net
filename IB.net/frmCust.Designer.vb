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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCust))
        Me.CustomerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CustomerMaster1 = New IB.net.DS_CustomerMaster()
        Me.optData1 = New System.Windows.Forms.RadioButton()
        Me.optData0 = New System.Windows.Forms.RadioButton()
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
        Me.cmdFind = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdEditDept = New C1.Win.C1Input.C1Button()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.txmData0 = New C1.Win.C1Input.C1TextBox()
        Me.txmData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData12 = New C1.Win.C1Input.C1TextBox()
        Me.txtOption = New C1.Win.C1Input.C1TextBox()
        Me.chkData = New C1.Win.C1Input.C1CheckBox()
        Me.txtData17 = New C1.Win.C1Input.C1TextBox()
        Me.txtLastChanged = New C1.Win.C1Input.C1TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CustomerMaster1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdEditDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastChanged, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.optData1.Location = New System.Drawing.Point(141, 265)
        Me.optData1.Name = "optData1"
        Me.optData1.Size = New System.Drawing.Size(86, 17)
        Me.optData1.TabIndex = 13
        Me.optData1.TabStop = True
        Me.optData1.Tag = "I"
        Me.optData1.Text = "Cash or Card"
        Me.optData1.UseVisualStyleBackColor = True
        '
        'optData0
        '
        Me.optData0.AutoSize = True
        Me.optData0.Location = New System.Drawing.Point(82, 265)
        Me.optData0.Name = "optData0"
        Me.optData0.Size = New System.Drawing.Size(52, 17)
        Me.optData0.TabIndex = 12
        Me.optData0.TabStop = True
        Me.optData0.Tag = "A"
        Me.optData0.Text = "Credit"
        Me.optData0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Notes:"
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(7, 292)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(69, 13)
        Me.lblLabel12.TabIndex = 27
        Me.lblLabel12.Text = "C&redit Card #"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(518, 217)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(44, 13)
        Me.lblCurCust.TabIndex = 35
        Me.lblCurCust.Text = "CurCust"
        Me.lblCurCust.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.Location = New System.Drawing.Point(7, 142)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel11.TabIndex = 12
        Me.lblLabel11.Text = "Count&y:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(7, 217)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel10.TabIndex = 20
        Me.lblLabel10.Text = "&E-mail:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(7, 242)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(32, 13)
        Me.lblLabel9.TabIndex = 22
        Me.lblLabel9.Text = "&URL:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(7, 267)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(43, 13)
        Me.lblLabel8.TabIndex = 24
        Me.lblLabel8.Text = "Pay &By:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(185, 192)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel7.TabIndex = 1
        Me.lblLabel7.Text = "&Fax:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(7, 167)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel6.TabIndex = 14
        Me.lblLabel6.Text = "Con&tact:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 92)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel3.TabIndex = 6
        Me.lblLabel3.Text = "C&ity/St/ Zip:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 67)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel2.TabIndex = 4
        Me.lblLabel2.Text = "&Address:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(7, 117)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel5.TabIndex = 10
        Me.lblLabel5.Text = "Care/&Of:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 192)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel4.TabIndex = 16
        Me.lblLabel4.Text = "&Phone:"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(7, 42)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel.TabIndex = 2
        Me.lblLabel.Text = "&Name:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 16)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 0
        Me.lblLabel0.Text = "&Customer:"
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
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(225, 10)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 25)
        Me.cmdFind.TabIndex = 23
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        Me.cmdFind.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFind.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(496, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 17
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(496, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 18
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(496, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 19
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(496, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 20
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(496, 131)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdEditDept
        '
        Me.cmdEditDept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdEditDept.Location = New System.Drawing.Point(80, 315)
        Me.cmdEditDept.Name = "cmdEditDept"
        Me.cmdEditDept.Size = New System.Drawing.Size(230, 25)
        Me.cmdEditDept.TabIndex = 22
        Me.cmdEditDept.Text = "&Departments/Routes"
        Me.cmdEditDept.UseVisualStyleBackColor = True
        Me.cmdEditDept.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdEditDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "CUST_NUM", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Enabled = False
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(80, 14)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(75, 18)
        Me.txtData0.TabIndex = 50
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "BILL_NAME", True))
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(80, 40)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(230, 18)
        Me.txtData1.TabIndex = 0
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "BILL_STR", True))
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Location = New System.Drawing.Point(80, 65)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(230, 18)
        Me.txtData2.TabIndex = 1
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "BILL_CTY", True))
        Me.txtData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData3.Location = New System.Drawing.Point(80, 90)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(100, 18)
        Me.txtData3.TabIndex = 2
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "BILL_STATE", True))
        Me.txtData4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData4.Location = New System.Drawing.Point(190, 90)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(30, 18)
        Me.txtData4.TabIndex = 3
        Me.txtData4.Tag = Nothing
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "BILL_ZIP", True))
        Me.txtData5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData5.Location = New System.Drawing.Point(230, 90)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(80, 18)
        Me.txtData5.TabIndex = 4
        Me.txtData5.Tag = Nothing
        Me.txtData5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "CARE_OF", True))
        Me.txtData6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData6.Location = New System.Drawing.Point(80, 115)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(160, 18)
        Me.txtData6.TabIndex = 5
        Me.txtData6.Tag = Nothing
        Me.txtData6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "COUNTY", True))
        Me.txtData10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData10.Location = New System.Drawing.Point(80, 140)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(100, 18)
        Me.txtData10.TabIndex = 6
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "CONTACT", True))
        Me.txtData7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData7.Location = New System.Drawing.Point(80, 165)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(160, 18)
        Me.txtData7.TabIndex = 7
        Me.txtData7.Tag = Nothing
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "EMAIL", True))
        Me.txtData8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData8.Location = New System.Drawing.Point(80, 215)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(230, 18)
        Me.txtData8.TabIndex = 10
        Me.txtData8.Tag = Nothing
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData9
        '
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "URL", True))
        Me.txtData9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData9.Location = New System.Drawing.Point(80, 240)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(230, 18)
        Me.txtData9.TabIndex = 11
        Me.txtData9.Tag = Nothing
        Me.txtData9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "CC_NUM", True))
        Me.txtData11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData11.Location = New System.Drawing.Point(80, 290)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(160, 18)
        Me.txtData11.TabIndex = 15
        Me.txtData11.Tag = Nothing
        Me.txtData11.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData0
        '
        Me.txmData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "PHONE", True))
        Me.txmData0.EditMask = "(999)000-0000"
        Me.txmData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData0.Location = New System.Drawing.Point(80, 190)
        Me.txmData0.Name = "txmData0"
        Me.txmData0.Size = New System.Drawing.Size(100, 18)
        Me.txmData0.TabIndex = 8
        Me.txmData0.Tag = Nothing
        Me.txmData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData1
        '
        Me.txmData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "FAX_NO", True))
        Me.txmData1.EditMask = "(999)000-0000"
        Me.txmData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData1.Location = New System.Drawing.Point(210, 190)
        Me.txmData1.Name = "txmData1"
        Me.txmData1.Size = New System.Drawing.Size(100, 18)
        Me.txmData1.TabIndex = 9
        Me.txmData1.Tag = Nothing
        Me.txmData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData12
        '
        Me.txtData12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData12.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "Last_Change", True))
        Me.txtData12.DataType = GetType(Date)
        Me.txtData12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData12.Location = New System.Drawing.Point(253, 290)
        Me.txtData12.Name = "txtData12"
        Me.txtData12.Size = New System.Drawing.Size(57, 18)
        Me.txtData12.TabIndex = 64
        Me.txtData12.Tag = Nothing
        Me.txtData12.Visible = False
        Me.txtData12.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData12.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtOption
        '
        Me.txtOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOption.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "PAY_TYPE", True))
        Me.txtOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOption.Location = New System.Drawing.Point(556, 322)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(20, 18)
        Me.txtOption.TabIndex = 65
        Me.txtOption.Tag = Nothing
        Me.txtOption.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtOption.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkData
        '
        Me.chkData.BackColor = System.Drawing.Color.Transparent
        Me.chkData.BorderColor = System.Drawing.Color.Transparent
        Me.chkData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkData.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "MAIL_STATEMENT", True))
        Me.chkData.ForeColor = System.Drawing.Color.Black
        Me.chkData.Location = New System.Drawing.Point(241, 263)
        Me.chkData.Name = "chkData"
        Me.chkData.Padding = New System.Windows.Forms.Padding(1)
        Me.chkData.Size = New System.Drawing.Size(104, 24)
        Me.chkData.TabIndex = 14
        Me.chkData.Text = "Mail Stmt"
        Me.chkData.UseVisualStyleBackColor = True
        Me.chkData.Value = Nothing
        Me.chkData.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkData.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData17
        '
        Me.txtData17.AutoSize = False
        Me.txtData17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtData17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData17.Location = New System.Drawing.Point(325, 40)
        Me.txtData17.Multiline = True
        Me.txtData17.Name = "txtData17"
        Me.txtData17.Size = New System.Drawing.Size(140, 115)
        Me.txtData17.TabIndex = 16
        Me.txtData17.Tag = Nothing
        Me.txtData17.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData17.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtLastChanged
        '
        Me.txtLastChanged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastChanged.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerMasterBindingSource, "Last_Change", True))
        Me.txtLastChanged.DataType = GetType(Date)
        Me.txtLastChanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastChanged.Location = New System.Drawing.Point(496, 237)
        Me.txtLastChanged.Name = "txtLastChanged"
        Me.txtLastChanged.Size = New System.Drawing.Size(80, 18)
        Me.txtLastChanged.TabIndex = 66
        Me.txtLastChanged.Tag = Nothing
        Me.txtLastChanged.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtLastChanged.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(594, 351)
        Me.ShapeContainer1.TabIndex = 67
        Me.ShapeContainer1.TabStop = False
        '
        'Line1
        '
        Me.Line1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 480
        Me.Line1.X2 = 480
        Me.Line1.Y1 = 0
        Me.Line1.Y2 = 220
        '
        'frmCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 351)
        Me.Controls.Add(Me.txtLastChanged)
        Me.Controls.Add(Me.txtData17)
        Me.Controls.Add(Me.chkData)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.txtData12)
        Me.Controls.Add(Me.txmData1)
        Me.Controls.Add(Me.txmData0)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.cmdEditDept)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdFind)
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
        Me.Controls.Add(Me.optData0)
        Me.Controls.Add(Me.optData1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(134, 111)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCust"
        Me.ShowInTaskbar = False
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CustomerMaster1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdEditDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastChanged, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optData1 As RadioButton
    Friend WithEvents optData0 As RadioButton
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
    Friend WithEvents cmdEditDept As C1.Win.C1Input.C1Button
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFind As C1.Win.C1Input.C1Button
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkData As C1.Win.C1Input.C1CheckBox
    Friend WithEvents txtOption As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData12 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData17 As C1.Win.C1Input.C1TextBox
    Private WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents txtLastChanged As C1.Win.C1Input.C1TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Line1 As PowerPacks.LineShape
End Class
