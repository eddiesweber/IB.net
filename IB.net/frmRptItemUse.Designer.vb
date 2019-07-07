<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptItemUse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptItemUse))
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.txtRange0 = New C1.Win.C1Input.C1TextBox()
        Me.txtRange1 = New C1.Win.C1Input.C1TextBox()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRange0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRange1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(35, 55)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(115, 17)
        Me.chkRpt1.TabIndex = 7
        Me.chkRpt1.Text = "Item &Usage Report"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(35, 90)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(111, 17)
        Me.chkRpt2.TabIndex = 6
        Me.chkRpt2.Text = "Inventory &Analysis"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(10, 120)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(250, 15)
        Me.lblStatus1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "through"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Print &Items:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(137, 145)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 85
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(46, 145)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 84
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(185, 50)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 87
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(185, 85)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 86
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRange0
        '
        Me.txtRange0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRange0.DataType = GetType(Integer)
        Me.txtRange0.Location = New System.Drawing.Point(70, 15)
        Me.txtRange0.Name = "txtRange0"
        Me.txtRange0.Size = New System.Drawing.Size(65, 18)
        Me.txtRange0.TabIndex = 88
        Me.txtRange0.Tag = Nothing
        Me.txtRange0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRange0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRange1
        '
        Me.txtRange1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRange1.DataType = GetType(Integer)
        Me.txtRange1.Location = New System.Drawing.Point(190, 15)
        Me.txtRange1.Name = "txtRange1"
        Me.txtRange1.Size = New System.Drawing.Size(65, 18)
        Me.txtRange1.TabIndex = 89
        Me.txtRange1.Tag = Nothing
        Me.txtRange1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRange1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRptItemUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 181)
        Me.Controls.Add(Me.txtRange1)
        Me.Controls.Add(Me.txtRange0)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.chkRpt1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(203, 289)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptItemUse"
        Me.ShowInTaskbar = False
        Me.Text = "Item Usage Reports"
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRange0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRange1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents txtRange0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRange1 As C1.Win.C1Input.C1TextBox
End Class
