Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1Input
Imports System.Data.SqlClient

Public Class frmDayCalc

    Dim RunDate As Date
    Dim Stamp As Date
    Dim WD1 As String
    Dim WD2 As String
    Dim dtHoldDate As Date
    Dim blnNoClear1 As Boolean = False
    Dim blnNoClear2 As Boolean = False

    Private Sub frmDayCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        ResetScreen()

    End Sub

    Private Sub frmDayCalc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub GetCompany()

        'Get last run info from Company File
        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_LASTCALC.Company, Company)

    End Sub

    Sub ResetScreen()

        Dim q As String

        GetCompany()

        q = "Last run for "

        'Set date control
        If IsDBNull(DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_DATE")) Then
            RunDate = Now()
            q = q & "(never)"
        Else
            RunDate = DateAdd(DateInterval.Day, 1, DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_DATE"))
            q = q & Format(DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_DATE"), "Short Date")
        End If

        q = q & " on " & Format(DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_STAMP"), "General Date")
        lblLast.Text = q
        lblStatus0.Text = ""
        lblStatus1.Text = ""

        dtHoldDate = Format(RunDate, "General Date")
        datDate.Value = Format(RunDate, "General Date")

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        Dim D1 As Integer

        'Validate for weekend and get weekday
        If Not IsDate(datDate.Value) Then
            RunDate = Nothing
            cmdOK.Enabled = False
            Exit Sub
        End If

        dtHoldDate = CDate(datDate.Value)
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
        WD1 = CStr(D1)
        Select Case Int(D1 / 10)
            Case 1, 3
                WD2 = "A" & WD1.Substring(WD1.Length - 1, 1)
            Case 2, 4
                WD2 = "B" & WD1.Substring(WD1.Length - 1, 1)
        End Select
        lblStatus0.Text = "Selected weekdays " & WD1 & " and " & WD2

        cmdOK.Enabled = True
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub datDate_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        'DateSpin = CDate(NewDate) - CDate(OldDate)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta
        datDate.Show()
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

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim q2 As String = ""

        Dim strSQL As String = "SELECT * FROM CalcLog WHERE RunDate='" & Format(RunDate, "Short Date") & "'"

        strLocation = "COK1.0"
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(strSQL, connection)

            Try
                strLocation = "COK2.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows Then
                    strLocation = "COK3.0"
                    dataReader.Read()

                    strLocation = "COK4.0"
                    If IsDate(dataReader("PrintDate2")) Then
                        Result = MessageBox.Show(Me, "Can't recalculate this date.", "Date Done", vbOKOnly)
                        Exit Sub
                    Else
                        Result = MessageBox.Show(Me, "Invoices have been calculated for this date." & Chr(10) & "Are you sure?", "Calculation Done", vbYesNo)
                        If Result = vbNo Then
                            Exit Sub
                        End If
                    End If
                End If

                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)

                Result = MessageBox.Show(Me, "Exiting, invoices were not calculated. ", "Error Calculating Invoices", vbOK)
                Exit Sub
            End Try

        End Using
        '        'Get info for this date from CalcLog
        '        q = "SELECT * FROM CalcLog WHERE RunDate='" & Format(RunDate, "MM/DD/YYYY") & "'"
        '        Call CLRS.Open(q, DB, adOpenForwardOnly)
        '        If Not CLRS.EOF Then
        '            If CLRS!PrintDate2 > 0 Then
        '                MsgBox "Can't recalculate this date.", vbOKOnly, "Date Done"
        '        Exit Sub
        '            Else
        '                e = MsgBox("Invoices have been calculated for this date." & Chr(10) & "Are you sure?", vbYesNo, "Calculation Done")
        '                If e = vbNo Then Exit Sub
        '            End If
        '        End If

        'Set route list

        If optRoute1.Checked Then
            q2 = ""
            If txtRoute1.Text.Trim <> "" Then
                q2 = q2 & txtRoute1.Text & ","
            End If
            If txtRoute2.Text.Trim <> "" Then
                q2 = q2 & txtRoute2.Text & ","
            End If
            If txtRoute3.Text.Trim <> "" Then
                q2 = q2 & txtRoute3.Text & ","
            End If
            If txtRoute4.Text.Trim <> "" Then
                q2 = q2 & txtRoute4.Text & ","
            End If
            If txtRoute5.Text.Trim <> "" Then
                q2 = q2 & txtRoute5.Text & ","
            End If

            If q2.Length < 2 Then
                Result = MessageBox.Show(Me, "You must select routes with 'only' option.", "No Routes Entered", vbOKOnly)
                Exit Sub
            End If
            q2 = q2.Substring(0, Len(q2) - 1)
        ElseIf optRoute2.Checked Then
            q2 = ""
            If txtRoute0.Text.Trim <> "" Then
                q2 = q2 & txtRoute0.Text
            End If

            If txtRoute0.Text.Trim = "" Then
                Result = MessageBox.Show(Me, "You must select routes with 'exclude' option.", "No Route Entered", vbOKOnly)
                Exit Sub
            End If
        End If
        '        'Set route list
        '        If optRoute(1) Then
        '            q2 = ""
        '            For i = 1 To 5
        '                If txtRoute(i) > "" Then q2 = q2 & txtRoute(i) & ","
        '            Next i
        '            If Len(q2) < 2 Then
        '                MsgBox "You must select routes with 'only' option.", vbOKOnly, "No Routes Entered"
        '        Exit Sub
        '            End If
        '            q2 = Left(q2, Len(q2) - 1)
        '        ElseIf optRoute(2) Then
        '            q2 = ""
        '            For i = 0 To 0
        '                If txtRoute(i) > "" Then q2 = q2 & txtRoute(i) & ","
        '            Next i
        '            If Len(q2) < 2 Then
        '                MsgBox "You must select route with 'exclude' option.", vbOKOnly, "No Route Entered"
        '               Exit Sub
        '            End If
        '            q2 = Left(q2, Len(q2) - 1)
        '        End If

        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "COK5.0"
                connection.Open()

                strLocation = "COK6.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spDayCalc"
                cmd.Parameters.Add("RunDate", SqlDbType.Date).Value = Format(RunDate, "Short Date")
                cmd.Parameters.Add("RouteList", SqlDbType.VarChar).Value = q2

                strLocation = "COK7.0"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
            End Try
        End Using

        '        q = "spDayCalc ('" & Format(RunDate, "MM/DD/YYYY")
        '        If q2 > "" Then
        '            q = q & "','" & q2 & "')"
        '        Else
        '            q = q & "')"
        '        End If
        '        With ADOCmd
        '            .ActiveConnection = DB
        '            .CommandText = q
        '            .CommandType = adCmdStoredProc
        '            .Execute()
        '        End With

        'Done
        Me.Cursor = Cursors.Default
        Me.Enabled = True

        Result = MessageBox.Show(Me, "Calculation Complete", "Complete", vbOK)

        ResetScreen()


    End Sub
End Class