<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurge
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurge))
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        Me.cmdOK = New C1.Win.C1Input.C1Button()
        Me.lblName0 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.lblHead0 = New System.Windows.Forms.Label()
        Me.lblHead1 = New System.Windows.Forms.Label()
        Me.lblHead2 = New System.Windows.Forms.Label()
        Me.DsPurge = New IB.net.dsPurge()
        Me.PurgeTableAdapter = New IB.net.dsPurgeTableAdapters.PurgeTableAdapter()
        Me.DsCustomerMasterPurge = New IB.net.dsCustomerMasterPurge()
        Me.CustomerMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerMasterTableAdapter = New IB.net.dsCustomerMasterPurgeTableAdapters.CustomerMasterTableAdapter()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPurge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomerMasterPurge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(190, 266)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(85, 25)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(10, 266)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 25
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        Me.cmdOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblName0
        '
        Me.lblName0.AutoSize = True
        Me.lblName0.ForeColor = System.Drawing.Color.Navy
        Me.lblName0.Location = New System.Drawing.Point(10, 50)
        Me.lblName0.Name = "lblName0"
        Me.lblName0.Size = New System.Drawing.Size(60, 13)
        Me.lblName0.TabIndex = 34
        Me.lblName0.Text = "Description"
        Me.lblName0.Visible = False
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.ForeColor = System.Drawing.Color.Navy
        Me.lblName2.Location = New System.Drawing.Point(220, 50)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(35, 13)
        Me.lblName2.TabIndex = 35
        Me.lblName2.Text = "Count" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblName2.Visible = False
        '
        'lblName1
        '
        Me.lblName1.AutoSize = True
        Me.lblName1.ForeColor = System.Drawing.Color.Navy
        Me.lblName1.Location = New System.Drawing.Point(170, 50)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(42, 13)
        Me.lblName1.TabIndex = 36
        Me.lblName1.Text = "Months" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblName1.Visible = False
        '
        'lblHead0
        '
        Me.lblHead0.AutoSize = True
        Me.lblHead0.Location = New System.Drawing.Point(10, 10)
        Me.lblHead0.Name = "lblHead0"
        Me.lblHead0.Size = New System.Drawing.Size(92, 26)
        Me.lblHead0.TabIndex = 38
        Me.lblHead0.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data File to Purge"
        '
        'lblHead1
        '
        Me.lblHead1.AutoSize = True
        Me.lblHead1.Location = New System.Drawing.Point(170, 10)
        Me.lblHead1.Name = "lblHead1"
        Me.lblHead1.Size = New System.Drawing.Size(45, 26)
        Me.lblHead1.TabIndex = 39
        Me.lblHead1.Text = "Months " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Keep"
        '
        'lblHead2
        '
        Me.lblHead2.AutoSize = True
        Me.lblHead2.Location = New System.Drawing.Point(220, 10)
        Me.lblHead2.Name = "lblHead2"
        Me.lblHead2.Size = New System.Drawing.Size(47, 26)
        Me.lblHead2.TabIndex = 40
        Me.lblHead2.Text = "Records" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleted"
        '
        'DsPurge
        '
        Me.DsPurge.DataSetName = "dsPurge"
        Me.DsPurge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurgeTableAdapter
        '
        Me.PurgeTableAdapter.ClearBeforeFill = True
        '
        'DsCustomerMasterPurge
        '
        Me.DsCustomerMasterPurge.DataSetName = "dsCustomerMasterPurge"
        Me.DsCustomerMasterPurge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerMasterBindingSource
        '
        Me.CustomerMasterBindingSource.DataMember = "CustomerMaster"
        Me.CustomerMasterBindingSource.DataSource = Me.DsCustomerMasterPurge
        '
        'CustomerMasterTableAdapter
        '
        Me.CustomerMasterTableAdapter.ClearBeforeFill = True
        '
        'frmPurge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 301)
        Me.Controls.Add(Me.lblHead2)
        Me.Controls.Add(Me.lblHead1)
        Me.Controls.Add(Me.lblHead0)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblName0)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(97, 106)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurge"
        Me.ShowInTaskbar = False
        Me.Text = "Purge"
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPurge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomerMasterPurge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
    Friend WithEvents cmdOK As C1.Win.C1Input.C1Button
    Friend WithEvents lblName0 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents lblHead0 As Label
    Friend WithEvents lblHead1 As Label
    Friend WithEvents lblHead2 As Label
    Friend WithEvents DsPurge As dsPurge
    Friend WithEvents PurgeTableAdapter As dsPurgeTableAdapters.PurgeTableAdapter
    Friend WithEvents DsCustomerMasterPurge As dsCustomerMasterPurge
    Friend WithEvents CustomerMasterBindingSource As BindingSource
    Friend WithEvents CustomerMasterTableAdapter As dsCustomerMasterPurgeTableAdapters.CustomerMasterTableAdapter
End Class
