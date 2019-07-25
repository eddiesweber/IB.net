Option Explicit On

Imports System.ComponentModel

Public Class frmRouteRpt

    Public SF As String

    Private Sub frmRouteRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

    End Sub

    Private Sub frmRouteRpt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim SO As String

        'Selection Formula
        If optRoute1.Checked Then
            If Val(txtRoute.Text) > 0 Then
                SF = txtRoute.Text
            Else
                MessageBox.Show("Please enter a Route")
                Exit Sub
            End If
        Else
            SF = "0"
        End If

        If optSort0.Checked Then
            SO = "Route.rpt"
        Else
            SO = "Route2.rpt"
        End If

        'Destination
        If chkPreview.Checked Then
            If txtSummary.Checked = False Then
                strLocation = "CO1.0"
                frmViewReport.lblReportName.Text = SO
                frmViewReport.Show()
            End If

            strLocation = "CO2.0"
            frmViewReport.lblReportName.Text = SO
            frmViewReport.Show()
        Else
            If txtSummary.Checked = False Then
                Try
                    Me.Cursor = Cursors.WaitCursor

                    strLocation = "CO3.0"
                    RPT.Load("C:\IB\ReportsCR2016\routesum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    setCrystalPrinter()
                    SetDbConnection()

                    strLocation = "CO4.0"
                    RPT.SetParameterValue("CompanyName", frmMain.Text)
                    strLocation = "CO4.1"
                    RPT.SetParameterValue("Route", Val(SF))

                    strLocation = "CO5.0"
                    RPT.PrintToPrinter(1, True, 0, 0)

                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                    LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
                End Try

                'With RPT
                '    .ReportFileName = RptPath & "\" & SO
                '    .Connect = CryCS
                '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
                '    .SelectionFormula = SF
                '    .Action = 1
                '    .Formulas(0) = ""
                '    .SelectionFormula = ""
                '    .ReportFileName = ""
                'End With
            End If

            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "CO6.0"
                RPT.Load("C:\IB\ReportsCR2016\routesum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                setCrystalPrinter()
                SetDbConnection()

                strLocation = "CO7.0"
                RPT.SetParameterValue("CompanyName", frmMain.Text)
                strLocation = "CO7.1"
                RPT.SetParameterValue("Route", Val(SF))

                strLocation = "CO8.0"
                RPT.PrintToPrinter(1, True, 0, 0)

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
            End Try
            'With RPT
            '    .ReportFileName = RptPath & "\" & "routesum.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .SelectionFormula = SF
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub txtRoute_TextChanged(sender As Object, e As EventArgs) Handles txtRoute.TextChanged

        If Val(txtRoute.Text) > 0 Then
            optRoute1.Checked = True
        Else
            optRoute0.Checked = True
        End If

        cmdOK.Enabled = True

    End Sub

    Private Sub optRoute0_CheckedChanged(sender As Object, e As EventArgs) Handles optRoute0.CheckedChanged

        If Val(txtRoute.Text) > 0 Or optRoute0.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

End Class