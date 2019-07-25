<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRouteRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRouteRpt))
        Me.txtSummary = New System.Windows.Forms.CheckBox()
        Me.fraSort = New System.Windows.Forms.GroupBox()
        Me.optSort1 = New System.Windows.Forms.RadioButton()
        Me.optSort0 = New System.Windows.Forms.RadioButton()
        Me.chkPreview = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtRoute = New C1.Win.C1Input.C1TextBox()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.fraSort.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.txtRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSummary
        '
        Me.txtSummary.AutoSize = True
        Me.txtSummary.Location = New System.Drawing.Point(175, 105)
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Size = New System.Drawing.Size(93, 17)
        Me.txtSummary.TabIndex = 10
        Me.txtSummary.Text = "Summary Only"
        Me.txtSummary.UseVisualStyleBackColor = True
        '
        'fraSort
        '
        Me.fraSort.Controls.Add(Me.optSort1)
        Me.fraSort.Controls.Add(Me.optSort0)
        Me.fraSort.Location = New System.Drawing.Point(160, 15)
        Me.fraSort.Name = "fraSort"
        Me.fraSort.Size = New System.Drawing.Size(120, 78)
        Me.fraSort.TabIndex = 4
        Me.fraSort.TabStop = False
        Me.fraSort.Text = "&Sort by:"
        '
        'optSort1
        '
        Me.optSort1.AutoSize = True
        Me.optSort1.Location = New System.Drawing.Point(15, 45)
        Me.optSort1.Name = "optSort1"
        Me.optSort1.Size = New System.Drawing.Size(88, 17)
        Me.optSort1.TabIndex = 6
        Me.optSort1.Text = "Route/&Week"
        Me.optSort1.UseVisualStyleBackColor = True
        '
        'optSort0
        '
        Me.optSort0.AutoSize = True
        Me.optSort0.Checked = True
        Me.optSort0.Location = New System.Drawing.Point(15, 20)
        Me.optSort0.Name = "optSort0"
        Me.optSort0.Size = New System.Drawing.Size(78, 17)
        Me.optSort0.TabIndex = 5
        Me.optSort0.TabStop = True
        Me.optSort0.Text = "Route/&Day"
        Me.optSort0.UseVisualStyleBackColor = True
        '
        'chkPreview
        '
        Me.chkPreview.AutoSize = True
        Me.chkPreview.Location = New System.Drawing.Point(25, 105)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.Size = New System.Drawing.Size(64, 17)
        Me.chkPreview.TabIndex = 7
        Me.chkPreview.Text = "&Preview"
        Me.chkPreview.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.txtRoute)
        Me.Frame1.Controls.Add(Me.optRoute0)
        Me.Frame1.Controls.Add(Me.optRoute1)
        Me.Frame1.Location = New System.Drawing.Point(10, 15)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(141, 78)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Select &Route(s) :"
        '
        'txtRoute
        '
        Me.txtRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute.Location = New System.Drawing.Point(99, 45)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(25, 18)
        Me.txtRoute.TabIndex = 95
        Me.txtRoute.Tag = Nothing
        Me.txtRoute.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Checked = True
        Me.optRoute0.Location = New System.Drawing.Point(15, 20)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(97, 17)
        Me.optRoute0.TabIndex = 1
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "Print &All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(15, 45)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(78, 17)
        Me.optRoute1.TabIndex = 2
        Me.optRoute1.Text = "&Only Route"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(147, 135)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 92
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(56, 135)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 93
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRouteRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 171)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.chkPreview)
        Me.Controls.Add(Me.fraSort)
        Me.Controls.Add(Me.txtSummary)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(159, 121)
        Me.Name = "frmRouteRpt"
        Me.Text = "Route List"
        Me.fraSort.ResumeLayout(False)
        Me.fraSort.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.txtRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSummary As CheckBox
    Friend WithEvents fraSort As GroupBox
    Friend WithEvents optSort0 As RadioButton
    Friend WithEvents optSort1 As RadioButton
    Friend WithEvents chkPreview As CheckBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents txtRoute As C1.Win.C1Input.C1TextBox
End Class
