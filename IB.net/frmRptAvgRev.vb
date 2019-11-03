Option Explicit On
Imports System.ComponentModel

Public Class frmRptAvgRev

    Dim Loaded As Boolean

    Private Sub frmRptAvgRev_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        If CommFlag Then
            chkRpt2.Visible = True
            cmdPreview2.Visible = True
        End If

        ResetScreen()

    End Sub

    Private Sub frmRptAvgRev_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Sub GetCompany()

        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_CompanyID.Company, Company)
        'q = "Select * From Company where COMPANY_ID='" & Company & "'"
        'CoRS.Open q, DB, adOpenStatic

    End Sub

    Sub ResetScreen()

        Dim q As String

        Try
            GetCompany()

            q = "(never)"
            If DsCompany_CompanyID.Company.Rows.Count > 0 Then
                If Not IsDBNull(DsCompany_CompanyID.Company.Rows(0)("LASTROLL_OVER")) Then
                    q = Format(DsCompany_CompanyID.Company.Rows(0)("LASTROLL_OVER"), "Short Date")
                End If
            End If

            lblStatus0.Text = "Data current as of " & q
            lblStatus0.Update()
        Catch ex As Exception

        End Try

    End Sub

    Sub RunReport1()

        lblStatus1.Text = "Printing Top 100 Report"
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load(RptPath & "awrtop100.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\awrtop100.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport2()

        lblStatus1.Text = "Printing Change Report"
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load(RptPath & "awrchange.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RRO2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = DataPath & "\awrchange.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub chkRpt1_CheckedChanged(sender As Object, e As EventArgs) Handles chkRpt1.CheckedChanged, chkRpt2.CheckedChanged

        If chkRpt1.Checked Or chkRpt2.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If chkRpt1.Checked Then
            RunReport1()
        End If

        If chkRpt2.Checked Then
            RunReport2()
        End If

        lblStatus1.Text = "Reports completed."
        lblStatus1.Update()

    End Sub

    Private Sub cmdPreview1_Click(sender As Object, e As EventArgs) Handles cmdPreview1.Click, cmdPreview2.Click

        Select Case sender.name
            Case "cmdPreview1"
                frmViewReport.lblReportName.Text = "awrtop100.rpt"
                frmViewReport.Show()
            Case "cmdPreview2"
                frmViewReport.lblReportName.Text = "awrchange.rpt"
                frmViewReport.Show()
        End Select

    End Sub

End Class