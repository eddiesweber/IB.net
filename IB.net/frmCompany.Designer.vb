<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.TableAdapterManager = New IB.net.masterDataSetTableAdapters.TableAdapterManager()
        Me.lstCompany = New System.Windows.Forms.ListBox()
        Me.IBconfigBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdOpen = New C1.Win.C1Input.C1Button()
        Me.cmdCancel = New C1.Win.C1Input.C1Button()
        CType(Me.IBconfigBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.IBconfigTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IB.net.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lstCompany
        '
        Me.lstCompany.FormattingEnabled = True
        Me.lstCompany.Location = New System.Drawing.Point(10, 10)
        Me.lstCompany.Margin = New System.Windows.Forms.Padding(1)
        Me.lstCompany.Name = "lstCompany"
        Me.lstCompany.Size = New System.Drawing.Size(125, 69)
        Me.lstCompany.TabIndex = 3
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(150, 10)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 25)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        Me.cmdOpen.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdOpen.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(150, 40)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 25)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        Me.cmdCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 86)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.lstCompany)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(76, 73)
        Me.Name = "frmCompany"
        Me.Text = "Select Division"
        CType(Me.IBconfigBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lstCompany As ListBox
    Friend WithEvents IBconfigBindingSource1 As BindingSource
    Friend WithEvents cmdOpen As C1.Win.C1Input.C1Button
    Friend WithEvents cmdCancel As C1.Win.C1Input.C1Button
End Class
