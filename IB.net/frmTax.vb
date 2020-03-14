Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmTax

    Private Sub frmTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intCount As Int16
        Dim intLength As Int16

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FT_FTLL1.0"
            'GetWindowPos(Me, 200, 22)

            strLocation = "FT_FTL2.0"
            If Dir("frmTaxC1TrueDBGrid1.xml") <> "" Then
                'C1TrueDBGrid1.LoadLayout("frmTaxC1TrueDBGrid1.xml")
            End If

            strLocation = "FT_FTL3.0"
            Me.TaxMasterTableAdapter.Connection.ConnectionString = CS
            Me.TaxMasterTableAdapter.Fill(Me.DsTaxMaster.TaxMaster)

            ' Get field types and set limits
            strLocation = "FT_FTL4.0"
            For intCount = 0 To Me.DsTaxMaster.TaxMaster.Columns.Count - 1
                intLength = GetFieldMaxLenght(Me.DsTaxMaster.TaxMaster.Columns(intCount).DataType.ToString, Me.DsTaxMaster.TaxMaster.Columns(intCount).MaxLength)
                C1TrueDBGrid1.Columns(Me.DsTaxMaster.TaxMaster.Columns(intCount).ColumnName).DataWidth = intLength
            Next

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

    Private Sub C1TrueDBGrid1_OnAddNew(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.OnAddNew

        Try
            Me.Cursor = Cursors.WaitCursor

            ' Set default values and clear nulls for the rest of the fields
            strLocation = "FT_CTDG1.0"
            C1TrueDBGrid1.Columns("TAX_STATE").Value = ""
            C1TrueDBGrid1.Columns("LOCAL_CODE").Value = ""
            C1TrueDBGrid1.Columns("COUNTY").Value = ""
            C1TrueDBGrid1.Columns("COMMUNITY").Value = ""
            C1TrueDBGrid1.Columns("LOCAL_RATE").Value = 0
            C1TrueDBGrid1.Columns("TOTAL_RATE").Value = 0

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_OnAddNew (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_OnAddNew", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_OnAddNew", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub C1TrueDBGrid1_BeforeRowColChange(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1TrueDBGrid1.BeforeRowColChange

        If C1TrueDBGrid1.Row >= 0 And C1TrueDBGrid1.DestinationRow >= 0 Then
            If C1TrueDBGrid1.Row <> C1TrueDBGrid1.DestinationRow Then
                Try
                    Me.Cursor = Cursors.WaitCursor

                    ' Validate fields
                    strLocation = "FT_CTDGACU1.0"
                    If C1TrueDBGrid1.Columns("TAX_STATE").Value = "" Then
                        MessageBox.Show("TAX_STATE - must have a value")
                        e.Cancel = True
                    End If

                    strLocation = "FT_CTDGACU2.0"
                    If C1TrueDBGrid1.Columns("LOCAL_CODE").Value = "" Then
                        MessageBox.Show("LOCAL_CODE - must have a value")
                        e.Cancel = True
                    End If

                    strLocation = "FT_CTDGACU3.0"
                    C1TrueDBGrid1.Columns("TAX_STATE").Value = UCase(C1TrueDBGrid1.Columns("TAX_STATE").Value)
                    C1TrueDBGrid1.Columns("COUNTY").Value = UCase(C1TrueDBGrid1.Columns("COUNTY").Value)
                    C1TrueDBGrid1.Columns("COMMUNITY").Value = UCase(C1TrueDBGrid1.Columns("COMMUNITY").Value)

                    strLocation = "FT_CTDGACU4.0"
                    C1TrueDBGrid1.UpdateData()

                    strLocation = "FT_CTDGACU5.0"
                    TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)

                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_BeforeRowColChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_BeforeRowColChange", vbOK)
                    LogError(Me.Name, "C1TrueDBGrid1_BeforeRowColChange", strLocation, ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub C1TrueDBGrid1_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1TrueDBGrid1.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub C1TrueDBGrid1_AfterDelete(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.AfterDelete

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FT_CTDGAD1.0"
            C1TrueDBGrid1.UpdateData()

            strLocation = "FT_CTDGAD2.0"
            TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterDelete", vbOK)
            LogError(Me.Name, "C1TrueDBGrid1_AfterDelete", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    'Private Sub C1TrueDBGrid1_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles C1TrueDBGrid1.BeforeColUpdate

    '    ' Validate fields
    '    Select Case e.Column.DataColumn.DataField
    '        Case "LOCAL_CODE"
    '            If C1TrueDBGrid1.Columns("LOCAL_CODE").Value = "" Then
    '                MessageBox.Show(e.Column.Name & " - must have a value")
    '                e.Cancel = True
    '            End If
    '        Case "TAX_STATE"
    '            C1TrueDBGrid1.Columns("TAX_STATE").Value = UCase(C1TrueDBGrid1.Columns("TAX_STATE").Value)
    '        Case "COUNTY"
    '            C1TrueDBGrid1.Columns("COUNTY").Value = UCase(C1TrueDBGrid1.Columns("COUNTY").Value)
    '        Case "COMMUNITY"
    '            C1TrueDBGrid1.Columns("COMMUNITY").Value = UCase(C1TrueDBGrid1.Columns("COMMUNITY").Value)
    '    End Select

    'End Sub

    'Private Sub C1TrueDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles C1TrueDBGrid1.AfterColUpdate

    '    Me.Cursor = Cursors.WaitCursor

    '    strLocation = "CTDGACU1.0"
    '    If IsDBNull(C1TrueDBGrid1.Columns("TAX_STATE").CellValue(C1TrueDBGrid1.Row)) Then
    '        Exit Sub
    '    End If

    '    strLocation = "CTDGACU2.0"
    '    If IsDBNull(C1TrueDBGrid1.Columns("LOCAL_CODE").CellValue(C1TrueDBGrid1.Row)) Then
    '        Exit Sub
    '    End If

    '    Me.Cursor = Cursors.WaitCursor

    '    Try
    '        strLocation = "CTDGACU3.0"
    '        C1TrueDBGrid1.UpdateData()

    '        strLocation = "CTDGACU4.0"
    '        TaxMasterTableAdapter.Update(DsTaxMaster.TaxMaster)
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterColUpdate", vbOK)
    '        LogError(Me.Name, "C1TrueDBGrid1_AfterColUpdate", strLocation, ex.Message)
    '    End Try

    '    Me.Cursor = Cursors.Default

    'End Sub

End Class