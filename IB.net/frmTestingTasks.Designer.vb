<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestingTasks
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
        Dim ScreenNameLabel As System.Windows.Forms.Label
        Dim TesterLabel As System.Windows.Forms.Label
        Dim TaskLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestingTasks))
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
        Me.ScreenNameTextBox = New System.Windows.Forms.TextBox()
        Me.TaskTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.DsTesters = New IB.net.dsTesters()
        Me.TestersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestersTableAdapter = New IB.net.dsTestersTableAdapters.TestersTableAdapter()
        Me.TableAdapterManager1 = New IB.net.dsTestersTableAdapters.TableAdapterManager()
        Me.drpTester = New C1.Win.C1Input.C1DropDownControl()
        Me.lblCurTaskNumber = New System.Windows.Forms.Label()
        Me.grdTestingTasks = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        ScreenNameLabel = New System.Windows.Forms.Label()
        TesterLabel = New System.Windows.Forms.Label()
        TaskLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        CType(Me.DsTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingTasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestingTasksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TestingTasksBindingNavigator.SuspendLayout()
        CType(Me.DsTesters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScreenNameLabel
        '
        ScreenNameLabel.AutoSize = True
        ScreenNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScreenNameLabel.Location = New System.Drawing.Point(6, 43)
        ScreenNameLabel.Name = "ScreenNameLabel"
        ScreenNameLabel.Size = New System.Drawing.Size(98, 17)
        ScreenNameLabel.TabIndex = 3
        ScreenNameLabel.Text = "Screen Name:"
        '
        'TesterLabel
        '
        TesterLabel.AutoSize = True
        TesterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TesterLabel.Location = New System.Drawing.Point(266, 42)
        TesterLabel.Name = "TesterLabel"
        TesterLabel.Size = New System.Drawing.Size(53, 17)
        TesterLabel.TabIndex = 5
        TesterLabel.Text = "Tester:"
        '
        'TaskLabel
        '
        TaskLabel.AutoSize = True
        TaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaskLabel.Location = New System.Drawing.Point(61, 68)
        TaskLabel.Name = "TaskLabel"
        TaskLabel.Size = New System.Drawing.Size(43, 17)
        TaskLabel.TabIndex = 7
        TaskLabel.Text = "Task:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommentsLabel.Location = New System.Drawing.Point(26, 93)
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
        Me.TestingTasksBindingNavigator.Size = New System.Drawing.Size(808, 25)
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
        'ScreenNameTextBox
        '
        Me.ScreenNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestingTasksBindingSource, "ScreenName", True))
        Me.ScreenNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScreenNameTextBox.Location = New System.Drawing.Point(110, 40)
        Me.ScreenNameTextBox.Name = "ScreenNameTextBox"
        Me.ScreenNameTextBox.Size = New System.Drawing.Size(150, 23)
        Me.ScreenNameTextBox.TabIndex = 4
        '
        'TaskTextBox
        '
        Me.TaskTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestingTasksBindingSource, "Task", True))
        Me.TaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskTextBox.Location = New System.Drawing.Point(110, 65)
        Me.TaskTextBox.Name = "TaskTextBox"
        Me.TaskTextBox.Size = New System.Drawing.Size(416, 23)
        Me.TaskTextBox.TabIndex = 8
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestingTasksBindingSource, "Comments", True))
        Me.CommentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentsTextBox.Location = New System.Drawing.Point(110, 90)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(416, 23)
        Me.CommentsTextBox.TabIndex = 12
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
        'drpTester
        '
        Me.drpTester.AllowDrop = True
        Me.drpTester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.drpTester.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TestersBindingSource, "Tester", True))
        Me.drpTester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drpTester.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.drpTester.Location = New System.Drawing.Point(325, 40)
        Me.drpTester.Name = "drpTester"
        Me.drpTester.Size = New System.Drawing.Size(200, 21)
        Me.drpTester.TabIndex = 14
        Me.drpTester.Tag = Nothing
        Me.drpTester.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.drpTester.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblCurTaskNumber
        '
        Me.lblCurTaskNumber.AutoSize = True
        Me.lblCurTaskNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurTaskNumber.Location = New System.Drawing.Point(545, 64)
        Me.lblCurTaskNumber.Name = "lblCurTaskNumber"
        Me.lblCurTaskNumber.Size = New System.Drawing.Size(125, 17)
        Me.lblCurTaskNumber.TabIndex = 33
        Me.lblCurTaskNumber.Text = "lblCurTaskNumber"
        '
        'grdTestingTasks
        '
        Me.grdTestingTasks.DataSource = Me.TestingTasksBindingSource
        Me.grdTestingTasks.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdTestingTasks.Images.Add(CType(resources.GetObject("grdTestingTasks.Images"), System.Drawing.Image))
        Me.grdTestingTasks.Location = New System.Drawing.Point(9, 119)
        Me.grdTestingTasks.Name = "grdTestingTasks"
        Me.grdTestingTasks.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdTestingTasks.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdTestingTasks.PreviewInfo.ZoomFactor = 75.0R
        Me.grdTestingTasks.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.grdTestingTasks.PrintInfo.MeasurementPrinterName = Nothing
        Me.grdTestingTasks.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdTestingTasks.Size = New System.Drawing.Size(661, 283)
        Me.grdTestingTasks.TabIndex = 34
        Me.grdTestingTasks.UseCompatibleTextRendering = False
        Me.grdTestingTasks.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdTestingTasks.PropBag = resources.GetString("grdTestingTasks.PropBag")
        '
        'frmTestingTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 458)
        Me.Controls.Add(Me.grdTestingTasks)
        Me.Controls.Add(Me.lblCurTaskNumber)
        Me.Controls.Add(Me.drpTester)
        Me.Controls.Add(CommentsLabel)
        Me.Controls.Add(Me.CommentsTextBox)
        Me.Controls.Add(TaskLabel)
        Me.Controls.Add(Me.TaskTextBox)
        Me.Controls.Add(TesterLabel)
        Me.Controls.Add(ScreenNameLabel)
        Me.Controls.Add(Me.ScreenNameTextBox)
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
        CType(Me.drpTester, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTestingTasks, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ScreenNameTextBox As TextBox
    Friend WithEvents TaskTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents DsTesters As dsTesters
    Friend WithEvents TestersBindingSource As BindingSource
    Friend WithEvents TestersTableAdapter As dsTestersTableAdapters.TestersTableAdapter
    Friend WithEvents TableAdapterManager1 As dsTestersTableAdapters.TableAdapterManager
    Friend WithEvents drpTester As C1.Win.C1Input.C1DropDownControl
    Friend WithEvents lblCurTaskNumber As Label
    Friend WithEvents grdTestingTasks As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
