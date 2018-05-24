<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelQty
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
        Me.txtCustDept = New System.Windows.Forms.TextBox()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdFindCust = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtdata1 = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lstDept = New System.Windows.Forms.ListBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCustDept
        '
        Me.txtCustDept.BackColor = System.Drawing.Color.Silver
        Me.txtCustDept.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustDept.ForeColor = System.Drawing.Color.Navy
        Me.txtCustDept.Location = New System.Drawing.Point(98, 49)
        Me.txtCustDept.Name = "txtCustDept"
        Me.txtCustDept.Size = New System.Drawing.Size(204, 13)
        Me.txtCustDept.TabIndex = 10
        Me.txtCustDept.TabStop = False
        '
        'txtData0
        '
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(70, 7)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(78, 20)
        Me.txtData0.TabIndex = 1
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(385, 7)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 5
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdFindCust
        '
        Me.cmdFindCust.Location = New System.Drawing.Point(161, 7)
        Me.cmdFindCust.Name = "cmdFindCust"
        Me.cmdFindCust.Size = New System.Drawing.Size(71, 20)
        Me.cmdFindCust.TabIndex = 2
        Me.cmdFindCust.Text = "&Find"
        Me.cmdFindCust.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(385, 63)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(385, 35)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtdata1
        '
        Me.txtdata1.Enabled = False
        Me.txtdata1.ForeColor = System.Drawing.Color.Navy
        Me.txtdata1.Location = New System.Drawing.Point(315, 7)
        Me.txtdata1.Name = "txtdata1"
        Me.txtdata1.Size = New System.Drawing.Size(22, 20)
        Me.txtdata1.TabIndex = 4
        Me.txtdata1.Visible = False
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Silver
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.ForeColor = System.Drawing.Color.Navy
        Me.txtCustName.Location = New System.Drawing.Point(70, 28)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(232, 13)
        Me.txtCustName.TabIndex = 8
        Me.txtCustName.TabStop = False
        '
        'lstDept
        '
        Me.lstDept.FormattingEnabled = True
        Me.lstDept.Location = New System.Drawing.Point(315, 7)
        Me.lstDept.Name = "lstDept"
        Me.lstDept.Size = New System.Drawing.Size(43, 56)
        Me.lstDept.TabIndex = 12
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 7)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Customer:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(273, 7)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "&Dept:"
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(250, 7)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(39, 13)
        Me.lblCurCust.TabIndex = 9
        Me.lblCurCust.Text = "Label1"
        Me.lblCurCust.Visible = False
        '
        'frmDelQty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 153)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lstDept)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtdata1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdFindCust)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtCustDept)
        Me.Location = New System.Drawing.Point(64, 134)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDelQty"
        Me.ShowInTaskbar = False
        Me.Text = "Change Delivery Quantities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustDept As TextBox
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdFindCust As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents txtdata1 As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lstDept As ListBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblCurCust As Label
End Class
