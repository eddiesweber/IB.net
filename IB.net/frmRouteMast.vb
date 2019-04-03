Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmRouteMast

    Dim rs As ADODB.Recordset

    Private Sub frmRouteMast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        If Dir("frmRouteMastC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmRouteMastC1TrueDBGrid1.xml")
        End If

        Try
            Me.RouteMasterTableAdapter.Connection.ConnectionString = CS
            Me.RouteMasterTableAdapter.Fill(Me.DsRouteMaster.RouteMaster)
        Catch ex As Exception
            LogError(Me.Name, "Load", "1.0", ex.Message)
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

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

    Private Sub C1TrueDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles C1TrueDBGrid1.AfterColUpdate

        If IsDBNull(C1TrueDBGrid1.Columns("Route").CellValue(C1TrueDBGrid1.Row)) Then
            Exit Sub
        End If

        Try
            C1TrueDBGrid1.UpdateData()
            RouteMasterTableAdapter.Update(DsRouteMaster.RouteMaster)
        Catch ex As Exception
            LogError(Me.Name, "C1Truedbgrid1_AfterColUpdate", "1.0", ex.Message)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub C1TrueDBGrid1_AfterDelete(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.AfterDelete

        Try
            C1TrueDBGrid1.UpdateData()
            RouteMasterTableAdapter.Update(DsRouteMaster.RouteMaster)
        Catch ex As Exception
            LogError(Me.Name, "C1Truedbgrid1_AfterDelete", "1.0", ex.Message)
            MessageBox.Show(ex.Message, "Error deleting record")
        End Try

    End Sub

    Private Sub C1TrueDBGrid1_OnAddNew(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.OnAddNew

        C1TrueDBGrid1.Columns("labels").Value = 0

    End Sub

    Private Sub C1TrueDBGrid1_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles C1TrueDBGrid1.BeforeColUpdate

        ' Validate fields
        Select Case e.Column.DataColumn.DataField
            Case "Route"
                If C1TrueDBGrid1.Columns("Route").Value = "" Then
                    MessageBox.Show(e.Column.Name & " - must have a value")
                    e.Cancel = True
                End If
        End Select

    End Sub

End Class