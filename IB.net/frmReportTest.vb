Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReportTest

    Private Sub frmReportTest_Load(sender As Object, e As EventArgs) Handles Me.Load


        'Dim CrxReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'Dim strReportName As String
        'Dim reportDesc As String = "This is the report NameOf"

        'strReportName = "C:\Reports\rptTest.rpt"
        ''strReportName = "C:\Users\eddie.IBEDDIE\source\repos\IB.net\IB.net\bin\Debug\Custinfo.rpt"
        'CrxReport.Load(strReportName, CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'Dim param1Fields As New ParameterFields
        'Dim param1Field As New ParameterField
        'Dim param1Range As New ParameterDiscreteValue

        'param1Field.ParameterFieldName = "CustomerNumber"
        ''param1Field.ParameterFieldName = "CustNum"
        'param1Range.Value = CurCust
        'param1Field.CurrentValues.Add(param1Range)
        'param1Fields.Add(param1Field)

        'CrystalReportViewer1.ReportSource = CrxReport
        'CrystalReportViewer1.Refresh()


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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