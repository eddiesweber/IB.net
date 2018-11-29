<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptExcept
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
        Me.Command1 = New System.Windows.Forms.Button()
        Me.chkPreview = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(56, 184)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(57, 25)
        Me.Command1.TabIndex = 5
        Me.Command1.Text = "OK"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'chkPreview
        '
        Me.chkPreview.AutoSize = True
        Me.chkPreview.Location = New System.Drawing.Point(56, 70)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.Size = New System.Drawing.Size(64, 17)
        Me.chkPreview.TabIndex = 3
        Me.chkPreview.Text = "Preview"
        Me.chkPreview.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(147, 112)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(57, 22)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(56, 112)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(57, 22)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customers with no orders (use calendar for dates)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Print customers with paper items not ordered since:"
        '
        'frmRptExcept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chkPreview)
        Me.Controls.Add(Me.Command1)
        Me.Location = New System.Drawing.Point(203, 289)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptExcept"
        Me.ShowInTaskbar = False
        Me.Text = "Exception Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Command1 As Button
    Friend WithEvents chkPreview As CheckBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
