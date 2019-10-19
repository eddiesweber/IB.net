Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports C1.Win.C1Input

Public Class frmRptDay1

    Dim RunDate As Date
    Dim Stamp As Date
    Dim CoRS As New ADODB.Recordset
    Dim CLRS As New ADODB.Recordset
    Dim SF As String
    Dim blnNoClear1 As Boolean = False
    Dim blnNoClear2 As Boolean = False

    Private Sub frmRptDay1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        GetCalcLog()

        ResetScreen()

    End Sub

    Sub GetCalcLog()

        CalcLogTableAdapter.Connection.ConnectionString = CS
        CalcLogTableAdapter.Fill(DsCalcLogOrderbyRunDate.CalcLog)
        'q = "SELECT * FROM CalcLog ORDER BY RunDate"
        'Call CLRS.Open(q, DB, adOpenDynamic, adLockOptimistic)

    End Sub

    Sub ResetScreen()

        GetCompany()

        'Get first date calculated but not printed
        If DsCalcLogOrderbyRunDate.CalcLog.Rows.Count = 0 Then
            MessageBox.Show("No dates have been calculated.")
            RunDate = Nothing
            Me.Close()
        End If
        'If CLRS.RecordCount = 0 Then
        '    MsgBox("No dates have been calculated.")
        '    Unload Me
        'End If

        CalcLogBindingSource.MoveLast()
        Do While CalcLogBindingSource.Position > 0
            If Not IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) Then
                If IsDate(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) Then
                    Exit Do
                End If
            End If
            CalcLogBindingSource.MovePrevious()
        Loop
        'CLRS.MoveLast()
        'CLRS.Find "PrintDate>'1/1/1900'", 0, adSearchBackward

        If CalcLogBindingSource.Position < 0 Then
            CalcLogBindingSource.MoveFirst()
        Else
            If CalcLogBindingSource.Position < DsCalcLogOrderbyRunDate.CalcLog.Rows.Count - 1 Then
                CalcLogBindingSource.MoveNext()
            End If
        End If
        'If CLRS.BOF Then
        '    CLRS.MoveFirst()
        'Else
        '    CLRS.MoveNext()
        '    If CLRS.EOF Then CLRS.MoveLast()
        'End If

        CurDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("RunDate")

        'Set date control
        RunDate = CurDate
        datDate.Value = Format(RunDate, "Short Date")
        'datDate_Change

    End Sub

    Sub GetCompany()

        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_CompanyID.Company, Company)
        'q = "Select * From Company where COMPANY_ID='" & Company & "'"
        'Call CoRS.Open(q, DB, adOpenStatic)

    End Sub

    Sub RunReport1()

        lblStatus.Text = "Printing Tripsheet..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\trip.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR1-2.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR1-2.2"
            If IsNumeric(txtRoute0.Text) Then
                RPT.SetParameterValue("Route0", Val(txtRoute0.Text))
            Else
                RPT.SetParameterValue("Route0", 0)
            End If
            strLocation = "RR1-2.3"
            If IsNumeric(txtRoute1.Text) Then
                RPT.SetParameterValue("Route1", Val(txtRoute1.Text))
            Else
                RPT.SetParameterValue("Route1", 0)
            End If
            strLocation = "RR1-2.4"
            If IsNumeric(txtRoute2.Text) Then
                RPT.SetParameterValue("Route2", Val(txtRoute2.Text))
            Else
                RPT.SetParameterValue("Route2", 0)
            End If
            strLocation = "RR1-2.5"
            If IsNumeric(txtRoute3.Text) Then
                RPT.SetParameterValue("Route3", Val(txtRoute3.Text))
            Else
                RPT.SetParameterValue("Route3", 0)
            End If
            strLocation = "RR1-2.6"
            If IsNumeric(txtRoute4.Text) Then
                RPT.SetParameterValue("Route4", Val(txtRoute4.Text))
            Else
                RPT.SetParameterValue("Route4", 0)
            End If
            strLocation = "RR1-2.7"
            If IsNumeric(txtRoute5.Text) Then
                RPT.SetParameterValue("Route5", Val(txtRoute5.Text))
            Else
                RPT.SetParameterValue("Route5", 0)
            End If

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\trip.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
        '    .SelectionFormula = SF
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()


    End Sub

    Sub RunReport2()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load("C:\IB\ReportsCR2016\triprec.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR2-2.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR2-2.2"
            If IsNumeric(txtRoute0.Text) Then
                RPT.SetParameterValue("Route0", Val(txtRoute0.Text))
            Else
                RPT.SetParameterValue("Route0", 0)
            End If
            strLocation = "RR2-2.3"
            If IsNumeric(txtRoute1.Text) Then
                RPT.SetParameterValue("Route1", Val(txtRoute1.Text))
            Else
                RPT.SetParameterValue("Route1", 0)
            End If
            strLocation = "RR2-2.4"
            If IsNumeric(txtRoute2.Text) Then
                RPT.SetParameterValue("Route2", Val(txtRoute2.Text))
            Else
                RPT.SetParameterValue("Route2", 0)
            End If
            strLocation = "RR2-2.5"
            If IsNumeric(txtRoute3.Text) Then
                RPT.SetParameterValue("Route3", Val(txtRoute3.Text))
            Else
                RPT.SetParameterValue("Route3", 0)
            End If
            strLocation = "RR2-2.6"
            If IsNumeric(txtRoute4.Text) Then
                RPT.SetParameterValue("Route4", Val(txtRoute4.Text))
            Else
                RPT.SetParameterValue("Route4", 0)
            End If
            strLocation = "RR2-2.7"
            If IsNumeric(txtRoute5.Text) Then
                RPT.SetParameterValue("Route5", Val(txtRoute5.Text))
            Else
                RPT.SetParameterValue("Route5", 0)
            End If

            strLocation = "RR2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\triprec.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
        '    .Formulas(2) = "TITLE='TRIPSHEET RECAP'"
        '    .SelectionFormula = SF
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport3()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR3-1.0"
            RPT.Load("C:\IB\ReportsCR2016\load.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR3-2.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR3-2.2"
            If IsNumeric(txtRoute0.Text) Then
                RPT.SetParameterValue("Route0", Val(txtRoute0.Text))
            Else
                RPT.SetParameterValue("Route0", 0)
            End If
            strLocation = "RR3-2.3"
            If IsNumeric(txtRoute1.Text) Then
                RPT.SetParameterValue("Route1", Val(txtRoute1.Text))
            Else
                RPT.SetParameterValue("Route1", 0)
            End If
            strLocation = "RR3-2.4"
            If IsNumeric(txtRoute2.Text) Then
                RPT.SetParameterValue("Route2", Val(txtRoute2.Text))
            Else
                RPT.SetParameterValue("Route2", 0)
            End If
            strLocation = "RR3-2.5"
            If IsNumeric(txtRoute3.Text) Then
                RPT.SetParameterValue("Route3", Val(txtRoute3.Text))
            Else
                RPT.SetParameterValue("Route3", 0)
            End If
            strLocation = "RR2-2.6"
            If IsNumeric(txtRoute4.Text) Then
                RPT.SetParameterValue("Route4", Val(txtRoute4.Text))
            Else
                RPT.SetParameterValue("Route4", 0)
            End If
            strLocation = "RR3-2.7"
            If IsNumeric(txtRoute5.Text) Then
                RPT.SetParameterValue("Route5", Val(txtRoute5.Text))
            Else
                RPT.SetParameterValue("Route5", 0)
            End If

            strLocation = "RR3-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\load.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Formulas(2) = ""
            '    .SelectionFormula = SF
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            strLocation = "RR3-4.0"
            RPT.Load("C:\IB\ReportsCR2016\load1.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-5.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR3-5.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR3-5.2"
            If IsNumeric(txtRoute0.Text) Then
                RPT.SetParameterValue("Route0", Val(txtRoute0.Text))
            Else
                RPT.SetParameterValue("Route0", 0)
            End If
            strLocation = "RR3-5.3"
            If IsNumeric(txtRoute1.Text) Then
                RPT.SetParameterValue("Route1", Val(txtRoute1.Text))
            Else
                RPT.SetParameterValue("Route1", 0)
            End If
            strLocation = "RR3-5.4"
            If IsNumeric(txtRoute2.Text) Then
                RPT.SetParameterValue("Route2", Val(txtRoute2.Text))
            Else
                RPT.SetParameterValue("Route2", 0)
            End If
            strLocation = "RR3-5.5"
            If IsNumeric(txtRoute3.Text) Then
                RPT.SetParameterValue("Route3", Val(txtRoute3.Text))
            Else
                RPT.SetParameterValue("Route3", 0)
            End If
            strLocation = "RR2-5.6"
            If IsNumeric(txtRoute4.Text) Then
                RPT.SetParameterValue("Route4", Val(txtRoute4.Text))
            Else
                RPT.SetParameterValue("Route4", 0)
            End If
            strLocation = "RR3-5.7"
            If IsNumeric(txtRoute5.Text) Then
                RPT.SetParameterValue("Route5", Val(txtRoute5.Text))
            Else
                RPT.SetParameterValue("Route5", 0)
            End If

            strLocation = "RR3-6.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\load1.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Formulas(2) = ""
            '    .SelectionFormula = SF
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            strLocation = "RR3-7.0"
            RPT.Load("C:\IB\ReportsCR2016\deex.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-8.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR3-8.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR3-8.2"
            If IsNumeric(txtRoute0.Text) Then
                RPT.SetParameterValue("Route0", Val(txtRoute0.Text))
            Else
                RPT.SetParameterValue("Route0", 0)
            End If
            strLocation = "RR3-8.3"
            If IsNumeric(txtRoute1.Text) Then
                RPT.SetParameterValue("Route1", Val(txtRoute1.Text))
            Else
                RPT.SetParameterValue("Route1", 0)
            End If
            strLocation = "RR3-8.4"
            If IsNumeric(txtRoute2.Text) Then
                RPT.SetParameterValue("Route2", Val(txtRoute2.Text))
            Else
                RPT.SetParameterValue("Route2", 0)
            End If
            strLocation = "RR3-8.5"
            If IsNumeric(txtRoute3.Text) Then
                RPT.SetParameterValue("Route3", Val(txtRoute3.Text))
            Else
                RPT.SetParameterValue("Route3", 0)
            End If
            strLocation = "RR2-8.6"
            If IsNumeric(txtRoute4.Text) Then
                RPT.SetParameterValue("Route4", Val(txtRoute4.Text))
            Else
                RPT.SetParameterValue("Route4", 0)
            End If
            strLocation = "RR3-8.7"
            If IsNumeric(txtRoute5.Text) Then
                RPT.SetParameterValue("Route5", Val(txtRoute5.Text))
            Else
                RPT.SetParameterValue("Route5", 0)
            End If

            strLocation = "RR3-9.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\deex.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Formulas(2) = ""
            '    .SelectionFormula = SF
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport3 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport3", vbOK)
            LogError(Me.Name, "RunReport3", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdPreview0_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click, cmdPreview2.Click, cmdPreview1.Click

        '   ****************************************************************************
        '   * Not needed, can't send formulas to Crystal anymore.  Done with parameters
        '   ****************************************************************************
        'SetSelection()

        'Set preview screen
        'With RPT
        '    .Destination = 0
        '    .WindowTop = 300 / Screen.TwipsPerPixelX
        '    .WindowLeft = 300 / Screen.TwipsPerPixelY
        '    .WindowWidth = (Screen.Width - 600) / Screen.TwipsPerPixelX
        '    .WindowHeight = (Screen.Height - 600) / Screen.TwipsPerPixelY
        'End With

        Select Case sender.name
            Case "cmdPreview0"
                frmViewReport.lblReportName.Text = "trip.rpt"
                frmViewReport.Show()
            Case "cmdPreview1"
                frmViewReport.lblReportName.Text = "triprec.rpt"
                frmViewReport.Show()
            Case "cmdPreview2"
                frmViewReport.lblReportName.Text = "load.rpt"
                frmViewReport.Show()

                Dim frmViewReport2 As New frmViewReport
                frmViewReport2.lblReportName.Text = "load1.rpt"
                frmViewReport2.Show()

                Dim frmViewReport3 As New frmViewReport
                frmViewReport3.lblReportName.Text = "deex.rpt"
                frmViewReport3.Show()
        End Select

    End Sub

    Private Sub chkRpt0_CheckedChanged(sender As Object, e As EventArgs) Handles chkRpt0.CheckedChanged, chkRpt2.CheckedChanged, chkRpt1.CheckedChanged

        If chkRpt0.Checked Or chkRpt1.Checked Or chkRpt2.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        '   ****************************************************************************
        '   * Not needed, can't send formulas to Crystal anymore.  Done with parameters
        '   ****************************************************************************
        'SetSelection()

        'Begin process
        Me.Cursor = Cursors.WaitCursor
        'Me.Enabled = False

        Try
            'Print reports
            strLocation = "COC1.0"
            If chkRpt0.Checked Then
                lblStatus.Text = "Printing Tripsheets..."
                lblStatus.Update()

                RunReport1()

                strLocation = "COC1.1"
                If IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) And optRoute0.Checked Then
                    DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate") = Now()
                    CalcLogTableAdapter.Update(DsCalcLogOrderbyRunDate.CalcLog)
                End If
            End If

            strLocation = "COC2.0"
            If chkRpt1.Checked Then
                lblStatus.Text = "Printing Tripsheet Recap..."
                lblStatus.Update()

                RunReport2()
            End If

            strLocation = "COC3.0"
            If chkRpt2.Checked Then
                lblStatus.Text = "Printing Production Requirements..."
                lblStatus.Update()

                RunReport3()
            End If

            strLocation = "COC4.0"
            lblStatus.Text = "Reports completed."
            lblStatus.Update()

            Me.Cursor = Cursors.Default
            Me.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.Enabled = True
            Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
            LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
        End Try
    End Sub

    Private Sub datDate_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        'DateSpin = CDate(NewDate) - CDate(OldDate)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        Dim D1 As Integer
        Dim intRow As Integer

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
            If DateSpin = 0 Then DateSpin = 1
            RunDate = DateAdd(DateInterval.Day, DateSpin, RunDate)

            GoTo Calc
        End If

        DateSpin = 0
        datDate.Value = Format(RunDate, "Short Date")
        lblDate.Text = "Day " & CStr(D1)

        CalcLogBindingSource.MoveFirst()
        intRow = CalcLogBindingSource.Find("RunDate", RunDate)
        CalcLogBindingSource.Position = intRow
        'CLRS.MoveFirst()
        'CLRS.Find "RunDate=#" & Format(RunDate, "MM/DD/YYYY") & "#"

        If intRow >= 0 Then
            lblStatus.Text = ""
            lblStatus.Update()
            cmdOK.Enabled = True
        Else
            lblStatus.Text = "Invoices have not been calculated for this date."
            lblStatus.Update()
            cmdOK.Enabled = False
        End If
        'If CLRS.EOF Then
        '    lblStatus.Text = "Invoices have not been calculated for this date."
        '    lblStatus.Update()
        '    cmdOK.Enabled = False
        'Else
        '    lblStatus.Text = ""
        '    lblStatus.Update()
        '    cmdOK.Enabled = True
        'End If

    End Sub

    Private Sub optRoute0_CheckedChanged(sender As Object, e As EventArgs) Handles optRoute0.CheckedChanged, optRoute2.CheckedChanged, optRoute1.CheckedChanged

        Select Case sender.name
            Case "optRoute0"
                If optRoute0.Checked Then
                    txtRoute0.Text = ""
                    txtRoute1.Text = ""
                    txtRoute2.Text = ""
                    txtRoute3.Text = ""
                    txtRoute4.Text = ""
                    txtRoute5.Text = ""
                End If
            Case "optRoute1"
                If blnNoClear1 = False Then
                    txtRoute0.Text = ""
                End If
            Case "optRoute2"
                If blnNoClear2 = False Then
                    txtRoute1.Text = ""
                    txtRoute2.Text = ""
                    txtRoute3.Text = ""
                    txtRoute4.Text = ""
                    txtRoute5.Text = ""
                End If
        End Select

    End Sub

    Private Sub txtRoute0_TextChanged(sender As Object, e As EventArgs) Handles txtRoute0.TextChanged, txtRoute5.TextChanged, txtRoute4.TextChanged, txtRoute3.TextChanged, txtRoute2.TextChanged, txtRoute1.TextChanged

        strLocation = "TRC1.0"
        Dim tb As TextBox = sender

        If tb.Text <> "" Then
            Try
                Select Case tb.Name
                    Case "txtRoute0"
                        strLocation = "TRC2.0"
                        blnNoClear1 = True
                        optRoute2.Checked = True
                    Case "txtRoute1", "txtRoute2", "txtRoute3", "txtRoute4", "txtRoute5"
                        strLocation = "TRC3.0"
                        blnNoClear2 = True
                        optRoute1.Checked = True
                End Select
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in routine txtRoute0_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "txtRoute0_TextChanged", vbOK)
                LogError(Me.Name, "txtRoute0_TextChanged", strLocation, ex.Message)
            Finally
                blnNoClear1 = False
                blnNoClear2 = False
            End Try
        End If

    End Sub

    'Sub SetSelection()

    '   ****************************************************************************
    '   * Not needed, can't send formulas to Crystal anymore.  Done with parameters
    '   ****************************************************************************

    '    Dim q2 As String
    '    Dim flag As Boolean

    '    'Process selections
    '    SF = "{InvoiceHeader.DATE}=Date(" & Format(RunDate, "Short Date") & ")"

    '    If optRoute1.Checked Then
    '        q2 = "{InvoiceHeader.ROUTE} in ["

    '        flag = False
    '        If txtRoute1.Text > "" Then
    '            q2 = q2 & txtRoute1.Text & ","
    '            flag = True
    '        End If
    '        If txtRoute2.Text > "" Then
    '            q2 = q2 & txtRoute2.Text & ","
    '            flag = True
    '        End If
    '        If txtRoute3.Text > "" Then
    '            q2 = q2 & txtRoute3.Text & ","
    '            flag = True
    '        End If
    '        If txtRoute4.Text > "" Then
    '            q2 = q2 & txtRoute4.Text & ","
    '            flag = True
    '        End If
    '        If txtRoute5.Text > "" Then
    '            q2 = q2 & txtRoute5.Text & ","
    '            flag = True
    '        End If

    '        q2 = Strings.Left(q2, Len(q2) - 1) & "]"
    '        If Not flag Then
    '            MsgBox("You must select routes with 'only' option.", vbOKOnly, "No Routes Entered")
    '            Exit Sub
    '        End If

    '        SF = SF & " AND " & q2
    '    ElseIf optRoute2.Checked Then
    '        q2 = "Not ({InvoiceHeader.ROUTE} in ["

    '        flag = False
    '        If txtRoute0.Text > "" Then
    '            q2 = q2 & txtRoute0.Text & ","
    '            flag = True
    '        End If

    '        q2 = Strings.Left(q2, Len(q2) - 1) & "])"
    '        If Not flag Then
    '            MsgBox("You must select route with 'exclude' option.", vbOKOnly, "No Route Entered")
    '            Exit Sub
    '        End If

    '        SF = SF & " AND " & q2
    '    End If
    'End Sub

End Class