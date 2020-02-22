<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestingTasks
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
        Dim TesterLabel As System.Windows.Forms.Label
        Dim TaskLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingTasks))
        Dim Label1 As System.Windows.Forms.Label
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
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
        Me.DsTestingTasks = New IB.net.dsTestingTasks()
        Me.TestingTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestingTasksTableAdapter = New IB.net.dsTestingTasksTableAdapters.TestingTasksTableAdapter()
        Me.TableAdapterManager = New IB.net.dsTestingTasksTableAdapters.TableAdapterManager()
        Me.TestingTasksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TestingTasksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DsTesters = New IB.net.dsTesters()
        Me.TestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestersTableAdapter = New IB.net.dsTestersTableAdapters.TestersTableAdapter()
        Me.TableAdapterManager1 = New IB.net.dsTestersTableAdapters.TableAdapterManager()
        Me.lblCurTaskNumber = New System.Windows.Forms.Label()
        Me.grdTestingTasks = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtScreenName = New C1.Win.C1Input.C1TextBox()
        Me.cmbTester = New C1.Win.C1List.C1Combo()
        Me.txtTask = New C1.Win.C1Input.C1TextBox()
        Me.txtComments = New C1.Win.C1Input.C1TextBox()
        Me.cmbStatus = New C1.Win.C1List.C1Combo()
        Me.DsTestingStatus = New IB.net.dsTestingStatus()
        Me.TestingStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestingStatusTableAdapter = New IB.net.dsTestingStatusTableAdapters.TestingStatusTableAdapter()
        Me.drpStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.drpTester = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        ScreenNameLabel = New System.Windows.Forms.Label()
        TesterLabel = New System.Windows.Forms.Label()
        TaskLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DsTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingTasksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestingTasksBindingNavigator.SuspendLayout()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScreenNameLabel
        '
        ScreenNameLabel.AutoSize = True
        ScreenNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScreenNameLabel.Location = New System.Drawing.Point(11, 43)
        ScreenNameLabel.Name = "ScreenNameLabel"
        ScreenNameLabel.Size = New System.Drawing.Size(98, 17)
        ScreenNameLabel.TabIndex = 3
        ScreenNameLabel.Text = "Screen Name:"
        '
        'TesterLabel
        '
        TesterLabel.AutoSize = True
        TesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TesterLabel.Location = New System.Drawing.Point(494, 50)
        TesterLabel.Name = "TesterLabel"
        TesterLabel.Size = New System.Drawing.Size(53, 17)
        TesterLabel.TabIndex = 5
        TesterLabel.Text = "Tester:"
        '
        'TaskLabel
        '
        TaskLabel.AutoSize = True
        TaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaskLabel.Location = New System.Drawing.Point(66, 75)
        TaskLabel.Name = "TaskLabel"
        TaskLabel.Size = New System.Drawing.Size(43, 17)
        TaskLabel.TabIndex = 7
        TaskLabel.Text = "Task:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommentsLabel.Location = New System.Drawing.Point(31, 105)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(78, 17)
        CommentsLabel.TabIndex = 11
        CommentsLabel.Text = "Comments:"
        '
        'DsTestingTasks
        '
        Me.DsTestingTasks.DataSetName = "dsTestingTasks"
        Me.DsTestingTasks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestingTasksBindingSource
        '
        Me.TestingTasksBindingSource.DataMember = "TestingTasks"
        Me.TestingTasksBindingSource.DataSource = Me.DsTestingTasks
        '
        'TestingTasksTableAdapter
        '
        Me.TestingTasksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TestingTasksTableAdapter = Me.TestingTasksTableAdapter
        Me.TableAdapterManager.UpdateOrder = IB.net.dsTestingTasksTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TestingTasksBindingNavigator
        '
        Me.TestingTasksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TestingTasksBindingNavigator.BindingSource = Me.TestingTasksBindingSource
        Me.TestingTasksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TestingTasksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TestingTasksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TestingTasksBindingNavigatorSaveItem})
        Me.TestingTasksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TestingTasksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TestingTasksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TestingTasksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TestingTasksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TestingTasksBindingNavigator.Name = "TestingTasksBindingNavigator"
        Me.TestingTasksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TestingTasksBindingNavigator.Size = New System.Drawing.Size(784, 25)
        Me.TestingTasksBindingNavigator.TabIndex = 0
        Me.TestingTasksBindingNavigator.Text = "BindingNavigator1"
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
        'TestingTasksBindingNavigatorSaveItem
        '
        Me.TestingTasksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TestingTasksBindingNavigatorSaveItem.Image = CType(resources.GetObject("TestingTasksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TestingTasksBindingNavigatorSaveItem.Name = "TestingTasksBindingNavigatorSaveItem"
        Me.TestingTasksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TestingTasksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DsTesters
        '
        Me.DsTesters.DataSetName = "dsTesters"
        Me.DsTesters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestersBindingSource
        '
        Me.TestersBindingSource.DataMember = "Testers"
        Me.TestersBindingSource.DataSource = Me.DsTesters
        '
        'TestersTableAdapter
        '
        Me.TestersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TestersTableAdapter = Me.TestersTableAdapter
        Me.TableAdapterManager1.UpdateOrder = IB.net.dsTestersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblCurTaskNumber
        '
        Me.lblCurTaskNumber.AutoSize = True
        Me.lblCurTaskNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurTaskNumber.Location = New System.Drawing.Point(647, 8)
        Me.lblCurTaskNumber.Name = "lblCurTaskNumber"
        Me.lblCurTaskNumber.Size = New System.Drawing.Size(125, 17)
        Me.lblCurTaskNumber.TabIndex = 33
        Me.lblCurTaskNumber.Text = "lblCurTaskNumber"
        '
        'grdTestingTasks
        '
        Me.grdTestingTasks.AllowAddNew = True
        Me.grdTestingTasks.AllowDelete = True
        Me.grdTestingTasks.CaptionHeight = 17
        Me.grdTestingTasks.DataSource = Me.TestingTasksBindingSource
        Me.grdTestingTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTestingTasks.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTestingTasks.Images.Add(CType(resources.GetObject("grdTestingTasks.Images"), System.Drawing.Image))
        Me.grdTestingTasks.Location = New System.Drawing.Point(12, 195)
        Me.grdTestingTasks.Name = "grdTestingTasks"
        Me.grdTestingTasks.Padding = New System.Windows.Forms.Padding(1)
        Me.grdTestingTasks.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTestingTasks.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTestingTasks.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTestingTasks.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdTestingTasks.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdTestingTasks.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTestingTasks.Size = New System.Drawing.Size(760, 254)
        Me.grdTestingTasks.TabIndex = 5
        Me.grdTestingTasks.UseCompatibleTextRendering = False
        Me.grdTestingTasks.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTestingTasks.PropBag = resources.GetString("grdTestingTasks.PropBag")
        '
        'txtScreenName
        '
        Me.txtScreenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScreenName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "ScreenName", True))
        Me.txtScreenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreenName.Location = New System.Drawing.Point(110, 40)
        Me.txtScreenName.Name = "txtScreenName"
        Me.txtScreenName.Size = New System.Drawing.Size(300, 24)
        Me.txtScreenName.TabIndex = 0
        Me.txtScreenName.Tag = Nothing
        Me.txtScreenName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtScreenName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbTester
        '
        Me.cmbTester.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTester.AllowColSelect = True
        Me.cmbTester.AutoSize = False
        Me.cmbTester.Caption = ""
        Me.cmbTester.CaptionHeight = 0
        Me.cmbTester.CaptionVisible = False
        Me.cmbTester.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTester.ColumnHeaders = False
        Me.cmbTester.ColumnWidth = 100
        Me.cmbTester.ContentHeight = 18
        Me.cmbTester.DataSource = Me.TestersBindingSource
        Me.cmbTester.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTester.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTester.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTester.Images.Add(CType(resources.GetObject("cmbTester.Images"), System.Drawing.Image))
        Me.cmbTester.Location = New System.Drawing.Point(491, 70)
        Me.cmbTester.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTester.MaxDropDownItems = CType(0, Short)
        Me.cmbTester.MaxLength = 32767
        Me.cmbTester.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTester.Name = "cmbTester"
        Me.cmbTester.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTester.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTester.Size = New System.Drawing.Size(125, 24)
        Me.cmbTester.TabIndex = 2
        Me.cmbTester.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbTester.PropBag = resources.GetString("cmbTester.PropBag")
        '
        'txtTask
        '
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "Task", True))
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.Location = New System.Drawing.Point(110, 70)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(375, 24)
        Me.txtTask.TabIndex = 1
        Me.txtTask.Tag = Nothing
        Me.txtTask.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTask.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtComments
        '
        Me.txtComments.AutoSize = False
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "Comments", True))
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(110, 100)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(662, 89)
        Me.txtComments.TabIndex = 4
        Me.txtComments.Tag = Nothing
        Me.txtComments.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtComments.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbStatus
        '
        Me.cmbStatus.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbStatus.AllowColSelect = True
        Me.cmbStatus.AutoSize = False
        Me.cmbStatus.Caption = ""
        Me.cmbStatus.CaptionHeight = 0
        Me.cmbStatus.CaptionVisible = False
        Me.cmbStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbStatus.ColumnHeaders = False
        Me.cmbStatus.ColumnWidth = 100
        Me.cmbStatus.ContentHeight = 18
        Me.cmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestingStatusBindingSource, "Status", True))
        Me.cmbStatus.DataSource = Me.TestingStatusBindingSource
        Me.cmbStatus.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbStatus.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbStatus.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Images.Add(CType(resources.GetObject("cmbStatus.Images"), System.Drawing.Image))
        Me.cmbStatus.Location = New System.Drawing.Point(622, 70)
        Me.cmbStatus.MatchEntryTimeout = CType(2000, Long)
        Me.cmbStatus.MaxDropDownItems = CType(0, Short)
        Me.cmbStatus.MaxLength = 32767
        Me.cmbStatus.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbStatus.Size = New System.Drawing.Size(150, 24)
        Me.cmbStatus.TabIndex = 3
        Me.cmbStatus.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbStatus.PropBag = resources.GetString("cmbStatus.PropBag")
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(625, 50)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(52, 17)
        Label1.TabIndex = 40
        Label1.Text = "Status:"
        '
        'DsTestingStatus
        '
        Me.DsTestingStatus.DataSetName = "dsTestingStatus"
        Me.DsTestingStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestingStatusBindingSource
        '
        Me.TestingStatusBindingSource.DataMember = "TestingStatus"
        Me.TestingStatusBindingSource.DataSource = Me.DsTestingStatus
        '
        'TestingStatusTableAdapter
        '
        Me.TestingStatusTableAdapter.ClearBeforeFill = True
        '
        'drpStatus
        '
        Me.drpStatus.AllowColMove = True
        Me.drpStatus.AllowColSelect = True
        Me.drpStatus.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpStatus.AlternatingRows = False
        Me.drpStatus.CaptionHeight = 17
        Me.drpStatus.CaptionStyle = Style1
        Me.drpStatus.ColumnCaptionHeight = 17
        Me.drpStatus.ColumnFooterHeight = 17
        Me.drpStatus.ColumnHeaders = False
        Me.drpStatus.ColumnSelectorStyle = Style2
        Me.drpStatus.DataSource = Me.TestingStatusBindingSource
        Me.drpStatus.DisplayMember = "Status"
        Me.drpStatus.EvenRowStyle = Style3
        Me.drpStatus.FetchRowStyles = False
        Me.drpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpStatus.FooterStyle = Style4
        Me.drpStatus.HeadingStyle = Style5
        Me.drpStatus.HighLightRowStyle = Style6
        Me.drpStatus.Images.Add(CType(resources.GetObject("drpStatus.Images"), System.Drawing.Image))
        Me.drpStatus.Location = New System.Drawing.Point(229, 197)
        Me.drpStatus.Name = "drpStatus"
        Me.drpStatus.OddRowStyle = Style7
        Me.drpStatus.RecordSelectorStyle = Style8
        Me.drpStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpStatus.RowHeight = 15
        Me.drpStatus.RowSelectorStyle = Style9
        Me.drpStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpStatus.ScrollTips = False
        Me.drpStatus.Size = New System.Drawing.Size(100, 150)
        Me.drpStatus.Style = Style10
        Me.drpStatus.TabIndex = 8
        Me.drpStatus.TabStop = False
        Me.drpStatus.UseCompatibleTextRendering = False
        Me.drpStatus.ValueMember = "Status"
        Me.drpStatus.Visible = False
        Me.drpStatus.PropBag = resources.GetString("drpStatus.PropBag")
        '
        'drpTester
        '
        Me.drpTester.AllowColMove = True
        Me.drpTester.AllowColSelect = True
        Me.drpTester.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpTester.AlternatingRows = False
        Me.drpTester.CaptionHeight = 17
        Me.drpTester.CaptionStyle = Style11
        Me.drpTester.ColumnCaptionHeight = 17
        Me.drpTester.ColumnFooterHeight = 17
        Me.drpTester.ColumnHeaders = False
        Me.drpTester.ColumnSelectorStyle = Style12
        Me.drpTester.DataSource = Me.TestersBindingSource
        Me.drpTester.DisplayMember = "Tester"
        Me.drpTester.EvenRowStyle = Style13
        Me.drpTester.FetchRowStyles = False
        Me.drpTester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpTester.FooterStyle = Style14
        Me.drpTester.HeadingStyle = Style15
        Me.drpTester.HighLightRowStyle = Style16
        Me.drpTester.Images.Add(CType(resources.GetObject("drpTester.Images"), System.Drawing.Image))
        Me.drpTester.Location = New System.Drawing.Point(123, 197)
        Me.drpTester.Name = "drpTester"
        Me.drpTester.OddRowStyle = Style17
        Me.drpTester.RecordSelectorStyle = Style18
        Me.drpTester.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpTester.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpTester.RowHeight = 15
        Me.drpTester.RowSelectorStyle = Style19
        Me.drpTester.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpTester.ScrollTips = False
        Me.drpTester.Size = New System.Drawing.Size(100, 150)
        Me.drpTester.Style = Style20
        Me.drpTester.TabIndex = 6
        Me.drpTester.TabStop = False
        Me.drpTester.UseCompatibleTextRendering = False
        Me.drpTester.ValueMember = "Tester"
        Me.drpTester.Visible = False
        Me.drpTester.PropBag = resources.GetString("drpTester.PropBag")
        '
        'frmTestingTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.drpTester)
        Me.Controls.Add(Me.drpStatus)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.cmbTester)
        Me.Controls.Add(Me.txtScreenName)
        Me.Controls.Add(Me.grdTestingTasks)
        Me.Controls.Add(Me.lblCurTaskNumber)
        Me.Controls.Add(CommentsLabel)
        Me.Controls.Add(TaskLabel)
        Me.Controls.Add(TesterLabel)
        Me.Controls.Add(ScreenNameLabel)
        Me.Controls.Add(Me.TestingTasksBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTestingTasks"
        Me.Text = "frmTestingTasks"
        CType(Me.DsTestingTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingTasksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TestingTasksBindingNavigator.ResumeLayout(False)
        Me.TestingTasksBindingNavigator.PerformLayout()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsTestingTasks As dsTestingTasks
    Friend WithEvents TestingTasksBindingSource As BindingSource
    Friend WithEvents TestingTasksTableAdapter As dsTestingTasksTableAdapters.TestingTasksTableAdapter
    Friend WithEvents TableAdapterManager As dsTestingTasksTableAdapters.TableAdapterManager
    Friend WithEvents TestingTasksBindingNavigator As BindingNavigator
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
    Friend WithEvents TestingTasksBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DsTesters As dsTesters
    Friend WithEvents TestersBindingSource As BindingSource
    Friend WithEvents TestersTableAdapter As dsTestersTableAdapters.TestersTableAdapter
    Friend WithEvents TableAdapterManager1 As dsTestersTableAdapters.TableAdapterManager
    Friend WithEvents lblCurTaskNumber As Label
    Friend WithEvents grdTestingTasks As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtScreenName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmbTester As C1.Win.C1List.C1Combo
    Friend WithEvents txtTask As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtComments As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmbStatus As C1.Win.C1List.C1Combo
    Friend WithEvents DsTestingStatus As dsTestingStatus
    Friend WithEvents TestingStatusBindingSource As BindingSource
    Friend WithEvents TestingStatusTableAdapter As dsTestingStatusTableAdapters.TestingStatusTableAdapter
    Friend WithEvents drpStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents drpTester As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
End Class
