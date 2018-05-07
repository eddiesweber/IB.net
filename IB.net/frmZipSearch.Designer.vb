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
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.OPTcITY = New System.Windows.Forms.RadioButton()
        Me.optZip = New System.Windows.Forms.RadioButton()
        Me.lblCityorZip = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(280, 64)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(98, 33)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "PRINT REPORT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.ForeColor = System.Drawing.Color.Navy
        Me.txtZip.Location = New System.Drawing.Point(244, 29)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(169, 20)
        Me.txtZip.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 97)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optZip)
        Me.Frame1.Controls.Add(Me.OPTcITY)
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(201, 77)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "SELECT CITY NAME OR ZIP CODE"
        '
        'OPTcITY
        '
        Me.OPTcITY.AutoSize = True
        Me.OPTcITY.ForeColor = System.Drawing.Color.Black
        Me.OPTcITY.Location = New System.Drawing.Point(16, 48)
        Me.OPTcITY.Name = "OPTcITY"
        Me.OPTcITY.Size = New System.Drawing.Size(49, 17)
        Me.OPTcITY.TabIndex = 2
        Me.OPTcITY.TabStop = True
        Me.OPTcITY.Text = "CITY"
        Me.OPTcITY.UseVisualStyleBackColor = True
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
        'lblCityorZip
        '
        Me.lblCityorZip.AutoSize = True
        Me.lblCityorZip.Location = New System.Drawing.Point(240, 8)
        Me.lblCityorZip.Name = "lblCityorZip"
        Me.lblCityorZip.Size = New System.Drawing.Size(183, 13)
        Me.lblCityorZip.TabIndex = 4
        Me.lblCityorZip.Text = "PLEASE ENTER ZIP CODE BELOW"
        '
        'frmZipSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 97)
        Me.Controls.Add(Me.lblCityorZip)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.cmdPrint)
        Me.Location = New System.Drawing.Point(117, 191)
        Me.Name = "frmZipSearch"
        Me.Text = "CUSTOMER AREA REPORT"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPrint As Button
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents OPTcITY As RadioButton
    Friend WithEvents optZip As RadioButton
    Friend WithEvents lblCityorZip As Label
End Class
