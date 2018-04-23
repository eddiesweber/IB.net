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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectDivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RouteMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PurgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.DailyToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.CommisionToolStripMenuItem, Me.VersionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectDivisionToolStripMenuItem, Me.PrintSetupToolStripMenuItem, Me.MiscSetupToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindCustomerToolStripMenuItem, Me.ViewCustomerToolStripMenuItem, Me.AreaSearchToolStripMenuItem, Me.GeneralSearchToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'DailyToolStripMenuItem
        '
        Me.DailyToolStripMenuItem.Name = "DailyToolStripMenuItem"
        Me.DailyToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.DailyToolStripMenuItem.Text = "&Daily"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InventoryToolStripMenuItem.Text = "&Inventory"
        '
        'CommisionToolStripMenuItem
        '
        Me.CommisionToolStripMenuItem.Name = "CommisionToolStripMenuItem"
        Me.CommisionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CommisionToolStripMenuItem.Text = "Co&mmision"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.VersionToolStripMenuItem.Text = "&Version"
        '
        'SelectDivisionToolStripMenuItem
        '
        Me.SelectDivisionToolStripMenuItem.Name = "SelectDivisionToolStripMenuItem"
        Me.SelectDivisionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectDivisionToolStripMenuItem.Text = "Select Division"
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Print Setup"
        '
        'MiscSetupToolStripMenuItem
        '
        Me.MiscSetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TaxCodeToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.RouteMasterToolStripMenuItem, Me.ToolStripSeparator2, Me.PurgeToolStripMenuItem})
        Me.MiscSetupToolStripMenuItem.Name = "MiscSetupToolStripMenuItem"
        Me.MiscSetupToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MiscSetupToolStripMenuItem.Text = "Misc Setup"
        '
        'TaxCodeToolStripMenuItem
        '
        Me.TaxCodeToolStripMenuItem.Name = "TaxCodeToolStripMenuItem"
        Me.TaxCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TaxCodeToolStripMenuItem.Text = "Tax Code"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'RouteMasterToolStripMenuItem
        '
        Me.RouteMasterToolStripMenuItem.Name = "RouteMasterToolStripMenuItem"
        Me.RouteMasterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RouteMasterToolStripMenuItem.Text = "Route Master"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'PurgeToolStripMenuItem
        '
        Me.PurgeToolStripMenuItem.Name = "PurgeToolStripMenuItem"
        Me.PurgeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PurgeToolStripMenuItem.Text = "Purge"
        '
        'FindCustomerToolStripMenuItem
        '
        Me.FindCustomerToolStripMenuItem.Name = "FindCustomerToolStripMenuItem"
        Me.FindCustomerToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.FindCustomerToolStripMenuItem.Text = "Find Customer"
        '
        'ViewCustomerToolStripMenuItem
        '
        Me.ViewCustomerToolStripMenuItem.Name = "ViewCustomerToolStripMenuItem"
        Me.ViewCustomerToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ViewCustomerToolStripMenuItem.Text = "&View Customer          Ctrl-V"
        '
        'AreaSearchToolStripMenuItem
        '
        Me.AreaSearchToolStripMenuItem.Name = "AreaSearchToolStripMenuItem"
        Me.AreaSearchToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AreaSearchToolStripMenuItem.Text = "Area Search"
        '
        'GeneralSearchToolStripMenuItem
        '
        Me.GeneralSearchToolStripMenuItem.Name = "GeneralSearchToolStripMenuItem"
        Me.GeneralSearchToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.GeneralSearchToolStripMenuItem.Text = "General Search"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 111)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Indoor Billboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDivisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaxCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RouteMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PurgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralSearchToolStripMenuItem As ToolStripMenuItem
End Class
