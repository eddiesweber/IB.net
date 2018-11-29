<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSales
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
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.cmdPreview1 = New System.Windows.Forms.Button()
        Me.cmdPreview0 = New System.Windows.Forms.Button()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStaus0 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbCat
        '
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Location = New System.Drawing.Point(84, 49)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(71, 21)
        Me.cmbCat.TabIndex = 9
        Me.cmbCat.Text = "DataCombo1"
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(190, 124)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(38, 24)
        Me.cmdPreview1.TabIndex = 8
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(189, 90)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(38, 24)
        Me.cmdPreview0.TabIndex = 7
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(21, 91)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(149, 17)
        Me.chkRpt0.TabIndex = 0
        Me.chkRpt0.Text = "&Production (Sales by Item)"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(35, 189)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(154, 189)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(21, 126)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(162, 17)
        Me.chkRpt1.TabIndex = 1
        Me.chkRpt1.Text = "&Top 100 (Sales by Customer)"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Category:"
        '
        'lblStaus0
        '
        Me.lblStaus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStaus0.Location = New System.Drawing.Point(7, 14)
        Me.lblStaus0.Name = "lblStaus0"
        Me.lblStaus0.Size = New System.Drawing.Size(253, 15)
        Me.lblStaus0.TabIndex = 6
        '
        'lblStatus1
        '
        Me.lblStatus1.Location = New System.Drawing.Point(14, 168)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(232, 15)
        Me.lblStatus1.TabIndex = 5
        '
        'frmRptSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 220)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.lblStaus0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmbCat)
        Me.Location = New System.Drawing.Point(237, 226)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptSales"
        Me.ShowInTaskbar = False
        Me.Text = "Sales Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents cmdPreview0 As Button
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStaus0 As Label
    Friend WithEvents lblStatus1 As Label
End Class
