Public Class frmitemreports

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "CPC1.0"
            If optNumeric.Checked = True Then
                RPT.Load("C:\IB\ReportsCR2016\itemsbynum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            Else
                RPT.Load("C:\IB\ReportsCR2016\itemsbyalpha.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            End If

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "CPC2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "CPC3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine cmdPrint_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdPrint_Click", vbOK)
            LogError(Me.Name, "cmdPrint_Click", strLocation, ex.Message)
        End Try

        'With RPT
        '    If optNumeric = True Then
        '        .ReportFileName = RptPath & "\itemsbynum.rpt"
        '    Else
        '        .ReportFileName = RptPath & "\itemsbyalpha.rpt"
        '    End If

        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Destination = 1
        '    .Action = 1
        '    .ReportFileName = ""
        '    .Formulas(0) = ""
        'End With

    End Sub

End Class