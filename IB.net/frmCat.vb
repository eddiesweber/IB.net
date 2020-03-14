Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmCat

    Private Sub frmCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intCount As Int16
        Dim intLength As Int16

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FCL1.0"
            'GetWindowPos(Me, 200, 200)

            strLocation = "FCL2.0"
            If Dir("frmCatC1TrueDBGrid1.xml") <> "" Then
                'C1TrueDBGrid1.LoadLayout("frmCatC1TrueDBGrid1.xml")
            End If

            strLocation = "FCL3.0"
            Me.CategoryMasterTableAdapter.Connection.ConnectionString = CS
            Me.CategoryMasterTableAdapter.Fill(Me.DsCategoryMaster.CategoryMaster)

            ' Get field types and set limits
            strLocation = "FCL4.0"
            For intCount = 0 To DsCategoryMaster.CategoryMaster.Columns.Count - 1
                intLength = GetFieldMaxLenght(Me.DsCategoryMaster.CategoryMaster.Columns(intCount).DataType.ToString, Me.DsCategoryMaster.CategoryMaster.Columns(intCount).MaxLength)
                C1TrueDBGrid1.Columns(Me.DsCategoryMaster.CategoryMaster.Columns(intCount).ColumnName).DataWidth = intLength
            Next

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmCat_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmCat_Load", vbOK)
            LogError(Me.Name, "frmCat_Load", strLocation, ex.Message)
        End Try

    End Sub
    Private Sub frmCat_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        C1TrueDBGrid1.SaveLayout("frmCatC1TrueDBGrid1.xml")

    End Sub

    Private Sub C1TrueDBGrid1_OnAddNew(sender As Object, e As EventArgs) Handles C1TrueDBGrid1.OnAddNew

        Try
            Me.Cursor = Cursors.WaitCursor

            ' Set default values and clear nulls for the rest of the fields
            strLocation = "FC_CTDG1.0"
            C1TrueDBGrid1.Columns("VOL_CAT").Value = ""
            C1TrueDBGrid1.Columns("VOL_TITLE").Value = ""
            C1TrueDBGrid1.Columns("REMARKS").Value = ""
            C1TrueDBGrid1.Columns("SALE_CD").Value = ""
            C1TrueDBGrid1.Columns("REVENUE").Value = 0
            C1TrueDBGrid1.Columns("DIST_CODE").Value = ""
            C1TrueDBGrid1.Columns("COMM_CAT").Value = ""
            C1TrueDBGrid1.Columns("SOHist").Value = 0
            C1TrueDBGrid1.Columns("Paper").Value = 0

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

                    strLocation = "FC_CTDGBRCC1.0"
                    If C1TrueDBGrid1.Columns("VOL_CAT").Value = "" Then
                        MessageBox.Show("VOL_CAT" & " - must have a value")
                        e.Cancel = True
                    End If

                    strLocation = "FC_CTDGBRCC2.0"
                    If C1TrueDBGrid1.Columns("SALE_CD").Value = "" Then
                        MessageBox.Show("SALE_CD" & " - must have a value")
                        e.Cancel = True
                    End If

                    strLocation = "FC_CTDGBRCC3.0"
                    If C1TrueDBGrid1.Columns("REVENUE").Value = "" Then
                        MessageBox.Show("REVENUE" & " - must have a value")
                        e.Cancel = True
                    End If

                    strLocation = "FC_CTDGBRCC4.0"
                    C1TrueDBGrid1.Columns("VOL_CAT").Value = UCase(C1TrueDBGrid1.Columns("VOL_CAT").Value)
                    C1TrueDBGrid1.Columns("SALE_CD").Value = UCase(C1TrueDBGrid1.Columns("SALE_CD").Value)
                    C1TrueDBGrid1.Columns("VOL_TITLE").Value = UCase(C1TrueDBGrid1.Columns("VOL_TITLE").Value)
                    C1TrueDBGrid1.Columns("REMARKS").Value = UCase(C1TrueDBGrid1.Columns("REMARKS").Value)
                    C1TrueDBGrid1.Columns("DIST_CODE").Value = UCase(C1TrueDBGrid1.Columns("DIST_CODE").Value)
                    C1TrueDBGrid1.Columns("COMM_CAT").Value = UCase(C1TrueDBGrid1.Columns("COMM_CAT").Value)

                    strLocation = "FC_CTDGBRCC5.0"
                    C1TrueDBGrid1.UpdateData()

                    strLocation = "FC_CTDGBRCC6.0"
                    Me.CategoryMasterTableAdapter.Update(Me.DsCategoryMaster.CategoryMaster)

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

            strLocation = "FC_CTDGAD1.0"
            C1TrueDBGrid1.UpdateData()

            strLocation = "FC_CTDGAD2.0"
            Me.CategoryMasterTableAdapter.Update(Me.DsCategoryMaster.CategoryMaster)

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
    '        Case "VOL_CAT"
    '            If C1TrueDBGrid1.Columns("VOL_CAT").Value = "" Then
    '                MessageBox.Show(e.Column.Name & " - must have a value")
    '                e.Cancel = True
    '            End If
    '            C1TrueDBGrid1.Columns("VOL_CAT").Value = UCase(C1TrueDBGrid1.Columns("VOL_CAT").Value)
    '        Case "SALE_CD"
    '            If C1TrueDBGrid1.Columns("SALE_CD").Value = "" Then
    '                MessageBox.Show(e.Column.Name & " - must have a value")
    '                e.Cancel = True
    '            End If
    '            C1TrueDBGrid1.Columns("SALE_CD").Value = UCase(C1TrueDBGrid1.Columns("SALE_CD").Value)
    '        Case "REVENUE"
    '            If C1TrueDBGrid1.Columns("REVENUE").Value = "" Then
    '                MessageBox.Show(e.Column.Name & " - must have a value")
    '                e.Cancel = True
    '            End If
    '        Case "VOL_TITLE"
    '            C1TrueDBGrid1.Columns("VOL_TITLE").Value = UCase(C1TrueDBGrid1.Columns("VOL_TITLE").Value)
    '        Case "REMARKS"
    '            C1TrueDBGrid1.Columns("REMARKS").Value = UCase(C1TrueDBGrid1.Columns("REMARKS").Value)
    '        Case "DIST_CODE"
    '            C1TrueDBGrid1.Columns("DIST_CODE").Value = UCase(C1TrueDBGrid1.Columns("DIST_CODE").Value)
    '        Case "COMM_CAT"
    '            C1TrueDBGrid1.Columns("COMM_CAT").Value = UCase(C1TrueDBGrid1.Columns("COMM_CAT").Value)
    '    End Select

    'End Sub

    'Private Sub C1TrueDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles C1TrueDBGrid1.AfterColUpdate

    '    Me.Cursor = Cursors.WaitCursor

    '    strLocation = "CTDGACU1.0"
    '    If IsDBNull(C1TrueDBGrid1.Columns("VOL_CAT").CellValue(C1TrueDBGrid1.Row)) Then
    '        Exit Sub
    '    End If

    '    strLocation = "CTDGACU2.0"
    '    If IsDBNull(C1TrueDBGrid1.Columns("SALE_CD").CellValue(C1TrueDBGrid1.Row)) Then
    '        Exit Sub
    '    End If

    '    strLocation = "CTDGACU3.0"
    '    If IsDBNull(C1TrueDBGrid1.Columns("REVENUE").CellValue(C1TrueDBGrid1.Row)) Then
    '        Exit Sub
    '    End If

    '    Try
    '        strLocation = "CTDGACU4.0"
    '        C1TrueDBGrid1.UpdateData()

    '        strLocation = "CTDGACU5.0"
    '        CategoryMasterTableAdapter.Update(DsCategoryMaster.CategoryMaster)
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine C1TrueDBGrid1_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "C1TrueDBGrid1_AfterColUpdate", vbOK)
    '        LogError(Me.Name, "C1TrueDBGrid1_AfterColUpdate", strLocation, ex.Message)
    '    End Try

    '    Me.Cursor = Cursors.Default

    'End Sub

End Class