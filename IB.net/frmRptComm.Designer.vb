<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptComm
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
        Me.cmdPreview0 = New System.Windows.Forms.Button()
        Me.cmdPreview1 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(175, 70)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(38, 25)
        Me.cmdPreview0.TabIndex = 10
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(175, 105)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(38, 25)
        Me.cmdPreview1.TabIndex = 9
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(14, 7)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(239, 57)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Date Range:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "to"
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(35, 77)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(53, 17)
        Me.chkRpt0.TabIndex = 4
        Me.chkRpt0.Text = "D&etail"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(35, 161)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(154, 161)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(35, 105)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(69, 17)
        Me.chkRpt1.TabIndex = 5
        Me.chkRpt1.Text = "&Summary"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(14, 140)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(253, 15)
        Me.lblStatus1.TabIndex = 6
        '
        'frmRptComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 190)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Location = New System.Drawing.Point(237, 226)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptComm"
        Me.ShowInTaskbar = False
        Me.Text = "Commission Reports"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPreview0 As Button
    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents lblStatus1 As Label
End Class
