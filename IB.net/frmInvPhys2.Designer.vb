<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvPhys2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvPhys2))
        Me.Option11 = New System.Windows.Forms.RadioButton()
        Me.Option10 = New System.Windows.Forms.RadioButton()
        Me.txtDate = New C1.Win.C1Input.C1TextBox()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.OKButton = New C1.Win.C1Input.C1Button()
        Me.CancelButton = New C1.Win.C1Input.C1Button()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OKButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Option11
        '
        Me.Option11.AutoSize = True
        Me.Option11.Location = New System.Drawing.Point(10, 45)
        Me.Option11.Name = "Option11"
        Me.Option11.Size = New System.Drawing.Size(148, 17)
        Me.Option11.TabIndex = 1
        Me.Option11.TabStop = True
        Me.Option11.Text = "Start new worksheet as of"
        Me.Option11.UseVisualStyleBackColor = True
        '
        'Option10
        '
        Me.Option10.AutoSize = True
        Me.Option10.Location = New System.Drawing.Point(10, 15)
        Me.Option10.Name = "Option10"
        Me.Option10.Size = New System.Drawing.Size(190, 17)
        Me.Option10.TabIndex = 0
        Me.Option10.TabStop = True
        Me.Option10.Text = "Continue working with counts as of"
        Me.Option10.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDate.Location = New System.Drawing.Point(205, 15)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(80, 18)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Tag = Nothing
        Me.txtDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate
        '
        Me.datDate.AllowSpinLoop = False
        Me.datDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.datDate.Location = New System.Drawing.Point(160, 45)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 7
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(300, 12)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(85, 23)
        Me.OKButton.TabIndex = 11
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        Me.OKButton.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.OKButton.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(300, 42)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(85, 23)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        Me.CancelButton.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.CancelButton.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmInvPhys2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 76)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Option10)
        Me.Controls.Add(Me.Option11)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvPhys2"
        Me.ShowInTaskbar = False
        Me.Text = "Physical Inventory Date"
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OKButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Option11 As RadioButton
    Friend WithEvents Option10 As RadioButton
    Friend WithEvents txtDate As C1.Win.C1Input.C1TextBox
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents OKButton As C1.Win.C1Input.C1Button
    Friend WithEvents CancelButton As C1.Win.C1Input.C1Button
End Class
