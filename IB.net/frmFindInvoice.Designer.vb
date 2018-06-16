<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindInvoice
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
        Me.lstData0 = New System.Windows.Forms.ListBox()
        Me.chlAll = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.lstData1 = New System.Windows.Forms.ListBox()
        Me.lstData2 = New System.Windows.Forms.ListBox()
        Me.lstData3 = New System.Windows.Forms.ListBox()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lbllabel0 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstData0
        '
        Me.lstData0.FormattingEnabled = True
        Me.lstData0.Location = New System.Drawing.Point(7, 49)
        Me.lstData0.Name = "lstData0"
        Me.lstData0.Size = New System.Drawing.Size(64, 95)
        Me.lstData0.TabIndex = 10
        '
        'chlAll
        '
        Me.chlAll.AutoSize = True
        Me.chlAll.Location = New System.Drawing.Point(161, 7)
        Me.chlAll.Name = "chlAll"
        Me.chlAll.Size = New System.Drawing.Size(68, 17)
        Me.chlAll.TabIndex = 9
        Me.chlAll.Text = "&All Dates"
        Me.chlAll.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(364, 119)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(364, 35)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "&Refresh"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(364, 7)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(64, 22)
        Me.cmdSelect.TabIndex = 6
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'lstData1
        '
        Me.lstData1.FormattingEnabled = True
        Me.lstData1.Location = New System.Drawing.Point(77, 49)
        Me.lstData1.Name = "lstData1"
        Me.lstData1.Size = New System.Drawing.Size(57, 95)
        Me.lstData1.TabIndex = 11
        '
        'lstData2
        '
        Me.lstData2.FormattingEnabled = True
        Me.lstData2.Location = New System.Drawing.Point(140, 49)
        Me.lstData2.Name = "lstData2"
        Me.lstData2.Size = New System.Drawing.Size(57, 95)
        Me.lstData2.TabIndex = 12
        '
        'lstData3
        '
        Me.lstData3.FormattingEnabled = True
        Me.lstData3.Location = New System.Drawing.Point(203, 49)
        Me.lstData3.Name = "lstData3"
        Me.lstData3.Size = New System.Drawing.Size(148, 95)
        Me.lstData3.TabIndex = 13
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(203, 35)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel4.TabIndex = 5
        Me.lblLabel4.Text = "&Name:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(140, 35)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(54, 13)
        Me.lblLabel3.TabIndex = 4
        Me.lblLabel3.Text = "&Customer:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(77, 35)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 3
        Me.lblLabel2.Text = "R&oute:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 35)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel1.TabIndex = 2
        Me.lblLabel1.Text = "&Invoice:"
        '
        'lbllabel0
        '
        Me.lbllabel0.AutoSize = True
        Me.lbllabel0.Location = New System.Drawing.Point(7, 7)
        Me.lbllabel0.Name = "lbllabel0"
        Me.lbllabel0.Size = New System.Drawing.Size(33, 13)
        Me.lbllabel0.TabIndex = 0
        Me.lbllabel0.Text = "&Date:"
        '
        'frmFindInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 154)
        Me.Controls.Add(Me.lbllabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lstData3)
        Me.Controls.Add(Me.lstData2)
        Me.Controls.Add(Me.lstData1)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chlAll)
        Me.Controls.Add(Me.lstData0)
        Me.Location = New System.Drawing.Point(85, 92)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindInvoice"
        Me.ShowInTaskbar = False
        Me.Tag = "spGetInvNum"
        Me.Text = "Find Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstData0 As ListBox
    Friend WithEvents chlAll As CheckBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdSelect As Button
    Friend WithEvents lstData1 As ListBox
    Friend WithEvents lstData2 As ListBox
    Friend WithEvents lstData3 As ListBox
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lbllabel0 As Label
End Class
