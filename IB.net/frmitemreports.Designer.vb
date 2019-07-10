<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmitemreports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmitemreports))
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.optAlpha = New System.Windows.Forms.RadioButton()
        Me.optNumeric = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdPrint = New C1.Win.C1Input.C1Button()
        Me.Frame1.SuspendLayout()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.optAlpha)
        Me.Frame1.Controls.Add(Me.optNumeric)
        Me.Frame1.Location = New System.Drawing.Point(10, 50)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(227, 75)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "SELECT SORT"
        '
        'optAlpha
        '
        Me.optAlpha.AutoSize = True
        Me.optAlpha.Location = New System.Drawing.Point(15, 20)
        Me.optAlpha.Name = "optAlpha"
        Me.optAlpha.Size = New System.Drawing.Size(124, 17)
        Me.optAlpha.TabIndex = 3
        Me.optAlpha.Text = "Sorted Alphabetically"
        Me.optAlpha.UseVisualStyleBackColor = True
        '
        'optNumeric
        '
        Me.optNumeric.AutoSize = True
        Me.optNumeric.Checked = True
        Me.optNumeric.Location = New System.Drawing.Point(15, 40)
        Me.optNumeric.Name = "optNumeric"
        Me.optNumeric.Size = New System.Drawing.Size(113, 17)
        Me.optNumeric.TabIndex = 4
        Me.optNumeric.TabStop = True
        Me.optNumeric.Text = "Sorted Numerically"
        Me.optNumeric.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This is a report of all items currenty in Inventory"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(49, 135)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(150, 23)
        Me.cmdPrint.TabIndex = 85
        Me.cmdPrint.Text = "Print Item Master Report"
        Me.cmdPrint.UseVisualStyleBackColor = True
        Me.cmdPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmitemreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 171)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Frame1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(170, 148)
        Me.Name = "frmitemreports"
        Me.Text = "ITEM REPORTS"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cmdPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents optNumeric As RadioButton
    Friend WithEvents optAlpha As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPrint As C1.Win.C1Input.C1Button
End Class
