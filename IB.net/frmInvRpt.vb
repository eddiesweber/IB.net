Option Explicit On
Imports System.ComponentModel

Public Class frmInvRpt

    Dim D1 As Date, D2 As Date

    Private Sub frmInvRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim D As Date
        Dim i As Integer

        GetWindowPos(Me, 200, 200)

        D = Now()

        i = DatePart("d", D)
        D = DateAdd("d", 0 - i, D)
        datDate1.Value = Format(D, "Short Date")

        i = DatePart("d", D)
        D = DateAdd("d", 1 - i, D)
        datDate0.Value = Format(D, "Short Date")

    End Sub

    Private Sub frmInvRpt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If IsDate(datDate0.Value) And IsDate(datDate1.Value) Then
            D1 = datDate0.Value
            D2 = datDate1.Value

            'RPT.Destination = 1
            If chkRpt0.Checked Then
                RunReport1()
            End If
            If chkRpt1.Checked Then
                RunReport2()
            End If
            If chkRpt2.Checked Then
                RunReport3()
            End If
            If chkRpt3.Checked Then
                RunReport4()
            End If
            If chkRpt4.Checked Then
                runreport5()
            End If
            If chkRpt5.Checked Then
                runreport6()
            End If
        Else
            MsgBox("Please enter date range", vbOKOnly, "Invalid Date(s)")
        End If

    End Sub

    Private Sub cmdPreview0_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click, cmdPreview5.Click, cmdPreview4.Click, cmdPreview3.Click, cmdPreview2.Click, cmdPreview1.Click

        If Not (IsDate(datDate0.Value) And IsDate(datDate1.Value)) And
            (sender.name = "cmdPreview0" Or sender.name = "cmdPreview1" Or sender.name = "cmdPreview5") Then
            MsgBox("Please enter date range", vbOKOnly, "Invalid Date(s)")
            Exit Sub
        End If

        D1 = datDate0.Text
        D2 = datDate1.Text

        'RPT.Destination = 0
        Select Case sender.name
            Case "cmdPreview0"
                frmViewReport.lblReportName.Text = "InvSales.rpt"
                frmViewReport.Show()
            Case "cmdPreview1"
                frmViewReport.lblReportName.Text = "Inventory.rpt"
                frmViewReport.Show()
            Case "cmdPreview2"
                frmViewReport.lblReportName.Text = "InvReorder.rpt"
                frmViewReport.Show()
            Case "cmdPreview3"
                frmViewReport.lblReportName.Text = "InvSalesHist.rpt"
                frmViewReport.Show()
            Case "cmdPreview4"
                frmViewReport.lblReportName.Text = "InvSpecOrd.rpt"
                frmViewReport.Show()
            Case "cmdPreview5"
                frmViewReport.lblReportName.Text = "InvSalesDeliv.rpt"
                frmViewReport.Show()
        End Select

    End Sub

    Sub RunReport1()

        lblStatus.Text = "Printing Sales By Product..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvSales.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

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
        '    .ReportFileName = RptPath & "\InvSales.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "Date1=Date(" & Format(D1, "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "Date2=Date(" & Format(D2, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Sub RunReport2()

        lblStatus.Text = "Printing Inventory Report..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load("C:\IB\ReportsCR2016\Inventory.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("@Date1", datDate0.Value)
            RPT.SetParameterValue("@date2", datDate1.Value)
            RPT.SetParameterValue("DateFrom", datDate0.Value)
            RPT.SetParameterValue("DateTo", datDate1.Value)

            strLocation = "RR2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try
        'With RPT
        '    .ReportFileName = RptPath & "\Inventory.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "Date1=Date(" & Format(D1, "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "Date2=Date(" & Format(D2, "yyyy,mm,dd") & ")"
        '    .StoredProcParam(0) = Format(D1, "yyyy-mm-dd ") & "00:00:00.000"
        '    .StoredProcParam(1) = Format(D2, "yyyy-mm-dd ") & "00:00:00.000"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .StoredProcParam(0) = ""
        '    .StoredProcParam(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Sub RunReport3()

        lblStatus.Text = "Printing Reorder Report..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR3-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvReorder.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR3-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RR3-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport3 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport3", vbOK)
            LogError(Me.Name, "RunReport3", strLocation, ex.Message)
        End Try
        'With RPT
        '    .ReportFileName = RptPath & "\InvReorder.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Sub RunReport4()

        lblStatus.Text = "Printing Sales History Report..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR4-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvSalesHist.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR4-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("@Date2", datDate1.Value)

            strLocation = "RR4-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport4 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport4", vbOK)
            LogError(Me.Name, "RunReport4", strLocation, ex.Message)
        End Try
        'With RPT
        '    .ReportFileName = RptPath & "\InvSalesHist.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .StoredProcParam(0) = Format(D2, "yyyy-mm-dd ") & "00:00:00.000"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .StoredProcParam(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Sub runreport5()

        lblStatus.Text = "Printing Special Orders Report..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR5-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvSpecOrd.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR5-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "RR5-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport5 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport5", vbOK)
            LogError(Me.Name, "RunReport5", strLocation, ex.Message)
        End Try
        'With RPT
        '    .ReportFileName = RptPath & "\InvSpecOrd.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

    Sub runreport6()

        lblStatus.Text = "Printing Sales/Delivery Reconciliation..."
        lblStatus.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR6-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvSalesDeliv.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR6-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("DateFrom", datDate0.Value)
            RPT.SetParameterValue("DateTo", datDate1.Value)

            strLocation = "RR6-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport6 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport6", vbOK)
            LogError(Me.Name, "RunReport6", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\InvSalesDeliv.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Formulas(1) = "Date1=Date(" & Format(D1, "yyyy,mm,dd") & ")"
        '    .Formulas(2) = "Date2=Date(" & Format(D2, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .Formulas(2) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = ""
        lblStatus.Update()

    End Sub

End Class