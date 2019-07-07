Public Class frmmiscrpt

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click

        If optMonthlyitem.Checked = True Then
            cmdItemActivity.PerformClick()
        End If

        If optCurrentPeriod.Checked = True Then
            cmdYtd.PerformClick()
        End If

        If optPriorperiod.Checked = True Then
            cmdLytd.PerformClick()
        End If

        If optNewpaper.Checked = True Then
            Command1.PerformClick()
        End If

        If optSca.Checked = True Then
            cmdDisrpt.PerformClick()
        End If

    End Sub

    Private Sub cmdDisrpt_Click(sender As Object, e As EventArgs) Handles cmdDisrpt.Click

        frmViewReport.lblReportName.Text = "monthly_dispenser.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click

        frmViewReport.lblReportName.Text = "New_Paper.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdLytd_Click(sender As Object, e As EventArgs) Handles cmdLytd.Click

        frmViewReport.lblReportName.Text = "lytdcomp.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdYtd_Click(sender As Object, e As EventArgs) Handles cmdYtd.Click

        frmViewReport.lblReportName.Text = "ytdcomp.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdItemActivity_Click(sender As Object, e As EventArgs) Handles cmdItemActivity.Click

        If Val(txtItemNumOpt.Text) > 0 Then
            frmViewReport.lblReportName.Text = "monthlyitem.rpt"
            frmViewReport.Show()
        Else
            MessageBox.Show("Please enter an Item Number")
        End If

    End Sub

    Private Sub Command4_Click(sender As Object, e As EventArgs) Handles Command4.Click

        Command2.PerformClick()

    End Sub

    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click

        'With RPT
        '    .ReportFileName = RptPath & "\all customers for bobm.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    If Option1 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.DEL_NAME}"
        '        .SortFields(1) = "+{all customer report for bobm.CUST_NUM}"
        '    ElseIf Option2 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.MINIM_00}"
        '        .SortFields(1) = "+{all customer report for bobm.DEL_CITY}"
        '    ElseIf Option3 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.DEL_CITY}"
        '        .SortFields(1) = "+{all customer report for bobm.CUST_NUM}"
        '    ElseIf Option4 = True Then
        '        .SortFields(0) = "+{@AWPR}"
        '        .SortFields(1) = "+{all customer report for bobm.DEL_CITY}"
        '    End If
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub
End Class