<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmROHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmROHist))
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        Me.cmdFind = New C1.Win.C1Input.C1Button()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.txtCust = New C1.Win.C1Input.C1TextBox()
        Me.datSince = New C1.Win.Calendar.C1DateEdit()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetRentHistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsROHist = New IB.net.dsROHist()
        Me.SpGetRentHistTableAdapter = New IB.net.dsROHistTableAdapters.spGetRentHistTableAdapter()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datSince, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetRentHistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsROHist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.ForeColor = System.Drawing.Color.Navy
        Me.lblCurCust.Location = New System.Drawing.Point(21, 42)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 3
        Me.lblCurCust.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(510, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 24
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(150, 10)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 25)
        Me.cmdFind.TabIndex = 22
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        Me.cmdFind.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFind.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustName.Location = New System.Drawing.Point(15, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(220, 18)
        Me.txtCustName.TabIndex = 21
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCust
        '
        Me.txtCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCust.Location = New System.Drawing.Point(67, 15)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.ReadOnly = True
        Me.txtCust.Size = New System.Drawing.Size(75, 18)
        Me.txtCust.TabIndex = 20
        Me.txtCust.Tag = Nothing
        Me.txtCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'datSince
        '
        Me.datSince.AllowSpinLoop = False
        Me.datSince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.datSince.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.datSince.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datSince.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datSince.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datSince.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.datSince.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datSince.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.datSince.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.datSince.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.datSince.Location = New System.Drawing.Point(300, 15)
        Me.datSince.Name = "datSince"
        Me.datSince.Size = New System.Drawing.Size(121, 18)
        Me.datSince.TabIndex = 19
        Me.datSince.Tag = Nothing
        Me.datSince.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datSince.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(264, 17)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(37, 13)
        Me.lblLabel4.TabIndex = 17
        Me.lblLabel4.Text = "&Since:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(14, 17)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 18
        Me.lblLabel0.Text = "Customer:"
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.DataSource = Me.SpGetRentHistBindingSource
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(10, 65)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.C1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(585, 261)
        Me.C1TrueDBGrid1.TabIndex = 25
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'SpGetRentHistBindingSource
        '
        Me.SpGetRentHistBindingSource.DataMember = "spGetRentHist"
        Me.SpGetRentHistBindingSource.DataSource = Me.DsROHist
        '
        'DsROHist
        '
        Me.DsROHist.DataSetName = "dsROHist"
        Me.DsROHist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetRentHistTableAdapter
        '
        Me.SpGetRentHistTableAdapter.ClearBeforeFill = True
        '
        'frmROHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 338)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtCust)
        Me.Controls.Add(Me.datSince)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblCurCust)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(62, 145)
        Me.Name = "frmROHist"
        Me.Text = "Customer Item History"
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datSince, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetRentHistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsROHist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurCust As Label
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
    Friend WithEvents cmdFind As C1.Win.C1Input.C1Button
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCust As C1.Win.C1Input.C1TextBox
    Friend WithEvents datSince As C1.Win.Calendar.C1DateEdit
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetRentHistBindingSource As BindingSource
    Friend WithEvents DsROHist As dsROHist
    Friend WithEvents SpGetRentHistTableAdapter As dsROHistTableAdapters.spGetRentHistTableAdapter
End Class
