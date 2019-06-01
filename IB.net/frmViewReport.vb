Option Explicit On

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmViewReport

    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case lblReportName.Text
            Case "sohist.rpt"
                sohist()
            Case "deadbeatcust.rpt"
                deadbeatcust()
            Case "Custinfo.rpt"
                CustInfo()
            Case "zipreport.rpt"
                zipreport()
            Case "invoice_historical.rpt"
                invoice_historical()
            Case Else
                MessageBox.Show("The report '" & lblReportName.Text & "' does not exist")

                Me.Close()
        End Select

    End Sub

    Private Sub invoice_historical()

        Try
            strLocation = "IH1.0"
            RPT.Load("C:\IB\ReportsCR2016\invoice_historical.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "IH2.0"
            RPT.SetParameterValue("InvoiceNumber", frmInvHist.txtInvoice.Text)

            strLocation = "IH3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine invoice_historical (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "invoice_historical", vbOK)
            LogError(Me.Name, "invoice_historical", strLocation, ex.Message)
        End Try

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
    Private Sub zipreport()

        Try
            strLocation = "ZR1.0"
            RPT.Load("C:\IB\ReportsCR2016\zipreport.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "ZR2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            If frmZipSearch.optZip.Checked = True Then
                strLocation = "ZR3.0"
                RPT.SetParameterValue("byCity", "NO")
                RPT.SetParameterValue("SearchField", frmZipSearch.txtZip.Text)
            Else
                strLocation = "ZR4.0"
                RPT.SetParameterValue("byCity", "YES")
                RPT.SetParameterValue("SearchField", UCase(frmZipSearch.txtZip.Text))
            End If

            strLocation = "ZR5.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine zipreport (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "zipreport", vbOK)
            LogError(Me.Name, "zipreport", strLocation, ex.Message)
        End Try

    End Sub
    Private Sub sohist()

        Try
            strLocation = "SH1.0"
            RPT.Load("C:\IB\ReportsCR2016\sohist.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "SH2.0"
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "SH3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine sohist (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "sohist", vbOK)
            LogError(Me.Name, "sohist", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub deadbeatcust()

        Try
            strLocation = "DBC1.0"
            RPT.Load("C:\IB\ReportsCR2016\deadbeatcust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "DBC2.0"
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "DBC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine deadbeatcust (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "deadbeatcust", vbOK)
            LogError(Me.Name, "deadbeatcust", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CustInfo()

        Try
            strLocation = "CI1.0"
            RPT.Load("C:\Reports\CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "CI2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "CI3.0"
            RPT.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustInfo (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustInfo", vbOK)
            LogError(Me.Name, "CustInfo", strLocation, ex.Message)
        End Try

    End Sub

    'Private Sub rptTest()

    ' This also works, but I like to format above.  
    ' Keeping just incase needed

    '    RPT.Load("C:\Reports\rptTest.rpt")

    '    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    '    Dim crParameterFieldDefinition As ParameterFieldDefinition
    '    Dim crParameterValues As New ParameterValues
    '    Dim crParameterDiscreteValue As New ParameterDiscreteValue

    '    For Each CTable As Table In RPT.Database.Tables
    '        CTable.LogOnInfo.ConnectionInfo = ConnInfo
    '        CTableLogInfo = CTable.LogOnInfo
    '        CTableLogInfo.ReportName = RPT.Name
    '        CTableLogInfo.TableName = CTable.Name
    '        CTable.ApplyLogOnInfo(CTableLogInfo)
    '    Next

    '    crParameterDiscreteValue.Value = CurCust
    '    crParameterFieldDefinitions = RPT.DataDefinition.ParameterFields
    '    crParameterFieldDefinition = crParameterFieldDefinitions.Item("CustomerNumber")
    '    crParameterValues = crParameterFieldDefinition.CurrentValues

    '    crParameterValues.Clear()
    '    crParameterValues.Add(crParameterDiscreteValue)
    '    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    '    'CrystalReportViewer1.ReportSource = RPT
    '    'CrystalReportViewer1.Refresh()

    'End Sub


End Class