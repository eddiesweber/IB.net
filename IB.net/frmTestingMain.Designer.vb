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
        Dim ScreenNameLabel As System.Windows.Forms.Label
        Dim MenuLabel As System.Windows.Forms.Label
        Dim SubMenu1Label As System.Windows.Forms.Label
        Dim SubMenu2Label As System.Windows.Forms.Label
        Dim ReadyToTestLabel As System.Windows.Forms.Label
        Dim Style41 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style42 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style43 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style44 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style45 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style46 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingMain))
        Dim Style47 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style48 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style49 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style50 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style51 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style52 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style53 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style54 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style55 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style56 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style57 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style58 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style59 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style60 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tdrpTesters = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTesters = New IB.net.dsTesters()
        Me.tdrpStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TestingStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingStatus = New IB.net.dsTestingStatus()
        Me.txtMenu = New C1.Win.C1Input.C1TextBox()
        Me.TestingHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingHeader = New IB.net.dsTestingHeader()
        Me.txtSubMenu1 = New C1.Win.C1Input.C1TextBox()
        Me.txtSubMenu2 = New C1.Win.C1Input.C1TextBox()
        Me.txtScreenName = New C1.Win.C1Input.C1TextBox()
        Me.lstTesters = New C1.Win.C1List.C1List()
        Me.lstStatus = New C1.Win.C1List.C1List()
        Me.chkReadyToTest = New C1.Win.C1Input.C1CheckBox()
        Me.cmdShowTasks = New C1.Win.C1Input.C1Button()
        Me.TestingHeaderTableAdapter = New IB.net.dsTestingHeaderTableAdapters.TestingHeaderTableAdapter()
        Me.TableAdapterManager = New IB.net.dsTestingHeaderTableAdapters.TableAdapterManager()
        Me.TestingHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TestingHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TestersTableAdapter = New IB.net.dsTestersTableAdapters.TestersTableAdapter()
        Me.TestingStatusTableAdapter = New IB.net.dsTestingStatusTableAdapters.TestingStatusTableAdapter()
        Me.grdTestingHeader = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        ScreenNameLabel = New System.Windows.Forms.Label()
        MenuLabel = New System.Windows.Forms.Label()
        SubMenu1Label = New System.Windows.Forms.Label()
        SubMenu2Label = New System.Windows.Forms.Label()
        ReadyToTestLabel = New System.Windows.Forms.Label()
        CType(Me.tdrpTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdrpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReadyToTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdShowTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestingHeaderBindingNavigator.SuspendLayout()
        CType(Me.grdTestingHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScreenNameLabel
        '
        ScreenNameLabel.AutoSize = True
        ScreenNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScreenNameLabel.Location = New System.Drawing.Point(10, 39)
        ScreenNameLabel.Name = "ScreenNameLabel"
        ScreenNameLabel.Size = New System.Drawing.Size(110, 20)
        ScreenNameLabel.TabIndex = 9
        ScreenNameLabel.Text = "Screen Name:"
        '
        'MenuLabel
        '
        MenuLabel.AutoSize = True
        MenuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuLabel.Location = New System.Drawing.Point(278, 37)
        MenuLabel.Name = "MenuLabel"
        MenuLabel.Size = New System.Drawing.Size(53, 20)
        MenuLabel.TabIndex = 15
        MenuLabel.Text = "Menu:"
        '
        'SubMenu1Label
        '
        SubMenu1Label.AutoSize = True
        SubMenu1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubMenu1Label.Location = New System.Drawing.Point(241, 62)
        SubMenu1Label.Name = "SubMenu1Label"
        SubMenu1Label.Size = New System.Drawing.Size(91, 20)
        SubMenu1Label.TabIndex = 16
        SubMenu1Label.Text = "Submenu1:"
        '
        'SubMenu2Label
        '
        SubMenu2Label.AutoSize = True
        SubMenu2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubMenu2Label.Location = New System.Drawing.Point(241, 87)
        SubMenu2Label.Name = "SubMenu2Label"
        SubMenu2Label.Size = New System.Drawing.Size(91, 20)
        SubMenu2Label.TabIndex = 17
        SubMenu2Label.Text = "Submenu2:"
        '
        'ReadyToTestLabel
        '
        ReadyToTestLabel.AutoSize = True
        ReadyToTestLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReadyToTestLabel.Location = New System.Drawing.Point(10, 87)
        ReadyToTestLabel.Name = "ReadyToTestLabel"
        ReadyToTestLabel.Size = New System.Drawing.Size(116, 20)
        ReadyToTestLabel.TabIndex = 19
        ReadyToTestLabel.Text = "Ready To Test:"
        '
        'tdrpTesters
        '
        Me.tdrpTesters.AllowColMove = True
        Me.tdrpTesters.AllowColSelect = True
        Me.tdrpTesters.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdrpTesters.AlternatingRows = False
        Me.tdrpTesters.CaptionStyle = Style41
        Me.tdrpTesters.ColumnCaptionHeight = 17
        Me.tdrpTesters.ColumnFooterHeight = 17
        Me.tdrpTesters.ColumnHeaders = False
        Me.tdrpTesters.ColumnSelectorStyle = Style42
        Me.tdrpTesters.DataSource = Me.TestersBindingSource
        Me.tdrpTesters.DisplayMember = "Tester"
        Me.tdrpTesters.EvenRowStyle = Style43
        Me.tdrpTesters.FetchRowStyles = False
        Me.tdrpTesters.FooterStyle = Style44
        Me.tdrpTesters.HeadingStyle = Style45
        Me.tdrpTesters.HighLightRowStyle = Style46
        Me.tdrpTesters.Images.Add(CType(resources.GetObject("tdrpTesters.Images"), System.Drawing.Image))
        Me.tdrpTesters.Location = New System.Drawing.Point(465, 62)
        Me.tdrpTesters.Name = "tdrpTesters"
        Me.tdrpTesters.OddRowStyle = Style47
        Me.tdrpTesters.RecordSelectorStyle = Style48
        Me.tdrpTesters.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdrpTesters.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdrpTesters.RowSelectorStyle = Style49
        Me.tdrpTesters.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdrpTesters.ScrollTips = False
        Me.tdrpTesters.Size = New System.Drawing.Size(100, 89)
        Me.tdrpTesters.Style = Style50
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
        Me.tdrpStatus.CaptionStyle = Style51
        Me.tdrpStatus.ColumnCaptionHeight = 17
        Me.tdrpStatus.ColumnFooterHeight = 17
        Me.tdrpStatus.ColumnHeaders = False
        Me.tdrpStatus.ColumnSelectorStyle = Style52
        Me.tdrpStatus.DataSource = Me.TestingStatusBindingSource
        Me.tdrpStatus.DisplayMember = "Status"
        Me.tdrpStatus.EvenRowStyle = Style53
        Me.tdrpStatus.FetchRowStyles = False
        Me.tdrpStatus.FooterStyle = Style54
        Me.tdrpStatus.HeadingStyle = Style55
        Me.tdrpStatus.HighLightRowStyle = Style56
        Me.tdrpStatus.Images.Add(CType(resources.GetObject("tdrpStatus.Images"), System.Drawing.Image))
        Me.tdrpStatus.Location = New System.Drawing.Point(596, 62)
        Me.tdrpStatus.Name = "tdrpStatus"
        Me.tdrpStatus.OddRowStyle = Style57
        Me.tdrpStatus.RecordSelectorStyle = Style58
        Me.tdrpStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdrpStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdrpStatus.RowSelectorStyle = Style59
        Me.tdrpStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdrpStatus.ScrollTips = False
        Me.tdrpStatus.Size = New System.Drawing.Size(100, 89)
        Me.tdrpStatus.Style = Style60
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
        'txtMenu
        '
        Me.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMenu.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "Menu", True))
        Me.txtMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenu.Location = New System.Drawing.Point(330, 35)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(175, 24)
        Me.txtMenu.TabIndex = 1
        Me.txtMenu.Tag = Nothing
        Me.txtMenu.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMenu.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        'txtSubMenu1
        '
        Me.txtSubMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubMenu1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "SubMenu1", True))
        Me.txtSubMenu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubMenu1.Location = New System.Drawing.Point(330, 60)
        Me.txtSubMenu1.Name = "txtSubMenu1"
        Me.txtSubMenu1.Size = New System.Drawing.Size(175, 24)
        Me.txtSubMenu1.TabIndex = 2
        Me.txtSubMenu1.Tag = Nothing
        Me.txtSubMenu1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSubMenu1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtSubMenu2
        '
        Me.txtSubMenu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubMenu2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "SubMenu2", True))
        Me.txtSubMenu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubMenu2.Location = New System.Drawing.Point(330, 85)
        Me.txtSubMenu2.Name = "txtSubMenu2"
        Me.txtSubMenu2.Size = New System.Drawing.Size(175, 24)
        Me.txtSubMenu2.TabIndex = 3
        Me.txtSubMenu2.Tag = Nothing
        Me.txtSubMenu2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSubMenu2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtScreenName
        '
        Me.txtScreenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScreenName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingHeaderBindingSource, "ScreenName", True))
        Me.txtScreenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreenName.Location = New System.Drawing.Point(10, 60)
        Me.txtScreenName.Name = "txtScreenName"
        Me.txtScreenName.Size = New System.Drawing.Size(225, 24)
        Me.txtScreenName.TabIndex = 0
        Me.txtScreenName.Tag = Nothing
        Me.txtScreenName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtScreenName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.lstTesters.Location = New System.Drawing.Point(515, 35)
        Me.lstTesters.MatchEntryTimeout = CType(2000, Long)
        Me.lstTesters.Name = "lstTesters"
        Me.lstTesters.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstTesters.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstTesters.PreviewInfo.ZoomFactor = 75.0R
        Me.lstTesters.PrintInfo.PageSettings = CType(resources.GetObject("lstTesters.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstTesters.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstTesters.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstTesters.ShowHeaderCheckBox = False
        Me.lstTesters.Size = New System.Drawing.Size(125, 105)
        Me.lstTesters.TabIndex = 4
        Me.lstTesters.Text = "C1List1"
        Me.lstTesters.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstTesters.PropBag = resources.GetString("lstTesters.PropBag")
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
        Me.lstStatus.Location = New System.Drawing.Point(647, 35)
        Me.lstStatus.MatchEntryTimeout = CType(2000, Long)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstStatus.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstStatus.PreviewInfo.ZoomFactor = 75.0R
        Me.lstStatus.PrintInfo.PageSettings = CType(resources.GetObject("lstStatus.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstStatus.ShowHeaderCheckBox = False
        Me.lstStatus.Size = New System.Drawing.Size(125, 105)
        Me.lstStatus.TabIndex = 5
        Me.lstStatus.Text = "C1List2"
        Me.lstStatus.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstStatus.PropBag = resources.GetString("lstStatus.PropBag")
        '
        'chkReadyToTest
        '
        Me.chkReadyToTest.BackColor = System.Drawing.Color.Transparent
        Me.chkReadyToTest.BorderColor = System.Drawing.Color.Transparent
        Me.chkReadyToTest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkReadyToTest.ForeColor = System.Drawing.Color.Black
        Me.chkReadyToTest.Location = New System.Drawing.Point(130, 86)
        Me.chkReadyToTest.Name = "chkReadyToTest"
        Me.chkReadyToTest.Padding = New System.Windows.Forms.Padding(1)
        Me.chkReadyToTest.Size = New System.Drawing.Size(23, 24)
        Me.chkReadyToTest.TabIndex = 25
        Me.chkReadyToTest.UseVisualStyleBackColor = True
        Me.chkReadyToTest.Value = Nothing
        Me.chkReadyToTest.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkReadyToTest.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdShowTasks
        '
        Me.cmdShowTasks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShowTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShowTasks.Location = New System.Drawing.Point(10, 117)
        Me.cmdShowTasks.Name = "cmdShowTasks"
        Me.cmdShowTasks.Size = New System.Drawing.Size(495, 25)
        Me.cmdShowTasks.TabIndex = 6
        Me.cmdShowTasks.Text = "Show tasks for screen "
        Me.cmdShowTasks.UseVisualStyleBackColor = True
        Me.cmdShowTasks.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdShowTasks.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TestingHeaderTableAdapter
        '
        Me.TestingHeaderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TestingHeaderTableAdapter = Me.TestingHeaderTableAdapter
        Me.TableAdapterManager.UpdateOrder = IB.net.dsTestingHeaderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TestingHeaderBindingNavigator
        '
        Me.TestingHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TestingHeaderBindingNavigator.BindingSource = Me.TestingHeaderBindingSource
        Me.TestingHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TestingHeaderBindingNavigator.DeleteItem = Nothing
        Me.TestingHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TestingHeaderBindingNavigatorSaveItem})
        Me.TestingHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TestingHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TestingHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TestingHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TestingHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TestingHeaderBindingNavigator.Name = "TestingHeaderBindingNavigator"
        Me.TestingHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TestingHeaderBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.TestingHeaderBindingNavigator.TabIndex = 8
        Me.TestingHeaderBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TestingHeaderBindingNavigatorSaveItem
        '
        Me.TestingHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TestingHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("TestingHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TestingHeaderBindingNavigatorSaveItem.Name = "TestingHeaderBindingNavigatorSaveItem"
        Me.TestingHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TestingHeaderBindingNavigatorSaveItem.Text = "Save Data"
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
        Me.grdTestingHeader.CaptionHeight = 17
        Me.grdTestingHeader.DataSource = Me.TestingHeaderBindingSource
        Me.grdTestingHeader.FilterBar = True
        Me.grdTestingHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTestingHeader.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTestingHeader.Images.Add(CType(resources.GetObject("grdTestingHeader.Images"), System.Drawing.Image))
        Me.grdTestingHeader.Location = New System.Drawing.Point(10, 148)
        Me.grdTestingHeader.Name = "grdTestingHeader"
        Me.grdTestingHeader.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTestingHeader.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTestingHeader.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTestingHeader.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdTestingHeader.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdTestingHeader.PrintInfo.PageSettings = CType(resources.GetObject("grdTestingHeader.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTestingHeader.RowHeight = 15
        Me.grdTestingHeader.Size = New System.Drawing.Size(762, 340)
        Me.grdTestingHeader.TabIndex = 7
        Me.grdTestingHeader.UseCompatibleTextRendering = False
        Me.grdTestingHeader.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTestingHeader.PropBag = resources.GetString("grdTestingHeader.PropBag")
        '
        'frmTestingMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 500)
        Me.Controls.Add(Me.grdTestingHeader)
        Me.Controls.Add(Me.TestingHeaderBindingNavigator)
        Me.Controls.Add(Me.cmdShowTasks)
        Me.Controls.Add(Me.lstStatus)
        Me.Controls.Add(Me.lstTesters)
        Me.Controls.Add(Me.chkReadyToTest)
        Me.Controls.Add(Me.txtScreenName)
        Me.Controls.Add(Me.txtSubMenu2)
        Me.Controls.Add(Me.txtSubMenu1)
        Me.Controls.Add(Me.txtMenu)
        Me.Controls.Add(ReadyToTestLabel)
        Me.Controls.Add(SubMenu2Label)
        Me.Controls.Add(SubMenu1Label)
        Me.Controls.Add(MenuLabel)
        Me.Controls.Add(ScreenNameLabel)
        Me.Controls.Add(Me.tdrpStatus)
        Me.Controls.Add(Me.tdrpTesters)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTestingMain"
        Me.Text = "IB.net Testing"
        CType(Me.tdrpTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdrpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReadyToTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdShowTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestingHeaderBindingNavigator.ResumeLayout(False)
        Me.TestingHeaderBindingNavigator.PerformLayout()
        CType(Me.grdTestingHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tdrpTesters As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents tdrpStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents txtMenu As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSubMenu1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSubMenu2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtScreenName As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkReadyToTest As C1.Win.C1Input.C1CheckBox
    Friend WithEvents lstTesters As C1.Win.C1List.C1List
    Friend WithEvents lstStatus As C1.Win.C1List.C1List
    Friend WithEvents cmdShowTasks As C1.Win.C1Input.C1Button
    Friend WithEvents DsTestingHeader As dsTestingHeader
    Friend WithEvents TestingHeaderBindingSource As BindingSource
    Friend WithEvents TestingHeaderTableAdapter As dsTestingHeaderTableAdapters.TestingHeaderTableAdapter
    Friend WithEvents TableAdapterManager As dsTestingHeaderTableAdapters.TableAdapterManager
    Friend WithEvents TestingHeaderBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TestingHeaderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DsTesters As dsTesters
    Friend WithEvents TestersBindingSource As BindingSource
    Friend WithEvents TestersTableAdapter As dsTestersTableAdapters.TestersTableAdapter
    Friend WithEvents DsTestingStatus As dsTestingStatus
    Friend WithEvents TestingStatusBindingSource As BindingSource
    Friend WithEvents TestingStatusTableAdapter As dsTestingStatusTableAdapters.TestingStatusTableAdapter
    Friend WithEvents grdTestingHeader As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
