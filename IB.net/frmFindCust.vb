'Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmFindCust

    Public intCustNum(2500) As Integer
    Public strCustName(2500) As String
    Dim Result As DialogResult
    Dim blnNoCLick As Boolean = False

    Private Sub frmFindCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)
        Me.Show()

        GetData()

    End Sub

    Private Sub GetData()

        SpGetCustsNumTableAdapter.Connection.ConnectionString = CS
        SpGetCustsNumTableAdapter.Fill(Me.DsspGetCustsNum.SpGetCustsNum)

        SpGetCustsAlphaTableAdapter.Connection.ConnectionString = CS
        SpGetCustsAlphaTableAdapter.Fill(Me.DsspGetCustsAlpha.SpGetCustsAlpha)

        lstCustNum.SelectedIndex = 0
        lstCustName.SelectedIndex = 0
        If CurCust > 0 Then
            lstCustNum.SelectedIndex = lstCustNum.FindStringExact(CurCust)
        End If

    End Sub

    Private Sub lstCustNum_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstCustNum.SelectedIndexChanged

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

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        Dim frm As Form

        CurCust = CType(lstCustNum.SelectedItem(0), Long)
        For Each frm In My.Application.OpenForms
            ' Alternate way to get "textbox" control list
            ' Dim ctrls() As Control = frm.Controls.Find("TextBox1", True)
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is Label Then
                    If ctl.Name = "lblCurCust" Then
                        ctl.Text = CurCust
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

    Private Sub lstCustNum_DoubleClick(sender As Object, e As EventArgs) Handles lstCustNum.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub lstCustName_DoubleClick(sender As Object, e As EventArgs) Handles lstCustName.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub frmFindCust_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub frmFindCust_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        SaveWindowPos(Me)

    End Sub

    Private Sub frmFindCust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        SaveWindowPos(Me)

    End Sub
End Class