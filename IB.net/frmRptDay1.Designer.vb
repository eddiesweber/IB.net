<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptDay1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptDay1))
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.txtRoute5 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute4 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute3 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute2 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute1 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute0 = New C1.Win.C1Input.C1TextBox()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.chkRpt2 = New System.Windows.Forms.CheckBox()
        Me.chkRpt1 = New System.Windows.Forms.CheckBox()
        Me.chkRpt0 = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.cmdPreview1 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview2 = New C1.Win.C1Input.C1Button()
        Me.cmdPreview0 = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.DsCalcLogOrderbyRunDate = New IB.net.dsCalcLogOrderbyRunDate()
        Me.CalcLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CalcLogTableAdapter = New IB.net.dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter()
        Me.DsCompany_CompanyID = New IB.net.dsCompany_CompanyID()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyTableAdapter = New IB.net.dsCompany_CompanyIDTableAdapters.CompanyTableAdapter()
        Me.TableAdapterManager = New IB.net.dsCompany_CompanyIDTableAdapters.TableAdapterManager()
        Me.fraRoute.SuspendLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.txtRoute5)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute1)
        Me.fraRoute.Controls.Add(Me.txtRoute0)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Location = New System.Drawing.Point(10, 40)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(245, 100)
        Me.fraRoute.TabIndex = 212
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'txtRoute5
        '
        Me.txtRoute5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute5.Location = New System.Drawing.Point(207, 45)
        Me.txtRoute5.Name = "txtRoute5"
        Me.txtRoute5.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute5.TabIndex = 222
        Me.txtRoute5.Tag = Nothing
        Me.txtRoute5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute4
        '
        Me.txtRoute4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute4.Location = New System.Drawing.Point(182, 45)
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute4.TabIndex = 221
        Me.txtRoute4.Tag = Nothing
        Me.txtRoute4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute3
        '
        Me.txtRoute3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute3.Location = New System.Drawing.Point(157, 45)
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute3.TabIndex = 220
        Me.txtRoute3.Tag = Nothing
        Me.txtRoute3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute2
        '
        Me.txtRoute2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute2.Location = New System.Drawing.Point(132, 45)
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute2.TabIndex = 219
        Me.txtRoute2.Tag = Nothing
        Me.txtRoute2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute1
        '
        Me.txtRoute1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute1.Location = New System.Drawing.Point(107, 45)
        Me.txtRoute1.Name = "txtRoute1"
        Me.txtRoute1.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute1.TabIndex = 218
        Me.txtRoute1.Tag = Nothing
        Me.txtRoute1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute0
        '
        Me.txtRoute0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute0.Location = New System.Drawing.Point(115, 70)
        Me.txtRoute0.Name = "txtRoute0"
        Me.txtRoute0.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute0.TabIndex = 215
        Me.txtRoute0.Tag = Nothing
        Me.txtRoute0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(15, 70)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 7
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(15, 45)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 6
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Checked = True
        Me.optRoute0.Location = New System.Drawing.Point(15, 20)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 5
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'chkRpt2
        '
        Me.chkRpt2.AutoSize = True
        Me.chkRpt2.Location = New System.Drawing.Point(25, 217)
        Me.chkRpt2.Name = "chkRpt2"
        Me.chkRpt2.Size = New System.Drawing.Size(85, 17)
        Me.chkRpt2.TabIndex = 4
        Me.chkRpt2.Text = "&Load Report"
        Me.chkRpt2.UseVisualStyleBackColor = True
        '
        'chkRpt1
        '
        Me.chkRpt1.AutoSize = True
        Me.chkRpt1.Location = New System.Drawing.Point(25, 186)
        Me.chkRpt1.Name = "chkRpt1"
        Me.chkRpt1.Size = New System.Drawing.Size(105, 17)
        Me.chkRpt1.TabIndex = 3
        Me.chkRpt1.Text = "Tripsheet &Recap"
        Me.chkRpt1.UseVisualStyleBackColor = True
        '
        'chkRpt0
        '
        Me.chkRpt0.AutoSize = True
        Me.chkRpt0.Location = New System.Drawing.Point(25, 155)
        Me.chkRpt0.Name = "chkRpt0"
        Me.chkRpt0.Size = New System.Drawing.Size(75, 17)
        Me.chkRpt0.TabIndex = 2
        Me.chkRpt0.Text = "&Tripsheets"
        Me.chkRpt0.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(10, 255)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(245, 13)
        Me.lblStatus.TabIndex = 11
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblDate.Location = New System.Drawing.Point(190, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(55, 13)
        Me.lblDate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
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
        Me.datDate.Location = New System.Drawing.Point(50, 10)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 213
        Me.datDate.Tag = Nothing
        Me.datDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview1
        '
        Me.cmdPreview1.Location = New System.Drawing.Point(190, 181)
        Me.cmdPreview1.Name = "cmdPreview1"
        Me.cmdPreview1.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview1.TabIndex = 216
        Me.cmdPreview1.Text = "View"
        Me.cmdPreview1.UseVisualStyleBackColor = True
        Me.cmdPreview1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview2
        '
        Me.cmdPreview2.Location = New System.Drawing.Point(190, 212)
        Me.cmdPreview2.Name = "cmdPreview2"
        Me.cmdPreview2.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview2.TabIndex = 215
        Me.cmdPreview2.Text = "View"
        Me.cmdPreview2.UseVisualStyleBackColor = True
        Me.cmdPreview2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPreview0
        '
        Me.cmdPreview0.Location = New System.Drawing.Point(190, 150)
        Me.cmdPreview0.Name = "cmdPreview0"
        Me.cmdPreview0.Size = New System.Drawing.Size(50, 25)
        Me.cmdPreview0.TabIndex = 214
        Me.cmdPreview0.Text = "View"
        Me.cmdPreview0.UseVisualStyleBackColor = True
        Me.cmdPreview0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPreview0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(46, 280)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 218
        Me.cmdOK.Text = "Print"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(137, 280)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 217
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'DsCalcLogOrderbyRunDate
        '
        Me.DsCalcLogOrderbyRunDate.DataSetName = "dsCalcLogOrderbyRunDate"
        Me.DsCalcLogOrderbyRunDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CalcLogBindingSource
        '
        Me.CalcLogBindingSource.DataMember = "CalcLog"
        Me.CalcLogBindingSource.DataSource = Me.DsCalcLogOrderbyRunDate
        '
        'CalcLogTableAdapter
        '
        Me.CalcLogTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompanyTableAdapter = Me.CompanyTableAdapter
        Me.TableAdapterManager.UpdateOrder = IB.net.dsCompany_CompanyIDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmRptDay1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 316)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdPreview1)
        Me.Controls.Add(Me.cmdPreview2)
        Me.Controls.Add(Me.cmdPreview0)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.chkRpt0)
        Me.Controls.Add(Me.chkRpt1)
        Me.Controls.Add(Me.chkRpt2)
        Me.Controls.Add(Me.fraRoute)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(257, 88)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptDay1"
        Me.ShowInTaskbar = False
        Me.Text = "Tripsheets/Load Reports"
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPreview0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCalcLogOrderbyRunDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_CompanyID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents chkRpt2 As CheckBox
    Friend WithEvents chkRpt1 As CheckBox
    Friend WithEvents chkRpt0 As CheckBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents txtRoute1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdPreview1 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview2 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdPreview0 As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents DsCalcLogOrderbyRunDate As dsCalcLogOrderbyRunDate
    Friend WithEvents CalcLogBindingSource As BindingSource
    Friend WithEvents CalcLogTableAdapter As dsCalcLogOrderbyRunDateTableAdapters.CalcLogTableAdapter
    Friend WithEvents DsCompany_CompanyID As dsCompany_CompanyID
    Friend WithEvents CompanyBindingSource As BindingSource
    Friend WithEvents CompanyTableAdapter As dsCompany_CompanyIDTableAdapters.CompanyTableAdapter
    Friend WithEvents TableAdapterManager As dsCompany_CompanyIDTableAdapters.TableAdapterManager
End Class
