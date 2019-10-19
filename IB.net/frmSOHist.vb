Option Explicit On
Imports System.ComponentModel

Public Class frmSOHist

    Dim Startdate As Date

    Private Sub frmSOHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' GetWindowPos Me, 1000, 1000
        GetWindowPos(Me, 66, 66)

        If Dir("frmSOHistC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmSOHistC1TrueDBGrid1.xml")
        End If

        Startdate = DateAdd("yyyy", -1, Now())
        datSince.Value = Startdate

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            lblCurCust.Text = CurCust
        End If

    End Sub

    Private Sub frmSOHist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        C1TrueDBGrid1.SaveLayout("frmSOHistC1TrueDBGrid1.xml")

    End Sub

    Private Sub GetData()

        If IsDate(datSince.Value) And CurCust > 0 Then
            Me.SpGetInvoiceHistTableAdapter.Connection.ConnectionString = CS
            Me.SpGetInvoiceHistTableAdapter.Fill(DsSOHist.spGetInvoiceHist, CurCust, datSince.Value)
        End If

    End Sub

    Private Sub datSince_Click(sender As Object, e As EventArgs) Handles datSince.Click

        datSince_TextChanged(sender, e)

    End Sub

    Private Sub datSince_TextChanged(sender As Object, e As EventArgs) Handles datSince.TextChanged

        Dim NewDate As Date

        If IsDate(datSince.Value) Then
            NewDate = datSince.Value
        End If

        If NewDate <> Startdate Then
            Startdate = NewDate
            GetData()
        End If

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        txtCust.ReadOnly = False
        txtCustName.ReadOnly = False

        txtCust.Text = CStr(CurCust)
        txtCustName.Text = GetCustName()

        txtCust.ReadOnly = True
        txtCustName.ReadOnly = True

    End Sub

    Private Sub txtCust_TextChanged(sender As Object, e As EventArgs) Handles txtCust.TextChanged

        GetData()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub CmdPrint_Click(sender As Object, e As EventArgs) Handles CmdPrint.Click

        frmViewReport.lblReportName.Text = "sohist.rpt"
        frmViewReport.Show()

        '    'Dim SF As String
        '    'SF = "{InvoiceHistory.Cust_NUM}=" & CurCust & "and {InvoiceHistory.Money}<>" & 0 & "and {CategoryMaster.SOHist} =true"

        '    'With RPT
        '    '    .ReportFileName = RptPath & "\sohist.rpt"
        '    '    .Connect = CryCS
        '    '    .SelectionFormula = SF
        '    '    .Action = 1
        '    '    .Formulas(0) = ""
        '    '    .Formulas(1) = ""
        '    '    .ReportFileName = ""
        '    'End With

    End Sub

End Class