<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoute
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
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(30, 119)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(148, 22)
        Me.cmdChange.TabIndex = 6
        Me.cmdChange.Text = "Print &Change Report"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(59, 188)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 22)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(30, 84)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(148, 22)
        Me.cmdPrint.TabIndex = 3
        Me.cmdPrint.Text = "&Print Route Lists"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(30, 154)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(148, 22)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "&Updste Permanent File"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(30, 49)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(148, 22)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "&Edit Routes"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(30, 14)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(148, 22)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.Text = "&Load Work File"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(7, 224)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(169, 15)
        Me.lblStatus.TabIndex = 5
        '
        'frmRoute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 241)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdChange)
        Me.Location = New System.Drawing.Point(14, 119)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoute"
        Me.ShowInTaskbar = False
        Me.Text = "Routing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdChange As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdLoad As Button
    Friend WithEvents lblStatus As Label
End Class
