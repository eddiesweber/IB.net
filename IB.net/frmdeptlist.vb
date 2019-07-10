Public Class frmdeptlist

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        frmViewReport.lblReportName.Text = "ardept.rpt"
        frmViewReport.Show()

    End Sub

End Class