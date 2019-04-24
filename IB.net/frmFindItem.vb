Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmFindItem

    'Dim TypeOpt As String * 1
    Dim TypeOpt As String
    Dim Result As DialogResult
    Dim blnNoCLick As Boolean = False

    Private Sub frmFindItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        blnNoCLick = True
        GetWindowPos(Me, 333, 66)
        blnNoCLick = False

        TypeOpt = "B"

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        'Data1.ConnectionString = CS
        'Data1.RecordSource = "spGetItemsNum ('" & TypeOpt & "')"
        'Data1.Enabled = True
        'Data1.Refresh
        SpGetItemsNumTableAdapter.Connection.ConnectionString = CS
        SpGetItemsNumTableAdapter.Fill(DsspGetItemsNum.spGetItemsNum, TypeOpt)

        'Data2.ConnectionString = CS
        'Data2.RecordSource = "spGetItemsAlpha ('" & TypeOpt & "')"
        'Data2.Enabled = True
        'Data2.Refresh
        SpGetItemsAlphaTableAdapter.Connection.ConnectionString = CS
        SpGetItemsAlphaTableAdapter.Fill(DsspGetItemsAlpha.spGetItemsAlpha, TypeOpt)

        'Data3.ConnectionString = CS
        'Data3.RecordSource = "spGetItemsVend1 ('" & TypeOpt & "')"
        'Data3.Enabled = True
        'Data3.Refresh
        SpGetItemsVend1TableAdapter.Connection.ConnectionString = CS
        SpGetItemsVend1TableAdapter.Fill(DsspGetItemsVend1.spGetItemsVend1, TypeOpt)

        'LstItemNum.BoundText = CStr(CurItem)
        'lstItemNum_Click
        LstItemNum.SelectedIndex = -1
        LstItemAlpha.SelectedIndex = -1
        If CurItem > 0 Then
            LstItemNum.SelectedIndex = LstItemNum.FindStringExact(CurItem)
        End If

        Me.Cursor = Cursors.Arrow

    End Sub

    Sub GetVendor()

        Dim s As String

        s = "Select vendor from ItemMasterO  where item_num = " & LstItemNum.SelectedItem(0) & " union select vendor from ItemMasterR where item_num = " & LstItemNum.SelectedItem(0)

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(s, connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows Then
                    dataReader.Read()
                    CurVend = dataReader(0)
                    If CurVend.Trim <> "" Then
                        cmbVendor.SelectedIndex = cmbVendor.FindStringExact(CurVend)
                    End If

                End If

                dataReader.Close()

            Catch ex As Exception
                LogError(Me.Name, "GetVendor", "2.0", ex.Message)
                Result = MessageBox.Show(Me, "Error getting the vendor" & vbNewLine & "Error : " & ex.Message, "Getting Vendor", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

    End Sub

    'Private Sub LstItemNum_Click(sender As Object, e As EventArgs) Handles LstItemNum.Click

    '    LstItemAlpha.SelectedIndex = LstItemAlpha.FindStringExact(LstItemNum.SelectedValue.ToString)

    '    GetVendor()

    'End Sub

    'Private Sub LstItemAlpha_Click(sender As Object, e As EventArgs) Handles LstItemAlpha.Click

    '    LstItemNum.SelectedIndex = LstItemNum.FindStringExact(LstItemAlpha.SelectedValue.ToString)

    'End Sub

    Private Sub LstItemAlpha_DoubleClick(sender As Object, e As EventArgs) Handles LstItemAlpha.DoubleClick

        cmdSelect.Select()

    End Sub

    Private Sub LstItemNum_DoubleClick(sender As Object, e As EventArgs) Handles LstItemNum.DoubleClick

        cmdSelect.Select()

    End Sub

    Private Sub LstItemNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstItemNum.SelectedIndexChanged

        If LstItemNum.SelectedValue <> Nothing Then
            If blnNoCLick = False Then
                blnNoCLick = True
                LstItemAlpha.SelectedIndex = LstItemAlpha.FindStringExact(LstItemNum.SelectedValue.ToString)
                blnNoCLick = False

                GetVendor()

            End If
        End If

    End Sub

    Private Sub LstItemAlpha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstItemAlpha.SelectedIndexChanged

        If LstItemAlpha.SelectedValue <> Nothing Then
            If blnNoCLick = False Then
                blnNoCLick = True
                LstItemNum.SelectedIndex = LstItemNum.FindStringExact(LstItemAlpha.SelectedValue.ToString)
                blnNoCLick = False
            End If
        End If

    End Sub

    Private Sub lstVendItem_Click(sender As Object, e As EventArgs) Handles lstVendItem.Click

        LstItemNum.SelectedIndex = LstItemNum.FindStringExact(lstVendItem.SelectedItem(0))
        'LstItemNum.BoundText = lstVendItem.BoundText
        LstItemAlpha.SelectedIndex = LstItemAlpha.FindStringExact(lstVendItem.SelectedValue.ToString)
        'LstItemAlpha.BoundText = lstVendItem.BoundText

    End Sub

    Private Sub cmbVendor_Click(sender As Object, e As EventArgs) Handles cmbVendor.Click

        CurVend = cmbVendor.Text

        SpGetItemsVend2TableAdapter.Connection.ConnectionString = CS
        SpGetItemsVend2TableAdapter.Fill(DsspGetItemsVend2.spGetItemsVend2, TypeOpt, CurVend)
        'Data4.RecordSource = "spGetItemsVend2 ('" & TypeOpt & "', '" & CurVend & "')"
        'Data4.Enabled = True
        'Data4.Refresh

    End Sub

    Private Sub lstVendItem_DoubleClick(sender As Object, e As EventArgs) Handles lstVendItem.DoubleClick

        cmdSelect.Select()

    End Sub

    Private Sub optType0_CheckedChanged(sender As Object, e As EventArgs) Handles optType0.CheckedChanged

        TypeOpt = "R"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub optType1_CheckedChanged(sender As Object, e As EventArgs) Handles optType1.CheckedChanged

        TypeOpt = "O"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub OptType2_CheckedChanged(sender As Object, e As EventArgs) Handles OptType2.CheckedChanged

        TypeOpt = "B"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub frmFindItem_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        Dim frm As Form
        Dim intRow As Integer

        CurItem = CType(LstItemNum.SelectedItem(0), Long)

        If CurItem > 0 Then
            SpGetItemsNumBindingSource.MoveFirst()
            intRow = SpGetItemsNumBindingSource.Find("ITEM_NUM", CurItem)

            If intRow >= 0 Then
                SpGetItemsNumBindingSource.Position = intRow
            End If
        End If

        ' What if it doesn't find a row?
        CurItem = DsspGetItemsNum.spGetItemsNum(intRow)("ITEM_NUM")
        CurType = DsspGetItemsNum.spGetItemsNum(intRow)("ITEM_TYPE")
        For Each frm In My.Application.OpenForms
            ' Alternate way to get "textbox" control list
            ' Dim ctrls() As Control = frm.Controls.Find("TextBox1", True)
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is Label Then
                    If ctl.Name = "lblCurItem" Then
                        ctl.Text = CurItem
                    End If
                End If
            Next
        Next

        'rstemp.MoveFirst()
        'rstemp.Find "ITEM_NUM=" & LstItemNum.BoundText

        'CurItem = rstemp!ITEM_NUM
        'CurType = rstemp!ITEM_TYPE

        'On Error Resume Next
        'For Each fm In Forms
        '    fm.lblCurItem = CurItem
        'Next

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub
End Class