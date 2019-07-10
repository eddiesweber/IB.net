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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoute))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdLoad = New C1.Win.C1Input.C1Button()
        Me.cmdEdit = New C1.Win.C1Input.C1Button()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.cmdChange = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(10, 170)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(169, 15)
        Me.lblStatus.TabIndex = 5
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(17, 15)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(150, 23)
        Me.cmdLoad.TabIndex = 85
        Me.cmdLoad.Text = "&Load Work File"
        Me.cmdLoad.UseVisualStyleBackColor = True
        Me.cmdLoad.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdLoad.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(17, 45)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(150, 23)
        Me.cmdEdit.TabIndex = 86
        Me.cmdEdit.Text = "&Edit Routes"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(17, 75)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(150, 23)
        Me.cmdPrint.TabIndex = 87
        Me.cmdPrint.Text = "&Print Route Lists"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(17, 105)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(150, 23)
        Me.cmdChange.TabIndex = 88
        Me.cmdChange.Text = "Print &Change Report"
        Me.cmdChange.UseVisualStyleBackColor = True
        Me.cmdChange.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdChange.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(17, 135)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(150, 23)
        Me.cmdUpdate.TabIndex = 89
        Me.cmdUpdate.Text = "&Updste Permanent File"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(50, 200)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 23)
        Me.cmdClose.TabIndex = 90
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRoute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 236)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.lblStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(14, 119)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoute"
        Me.ShowInTaskbar = False
        Me.Text = "Routing"
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmdLoad As C1.Win.C1Input.C1Button
    Friend WithEvents cmdEdit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
    Friend WithEvents cmdChange As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
End Class
