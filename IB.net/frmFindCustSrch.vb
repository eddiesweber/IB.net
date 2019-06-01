Imports System.ComponentModel

Public Class frmFindCustSrch

    Private Sub frmFindCustSrch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

    End Sub

    Private Sub frmFindCustSrch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        If txtSearch.Text.Trim <> "" Then
            SpGetCustsSrchTableAdapter.Connection.ConnectionString = CS
            SpGetCustsSrchTableAdapter.Fill(DsspGetCustsSrch.spGetCustsSrch, txtSearch.Text)
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        If lstDelName.Items.Count > 0 Then
            CurCust = lstDelName.SelectedValue
            SetLabelOnAllOpenForms(CurCust, "lblCurCust")
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub lstDelName_DoubleClick(sender As Object, e As EventArgs) Handles lstDelName.DoubleClick

        cmdSelect.PerformClick()

    End Sub
End Class