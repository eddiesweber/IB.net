Imports System.ComponentModel

Public Class frmInvHist

    Private Sub frmInvHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        'GetColWidths Me, TDBGrid1
        If Dir("frmInvHistTDBGrid1.xml") <> "" Then
            TDBGrid1.LoadLayout("frmInvHistTDBGrid1.xml")
        End If

    End Sub

    Private Sub GetData()

        Dim q As String
        Dim inv As Long

        inv = Val(txtInvoice.Text)

        If inv > 0 Then
            ' data1
            SpGetInvoiceHist2TableAdapter.Connection.ConnectionString = CS
            SpGetInvoiceHist2TableAdapter.Fill(DsspGetInvoiceHist2.spGetInvoiceHist2, inv)

            ' data2
            SpGetInvHistHeaderTableAdapter.Connection.ConnectionString = CS
            SpGetInvHistHeaderTableAdapter.Fill(DsspGetInvHistHeader.spGetInvHistHeader, inv)
        End If

    End Sub

    Private Sub frmInvHist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        TDBGrid1.SaveLayout("frmInvHistTDBGrid1.xml")
        SaveWindowPos(Me)

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        'With RPT
        '    .ReportFileName = RptPath & "\invoice_historical.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    '.Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "({INVHISTORYHEADER.INV_NUMBER} = " & Val(txtInvoice) & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub txtInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtInvoice.TextChanged

        'GetData()

    End Sub

    Private Sub txtInvoice_LostFocus(sender As Object, e As EventArgs) Handles txtInvoice.LostFocus

        GetData()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        GetData()

    End Sub

End Class