Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmUndo

    Dim UndoDate As Date
    Dim RunDate As Date
    Dim Stamp As Date

    Private Sub frmUndo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'GetWindowPos(Me, 66, 66)

        ResetScreen()

    End Sub

    Private Sub frmUndo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub ResetScreen()

        GetCompany()

        RunDate = Now()
        If DsCompany_LASTCALC.Company.Rows.Count > 0 Then
            If IsDBNull(DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_DATE")) = False Then
                RunDate = DsCompany_LASTCALC.Company.Rows(0)("LASTCALC_DATE")
            End If
        End If

        'Set date control
        lblStatus0.Text = ""
        lblStatus1.Text = ""
        datDate.Value = Format(RunDate, "Short Date")

    End Sub

    Sub GetCompany()

        'Get last run info from Company File
        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_LASTCALC.Company, Company)
        'q = "Select LASTCALC_DATE From Company where COMPANY_ID='" & Company & "'"
        'Call CoRS.Open(q, DB, adOpenForwardOnly)

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        RunDate = CDate(datDate.Value)

        CalcLogTableAdapter.Connection.ConnectionString = CS
        CalcLogTableAdapter.Fill(DsCalcLog_RunDate.CalcLog, RunDate)
        'q = "SELECT * FROM CalcLog WHERE RunDate='" & Format(RunDate, "MM/DD/YYYY") & "'"
        'Call CLRS.Open(q, DB, adOpenDynamic, adLockOptimistic)

        If DsCalcLog_RunDate.CalcLog.Rows.Count > 0 Then
            lblStatus0.Text = "Invoices were last calculated for this date on " & Format(DsCalcLog_RunDate.CalcLog.Rows(0)("CalcDate"), "General Date")
            lblStatus1.Text = "All computer-generated invoices with this date will be deleted."
            cmdOK.Enabled = True
        Else
            lblStatus0.Text = "Invoices have never been calculated for this date."
            lblStatus1.Text = ""
            cmdOK.Enabled = False
        End If

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim dtNullDate As Date = Nothing

        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "COK1.0"
                connection.Open()

                strLocation = "COK2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spDayCalcUndo"
                cmd.Parameters.Add("RunDate", SqlDbType.Date).Value = Format(RunDate, "Short Date")

                strLocation = "COK3.0"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
            End Try
        End Using
        'q = "spDayCalcUndo ('" & Format(RunDate, "MM/DD/YYYY") & "')"
        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandText = q
        '    .CommandType = adCmdStoredProc
        '    .Execute()
        'End With

        DsCalcLog_RunDate.CalcLog.Rows(0)("CalcDate") = DBNull.Value
        CalcLogTableAdapter.Update(DsCalcLog_RunDate.CalcLog.Rows(0))
        'CLRS!CalcDate = Null
        'CLRS.Update()

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        MessageBox.Show("Undo complete")

        Me.Close()

        Exit Sub

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

End Class