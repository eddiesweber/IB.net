<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectToServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectToServer))
        Me.cmdConnect = New C1.Win.C1Input.C1Button()
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelectServer = New System.Windows.Forms.Label()
        Me.txtOther = New C1.Win.C1Input.C1TextBox()
        Me.lstServerName = New C1.Win.C1List.C1List()
        Me.chkPassword = New C1.Win.C1Input.C1CheckBox()
        Me.grpUsernamePassword = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.txtUserName = New C1.Win.C1Input.C1TextBox()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpServer.SuspendLayout()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUsernamePassword.SuspendLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(355, 185)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(85, 23)
        Me.cmdConnect.TabIndex = 16
        Me.cmdConnect.Text = "Connect "
        Me.cmdConnect.UseVisualStyleBackColor = True
        Me.cmdConnect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdConnect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.chkPassword)
        Me.grpServer.Controls.Add(Me.Label3)
        Me.grpServer.Controls.Add(Me.lblSelectServer)
        Me.grpServer.Controls.Add(Me.txtOther)
        Me.grpServer.Controls.Add(Me.lstServerName)
        Me.grpServer.Location = New System.Drawing.Point(15, 15)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(230, 195)
        Me.grpServer.TabIndex = 24
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Not Connected"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Server not on list"
        '
        'lblSelectServer
        '
        Me.lblSelectServer.AutoSize = True
        Me.lblSelectServer.Location = New System.Drawing.Point(15, 20)
        Me.lblSelectServer.Name = "lblSelectServer"
        Me.lblSelectServer.Size = New System.Drawing.Size(80, 13)
        Me.lblSelectServer.TabIndex = 26
        Me.lblSelectServer.Text = "Select a Server"
        '
        'txtOther
        '
        Me.txtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOther.Location = New System.Drawing.Point(15, 140)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(200, 18)
        Me.txtOther.TabIndex = 25
        Me.txtOther.Tag = Nothing
        Me.txtOther.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtOther.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.lstServerName.Location = New System.Drawing.Point(15, 35)
        Me.lstServerName.MatchEntryTimeout = CType(2000, Long)
        Me.lstServerName.Name = "lstServerName"
        Me.lstServerName.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstServerName.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstServerName.PreviewInfo.ZoomFactor = 75.0R
        Me.lstServerName.PrintInfo.PageSettings = CType(resources.GetObject("lstServerName.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstServerName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstServerName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstServerName.ShowHeaderCheckBox = False
        Me.lstServerName.Size = New System.Drawing.Size(200, 80)
        Me.lstServerName.TabIndex = 24
        Me.lstServerName.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstServerName.PropBag = resources.GetString("lstServerName.PropBag")
        '
        'chkPassword
        '
        Me.chkPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkPassword.BorderColor = System.Drawing.Color.Transparent
        Me.chkPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkPassword.ForeColor = System.Drawing.Color.Black
        Me.chkPassword.Location = New System.Drawing.Point(15, 160)
        Me.chkPassword.Name = "chkPassword"
        Me.chkPassword.Padding = New System.Windows.Forms.Padding(1)
        Me.chkPassword.Size = New System.Drawing.Size(104, 24)
        Me.chkPassword.TabIndex = 28
        Me.chkPassword.Text = "Use Password"
        Me.chkPassword.UseVisualStyleBackColor = True
        Me.chkPassword.Value = Nothing
        Me.chkPassword.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkPassword.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'grpUsernamePassword
        '
        Me.grpUsernamePassword.Controls.Add(Me.Label2)
        Me.grpUsernamePassword.Controls.Add(Me.Label1)
        Me.grpUsernamePassword.Controls.Add(Me.txtPassword)
        Me.grpUsernamePassword.Controls.Add(Me.txtUserName)
        Me.grpUsernamePassword.Location = New System.Drawing.Point(260, 15)
        Me.grpUsernamePassword.Name = "grpUsernamePassword"
        Me.grpUsernamePassword.Size = New System.Drawing.Size(180, 75)
        Me.grpUsernamePassword.TabIndex = 25
        Me.grpUsernamePassword.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(70, 45)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 18)
        Me.txtPassword.TabIndex = 23
        Me.txtPassword.Tag = Nothing
        Me.txtPassword.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtPassword.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(70, 20)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 18)
        Me.txtUserName.TabIndex = 22
        Me.txtUserName.Tag = Nothing
        Me.txtUserName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtUserName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(260, 185)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmConnectToServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 221)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.grpUsernamePassword)
        Me.Controls.Add(Me.grpServer)
        Me.Controls.Add(Me.cmdConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConnectToServer"
        Me.Text = "Connect To Server"
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUsernamePassword.ResumeLayout(False)
        Me.grpUsernamePassword.PerformLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdConnect As C1.Win.C1Input.C1Button
    Friend WithEvents grpServer As GroupBox
    Friend WithEvents chkPassword As C1.Win.C1Input.C1CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSelectServer As Label
    Friend WithEvents txtOther As C1.Win.C1Input.C1TextBox
    Friend WithEvents lstServerName As C1.Win.C1List.C1List
    Friend WithEvents grpUsernamePassword As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtUserName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
End Class
