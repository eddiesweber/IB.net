Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmRptViewer

    Public strReportName As String

    Private Sub frmRptViewer_Load(sender As Object, e As EventArgs) Handles Me.Load

        'CrystalReportViewer1.BringToFront()

        '' Set database information
        'Select Case lblReportName.Text
        '    Case "Custinfo.rpt"
        '        CustInfo()
        '    Case Else
        '        MessageBox.Show("The report '" & strReportName & "' does not exist")

        '        Me.Close()
        'End Select

    End Sub

    Private Sub CustInfo()

        'Report.Load(System.AppDomain.CurrentDomain.BaseDirectory() & "CustInfo.rpt")

        'Dim dt As New DataTable                     ' THE DATATABLE HAS THE DATA FROM THE DATABASE.
        'Report.SetDataSource(dt)                    ' SET REPORT DATA SOURCE.
        'Report.PrintToPrinter(1, True, 0, 0)        ' FINALY, PRINT IT.

        'With RPT
        '    .ReportFileName = DataPath & "\Custinfo.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{CustomerMaster.CUST_NUM}=" & CStr(CurCust)
        '    .Destination = 1
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Reports\rptTest.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = CurCust
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("CustomerNumber")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()

    End Sub
End Class