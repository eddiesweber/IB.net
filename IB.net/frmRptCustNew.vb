Option Explicit On
Imports System.ComponentModel
Imports C1.Win.C1Input

Public Class frmRptCustNew

    Dim RunDate(0 To 1) As Date

    Private Sub frmRptCustNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        datDate0.Value = Now
        datDate1.Value = Now

    End Sub

    Private Sub frmRptCustNew_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub datDate0_ValueChanged(sender As Object, e As EventArgs) Handles datDate0.ValueChanged, datDate1.ValueChanged

        Dim D1 As Integer

        'Validate for weekend and get weekday
        If sender.name = "datDate0" Then
            If Not IsDate(datDate0.Value) Then
                RunDate(0) = Nothing
                cmdOK.Enabled = False
                Exit Sub
            End If
            RunDate(0) = CDate(datDate0.Value)
Calc0:
            D1 = GetWeekDay(RunDate(0))
            If D1 = 99 Then
                If DateSpin = 0 Then DateSpin = 1
                RunDate(0) = DateAdd(DateInterval.Day, DateSpin, RunDate(0))
                GoTo Calc0
            End If
            DateSpin = 0
            datDate0.Value = Format(RunDate(0), "short Date")
        Else
            If Not IsDate(datDate1.Value) Then
                RunDate(1) = Nothing
                cmdOK.Enabled = False
                Exit Sub
            End If
            RunDate(1) = CDate(datDate1.Value)
        End If
Calc1:
        D1 = GetWeekDay(RunDate(1))
        If D1 = 99 Then
            If DateSpin = 0 Then DateSpin = 1
            RunDate(1) = DateAdd(DateInterval.Day, DateSpin, RunDate(1))
            GoTo Calc1
        End If
        DateSpin = 0
        datDate1.Value = Format(RunDate(1), "short Date")
        '        If Not IsDate(datDate(Index).Date) Then
        '            RunDate(Index) = 0
        '            cmdOK.Enabled = False
        '            Exit Sub
        '        End If
        '        RunDate(Index) = CDate(datDate(Index).Date)
        'Calc:
        '        D1 = GetWeekDay(RunDate(Index))
        '        If D1 = 99 Then
        '            If DateSpin = 0 Then DateSpin = 1
        '            RunDate(Index) = RunDate(Index) + DateSpin
        '            GoTo Calc
        '        End If
        '        DateSpin = 0
        '        datDate(Index) = Format(RunDate(Index), "MM/DD/YYYY")

    End Sub

    Private Sub chkRpt0_CheckedChanged(sender As Object, e As EventArgs) Handles chkRpt0.CheckedChanged

        If chkRpt0.Checked Or chkRpt1.Checked Or chkRpt2.Checked Or chkRpt3.Checked Or chkRpt4.Checked Or chkRpt5.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

    Private Sub datDate0_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate0.UpDownButtonClick, datDate1.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        'DateSpin = CDate(NewDate) - CDate(datDate(Index).Date)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If chkRpt0.Checked Then
            RunReport1()
        End If

        If chkRpt1.Checked Then
            RunReport2()
        End If

        If chkRpt2.Checked Then
            ' Same as the report above?
            'RunReport3()
            RunReport2()
        End If

        If chkRpt3.Checked Then
            RunReport4()
        End If

        If chkRpt4.Checked Then
            runreport6()
        End If

        If chkFullCust.Checked Then
            runreport5()
        End If

        If chkRpt5.Checked Then
            runreport7()
        End If

