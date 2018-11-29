<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdeptlist
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
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(48, 112)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(75, 34)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "PRINT REPORT"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(40, 56)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(105, 20)
        Me.Text1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Customer Number"
        '
        'frmdeptlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 237)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Command1)
        Me.Location = New System.Drawing.Point(104, 154)
        Me.Name = "frmdeptlist"
        Me.Text = "DEPARTMENT LIST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Command1 As Button
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Label1 As Label
End Class
