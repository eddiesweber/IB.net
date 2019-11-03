Option Explicit On
Imports System.ComponentModel
Imports C1.Win.C1Input

Public Class frmRptExcept

    Dim RunDate As Date

    Private Sub frmRptExcept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        datDate.Value = Now

    End Sub

    Private Sub frmRptExcept_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If chkPreview.Checked Then
            frmViewReport.lblReportName.Text = "Except.rpt"
            frmViewReport.Show()
        Else
            RunReport1()
        End If

    End Sub

    Sub RunReport1()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load(RptPath & "Except.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("StartDate", datDate.Value)

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\Except.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "STARTDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click

        If chkPreview2.Checked Then
            frmViewReport.lblReportName.Text = "NoOrders.rpt"
            frmViewReport.Show()
        Else
            RunReport2()
        End If

    End Sub

    Public Sub RunReport2()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load(RptPath & "NoOrders.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("StartDate", datDate.Value)

            strLocation = "RR2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\NoOrders.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "STARTDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub


    Private Sub datDate_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        ' DateSpin = CDate(NewDate) - CDate(OldDate)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        Dim D1 As Integer

        'Validate for weekend and get weekday
        If Not IsDate(datDate.Value) Then
            RunDate = Nothing
            cmdOK.Enabled = False

            Exit Sub
        End If
        RunDate = CDate(datDate.Value)
Calc:
        D1 = GetWeekDay(RunDate)
        If D1 = 99 Then
            If DateSpin = 0 Then
                DateSpin = 1
            End If
            RunDate = DateAdd(DateInterval.Day, DateSpin, RunDate)
            GoTo Calc
        End If

        DateSpin = 0
        datDate.Value = Format(RunDate, "Short Date")

    End Sub

End Class