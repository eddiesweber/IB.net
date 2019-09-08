Option Explicit On

Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmRentComm

    Private Sub frmRentComm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim RunDate(0 To 1) As Date

        GetWindowPos(Me, 200, 200)

        'RunDate(0) = Now - DatePart("d", Now) + 1
        RunDate(0) = DateAdd(DateInterval.Day, ((DatePart("d", Now) * (-1)) + 1), Now())
        RunDate(0) = DateAdd("m", -1, RunDate(0)) '1st of last month

        'RunDate(1) = DateAdd("m", 1, RunDate(0)) - 1
        RunDate(1) = DateAdd(DateInterval.Month, 1, RunDate(0))
        RunDate(1) = DateAdd(DateInterval.Day, -1, RunDate(1))

        datStart.Value = Format(RunDate(0), "Short Date")
        datComm.Value = Format(RunDate(1), "Short Date")

    End Sub

    Private Sub frmRentComm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub ResetScreen()

        Dim q As String

        GetCompany()

        If IsDBNull(DsCompany_CompanyID.Company.Rows(0)("LASTROLL_OVER")) Then
            q = "(never)"
        Else
            q = Format(DsCompany_CompanyID.Company.Rows(0)("LASTROLL_OVER"), "Short Date")
        End If

        lblStatus.Text = "Data current as of " & q

    End Sub

    Sub GetCompany()

        'Get last run info from Company File
        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_CompanyID.Company, Company)
        'q = "Select * From Company where COMPANY_ID='" & Company & "'"
        'CoRS.Open q, DB, adOpenStatic

    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        Dim q As String

        Try
            'Begin process
            strLocation = "CLC1.0"
            Me.Cursor = Cursors.WaitCursor
            Me.Enabled = False

            'Copy routes to temp file
            lblStatus.Text = "Loading default commissions..."
            lblStatus.Update()

            Using connection As New SqlConnection(CS)
                strLocation = "CLC2.0"
                Dim cmd As SqlCommand = New SqlCommand

                connection.Open()

                strLocation = "CLC3.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spLoadRentComm"
                cmd.Parameters.Add("StartDate", SqlDbType.DateTime).Value = Format(datStart.Value, "Short Date")

                strLocation = "CLC4.0"
                cmd.ExecuteNonQuery()
            End Using
            'q = "spLoadRentComm '" & Format(CDate(datStart.Date), "MM/DD/YYYY") & "'"
            'With ADOCmd
            '    .ActiveConnection = DB
            '    .CommandText = q
            '    .Execute
            'End With

            Me.Cursor = Cursors.Default
            Me.Enabled = True

            lblStatus.Text = "Load complete"
            lblStatus.Update()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.Enabled = True

            lblStatus.Text = "LOAD FAILED"
            lblStatus.Update()
            Result = MessageBox.Show(Me, "Error in routine cmdLoad_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdLoad_Click", vbOK)
            LogError(Me.Name, "cmdLoad_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click

        frmRentCommEdit.Show()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim q As String

        Try
            strLocation = "CUC1.0"
            Me.Cursor = Cursors.WaitCursor
            Me.Enabled = False

            'Update CustomerRoute
            lblStatus.Text = "Updating Commission file"
            lblStatus.Update()

            Using connection As New SqlConnection(CS)
                strLocation = "CLC2.0"
                Dim cmd As SqlCommand = New SqlCommand

                connection.Open()

                strLocation = "CLC3.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spUpdateRentComm"
                cmd.Parameters.Add("PostDate", SqlDbType.DateTime).Value = Format(datComm.Value, "Short Date")

                strLocation = "CLC4.0"
                cmd.ExecuteNonQuery()
            End Using
            'q = "spUpdateRentComm '" & Format(CDate(datComm.Date), "MM/DD/YYYY") & "'"
            'With ADOCmd
            '    .ActiveConnection = DB
            '    .CommandText = q
            '    .Execute
            'End With

            lblStatus.Text = "Update complete"
            lblStatus.Update()

            Me.Cursor = Cursors.Default
            Me.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.Enabled = True

            lblStatus.Text = "LOAD FAILED"
            lblStatus.Update()
            Result = MessageBox.Show(Me, "Error in routine cmdUpdate_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdUpdate_Click", vbOK)
            LogError(Me.Name, "cmdUpdate_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

End Class