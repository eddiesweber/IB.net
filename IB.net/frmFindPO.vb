Option Explicit On

Imports System.ComponentModel

Public Class frmFindPO

    Dim blnNoCLick As Boolean = False

    Private Sub frmFindPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        'Me.Show()

        SpGetPOsNumTableAdapter.Connection.ConnectionString = CS
        SpGetPOsNumTableAdapter.Fill(Me.DsspGetPOsNum.SpGetPOsNum)
        'data1(0).ConnectionString = CS
        'data1(0).RecordSource = "spGetPOsNum"
        'data1(0).Enabled = True
        'data1(0).Refresh

        SpGetPOsAlphaTableAdapter.Connection.ConnectionString = CS
        SpGetPOsAlphaTableAdapter.Fill(Me.DsspGetPOsAlpha.SpGetPOsAlpha)
        'data1(1).ConnectionString = CS
        'data1(1).RecordSource = "spGetPOsAlpha"
        'data1(1).Enabled = True
        'data1(1).Refresh

    End Sub

    Private Sub frmFindPO_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        GetData()
        ShowCurrent()

    End Sub

    Sub GetData()

        'Screen.MousePointer = 11
        'On Error Resume Next
        'data1(0).Recordset.Close
        'data1(1).Recordset.Close
        'On Error GoTo 0
        'data1(0).Refresh
        'data1(1).Refresh
        'Screen.MousePointer = 0

    End Sub

    Sub ShowCurrent()

        'If Not lstCustNum.BoundText = CStr(CurPO) Then
        '    lstCustNum.BoundText = CStr(CurPO)
        '    lstCustNum_Click
        'End If

    End Sub

    Private Sub frmFindPO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub lstCustNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustNum.SelectedIndexChanged

        If lstCustNum.SelectedValue <> Nothing Then
            If blnNoCLick = False Then
                blnNoCLick = True
                lstCustName.SelectedIndex = lstCustName.FindStringExact(lstCustNum.SelectedValue.ToString)
                lstCustName.SelectedIndex = lstCustName.FindStringExact(lstCustNum.SelectedItem.ToString)
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

    Private Sub lstCustName_DoubleClick(sender As Object, e As EventArgs) Handles lstCustName.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub lstCustNum_DoubleClick(sender As Object, e As EventArgs) Handles lstCustNum.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        Dim frm As Form

        CurPO = lstCustNum.SelectedItem(0)
        For Each frm In My.Application.OpenForms
            ' Alternate way to get "textbox" control list
            ' Dim ctrls() As Control = frm.Controls.Find("TextBox1", True)
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is Label Then
                    If ctl.Name = "lblCurPO" Then
                        ctl.Text = CurPO
                    End If
                End If
            Next
        Next
        'Dim fm As Form
        'CurPO = lstCustNum.BoundText
        'On Error Resume Next
        'For Each fm In Forms
        '    fm.lblCurPO = CurPO
        'Next

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub
End Class