Public Class frmVend

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean

    Private Sub frmVend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        '    data1.ConnectionString = CS
        '    data1.RecordSource = "Select * From VendMaster Where 1=0"
        '    data1.Enabled = True
        '    data1.Refresh
        '    Set rs = data1.Recordset

        '    Line1(0).Y2 = Me.ScaleHeight
        '    Line1(1).Y2 = Me.ScaleHeight

        '    'Set text box lengths based on rs
        '    Dim c As Control, fld As String
        '    For Each c In Me.Controls
        '        If TypeOf c Is TextBox Then
        '            fld = c.DataField
        '            If fld > "" Then
        '                Select Case data1.Recordset.Fields(fld).Type
        '                    Case adChar, adVarChar, adVarWChar
        '                        c.MaxLength = rs.Fields(fld).DefinedSize
        '                    Case adTinyInt
        '                        c.MaxLength = 1
        '                    Case adSmallInt
        '                        c.MaxLength = 5
        '                    Case adInteger, adSingle
        '                        c.MaxLength = 10
        '                    Case Else
        '                        c.MaxLength = 20
        '                End Select
        '            End If
        '        End If
        '    Next c
        '    'End If
        '    Me.Enabled = True
        '    Screen.MousePointer = 1
        '    Me.Show()

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        If CurVend <> "" Then
            VendMasterTableAdapter.Connection.ConnectionString = CS
            VendMasterTableAdapter.Fill(DsVendMaster_Vendor.VendMaster, CurVend)
        Else
            frmFindVend.Show()
            frmFindVend.BringToFront()
        End If
        'Dim q As String
        'If CurVend > "" Then
        '    q = "Select * from VendMaster Where VENDOR='" & CurVend & "'"
        'Else
        '    q = "Select * from VendMaster"
        'End If
        'data1.RecordSource = q
        'data1.Enabled = True
        'data1.Refresh

        'Set rs = data1.Recordset
        'If rs.EOF And rs.BOF Then
        '    cmdNew_Click
        'Else
        '    If rs.RecordCount > 1 Then cmdFind_Click
        'End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Sub closedata()

        'If rs Is Nothing Then Exit Sub
        'bCancel = False
        'rs.Close()

        'If Not bCancel Then
        'Set rs = Nothing
        'On Error Resume Next
        'End If
        'bCancel = False

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindVend.Show()

    End Sub

    Private Sub lblCurVend_TextChanged(sender As Object, e As EventArgs) Handles lblCurVend.TextChanged

        If Not cmdReset.Enabled Then
            buserchange = False
            GetData()
            buserchange = True
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        'Dim Result As DialogResult

        'If bTextChanged = True Then
        '    Result = MessageBox.Show(Me, "Do you want to exit the form without saving your changes?", "Exit form", vbYesNo)
        '    If Result = vbYes Then
        '        Exit Sub
        '    End If
        'End If

        SaveWindowPos(Me)

        Me.Close()

    End Sub

End Class