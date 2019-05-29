Option Explicit On

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmViewReport

    'Dim strReportName As String
    'Dim CTableLogInfo As TableLogOnInfo
    'Dim ConnInfo As CrystalDecisions.Shared.ConnectionInfo

    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        'CrystalReportViewer1.BringToFront()

        ' Set database information
        ConnInfo = New CrystalDecisions.Shared.ConnectionInfo
        ConnInfo.ServerName = Server.Trim
        ConnInfo.DatabaseName = DBName.Trim
        ConnInfo.UserID = Username.Trim
        ConnInfo.Password = Password

        Select Case lblReportName.Text
            Case "sohist.rpt"
                sohist()
            Case "deadbeatcust.rpt"
                deadbeatcust()
            Case "Custinfo.rpt"
                CustInfo()
            Case "rptTest.rpt"
                rptTest()
            Case Else
                MessageBox.Show("The report '" & lblReportName.Text & "' does not exist")

                Me.Close()
        End Select

    End Sub

    Private Sub SetDbConnection(ByVal RPT As CrystalDecisions.CrystalReports.Engine.ReportDocument)

        For Each CTable As Table In RPT.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = RPT.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

    End Sub

    Private Sub sohist()

        Dim RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        RPT.Load("C:\IB\ReportsCR2016\sohist.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        SetDbConnection(RPT)

        'RPT.SetParameterValue("CompanyName", frmMain.Text)
        RPT.SetParameterValue("CustNum", CurCust)

        'RPT.PrintToPrinter(1, True, 0, 0)
        CrystalReportViewer1.ReportSource = RPT
        CrystalReportViewer1.Refresh()

        Me.Cursor = Cursors.Default

        'Dim SF As String
        'SF = "{InvoiceHistory.Cust_NUM}=" & CurCust & "and {InvoiceHistory.Money}<>" & 0 & "and {CategoryMaster.SOHist} =true"

        'With RPT
        '    .ReportFileName = RptPath & "\sohist.rpt"
        '    .Connect = CryCS
        '    .SelectionFormula = SF
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .ReportFileName = ""
        'End With


    End Sub

    Private Sub deadbeatcust()

        Dim RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        RPT.Load("C:\IB\ReportsCR2016\deadbeatcust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        SetDbConnection(RPT)

        'RPT.SetParameterValue("CompanyName", frmMain.Text)
        RPT.SetParameterValue("CustNum", CurCust)

        'RPT.PrintToPrinter(1, True, 0, 0)
        CrystalReportViewer1.ReportSource = RPT
        CrystalReportViewer1.Refresh()

        Me.Cursor = Cursors.Default

        'With RPT
        '    .ReportFileName = RptPath & "\deadbeatcust.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    ' .Formulas(1) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{custcopy.Cust # (2)}=" & CurCust
        '    '.SelectionFormula = "{ARCUSTSCOPY2.Cust # (2)}=" & CurCust
        '    '.SelectionFormula = "{custcopy.Cust # (2)}in [" & txtcustnum.Text & "]"
        '    .Action = 1
        '    .Destination = 0
        '    ' .Formulas(0) = ""
        '    ' .Formulas(1) = ""
        '    .ReportF

    End Sub

    Private Sub CustInfo()

        Dim RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        RPT.Load("C:\Reports\CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        SetDbConnection(RPT)

        RPT.SetParameterValue("CompanyName", frmMain.Text)
        RPT.SetParameterValue("CustNum", CurCust)

        RPT.PrintToPrinter(1, True, 0, 0)
        'CrystalReportViewer1.ReportSource = RPT
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

        Dim RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        RPT.Load("C:\Reports\rptTest.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        For Each CTable As Table In RPT.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = RPT.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

        crParameterDiscreteValue.Value = CurCust
        crParameterFieldDefinitions = RPT.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("CustomerNumber")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        'CrystalReportViewer1.ReportSource = RPT
        'CrystalReportViewer1.Refresh()

    End Sub


End Class