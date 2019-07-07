<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptExcept
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptExcept))
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPreview = New C1.Win.C1Input.C1CheckBox()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPreview2 = New C1.Win.C1Input.C1CheckBox()
        Me.Command1 = New C1.Win.C1Input.C1Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chkPreview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Command1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(101, 225)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate
        '
        Me.datDate.AllowSpinLoop = False
        Me.datDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate.Location = New System.Drawing.Point(15, 20)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 0
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPreview)
        Me.GroupBox1.Controls.Add(Me.cmdOK)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'chkPreview
        '
        Me.chkPreview.BackColor = System.Drawing.Color.Transparent
        Me.chkPreview.BorderColor = System.Drawing.Color.Transparent
        Me.chkPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkPreview.ForeColor = System.Drawing.Color.Black
        Me.chkPreview.Location = New System.Drawing.Point(110, 44)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.Padding = New System.Windows.Forms.Padding(1)
        Me.chkPreview.Size = New System.Drawing.Size(104, 24)
        Me.chkPreview.TabIndex = 1
        Me.chkPreview.Text = "Preview"
        Me.chkPreview.UseVisualStyleBackColor = True
        Me.chkPreview.Value = Nothing
        Me.chkPreview.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkPreview.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(15, 45)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Print customers with paper items not ordered since:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPreview2)
        Me.GroupBox2.Controls.Add(Me.Command1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'chkPreview2
        '
        Me.chkPreview2.BackColor = System.Drawing.Color.Transparent
        Me.chkPreview2.BorderColor = System.Drawing.Color.Transparent
        Me.chkPreview2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chkPreview2.ForeColor = System.Drawing.Color.Black
        Me.chkPreview2.Location = New System.Drawing.Point(110, 44)
        Me.chkPreview2.Name = "chkPreview2"
        Me.chkPreview2.Padding = New System.Windows.Forms.Padding(1)
        Me.chkPreview2.Size = New System.Drawing.Size(104, 24)
        Me.chkPreview2.TabIndex = 1
        Me.chkPreview2.Text = "Preview"
        Me.chkPreview2.UseVisualStyleBackColor = True
        Me.chkPreview2.Value = Nothing
        Me.chkPreview2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.chkPreview2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(15, 45)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(85, 23)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Print"
        Me.Command1.UseVisualStyleBackColor = True
        Me.Command1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Command1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Customers with no orders (use calendar for dates)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmRptExcept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(203, 289)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptExcept"
        Me.ShowInTaskbar = False
        Me.Text = "Exception Report"
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.chkPreview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Command1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPreview As C1.Win.C1Input.C1CheckBox
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPreview2 As C1.Win.C1Input.C1CheckBox
    Friend WithEvents Command1 As C1.Win.C1Input.C1Button
    Friend WithEvents Label2 As Label
End Class
