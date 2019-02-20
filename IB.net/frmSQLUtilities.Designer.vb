<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLUtilities
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
        Me.cmdBackupTransactionLogs = New C1.Win.C1Input.C1Button()
        Me.C1Button2 = New C1.Win.C1Input.C1Button()
        CType(Me.cmdBackupTransactionLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBackupTransactionLogs
        '
        Me.cmdBackupTransactionLogs.Location = New System.Drawing.Point(220, 69)
        Me.cmdBackupTransactionLogs.Name = "cmdBackupTransactionLogs"
        Me.cmdBackupTransactionLogs.Size = New System.Drawing.Size(175, 23)
        Me.cmdBackupTransactionLogs.TabIndex = 0
        Me.cmdBackupTransactionLogs.Text = "Backup Transaction Logs"
        Me.cmdBackupTransactionLogs.UseVisualStyleBackColor = True
        Me.cmdBackupTransactionLogs.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdBackupTransactionLogs.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button2
        '
        Me.C1Button2.Location = New System.Drawing.Point(220, 109)
        Me.C1Button2.Name = "C1Button2"
        Me.C1Button2.Size = New System.Drawing.Size(75, 23)
        Me.C1Button2.TabIndex = 1
        Me.C1Button2.Text = "C1Button2"
        Me.C1Button2.UseVisualStyleBackColor = True
        '
        'frmSQLUtilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1Button2)
        Me.Controls.Add(Me.cmdBackupTransactionLogs)
        Me.Name = "frmSQLUtilities"
        Me.Text = "frmSQLUtilities"
        CType(Me.cmdBackupTransactionLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBackupTransactionLogs As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button2 As C1.Win.C1Input.C1Button
End Class
