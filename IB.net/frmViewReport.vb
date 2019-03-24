Imports CrystalDecisions.CrystalReports.Engine

Public Class frmViewReport

    Dim strReportName As String

    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Hide the text box since we cannot use it when it is disabled
        txtReportName.Left = Me.Width + 1
        txtReportName.Top = Me.Height + 1

        If txtReportName.Text.Trim <> "" Then
            Dim cryRpt As New ReportDocument

            Try
                'cryRpt.Load("D:\crud_vb_mysql\crud\crud\CrystalReport7.rpt")
                cryRpt.Load(txtReportName.Text.Trim)
                CrystalReportViewer1.ReportSource = cryRpt
                CrystalReportViewer1.Refresh()
            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message)
            End Try
        End If

    End Sub

End Class