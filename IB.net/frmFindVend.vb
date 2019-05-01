Imports System.ComponentModel

Public Class frmFindVend

    Dim blnNoCLick As Boolean = False

    Sub GetData()

        Me.Cursor = Cursors.Arrow

        VendMasterTableAdapter.Connection.ConnectionString = CS
        VendMasterTableAdapter.Fill(DsVendMasterFind_Vendor.VendMaster)

        VendMasterTableAdapter1.Connection.ConnectionString = CS
        VendMasterTableAdapter1.Fill(DsVendMasterFind_VendorName.VendMaster)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub frmFindVend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        'data1(0).ConnectionString = CS
        'data1(0).RecordSource = "Select * from VendMaster order by Vendor"
        'data1(0).Enabled = True
        'data1(0).Refresh

        'data1(1).ConnectionString = CS
        'data1(1).RecordSource = "Select * from VendMaster order by Vend_Name"
        'data1(1).Enabled = True
        'data1(1).Refresh

        GetData()

    End Sub

    Private Sub frmFindVend_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ShowCurrent()

    End Sub

    Sub ShowCurrent()

        'Dim intRow As Integer

        'If Not lstCustNum.SelectedItem = CurVend Then
        '    VendMasterBindingSource.MoveFirst()
        '    intRow = VendMasterBindingSource.Find("VENDOR", CurVend)

        '    If intRow >= 0 Then
        '        VendMasterBindingSource.Position = intRow
        '    End If

        '    'lstCustNum.BoundText = CStr(CurVend)
        '    'lstCustNum_Click
        'End If

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        Dim frm As Form

        CurVend = lstCustNum.SelectedItem(0)
        For Each frm In My.Application.OpenForms
            ' Alternate way to get "textbox" control list
            ' Dim ctrls() As Control = frm.Controls.Find("TextBox1", True)
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is Label Then
                    If ctl.Name = "lblCurVend" Then
                        ctl.Text = CurVend
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub lstCustName_DoubleClick(sender As Object, e As EventArgs) Handles lstCustName.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub lstCustNum_DoubleClick(sender As Object, e As EventArgs) Handles lstCustNum.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub frmFindVend_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub lstCustNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustNum.SelectedIndexChanged

        If lstCustNum.SelectedValue <> Nothing Then
            If blnNoCLick = False Then
                blnNoCLick = True
                lstCustName.SelectedIndex = lstCustName.FindStringExact(lstCustNum.SelectedValue.ToString)
                blnNoCLick = False
            End If
        End If

    End Sub

    Private Sub lstCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustName.SelectedIndexChanged

        If lstCustName.SelectedValue <> Nothing Then
            If blnNoCLick = False Then
                blnNoCLick = True
                lstCustNum.SelectedIndex = lstCustNum.FindStringExact(lstCustName.SelectedValue.ToString)
                blnNoCLick = False
            End If
        End If

    End Sub

End Class