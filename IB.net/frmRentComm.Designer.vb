<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRentComm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRentComm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmdLoad = New C1.Win.C1Input.C1Button()
        Me.datStart = New C1.Win.Calendar.C1DateEdit()
        Me.datComm = New C1.Win.Calendar.C1DateEdit()
        Me.DsCompany_CompanyID = New IB.net.dsCompany_CompanyID()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New IB.net.dsCompany_CompanyIDTableAdapters.CompanyTableAdapter()
        Me.cmdEdit = New C1.Win.C1Input.C1Button()
        Me.cmdUpdate = New C1.Win.C1Input.C1Button()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datComm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Usin&g:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Starting:"
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(15, 105)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(169, 15)
        Me.lblStatus.TabIndex = 9
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(15, 15)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(150, 23)
        Me.cmdLoad.TabIndex = 11
        Me.cmdLoad.Text = "&Load Defaults"
        Me.cmdLoad.UseVisualStyleBackColor = True
        Me.cmdLoad.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdLoad.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datStart
        '
        Me.datStart.AllowSpinLoop = False
        Me.datStart.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datStart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datStart.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datStart.Location = New System.Drawing.Point(227, 17)
        Me.datStart.Name = "datStart"
        Me.datStart.Size = New System.Drawing.Size(125, 18)
        Me.datStart.TabIndex = 12
        Me.datStart.Tag = Nothing
        '
        'datComm
        '
        Me.datComm.AllowSpinLoop = False
        Me.datComm.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datComm.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datComm.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datComm.Location = New System.Drawing.Point(227, 77)
        Me.datComm.Name = "datComm"
        Me.datComm.Size = New System.Drawing.Size(125, 18)
        Me.datComm.TabIndex = 13
        Me.datComm.Tag = Nothing
        '
        'DsCompany_CompanyID
        '
        Me.DsCompany_CompanyID.DataSetName = "dsCompany_CompanyID"
        Me.DsCompany_CompanyID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "Company"
        Me.CompanyBindingSource.DataSource = Me.DsCompany_CompanyID
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(15, 45)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(150, 23)
        Me.cmdEdit.TabIndex = 14
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        Me.cmdEdit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(15, 75)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(150, 23)
        Me.cmdUpdate.TabIndex = 15
        Me.cmdUpdate.Text = "&Update Commission File"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        Me.cmdUpdate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdUpdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(142, 130)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmRentComm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 166)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.datComm)
        Me.Controls.Add(Me.datStart)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRentComm"
        Me.ShowInTaskbar = False
        Me.Text = "Rental Commissions"
        CType(Me.cmdLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datComm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmdLoad As C1.Win.C1Input.C1Button
    Friend WithEvents datStart As C1.Win.Calendar.C1DateEdit
    Friend WithEvents datComm As C1.Win.Calendar.C1DateEdit
    Friend WithEvents DsCompany_CompanyID As dsCompany_CompanyID
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As dsCompany_CompanyIDTableAdapters.CompanyTableAdapter
    Friend WithEvents cmdEdit As C1.Win.C1Input.C1Button
    Friend WithEvents cmdUpdate As C1.Win.C1Input.C1Button
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
End Class
