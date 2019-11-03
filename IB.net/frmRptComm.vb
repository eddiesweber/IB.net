Option Explicit On

Imports System.ComponentModel

Public Class frmRptComm

    Public RunDate(0 To 1) As Date

    Private Sub frmRptComm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        'RunDate(0) = Now - DatePart("d", Now) + 1
        RunDate(0) = DateAdd(DateInterval.Day, ((DatePart("d", Now) * (-1)) + 1), Now())
        RunDate(0) = DateAdd("m", -1, RunDate(0)) '1st of last month

        'RunDate(1) = DateAdd("m", 1, RunDate(0)) - 1
        RunDate(1) = DateAdd(DateInterval.Month, 1, RunDate(0))
        RunDate(1) = DateAdd(DateInterval.Day, -1, RunDate(1))

        datDate0.Value = Format(RunDate(0), "Short Date")
        datDate1.Value = Format(RunDate(1), "Short Date")

    End Sub

    Private Sub frmRptComm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        'Print reports
        'RPT.Destination = 1

        If chkRpt0.Checked Then
            RunReport1()
        End If
        If chkRpt1.Checked Then
            RunReport2
        End If


OKDone:
        lblStatus.Text = "Reports completed."
        lblStatus.Update()

    End Sub

    Private Sub chkRpt0_CheckedChanged(sender As Object, e As EventArgs) Handles chkRpt0.CheckedChanged, chkRpt1.CheckedChanged

        If chkRpt0.Checked Or chkRpt1.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

    Private Sub datDate0_ValueChanged(sender As Object, e As EventArgs) Handles datDate0.ValueChanged, datDate1.ValueChanged

        'Validate for weekend and get weekday
        If sender.name = "datDate0" Then
            If Not IsDate(datDate0.Value) Then
                RunDate(0) = Nothing
                cmdOK.Enabled = False
                Exit Sub
            End If
            RunDate(0) = CDate(datDate0.Value)

            DateSpin = 0
            datDate0.Value = Format(datDate0.Value, "Short Date")
        Else
            If Not IsDate(datDate1.Value) Then
                RunDate(1) = Nothing
                cmdOK.Enabled = False
                Exit Sub
            End If
            RunDate(1) = CDate(datDate1.Value)

            DateSpin = 0
            datDate1.Value = Format(datDate1.Value, "Short Date")
        End If

    End Sub

    Private Sub cmdPreview1_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click, cmdPreview1.Click

        Select Case sender.name
            Case "cmdPreview0"
                frmViewReport.lblReportName.Text = "CommDet.rpt"
                frmViewReport.Show()
            Case "cmdPreview1"
                frmViewReport.lblReportName.Text = "CommSum.rpt"
                frmViewReport.Show()
        End Select


    End Sub

    Sub RunReport1()

        lblStatus.Text = "Printing Commission Detail Report"
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load(RptPath & "CommDet.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR1-2.1"
            RPT.SetParameterValue("StartDate", Format(RunDate(0), "Short Date"))
            strLocation = "RR1-2.2"
            RPT.SetParameterValue("EndDate", Format(RunDate(1), "Short Date"))

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\CommDet.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "STARTDATE=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "ENDDATE=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport2()

        lblStatus.Text = "Printing Commission Summary Report"
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load(RptPath & "CommSum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR2-2.1"
            RPT.SetParameterValue("StartDate", Format(RunDate(0), "Short Date"))
            strLocation = "RR2-2.2"
            RPT.SetParameterValue("EndDate", Format(RunDate(1), "Short Date"))

            strLocation = "RRO2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\CommSum.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "STARTDATE=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "ENDDATE=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .ReportFileName = ""
        'End With

    End Sub


End Class