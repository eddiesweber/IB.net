<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsalestaxreports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsalestaxreports))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFullReport = New C1.Win.C1Input.C1Button()
        Me.C1MainMenu1 = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.mnuMain = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        CType(Me.cmdFullReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(49, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports cover sales from LAST MONTH ONLY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdFullReport
        '
        Me.cmdFullReport.Location = New System.Drawing.Point(100, 75)
        Me.cmdFullReport.Name = "cmdFullReport"
        Me.cmdFullReport.Size = New System.Drawing.Size(85, 23)
        Me.cmdFullReport.TabIndex = 9
        Me.cmdFullReport.Text = "Full Report"
        Me.cmdFullReport.UseVisualStyleBackColor = True
        Me.cmdFullReport.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdFullReport.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1MainMenu1
        '
        Me.C1MainMenu1.AccessibleName = "Menu Bar"
        Me.C1MainMenu1.CommandHolder = Me.C1CommandHolder1
        Me.C1MainMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1})
        Me.C1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.C1MainMenu1.Name = "C1MainMenu1"
        Me.C1MainMenu1.Size = New System.Drawing.Size(284, 21)
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.mnuMain)
        Me.C1CommandHolder1.Commands.Add(Me.cmdExit)
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.mnuMain
        '
        'mnuMain
        '
        Me.mnuMain.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2})
        Me.mnuMain.HideNonRecentLinks = False
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.ShortcutText = ""
        Me.mnuMain.Text = "&File"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.cmdExit
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.ShortcutText = ""
        Me.cmdExit.Text = "E&xit"
        '
        'frmsalestaxreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.cmdFullReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1MainMenu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(149, 151)
        Me.Name = "frmsalestaxreports"
        Me.Text = "Sales Tax Reports"
        CType(Me.cmdFullReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdFullReport As C1.Win.C1Input.C1Button
    Friend WithEvents C1MainMenu1 As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents mnuMain As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
End Class
