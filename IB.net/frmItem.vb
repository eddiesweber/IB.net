Public Class frmItem

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean
    Dim bFlagX As Boolean

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        'Data1.ConnectionString = CS
        'Data2.ConnectionString = CS
        'Data3.ConnectionString = CS

        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        ''Set text box lengths based on tabledef
        'Dim c As Control, fld As String
        'Dim R As New ADODB.Recordset
        'Dim ADOConn As New ADODB.Connection
        'R.Open "Select * from ItemMasterR Where 1=0", DB, adOpenStatic
        'For Each c In Me.Controls
        '    If c.Name = "txtData" Then
        '        fld = c.DataField
        '        If fld > "" Then
        '            Select Case R.Fields(fld).Type
        '                Case adChar, adVarChar, adVarWChar
        '                    c.MaxLength = R.Fields(fld).DefinedSize
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
        'R.Close()

        VendMasterTableAdapter.Connection.ConnectionString = CS
        VendMasterTableAdapter.Fill(Me.DsVendMaster.VendMaster)
        'Data2.RecordSource = "VendMaster"
        'Data2.Enabled = True
        'Data2.Refresh

        GetData()

        SetModeReg

        '''''''''''' From for activate
        buserchange = True
        bInit = False

    End Sub

    Sub GetData()

        If CurType = "O" Then
            'optType0.Checked = False
            optType1.Checked = True
        Else
            optType0.Checked = True
            'optType1.Checked = False
        End If

        buserchange = False
        bFlagX = False

        If CurItem > 0 Then
            '    rs.MoveFirst
            '    rs.Find "ITEM_NUM=" & CStr(CurItem)
        End If

        'If Not rs.EOF Then Exit Sub
        'End If
        'If rs.EOF And rs.BOF Then
        '    cmdNew_Click
        'Else
        '    cmdFind_Click
        'End If

    End Sub

    Private Sub optType0_CheckedChanged(sender As Object, e As EventArgs) Handles optType0.CheckedChanged

        If optType0.Checked = True Then
            buserchange = False

            CurType = "R"

            SpGetCategoriesTableAdapter.Connection.ConnectionString = CS
            SpGetCategoriesTableAdapter.Fill(DsspGetCategories.spGetCategories, CurType)
            'Data3.RecordSource = "spGetCategories ('" & CurType & "')"
            'Data3.Enabled = True
            'Data3.Refresh

            txtData0.DataSource = ItemMasterRBindingSource
            txtData1.DataSource = ItemMasterRBindingSource
            txtData2.DataSource = ItemMasterRBindingSource
            txtData3.DataSource = ItemMasterRBindingSource
            txtData4.DataSource = ItemMasterRBindingSource
            txtData5.DataSource = ItemMasterRBindingSource
            txtData6.DataSource = ItemMasterRBindingSource
            txtData7.DataSource = ItemMasterRBindingSource
            txtData8.DataSource = ItemMasterRBindingSource
            txtData10.DataSource = ItemMasterRBindingSource
            txtData12.DataSource = ItemMasterRBindingSource
            txtData13.DataSource = ItemMasterRBindingSource
            chkData0.DataSource = ItemMasterRBindingSource
            chkData1.DataSource = ItemMasterRBindingSource
            chkData2.DataSource = ItemMasterRBindingSource

            ItemMasterRTableAdapter.Connection.ConnectionString = CS
            ItemMasterRTableAdapter.Fill(DsItemMasterR_ItemNum.ItemMasterR, CurItem)
            'data1.RecordSource = "ItemMaster" & CurType
            'data1.Enabled = True
            'data1.Refresh

            'Set rs = data1.Recordset

            buserchange = True
            frmPO.Visible = True
        End If

    End Sub

    Private Sub optType1_CheckedChanged(sender As Object, e As EventArgs) Handles optType1.CheckedChanged

        If optType1.Checked = True Then
            buserchange = False

            CurType = "O"

            SpGetCategoriesTableAdapter.Connection.ConnectionString = CS
            SpGetCategoriesTableAdapter.Fill(DsspGetCategories.spGetCategories, CurType)
            'Data3.RecordSource = "spGetCategories ('" & CurType & "')"
            'Data3.Enabled = True
            'Data3.Refresh

            txtData0.DataSource = ItemMasterOBindingSource
            txtData1.DataSource = ItemMasterOBindingSource
            txtData2.DataSource = ItemMasterOBindingSource
            txtData3.DataSource = ItemMasterOBindingSource
            txtData4.DataSource = ItemMasterOBindingSource
            txtData5.DataSource = ItemMasterOBindingSource
            txtData6.DataSource = ItemMasterOBindingSource
            txtData7.DataSource = ItemMasterOBindingSource
            txtData8.DataSource = ItemMasterOBindingSource
            txtData10.DataSource = ItemMasterOBindingSource
            txtData12.DataSource = ItemMasterOBindingSource
            txtData13.DataSource = ItemMasterOBindingSource
            chkData0.DataSource = ItemMasterOBindingSource
            chkData1.DataSource = ItemMasterOBindingSource
            chkData2.DataSource = ItemMasterOBindingSource

            ItemMasterOTableAdapter.Connection.ConnectionString = CS
            ItemMasterOTableAdapter.Fill(DsItemMasterO_ItemNum.ItemMasterO, CurItem)
            'data1.RecordSource = "ItemMaster" & CurType
            'data1.Enabled = True
            'data1.Refresh

            'Set rs = data1.Recordset

            buserchange = True
            frmPO.Visible = False
        End If

    End Sub

    Sub closedata()

        'If rs Is Nothing Then Exit Sub
        'bCancel = False
        'rs.Close
        'If Not bCancel Then
        'Set rs = Nothing
        'On Error Resume Next
        'End If
        'bCancel = False

    End Sub

    Public Sub SetModeChange()

        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFind.Enabled = False
        cmdExit.Enabled = False
        fraType.Enabled = False

    End Sub

    Public Sub SetModeAdd()

        txtData0.Enabled = True

        SetModeChange()

        txtData0.Select()

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFind.Enabled = True
        txtData0.Enabled = False
        fraType.Enabled = True

    End Sub
End Class