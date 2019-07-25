Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmRoute

    Private Sub frmRoute_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub frmRoute_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        'Begin process
        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "CLC1.0"
                connection.Open()

                strLocation = "CLC2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spLoadRouteTemp"
                strLocation = "CLC3.0"
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                lblStatus.Text = "Error Loading Temporary File"
                lblStatus.Update()

                Me.Cursor = Cursors.Default
                Me.Enabled = True

                Result = MessageBox.Show(Me, "Error in routine cmdLoad_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdLoad_Click", vbOK)
                LogError(Me.Name, "cmdLoad_Click", strLocation, ex.Message)
            End Try
        End Using

        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandText = q
        '    .CommandType = adCmdStoredProc
        '    .Execute
        'End With

        lblStatus.Text = "Temporary file loaded"
        lblStatus.Update()

        Me.Cursor = Cursors.Default
        Me.Enabled = True

    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click

        frmRouteEdit.Show()

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        frmRouteRpt.Show()

    End Sub

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click

        'Print list of changes
        lblStatus.Text = "Printing change report"
        lblStatus.Update()

        frmViewReport.lblReportName.Text = "RouteChange.rpt"
        frmViewReport.Show()

        'With RPT
        '    .ReportFileName = RptPath & "\RouteChange.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Destination = 1
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim i As Integer

        Me.Cursor = Cursors.WaitCursor
        Me.Enabled = False

        'Update CustomerRoute
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "CUC1.0"
                connection.Open()

                strLocation = "CUC2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spUpdateRoutes"
                strLocation = "CUC3.0"
                i = cmd.ExecuteNonQuery

            Catch ex As Exception
                lblStatus.Text = "Error: 0 records updated"
                lblStatus.Update()

                Me.Cursor = Cursors.Default
                Me.Enabled = True

                Result = MessageBox.Show(Me, "Error in routine cmdUpdate_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdUpdate_Click", vbOK)
                LogError(Me.Name, "cmdUpdate_Click", strLocation, ex.Message)
            End Try
        End Using

        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandText = q
        '    .CommandType = adCmdStoredProc
        '    .Execute i
        'End With

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        'lblStatus.Text = i & " records updated"
        lblStatus.Text = "Records updated"
        lblStatus.Update()

    End Sub
End Class