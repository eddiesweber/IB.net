Public Class frmCust

    'Dim CoRS As ADODB.Recordset
    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean
    'Dim rs As ADODB.Recordset

    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        Me.Show()
        Me.Enabled = False

        Me.Cursor = Cursors.WaitCursor

        'data1.ConnectionString = CS
        Me.CustomerMasterTableAdapter.Connection.ConnectionString = CS

        'data1.RecordSource = "Select * From CustomerMaster Where 1=0"
        'data1.Enabled = True
        'data1.Refresh
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
        'Screen.MousePointer = 1

    End Sub

    Sub GetData()

        'Dim q As String
        If CurCust > 0 Then
            'q = "Select * from CustomerMaster Where CUST_NUM=" & CurCust
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)
        Else
            'q = "Select * from CustomerMaster"
        End If
        'data1.RecordSource = q
        'data1.Enabled = True
        'data1.Refresh

        If Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString = "" Then
            'If Trim(data1.Recordset.Fields("CC_NUM")) <> "" Then
            txtData11.Text = CCDecrypt(Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString)
        End If

        'Set rs = data1.Recordset
        'If rs.EOF And rs.BOF Then
        'cmdNew_Click
        'Else
        'If rs.RecordCount > 1 Then cmdFind_Click
        'End If

    End Sub


End Class