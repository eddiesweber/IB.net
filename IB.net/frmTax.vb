Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmTax

    Dim rs As ADODB.Recordset

    Private Sub frmTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 22)

        If Dir("frmTaxC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmTaxC1TrueDBGrid1.xml")
        End If

        Try
            Me.TaxMasterTableAdapter.Connection.ConnectionString = CS
            Me.TaxMasterTableAdapter.Fill(Me.DsTaxMaster.TaxMaster)
        Catch ex As Exception
            LogError(Me.Name, "Load", "1.0", ex.Message)
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub frmTax_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        C1TrueDBGrid1.SaveLayout("frmTaxC1TrueDBGrid1.xml")

    End Sub

    Private Sub C1TrueDBGrid1_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1TrueDBGrid1.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub C1TrueDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles C1TrueDBGrid1.AfterColUpdate

        If IsDBNull(C1TrueDBGrid1.Columns("LOCAL_CODE").CellValue(C1TrueDBGrid1.Row)) Then
            Exit Sub
        End If

        Try
            C1TrueDBGrid1.UpdateData()
            TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)
        Catch ex As Exception
            LogError(Me.Name, "C1Truedbgrid1_AfterColUpdate", "1.0", ex.Message)
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub C1TrueDBGrid1_AfterDelete(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.AfterDelete

        Try
            C1TrueDBGrid1.UpdateData()
            TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)
        Catch ex As Exception
            LogError(Me.Name, "C1Truedbgrid1_AfterDelete", "1.0", ex.Message)
            MessageBox.Show(ex.Message, "Error deleting record")
        End Try

    End Sub

    Private Sub C1TrueDBGrid1_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles C1TrueDBGrid1.BeforeColUpdate

        ' Validate fields
        Select Case e.Column.DataColumn.DataField
            Case "LOCAL_CODE"
                If C1TrueDBGrid1.Columns("LOCAL_CODE").Value = "" Then
                    MessageBox.Show(e.Column.Name & " - must have a value")
                    e.Cancel = True
                End If
            Case "TAX_STATE"
                C1TrueDBGrid1.Columns("TAX_STATE").Value = UCase(C1TrueDBGrid1.Columns("TAX_STATE").Value)
            Case "COUNTY"
                C1TrueDBGrid1.Columns("COUNTY").Value = UCase(C1TrueDBGrid1.Columns("COUNTY").Value)
            Case "COMMUNITY"
                C1TrueDBGrid1.Columns("COMMUNITY").Value = UCase(C1TrueDBGrid1.Columns("COMMUNITY").Value)
        End Select

    End Sub

End Class