OKDone:
        lblStatus1.Text = "Reports completed."

    End Sub

    Sub RunReport1()

        lblStatus1.Text = "Printing New Customers Report"

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustNew.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("DateFrom", datDate0.Value)
            RPT.SetParameterValue("DateTo", datDate1.Value)

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\CustNew.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "DATE1=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "DATE2=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport2()

        lblStatus1.Text = "Printing Anniversary Report"

        MessageBox.Show("This report runs forever and does not have date selection in the report, which field do the date search by?  Exiting...")
        Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustExp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("DateFrom", datDate0.Value)
            RPT.SetParameterValue("DateTo", datDate1.Value)
            RPT.SetParameterValue("ReportTitle", frmMain.Text)

            strLocation = "RRO2-.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\CustExp.rpt"
        '    '.ReportFileName = rptpath & "\CustAnn.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "DATE1=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "DATE2=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Formulas(3) = "TITLE='CONTRACT ANNIVERSARIES'"
        '    .GroupSelectionFormula = "Sum({@ACNT},{CustomerMaster.CUST_NUM})>0"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .Formulas(3) = ""
        '    .GroupSelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport3()

        lblStatus1.Text = "Printing Expiration Report"

        'With RPT
        '    .ReportFileName = RptPath & "\CustExp.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "DATE1=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "DATE2=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Formulas(3) = "TITLE='CONTRACT EXPIRATIONS'"
        '    .GroupSelectionFormula = "Sum({@XCNT},{CustomerMaster.CUST_NUM})>0"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .Formulas(3) = ""
        '    .GroupSelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport4()

        lblStatus1.Text = "Printing Cancelled Customers Report"

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR4-1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustCanc.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR4-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR4-2.1"
            RPT.SetParameterValue("DateFrom", datDate0.Value)
            strLocation = "RR4-2.2"
            RPT.SetParameterValue("DateTo", datDate1.Value)

            strLocation = "RRO4-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport4 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport4", vbOK)
            LogError(Me.Name, "RunReport4", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\CustCanc.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "DATE1=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "DATE2=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub runreport5()

        Result = MessageBox.Show(Me, "This report prints over 2000 pages, are you sure you want to run this?", "Full Customer Report", vbYesNo)
        If Result = DialogResult.No Then
            Exit Sub
        End If

        lblStatus1.Text = "Printing full Customer Report"

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR5-1.0"
            RPT.Load("C:\IB\ReportsCR2016\Custinfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR5-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR5-2.1"
            RPT.SetParameterValue("CustNum", 0)

            strLocation = "RRO5-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport5 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport5", vbOK)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = DataPath & "\Custinfo.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "IsNull({CustomerMaster.CANC_DATE})"
        '    '.Destination = 1
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Public Sub runreport6()

        lblStatus1.Text = "Printing Stop Delivery Report"

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR6-1.0"
            RPT.Load("C:\IB\ReportsCR2016\stopdeliv.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR6-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RRO6-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport6 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport6", vbOK)
            LogError(Me.Name, "RunReport6", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\stopdeliv.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    ' .Formulas(1) = "DATE1=Date(" & Format(RunDate(0), "yyyy,mm,dd") & ")"
        '    '.Formulas(2) = "DATE2=Date(" & Format(RunDate(1), "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Public Sub runreport7()

        lblStatus1.Text = "Printing Recollect Report"

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR7-1.0"
            RPT.Load("C:\IB\ReportsCR2016\recollect.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RRO7-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport7 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport7", vbOK)
            LogError(Me.Name, "RunReport7", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\recollect.rpt"
        '    .Connect = CryCS
        '    ' .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        'End With

    End Sub

    Private Sub cmdView0_Click(sender As Object, e As EventArgs) Handles cmdView0.Click, cmdView6.Click, cmdView5.Click, cmdView4.Click, cmdView3.Click, cmdView2.Click, cmdView1.Click

        Select Case sender.name
            Case "cmdView0"
                frmViewReport.lblReportName.Text = "CustNew.rpt"
                frmViewReport.Show()
            Case "cmdView1", "cmdView2"
                MessageBox.Show("This report runs forever and does not have date selection in the report, which field do the date search by?  Exiting...")
                Exit Sub
                frmViewReport.lblReportName.Text = "CustExp.rpt"
                frmViewReport.Show()
            'Case "cmdView2"
            '    frmViewReport.lblReportName.Text = "CustExp.rpt"
            '    frmViewReport.Show()
            Case "cmdView3"
                frmViewReport.lblReportName.Text = "CustCanc.rpt"
                frmViewReport.Show()
            Case "cmdView4"
                frmViewReport.lblReportName.Text = "CustInfoAll.rpt"
                frmViewReport.Show()
            Case "cmdView5"
                frmViewReport.lblReportName.Text = "stopdeliv.rpt"
                frmViewReport.Show()
            Case "cmdView6"
                frmViewReport.lblReportName.Text = "recollect.rpt"
                frmViewReport.Show()
        End Select

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub
End Class