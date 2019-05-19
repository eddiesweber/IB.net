Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmViewReport

    Dim strReportName As String
    Dim CTableLogInfo As TableLogOnInfo
    Dim ConnInfo As CrystalDecisions.Shared.ConnectionInfo

    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        'CrystalReportViewer1.BringToFront()

        ' Set database information
        ConnInfo = New CrystalDecisions.Shared.ConnectionInfo
        ConnInfo.ServerName = Server.Trim
        ConnInfo.DatabaseName = DBName.Trim
        ConnInfo.UserID = Username.Trim
        ConnInfo.Password = Password

        Select Case lblReportName.Text
            Case "rptTest.rpt"
                rptTest()
            Case "Custinfo.rpt"
                CustInfo()
            Case Else
                MessageBox.Show("The report '" & strReportName & "' does not exist")

                Me.Close()
        End Select


    End Sub

    Private Sub SetDbConnection(ByVal rptCrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)

        For Each CTable As Table In rptCrxReport.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = rptCrxReport.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

    End Sub

    Private Sub CustInfo()

        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Reports\CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        SetDbConnection(cryRpt)

        cryRpt.SetParameterValue("CompanyName", frmMain.Text)
        cryRpt.SetParameterValue("CustNum", CurCust)

        cryRpt.PrintToPrinter(1, True, 0, 0)
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()

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

    End Sub

    Private Sub rptTest()

        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Reports\rptTest.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        For Each CTable As Table In cryRpt.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = cryRpt.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

        crParameterDiscreteValue.Value = CurCust
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("CustomerNumber")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()

    End Sub


End Class