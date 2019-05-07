<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindInvoice
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
        Me.components = New System.ComponentModel.Container()
        Me.lstData0 = New System.Windows.Forms.ListBox()
        Me.SpGetInvNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvNum = New IB.net.dsspGetInvNum()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.lstData1 = New System.Windows.Forms.ListBox()
        Me.SpGetInvRouteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvRoute = New IB.net.dsspGetInvRoute()
        Me.lstData2 = New System.Windows.Forms.ListBox()
        Me.SpGetInvCustNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvCustNum = New IB.net.dsspGetInvCustNum()
        Me.lstData3 = New System.Windows.Forms.ListBox()
        Me.SpGetInvCustAlphaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsspGetInvCustAlpha = New IB.net.dsspGetInvCustAlpha()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lbllabel0 = New System.Windows.Forms.Label()
        Me.cmdSelect = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdRefresh = New C1.Win.C1Input.C1Button()
        Me.datDate = New C1.Win.Calendar.C1DateEdit()
        Me.SpGetInvNumTableAdapter = New IB.net.dsspGetInvNumTableAdapters.spGetInvNumTableAdapter()
        Me.SpGetInvRouteTableAdapter = New IB.net.dsspGetInvRouteTableAdapters.spGetInvRouteTableAdapter()
        Me.SpGetInvCustNumTableAdapter = New IB.net.dsspGetInvCustNumTableAdapters.spGetInvCustNumTableAdapter()
        Me.SpGetInvCustAlphaTableAdapter = New IB.net.dsspGetInvCustAlphaTableAdapters.spGetInvCustAlphaTableAdapter()
        CType(Me.SpGetInvNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvRouteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvRoute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvCustNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvCustNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvCustAlphaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsspGetInvCustAlpha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstData0
        '
        Me.lstData0.DataSource = Me.SpGetInvNumBindingSource
        Me.lstData0.DisplayMember = "INV_NUMBER"
        Me.lstData0.FormattingEnabled = True
        Me.lstData0.Location = New System.Drawing.Point(10, 50)
        Me.lstData0.Name = "lstData0"
        Me.lstData0.Size = New System.Drawing.Size(75, 95)
        Me.lstData0.TabIndex = 10
        Me.lstData0.ValueMember = "INV_NUMBER"
        '
        'SpGetInvNumBindingSource
        '
        Me.SpGetInvNumBindingSource.DataMember = "spGetInvNum"
        Me.SpGetInvNumBindingSource.DataSource = Me.DsspGetInvNum
        '
        'DsspGetInvNum
        '
        Me.DsspGetInvNum.DataSetName = "dsspGetInvNum"
        Me.DsspGetInvNum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(160, 11)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(68, 17)
        Me.chkAll.TabIndex = 9
        Me.chkAll.Text = "&All Dates"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'lstData1
        '
        Me.lstData1.DataSource = Me.SpGetInvRouteBindingSource
        Me.lstData1.DisplayMember = "STOP"
        Me.lstData1.FormattingEnabled = True
        Me.lstData1.Location = New System.Drawing.Point(90, 50)
        Me.lstData1.Name = "lstData1"
        Me.lstData1.Size = New System.Drawing.Size(60, 95)
        Me.lstData1.TabIndex = 11
        Me.lstData1.ValueMember = "INV_NUMBER"
        '
        'SpGetInvRouteBindingSource
        '
        Me.SpGetInvRouteBindingSource.DataMember = "spGetInvRoute"
        Me.SpGetInvRouteBindingSource.DataSource = Me.DsspGetInvRoute
        '
        'DsspGetInvRoute
        '
        Me.DsspGetInvRoute.DataSetName = "dsspGetInvRoute"
        Me.DsspGetInvRoute.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstData2
        '
        Me.lstData2.DataSource = Me.SpGetInvCustNumBindingSource
        Me.lstData2.DisplayMember = "CUST_NUM"
        Me.lstData2.FormattingEnabled = True
        Me.lstData2.Location = New System.Drawing.Point(155, 50)
        Me.lstData2.Name = "lstData2"
        Me.lstData2.Size = New System.Drawing.Size(60, 95)
        Me.lstData2.TabIndex = 12
        Me.lstData2.ValueMember = "INV_NUMBER"
        '
        'SpGetInvCustNumBindingSource
        '
        Me.SpGetInvCustNumBindingSource.DataMember = "spGetInvCustNum"
        Me.SpGetInvCustNumBindingSource.DataSource = Me.DsspGetInvCustNum
        '
        'DsspGetInvCustNum
        '
        Me.DsspGetInvCustNum.DataSetName = "dsspGetInvCustNum"
        Me.DsspGetInvCustNum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstData3
        '
        Me.lstData3.DataSource = Me.SpGetInvCustAlphaBindingSource
        Me.lstData3.DisplayMember = "BILL_NAME"
        Me.lstData3.FormattingEnabled = True
        Me.lstData3.Location = New System.Drawing.Point(220, 50)
        Me.lstData3.Name = "lstData3"
        Me.lstData3.Size = New System.Drawing.Size(150, 95)
        Me.lstData3.TabIndex = 13
        Me.lstData3.ValueMember = "INV_NUMBER"
        '
        'SpGetInvCustAlphaBindingSource
        '
        Me.SpGetInvCustAlphaBindingSource.DataMember = "spGetInvCustAlpha"
        Me.SpGetInvCustAlphaBindingSource.DataSource = Me.DsspGetInvCustAlpha
        '
        'DsspGetInvCustAlpha
        '
        Me.DsspGetInvCustAlpha.DataSetName = "dsspGetInvCustAlpha"
        Me.DsspGetInvCustAlpha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(222, 35)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel4.TabIndex = 5
        Me.lblLabel4.Text = "&Name:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(157, 35)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel3.TabIndex = 4
        Me.lblLabel3.Text = "&Customer:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(92, 35)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 3
        Me.lblLabel2.Text = "R&oute:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(12, 35)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel1.TabIndex = 2
        Me.lblLabel1.Text = "&Invoice:"
        '
        'lbllabel0
        '
        Me.lbllabel0.AutoSize = True
        Me.lbllabel0.Location = New System.Drawing.Point(10, 12)
        Me.lbllabel0.Name = "lbllabel0"
        Me.lbllabel0.Size = New System.Drawing.Size(33, 13)
        Me.lbllabel0.TabIndex = 0
        Me.lbllabel0.Text = "&Date:"
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(380, 10)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(85, 25)
        Me.cmdSelect.TabIndex = 82
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        Me.cmdSelect.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(380, 119)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 81
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(380, 41)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(85, 25)
        Me.cmdRefresh.TabIndex = 80
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        Me.cmdRefresh.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdRefresh.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datDate
        '
        Me.datDate.AllowSpinLoop = False
        Me.datDate.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datDate.Location = New System.Drawing.Point(45, 10)
        Me.datDate.Name = "datDate"
        Me.datDate.Size = New System.Drawing.Size(105, 18)
        Me.datDate.TabIndex = 83
        Me.datDate.Tag = Nothing
        '
        'SpGetInvNumTableAdapter
        '
        Me.SpGetInvNumTableAdapter.ClearBeforeFill = True
        '
        'SpGetInvRouteTableAdapter
        '
        Me.SpGetInvRouteTableAdapter.ClearBeforeFill = True
        '
        'SpGetInvCustNumTableAdapter
        '
        Me.SpGetInvCustNumTableAdapter.ClearBeforeFill = True
        '
        'SpGetInvCustAlphaTableAdapter
        '
        Me.SpGetInvCustAlphaTableAdapter.ClearBeforeFill = True
        '
        'frmFindInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 156)
        Me.Controls.Add(Me.datDate)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.lbllabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lstData3)
        Me.Controls.Add(Me.lstData2)
        Me.Controls.Add(Me.lstData1)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.lstData0)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindInvoice"
        Me.ShowInTaskbar = False
        Me.Tag = "spGetInvNum"
        Me.Text = "Find Invoice"
        CType(Me.SpGetInvNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvRouteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvRoute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvCustNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvCustNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvCustAlphaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsspGetInvCustAlpha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData0 As ListBox
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents lstData1 As ListBox
    Friend WithEvents lstData2 As ListBox
    Friend WithEvents lstData3 As ListBox
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lbllabel0 As Label
    Friend WithEvents cmdSelect As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdRefresh As C1.Win.C1Input.C1Button
    Friend WithEvents datDate As C1.Win.Calendar.C1DateEdit
    Friend WithEvents SpGetInvNumBindingSource As BindingSource
    Friend WithEvents DsspGetInvNum As dsspGetInvNum
    Friend WithEvents SpGetInvRouteBindingSource As BindingSource
    Friend WithEvents DsspGetInvRoute As dsspGetInvRoute
    Friend WithEvents SpGetInvCustNumBindingSource As BindingSource
    Friend WithEvents DsspGetInvCustNum As dsspGetInvCustNum
    Friend WithEvents SpGetInvCustAlphaBindingSource As BindingSource
    Friend WithEvents DsspGetInvCustAlpha As dsspGetInvCustAlpha
    Friend WithEvents SpGetInvNumTableAdapter As dsspGetInvNumTableAdapters.spGetInvNumTableAdapter
    Friend WithEvents SpGetInvRouteTableAdapter As dsspGetInvRouteTableAdapters.spGetInvRouteTableAdapter
    Friend WithEvents SpGetInvCustNumTableAdapter As dsspGetInvCustNumTableAdapters.spGetInvCustNumTableAdapter
    Friend WithEvents SpGetInvCustAlphaTableAdapter As dsspGetInvCustAlphaTableAdapters.spGetInvCustAlphaTableAdapter
End Class
