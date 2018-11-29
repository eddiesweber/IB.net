<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentCommEdit
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
        Me.lstSales2 = New System.Windows.Forms.ListBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.optCust1 = New System.Windows.Forms.RadioButton()
        Me.optCust0 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lstSales2
        '
        Me.lstSales2.FormattingEnabled = True
        Me.lstSales2.Location = New System.Drawing.Point(56, 175)
        Me.lstSales2.Name = "lstSales2"
        Me.lstSales2.Size = New System.Drawing.Size(43, 82)
        Me.lstSales2.TabIndex = 4
        Me.lstSales2.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(308, 7)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(64, 22)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'optCust1
        '
        Me.optCust1.AutoSize = True
        Me.optCust1.Location = New System.Drawing.Point(119, 14)
        Me.optCust1.Name = "optCust1"
        Me.optCust1.Size = New System.Drawing.Size(92, 17)
        Me.optCust1.TabIndex = 1
        Me.optCust1.TabStop = True
        Me.optCust1.Text = "&Changed Only"
        Me.optCust1.UseVisualStyleBackColor = True
        '
        'optCust0
        '
        Me.optCust0.AutoSize = True
        Me.optCust0.Location = New System.Drawing.Point(7, 14)
        Me.optCust0.Name = "optCust0"
        Me.optCust0.Size = New System.Drawing.Size(88, 17)
        Me.optCust0.TabIndex = 0
        Me.optCust0.TabStop = True
        Me.optCust0.Text = "&All Customers"
        Me.optCust0.UseVisualStyleBackColor = True
        '
        'frmRentCommEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 394)
        Me.Controls.Add(Me.optCust0)
        Me.Controls.Add(Me.optCust1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lstSales2)
        Me.Location = New System.Drawing.Point(55, 95)
        Me.Name = "frmRentCommEdit"
        Me.Text = "Edit Rental Commissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSales2 As ListBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents optCust1 As RadioButton
    Friend WithEvents optCust0 As RadioButton
End Class
