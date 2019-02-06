Option Explicit On

Public Class frmCust

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean

    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        Me.Show()
        Me.Enabled = False

        Me.Cursor = Cursors.WaitCursor

        Me.CustomerMasterTableAdapter.Connection.ConnectionString = CS

        If CurCust > 0 Then
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)
        End If

        'Set rs = data1.Recordset
        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        ''Set text box lengths based on rs
        'Dim c As Control, fld As String
        'For Each c In Me.Controls
        '    If TypeOf c Is TextBox Then
        '        fld = c.DataField
        '        If fld > "" Then
        '            Select Case data1.Recordset.Fields(fld).Type
        '                Case adChar, adVarChar, adVarWChar
        '                    c.MaxLength = rs.Fields(fld).DefinedSize
        '                Case adTinyInt
        '                    c.MaxLength = 1
        '                Case adSmallInt
        '                    c.MaxLength = 5
        '                Case adInteger, adSingle
        '                    c.MaxLength = 10
        '                Case Else
        '                    c.MaxLength = 20
        '            End Select
        '        End If
        '    End If
        'Next c

        Me.Show()
        GetData()

        Me.Enabled = True

        Me.Cursor = Cursors.Arrow

    End Sub

    Sub GetData()

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)
        End If

        If Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString = "" Then
            txtData11.Text = CCDecrypt(Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString)
        End If

        'Set rs = data1.Recordset
        'If rs.EOF And rs.BOF Then
        'cmdNew_Click
        'Else
        'If rs.RecordCount > 1 Then cmdFind_Click
        'End If

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        'CustomerMasterTableAdapter.Insert()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

        frmDept.Show()

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        'If Not cmdReset.Enabled Then
        buserchange = False
        GetData()
        buserchange = True
        'End If

    End Sub

    Public Sub SetModeChange()

        'cmdNew.Enabled = False
        'cmdDelete.Enabled = False
        'cmdReset.Enabled = True
        'cmdReset.Cancel = True
        'cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        'cmdFind.Enabled = False
        'cmdExit.Enabled = False
        'cmdEditDept.Enabled = False

    End Sub

    Public Sub SetModeAdd()

        'txtData0.Text = "(new)"
        'txtData0.DataChanged = False
        'SetModeChange()
        'txtData1.SetFocus

    End Sub

    Public Sub SetModeReg()

        'cmdNew.Enabled = True
        'cmdDelete.Enabled = True
        'cmdReset.Enabled = False
        'cmdUpdate.Enabled = False
        'cmdExit.Enabled = True
        'cmdFind.Enabled = True
        'cmdEditDept.Enabled = True

    End Sub

End Class