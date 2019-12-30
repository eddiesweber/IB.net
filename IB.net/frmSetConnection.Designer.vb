<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetConnection))
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.txtUserName = New C1.Win.C1Input.C1TextBox()
        Me.cmdConnect = New C1.Win.C1Input.C1Button()
        Me.txtOther = New C1.Win.C1Input.C1TextBox()
        Me.lstServerName = New C1.Win.C1List.C1List()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        Me.cmdConnectDivision = New C1.Win.C1Input.C1Button()
        Me.lstDivision = New C1.Win.C1List.C1List()
        Me.cmdSave = New C1.Win.C1Input.C1Button()
        Me.grpServer.SuspendLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDivision.SuspendLayout()
        CType(Me.cmdConnectDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.txtPassword)
        Me.grpServer.Controls.Add(Me.txtUserName)
        Me.grpServer.Controls.Add(Me.cmdConnect)
        Me.grpServer.Controls.Add(Me.txtOther)
        Me.grpServer.Controls.Add(Me.lstServerName)
        Me.grpServer.Location = New System.Drawing.Point(15, 10)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(520, 170)
        Me.grpServer.TabIndex = 7
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Not Connected"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(300, 60)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 18)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.Tag = Nothing
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(300, 40)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 18)
        Me.txtUserName.TabIndex = 12
        Me.txtUserName.Tag = Nothing
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(415, 130)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(85, 23)
        Me.cmdConnect.TabIndex = 11
        Me.cmdConnect.Text = "Connect "
        Me.cmdConnect.UseVisualStyleBackColor = True
        Me.cmdConnect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdConnect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(20, 135)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(199, 18)
        Me.txtOther.TabIndex = 9
        Me.txtOther.Tag = Nothing
        '
        'lstServerName
        '
        Me.lstServerName.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstServerName.Caption = ""
        Me.lstServerName.ColumnHeaders = False
        Me.lstServerName.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.lstServerName.DeadAreaBackColor = System.Drawing.SystemColors.Window
        Me.lstServerName.ExtendRightColumn = True
        Me.lstServerName.Images.Add(CType(resources.GetObject("lstServerName.Images"), System.Drawing.Image))
        Me.lstServerName.ItemHeight = 15
        Me.lstServerName.Location = New System.Drawing.Point(20, 35)
        Me.lstServerName.MatchEntryTimeout = CType(2000, Long)
        Me.lstServerName.Name = "lstServerName"
        Me.lstServerName.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstServerName.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstServerName.PreviewInfo.ZoomFactor = 75.0R
        Me.lstServerName.PrintInfo.PageSettings = CType(resources.GetObject("lstServerName.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstServerName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstServerName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstServerName.ShowHeaderCheckBox = False
        Me.lstServerName.Size = New System.Drawing.Size(199, 82)
        Me.lstServerName.TabIndex = 8
        Me.lstServerName.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstServerName.PropBag = resources.GetString("lstServerName.PropBag")
        '
        'grpDivision
        '
        Me.grpDivision.Controls.Add(Me.cmdConnectDivision)
        Me.grpDivision.Controls.Add(Me.lstDivision)
        Me.grpDivision.Location = New System.Drawing.Point(15, 182)
        Me.grpDivision.Name = "grpDivision"
        Me.grpDivision.Size = New System.Drawing.Size(520, 130)
        Me.grpDivision.TabIndex = 0
        Me.grpDivision.TabStop = False
        Me.grpDivision.Text = "Not Connected"
        '
        'cmdConnectDivision
        '
        Me.cmdConnectDivision.Enabled = False
        Me.cmdConnectDivision.Location = New System.Drawing.Point(415, 94)
        Me.cmdConnectDivision.Name = "cmdConnectDivision"
        Me.cmdConnectDivision.Size = New System.Drawing.Size(85, 23)
        Me.cmdConnectDivision.TabIndex = 12
        Me.cmdConnectDivision.Text = "Connect "
        Me.cmdConnectDivision.UseVisualStyleBackColor = True
        Me.cmdConnectDivision.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdConnectDivision.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lstDivision
        '
        Me.lstDivision.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstDivision.Caption = ""
        Me.lstDivision.ColumnHeaders = False
        Me.lstDivision.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.lstDivision.DeadAreaBackColor = System.Drawing.SystemColors.Window
        Me.lstDivision.ExtendRightColumn = True
        Me.lstDivision.Images.Add(CType(resources.GetObject("lstDivision.Images"), System.Drawing.Image))
        Me.lstDivision.ItemHeight = 15
        Me.lstDivision.Location = New System.Drawing.Point(20, 35)
        Me.lstDivision.MatchEntryTimeout = CType(2000, Long)
        Me.lstDivision.Name = "lstDivision"
        Me.lstDivision.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstDivision.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstDivision.PreviewInfo.ZoomFactor = 75.0R
        Me.lstDivision.PrintInfo.PageSettings = CType(resources.GetObject("lstDivision.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstDivision.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstDivision.ShowHeaderCheckBox = False
        Me.lstDivision.Size = New System.Drawing.Size(200, 82)
        Me.lstDivision.TabIndex = 9
        Me.lstDivision.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstDivision.PropBag = resources.GetString("lstDivision.PropBag")
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(430, 322)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Close"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmSetConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 355)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpDivision)
        Me.Controls.Add(Me.grpServer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetConnection"
        Me.Text = "Connect to Server"
        Me.grpServer.ResumeLayout(False)
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDivision.ResumeLayout(False)
        CType(Me.cmdConnectDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpServer As GroupBox
    Friend WithEvents lblUsername As C1.Win.C1Input.C1Label
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtUserName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdConnect As C1.Win.C1Input.C1Button
    Friend WithEvents lblOther As C1.Win.C1Input.C1Label
    Friend WithEvents txtOther As C1.Win.C1Input.C1TextBox
    Friend WithEvents lstServerName As C1.Win.C1List.C1List
    Friend WithEvents grpDivision As GroupBox
    Friend WithEvents lblConnectionString As C1.Win.C1Input.C1Label
    Friend WithEvents lblServerName As C1.Win.C1Input.C1Label
    Friend WithEvents cmdConnectDivision As C1.Win.C1Input.C1Button
    Friend WithEvents lstDivision As C1.Win.C1List.C1List
    Friend WithEvents cmdSave As C1.Win.C1Input.C1Button
    Friend WithEvents C1Label2 As C1.Win.C1Input.C1Label
End Class
