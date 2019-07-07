Public Class frmsalestaxreports


    Private Sub cmdExit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Private Sub cmdFullReport_Click(sender As Object, e As EventArgs) Handles cmdFullReport.Click

        FULLREPORT()

    End Sub

    Public Sub FULLREPORT()

        frmViewReport.lblReportName.Text = "salestaxsql.rpt"
        frmViewReport.Show()

    End Sub

    Public Sub SUMMARYREPORT()

        'With RPT
        '    .ReportFileName = RptPath & "\SALESTAXSUMA.rpt"
        '    .DataFiles(0) = DB.Name
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

End Class