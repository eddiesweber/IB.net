﻿Option Explicit On

Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmViewReport

    Private Sub frmViewReport_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' *****************************************************
        ' General Crystal Notes
        'RPT.RecordSelectionFormula = ""
        'RPT.DataDefinition.SortFields(0).ToString()

        Select Case lblReportName.Text
            Case "sohist.rpt"
                sohist()
            Case "deadbeatcust.rpt"
                deadbeatcust()
            Case "Custinfo.rpt"
                CustInfo()
            Case "zipreport.rpt"
                zipreport()
            Case "invoice_historical.rpt"
                invoice_historical()
            Case "CustNew.rpt"
                CustNew()
            Case "CustExp.rpt"
                CustExp()
            Case "CustCanc.rpt"
                CustCanc()
            Case "CustInfoAll.rpt"
                CustInfoAll()
            Case "stopdeliv.rpt"
                stopdeliv()
            Case "recollect.rpt"
                recollect()
            Case "Except.rpt"
                Except()
            Case "NoOrders.rpt"
                NoOrders()
            Case "awrtop100.rpt"
                awrtop100()
            Case "awrchange.rpt"
                awrchange()
            Case "monthlyitem.rpt"
                monthlyitem()
            Case "lytdcomp.rpt"
                lytdcomp()
            Case "ytdcomp.rpt"
                ytdcomp()
            Case "New_Paper.rpt"
                New_Paper()
            Case "monthly_dispenser.rpt"
                monthly_dispenser()
            Case "salestaxsql.rpt"
                salestaxsql()
            Case "VolItem.rpt"
                VolItem()
            Case "VolCust.rpt"
                VolCust()

            Case Else
                MessageBox.Show("The report '" & lblReportName.Text & "' does not exist")

                Me.Close()
        End Select

    End Sub

    Private Sub VolCust()

        Try
            strLocation = "VC1.0"
            RPT.Load("C:\IB\ReportsCR2016\VolCust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "VC2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "VC2.1"
            RPT.SetParameterValue("RunDate", Format(frmRptSales.RunDate, "Short Date"))
            strLocation = "VC2.2"
            RPT.SetParameterValue("VolCat", frmRptSales.cmbCat.SelectedText)

            strLocation = "VC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine VolCust (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "VolCust", vbOK)
            LogError(Me.Name, "VolCust", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub VolItem()

        Try
            strLocation = "VI1.0"
            RPT.Load("C:\IB\ReportsCR2016\VolItem.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "VI2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "VI2.1"
            RPT.SetParameterValue("RunDate", Format(frmRptSales.RunDate, "Short Date"))
            strLocation = "VI2.2"
            RPT.SetParameterValue("VolCat", frmRptSales.cmbCat.SelectedText)

            strLocation = "VI3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine VolItem (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "VolItem", vbOK)
            LogError(Me.Name, "VolItem", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub salestaxsql()

        Try
            strLocation = "STS1.0"
            RPT.Load("C:\IB\ReportsCR2016\salestaxsql.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "STS2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "STS3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine salestaxsql (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "salestaxsql", vbOK)
            LogError(Me.Name, "salestaxsql", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\salestaxsql.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    '.SelectionFormula = "{VolByItem.VOL_CAT}='" & cmbCat.BoundText & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub BobM()

        Try
            strLocation = "ACFB1.0"
            RPT.Load("C:\IB\ReportsCR2016\all customers for bobm.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "ACFB2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "ACFB3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine all customers for bobm (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "all customers for bobm", vbOK)
            LogError(Me.Name, "all customers for bobm", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\all customers for bobm.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    If Option1 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.DEL_NAME}"
        '        .SortFields(1) = "+{all customer report for bobm.CUST_NUM}"
        '    ElseIf Option2 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.MINIM_00}"
        '        .SortFields(1) = "+{all customer report for bobm.DEL_CITY}"
        '    ElseIf Option3 = True Then
        '        .SortFields(0) = "+{all customer report for bobm.DEL_CITY}"
        '        .SortFields(1) = "+{all customer report for bobm.CUST_NUM}"
        '    ElseIf Option4 = True Then
        '        .SortFields(0) = "+{@AWPR}"
        '        .SortFields(1) = "+{all customer report for bobm.DEL_CITY}"
        '    End If
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub monthly_dispenser()

        Try
            strLocation = "MD1.0"
            RPT.Load("C:\IB\ReportsCR2016\monthly_dispenser.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "MD2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "MD3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine monthly_dispenser (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "monthly_dispenser", vbOK)
            LogError(Me.Name, "monthly_dispenser", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\monthly_dispenser.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "Company='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With


    End Sub

    Private Sub New_Paper()

        Try
            strLocation = "NP1.0"
            RPT.Load("C:\IB\ReportsCR2016\New_Paper.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "NP2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "NP3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine New_Paper (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "New_Paper", vbOK)
            LogError(Me.Name, "New_Paper", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\New_Paper.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub ytdcomp()

        Try
            strLocation = "YC1.0"
            RPT.Load("C:\IB\ReportsCR2016\ytdcomp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "YC2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "YC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine ytdcomp (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "ytdcomp", vbOK)
            LogError(Me.Name, "ytdcomp", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\ytdcomp.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub lytdcomp()

        Try
            strLocation = "LYC1.0"
            RPT.Load("C:\IB\ReportsCR2016\lytdcomp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "LYC2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "LYC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lytdcomp (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lytdcomp", vbOK)
            LogError(Me.Name, "lytdcomp", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\lytdcomp.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub monthlyitem()

        Try
            strLocation = "MI1.0"
            RPT.Load("C:\IB\ReportsCR2016\monthlyitem.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "MI2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "MI2.1"
            RPT.SetParameterValue("ItemNumber", frmmiscrpt.txtItemNumOpt.Text)

            strLocation = "MI3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine monthlyitem (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "monthlyitem", vbOK)
            LogError(Me.Name, "monthlyitem", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\monthlyitem.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{InvoiceHistory.COUNT} > 0 and{InvoiceHistory.ITEM_NUM} =" & Val(txtItemNumOpt) & "and {InvoiceHistory.DATE} in LastFullMonth"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub awrchange()

        Try
            strLocation = "AWRC1.0"
            RPT.Load("C:\IB\ReportsCR2016\awrchange.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "AWRC2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "AWRC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine awrchange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "awrchange", vbOK)
            LogError(Me.Name, "awrchange", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub awrtop100()

        Try
            strLocation = "AWRT1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\awrtop100.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "AWRT1-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "AWRT1-3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine awrtop100 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "awrtop100", vbOK)
            LogError(Me.Name, "awrtop100", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub NoOrders()

        Try
            strLocation = "NO1.0"
            RPT.Load("C:\IB\ReportsCR2016\NoOrders.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "NO2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("StartDate", frmRptExcept.datDate.Value)

            strLocation = "NO3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine NoOrders (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "NoOrders", vbOK)
            LogError(Me.Name, "NoOrders", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub Except()

        Try
            strLocation = "EX1.0"
            RPT.Load("C:\IB\ReportsCR2016\Except.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "EX2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("StartDate", frmRptExcept.datDate.Value)

            strLocation = "EX3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine Except (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "Except", vbOK)
            LogError(Me.Name, "Except", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub recollect()

        Try
            strLocation = "RC1.0"
            RPT.Load("C:\IB\ReportsCR2016\recollect.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine recollect (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "recollect", vbOK)
            LogError(Me.Name, "recollect", strLocation, ex.Message)
        End Try


    End Sub

    Private Sub stopdeliv()

        Try
            strLocation = "SD1.0"
            RPT.Load("C:\IB\ReportsCR2016\stopdeliv.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "SD2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)

            strLocation = "SD3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine stopdeliv (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "stopdeliv", vbOK)
            LogError(Me.Name, "stopdeliv", strLocation, ex.Message)
        End Try


    End Sub

    Private Sub CustInfoAll()

        Try
            strLocation = "CIA1.0"
            RPT.Load("C:\IB\ReportsCR2016\Custinfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "CIA2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "CIA2.1"
            RPT.SetParameterValue("CustNum", 0)

            strLocation = "CIA3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustInfoAll (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustInfoAll", vbOK)
            LogError(Me.Name, "CustInfoAll", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CustCanc()

        Try
            strLocation = "cc1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustCanc.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "cc2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "CC2.1"
            RPT.SetParameterValue("DateFrom", frmRptCustNew.datDate0.Value)
            strLocation = "CC2.2"
            RPT.SetParameterValue("DateTo", frmRptCustNew.datDate1.Value)

            strLocation = "CC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustCanc (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustCanc", vbOK)
            LogError(Me.Name, "CustCanc", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CustExp()

        Try
            strLocation = "CE1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustExp.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "CE2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "CE3.0"
            RPT.SetParameterValue("DateFrom", frmRptCustNew.datDate0.Value)
            strLocation = "CE4.0"
            RPT.SetParameterValue("DateTo", frmRptCustNew.datDate1.Value)
            strLocation = "CE5.0"
            RPT.SetParameterValue("ReportTitle", frmMain.Text)

            strLocation = "CE6.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustExp (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustExp", vbOK)
            LogError(Me.Name, "CustExp", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CustNew()

        Try
            strLocation = "CN1.0"
            RPT.Load("C:\IB\ReportsCR2016\CustNew.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "CN2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "CN2.1"
            RPT.SetParameterValue("DateFrom", frmRptCustNew.datDate0.Value)
            strLocation = "CN2.2"
            RPT.SetParameterValue("DateTo", frmRptCustNew.datDate1.Value)

            strLocation = "CN3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustNew (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustNew", vbOK)
            LogError(Me.Name, "CustNew", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub invoice_historical()

        Try
            strLocation = "IH1.0"
            RPT.Load("C:\IB\ReportsCR2016\invoice_historical.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "IH2.0"
            RPT.SetParameterValue("InvoiceNumber", frmInvHist.txtInvoice.Text)

            strLocation = "IH3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine invoice_historical (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "invoice_historical", vbOK)
            LogError(Me.Name, "invoice_historical", strLocation, ex.Message)
        End Try

        'With RPT
        '    .ReportFileName = RptPath & "\invoice_historical.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    '.Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "({INVHISTORYHEADER.INV_NUMBER} = " & Val(txtInvoice) & ")"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .Formulas(1) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub

    Private Sub zipreport()

        Try
            strLocation = "ZR1.0"
            RPT.Load("C:\IB\ReportsCR2016\zipreport.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "ZR2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            If frmZipSearch.optZip.Checked = True Then
                strLocation = "ZR3.0"
                RPT.SetParameterValue("byCity", "NO")
                RPT.SetParameterValue("SearchField", frmZipSearch.txtZip.Text)
            Else
                strLocation = "ZR4.0"
                RPT.SetParameterValue("byCity", "YES")
                RPT.SetParameterValue("SearchField", UCase(frmZipSearch.txtZip.Text))
            End If

            strLocation = "ZR5.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine zipreport (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "zipreport", vbOK)
            LogError(Me.Name, "zipreport", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub sohist()

        Try
            strLocation = "SH1.0"
            RPT.Load("C:\IB\ReportsCR2016\sohist.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "SH2.0"
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "SH3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine sohist (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "sohist", vbOK)
            LogError(Me.Name, "sohist", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub deadbeatcust()

        Try
            strLocation = "DBC1.0"
            RPT.Load("C:\IB\ReportsCR2016\deadbeatcust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "DBC2.0"
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "DBC3.0"
            CrystalReportViewer1.ReportSource = RPT
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine deadbeatcust (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "deadbeatcust", vbOK)
            LogError(Me.Name, "deadbeatcust", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CustInfo()

        Try
            strLocation = "CI1.0"
            RPT.Load("C:\Reports\CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()

            SetDbConnection()

            strLocation = "CI2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            RPT.SetParameterValue("CustNum", CurCust)

            strLocation = "CI3.0"
            RPT.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine CustInfo (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CustInfo", vbOK)
            LogError(Me.Name, "CustInfo", strLocation, ex.Message)
        End Try

    End Sub

    'Private Sub rptTest()

    ' This also works, but I like to format above.  
    ' Keeping just incase needed

    '    RPT.Load("C:\Reports\rptTest.rpt")

    '    Dim crParameterFieldDefinitions As ParameterFieldDefinitions
    '    Dim crParameterFieldDefinition As ParameterFieldDefinition
    '    Dim crParameterValues As New ParameterValues
    '    Dim crParameterDiscreteValue As New ParameterDiscreteValue

    '    For Each CTable As Table In RPT.Database.Tables
    '        CTable.LogOnInfo.ConnectionInfo = ConnInfo
    '        CTableLogInfo = CTable.LogOnInfo
    '        CTableLogInfo.ReportName = RPT.Name
    '        CTableLogInfo.TableName = CTable.Name
    '        CTable.ApplyLogOnInfo(CTableLogInfo)
    '    Next

    '    crParameterDiscreteValue.Value = CurCust
    '    crParameterFieldDefinitions = RPT.DataDefinition.ParameterFields
    '    crParameterFieldDefinition = crParameterFieldDefinitions.Item("CustomerNumber")
    '    crParameterValues = crParameterFieldDefinition.CurrentValues

    '    crParameterValues.Clear()
    '    crParameterValues.Add(crParameterDiscreteValue)
    '    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

    '    'CrystalReportViewer1.ReportSource = RPT
    '    'CrystalReportViewer1.Refresh()

    'End Sub


End Class