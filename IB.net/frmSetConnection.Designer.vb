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
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.lblServerName = New C1.Win.C1Input.C1Label()
        Me.lblUsername = New C1.Win.C1Input.C1Label()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.txtUserName = New C1.Win.C1Input.C1TextBox()
        Me.cmdConnect = New C1.Win.C1Input.C1Button()
        Me.lblOther = New C1.Win.C1Input.C1Label()
        Me.txtOther = New C1.Win.C1Input.C1TextBox()
        Me.lstServerName = New C1.Win.C1List.C1List()
        Me.grpDivision = New System.Windows.Forms.GroupBox()
        Me.C1Label2 = New C1.Win.C1Input.C1Label()
        Me.cmdConnectDivision = New C1.Win.C1Input.C1Button()
        Me.lstDivision = New C1.Win.C1List.C1List()
        Me.lblConnectionString = New C1.Win.C1Input.C1Label()
        Me.cmdSave = New C1.Win.C1Input.C1Button()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServer.SuspendLayout()
        CType(Me.lblServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDivision.SuspendLayout()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdConnectDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblConnectionString, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(339, 350)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.lblServerName)
        Me.grpServer.Controls.Add(Me.lblUsername)
        Me.grpServer.Controls.Add(Me.C1Label1)
        Me.grpServer.Controls.Add(Me.txtPassword)
        Me.grpServer.Controls.Add(Me.txtUserName)
        Me.grpServer.Controls.Add(Me.cmdConnect)
        Me.grpServer.Controls.Add(Me.lblOther)
        Me.grpServer.Controls.Add(Me.txtOther)
        Me.grpServer.Controls.Add(Me.lstServerName)
        Me.grpServer.Location = New System.Drawing.Point(15, 38)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(520, 170)
        Me.grpServer.TabIndex = 7
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Not Connected"
        '
        'lblServerName
        '
        Me.lblServerName.AutoSize = True
        Me.lblServerName.BackColor = System.Drawing.Color.Transparent
        Me.lblServerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblServerName.ForeColor = System.Drawing.Color.Black
        Me.lblServerName.Location = New System.Drawing.Point(20, 20)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.Size = New System.Drawing.Size(76, 13)
        Me.lblServerName.TabIndex = 17
        Me.lblServerName.Tag = Nothing
        Me.lblServerName.Value = "Server Name"
        Me.lblServerName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.lblServerName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(236, 43)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(65, 13)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Tag = Nothing
        Me.lblUsername.Value = "Username:"
        Me.lblUsername.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.lblUsername.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BackColor = System.Drawing.Color.Transparent
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.ForeColor = System.Drawing.Color.Black
        Me.C1Label1.Location = New System.Drawing.Point(238, 63)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(52, 13)
        Me.C1Label1.TabIndex = 14
        Me.C1Label1.Tag = Nothing
        Me.C1Label1.Value = "Password:"
        Me.C1Label1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.BackColor = System.Drawing.Color.Transparent
        Me.lblOther.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblOther.ForeColor = System.Drawing.Color.Black
        Me.lblOther.Location = New System.Drawing.Point(20, 120)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(43, 13)
        Me.lblOther.TabIndex = 10
        Me.lblOther.Tag = Nothing
        Me.lblOther.Value = "Other Server"
        Me.lblOther.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.lblOther.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.grpDivision.Controls.Add(Me.C1Label2)
        Me.grpDivision.Controls.Add(Me.cmdConnectDivision)
        Me.grpDivision.Controls.Add(Me.lstDivision)
        Me.grpDivision.Location = New System.Drawing.Point(15, 210)
        Me.grpDivision.Name = "grpDivision"
        Me.grpDivision.Size = New System.Drawing.Size(520, 130)
        Me.grpDivision.TabIndex = 0
        Me.grpDivision.TabStop = False
        Me.grpDivision.Text = "Not Connected"
        '
        'C1Label2
        '
        Me.C1Label2.AutoSize = True
        Me.C1Label2.BackColor = System.Drawing.Color.Transparent
        Me.C1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label2.ForeColor = System.Drawing.Color.Black
        Me.C1Label2.Location = New System.Drawing.Point(20, 19)
        Me.C1Label2.Name = "C1Label2"
        Me.C1Label2.Size = New System.Drawing.Size(52, 13)
        Me.C1Label2.TabIndex = 18
        Me.C1Label2.Tag = Nothing
        Me.C1Label2.Value = "Division"
        Me.C1Label2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        'lblConnectionString
        '
        Me.lblConnectionString.AutoSize = True
        Me.lblConnectionString.BackColor = System.Drawing.Color.Transparent
        Me.lblConnectionString.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblConnectionString.ForeColor = System.Drawing.Color.Black
        Me.lblConnectionString.Location = New System.Drawing.Point(23, 13)
        Me.lblConnectionString.Name = "lblConnectionString"
        Me.lblConnectionString.Size = New System.Drawing.Size(98, 13)
        Me.lblConnectionString.TabIndex = 9
        Me.lblConnectionString.Tag = Nothing
        Me.lblConnectionString.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.lblConnectionString.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(430, 350)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 23)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmSetConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 381)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lblConnectionString)
        Me.Controls.Add(Me.grpDivision)
        Me.Controls.Add(Me.grpServer)
        Me.Controls.Add(Me.cmdCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetConnection"
        Me.Text = "frmSetConnection"
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        CType(Me.lblServerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDivision.ResumeLayout(False)
        Me.grpDivision.PerformLayout()
        CType(Me.C1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdConnectDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblConnectionString, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
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
