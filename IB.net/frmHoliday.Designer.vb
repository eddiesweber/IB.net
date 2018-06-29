<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoliday
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
        Me.Frame11 = New System.Windows.Forms.GroupBox()
        Me.txtRoute = New System.Windows.Forms.TextBox()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.Frame10 = New System.Windows.Forms.GroupBox()
        Me.lstRoute = New System.Windows.Forms.ListBox()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.lblStatus0 = New System.Windows.Forms.Label()
        Me.Frame11.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame11
        '
        Me.Frame11.Controls.Add(Me.lblLabel2)
        Me.Frame11.Controls.Add(Me.lblLabel3)
        Me.Frame11.Controls.Add(Me.txtRoute)
        Me.Frame11.Location = New System.Drawing.Point(182, 14)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.Size = New System.Drawing.Size(155, 120)
        Me.Frame11.TabIndex = 4
        Me.Frame11.TabStop = False
        Me.Frame11.Text = "&To:"
        '
        'txtRoute
        '
        Me.txtRoute.ForeColor = System.Drawing.Color.Navy
        Me.txtRoute.Location = New System.Drawing.Point(49, 56)
        Me.txtRoute.Name = "txtRoute"
        Me.txtRoute.Size = New System.Drawing.Size(36, 20)
        Me.txtRoute.TabIndex = 8
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 28)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel3.TabIndex = 5
        Me.lblLabel3.Text = "Date:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 56)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 7
        Me.lblLabel2.Text = "Route:"
        '
        'Frame10
        '
        Me.Frame10.Controls.Add(Me.lblLabel0)
        Me.Frame10.Controls.Add(Me.lblLabel1)
        Me.Frame10.Controls.Add(Me.lstRoute)
        Me.Frame10.Location = New System.Drawing.Point(14, 14)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Size = New System.Drawing.Size(155, 120)
        Me.Frame10.TabIndex = 0
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "&From:"
        '
        'lstRoute
        '
        Me.lstRoute.ForeColor = System.Drawing.Color.Navy
        Me.lstRoute.FormattingEnabled = True
        Me.lstRoute.Location = New System.Drawing.Point(49, 56)
        Me.lstRoute.Name = "lstRoute"
        Me.lstRoute.Size = New System.Drawing.Size(36, 56)
        Me.lstRoute.TabIndex = 12
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 56)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel1.TabIndex = 3
        Me.lblLabel1.Text = "Route:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 28)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(33, 13)
        Me.lblLabel0.TabIndex = 1
        Me.lblLabel0.Text = "Date:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(196, 147)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 22)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(91, 147)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(64, 22)
        Me.cmdOK.TabIndex = 9
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'lblStatus0
        '
        Me.lblStatus0.AutoSize = True
        Me.lblStatus0.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus0.Location = New System.Drawing.Point(14, 182)
        Me.lblStatus0.Name = "lblStatus0"
        Me.lblStatus0.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus0.TabIndex = 11
        '
        'frmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 197)
        Me.Controls.Add(Me.lblStatus0)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame11)
        Me.Location = New System.Drawing.Point(44, 57)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoliday"
        Me.ShowInTaskbar = False
        Me.Text = "Holiday Reschedule"
        Me.Frame11.ResumeLayout(False)
        Me.Frame11.PerformLayout()
        Me.Frame10.ResumeLayout(False)
        Me.Frame10.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Frame11 As GroupBox
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents txtRoute As TextBox
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents Frame10 As GroupBox
    Friend WithEvents lstRoute As ListBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents lblStatus0 As Label
End Class
