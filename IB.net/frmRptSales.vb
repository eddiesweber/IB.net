Option Explicit On

Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmRptSales

    Public RunDate As Date

    Private Sub frmRptSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        strLocation = "FRSL1.0"
        Try
            strLocation = "FRSL2.0"
            CategoryMasterTableAdapter.Connection.ConnectionString = CS
            CategoryMasterTableAdapter.Fill(DsCategoryMaster.CategoryMaster)

            strLocation = "FRSL3.0"
            cmbCat.SelectedIndex = cmbCat.FindString("01")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmRptSales_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmRptSales_Load", vbOK)
            LogError(Me.Name, "frmRptSales_Load", strLocation, ex.Message)
        End Try

        ' Form_Activate
        GetCalcLog()

    End Sub

    Private Sub frmRptSales_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub GetCalcLog()

        Dim q As String

        strLocation = "GCL1.0"
        q = "SELECT * From CalcLog Where (Not (PrintDate2 Is Null)) ORDER BY RunDate"

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(q, connection)

            Try
                strLocation = "GCL2.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                strLocation = "GCL3.0"
                If dataReader.HasRows = True Then
                    Do While dataReader.Read()
                        RunDate = dataReader("PrintDate2")
                    Loop

                    lblStaus0.Text = "Data updated through " & Format(RunDate, "Short Date")
                    lblStaus0.Update()
                Else
                    MessageBox.Show("No dates updated")
                    Me.Close()

                    Exit Sub
                End If

                strLocation = "GCL4.0"
                dataReader.Close()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetCalcLog (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetCalcLog", vbOK)
                LogError(Me.Name, "GetCalcLog", strLocation, ex.Message)
            End Try
        End Using



    End Sub

    Sub RunReport1()

        lblStatus1.Text = "Printing Production Report"
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\VolItem.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR1-2.1"
            RPT.SetParameterValue("RunDate", Format(RunDate, "Short Date"))
            strLocation = "RR1-2.2"
            RPT.SetParameterValue("VolCat", cmbCat.SelectedText)

            strLocation = "RR1-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport1", vbOK)
            LogError(Me.Name, "RunReport1", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\VolItem.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(1) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{VolByItem.VOL_CAT}='" & cmbCat.BoundText & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Sub RunReport2()

        lblStatus1.Text = "Printing Top 100 Report"
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load("C:\IB\ReportsCR2016\VolCust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR2-2.1"
            RPT.SetParameterValue("RunDate", Format(RunDate, "Short Date"))
            strLocation = "RR2-2.2"
            RPT.SetParameterValue("VolCat", cmbCat.SelectedText)

            strLocation = "RRO2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\VolCust.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .SelectionFormula = "{VolByCust.VOL_CAT}='" & cmbCat.BoundText & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If chkRpt0.Checked Then
            RunReport1()
        End If

        If chkRpt1.Checked Then
            RunReport2()
        End If

        lblStatus1.Text = "Reports completed."
        lblStatus1.Update()

    End Sub

    Private Sub cmdPreview0_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click

        frmViewReport.lblReportName.Text = "VolItem.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdPreview1_Click(sender As Object, e As EventArgs) Handles cmdPreview1.Click

        frmViewReport.lblReportName.Text = "VolCust.rpt"
        frmViewReport.Show()

    End Sub

End Class