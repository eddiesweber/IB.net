<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvPhys
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
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optSort2 = New System.Windows.Forms.RadioButton()
        Me.optSort1 = New System.Windows.Forms.RadioButton()
        Me.optSort0 = New System.Windows.Forms.RadioButton()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(648, 216)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(71, 22)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optSort0)
        Me.Frame1.Controls.Add(Me.optSort1)
        Me.Frame1.Controls.Add(Me.optSort2)
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(337, 41)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "&Sort By:"
        '
        'optSort2
        '
        Me.optSort2.AutoSize = True
        Me.optSort2.Location = New System.Drawing.Point(240, 16)
        Me.optSort2.Name = "optSort2"
        Me.optSort2.Size = New System.Drawing.Size(59, 17)
        Me.optSort2.TabIndex = 3
        Me.optSort2.TabStop = True
        Me.optSort2.Text = "&Vendor"
        Me.optSort2.UseVisualStyleBackColor = True
        '
        'optSort1
        '
        Me.optSort1.AutoSize = True
        Me.optSort1.Location = New System.Drawing.Point(144, 16)
        Me.optSort1.Name = "optSort1"
        Me.optSort1.Size = New System.Drawing.Size(78, 17)
        Me.optSort1.TabIndex = 2
        Me.optSort1.TabStop = True
        Me.optSort1.Text = "&Description"
        Me.optSort1.UseVisualStyleBackColor = True
        '
        'optSort0
        '
        Me.optSort0.AutoSize = True
        Me.optSort0.Location = New System.Drawing.Point(64, 16)
        Me.optSort0.Name = "optSort0"
        Me.optSort0.Size = New System.Drawing.Size(71, 17)
        Me.optSort0.TabIndex = 1
        Me.optSort0.TabStop = True
        Me.optSort0.Text = "&IB Item #:"
        Me.optSort0.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(648, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 6
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(648, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(648, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 5
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(432, 32)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(121, 17)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(432, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(392, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "As of:"
        '
        'frmInvPhys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 520)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdPrint)
        Me.Location = New System.Drawing.Point(87, 78)
        Me.Name = "frmInvPhys"
        Me.Text = "Physical Inventory Adjustment"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPrint As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optSort2 As RadioButton
    Friend WithEvents optSort1 As RadioButton
    Friend WithEvents optSort0 As RadioButton
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
End Class
