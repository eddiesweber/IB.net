<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.C1MainMenu1 = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.mnuFile = New C1.Win.C1Command.C1CommandMenu()
        Me.clSelectDivision = New C1.Win.C1Command.C1CommandLink()
        Me.cmdSelectDivision = New C1.Win.C1Command.C1Command()
        Me.clPrintSetup = New C1.Win.C1Command.C1CommandLink()
        Me.cmdPrintSetup = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.mnuMiscSetup = New C1.Win.C1Command.C1CommandMenu()
        Me.clTaxCode = New C1.Win.C1Command.C1CommandLink()
        Me.cmdTaxCode = New C1.Win.C1Command.C1Command()
        Me.clCategories = New C1.Win.C1Command.C1CommandLink()
        Me.cmdCategories = New C1.Win.C1Command.C1Command()
        Me.clRouteMaster = New C1.Win.C1Command.C1CommandLink()
        Me.cmdRouteMaster = New C1.Win.C1Command.C1Command()
        Me.clPurge = New C1.Win.C1Command.C1CommandLink()
        Me.cmdPurge = New C1.Win.C1Command.C1Command()
        Me.clExit = New C1.Win.C1Command.C1CommandLink()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.C1Command1 = New C1.Win.C1Command.C1Command()
        Me.mnuCustomer = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdFindCustomer = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdViewCustomer = New C1.Win.C1Command.C1Command()
        Me.cmdAreaSearch = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.cmdGeneralSearch = New C1.Win.C1Command.C1Command()
        Me.mnuDaily = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1MainMenu1
        '
        Me.C1MainMenu1.AccessibleName = "Menu Bar"
        Me.C1MainMenu1.BackColor = System.Drawing.Color.White
        Me.C1MainMenu1.CommandHolder = Me.C1CommandHolder1
        Me.C1MainMenu1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink6, Me.C1CommandLink7})
        Me.C1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.C1MainMenu1.Name = "C1MainMenu1"
        Me.C1MainMenu1.Size = New System.Drawing.Size(429, 27)
        Me.C1MainMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1MainMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.mnuFile)
        Me.C1CommandHolder1.Commands.Add(Me.cmdSelectDivision)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPrintSetup)
        Me.C1CommandHolder1.Commands.Add(Me.mnuMiscSetup)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.mnuCustomer)
        Me.C1CommandHolder1.Commands.Add(Me.mnuDaily)
        Me.C1CommandHolder1.Commands.Add(Me.cmdFindCustomer)
        Me.C1CommandHolder1.Commands.Add(Me.cmdViewCustomer)
        Me.C1CommandHolder1.Commands.Add(Me.cmdTaxCode)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCategories)
        Me.C1CommandHolder1.Commands.Add(Me.cmdRouteMaster)
        Me.C1CommandHolder1.Commands.Add(Me.cmdExit)
        Me.C1CommandHolder1.Commands.Add(Me.cmdPurge)
        Me.C1CommandHolder1.Commands.Add(Me.cmdGeneralSearch)
        Me.C1CommandHolder1.Owner = Me
        '
        'mnuFile
        '
        Me.mnuFile.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.clSelectDivision, Me.clPrintSetup, Me.C1CommandLink4, Me.clExit})
        Me.mnuFile.HideNonRecentLinks = False
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutText = ""
        Me.mnuFile.Text = "&File"
        Me.mnuFile.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.mnuFile.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'clSelectDivision
        '
        Me.clSelectDivision.Command = Me.cmdSelectDivision
        '
        'cmdSelectDivision
        '
        Me.cmdSelectDivision.Name = "cmdSelectDivision"
        Me.cmdSelectDivision.ShortcutText = ""
        Me.cmdSelectDivision.Text = "Select &Division"
        '
        'clPrintSetup
        '
        Me.clPrintSetup.Command = Me.cmdPrintSetup
        Me.clPrintSetup.SortOrder = 1
        '
        'cmdPrintSetup
        '
        Me.cmdPrintSetup.Name = "cmdPrintSetup"
        Me.cmdPrintSetup.ShortcutText = ""
        Me.cmdPrintSetup.Text = "&Print Setup"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.mnuMiscSetup
        Me.C1CommandLink4.SortOrder = 2
        Me.C1CommandLink4.Text = "&Misc Setup"
        '
        'mnuMiscSetup
        '
        Me.mnuMiscSetup.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.clTaxCode, Me.clCategories, Me.clRouteMaster, Me.clPurge})
        Me.mnuMiscSetup.HideNonRecentLinks = False
        Me.mnuMiscSetup.Name = "mnuMiscSetup"
        Me.mnuMiscSetup.ShortcutText = ""
        Me.mnuMiscSetup.Text = "Misc Setup"
        '
        'clTaxCode
        '
        Me.clTaxCode.Command = Me.cmdTaxCode
        Me.clTaxCode.Text = "Tax Code"
        '
        'cmdTaxCode
        '
        Me.cmdTaxCode.Name = "cmdTaxCode"
        Me.cmdTaxCode.ShortcutText = ""
        Me.cmdTaxCode.Text = "&Tax Code"
        '
        'clCategories
        '
        Me.clCategories.Command = Me.cmdCategories
        Me.clCategories.SortOrder = 1
        '
        'cmdCategories
        '
        Me.cmdCategories.Name = "cmdCategories"
        Me.cmdCategories.ShortcutText = ""
        Me.cmdCategories.Text = "&Categories"
        '
        'clRouteMaster
        '
        Me.clRouteMaster.Command = Me.cmdRouteMaster
        Me.clRouteMaster.SortOrder = 2
        '
        'cmdRouteMaster
        '
        Me.cmdRouteMaster.Name = "cmdRouteMaster"
        Me.cmdRouteMaster.ShortcutText = ""
        Me.cmdRouteMaster.Text = "&RouteMaster"
        '
        'clPurge
        '
        Me.clPurge.Command = Me.cmdPurge
        Me.clPurge.Delimiter = True
        Me.clPurge.SortOrder = 3
        '
        'cmdPurge
        '
        Me.cmdPurge.Name = "cmdPurge"
        Me.cmdPurge.ShortcutText = ""
        Me.cmdPurge.Text = "&Purge"
        '
        'clExit
        '
        Me.clExit.Command = Me.cmdExit
        Me.clExit.Delimiter = True
        Me.clExit.SortOrder = 3
        Me.clExit.Text = "E&xit"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.ShortcutText = ""
        Me.cmdExit.Text = "&Exit"
        '
        'C1Command1
        '
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.ShortcutText = ""
        Me.C1Command1.Text = "&Tax Code"
        '
        'mnuCustomer
        '
        Me.mnuCustomer.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink9, Me.C1CommandLink10, Me.cmdAreaSearch, Me.C1CommandLink15})
        Me.mnuCustomer.HideNonRecentLinks = False
        Me.mnuCustomer.Name = "mnuCustomer"
        Me.mnuCustomer.ShortcutText = ""
        Me.mnuCustomer.Text = "&Customer"
        Me.mnuCustomer.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.mnuCustomer.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.cmdFindCustomer
        '
        'cmdFindCustomer
        '
        Me.cmdFindCustomer.Name = "cmdFindCustomer"
        Me.cmdFindCustomer.ShortcutText = ""
        Me.cmdFindCustomer.Text = "&Find Customer"
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.cmdViewCustomer
        Me.C1CommandLink10.SortOrder = 1
        '
        'cmdViewCustomer
        '
        Me.cmdViewCustomer.Name = "cmdViewCustomer"
        Me.cmdViewCustomer.ShortcutText = ""
        Me.cmdViewCustomer.Text = "&View Customer"
        '
        'cmdAreaSearch
        '
        Me.cmdAreaSearch.SortOrder = 2
        Me.cmdAreaSearch.Text = "Area Search"
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.cmdGeneralSearch
        Me.C1CommandLink15.SortOrder = 3
        '
        'cmdGeneralSearch
        '
        Me.cmdGeneralSearch.Name = "cmdGeneralSearch"
        Me.cmdGeneralSearch.ShortcutText = ""
        Me.cmdGeneralSearch.Text = "General Search"
        '
        'mnuDaily
        '
        Me.mnuDaily.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink8})
        Me.mnuDaily.HideNonRecentLinks = False
        Me.mnuDaily.Name = "mnuDaily"
        Me.mnuDaily.ShortcutText = ""
        Me.mnuDaily.Text = "&Daily"
        Me.mnuDaily.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.mnuDaily.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Text = "New Command"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.mnuFile
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.mnuCustomer
        Me.C1CommandLink6.SortOrder = 1
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.mnuDaily
        Me.C1CommandLink7.SortOrder = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 1)
        Me.Panel1.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(429, 111)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1MainMenu1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.Text = "Indoor Billboard"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1MainMenu1 As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents mnuFile As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents clSelectDivision As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdSelectDivision As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents clPrintSetup As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdPrintSetup As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents mnuMiscSetup As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1Command
    Friend WithEvents mnuCustomer As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdFindCustomer As C1.Win.C1Command.C1Command
    Friend WithEvents mnuDaily As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdViewCustomer As C1.Win.C1Command.C1Command
    Friend WithEvents clTaxCode As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdTaxCode As C1.Win.C1Command.C1Command
    Friend WithEvents clCategories As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCategories As C1.Win.C1Command.C1Command
    Friend WithEvents clRouteMaster As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdRouteMaster As C1.Win.C1Command.C1Command
    Friend WithEvents clExit As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents clPurge As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdPurge As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAreaSearch As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdGeneralSearch As C1.Win.C1Command.C1Command
    Friend WithEvents Panel1 As Panel
End Class
