Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmTax

    Private Sub frmTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        strLocation = "FTLL1.0"
        GetWindowPos(Me, 200, 22)

        If Dir("frmTaxC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmTaxC1TrueDBGrid1.xml")
        End If

        Try
            strLocation = "FTL2.0"
            Me.TaxMasterTableAdapter.Connection.ConnectionString = CS
            Me.TaxMasterTableAdapter.Fill(Me.DsTaxMaster.TaxMaster)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmTax_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmTax_Load", vbOK)
            LogError(Me.Name, "frmTax_Load", strLocation, ex.Message)
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

        Me.Cursor = Cursors.WaitCursor

        strLocation = "CTDGACU1.0"
        If IsDBNull(C1TrueDBGrid1.Columns("TAX_STATE").CellValue(C1TrueDBGrid1.Row)) Then
            Exit Sub
        End If

        strLocation = "CTDGACU2.0"
        If IsDBNull(C1TrueDBGrid1.Columns("LOCAL_CODE").CellValue(C1TrueDBGrid1.Row)) Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "CTDGACU3.0"
            C1TrueDBGrid1.UpdateData()

            strLocation = "CTDGACU4.0"
            TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)
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
            TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterDelete", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_AfterDelete", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

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