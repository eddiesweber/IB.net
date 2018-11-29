<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurge
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
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lblCount0 = New System.Windows.Forms.Label()
        Me.lblMonth0 = New System.Windows.Forms.Label()
        Me.lblName0 = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.lblHead1 = New System.Windows.Forms.Label()
        Me.lblHead0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(182, 168)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(70, 168)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 6
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lblCount0
        '
        Me.lblCount0.AutoSize = True
        Me.lblCount0.ForeColor = System.Drawing.Color.Navy
        Me.lblCount0.Location = New System.Drawing.Point(266, 42)
        Me.lblCount0.Name = "lblCount0"
        Me.lblCount0.Size = New System.Drawing.Size(35, 13)
        Me.lblCount0.TabIndex = 5
        Me.lblCount0.Text = "Count"
        Me.lblCount0.Visible = False
        '
        'lblMonth0
        '
        Me.lblMonth0.AutoSize = True
        Me.lblMonth0.ForeColor = System.Drawing.Color.Navy
        Me.lblMonth0.Location = New System.Drawing.Point(210, 42)
        Me.lblMonth0.Name = "lblMonth0"
        Me.lblMonth0.Size = New System.Drawing.Size(42, 13)
        Me.lblMonth0.TabIndex = 4
        Me.lblMonth0.Text = "Months"
        Me.lblMonth0.Visible = False
        '
        'lblName0
        '
        Me.lblName0.AutoSize = True
        Me.lblName0.ForeColor = System.Drawing.Color.Navy
        Me.lblName0.Location = New System.Drawing.Point(7, 42)
        Me.lblName0.Name = "lblName0"
        Me.lblName0.Size = New System.Drawing.Size(60, 13)
        Me.lblName0.TabIndex = 3
        Me.lblName0.Text = "Description"
        Me.lblName0.Visible = False
        '
        'lblHead2
        '
        Me.lblHead2.Location = New System.Drawing.Point(266, 7)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(48, 29)
        Me.lblHead2.TabIndex = 2
        Me.lblHead2.Text = "Records Deleted"
        '
        'lblHead1
        '
        Me.lblHead1.Location = New System.Drawing.Point(210, 7)
        Me.lblHead1.Name = "lblHead1"
        Me.lblHead1.Size = New System.Drawing.Size(46, 29)
        Me.lblHead1.TabIndex = 1
        Me.lblHead1.Text = "Months to Keep"
        '
        'lblHead0
        '
        Me.lblHead0.AutoSize = True
        Me.lblHead0.Location = New System.Drawing.Point(7, 21)
        Me.lblHead0.Name = "lblHead0"
        Me.lblHead0.Size = New System.Drawing.Size(92, 13)
        Me.lblHead0.TabIndex = 0
        Me.lblHead0.Text = "Data File to Purge"
        '
        'frmPurge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 200)
        Me.Controls.Add(Me.lblHead0)
        Me.Controls.Add(Me.lblHead1)
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.lblName0)
        Me.Controls.Add(Me.lblMonth0)
        Me.Controls.Add(Me.lblCount0)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Location = New System.Drawing.Point(97, 106)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurge"
        Me.ShowInTaskbar = False
        Me.Text = "Purge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lblCount0 As Label
    Friend WithEvents lblMonth0 As Label
    Friend WithEvents lblName0 As Label
    Friend WithEvents lblHead2 As Label
    Friend WithEvents lblHead1 As Label
    Friend WithEvents lblHead0 As Label
End Class
