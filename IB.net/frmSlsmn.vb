﻿Option Explicit On
Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmSlsmn

    Dim buserchange As Boolean
    Dim rs As ADODB.Recordset

    Private Sub frmSlsmn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        If Dir("frmSlsmmgrdData.xml") <> "" Then
            grdData.LoadLayout("frmSlsmmgrdData.xml")
        End If

        buserchange = False

        SalesmanMasterTableAdapter.Connection.ConnectionString = CS
        SalesmanMasterTableAdapter.Fill(DsSalesmanMaster.SalesmanMaster)

        buserchange = True

    End Sub

    Private Sub frmSlsmn_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdData.SaveLayout("frmSlsmmgrdData.xml")

    End Sub

    Private Sub grdData_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdData.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub grdData_AfterDelete(sender As Object, e As EventArgs) Handles grdData.AfterDelete

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "GDAD1.0"
            grdData.UpdateData()

            strLocation = "GDAD2.0"
            SalesmanMasterTableAdapter.Update(DsSalesmanMaster.SalesmanMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdData_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdData_AfterDelete", vbOK)
            LogError(Me.Name, "grdData_AfterDelete", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub grdData_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles grdData.BeforeColUpdate

        ' Validate fields
        Select Case e.Column.DataColumn.DataField
            Case "FSALESNUM"
                If grdData.Columns("FSALESNUM").Value = "" Then
                    MessageBox.Show(e.Column.Name & " - must have a value")
                    e.Cancel = True
                End If
            Case "FSALESNAME"
                grdData.Columns("FSALESNAME").Value = UCase(grdData.Columns("FSALESNAME").Value)
            Case "ACTIVE"
                grdData.Columns("ACTIVE").Value = 0
        End Select

    End Sub

    Private Sub grdData_AfterColUpdate(sender As Object, e As ColEventArgs) Handles grdData.AfterColUpdate

        Me.Cursor = Cursors.WaitCursor

        strLocation = "GDACU1.0"
        If IsDBNull(grdData.Columns("FSALESNUM").CellValue(grdData.Row)) Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "GDACU2.0"
            grdData.UpdateData()

            strLocation = "GDACU3.0"
            SalesmanMasterTableAdapter.Update(DsSalesmanMaster.SalesmanMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterColUpdate", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_AfterColUpdate", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

End Class