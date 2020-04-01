<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestingMain
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
        Dim ReadyToTestLabel As System.Windows.Forms.Label
        Dim SubMenu2Label As System.Windows.Forms.Label
        Dim SubMenu1Label As System.Windows.Forms.Label
        Dim MenuLabel As System.Windows.Forms.Label
        Dim ScreenNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingMain))
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tdrpTesters = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesters = New IB.net.dsTesters()
        Me.tdrpStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TestingStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingStatus = New IB.net.dsTestingStatus()
        Me.TestingHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingHeader = New IB.net.dsTestingHeader()
        Me.TestingHeaderTableAdapter = New IB.net.dsTestingHeaderTableAdapters.TestingHeaderTableAdapter()
        Me.TestersTableAdapter = New IB.net.dsTestersTableAdapters.TestersTableAdapter()
        Me.TestingStatusTableAdapter = New IB.net.dsTestingStatusTableAdapters.TestingStatusTableAdapter()
        Me.grdTestingHeader = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDisplayOrder = New C1.Win.C1Input.C1TextBox()
        Me.cmdShowTasks = New C1.Win.C1Input.C1Button()
        Me.lstStatus = New C1.Win.C1List.C1List()
        Me.lstTesters = New C1.Win.C1List.C1List()
        Me.chkReadyToTest = New C1.Win.C1Input.C1CheckBox()
        Me.txtScreenName = New C1.Win.C1Input.C1TextBox()
        Me.txtSubMenu2 = New C1.Win.C1Input.C1TextBox()
        Me.txtSubMenu1 = New C1.Win.C1Input.C1TextBox()
        Me.txtMenu = New C1.Win.C1Input.C1TextBox()
        ReadyToTestLabel = New System.Windows.Forms.Label()
        SubMenu2Label = New System.Windows.Forms.Label()
        SubMenu1Label = New System.Windows.Forms.Label()
        MenuLabel = New System.Windows.Forms.Label()
        ScreenNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.tdrpTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdrpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTestingHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDisplayOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdShowTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReadyToTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReadyToTestLabel
        '
        ReadyToTestLabel.AutoSize = True
        ReadyToTestLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReadyToTestLabel.Location = New System.Drawing.Point(15, 122)
        ReadyToTestLabel.Name = "ReadyToTestLabel"
        ReadyToTestLabel.Size = New System.Drawing.Size(116, 20)
        ReadyToTestLabel.TabIndex = 37
        ReadyToTestLabel.Text = "Ready To Test:"
        '
        'SubMenu2Label
        '
        SubMenu2Label.AutoSize = True
        SubMenu2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubMenu2Label.Location = New System.Drawing.Point(32, 97)
        SubMenu2Label.Name = "SubMenu2Label"
        SubMenu2Label.Size = New System.Drawing.Size(99, 20)
        SubMenu2Label.TabIndex = 36
        SubMenu2Label.Text = "Sub Menu 2:"
        '
        'SubMenu1Label
        '
        SubMenu1Label.AutoSize = True
        SubMenu1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubMenu1Label.Location = New System.Drawing.Point(36, 72)
        SubMenu1Label.Name = "SubMenu1Label"
        SubMenu1Label.Size = New System.Drawing.Size(95, 20)
        SubMenu1Label.TabIndex = 35
        SubMenu1Label.Text = "Sub Menu1:"
        '
        'MenuLabel
        '
        MenuLabel.AutoSize = True
        MenuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuLabel.Location = New System.Drawing.Point(78, 47)
        MenuLabel.Name = "MenuLabel"
        MenuLabel.Size = New System.Drawing.Size(53, 20)
        MenuLabel.TabIndex = 34
        MenuLabel.Text = "Menu:"
        '
        'ScreenNameLabel
        '
        ScreenNameLabel.AutoSize = True
        ScreenNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScreenNameLabel.Location = New System.Drawing.Point(21, 22)
        ScreenNameLabel.Name = "ScreenNameLabel"
        ScreenNameLabel.Size = New System.Drawing.Size(110, 20)
        ScreenNameLabel.TabIndex = 33
        ScreenNameLabel.Text = "Screen Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(251, 123)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 20)
        Label1.TabIndex = 39
        Label1.Text = "Order:"
        '
        'tdrpTesters
        '
        Me.tdrpTesters.AllowColMove = True
        Me.tdrpTesters.AllowColSelect = True
        Me.tdrpTesters.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdrpTesters.AlternatingRows = False
        Me.tdrpTesters.CaptionHeight = 17
        Me.tdrpTesters.CaptionStyle = Style1
        Me.tdrpTesters.ColumnCaptionHeight = 17
        Me.tdrpTesters.ColumnFooterHeight = 17
        Me.tdrpTesters.ColumnHeaders = False
        Me.tdrpTesters.ColumnSelectorStyle = Style2
        Me.tdrpTesters.DataSource = Me.TestersBindingSource
        Me.tdrpTesters.DisplayMember = "Tester"
        Me.tdrpTesters.EvenRowStyle = Style3
        Me.tdrpTesters.FetchRowStyles = False
        Me.tdrpTesters.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdrpTesters.FooterStyle = Style4
        Me.tdrpTesters.HeadingStyle = Style5
        Me.tdrpTesters.HighLightRowStyle = Style6
        Me.tdrpTesters.Images.Add(CType(resources.GetObject("tdrpTesters.Images"), System.Drawing.Image))
        Me.tdrpTesters.Location = New System.Drawing.Point(382, 122)
        Me.tdrpTesters.Name = "tdrpTesters"
        Me.tdrpTesters.OddRowStyle = Style7
        Me.tdrpTesters.RecordSelectorStyle = Style8
        Me.tdrpTesters.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdrpTesters.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdrpTesters.RowHeight = 15
        Me.tdrpTesters.RowSelectorStyle = Style9
        Me.tdrpTesters.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdrpTesters.ScrollTips = False
        Me.tdrpTesters.Size = New System.Drawing.Size(100, 67)
        Me.tdrpTesters.Style = Style10
        Me.tdrpTesters.TabIndex = 5
        Me.tdrpTesters.TabStop = False
        Me.tdrpTesters.UseCompatibleTextRendering = False
        Me.tdrpTesters.ValueMember = "Tester"
        Me.tdrpTesters.Visible = False
        Me.tdrpTesters.PropBag = resources.GetString("tdrpTesters.PropBag")
        '
        'TestersBindingSource
        '
        Me.TestersBindingSource.DataMember = "Testers"
        Me.TestersBindingSource.DataSource = Me.DsTesters
        '
        'DsTesters
        '
        Me.DsTesters.DataSetName = "dsTesters"
        Me.DsTesters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tdrpStatus
        '
        Me.tdrpStatus.AllowColMove = True
        Me.tdrpStatus.AllowColSelect = True
        Me.tdrpStatus.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdrpStatus.AlternatingRows = False
        Me.tdrpStatus.CaptionHeight = 17
        Me.tdrpStatus.CaptionStyle = Style11
        Me.tdrpStatus.ColumnCaptionHeight = 17
        Me.tdrpStatus.ColumnFooterHeight = 17
        Me.tdrpStatus.ColumnHeaders = False
        Me.tdrpStatus.ColumnSelectorStyle = Style12
        Me.tdrpStatus.DataSource = Me.TestingStatusBindingSource
        Me.tdrpStatus.DisplayMember = "Status"
        Me.tdrpStatus.EvenRowStyle = Style13
        Me.tdrpStatus.FetchRowStyles = False
        Me.tdrpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdrpStatus.FooterStyle = Style14
        Me.tdrpStatus.HeadingStyle = Style15
        Me.tdrpStatus.HighLightRowStyle = Style16
        Me.tdrpStatus.Images.Add(CType(resources.GetObject("tdrpStatus.Images"), System.Drawing.Image))
        Me.tdrpStatus.Location = New System.Drawing.Point(501, 120)
        Me.tdrpStatus.Name = "tdrpStatus"
        Me.tdrpStatus.OddRowStyle = Style17
        Me.tdrpStatus.RecordSelectorStyle = Style18
        Me.tdrpStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdrpStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdrpStatus.RowHeight = 15
        Me.tdrpStatus.RowSelectorStyle = Style19
        Me.tdrpStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdrpStatus.ScrollTips = False
        Me.tdrpStatus.Size = New System.Drawing.Size(100, 69)
        Me.tdrpStatus.Style = Style20
        Me.tdrpStatus.TabIndex = 6
        Me.tdrpStatus.TabStop = False
        Me.tdrpStatus.UseCompatibleTextRendering = False
        Me.tdrpStatus.ValueMember = "Status"
        Me.tdrpStatus.Visible = False
        Me.tdrpStatus.PropBag = resources.GetString("tdrpStatus.PropBag")
        '
        'TestingStatusBindingSource
        '
        Me.TestingStatusBindingSource.DataMember = "TestingStatus"
        Me.TestingStatusBindingSource.DataSource = Me.DsTestingStatus
        '
        'DsTestingStatus
        '
        Me.DsTestingStatus.DataSetName = "dsTestingStatus"
        Me.DsTestingStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestingHeaderBindingSource
        '
        Me.TestingHeaderBindingSource.DataMember = "TestingHeader"
        Me.TestingHeaderBindingSource.DataSource = Me.DsTestingHeader
        '
        'DsTestingHeader
        '
        Me.DsTestingHeader.DataSetName = "dsTestingHeader"
        Me.DsTestingHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestingHeaderTableAdapter
        '
        Me.TestingHeaderTableAdapter.ClearBeforeFill = True
        '
        'TestersTableAdapter
        '
        Me.TestersTableAdapter.ClearBeforeFill = True
        '
        'TestingStatusTableAdapter
        '
        Me.TestingStatusTableAdapter.ClearBeforeFill = True
        '
        'grdTestingHeader
        '
        Me.grdTestingHeader.AllowAddNew = True
        Me.grdTestingHeader.AllowDelete = True
        Me.grdTestingHeader.AlternatingRows = True
        Me.grdTestingHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTestingHeader.CaptionHeight = 17
        Me.grdTestingHeader.DataSource = Me.TestingHeaderBindingSource
        Me.grdTestingHeader.FilterBar = True
        Me.grdTestingHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTestingHeader.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTestingHeader.Images.Add(CType(resources.GetObject("grdTestingHeader.Images"), System.Drawing.Image))
        Me.grdTestingHeader.Location = New System.Drawing.Point(10, 205)
        Me.grdTestingHeader.Name = "grdTestingHeader"
        Me.grdTestingHeader.Padding = New System.Windows.Forms.Padding(5)
        Me.grdTestingHeader.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTestingHeader.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTestingHeader.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTestingHeader.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdTestingHeader.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdTestingHeader.PrintInfo.PageSettings = CType(resources.GetObject("grdTestingHeader.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTestingHeader.RowHeight = 15
        Me.grdTestingHeader.Size = New System.Drawing.Size(765, 285)
        Me.grdTestingHeader.TabIndex = 0
        Me.grdTestingHeader.UseCompatibleTextRendering = False
        Me.grdTestingHeader.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTestingHeader.PropBag = resources.GetString("grdTestingHeader.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdReset)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.cmdNew)
        Me.GroupBox1.Location = New System.Drawing.Point(660, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 195)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(15, 154)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(15, 110)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(15, 80)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 2
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(15, 50)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(15, 20)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.txtDisplayOrder)
        Me.GroupBox2.Controls.Add(Me.cmdShowTasks)
        Me.GroupBox2.Controls.Add(Me.lstStatus)
        Me.GroupBox2.Controls.Add(Me.lstTesters)
        Me.GroupBox2.Controls.Add(Me.tdrpStatus)
        Me.GroupBox2.Controls.Add(Me.chkReadyToTest)
        Me.GroupBox2.Controls.Add(Me.tdrpTesters)
        Me.GroupBox2.Controls.Add(Me.txtScreenName)
        Me.GroupBox2.Controls.Add(Me.txtSubMenu2)
        Me.GroupBox2.Controls.Add(Me.txtSubMenu1)
        Me.GroupBox2.Controls.Add(Me.txtMenu)
        Me.GroupBox2.Controls.Add(ReadyToTestLabel)
        Me.GroupBox2.Controls.Add(SubMenu2Label)
        Me.GroupBox2.Controls.Add(SubMenu1Label)
        Me.GroupBox2.Controls.Add(MenuLabel)
        Me.GroupBox2.Controls.Add(ScreenNameLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 195)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtDisplayOrder
        '
        Me.txtDisplayOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisplayOrder.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "DisplayOrder", True))
        Me.txtDisplayOrder.DataType = GetType(Integer)
        Me.txtDisplayOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayOrder.Location = New System.Drawing.Point(310, 121)
        Me.txtDisplayOrder.Name = "txtDisplayOrder"
        Me.txtDisplayOrder.Size = New System.Drawing.Size(50, 24)
        Me.txtDisplayOrder.TabIndex = 5
        Me.txtDisplayOrder.Tag = Nothing
        Me.txtDisplayOrder.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDisplayOrder.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdShowTasks
        '
        Me.cmdShowTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShowTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowTasks.Location = New System.Drawing.Point(15, 155)
        Me.cmdShowTasks.Name = "cmdShowTasks"
        Me.cmdShowTasks.Size = New System.Drawing.Size(610, 25)
        Me.cmdShowTasks.TabIndex = 8
        Me.cmdShowTasks.Text = "Show tasks for screen "
        Me.cmdShowTasks.UseVisualStyleBackColor = True
        Me.cmdShowTasks.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdShowTasks.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lstStatus
        '
        Me.lstStatus.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstStatus.Caption = "Status"
        Me.lstStatus.ColumnHeaders = False
        Me.lstStatus.ColumnWidth = 100
        Me.lstStatus.DataSource = Me.TestingStatusBindingSource
        Me.lstStatus.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStatus.Images.Add(CType(resources.GetObject("lstStatus.Images"), System.Drawing.Image))
        Me.lstStatus.ItemHeight = 18
        Me.lstStatus.Location = New System.Drawing.Point(500, 20)
        Me.lstStatus.MatchEntryTimeout = CType(2000, Long)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstStatus.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstStatus.PreviewInfo.ZoomFactor = 75.0R
        Me.lstStatus.PrintInfo.PageSettings = CType(resources.GetObject("lstStatus.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstStatus.ShowHeaderCheckBox = False
        Me.lstStatus.Size = New System.Drawing.Size(125, 125)
        Me.lstStatus.TabIndex = 7
        Me.lstStatus.Text = "C1List2"
        Me.lstStatus.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstStatus.PropBag = resources.GetString("lstStatus.PropBag")
        '
        'lstTesters
        '
        Me.lstTesters.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstTesters.Caption = "Testers"
        Me.lstTesters.ColumnHeaders = False
        Me.lstTesters.ColumnWidth = 100
        Me.lstTesters.DataSource = Me.TestersBindingSource
        Me.lstTesters.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.lstTesters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTesters.Images.Add(CType(resources.GetObject("lstTesters.Images"), System.Drawing.Image))
        Me.lstTesters.ItemHeight = 18
        Me.lstTesters.Location = New System.Drawing.Point(370, 20)
        Me.lstTesters.MatchEntryTimeout = CType(2000, Long)
        Me.lstTesters.Name = "lstTesters"
        Me.lstTesters.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstTesters.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstTesters.PreviewInfo.ZoomFactor = 75.0R
        Me.lstTesters.PrintInfo.PageSettings = CType(resources.GetObject("lstTesters.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstTesters.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstTesters.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstTesters.ShowHeaderCheckBox = False
        Me.lstTesters.Size = New System.Drawing.Size(125, 125)
        Me.lstTesters.TabIndex = 6
        Me.lstTesters.Text = "C1List1"
        Me.lstTesters.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstTesters.PropBag = resources.GetString("lstTesters.PropBag")
        '
        'chkReadyToTest
        '
        Me.chkReadyToTest.BackColor = System.Drawing.Color.Transparent
        Me.chkReadyToTest.BorderColor = System.Drawing.Color.Transparent
        Me.chkReadyToTest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkReadyToTest.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "ReadyToTest", True))
        Me.chkReadyToTest.ForeColor = System.Drawing.Color.Black
        Me.chkReadyToTest.Location = New System.Drawing.Point(137, 121)
        Me.chkReadyToTest.Name = "chkReadyToTest"
        Me.chkReadyToTest.Padding = New System.Windows.Forms.Padding(1)
        Me.chkReadyToTest.Size = New System.Drawing.Size(23, 24)
        Me.chkReadyToTest.TabIndex = 4
        Me.chkReadyToTest.UseVisualStyleBackColor = True
        Me.chkReadyToTest.Value = Nothing
        Me.chkReadyToTest.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkReadyToTest.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtScreenName
        '
        Me.txtScreenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScreenName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "ScreenName", True))
        Me.txtScreenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreenName.Location = New System.Drawing.Point(135, 20)
        Me.txtScreenName.Name = "txtScreenName"
        Me.txtScreenName.Size = New System.Drawing.Size(225, 24)
        Me.txtScreenName.TabIndex = 0
        Me.txtScreenName.Tag = Nothing
        Me.txtScreenName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtScreenName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtSubMenu2
        '
        Me.txtSubMenu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubMenu2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "SubMenu2", True))
        Me.txtSubMenu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubMenu2.Location = New System.Drawing.Point(135, 95)
        Me.txtSubMenu2.Name = "txtSubMenu2"
        Me.txtSubMenu2.Size = New System.Drawing.Size(225, 24)
        Me.txtSubMenu2.TabIndex = 3
        Me.txtSubMenu2.Tag = Nothing
        Me.txtSubMenu2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSubMenu2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtSubMenu1
        '
        Me.txtSubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubMenu1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "SubMenu1", True))
        Me.txtSubMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubMenu1.Location = New System.Drawing.Point(135, 70)
        Me.txtSubMenu1.Name = "txtSubMenu1"
        Me.txtSubMenu1.Size = New System.Drawing.Size(225, 24)
        Me.txtSubMenu1.TabIndex = 2
        Me.txtSubMenu1.Tag = Nothing
        Me.txtSubMenu1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSubMenu1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtMenu
        '
        Me.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMenu.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "Menu", True))
        Me.txtMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.Location = New System.Drawing.Point(135, 45)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(225, 24)
        Me.txtMenu.TabIndex = 1
        Me.txtMenu.Tag = Nothing
        Me.txtMenu.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMenu.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmTestingMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 501)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdTestingHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTestingMain"
        Me.Text = "IB.net Testing"
        CType(Me.tdrpTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdrpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTestingHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDisplayOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdShowTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReadyToTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tdrpTesters As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents tdrpStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents DsTestingHeader As dsTestingHeader
    Friend WithEvents TestingHeaderBindingSource As BindingSource
    Friend WithEvents TestingHeaderTableAdapter As dsTestingHeaderTableAdapters.TestingHeaderTableAdapter
    Friend WithEvents DsTesters As dsTesters
    Friend WithEvents TestersBindingSource As BindingSource
    Friend WithEvents TestersTableAdapter As dsTestersTableAdapters.TestersTableAdapter
    Friend WithEvents DsTestingStatus As dsTestingStatus
    Friend WithEvents TestingStatusBindingSource As BindingSource
    Friend WithEvents TestingStatusTableAdapter As dsTestingStatusTableAdapters.TestingStatusTableAdapter
    Friend WithEvents grdTestingHeader As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdShowTasks As C1.Win.C1Input.C1Button
    Friend WithEvents lstStatus As C1.Win.C1List.C1List
    Friend WithEvents lstTesters As C1.Win.C1List.C1List
    Friend WithEvents chkReadyToTest As C1.Win.C1Input.C1CheckBox
    Friend WithEvents txtScreenName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSubMenu2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSubMenu1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtMenu As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDisplayOrder As C1.Win.C1Input.C1TextBox
End Class
