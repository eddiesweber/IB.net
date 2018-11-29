<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvPhys2
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
        Me.txtDate0 = New System.Windows.Forms.TextBox()
        Me.Option11 = New System.Windows.Forms.RadioButton()
        Me.Option10 = New System.Windows.Forms.RadioButton()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDate0
        '
        Me.txtDate0.Location = New System.Drawing.Point(208, 16)
        Me.txtDate0.Name = "txtDate0"
        Me.txtDate0.Size = New System.Drawing.Size(81, 20)
        Me.txtDate0.TabIndex = 5
        '
        'Option11
        '
        Me.Option11.AutoSize = True
        Me.Option11.Location = New System.Drawing.Point(16, 48)
        Me.Option11.Name = "Option11"
        Me.Option11.Size = New System.Drawing.Size(148, 17)
        Me.Option11.TabIndex = 1
        Me.Option11.TabStop = True
        Me.Option11.Text = "Start new worksheet as of"
        Me.Option11.UseVisualStyleBackColor = True
        '
        'Option10
        '
        Me.Option10.AutoSize = True
        Me.Option10.Location = New System.Drawing.Point(16, 16)
        Me.Option10.Name = "Option10"
        Me.Option10.Size = New System.Drawing.Size(190, 17)
        Me.Option10.TabIndex = 0
        Me.Option10.TabStop = True
        Me.Option10.Text = "Continue working with counts as of"
        Me.Option10.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(312, 40)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(81, 25)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(312, 8)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(81, 25)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'frmInvPhys2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 82)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Option10)
        Me.Controls.Add(Me.Option11)
        Me.Controls.Add(Me.txtDate0)
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvPhys2"
        Me.ShowInTaskbar = False
        Me.Text = "Physical Inventory Date"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDate0 As TextBox
    Friend WithEvents Option11 As RadioButton
    Friend WithEvents Option10 As RadioButton
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
End Class
