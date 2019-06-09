<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUndo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUndo))
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.DsCompany_LASTCALC = New IB.net.dsCompany_LASTCALC()
        Me.CompanyTableAdapter = New IB.net.dsCompany_LASTCALCTableAdapters.CompanyTableAdapter()
        Me.DsCalcLog_RunDate = New IB.net.dsCalcLog_RunDate()
        Me.CalcLogTableAdapter = New IB.net.dsCalcLog_RunDateTableAdapters.CalcLogTableAdapter()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_LASTCALC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCalcLog_RunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus0
        '
        Me.lblStatus0.AutoSize = True
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(15, 40)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus0.TabIndex = 6
        Me.lblStatus0.Text = "lblStatus0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Invoice &Date:"
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(15, 55)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(53, 13)
        Me.lblStatus1.TabIndex = 0
        Me.lblStatus1.Text = "lblStatus1"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(255, 80)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 49
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(18, 80)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 48
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.datDate.Location = New System.Drawing.Point(90, 15)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 50
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'DsCompany_LASTCALC
        '
        Me.DsCompany_LASTCALC.DataSetName = "dsCompany_LASTCALC"
        Me.DsCompany_LASTCALC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'DsCalcLog_RunDate
        '
        Me.DsCalcLog_RunDate.DataSetName = "dsCalcLog_RunDate"
        Me.DsCalcLog_RunDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalcLogTableAdapter
        '
        Me.CalcLogTableAdapter.ClearBeforeFill = True
        '
        'frmUndo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 116)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(104, 103)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUndo"
        Me.ShowInTaskbar = False
        Me.Text = "Undo Calculation"
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_LASTCALC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCalcLog_RunDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents DsCompany_LASTCALC As dsCompany_LASTCALC
    Friend WithEvents CompanyTableAdapter As dsCompany_LASTCALCTableAdapters.CompanyTableAdapter
    Friend WithEvents DsCalcLog_RunDate As dsCalcLog_RunDate
    Friend WithEvents CalcLogTableAdapter As dsCalcLog_RunDateTableAdapters.CalcLogTableAdapter
End Class
