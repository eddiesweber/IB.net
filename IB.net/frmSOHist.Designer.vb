<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSOHist))
        Me.lblCurCust = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.datSince = New C1.Win.Calendar.C1DateEdit()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.SpGetInvoiceHistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSOHist = New IB.net.dsSOHist()
        Me.SpGetInvoiceHistTableAdapter = New IB.net.dsSOHistTableAdapters.spGetInvoiceHistTableAdapter()
        Me.txtCust = New C1.Win.C1Input.C1TextBox()
        Me.txtCustName = New C1.Win.C1Input.C1TextBox()
        Me.cmdFind = New C1.Win.C1Input.C1Button()
        Me.CmdPrint = New C1.Win.C1Input.C1Button()
        Me.cmdClose = New C1.Win.C1Input.C1Button()
        CType(Me.datSince, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetInvoiceHistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSOHist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurCust
        '
        Me.lblCurCust.AutoSize = True
        Me.lblCurCust.Location = New System.Drawing.Point(0, 0)
        Me.lblCurCust.Name = "lblCurCust"
        Me.lblCurCust.Size = New System.Drawing.Size(0, 13)
        Me.lblCurCust.TabIndex = 5
        Me.lblCurCust.Visible = False
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(14, 17)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel0.TabIndex = 4
        Me.lblLabel0.Text = "Customer:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(264, 17)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(37, 13)
        Me.lblLabel4.TabIndex = 1
        Me.lblLabel4.Text = "&Since:"
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
        Me.datSince.TabIndex = 10
        Me.datSince.Tag = Nothing
        Me.datSince.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.datSince.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.DataSource = Me.SpGetInvoiceHistBindingSource
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 71)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(604, 285)
        Me.C1TrueDBGrid1.TabIndex = 11
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.C1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        '
        'SpGetInvoiceHistBindingSource
        '
        Me.SpGetInvoiceHistBindingSource.DataMember = "spGetInvoiceHist"
        Me.SpGetInvoiceHistBindingSource.DataSource = Me.DsSOHist
        '
        'DsSOHist
        '
        Me.DsSOHist.DataSetName = "dsSOHist"
        Me.DsSOHist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetInvoiceHistTableAdapter
        '
        Me.SpGetInvoiceHistTableAdapter.ClearBeforeFill = True
        '
        'txtCust
        '
        Me.txtCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCust.Location = New System.Drawing.Point(67, 15)
        Me.txtCust.Name = "txtCust"
        Me.txtCust.Size = New System.Drawing.Size(75, 18)
        Me.txtCust.TabIndex = 12
        Me.txtCust.Tag = Nothing
        Me.txtCust.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCust.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCustName
        '
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustName.Location = New System.Drawing.Point(15, 40)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(220, 18)
        Me.txtCustName.TabIndex = 13
        Me.txtCustName.Tag = Nothing
        Me.txtCustName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCustName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(150, 10)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(85, 25)
        Me.cmdFind.TabIndex = 14
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        Me.cmdFind.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFind.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'CmdPrint
        '
        Me.CmdPrint.Location = New System.Drawing.Point(300, 40)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(85, 25)
        Me.CmdPrint.TabIndex = 15
        Me.CmdPrint.Text = "Print"
        Me.CmdPrint.UseVisualStyleBackColor = True
        Me.CmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.CmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(510, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(85, 25)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        Me.cmdClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmSOHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 356)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.txtCust)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.datSince)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblCurCust)
        Me.Location = New System.Drawing.Point(53, 233)
        Me.Name = "frmSOHist"
        Me.Text = "Customer Sales History"
        CType(Me.datSince, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetInvoiceHistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSOHist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurCust As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents datSince As C1.Win.Calendar.C1DateEdit
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents SpGetInvoiceHistBindingSource As BindingSource
    Friend WithEvents DsSOHist As dsSOHist
    Friend WithEvents SpGetInvoiceHistTableAdapter As dsSOHistTableAdapters.spGetInvoiceHistTableAdapter
    Friend WithEvents txtCust As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCustName As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdFind As C1.Win.C1Input.C1Button
    Friend WithEvents CmdPrint As C1.Win.C1Input.C1Button
    Friend WithEvents cmdClose As C1.Win.C1Input.C1Button
End Class
