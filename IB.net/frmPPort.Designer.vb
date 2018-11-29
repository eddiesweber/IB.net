<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPPort
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
        Me.lstPrinters = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(210, 84)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(210, 28)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lstPrinters
        '
        Me.lstPrinters.ForeColor = System.Drawing.Color.Navy
        Me.lstPrinters.FormattingEnabled = True
        Me.lstPrinters.Location = New System.Drawing.Point(14, 14)
        Me.lstPrinters.Name = "lstPrinters"
        Me.lstPrinters.Size = New System.Drawing.Size(176, 147)
        Me.lstPrinters.TabIndex = 0
        '
        'frmPPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 169)
        Me.Controls.Add(Me.lstPrinters)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Location = New System.Drawing.Point(358, 106)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPPort"
        Me.ShowInTaskbar = False
        Me.Text = "Select Invoice Printer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lstPrinters As ListBox
End Class
