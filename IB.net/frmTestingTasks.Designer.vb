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
        Dim Label1 As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim TaskLabel As System.Windows.Forms.Label
        Dim TesterLabel As System.Windows.Forms.Label
        Dim ScreenNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingTasks))
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style25 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style26 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style27 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style28 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style29 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style30 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style31 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style32 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style33 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style34 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style35 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style36 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style37 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style38 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style39 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style40 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.DsTesters = New IB.net.dsTesters()
        Me.TestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestersTableAdapter = New IB.net.dsTestersTableAdapters.TestersTableAdapter()
        Me.DsTestingStatus = New IB.net.dsTestingStatus()
        Me.TestingStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestingStatusTableAdapter = New IB.net.dsTestingStatusTableAdapters.TestingStatusTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdReset = New C1.Win.C1Input.C1Button()
        Me.cmdDelete = New C1.Win.C1Input.C1Button()
        Me.cmdNew = New C1.Win.C1Input.C1Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCurTaskNumber = New System.Windows.Forms.Label()
        Me.cmbStatus = New C1.Win.C1List.C1Combo()
        Me.txtComments = New C1.Win.C1Input.C1TextBox()
        Me.TestingTasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTestingTasks = New IB.net.dsTestingTasks()
        Me.txtTask = New C1.Win.C1Input.C1TextBox()
        Me.cmbTester = New C1.Win.C1List.C1Combo()
        Me.txtScreenName = New C1.Win.C1Input.C1TextBox()
        Me.grdTestingTasks = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.drpTester = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.drpStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.TestingTasksTableAdapter = New IB.net.dsTestingTasksTableAdapters.TestingTasksTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        TaskLabel = New System.Windows.Forms.Label()
        TesterLabel = New System.Windows.Forms.Label()
        ScreenNameLabel = New System.Windows.Forms.Label()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Label1.Location = New System.Drawing.Point(434, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 20)
        Label1.TabIndex = 50
        Label1.Text = "Status:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        CommentsLabel.Location = New System.Drawing.Point(26, 97)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(90, 20)
        CommentsLabel.TabIndex = 49
        CommentsLabel.Text = "Comments:"
        '
        'TaskLabel
        '
        TaskLabel.AutoSize = True
        TaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        TaskLabel.Location = New System.Drawing.Point(69, 47)
        TaskLabel.Name = "TaskLabel"
        TaskLabel.Size = New System.Drawing.Size(47, 20)
        TaskLabel.TabIndex = 48
        TaskLabel.Text = "Task:"
        '
        'TesterLabel
        '
        TesterLabel.AutoSize = True
        TesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        TesterLabel.Location = New System.Drawing.Point(436, 47)
        TesterLabel.Name = "TesterLabel"
        TesterLabel.Size = New System.Drawing.Size(58, 20)
        TesterLabel.TabIndex = 47
        TesterLabel.Text = "Tester:"
        '
        'ScreenNameLabel
        '
        ScreenNameLabel.AutoSize = True
        ScreenNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        ScreenNameLabel.Location = New System.Drawing.Point(6, 22)
        ScreenNameLabel.Name = "ScreenNameLabel"
        ScreenNameLabel.Size = New System.Drawing.Size(110, 20)
        ScreenNameLabel.TabIndex = 45
        ScreenNameLabel.Text = "Screen Name:"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdReset)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.cmdNew)
        Me.GroupBox1.Location = New System.Drawing.Point(660, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 200)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(15, 159)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 25)
        Me.cmdExit.TabIndex = 35
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(15, 110)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(85, 25)
        Me.cmdUpdate.TabIndex = 34
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(15, 80)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(85, 25)
        Me.cmdReset.TabIndex = 33
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        Me.cmdReset.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(15, 50)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 25)
        Me.cmdDelete.TabIndex = 32
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        Me.cmdDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(15, 20)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 25)
        Me.cmdNew.TabIndex = 31
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCurTaskNumber)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.cmbStatus)
        Me.GroupBox2.Controls.Add(Me.txtComments)
        Me.GroupBox2.Controls.Add(Me.txtTask)
        Me.GroupBox2.Controls.Add(Me.cmbTester)
        Me.GroupBox2.Controls.Add(Me.txtScreenName)
        Me.GroupBox2.Controls.Add(CommentsLabel)
        Me.GroupBox2.Controls.Add(TaskLabel)
        Me.GroupBox2.Controls.Add(TesterLabel)
        Me.GroupBox2.Controls.Add(ScreenNameLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 200)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'lblCurTaskNumber
        '
        Me.lblCurTaskNumber.AutoSize = True
        Me.lblCurTaskNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurTaskNumber.Location = New System.Drawing.Point(500, 72)
        Me.lblCurTaskNumber.Name = "lblCurTaskNumber"
        Me.lblCurTaskNumber.Size = New System.Drawing.Size(125, 17)
        Me.lblCurTaskNumber.TabIndex = 51
        Me.lblCurTaskNumber.Text = "lblCurTaskNumber"
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
        Me.cmbStatus.Location = New System.Drawing.Point(500, 20)
        Me.cmbStatus.MatchEntryTimeout = CType(2000, Long)
        Me.cmbStatus.MaxDropDownItems = CType(0, Short)
        Me.cmbStatus.MaxLength = 32767
        Me.cmbStatus.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbStatus.Size = New System.Drawing.Size(125, 24)
        Me.cmbStatus.TabIndex = 44
        Me.cmbStatus.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbStatus.PropBag = resources.GetString("cmbStatus.PropBag")
        '
        'txtComments
        '
        Me.txtComments.AutoSize = False
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "Comments", True))
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(115, 95)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(510, 90)
        Me.txtComments.TabIndex = 46
        Me.txtComments.Tag = Nothing
        Me.txtComments.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtComments.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'TestingTasksBindingSource
        '
        Me.TestingTasksBindingSource.DataMember = "TestingTasks"
        Me.TestingTasksBindingSource.DataSource = Me.DsTestingTasks
        '
        'DsTestingTasks
        '
        Me.DsTestingTasks.DataSetName = "dsTestingTasks"
        Me.DsTestingTasks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTask
        '
        Me.txtTask.AutoSize = False
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "Task", True))
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.Location = New System.Drawing.Point(115, 45)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(300, 48)
        Me.txtTask.TabIndex = 42
        Me.txtTask.Tag = Nothing
        Me.txtTask.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTask.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.cmbTester.Location = New System.Drawing.Point(500, 45)
        Me.cmbTester.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTester.MaxDropDownItems = CType(0, Short)
        Me.cmbTester.MaxLength = 32767
        Me.cmbTester.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTester.Name = "cmbTester"
        Me.cmbTester.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTester.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTester.Size = New System.Drawing.Size(125, 24)
        Me.cmbTester.TabIndex = 43
        Me.cmbTester.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbTester.PropBag = resources.GetString("cmbTester.PropBag")
        '
        'txtScreenName
        '
        Me.txtScreenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScreenName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestingTasksBindingSource, "ScreenName", True))
        Me.txtScreenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScreenName.Location = New System.Drawing.Point(115, 20)
        Me.txtScreenName.Name = "txtScreenName"
        Me.txtScreenName.Size = New System.Drawing.Size(300, 24)
        Me.txtScreenName.TabIndex = 41
        Me.txtScreenName.Tag = Nothing
        Me.txtScreenName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtScreenName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'grdTestingTasks
        '
        Me.grdTestingTasks.AllowAddNew = True
        Me.grdTestingTasks.AllowDelete = True
        Me.grdTestingTasks.AlternatingRows = True
        Me.grdTestingTasks.CaptionHeight = 17
        Me.grdTestingTasks.DataSource = Me.TestingTasksBindingSource
        Me.grdTestingTasks.FilterBar = True
        Me.grdTestingTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTestingTasks.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTestingTasks.Images.Add(CType(resources.GetObject("grdTestingTasks.Images"), System.Drawing.Image))
        Me.grdTestingTasks.Location = New System.Drawing.Point(10, 211)
        Me.grdTestingTasks.Name = "grdTestingTasks"
        Me.grdTestingTasks.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTestingTasks.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTestingTasks.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTestingTasks.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdTestingTasks.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdTestingTasks.PrintInfo.PageSettings = CType(resources.GetObject("grdTestingTasks.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTestingTasks.RowHeight = 15
        Me.grdTestingTasks.Size = New System.Drawing.Size(765, 238)
        Me.grdTestingTasks.TabIndex = 43
        Me.grdTestingTasks.UseCompatibleTextRendering = False
        Me.grdTestingTasks.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTestingTasks.PropBag = resources.GetString("grdTestingTasks.PropBag")
        '
        'drpTester
        '
        Me.drpTester.AllowColMove = True
        Me.drpTester.AllowColSelect = True
        Me.drpTester.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpTester.AlternatingRows = False
        Me.drpTester.CaptionHeight = 17
        Me.drpTester.CaptionStyle = Style21
        Me.drpTester.ColumnCaptionHeight = 17
        Me.drpTester.ColumnFooterHeight = 17
        Me.drpTester.ColumnHeaders = False
        Me.drpTester.ColumnSelectorStyle = Style22
        Me.drpTester.DataSource = Me.TestersBindingSource
        Me.drpTester.DisplayMember = "Tester"
        Me.drpTester.EvenRowStyle = Style23
        Me.drpTester.FetchRowStyles = False
        Me.drpTester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpTester.FooterStyle = Style24
        Me.drpTester.HeadingStyle = Style25
        Me.drpTester.HighLightRowStyle = Style26
        Me.drpTester.Images.Add(CType(resources.GetObject("drpTester.Images"), System.Drawing.Image))
        Me.drpTester.Location = New System.Drawing.Point(155, 251)
        Me.drpTester.Name = "drpTester"
        Me.drpTester.OddRowStyle = Style27
        Me.drpTester.RecordSelectorStyle = Style28
        Me.drpTester.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpTester.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpTester.RowHeight = 15
        Me.drpTester.RowSelectorStyle = Style29
        Me.drpTester.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpTester.ScrollTips = False
        Me.drpTester.Size = New System.Drawing.Size(100, 150)
        Me.drpTester.Style = Style30
        Me.drpTester.TabIndex = 44
        Me.drpTester.TabStop = False
        Me.drpTester.UseCompatibleTextRendering = False
        Me.drpTester.ValueMember = "Tester"
        Me.drpTester.Visible = False
        Me.drpTester.PropBag = resources.GetString("drpTester.PropBag")
        '
        'drpStatus
        '
        Me.drpStatus.AllowColMove = True
        Me.drpStatus.AllowColSelect = True
        Me.drpStatus.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpStatus.AlternatingRows = False
        Me.drpStatus.CaptionHeight = 17
        Me.drpStatus.CaptionStyle = Style31
        Me.drpStatus.ColumnCaptionHeight = 17
        Me.drpStatus.ColumnFooterHeight = 17
        Me.drpStatus.ColumnHeaders = False
        Me.drpStatus.ColumnSelectorStyle = Style32
        Me.drpStatus.DataSource = Me.TestingStatusBindingSource
        Me.drpStatus.DisplayMember = "Status"
        Me.drpStatus.EvenRowStyle = Style33
        Me.drpStatus.FetchRowStyles = False
        Me.drpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpStatus.FooterStyle = Style34
        Me.drpStatus.HeadingStyle = Style35
        Me.drpStatus.HighLightRowStyle = Style36
        Me.drpStatus.Images.Add(CType(resources.GetObject("drpStatus.Images"), System.Drawing.Image))
        Me.drpStatus.Location = New System.Drawing.Point(261, 251)
        Me.drpStatus.Name = "drpStatus"
        Me.drpStatus.OddRowStyle = Style37
        Me.drpStatus.RecordSelectorStyle = Style38
        Me.drpStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpStatus.RowHeight = 15
        Me.drpStatus.RowSelectorStyle = Style39
        Me.drpStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpStatus.ScrollTips = False
        Me.drpStatus.Size = New System.Drawing.Size(100, 150)
        Me.drpStatus.Style = Style40
        Me.drpStatus.TabIndex = 45
        Me.drpStatus.TabStop = False
        Me.drpStatus.UseCompatibleTextRendering = False
        Me.drpStatus.ValueMember = "Status"
        Me.drpStatus.Visible = False
        Me.drpStatus.PropBag = resources.GetString("drpStatus.PropBag")
        '
        'TestingTasksTableAdapter
        '
        Me.TestingTasksTableAdapter.ClearBeforeFill = True
        '
        'frmTestingTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.drpStatus)
        Me.Controls.Add(Me.drpTester)
        Me.Controls.Add(Me.grdTestingTasks)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTestingTasks"
        Me.Text = "frmTestingTasks"
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestingTasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTestingTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtScreenName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drpStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsTesters As dsTesters
    Friend WithEvents TestersBindingSource As BindingSource
    Friend WithEvents TestersTableAdapter As dsTestersTableAdapters.TestersTableAdapter
    Friend WithEvents DsTestingStatus As dsTestingStatus
    Friend WithEvents TestingStatusBindingSource As BindingSource
    Friend WithEvents TestingStatusTableAdapter As dsTestingStatusTableAdapters.TestingStatusTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdReset As C1.Win.C1Input.C1Button
    Friend WithEvents cmdDelete As C1.Win.C1Input.C1Button
    Friend WithEvents cmdNew As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbStatus As C1.Win.C1List.C1Combo
    Friend WithEvents txtComments As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTask As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmbTester As C1.Win.C1List.C1Combo
    Friend WithEvents txtScreenName As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCurTaskNumber As Label
    Friend WithEvents grdTestingTasks As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents drpTester As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents drpStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents DsTestingTasks As dsTestingTasks
    Friend WithEvents TestingTasksBindingSource As BindingSource
    Friend WithEvents TestingTasksTableAdapter As dsTestingTasksTableAdapters.TestingTasksTableAdapter
End Class
