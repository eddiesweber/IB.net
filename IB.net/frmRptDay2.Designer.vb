<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDay2
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
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optSince1 = New System.Windows.Forms.RadioButton()
        Me.optSince0 = New System.Windows.Forms.RadioButton()
        Me.chkRpt4 = New System.Windows.Forms.CheckBox()
        Me.chkRpt3 = New System.Windows.Forms.CheckBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(147, 70)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(38, 22)
        Me.cmdPreview1.TabIndex = 17
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(147, 42)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(38, 22)
        Me.cmdPreview0.TabIndex = 16
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optSince0)
        Me.Frame1.Controls.Add(Me.optSince1)
        Me.Frame1.Location = New System.Drawing.Point(189, 28)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(148, 36)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Since"
        '
        'optSince1
        '
        Me.optSince1.AutoSize = True
        Me.optSince1.Location = New System.Drawing.Point(77, 14)
        Me.optSince1.Name = "optSince1"
        Me.optSince1.Size = New System.Drawing.Size(69, 17)
        Me.optSince1.TabIndex = 6
        Me.optSince1.TabStop = True
        Me.optSince1.Text = "Tripsheet"
        Me.optSince1.UseVisualStyleBackColor = True
        '
        'optSince0
        '
        Me.optSince0.AutoSize = True
        Me.optSince0.Location = New System.Drawing.Point(7, 14)
        Me.optSince0.Name = "optSince0"
        Me.optSince0.Size = New System.Drawing.Size(69, 17)
        Me.optSince0.TabIndex = 5
        Me.optSince0.TabStop = True
        Me.optSince0.Text = "Calculate"
        Me.optSince0.UseVisualStyleBackColor = True
        '
        'chkRpt4
        '
        Me.chkRpt4.AutoSize = True
        Me.chkRpt4.Location = New System.Drawing.Point(14, 154)
        Me.chkRpt4.Name = "chkRpt4"
        Me.chkRpt4.Size = New System.Drawing.Size(103, 17)
        Me.chkRpt4.TabIndex = 13
        Me.chkRpt4.Text = "&Monthly Reports"
        Me.chkRpt4.UseVisualStyleBackColor = True
        '
        'chkRpt3
        '
        Me.chkRpt3.AutoSize = True
        Me.chkRpt3.Location = New System.Drawing.Point(14, 126)
        Me.chkRpt3.Name = "chkRpt3"
        Me.chkRpt3.Size = New System.Drawing.Size(102, 17)
        Me.chkRpt3.TabIndex = 10
        Me.chkRpt3.Text = "&Weekly Reports"
        Me.chkRpt3.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(35, 203)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 14
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(133, 203)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 15
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(14, 98)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(127, 17)
        Me.chkRpt2.TabIndex = 9
        Me.chkRpt2.Text = "Daily &Volume Reports"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(14, 70)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(135, 17)
        Me.chkRpt1.TabIndex = 7
        Me.chkRpt1.Text = "Route Reciepts &Recap"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(14, 42)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(106, 17)
        Me.chkRpt0.TabIndex = 2
        Me.chkRpt0.Text = "&Invoice Changes"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Quarter Began:"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(7, 182)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
        '
        'frmRptDay2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 231)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.chkRpt3)
        Me.Controls.Add(Me.chkRpt4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Location = New System.Drawing.Point(163, 176)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptDay2"
        Me.ShowInTaskbar = False
        Me.Text = "Recap Reports"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPreview1 As Button
    Friend WithEvents cmdPreview0 As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optSince0 As RadioButton
    Friend WithEvents optSince1 As RadioButton
    Friend WithEvents chkRpt4 As CheckBox
    Friend WithEvents chkRpt3 As CheckBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label1 As Label
End Class
