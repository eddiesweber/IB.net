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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDept))
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
        Me.cmdFindCust = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdItem = New C1.Win.C1Input.C1Button()
        Me.cmdSurcharge = New C1.Win.C1Input.C1Button()
        Me.txtData8 = New C1.Win.C1Input.C1TextBox()
        Me.CustomerDepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomerDepartment = New IB.net.dsCustomerDepartment()
        Me.txtData0 = New C1.Win.C1Input.C1TextBox()
        Me.txtData2 = New C1.Win.C1Input.C1TextBox()
        Me.txtData3 = New C1.Win.C1Input.C1TextBox()
        Me.txtData6 = New C1.Win.C1Input.C1TextBox()
        Me.txtData5 = New C1.Win.C1Input.C1TextBox()
        Me.txtData4 = New C1.Win.C1Input.C1TextBox()
        Me.txtData7 = New C1.Win.C1Input.C1TextBox()
        Me.txmData0 = New C1.Win.C1Input.C1TextBox()
        Me.txmData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData9 = New C1.Win.C1Input.C1TextBox()
        Me.txtData11 = New C1.Win.C1Input.C1TextBox()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.txtData1 = New C1.Win.C1Input.C1TextBox()
        Me.txtData10 = New C1.Win.C1Input.C1TextBox()
        Me.txtTaxState = New C1.Win.C1Input.C1TextBox()
        Me.CustomerDepartmentTableAdapter = New IB.net.dsCustomerDepartmentTableAdapters.CustomerDepartmentTableAdapter()
        Me.grdRoute = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.CustomerRouteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomerRoute = New IB.net.dsCustomerRoute()
        Me.CustomerRouteTableAdapter = New IB.net.dsCustomerRouteTableAdapters.CustomerRouteTableAdapter()
        Me.lstDept = New C1.Win.C1List.C1List()
        Me.DsspGetTaxCodes = New IB.net.dsspGetTaxCodes()
        Me.SpGetTaxCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetTaxCodesTableAdapter = New IB.net.dsspGetTaxCodesTableAdapters.spGetTaxCodesTableAdapter()
        Me.TableAdapterManager = New IB.net.dsspGetTaxCodesTableAdapters.TableAdapterManager()
        Me.cmbTax = New C1.Win.C1List.C1Combo()
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSurcharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRouteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetTaxCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetTaxCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.Location = New System.Drawing.Point(7, 189)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.Size = New System.Drawing.Size(27, 13)
        Me.lblLabel12.TabIndex = 19
        Me.lblLabel12.Text = "&Fax:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(174, 187)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(35, 13)
        Me.lblLabel5.TabIndex = 21
        Me.lblLabel5.Text = "&Email:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(257, 16)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 39
        Me.lblCurCust.Visible = False
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.ForeColor = System.Drawing.Color.Black
        Me.lblLabel11.Location = New System.Drawing.Point(7, 264)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.Size = New System.Drawing.Size(53, 13)
        Me.lblLabel11.TabIndex = 30
        Me.lblLabel11.Text = "&Message:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.Location = New System.Drawing.Point(186, 162)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.Size = New System.Drawing.Size(68, 13)
        Me.lblLabel10.TabIndex = 17
        Me.lblLabel10.Text = "&Salesperson:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.Location = New System.Drawing.Point(7, 238)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.Size = New System.Drawing.Size(99, 13)
        Me.lblLabel9.TabIndex = 27
        Me.lblLabel9.Text = "Cont&ract Start/End:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(281, 16)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel8.TabIndex = 3
        Me.lblLabel8.Text = "&Dept:"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(7, 214)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel7.TabIndex = 23
        Me.lblLabel7.Text = "&Tax Code:"
        '
        'lblLabel6
        '
        Me.lblLabel6.AutoSize = True
        Me.lblLabel6.Location = New System.Drawing.Point(7, 137)
        Me.lblLabel6.Name = "lblLabel6"
        Me.lblLabel6.Size = New System.Drawing.Size(47, 13)
        Me.lblLabel6.TabIndex = 13
        Me.lblLabel6.Text = "Con&tact:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 112)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel3.TabIndex = 9
        Me.lblLabel3.Text = "C&ity, ST Zip:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 87)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel2.TabIndex = 7
        Me.lblLabel2.Text = "&Address:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(8, 162)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel4.TabIndex = 15
        Me.lblLabel4.Text = "&Phone:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 62)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel1.TabIndex = 5
        Me.lblLabel1.Text = "&Name:"
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
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(175, 10)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(85, 25)
        Me.cmdFindCust.TabIndex = 44
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        Me.cmdFindCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFindCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(390, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 45
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(390, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 46
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(390, 70)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 47
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(390, 100)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 48
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(390, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 49
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdItem
        '
        Me.cmdItem.Location = New System.Drawing.Point(92, 354)
        Me.cmdItem.Name = "cmdItem"
        Me.cmdItem.Size = New System.Drawing.Size(145, 25)
        Me.cmdItem.TabIndex = 50
        Me.cmdItem.Text = "&Items"
        Me.cmdItem.UseVisualStyleBackColor = True
        Me.cmdItem.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdItem.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdSurcharge
        '
        Me.cmdSurcharge.Location = New System.Drawing.Point(247, 354)
        Me.cmdSurcharge.Name = "cmdSurcharge"
        Me.cmdSurcharge.Size = New System.Drawing.Size(145, 25)
        Me.cmdSurcharge.TabIndex = 51
        Me.cmdSurcharge.Text = "S&urcharge/Discount"
        Me.cmdSurcharge.UseVisualStyleBackColor = True
        Me.cmdSurcharge.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSurcharge.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData8
        '
        Me.txtData8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "MESSAGE", True))
        Me.txtData8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData8.Location = New System.Drawing.Point(75, 260)
        Me.txtData8.Name = "txtData8"
        Me.txtData8.Size = New System.Drawing.Size(300, 18)
        Me.txtData8.TabIndex = 52
        Me.txtData8.Tag = Nothing
        Me.txtData8.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CustomerDepartmentBindingSource
        '
        Me.CustomerDepartmentBindingSource.DataMember = "CustomerDepartment"
        Me.CustomerDepartmentBindingSource.DataSource = Me.DsCustomerDepartment
        '
        'DsCustomerDepartment
        '
        Me.DsCustomerDepartment.DataSetName = "dsCustomerDepartment"
        Me.DsCustomerDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtData0
        '
        Me.txtData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "CUST_NUM", True))
        Me.txtData0.DataType = GetType(Integer)
        Me.txtData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData0.Location = New System.Drawing.Point(75, 15)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(75, 18)
        Me.txtData0.TabIndex = 53
        Me.txtData0.Tag = Nothing
        Me.txtData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData2
        '
        Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_NAME", True))
        Me.txtData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData2.Location = New System.Drawing.Point(75, 60)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(230, 18)
        Me.txtData2.TabIndex = 54
        Me.txtData2.Tag = Nothing
        Me.txtData2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData3
        '
        Me.txtData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_ADDR", True))
        Me.txtData3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData3.Location = New System.Drawing.Point(75, 85)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(230, 18)
        Me.txtData3.TabIndex = 55
        Me.txtData3.Tag = Nothing
        Me.txtData3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData6
        '
        Me.txtData6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_ZIP", True))
        Me.txtData6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData6.Location = New System.Drawing.Point(225, 110)
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(80, 18)
        Me.txtData6.TabIndex = 56
        Me.txtData6.Tag = Nothing
        Me.txtData6.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData5
        '
        Me.txtData5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_STATE", True))
        Me.txtData5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData5.Location = New System.Drawing.Point(190, 110)
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(30, 18)
        Me.txtData5.TabIndex = 57
        Me.txtData5.Tag = Nothing
        Me.txtData5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData4
        '
        Me.txtData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_CITY", True))
        Me.txtData4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData4.Location = New System.Drawing.Point(75, 110)
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(110, 18)
        Me.txtData4.TabIndex = 58
        Me.txtData4.Tag = Nothing
        Me.txtData4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData7
        '
        Me.txtData7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData7.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "CONTACT", True))
        Me.txtData7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData7.Location = New System.Drawing.Point(75, 135)
        Me.txtData7.Name = "txtData7"
        Me.txtData7.Size = New System.Drawing.Size(160, 18)
        Me.txtData7.TabIndex = 59
        Me.txtData7.Tag = Nothing
        Me.txtData7.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData0
        '
        Me.txmData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData0.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEL_PHONE", True))
        Me.txmData0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData0.Location = New System.Drawing.Point(75, 160)
        Me.txmData0.Name = "txmData0"
        Me.txmData0.Size = New System.Drawing.Size(90, 18)
        Me.txmData0.TabIndex = 60
        Me.txmData0.Tag = Nothing
        Me.txmData0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txmData1
        '
        Me.txmData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txmData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "Del_Fax", True))
        Me.txmData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txmData1.Location = New System.Drawing.Point(75, 185)
        Me.txmData1.Name = "txmData1"
        Me.txmData1.Size = New System.Drawing.Size(90, 18)
        Me.txmData1.TabIndex = 61
        Me.txmData1.Tag = Nothing
        Me.txmData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txmData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData9
        '
        Me.txtData9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData9.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "Del_Email", True))
        Me.txtData9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData9.Location = New System.Drawing.Point(210, 185)
        Me.txtData9.Name = "txtData9"
        Me.txtData9.Size = New System.Drawing.Size(165, 18)
        Me.txtData9.TabIndex = 62
        Me.txtData9.Tag = Nothing
        Me.txtData9.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData11
        '
        Me.txtData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData11.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "SALESMAN", True))
        Me.txtData11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData11.Location = New System.Drawing.Point(260, 160)
        Me.txtData11.Name = "txtData11"
        Me.txtData11.Size = New System.Drawing.Size(115, 18)
        Me.txtData11.TabIndex = 63
        Me.txtData11.Tag = Nothing
        Me.txtData11.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustName.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(75, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Padding = New System.Windows.Forms.Padding(1)
        Me.txtCustName.Size = New System.Drawing.Size(230, 15)
        Me.txtCustName.TabIndex = 64
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData1
        '
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "DEPT", True))
        Me.txtData1.DataType = GetType(Short)
        Me.txtData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData1.Location = New System.Drawing.Point(400, 191)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(67, 18)
        Me.txtData1.TabIndex = 65
        Me.txtData1.Tag = Nothing
        Me.txtData1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtData10
        '
        Me.txtData10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtData10.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerDepartmentBindingSource, "TAX_LOCODE", True))
        Me.txtData10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData10.Location = New System.Drawing.Point(400, 211)
        Me.txtData10.Name = "txtData10"
        Me.txtData10.Size = New System.Drawing.Size(67, 18)
        Me.txtData10.TabIndex = 68
        Me.txtData10.Tag = Nothing
        Me.txtData10.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtData10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTaxState
        '
        Me.txtTaxState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTaxState.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SpGetTaxCodesBindingSource, "LOCAL_CODE", True))
        Me.txtTaxState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxState.Location = New System.Drawing.Point(400, 171)
        Me.txtTaxState.Name = "txtTaxState"
        Me.txtTaxState.Size = New System.Drawing.Size(67, 18)
        Me.txtTaxState.TabIndex = 69
        Me.txtTaxState.Tag = Nothing
        Me.txtTaxState.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTaxState.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CustomerDepartmentTableAdapter
        '
        Me.CustomerDepartmentTableAdapter.ClearBeforeFill = True
        '
        'grdRoute
        '
        Me.grdRoute.DataSource = Me.CustomerRouteBindingSource
        Me.grdRoute.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdRoute.Location = New System.Drawing.Point(10, 284)
        Me.grdRoute.Name = "grdRoute"
        Me.grdRoute.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdRoute.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdRoute.PreviewInfo.ZoomFactor = 75.0R
        Me.grdRoute.PrintInfo.PageSettings = CType(resources.GetObject("grdRoute.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdRoute.PropBag = resources.GetString("grdRoute.PropBag")
        Me.grdRoute.Size = New System.Drawing.Size(465, 64)
        Me.grdRoute.TabIndex = 70
        Me.grdRoute.UseCompatibleTextRendering = False
        Me.grdRoute.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'CustomerRouteBindingSource
        '
        Me.CustomerRouteBindingSource.DataMember = "CustomerRoute"
        Me.CustomerRouteBindingSource.DataSource = Me.DsCustomerRoute
        '
        'DsCustomerRoute
        '
        Me.DsCustomerRoute.DataSetName = "dsCustomerRoute"
        Me.DsCustomerRoute.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerRouteTableAdapter
        '
        Me.CustomerRouteTableAdapter.ClearBeforeFill = True
        '
        'lstDept
        '
        Me.lstDept.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstDept.Caption = ""
        Me.lstDept.ColumnHeaders = False
        Me.lstDept.ColumnWidth = 55
        Me.lstDept.DataSource = Me.CustomerDepartmentBindingSource
        Me.lstDept.DeadAreaBackColor = System.Drawing.SystemColors.Window
        Me.lstDept.Images.Add(CType(resources.GetObject("lstDept.Images"), System.Drawing.Image))
        Me.lstDept.ItemHeight = 15
        Me.lstDept.Location = New System.Drawing.Point(315, 10)
        Me.lstDept.MatchEntryTimeout = CType(2000, Long)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstDept.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstDept.PreviewInfo.ZoomFactor = 75.0R
        Me.lstDept.PrintInfo.PageSettings = CType(resources.GetObject("C1List1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstDept.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstDept.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstDept.ScrollTrack = False
        Me.lstDept.ShowHeaderCheckBox = False
        Me.lstDept.Size = New System.Drawing.Size(60, 60)
        Me.lstDept.TabIndex = 71
        Me.lstDept.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstDept.PropBag = resources.GetString("lstDept.PropBag")
        '
        'DsspGetTaxCodes
        '
        Me.DsspGetTaxCodes.DataSetName = "dsspGetTaxCodes"
        Me.DsspGetTaxCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetTaxCodesBindingSource
        '
        Me.SpGetTaxCodesBindingSource.DataMember = "spGetTaxCodes"
        Me.SpGetTaxCodesBindingSource.DataSource = Me.DsspGetTaxCodes
        '
        'SpGetTaxCodesTableAdapter
        '
        Me.SpGetTaxCodesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = IB.net.dsspGetTaxCodesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbTax
        '
        Me.cmbTax.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTax.AllowColSelect = True
        Me.cmbTax.Caption = ""
        Me.cmbTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTax.ColumnHeaders = False
        Me.cmbTax.ColumnWidth = 100
        Me.cmbTax.DataSource = Me.SpGetTaxCodesBindingSource
        Me.cmbTax.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTax.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTax.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTax.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTax.Images.Add(CType(resources.GetObject("cmbTax.Images"), System.Drawing.Image))
        Me.cmbTax.Location = New System.Drawing.Point(75, 209)
        Me.cmbTax.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTax.MaxDropDownItems = CType(5, Short)
        Me.cmbTax.MaxLength = 32767
        Me.cmbTax.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTax.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTax.Size = New System.Drawing.Size(90, 21)
        Me.cmbTax.TabIndex = 72
        Me.cmbTax.Text = "C1Combo1"
        Me.cmbTax.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbTax.PropBag = resources.GetString("cmbTax.PropBag")
        '
        'frmDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 399)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.grdRoute)
        Me.Controls.Add(Me.txtTaxState)
        Me.Controls.Add(Me.txtData10)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtData11)
        Me.Controls.Add(Me.txtData9)
        Me.Controls.Add(Me.txmData1)
        Me.Controls.Add(Me.txmData0)
        Me.Controls.Add(Me.txtData7)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData8)
        Me.Controls.Add(Me.cmdSurcharge)
        Me.Controls.Add(Me.cmdItem)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdFindCust)
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
        Me.Location = New System.Drawing.Point(87, 78)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDept"
        Me.ShowInTaskbar = False
        Me.Text = "Add/Edit Departments"
        CType(Me.cmdFindCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSurcharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txmData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRouteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetTaxCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetTaxCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents cmdFindCust As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdItem As C1.Win.C1Input.C1Button
    Friend WithEvents cmdSurcharge As C1.Win.C1Input.C1Button
    Friend WithEvents txtData8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txmData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData9 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData11 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtData10 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTaxState As C1.Win.C1Input.C1TextBox
    Friend WithEvents CustomerDepartmentBindingSource As BindingSource
    Friend WithEvents DsCustomerDepartment As dsCustomerDepartment
    Friend WithEvents CustomerDepartmentTableAdapter As dsCustomerDepartmentTableAdapters.CustomerDepartmentTableAdapter
    Friend WithEvents grdRoute As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents CustomerRouteBindingSource As BindingSource
    Friend WithEvents DsCustomerRoute As dsCustomerRoute
    Friend WithEvents CustomerRouteTableAdapter As dsCustomerRouteTableAdapters.CustomerRouteTableAdapter
    Friend WithEvents lstDept As C1.Win.C1List.C1List
    Friend WithEvents SpGetTaxCodesBindingSource As BindingSource
    Friend WithEvents DsspGetTaxCodes As dsspGetTaxCodes
    Friend WithEvents SpGetTaxCodesTableAdapter As dsspGetTaxCodesTableAdapters.spGetTaxCodesTableAdapter
    Friend WithEvents TableAdapterManager As dsspGetTaxCodesTableAdapters.TableAdapterManager
    Friend WithEvents cmbTax As C1.Win.C1List.C1Combo
End Class
