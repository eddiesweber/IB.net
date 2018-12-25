Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmRouteMast

    Dim buserchange As Boolean
    Dim rs As ADODB.Recordset

    Private Sub frmRouteMast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Screen Position
        GetWindowPos(Me, 200, 200)

        If Dir("frmRouteMastC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmRouteMastC1TrueDBGrid1.xml")
        End If

        buserchange = False

        Me.RouteMasterTableAdapter.Connection.ConnectionString = CS
        Me.RouteMasterTableAdapter.Fill(Me.DsRouteMaster.RouteMaster)

        buserchange = True

    End Sub

    Private Sub frmRouteMast_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        C1TrueDBGrid1.SaveLayout("frmRouteMastC1TrueDBGrid1.xml")

    End Sub

    Private Sub C1TrueDBGrid1_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1TrueDBGrid1.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

End Class