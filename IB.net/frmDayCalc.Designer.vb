<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDayCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDayCalc))
        Me.fraRoute = New System.Windows.Forms.GroupBox()
        Me.txtRoute5 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute4 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute3 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute2 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute0 = New C1.Win.C1Input.C1TextBox()
        Me.txtRoute1 = New C1.Win.C1Input.C1TextBox()
        Me.optRoute0 = New System.Windows.Forms.RadioButton()
        Me.optRoute1 = New System.Windows.Forms.RadioButton()
        Me.optRoute2 = New System.Windows.Forms.RadioButton()
        Me.lblStatus1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.DsCompany_LASTCALC = New IB.net.dsCompany_LASTCALC()
        Me.CompanyTableAdapter = New IB.net.dsCompany_LASTCALCTableAdapters.CompanyTableAdapter()
        Me.fraRoute.SuspendLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCompany_LASTCALC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraRoute
        '
        Me.fraRoute.Controls.Add(Me.txtRoute5)
        Me.fraRoute.Controls.Add(Me.txtRoute4)
        Me.fraRoute.Controls.Add(Me.txtRoute3)
        Me.fraRoute.Controls.Add(Me.txtRoute2)
        Me.fraRoute.Controls.Add(Me.txtRoute0)
        Me.fraRoute.Controls.Add(Me.txtRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute0)
        Me.fraRoute.Controls.Add(Me.optRoute1)
        Me.fraRoute.Controls.Add(Me.optRoute2)
        Me.fraRoute.Location = New System.Drawing.Point(10, 70)
        Me.fraRoute.Name = "fraRoute"
        Me.fraRoute.Size = New System.Drawing.Size(253, 92)
        Me.fraRoute.TabIndex = 12
        Me.fraRoute.TabStop = False
        Me.fraRoute.Text = "&Route(s)"
        '
        'txtRoute5
        '
        Me.txtRoute5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute5.Location = New System.Drawing.Point(220, 42)
        Me.txtRoute5.Name = "txtRoute5"
        Me.txtRoute5.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute5.TabIndex = 61
        Me.txtRoute5.Tag = Nothing
        Me.txtRoute5.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute4
        '
        Me.txtRoute4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute4.Location = New System.Drawing.Point(190, 42)
        Me.txtRoute4.Name = "txtRoute4"
        Me.txtRoute4.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute4.TabIndex = 60
        Me.txtRoute4.Tag = Nothing
        Me.txtRoute4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute3
        '
        Me.txtRoute3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute3.Location = New System.Drawing.Point(160, 42)
        Me.txtRoute3.Name = "txtRoute3"
        Me.txtRoute3.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute3.TabIndex = 59
        Me.txtRoute3.Tag = Nothing
        Me.txtRoute3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute2
        '
        Me.txtRoute2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute2.Location = New System.Drawing.Point(130, 42)
        Me.txtRoute2.Name = "txtRoute2"
        Me.txtRoute2.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute2.TabIndex = 58
        Me.txtRoute2.Tag = Nothing
        Me.txtRoute2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute0
        '
        Me.txtRoute0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute0.Location = New System.Drawing.Point(112, 64)
        Me.txtRoute0.Name = "txtRoute0"
        Me.txtRoute0.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute0.TabIndex = 57
        Me.txtRoute0.Tag = Nothing
        Me.txtRoute0.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute0.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtRoute1
        '
        Me.txtRoute1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoute1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoute1.Location = New System.Drawing.Point(100, 42)
        Me.txtRoute1.Name = "txtRoute1"
        Me.txtRoute1.Size = New System.Drawing.Size(22, 18)
        Me.txtRoute1.TabIndex = 56
        Me.txtRoute1.Tag = Nothing
        Me.txtRoute1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtRoute1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'optRoute0
        '
        Me.optRoute0.AutoSize = True
        Me.optRoute0.Location = New System.Drawing.Point(15, 20)
        Me.optRoute0.Name = "optRoute0"
        Me.optRoute0.Size = New System.Drawing.Size(73, 17)
        Me.optRoute0.TabIndex = 3
        Me.optRoute0.TabStop = True
        Me.optRoute0.Text = "All Routes"
        Me.optRoute0.UseVisualStyleBackColor = True
        '
        'optRoute1
        '
        Me.optRoute1.AutoSize = True
        Me.optRoute1.Location = New System.Drawing.Point(15, 42)
        Me.optRoute1.Name = "optRoute1"
        Me.optRoute1.Size = New System.Drawing.Size(86, 17)
        Me.optRoute1.TabIndex = 14
        Me.optRoute1.TabStop = True
        Me.optRoute1.Text = "Only Routes:"
        Me.optRoute1.UseVisualStyleBackColor = True
        '
        'optRoute2
        '
        Me.optRoute2.AutoSize = True
        Me.optRoute2.Location = New System.Drawing.Point(15, 64)
        Me.optRoute2.Name = "optRoute2"
        Me.optRoute2.Size = New System.Drawing.Size(98, 17)
        Me.optRoute2.TabIndex = 10
        Me.optRoute2.TabStop = True
        Me.optRoute2.Text = "Exclude Route:"
        Me.optRoute2.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.AutoSize = True
        Me.lblStatus1.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus1.Location = New System.Drawing.Point(15, 195)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(46, 13)
        Me.lblStatus1.TabIndex = 16
        Me.lblStatus1.Text = "Status 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Date:"
        '
        'lblStatus0
        '
        Me.lblStatus0.AutoSize = True
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(15, 175)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(46, 13)
        Me.lblStatus0.TabIndex = 15
        Me.lblStatus0.Text = "Status 0"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.ForeColor = System.Drawing.Color.Maroon
        Me.lblLast.Location = New System.Drawing.Point(15, 10)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(37, 13)
        Me.lblLast.TabIndex = 14
        Me.lblLast.Text = "lblLast"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(10, 220)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 46
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(180, 220)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 47
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
        Me.datDate.Location = New System.Drawing.Point(50, 35)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(125, 18)
        Me.datDate.TabIndex = 48
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
        'frmDayCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 256)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.fraRoute)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(58, 140)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDayCalc"
        Me.ShowInTaskbar = False
        Me.Text = "Calculate Invoices"
        Me.fraRoute.ResumeLayout(False)
        Me.fraRoute.PerformLayout()
        CType(Me.txtRoute5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoute1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCompany_LASTCALC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fraRoute As GroupBox
    Friend WithEvents optRoute0 As RadioButton
    Friend WithEvents optRoute1 As RadioButton
    Friend WithEvents optRoute2 As RadioButton
    Friend WithEvents lblStatus1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus0 As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents txtRoute5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute0 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRoute1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents DsCompany_LASTCALC As dsCompany_LASTCALC
    Friend WithEvents CompanyTableAdapter As dsCompany_LASTCALCTableAdapters.CompanyTableAdapter
End Class
