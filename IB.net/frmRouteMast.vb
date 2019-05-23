Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmRouteMast

    Private Sub frmRouteMast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        strLocation = "FRML1.0"
        GetWindowPos(Me, 200, 200)

        If Dir("frmRouteMastC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmRouteMastC1TrueDBGrid1.xml")
        End If

        Try
            strLocation = "FRML2.0"
            Me.RouteMasterTableAdapter.Connection.ConnectionString = CS
            Me.RouteMasterTableAdapter.Fill(Me.DsRouteMaster.RouteMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmRouteMast_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmRouteMast_Load", vbOK)
            LogError(Me.Name, "frmRouteMast_Load", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

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

        Me.Cursor = Cursors.WaitCursor

        strLocation = "CTDGACU1.0"
        If IsDBNull(C1TrueDBGrid1.Columns("Route").CellValue(C1TrueDBGrid1.Row)) Then
            Exit Sub
        End If

        Try
            strLocation = "CTDGACU2.0"
            C1TrueDBGrid1.UpdateData()
            RouteMasterTableAdapter.Update(DsRouteMaster.RouteMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterColUpdate", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_AfterColUpdate", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub C1TrueDBGrid1_AfterDelete(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.AfterDelete

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "CTDGAD1.0"
            C1TrueDBGrid1.UpdateData()

            strLocation = "CTDGAD2.0"
            RouteMasterTableAdapter.Update(DsRouteMaster.RouteMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterDelete", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_AfterDelete", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

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