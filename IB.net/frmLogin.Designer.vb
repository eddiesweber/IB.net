<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.grpUsernamePassword = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New C1.Win.C1Input.C1TextBox()
        Me.txtUserName = New C1.Win.C1Input.C1TextBox()
        Me.cmdSave = New C1.Win.C1Input.C1Button()
        Me.grpUsernamePassword.SuspendLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUsernamePassword
        '
        Me.grpUsernamePassword.Controls.Add(Me.Label2)
        Me.grpUsernamePassword.Controls.Add(Me.Label1)
        Me.grpUsernamePassword.Controls.Add(Me.txtPassword)
        Me.grpUsernamePassword.Controls.Add(Me.txtUserName)
        Me.grpUsernamePassword.Location = New System.Drawing.Point(15, 15)
        Me.grpUsernamePassword.Name = "grpUsernamePassword"
        Me.grpUsernamePassword.Size = New System.Drawing.Size(180, 75)
        Me.grpUsernamePassword.TabIndex = 26
        Me.grpUsernamePassword.TabStop = False
        Me.grpUsernamePassword.Text = "Enter usename and password"
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
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(15, 100)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(180, 23)
        Me.cmdSave.TabIndex = 35
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 136)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpUsernamePassword)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.grpUsernamePassword.ResumeLayout(False)
        Me.grpUsernamePassword.PerformLayout()
        CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUsernamePassword As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtUserName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdSave As C1.Win.C1Input.C1Button
End Class
