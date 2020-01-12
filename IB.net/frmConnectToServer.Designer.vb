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
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.cmdConnect = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelectServer = New System.Windows.Forms.Label()
        Me.txtOther = New C1.Win.C1Input.C1TextBox()
        Me.lstServerName = New C1.Win.C1List.C1List()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAutoConnect = New C1.Win.C1Input.C1Button()
        Me.optPortland = New System.Windows.Forms.RadioButton()
        Me.optSeattle = New System.Windows.Forms.RadioButton()
        Me.optLosAngeles = New System.Windows.Forms.RadioButton()
        Me.optSanFrancisco = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstStatus = New C1.Win.C1List.C1List()
        Me.grpServer.SuspendLayout()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmdAutoConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.cmdConnect)
        Me.grpServer.Controls.Add(Me.Label3)
        Me.grpServer.Controls.Add(Me.lblSelectServer)
        Me.grpServer.Controls.Add(Me.txtOther)
        Me.grpServer.Controls.Add(Me.lstServerName)
        Me.grpServer.Location = New System.Drawing.Point(150, 15)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(230, 200)
        Me.grpServer.TabIndex = 24
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Manual Connection"
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(15, 164)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(200, 23)
        Me.cmdConnect.TabIndex = 28
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        Me.cmdConnect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdConnect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(15, 391)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(365, 23)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdAutoConnect)
        Me.GroupBox1.Controls.Add(Me.optPortland)
        Me.GroupBox1.Controls.Add(Me.optSeattle)
        Me.GroupBox1.Controls.Add(Me.optLosAngeles)
        Me.GroupBox1.Controls.Add(Me.optSanFrancisco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 200)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatic Connection"
        '
        'cmdAutoConnect
        '
        Me.cmdAutoConnect.Location = New System.Drawing.Point(15, 165)
        Me.cmdAutoConnect.Name = "cmdAutoConnect"
        Me.cmdAutoConnect.Size = New System.Drawing.Size(95, 23)
        Me.cmdAutoConnect.TabIndex = 34
        Me.cmdAutoConnect.Text = "Connect "
        Me.cmdAutoConnect.UseVisualStyleBackColor = True
        Me.cmdAutoConnect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdAutoConnect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optPortland
        '
        Me.optPortland.AutoSize = True
        Me.optPortland.Checked = True
        Me.optPortland.Location = New System.Drawing.Point(20, 40)
        Me.optPortland.Name = "optPortland"
        Me.optPortland.Size = New System.Drawing.Size(64, 17)
        Me.optPortland.TabIndex = 33
        Me.optPortland.TabStop = True
        Me.optPortland.Text = "Portland"
        Me.optPortland.UseVisualStyleBackColor = True
        '
        'optSeattle
        '
        Me.optSeattle.AutoSize = True
        Me.optSeattle.Location = New System.Drawing.Point(20, 60)
        Me.optSeattle.Name = "optSeattle"
        Me.optSeattle.Size = New System.Drawing.Size(58, 17)
        Me.optSeattle.TabIndex = 32
        Me.optSeattle.Text = "Seattle"
        Me.optSeattle.UseVisualStyleBackColor = True
        '
        'optLosAngeles
        '
        Me.optLosAngeles.AutoSize = True
        Me.optLosAngeles.Location = New System.Drawing.Point(20, 80)
        Me.optLosAngeles.Name = "optLosAngeles"
        Me.optLosAngeles.Size = New System.Drawing.Size(83, 17)
        Me.optLosAngeles.TabIndex = 31
        Me.optLosAngeles.Text = "Los Angeles"
        Me.optLosAngeles.UseVisualStyleBackColor = True
        '
        'optSanFrancisco
        '
        Me.optSanFrancisco.AutoSize = True
        Me.optSanFrancisco.Location = New System.Drawing.Point(20, 100)
        Me.optSanFrancisco.Name = "optSanFrancisco"
        Me.optSanFrancisco.Size = New System.Drawing.Size(93, 17)
        Me.optSanFrancisco.TabIndex = 30
        Me.optSanFrancisco.Text = "San Francisco"
        Me.optSanFrancisco.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Select your location"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 160)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Connection Status"
        '
        'lstStatus
        '
        Me.lstStatus.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.lstStatus.Caption = ""
        Me.lstStatus.ColumnHeaders = False
        Me.lstStatus.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.lstStatus.DeadAreaBackColor = System.Drawing.SystemColors.Window
        Me.lstStatus.ExtendRightColumn = True
        Me.lstStatus.Images.Add(CType(resources.GetObject("lstStatus.Images"), System.Drawing.Image))
        Me.lstStatus.ItemHeight = 15
        Me.lstStatus.Location = New System.Drawing.Point(15, 20)
        Me.lstStatus.MatchEntryTimeout = CType(2000, Long)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.lstStatus.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.lstStatus.PreviewInfo.ZoomFactor = 75.0R
        Me.lstStatus.PrintInfo.PageSettings = CType(resources.GetObject("lstStatus.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.lstStatus.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.lstStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.lstStatus.ShowHeaderCheckBox = False
        Me.lstStatus.Size = New System.Drawing.Size(335, 125)
        Me.lstStatus.TabIndex = 39
        Me.lstStatus.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.lstStatus.PropBag = resources.GetString("lstStatus.PropBag")
        '
        'frmConnectToServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 426)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.grpServer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConnectToServer"
        Me.Text = "Connect To Server"
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        CType(Me.cmdConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstServerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmdAutoConnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.lstStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpServer As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSelectServer As Label
    Friend WithEvents txtOther As C1.Win.C1Input.C1TextBox
    Friend WithEvents lstServerName As C1.Win.C1List.C1List
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdAutoConnect As C1.Win.C1Input.C1Button
    Friend WithEvents optPortland As RadioButton
    Friend WithEvents optSeattle As RadioButton
    Friend WithEvents optLosAngeles As RadioButton
    Friend WithEvents optSanFrancisco As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdConnect As C1.Win.C1Input.C1Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstStatus As C1.Win.C1List.C1List
End Class
