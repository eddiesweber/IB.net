<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(18, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(191, 13)
        Me.lblName.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(56, 70)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(209, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Label1"
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 263)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblName)
        Me.Location = New System.Drawing.Point(196, 241)
        Me.Name = "frmNotes"
        Me.Text = "NOTES"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lbl1 As Label
End Class
