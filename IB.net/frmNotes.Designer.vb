<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(191, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "name"
        '
        'lblNotes
        '
        Me.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(20, 40)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Padding = New System.Windows.Forms.Padding(10)
        Me.lblNotes.Size = New System.Drawing.Size(250, 186)
        Me.lblNotes.TabIndex = 2
        Me.lblNotes.Text = "Label1"
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 260)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblName)
        Me.Location = New System.Drawing.Point(196, 241)
        Me.Name = "frmNotes"
        Me.Text = "NOTES"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblNotes As Label
End Class
