<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustCanc
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
        Me.txtMemo = New System.Windows.Forms.TextBox()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMemo
        '
        Me.txtMemo.ForeColor = System.Drawing.Color.Navy
        Me.txtMemo.Location = New System.Drawing.Point(70, 70)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(253, 20)
        Me.txtMemo.TabIndex = 3
        '
        'txtCust
        '
        Me.txtCust.BackColor = System.Drawing.Color.Silver
        Me.txtCust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCust.ForeColor = System.Drawing.Color.Navy
        Me.txtCust.Location = New System.Drawing.Point(70, 14)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(253, 13)
        Me.txtCust.TabIndex = 7
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(189, 98)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(57, 22)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(98, 98)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(57, 22)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(14, 126)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(316, 15)
        Me.lblStatus.TabIndex = 8
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(14, 72)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 2
        Me.lblLabel2.Text = "&Memo:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(14, 44)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "&Date:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(14, 14)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 6
        Me.lblLabel0.Text = "Customer:"
        '
        'frmCustCanc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 145)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.txtCust)
        Me.Controls.Add(Me.txtMemo)
        Me.Location = New System.Drawing.Point(159, 193)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustCanc"
        Me.ShowInTaskbar = False
        Me.Text = "Cancel Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMemo As TextBox
    Friend WithEvents txtCust As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
End Class
