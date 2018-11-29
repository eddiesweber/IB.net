<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentComm
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAWR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(49, 147)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 22)
        Me.cmdClose.TabIndex = 7
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(14, 14)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(148, 22)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.Text = "&Load Defaults"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(14, 98)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(148, 22)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "&Update Commission File"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(14, 56)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(148, 22)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAWR
        '
        Me.cmdAWR.Location = New System.Drawing.Point(35, 189)
        Me.cmdAWR.Name = "cmdAWR"
        Me.cmdAWR.Size = New System.Drawing.Size(148, 22)
        Me.cmdAWR.TabIndex = 8
        Me.cmdAWR.Text = "Update &Avg Weekly Rev"
        Me.cmdAWR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usin&g:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Starting:"
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(7, 175)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(169, 15)
        Me.lblStatus1.TabIndex = 9
        '
        'frmRentComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 213)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAWR)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdClose)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRentComm"
        Me.ShowInTaskbar = False
        Me.Text = "Rental Commissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAWR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus1 As Label
End Class
