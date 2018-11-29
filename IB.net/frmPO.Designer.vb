<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO
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
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.txtData1 = New System.Windows.Forms.TextBox()
        Me.txtData0 = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.txtHidden2 = New System.Windows.Forms.TextBox()
        Me.txtHidden1 = New System.Windows.Forms.TextBox()
        Me.txtHidden0 = New System.Windows.Forms.TextBox()
        Me.txtData6 = New System.Windows.Forms.TextBox()
        Me.txtData5 = New System.Windows.Forms.TextBox()
        Me.fraType = New System.Windows.Forms.GroupBox()
        Me.optType1 = New System.Windows.Forms.RadioButton()
        Me.optType0 = New System.Windows.Forms.RadioButton()
        Me.txtData4 = New System.Windows.Forms.TextBox()
        Me.txtData3 = New System.Windows.Forms.TextBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.txtData2 = New System.Windows.Forms.TextBox()
        Me.lblCurItem1 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.fraType.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(238, 56)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(71, 22)
        Me.cmdFind.TabIndex = 2
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtData1
        '
        Me.txtData1.BackColor = System.Drawing.Color.Silver
        Me.txtData1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData1.ForeColor = System.Drawing.Color.Navy
        Me.txtData1.Location = New System.Drawing.Point(77, 77)
        Me.txtData1.Name = "txtData1"
        Me.txtData1.Size = New System.Drawing.Size(232, 13)
        Me.txtData1.TabIndex = 24
        Me.txtData1.TabStop = False
        '
        'txtData0
        '
        Me.txtData0.Enabled = False
        Me.txtData0.ForeColor = System.Drawing.Color.Navy
        Me.txtData0.Location = New System.Drawing.Point(77, 56)
        Me.txtData0.Name = "txtData0"
        Me.txtData0.Size = New System.Drawing.Size(64, 20)
        Me.txtData0.TabIndex = 23
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(343, 119)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(71, 22)
        Me.cmdExit.TabIndex = 22
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(343, 91)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(71, 22)
        Me.cmdUpdate.TabIndex = 21
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'txtHidden2
        '
        Me.txtHidden2.ForeColor = System.Drawing.Color.Navy
        Me.txtHidden2.Location = New System.Drawing.Point(259, 210)
        Me.txtHidden2.Multiline = True
        Me.txtHidden2.Name = "txtHidden2"
        Me.txtHidden2.Size = New System.Drawing.Size(29, 22)
        Me.txtHidden2.TabIndex = 20
        Me.txtHidden2.Visible = False
        '
        'txtHidden1
        '
        Me.txtHidden1.ForeColor = System.Drawing.Color.Navy
        Me.txtHidden1.Location = New System.Drawing.Point(224, 210)
        Me.txtHidden1.Multiline = True
        Me.txtHidden1.Name = "txtHidden1"
        Me.txtHidden1.Size = New System.Drawing.Size(29, 22)
        Me.txtHidden1.TabIndex = 19
        Me.txtHidden1.Visible = False
        '
        'txtHidden0
        '
        Me.txtHidden0.ForeColor = System.Drawing.Color.Navy
        Me.txtHidden0.Location = New System.Drawing.Point(189, 210)
        Me.txtHidden0.Multiline = True
        Me.txtHidden0.Name = "txtHidden0"
        Me.txtHidden0.Size = New System.Drawing.Size(29, 20)
        Me.txtHidden0.TabIndex = 18
        Me.txtHidden0.Visible = False
        '
        'txtData6
        '
        Me.txtData6.ForeColor = System.Drawing.Color.Navy
        Me.txtData6.Location = New System.Drawing.Point(77, 210)
        Me.txtData6.Multiline = True
        Me.txtData6.Name = "txtData6"
        Me.txtData6.Size = New System.Drawing.Size(71, 20)
        Me.txtData6.TabIndex = 15
        '
        'txtData5
        '
        Me.txtData5.ForeColor = System.Drawing.Color.Navy
        Me.txtData5.Location = New System.Drawing.Point(77, 182)
        Me.txtData5.Multiline = True
        Me.txtData5.Name = "txtData5"
        Me.txtData5.Size = New System.Drawing.Size(71, 20)
        Me.txtData5.TabIndex = 12
        '
        'fraType
        '
        Me.fraType.Controls.Add(Me.optType0)
        Me.fraType.Controls.Add(Me.optType1)
        Me.fraType.Location = New System.Drawing.Point(49, 7)
        Me.fraType.Name = "fraType"
        Me.fraType.Size = New System.Drawing.Size(211, 36)
        Me.fraType.TabIndex = 0
        Me.fraType.TabStop = False
        Me.fraType.Text = "&Type"
        '
        'optType1
        '
        Me.optType1.AutoSize = True
        Me.optType1.Location = New System.Drawing.Point(126, 14)
        Me.optType1.Name = "optType1"
        Me.optType1.Size = New System.Drawing.Size(51, 17)
        Me.optType1.TabIndex = 26
        Me.optType1.TabStop = True
        Me.optType1.Text = "Other"
        Me.optType1.UseVisualStyleBackColor = True
        '
        'optType0
        '
        Me.optType0.AutoSize = True
        Me.optType0.Location = New System.Drawing.Point(42, 14)
        Me.optType0.Name = "optType0"
        Me.optType0.Size = New System.Drawing.Size(56, 17)
        Me.optType0.TabIndex = 25
        Me.optType0.TabStop = True
        Me.optType0.Text = "Rental"
        Me.optType0.UseVisualStyleBackColor = True
        '
        'txtData4
        '
        Me.txtData4.ForeColor = System.Drawing.Color.Navy
        Me.txtData4.Location = New System.Drawing.Point(77, 154)
        Me.txtData4.Multiline = True
        Me.txtData4.Name = "txtData4"
        Me.txtData4.Size = New System.Drawing.Size(71, 19)
        Me.txtData4.TabIndex = 9
        '
        'txtData3
        '
        Me.txtData3.ForeColor = System.Drawing.Color.Navy
        Me.txtData3.Location = New System.Drawing.Point(77, 126)
        Me.txtData3.Name = "txtData3"
        Me.txtData3.Size = New System.Drawing.Size(99, 20)
        Me.txtData3.TabIndex = 7
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(343, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(71, 22)
        Me.cmdNew.TabIndex = 16
        Me.cmdNew.Text = "&New PO"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Enabled = False
        Me.cmdReset.Location = New System.Drawing.Point(343, 63)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(71, 22)
        Me.cmdReset.TabIndex = 17
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'txtData2
        '
        Me.txtData2.ForeColor = System.Drawing.Color.Navy
        Me.txtData2.Location = New System.Drawing.Point(77, 98)
        Me.txtData2.Name = "txtData2"
        Me.txtData2.Size = New System.Drawing.Size(232, 20)
        Me.txtData2.TabIndex = 5
        '
        'lblCurItem1
        '
        Me.lblCurItem1.Location = New System.Drawing.Point(280, 21)
        Me.lblCurItem1.Name = "lblCurItem1"
        Me.lblCurItem1.Size = New System.Drawing.Size(29, 15)
        Me.lblCurItem1.TabIndex = 1
        Me.lblCurItem1.Visible = False
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(7, 214)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(74, 13)
        Me.lblLabel4.TabIndex = 14
        Me.lblLabel4.Text = "&Back-ordered:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(7, 157)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel3.TabIndex = 8
        Me.lblLabel3.Text = "&Ordered:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(7, 130)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel2.TabIndex = 6
        Me.lblLabel2.Text = "I&nvoice:"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.Location = New System.Drawing.Point(7, 186)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(56, 13)
        Me.lblLabel5.TabIndex = 11
        Me.lblLabel5.Text = "&Received:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(7, 102)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(44, 13)
        Me.lblLabel1.TabIndex = 4
        Me.lblLabel1.Text = "&Vendor:"
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.Location = New System.Drawing.Point(7, 60)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.Size = New System.Drawing.Size(70, 13)
        Me.lblLabel0.TabIndex = 3
        Me.lblLabel0.Text = "&Item Number:"
        '
        'frmPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 236)
        Me.Controls.Add(Me.lblLabel0)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.lblLabel5)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.lblCurItem1)
        Me.Controls.Add(Me.txtData2)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtData3)
        Me.Controls.Add(Me.txtData4)
        Me.Controls.Add(Me.fraType)
        Me.Controls.Add(Me.txtData5)
        Me.Controls.Add(Me.txtData6)
        Me.Controls.Add(Me.txtHidden0)
        Me.Controls.Add(Me.txtHidden1)
        Me.Controls.Add(Me.txtHidden2)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtData0)
        Me.Controls.Add(Me.txtData1)
        Me.Controls.Add(Me.cmdFind)
        Me.Location = New System.Drawing.Point(121, 130)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPO"
        Me.ShowInTaskbar = False
        Me.Text = "Edit Current Purchase Order"
        Me.fraType.ResumeLayout(False)
        Me.fraType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFind As Button
    Friend WithEvents txtData1 As TextBox
    Friend WithEvents txtData0 As TextBox
    Friend WithEvents cmdExit As Button
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents txtHidden2 As TextBox
    Friend WithEvents txtHidden1 As TextBox
    Friend WithEvents txtHidden0 As TextBox
    Friend WithEvents txtData6 As TextBox
    Friend WithEvents txtData5 As TextBox
    Friend WithEvents fraType As GroupBox
    Friend WithEvents optType0 As RadioButton
    Friend WithEvents optType1 As RadioButton
    Friend WithEvents txtData4 As TextBox
    Friend WithEvents txtData3 As TextBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdReset As Button
    Friend WithEvents txtData2 As TextBox
    Friend WithEvents lblCurItem1 As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents lblLabel5 As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel0 As Label
End Class
