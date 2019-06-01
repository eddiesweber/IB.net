Imports System.ComponentModel

Public Class frmZipSearch

    Private Sub frmZipSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

    End Sub

    Private Sub frmZipSearch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        frmViewReport.lblReportName.Text = "zipreport.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub optZip_CheckedChanged(sender As Object, e As EventArgs) Handles optZip.CheckedChanged

        If optCity.Checked = False Then
            lblCityorZip.Text = "PLEASE ENTER ZIP BELOW"
        End If

    End Sub

    Private Sub optCity_CheckedChanged(sender As Object, e As EventArgs) Handles optCity.CheckedChanged

        If optCity.Checked = True Then
            lblCityorZip.Text = "PLEASE ENTER CITY BELOW"
        End If

    End Sub

End Class