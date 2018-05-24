<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmROHist
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
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCust = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(175, 14)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(71, 22)
        Me.cmdFind.TabIndex = 8
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Silver
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.ForeColor = System.Drawing.Color.Navy
        Me.txtCustName.Location = New System.Drawing.Point(77, 35)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(197, 13)
        Me.txtCustName.TabIndex = 7
        '
        'txtCust
        '
        Me.txtCust.BackColor = System.Drawing.Color.Silver
        Me.txtCust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCust.ForeColor = System.Drawing.Color.Navy
        Me.txtCust.Location = New System.Drawing.Point(77, 14)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(85, 13)
        Me.txtCust.TabIndex = 6
        Me.txtCust.Text = "Text1"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(441, 14)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(64, 22)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.ForeColor = System.Drawing.Color.Navy
        Me.lblCurCust.Location = New System.Drawing.Point(21, 42)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 3
        Me.lblCurCust.Visible = False
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(14, 14)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 2
        Me.lblLabel0.Text = "&Customer:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(280, 14)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(37, 13)
        Me.lblLabel4.TabIndex = 0
        Me.lblLabel4.Text = "&Since:"
        '
        'frmROHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 356)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblCurCust)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.txtCust)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.cmdFind)
        Me.Location = New System.Drawing.Point(62, 145)
        Me.Name = "frmROHist"
        Me.Text = "Customer Item History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFind As Button
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCust As TextBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblCurCust As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblLabel4 As Label
End Class
