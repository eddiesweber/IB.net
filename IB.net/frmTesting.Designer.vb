<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTesting
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
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTesting))
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.grpTestingOptions = New System.Windows.Forms.GroupBox()
        Me.drpTestingHeaderStatus = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.optFinished = New System.Windows.Forms.RadioButton()
        Me.optUntested = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.grpTestingOptions.SuspendLayout()
        CType(Me.drpTestingHeaderStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTestingOptions
        '
        Me.grpTestingOptions.Controls.Add(Me.drpTestingHeaderStatus)
        Me.grpTestingOptions.Controls.Add(Me.optFinished)
        Me.grpTestingOptions.Controls.Add(Me.optUntested)
        Me.grpTestingOptions.Controls.Add(Me.optAll)
        Me.grpTestingOptions.Location = New System.Drawing.Point(15, 15)
        Me.grpTestingOptions.Name = "grpTestingOptions"
        Me.grpTestingOptions.Size = New System.Drawing.Size(735, 50)
        Me.grpTestingOptions.TabIndex = 2
        Me.grpTestingOptions.TabStop = False
        Me.grpTestingOptions.Text = "Filter "
        '
        'drpTestingHeaderStatus
        '
        Me.drpTestingHeaderStatus.AllowColMove = True
        Me.drpTestingHeaderStatus.AllowColSelect = True
        Me.drpTestingHeaderStatus.AllowDrop = True
        Me.drpTestingHeaderStatus.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.drpTestingHeaderStatus.AlternatingRows = False
        Me.drpTestingHeaderStatus.CaptionHeight = 0
        Me.drpTestingHeaderStatus.CaptionStyle = Style1
        Me.drpTestingHeaderStatus.ColumnCaptionHeight = 17
        Me.drpTestingHeaderStatus.ColumnFooterHeight = 17
        Me.drpTestingHeaderStatus.ColumnSelectorStyle = Style2
        Me.drpTestingHeaderStatus.EvenRowStyle = Style3
        Me.drpTestingHeaderStatus.FetchRowStyles = False
        Me.drpTestingHeaderStatus.FooterStyle = Style4
        Me.drpTestingHeaderStatus.HeadingStyle = Style5
        Me.drpTestingHeaderStatus.HighLightRowStyle = Style6
        Me.drpTestingHeaderStatus.Images.Add(CType(resources.GetObject("drpTestingHeaderStatus.Images"), System.Drawing.Image))
        Me.drpTestingHeaderStatus.Location = New System.Drawing.Point(629, 10)
        Me.drpTestingHeaderStatus.Name = "drpTestingHeaderStatus"
        Me.drpTestingHeaderStatus.OddRowStyle = Style7
        Me.drpTestingHeaderStatus.RecordSelectorStyle = Style8
        Me.drpTestingHeaderStatus.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.drpTestingHeaderStatus.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.drpTestingHeaderStatus.RowSelectorStyle = Style9
        Me.drpTestingHeaderStatus.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.drpTestingHeaderStatus.ScrollTips = False
        Me.drpTestingHeaderStatus.Size = New System.Drawing.Size(100, 34)
        Me.drpTestingHeaderStatus.Style = Style10
        Me.drpTestingHeaderStatus.TabIndex = 3
        Me.drpTestingHeaderStatus.UseCompatibleTextRendering = False
        Me.drpTestingHeaderStatus.Visible = False
        Me.drpTestingHeaderStatus.PropBag = resources.GetString("drpTestingHeaderStatus.PropBag")
        '
        'optFinished
        '
        Me.optFinished.AutoSize = True
        Me.optFinished.Location = New System.Drawing.Point(207, 19)
        Me.optFinished.Name = "optFinished"
        Me.optFinished.Size = New System.Drawing.Size(68, 17)
        Me.optFinished.TabIndex = 2
        Me.optFinished.Text = "Untested"
        Me.optFinished.UseVisualStyleBackColor = True
        '
        'optUntested
        '
        Me.optUntested.AutoSize = True
        Me.optUntested.Checked = True
        Me.optUntested.Location = New System.Drawing.Point(117, 19)
        Me.optUntested.Name = "optUntested"
        Me.optUntested.Size = New System.Drawing.Size(68, 17)
        Me.optUntested.TabIndex = 1
        Me.optUntested.TabStop = True
        Me.optUntested.Text = "Untested"
        Me.optUntested.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(24, 19)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(62, 17)
        Me.optAll.TabIndex = 0
        Me.optAll.Text = "All Form"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'frmTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 450)
        Me.Controls.Add(Me.grpTestingOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTesting"
        Me.Text = "IB.net Testing"
        Me.grpTestingOptions.ResumeLayout(False)
        Me.grpTestingOptions.PerformLayout()
        CType(Me.drpTestingHeaderStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTestingOptions As GroupBox
    Friend WithEvents drpTestingHeaderStatus As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents optFinished As RadioButton
    Friend WithEvents optUntested As RadioButton
    Friend WithEvents optAll As RadioButton
End Class
