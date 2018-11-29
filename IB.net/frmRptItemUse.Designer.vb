<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptItemUse
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
        Me.cmdPreview1 = New System.Windows.Forms.Button()
        Me.cmdPreview0 = New System.Windows.Forms.Button()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.txtRange1 = New System.Windows.Forms.TextBox()
        Me.txtRange0 = New System.Windows.Forms.TextBox()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(175, 75)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(38, 24)
        Me.cmdPreview1.TabIndex = 10
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(175, 48)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(38, 24)
        Me.cmdPreview0.TabIndex = 9
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(35, 49)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(115, 17)
        Me.chkRpt1.TabIndex = 7
        Me.chkRpt1.Text = "Item &Usage Report"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(35, 77)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(111, 17)
        Me.chkRpt2.TabIndex = 6
        Me.chkRpt2.Text = "Inventory &Analysis"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(147, 140)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(57, 22)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(56, 140)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(57, 22)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'txtRange1
        '
        Me.txtRange1.ForeColor = System.Drawing.Color.Navy
        Me.txtRange1.Location = New System.Drawing.Point(182, 14)
        Me.txtRange1.Multiline = True
        Me.txtRange1.Name = "txtRange1"
        Me.txtRange1.Size = New System.Drawing.Size(64, 22)
        Me.txtRange1.TabIndex = 1
        Me.txtRange1.Text = "9999999"
        '
        'txtRange0
        '
        Me.txtRange0.ForeColor = System.Drawing.Color.Navy
        Me.txtRange0.Location = New System.Drawing.Point(70, 14)
        Me.txtRange0.Multiline = True
        Me.txtRange0.Name = "txtRange0"
        Me.txtRange0.Size = New System.Drawing.Size(64, 22)
        Me.txtRange0.TabIndex = 0
        Me.txtRange0.Text = "1"
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(7, 112)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(246, 15)
        Me.lblStatus1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "through"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Print &Items:"
        '
        'frmRptItemUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.txtRange0)
        Me.Controls.Add(Me.txtRange1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Location = New System.Drawing.Point(203, 289)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptItemUse"
        Me.ShowInTaskbar = False
        Me.Text = "Item Usage Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents cmdPreview0 As Button
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents txtRange1 As TextBox
    Friend WithEvents txtRange0 As TextBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
