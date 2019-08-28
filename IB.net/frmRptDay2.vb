Option Explicit On

Imports System.Data.SqlClient
Imports System.ComponentModel
Imports C1.Win.C1Input

Public Class frmRptDay2

    Dim RunDate As Date
    Dim LastDate As Date
    Dim Stamp As Date
    Dim CalcDate As Date
    Dim PrintDate As Date
    Dim ProcDate As Date
    Dim NewWeek As Boolean
    Dim NewMonth As Boolean
    Dim NewYear As Boolean
    Dim ReRun As Boolean
    Dim MoYr As Long
    Dim ADOCmd As New ADODB.Command
    Dim CoRS As New ADODB.Recordset
    Dim CLRS As New ADODB.Recordset

    Private Sub frmRptDay2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        GetCalcLog()

        Me.Show()

        ResetScreen()

    End Sub

    Private Sub frmRptDay2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Sub GetCalcLog()

        CalcLogTableAdapter.Connection.ConnectionString = CS
        CalcLogTableAdapter.Fill(DsCalcLogOrderbyRunDate.CalcLog)
        'q = "SELECT * FROM CalcLog ORDER BY RunDate"
        'CLRS.Open q, DB, adOpenDynamic, adLockOptimistic

    End Sub

    Sub ResetScreen()

        Dim q As String

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
            If Not IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("ProcessDate")) Then
                If IsDate(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("ProcessDate")) Then
                    Exit Do
                End If
            End If
            CalcLogBindingSource.MovePrevious()
        Loop
        'CLRS.MoveLast()
        'CLRS.Find("ProcessDate>'1/1/1901'", 0, adSearchBackward)

        If CalcLogBindingSource.Position < 0 Then
            LastDate = Nothing
            CalcLogBindingSource.MoveFirst()
        Else
            If CalcLogBindingSource.Position < DsCalcLogOrderbyRunDate.CalcLog.Rows.Count - 1 Then
                LastDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("RunDate")
                CalcLogBindingSource.MoveNext()
            Else
                MsgBox("No dates have been calculated but not completed.")
                Me.Close()

                Exit Sub
                'If CLRS.EOF Then
                '    MsgBox("No dates have been calculated but not completed.")
                '    Unload(Me)
                '    Exit Sub
                'End If
            End If
        End If
        'If CLRS.BOF Then
        '    LastDate = 0
        '    CLRS.MoveFirst()
        'Else
        '    LastDate = CLRS!RunDate
        '    CLRS.MoveNext()
        'End If

        CurDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("RunDate")
        ProcDate = CurDate 'the only date volume reports can be run for

        'Set date control
        RunDate = CurDate
        datDate.Value = Format(RunDate, "Short Date")
        'datDate_Change
        datQtr.Value = Format(DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("FIRSTFRIOFQTR"), "Short Date")

    End Sub

    Sub GetCompany()

        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_CompanyID.Company, Company)
        'q = "Select * From Company where COMPANY_ID='" & Company & "'"
        'CoRS.Open q, DB, adOpenDynamic, adLockOptimistic

    End Sub

    Sub LoadRevCust()

        Dim e As Integer

        'Roll over (or not) before loading
        Try
            strLocation = "LRC1.0"
            If Not IsDBNull(DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("LASTROLL_OVER")) Then
                strLocation = "LRC2.0"
                If DatePart("m", DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("LASTROLL_OVER")) <> DatePart("m", RunDate) Then
                    strLocation = "LRC3.0"
                    e = MsgBox("Done with " & Format(DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("LASTROLL_OVER"), "mmmm") & " commissions?", vbYesNo, "Avg Revenue Update")
                    If e = vbNo Then
                        MsgBox("Average revenue will not be updated.", vbOKOnly, "Commissions Not Done")
                        Exit Sub
                    End If

                    Using connection As New SqlConnection(CS)
                        strLocation = "LRC4.0"
                        connection.Open()

                        strLocation = "LRC5.0"
                        Dim cmd As SqlCommand = New SqlCommand
                        cmd.Connection = connection
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.CommandText = "spUpdateRevCust"

                        strLocation = "LRC6.0"
                        cmd.ExecuteNonQuery()
                        'With ADOCmd
                        '    .ActiveConnection = DB
                        '    .CommandText = "spUpdateRevCust"
                        '    .CommandType = adCmdStoredProc
                        '    .Execute()
                        'End With

                        strLocation = "LRC7.0"
                        DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("LASTROLL_OVER") = RunDate
                        CompanyTableAdapter.Update(DsCompany_CompanyID.Company)

                        cmd.CommandText = "spLoadRevenueByCust"

                        strLocation = "LRC8.0"
                        cmd.ExecuteNonQuery()
                    End Using
                    'Load current data
                    'With ADOCmd
                    '    .ActiveConnection = DB
                    '    .CommandText = "spLoadRevenueByCust"
                    '    .CommandType = adCmdStoredProc
                    '    .Execute()
                    'End With
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine LoadRevCust (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LoadRevCust", vbOK)
            LogError(Me.Name, "LoadRevCust", strLocation, ex.Message)
        End Try

    End Sub

    Sub LoadVolume()

        Try
            Me.Cursor = Cursors.WaitCursor
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand

                strLocation = "LV1.0"
                connection.Open()

                strLocation = "LV2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spResetVolume"
                cmd.Parameters.Add("ReRun", SqlDbType.Bit).Value = ReRun
                strLocation = "LV2.1"
                cmd.Parameters.Add("NewWeek", SqlDbType.Bit).Value = NewWeek
                strLocation = "LV2.2"
                cmd.Parameters.Add("NewMonth", SqlDbType.Bit).Value = NewMonth
                strLocation = "LV2.3"
                cmd.Parameters.Add("NewYear", SqlDbType.Bit).Value = NewYear

                strLocation = "LV3.0"
                cmd.ExecuteNonQuery()
                'q = "spResetVolume " & Math.Abs(ReRun) & "," & Math.Abs(NewWeek) & "," & Math.Abs(NewMonth) & "," & Math.Abs(NewYear)
                'With ADOCmd
                '    .CommandType = adCmdText
                '    .ActiveConnection = DB
                '    .CommandText = q
                '    .Execute()
                'End With

                strLocation = "LV4.0"
                cmd.Parameters.Clear()
                cmd.CommandText = "spLoadVolume"
                cmd.Parameters.Add("RunDate", SqlDbType.Date).Value = RunDate
                cmd.ExecuteNonQuery()
                'q = "spLoadVolume '" & Format(RunDate, "Short Date") & "'"
                'With ADOCmd
                '    .ActiveConnection = DB
                '    .CommandText = q
                '    .Execute()
                'End With
            End Using
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine LoadVolume (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LoadVolume", vbOK)
            LogError(Me.Name, "LoadVolume", strLocation, ex.Message)
        End Try

    End Sub

    Sub LoadVolumeMonth()

        Dim mo As Long
        Dim yr As Long

        Try
            Me.Cursor = Cursors.WaitCursor

            mo = DatePart("m", RunDate)
            yr = DatePart("yyyy", RunDate)
            MoYr = yr * 100 + mo

            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand

                strLocation = "LVM1.0"
                connection.Open()

                strLocation = "LVM2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spLoadVolumeMonth"
                cmd.Parameters.Add("MoYr", SqlDbType.Int).Value = MoYr

                strLocation = "LVM3.0"
                cmd.ExecuteNonQuery()
            End Using
            'With ADOCmd
            '    .ActiveConnection = DB
            '    .CommandText = q
            '    .Execute()
            'End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine LoadVolumeMonth (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LoadVolumeMonth", vbOK)
            LogError(Me.Name, "LoadVolumeMonth", strLocation, ex.Message)
        End Try

    End Sub

    Sub RunReport1()

        Dim FromDate As Date

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            If optSince0.Checked Then
                FromDate = DateAdd("s", 1, CalcDate)
            Else
                FromDate = PrintDate
            End If

            strLocation = "RR1-1.5"
            RPT.Load("C:\IB\ReportsCR2016\invchg.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR1-2.1"
            RPT.SetParameterValue("RunDate", RunDate)
            strLocation = "RR1-2.2"
            RPT.SetParameterValue("FromDate", FromDate)

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\invchg.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
        '    .Formulas(2) = "FromDate=DateTime(" & Format(FromDate, "yyyy,mm,dd,hh,nn,ss") & ")"
        '    .SelectionFormula = "Left({InvoiceHeader.DATE},10)='" & Format(RunDate, "yyyy/mm/dd") & "' AND {InvoiceQty.STAMP}>'" & Format(FromDate, "yyyy/mm/dd hh:nn:ss") & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

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
            RPT.SetParameterValue("Route0", 0)
            RPT.SetParameterValue("Route1", 0)
            RPT.SetParameterValue("Route2", 0)
            RPT.SetParameterValue("Route3", 0)
            RPT.SetParameterValue("Route4", 0)
            RPT.SetParameterValue("Route5", 0)

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
        '    .SelectionFormula = "{InvoiceHeader.DATE}=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport3()

        'Print Reports
        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR3-1.0"
            RPT.Load("C:\IB\ReportsCR2016\dayvol.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR3-2.1"
            RPT.SetParameterValue("RunDate", RunDate)

            strLocation = "RR3-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\dayvol.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Action = 1
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            strLocation = "RR3-4.0"
            RPT.Load("C:\IB\ReportsCR2016\dayvolsum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-5.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR3-5.1"
            RPT.SetParameterValue("RunDate", RunDate)

            strLocation = "RR3-6.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\dayvolsum.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RunDate=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
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

    Sub RunReport4()

        Dim FirstWeek As Date
        Dim RunWeek As Date
        Dim q As String
        Dim q1 As String
        Dim LastO As Double
        Dim LastR As Double
        Dim tempRS As New ADODB.Recordset
        Dim intWeekday As Int16

        Try
            Me.Cursor = Cursors.WaitCursor

            'Print weekly summary
            strLocation = "RR4-1.0"
            RPT.Load("C:\IB\ReportsCR2016\weekvolsum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR4-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR4-2.1"
            RPT.SetParameterValue("RunDate", RunDate)

            strLocation = "RR4-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\weekvolsum.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            'Print weekly analysis
            strLocation = "RR4-5.0"
            FirstWeek = CDate(datQtr.Value)
            intWeekday = DatePart("w", RunDate)
            RunWeek = DateAdd(DateInterval.Day, (intWeekday * (-1)) + 6, RunDate) ' friday of this week
            'RunWeek = RunDate - DatePart("w", RunDate) + 6 ' friday of this week

            'q = "spGetTotalWeekRev '" & Format(FirstWeek, "Short Date") & "'"
            Using connection As New SqlConnection(CS)
                strLocation = "RR4-6.0"
                connection.Open()

                strLocation = "RR4-7.0"
                Dim cmd As SqlCommand = New SqlCommand
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spGetTotalWeekRev"
                cmd.Parameters.Add("FirstWeek", SqlDbType.DateTime).Value = FirstWeek

                strLocation = "RR4-8.0"
                Using sqlReader = cmd.ExecuteReader()
                    If sqlReader.HasRows = True Then
                        strLocation = "RR4-9.0"
                        sqlReader.Read()

                        LastO = RoundOff(sqlReader("TOTAL_O") / 13)
                        LastR = RoundOff(sqlReader("TOTAL_R") / 13)
                    End If
                End Using
            End Using
            'tempRS.Open q, DB, adOpenStatic
            'If Not tempRS.EOF Then
            '    On Error Resume Next
            '    LastO = RoundOff(tempRS!TOTAL_O / 13)
            '    LastR = RoundOff(tempRS!TOTAL_R / 13)
            '    On Error GoTo 0
            'End If
            'tempRS.Close()

            'Print weekly summary
            strLocation = "RR4-9.0"
            RPT.Load("C:\IB\ReportsCR2016\weekrev.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR4-10.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR4-10.1"
            RPT.SetParameterValue("RunWeek", Format(RunWeek, "Short Date"))
            strLocation = "RR4-10.2"
            RPT.SetParameterValue("FirstWeek", FirstWeek)
            strLocation = "RR4-10.3"
            RPT.SetParameterValue("LASTQTR_O", LastO)
            strLocation = "RR4-10.4"
            RPT.SetParameterValue("LASTQTR_R", LastR)

            strLocation = "RR4-11.0"
            RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\weekrev.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RUNWEEK=Date(" & Format(RunWeek, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CompanyName & "'"
            '    .Formulas(2) = "LASTQTR_O=" & LastO
            '    .Formulas(3) = "LASTQTR_R=" & LastR
            '    .Formulas(4) = "FIRSTWEEK=Date(" & Format(FirstWeek, "yyyy,mm,dd") & ")"
            '    .SelectionFormula = "{RevenueByWeek.FRI_DATE}>=Date(" & Format(FirstWeek, "yyyy,mm,dd") & ")"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .Formulas(2) = ""
            '    .Formulas(3) = ""
            '    .Formulas(4) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            'Print production report
            strLocation = "RR4-9.0"
            RPT.Load("C:\IB\ReportsCR2016\VolItem.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR4-10.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR4-10.1"
            RPT.SetParameterValue("RunDate", Format(RunDate, "Short Date"))
            strLocation = "RR4-10.2"
            RPT.SetParameterValue("VolCat", "")
            strLocation = "RR4-10.3"
            RPT.SetParameterValue("ReportName", "RptDay2")

            strLocation = "RR4-11.0"
            RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\VolItem.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CompanyName & "'"
            '    .SelectionFormula = "{VolByItem.VOL_CAT} in ['01' , '40']"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport4 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport4", vbOK)
            LogError(Me.Name, "RunReport4", strLocation, ex.Message)
        End Try

    End Sub

    Sub RunReport5()

        Dim DateRange(0 To 5)

        Try
            'Calculate needed dates
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR5-1.0"
            'DateRange(0) = RunDate - Day(RunDate) + 1 ' first of this month
            DateRange(0) = DateAdd(DateInterval.Day, (DatePart("d", RunDate) * (-1)) + 1, RunDate) ' first of this month
            DateRange(1) = DateAdd("m", 1, DateRange(0)) ' first of next month
            DateRange(2) = DateAdd("m", 2, DateRange(0)) ' 2 months
            DateRange(3) = DateAdd("m", 6, DateRange(0)) ' 6 months
            DateRange(4) = DateAdd("m", 7, DateRange(0)) ' 7 months
            DateRange(5) = DateAdd("m", -2, DateRange(0)) ' last 90 days
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport5 (" & strLocation & ")" & vbNewLine & "Error calculating dates, cannot continue" & vbNewLine & "Error : " & ex.Message, "RunReport5", vbOK)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            Exit Sub
        End Try

        Try
            lblStatus1.Text = "Printing Monthly Volume Report"
            lblStatus1.Update()

            'strLocation = "RR5-2.0"
            'RPT.Load("C:\IB\ReportsCR2016\MonthVolSum.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-3.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-3.1"
            'RPT.SetParameterValue("MY", MoYr)

            'strLocation = "RR5-4.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\MonthVolSum.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "MY=" & MoYr
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            'strLocation = "RR5-5.0"
            'RPT.Load("C:\IB\ReportsCR2016\MonthVolComp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-6.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-6.1"
            'RPT.SetParameterValue("MY", MoYr)

            'strLocation = "RR5-7.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\MonthVolComp.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "MY=" & MoYr
            '    .Formulas(1) = "COMPANY='" & CoRS!COMPANY_NM & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error Printing Monthly Volume Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Production Report"
            lblStatus1.Update()

            'strLocation = "RR5-8.0"
            'RPT.Load("C:\IB\ReportsCR2016\VolItem.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-9.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-9.1"
            'RPT.SetParameterValue("RunDate", Format(RunDate, "Short Date"))
            'strLocation = "RR5-9.2"
            'RPT.SetParameterValue("VolCat", "")
            'strLocation = "RR5-9.3"
            'RPT.SetParameterValue("ReportName", "RptDay2")

            'strLocation = "RR5-10.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\VolItem.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .Formulas(1) = "COMPANY='" & CompanyName & "'"
            '    .SelectionFormula = "{VolByItem.VOL_CAT} in ['01' , '40']"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error Printing Production Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Anniversary Report"
            lblStatus1.Update()

            'strLocation = "RR5-11.0"
            'RPT.Load("C:\IB\ReportsCR2016\CustAnn.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-12.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)

            'strLocation = "RR5-13.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\CustAnn.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .Formulas(2) = ""
            '    .Formulas(3) = ""
            '    .GroupSelectionFormula = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error Printing Anniversary Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Expiration Report"
            lblStatus1.Update()

            'strLocation = "RR5-14.0"
            'RPT.Load("C:\IB\ReportsCR2016\CustExp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-15.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-15.1"
            'RPT.SetParameterValue("DateFrom", Format(CDate(DateRange(3)), "Short Date"))
            'strLocation = "RR5-15.2"
            'RPT.SetParameterValue("DateTo", Format(CDate(DateRange(4)), "Short Date"))
            'strLocation = "RR5-15.3"
            'RPT.SetParameterValue("ReportTitle", "CONTRACT EXPIRATIONS")

            'strLocation = "RR5-16.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\CustExp.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Formulas(1) = "DATE1=Date(" & Format(DateRange(3), "yyyy,mm,dd") & ")"
            '    .Formulas(2) = "DATE2=Date(" & Format(DateRange(4) - 1, "yyyy,mm,dd") & ")"
            '    .Formulas(3) = "TITLE='CONTRACT EXPIRATIONS'"
            '    .GroupSelectionFormula = "Sum({@XCNT},{CustomerMaster.BILL_NAME})>0"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .Formulas(2) = ""
            '    .Formulas(3) = ""
            '    .GroupSelectionFormula = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Expiration Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Cancellation Report"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\CustCanc.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-18.1"
            'RPT.SetParameterValue("DateFrom", Format(CDate(DateRange(3)), "Short Date"))
            'strLocation = "RR5-18.2"
            'RPT.SetParameterValue("DateTo", Format(CDate(DateRange(4)), "Short Date"))

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\CustCanc.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Formulas(1) = "DATE1=Date(" & Format(DateRange(0), "yyyy,mm,dd") & ")"
            '    .Formulas(2) = "DATE2=Date(" & Format(DateRange(1) - 1, "yyyy,mm,dd") & ")"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .Formulas(2) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Cancellation Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Top 100 Paper Report"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\VolCust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-18.1"
            'RPT.SetParameterValue("RunDate", RunDate)
            'strLocation = "RR5-18.2"
            'RPT.SetParameterValue("VolCat", "01")

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\VolCust.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Formulas(1) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
            '    .SelectionFormula = "{VolByCust.VOL_CAT}='01'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Top 100 Paper Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Top 100 AWR Report"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\awrtop100.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\awrtop100.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Top 100 AWR Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Top 100 PAPER SALES REPORT"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\ytdcomp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\ytdcomp.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\lytdcomp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\lytdcomp.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Top 100 PAPER SALES Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing Exception Report"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\Except.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)
            'strLocation = "RR5-18.1"
            'RPT.SetParameterValue("StartDate", Format(CDate(DateRange(5)), "Short Date"))

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\Except.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Formulas(1) = "STARTDATE=Date(" & Format(DateRange(5), "yyyy,mm,dd") & ")"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .ReportFileName = ""
            'End With
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Exception Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing tax exempt items Report"
            lblStatus1.Update()

            'strLocation = "RR5-17.0"
            'RPT.Load("C:\IB\ReportsCR2016\untaxeditems.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            'setCrystalPrinter()
            'SetDbConnection()

            'strLocation = "RR5-18.0"
            'RPT.SetParameterValue("CompanyName", frmMain.Text)

            'strLocation = "RR5-19.0"
            'RPT.PrintToPrinter(1, True, 0, 0)
            'With RPT
            '    .ReportFileName = RptPath & "\untaxeditems.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .ReportFileName = ""
            'End With

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Tax Exempt Items Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message & vbNewLine & "Do you wish to continue?", "RunReport5", vbYesNo)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)

            If Result = vbNo Then
                Exit Sub
            End If
        End Try

        Try
            lblStatus1.Text = "Printing tax exempt departments Report"
            lblStatus1.Update()

            strLocation = "RR5-17.0"
            RPT.Load("C:\IB\ReportsCR2016\untaxeddepartments.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR5-18.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RR5-19.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            'With RPT
            '    .ReportFileName = RptPath & "\untaxeddepartments.rpt"
            '    .Connect = CryCS
            '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .Formulas(1) = ""
            '    .ReportFileName = ""
            'End With

            lblStatus1.Text = "Finished Running Reports"
            lblStatus1.Update()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Printing Tax Exempt Departments Report (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport5", vbOK)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        'Begin process
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False

        'Print reports
        If chkRpt4.Checked Then
            lblStatus1.Text = "Loading Average Revenue Report File..."
            lblStatus1.Update()

            LoadRevCust()
        End If

        If chkRpt0.Checked Then
            lblStatus1.Text = "Printing Invoice Changes..."
            lblStatus1.Update()

            RunReport1()
        End If

        If chkRpt1.Checked Then
            lblStatus1.Text = "Printing Tripsheet Recap..."
            lblStatus1.Update()

            RunReport2()
        End If

        If chkRpt2.Checked Or chkRpt3.Checked Or chkRpt4.Checked Then
            lblStatus1.Text = "Loading Volume Report Files..."
            lblStatus1.Update()

            LoadVolume()
        End If

        If chkRpt2.Checked Then
            lblStatus1.Text = "Printing Daily Volume..."
            lblStatus1.Update()

            'RunReport3 change to stop update from failing

            '''''''''  ************ Do we have the right record ??????????????????
            DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate2") = Now()
            CalcLogTableAdapter.Update(DsCalcLogOrderbyRunDate.CalcLog)
            'CLRS!PrintDate2 = Now()
            'CLRS.Update()

            RunReport3()
        End If

        If chkRpt3.Checked Then
            lblStatus1.Text = "Printing Weekly Reports..."
            lblStatus1.Update()

            RunReport4()

            '''''''''  ************ Do we have the right record ??????????????????
            DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("WeekPrint") = True
            CalcLogTableAdapter.Update(DsCalcLogOrderbyRunDate.CalcLog)
            'CLRS!WeekPrint = True
            'CLRS.Update()
        End If

        If chkRpt4.Checked Then
            lblStatus1.Text = "Loading Monthly Volume Report File..."
            lblStatus1.Update()

            LoadVolumeMonth()

            lblStatus1.Text = "Calculating Peak Use..."
            lblStatus1.Update()

            Me.Cursor = Cursors.WaitCursor
            CalcItemUse(1, 999999999, False, True)
            Me.Cursor = Cursors.Default

            lblStatus1.Text = "Printing Monthly Reports..."
            lblStatus1.Update()

            RunReport5()

            '''''''''  ************ Do we have the right record ??????????????????
            DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("MonthPrint") = True
            CalcLogTableAdapter.Update(DsCalcLogOrderbyRunDate.CalcLog)
            'CLRS!MonthPrint = True
            'CLRS.Update()
        End If

OKDone:

        lblStatus1.Text = "Finished printing."
        lblStatus1.Update()

        ResetScreen()

        Me.Cursor = Cursors.Default
        Me.Enabled = True

    End Sub

    Private Sub datDate_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        'DateSpin = CDate(NewDate) - CDate(OldDate)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged, datDate.Click

        Dim D1 As Integer
        Dim intRow As Integer
        Dim q As String
        Dim M As Integer
        Dim NextDate As Date
        Dim TempDate As Date

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

        'Get initial print date
        CalcLogBindingSource.MoveFirst()
        intRow = CalcLogBindingSource.Find("RunDate", RunDate)
        CalcLogBindingSource.Position = intRow
        'CLRS.MoveFirst()
        'CLRS.Find "RunDate=#" & Format(RunDate, "MM/DD/YYYY") & "#"

        If intRow >= 0 Then
            CalcDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("CalcDate")
            cmdOK.Enabled = True
            If IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) Then
                lblStatus1.Text = "Tripsheets have not been run for this date."
                lblStatus1.Update()

                chkRpt1.Checked = False
                chkRpt1.Enabled = False
                chkRpt2.Checked = False
                chkRpt2.Enabled = False
                chkRpt3.Checked = False
                chkRpt3.Enabled = False
                chkRpt4.Checked = False
                chkRpt4.Enabled = False

                PrintDate = Nothing

                optSince0.Checked = True
                optSince1.Enabled = False

                Exit Sub
            Else
                lblStatus1.Text = "Tripsheets originally printed " & Format(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate"), "MM/dd/yy hh:mm tt")
                PrintDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")
                chkRpt1.Checked = True
                chkRpt1.Enabled = True
                optSince1.Checked = True
                optSince1.Enabled = True
            End If
        Else
            lblStatus1.Text = "Invoices have not been calculated for this date."
            lblStatus1.Update()
            cmdOK.Enabled = False
        End If

        'If CLRS.EOF Then
        '    lblStatus1.Text = "Invoices have not been calculated for this date."
        '    lblStatus1.Update()

        '    cmdOK.Enabled = False
        'Else
        '    CalcDate = CLRS!CalcDate
        '    cmdOK.Enabled = True
        '    If IsNull(CLRS!PrintDate) Then
        '        lblStatus(1) = "Tripsheets have not been run for this date."
        '        For i = 1 To 4
        '            chkRpt(i) = 0
        '            chkRpt(i).Enabled = False
        '        Next i
        '        PrintDate = 0
        '        optSince(0) = True
        '        optSince(1).Enabled = False
        '        Exit Sub
        '    Else
        '        lblStatus(1) = "Tripsheets originally printed " & Format(CLRS!PrintDate, "MM/DD/YY hh:nn am/pm")
        '        PrintDate = CLRS!PrintDate
        '        chkRpt(1) = 1
        '        chkRpt(1).Enabled = True
        '        optSince(1) = True
        '        optSince(1).Enabled = True
        '    End If
        'End If

        If RunDate <> ProcDate Then
            'can't run main reports if not next date in sequence
            chkRpt2.Checked = False
            chkRpt2.Enabled = False
            chkRpt3.Checked = False
            chkRpt3.Enabled = False
            chkRpt4.Checked = False
            chkRpt4.Enabled = False
        Else
            chkRpt2.Enabled = True
            chkRpt3.Enabled = True
            chkRpt4.Enabled = True
            chkRpt2.Checked = True

            'Figure end-of-week or -month
            If cmdOK.Enabled Then
                'tempRS = CLRS.Clone
                'tempRS.Bookmark = CLRS.Bookmark
                'tempRS.MoveNext()

                'If tempRS.EOF Then
                If CalcLogBindingSource.Position - 1 = DsCalcLogOrderbyRunDate.CalcLog.Rows.Count Then
                    'No next entry, check for Friday
                    If DatePart("w", RunDate) = 6 Then
                        chkRpt3.Checked = True

                        TempDate = DateAdd(DateInterval.Day, DateSpin, 3)
                        If Month(RunDate) <> Month(TempDate) Then
                            chkRpt4.Checked = True
                        Else
                            chkRpt4.Checked = False
                        End If
                    Else
                        chkRpt3.Checked = False

                        TempDate = DateAdd(DateInterval.Day, DateSpin, 1)
                        If Month(RunDate) <> Month(TempDate) Then
                            chkRpt4.Checked = True
                        Else
                            chkRpt4.Checked = False
                        End If
                    End If
                Else
                    'Compare to next entry
                    CalcLogBindingSource.MoveNext()
                    NextDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("RunDate")
                    If DatePart("ww", RunDate) <> DatePart("ww", NextDate) Then
                        chkRpt3.Checked = True
                    Else
                        chkRpt3.Checked = False
                    End If

                    If DatePart("m", RunDate) <> DatePart("m", NextDate) Then
                        chkRpt4.Checked = True
                    Else
                        chkRpt4.Checked = False
                    End If
                End If
            End If

            If IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate2")) And DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("WeekPrint") = False And DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("MonthPrint") = False Then
                ReRun = False
                'Figure if today is new week/month/year
                If DatePart("ww", RunDate) <> DatePart("ww", LastDate) Then
                    NewWeek = True
                Else
                    NewWeek = False
                End If
                M = DatePart("m", RunDate)
                If M <> DatePart("m", LastDate) Then
                    NewMonth = True
                    If M = 1 Then
                        NewYear = True
                    Else
                        NewYear = False
                    End If
                Else
                    NewMonth = False
                    NewYear = False
                End If
            Else
                'It's a rerun
                ReRun = True
            End If
        End If
    End Sub

    Private Sub datQtr_ValueChanged(sender As Object, e As EventArgs) Handles datQtr.ValueChanged, datQtr.Click

        DsCompany_CompanyID.Company.Rows(CompanyBindingSource.Position)("FIRSTFRIOFQTR") = datQtr.Value
        CompanyTableAdapter.Update(DsCompany_CompanyID.Company)
        'CoRS!FIRSTFRIOFQTR = CDate(datQtr.Date)
        'CoRS.Update()

    End Sub

    Private Sub cmdPreview0_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click

        frmViewReport.lblReportName.Text = "invchg.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdPreview1_Click(sender As Object, e As EventArgs) Handles cmdPreview1.Click

        frmViewReport.lblReportName.Text = "triprec2.rpt"
        frmViewReport.Show()

    End Sub
End Class