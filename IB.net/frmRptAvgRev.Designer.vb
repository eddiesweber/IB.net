<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAvgRev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptAvgRev))
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview2 = New C1.Win.C1Input.C1Button()
        Me.DsCompany_CompanyID = New IB.net.dsCompany_CompanyID()
        Me.CompanyTableAdapter = New IB.net.dsCompany_CompanyIDTableAdapters.CompanyTableAdapter()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(15, 85)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(98, 17)
        Me.chkRpt2.TabIndex = 1
        Me.chkRpt2.Text = "&Change Report"
        Me.chkRpt2.UseVisualStyleBackColor = True
        Me.chkRpt2.Visible = False
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(15, 50)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(118, 17)
        Me.chkRpt1.TabIndex = 0
        Me.chkRpt1.Text = "&Top 100 Customers"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'lblStatus0
        '
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(10, 15)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(190, 15)
        Me.lblStatus0.TabIndex = 2
        '
        'lblStatus1
        '
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(10, 115)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(190, 15)
        Me.lblStatus1.TabIndex = 3
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(18, 140)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 23)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(109, 140)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(150, 45)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 79
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview2
        '
        Me.cmdPreview2.Location = New System.Drawing.Point(150, 80)
        Me.cmdPreview2.Name = "cmdPreview2"
        Me.cmdPreview2.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview2.TabIndex = 80
        Me.cmdPreview2.Text = "View"
        Me.cmdPreview2.UseVisualStyleBackColor = True
        Me.cmdPreview2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'DsCompany_CompanyID
        '
        Me.DsCompany_CompanyID.DataSetName = "dsCompany_CompanyID"
        Me.DsCompany_CompanyID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'frmRptAvgRev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 176)
        Me.Controls.Add(Me.cmdPreview2)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptAvgRev"
        Me.ShowInTaskbar = False
        Me.Text = "Average Revenue Reports"
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview2 As C1.Win.C1Input.C1Button
    Friend WithEvents DsCompany_CompanyID As dsCompany_CompanyID
    Friend WithEvents CompanyTableAdapter As dsCompany_CompanyIDTableAdapters.CompanyTableAdapter
End Class
