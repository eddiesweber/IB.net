<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAvgRev
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
        Me.cmdPreview2 = New System.Windows.Forms.Button()
        Me.cmdPreview1 = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdPreview2
        '
        Me.cmdPreview2.Location = New System.Drawing.Point(147, 77)
        Me.cmdPreview2.Name = "cmdPreview2"
        Me.cmdPreview2.Size = New System.Drawing.Size(38, 25)
        Me.cmdPreview2.TabIndex = 7
        Me.cmdPreview2.Text = "View"
        Me.cmdPreview2.UseVisualStyleBackColor = True
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(147, 42)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(38, 25)
        Me.cmdPreview1.TabIndex = 6
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(35, 140)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(154, 140)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(14, 84)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(98, 17)
        Me.chkRpt2.TabIndex = 1
        Me.chkRpt2.Text = "&Change Report"
        Me.chkRpt2.UseVisualStyleBackColor = True
        Me.chkRpt2.Visible = False
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(14, 49)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(118, 17)
        Me.chkRpt1.TabIndex = 0
        Me.chkRpt1.Text = "&Top 100 Customers"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'lblStatus0
        '
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(7, 14)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(246, 15)
        Me.lblStatus0.TabIndex = 2
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(7, 119)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(246, 15)
        Me.lblStatus1.TabIndex = 3
        '
        'frmRptAvgRev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 173)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptAvgRev"
        Me.ShowInTaskbar = False
        Me.Text = "Average Revenue Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPreview2 As Button
    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents lblStatus1 As Label
End Class
