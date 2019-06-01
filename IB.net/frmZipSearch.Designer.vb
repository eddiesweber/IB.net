<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZipSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZipSearch))
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optZip = New System.Windows.Forms.RadioButton()
        Me.optCity = New System.Windows.Forms.RadioButton()
        Me.lblCityorZip = New System.Windows.Forms.Label()
        Me.txtZip = New C1.Win.C1Input.C1TextBox()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.Frame1.SuspendLayout()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 96)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optZip)
        Me.Frame1.Controls.Add(Me.optCity)
        Me.Frame1.Location = New System.Drawing.Point(10, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(201, 77)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "SELECT CITY NAME OR ZIP CODE"
        '
        'optZip
        '
        Me.optZip.AutoSize = True
        Me.optZip.Location = New System.Drawing.Point(16, 24)
        Me.optZip.Name = "optZip"
        Me.optZip.Size = New System.Drawing.Size(75, 17)
        Me.optZip.TabIndex = 1
        Me.optZip.TabStop = True
        Me.optZip.Text = "ZIP CODE"
        Me.optZip.UseVisualStyleBackColor = True
        '
        'optCity
        '
        Me.optCity.AutoSize = True
        Me.optCity.ForeColor = System.Drawing.Color.Black
        Me.optCity.Location = New System.Drawing.Point(16, 48)
        Me.optCity.Name = "optCity"
        Me.optCity.Size = New System.Drawing.Size(49, 17)
        Me.optCity.TabIndex = 2
        Me.optCity.TabStop = True
        Me.optCity.Text = "CITY"
        Me.optCity.UseVisualStyleBackColor = True
        '
        'lblCityorZip
        '
        Me.lblCityorZip.AutoSize = True
        Me.lblCityorZip.Location = New System.Drawing.Point(240, 10)
        Me.lblCityorZip.Name = "lblCityorZip"
        Me.lblCityorZip.Size = New System.Drawing.Size(183, 13)
        Me.lblCityorZip.TabIndex = 4
        Me.lblCityorZip.Text = "PLEASE ENTER ZIP CODE BELOW"
        '
        'txtZip
        '
        Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZip.Location = New System.Drawing.Point(245, 30)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(175, 18)
        Me.txtZip.TabIndex = 7
        Me.txtZip.Tag = Nothing
        Me.txtZip.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtZip.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(284, 59)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(100, 25)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "PRINT REPORT"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmZipSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 96)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblCityorZip)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Splitter1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(120, 190)
        Me.Name = "frmZipSearch"
        Me.Text = "CUSTOMER AREA REPORT"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.txtZip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optCity As RadioButton
    Friend WithEvents optZip As RadioButton
    Friend WithEvents lblCityorZip As Label
    Friend WithEvents txtZip As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
End Class
