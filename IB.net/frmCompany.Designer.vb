<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.lstCompany = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(143, 40)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(143, 12)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(64, 22)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'lstCompany
        '
        Me.lstCompany.FormattingEnabled = True
        Me.lstCompany.Location = New System.Drawing.Point(8, 8)
        Me.lstCompany.Name = "lstCompany"
        Me.lstCompany.Size = New System.Drawing.Size(129, 69)
        Me.lstCompany.TabIndex = 2
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 86)
        Me.Controls.Add(Me.lstCompany)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(76, 73)
        Me.Name = "frmCompany"
        Me.Text = "Select Division"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOpen As Button
    Friend WithEvents lstCompany As ListBox
End Class
