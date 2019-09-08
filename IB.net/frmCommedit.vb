Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Data.SqlClient

Public Class frmCommEdit

    Dim CurSales As String
    Dim RunDate0 As Date
    Dim RunDate1 As Date
    Dim blnNoClick As Boolean = True

    Private Sub frmCommEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        blnNoClick = True

        GetWindowPos(Me, 66, 66)

        If Dir("frmCommEditTDBGrid1.xml") <> "" Then
            TDBGrid1.LoadLayout("frmCommEditTDBGrid1.xml")
        End If

        SpGetSalesmenTableAdapter.Connection.ConnectionString = CS
        SpGetSalesmenTableAdapter.Fill(Me.DsspGetSalesmen.spGetSalesmen)

        'RunDate(0) = Now - DatePart("d", Now) + 1
        RunDate0 = DateAdd(DateInterval.Day, ((DatePart("d", Now) * (-1)) + 1), Now())
        RunDate0 = DateAdd("m", -1, RunDate0) '1st of last month

        'RunDate(1) = DateAdd("m", 1, RunDate(0)) - 1
        RunDate1 = DateAdd(DateInterval.Month, 1, RunDate0)
        RunDate1 = DateAdd(DateInterval.Day, -1, RunDate1)

        datRange0.Value = Format(RunDate0, "Short Date")
        datRange1.Value = Format(RunDate1, "Short Date")

        If CurCust > 0 Then
            lblCurCust.Text = CurCust
        End If

        GetData()

    End Sub

    Private Sub frmCommEdit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        TDBGrid1.SaveLayout("frmCommEditTDBGrid1.xml")

    End Sub

    Sub GetData()

        Dim strSort As String
        Dim strWhere As String

        Try
            blnNoClick = True
            Me.Cursor = Cursors.WaitCursor

            'q1 = "SELECT Commission.*"
            'q1 = q1 & " FROM Commission"
            'q1 = q1 & " WHERE SALEDATE>='" & datRange0.Value & "' AND SALEDATE<='" & datRange1.Value & "'"
            strLocation = "GD1.0"
            strWhere = "SALEDATE >= '" & datRange0.Value & "' AND SALEDATE <= '" & datRange1.Value & "'"
            If chkAllSales.Checked = False Then
                strWhere = strWhere & " AND FSALESNUM = '" & lstSales.SelectedValue & "'"
            End If
            If chkAllCust.Checked = False And CurCust <> 0 Then
                strWhere = strWhere & " AND CUST_NUM = " & CurCust
            End If

            strSort = ""
            strLocation = "GD2.0"
            If optSort0.Checked Then
                strSort = "FSALESNUM ASC, SALEDATE DESC , SALETYP ASC"
            Else
                strSort = "CUST_NUM ASC, SALEDATE DESC , SALETYP ASC"
            End If

            strLocation = "GD3.0"
            CommissionTableAdapter.Connection.ConnectionString = CS

            If strWhere.Trim() <> "" Then
                strLocation = "GD4.0"
                CommissionBindingSource.Filter = strWhere
            End If

            If strSort.Trim() <> "" Then
                strLocation = "GD5.0"
                CommissionBindingSource.Sort = strSort
            End If

            strLocation = "GD6.0"
            CommissionTableAdapter.Fill(DsCommission.Commission)
            'rs = Data1.Recordset

            blnNoClick = False
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            blnNoClick = False
            Result = MessageBox.Show(Me, "Error in routine GetData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        End Try
    End Sub

    Private Sub chkAllSales_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllSales.CheckedChanged

        If blnNoClick = False Then
            GetData()
        End If

    End Sub

    Private Sub chkAllCust_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllCust.CheckedChanged

        If blnNoClick = False Then
            GetData()
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        blnNoClick = True

        Me.Close()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()

    End Sub

    Private Sub datRange0_ValueChanged(sender As Object, e As EventArgs) Handles datRange0.ValueChanged, datRange1.ValueChanged

        If sender.name = "datRange0" Then
            RunDate0 = CDate(datRange0.Value)
        Else
            RunDate1 = CDate(datRange1.Value)
        End If

        If blnNoClick = False Then
            GetData()
        End If

    End Sub

    Private Sub lblCurCust_Click(sender As Object, e As EventArgs) Handles lblCurCust.Click

        chkAllCust.Checked = False

        GetData()

    End Sub

    Private Sub optSort0_CheckedChanged(sender As Object, e As EventArgs) Handles optSort0.CheckedChanged, optSort1.CheckedChanged

        If blnNoClick = False Then
            GetData()
        End If

    End Sub

    Private Sub TDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles TDBGrid1.AfterColUpdate

        Dim s As String
        Dim q As String
        Dim intRow As Int16

        Try
            strLocation = "TGACU1.0"
            'If e.ColIndex < 2 And TDBGrid1.Columns(0).Text > "" And TDBGrid1.Columns(1).Text > "" Then
            If e.ColIndex < 2 And TDBGrid1.Columns("Sales").Text > "" And TDBGrid1.Columns("Type").Text > "" Then
                'Look up rate
                strLocation = "TGACU1.0"
                's = TDBGrid1.Columns(0).Text
                s = TDBGrid1.Columns("Sales").Text
                If CurSales <> s Then
                    strLocation = "TGACU2.0"
                    CommRateTableAdapter.Connection.ConnectionString = CS
                    CommRateTableAdapter.Fill(DsCommRate.CommRate)
                    'q = "spGetCommRate '" & s & "'"
                    'RRS.Close
                    'RRS.Open q, DB, adOpenStatic

                    CurSales = s
                End If

                strLocation = "TGACU3.0"
                CommRateBindingSource.MoveFirst()
                intRow = CommRateBindingSource.Find("COMM_CAT", TDBGrid1.Columns("Type").Text)
                'RRS.MoveFirst
                'RRS.Find "COMM_CAT='" & TDBGrid1.Columns(1).Text & "'"

                strLocation = "TGACU4.0"
                If intRow > 0 Then
                    TDBGrid1.Columns("Rate").Value = DsCommRate.CommRate.Rows(intRow)("RATE1")
                Else
                    TDBGrid1.Columns("Rate").Value = 0
                End If
                'If RRS.EOF Then
                '    TDBGrid1.Columns("Rate").Value = 0
                'Else
                '    TDBGrid1.Columns("Rate").Value = RRS!RATE1
                'End If
            End If

            strLocation = "TGACU5.0"
            'If e.ColIndex = 3 And TDBGrid1.Columns("Cust").Text > "" Then
            If e.Column.Name = "Cust" And TDBGrid1.Columns("Cust").Text > "" Then
                CurCust = TDBGrid1.Columns("Cust").Value
                q = GetCustName()
                TDBGrid1.Columns("Name").Text = q
            End If

            strLocation = "TGACU6.0"
            If TDBGrid1.Columns("Date").Text = "" Then
                TDBGrid1.Columns("Date").Value = Now()
            End If

            strLocation = "TGACU7.0"
            If TDBGrid1.Columns("Pct %").Text = "" Then
                TDBGrid1.Columns("Pct %").Value = 100
            End If

            strLocation = "TGACU8.0"
            If TDBGrid1.Columns("Invoice").Text = "" Then
                TDBGrid1.Columns("Invoice").Text = "999999"
            End If

            strLocation = "TGACU9.0"
            TDBGrid1.UpdateData()

            strLocation = "TGACU10.0"
            CommissionTableAdapter.Update(DsCommission.Commission)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine TDBGrid1_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "TDBGrid1_AfterColUpdate", vbOK)
            LogError(Me.Name, "TDBGrid1_AfterColUpdate", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub TDBGrid1_BeforeUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles TDBGrid1.BeforeUpdate

        Dim i As Integer

        For i = 0 To 8
            If IsDBNull(TDBGrid1.Columns(i).Text) Or TDBGrid1.Columns(i).Text = "" Then
                MsgBox("All fields must be filled in.", vbOKOnly, "Incomplete Data")
                e.Cancel = True
                Exit Sub
            End If
        Next i

    End Sub

    Private Sub TDBGrid1_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles TDBGrid1.RowColChange

        If TDBGrid1.Col = 4 Then
            TDBGrid1.Col = 5
        End If

    End Sub

    Private Sub lstSales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSales.SelectedIndexChanged

        chkAllSales.Checked = False

        If blnNoClick = False Then
            GetData()
        End If

    End Sub

    Private Sub TDBGrid1_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles TDBGrid1.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub TDBGrid1_AfterDelete(sender As Object, e As EventArgs) Handles TDBGrid1.AfterDelete

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "CTDGAD1.0"
            TDBGrid1.UpdateData()

            strLocation = "CTDGAD2.0"
            CommissionTableAdapter.Update(DsCommission.Commission)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine TDBGrid1_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "TDBGrid1_AfterDelete", vbOK)
            LogError(Me.Name, "TDBGrid1_AfterDelete", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub
End Class