Option Explicit On
Imports System.ComponentModel

Public Class frmRptItemUse

    Private Sub frmRptItemUse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        txtRange0.Text = "1"
        txtRange1.Text = "9999999"

    End Sub

    Private Sub frmRptItemUse_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub RunReport1()

        lblStatus1.Text = "Printing Item Usage..."
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR1-1.0"
            RPT.Load("C:\IB\ReportsCR2016\ItemUse2.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

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
        '    .ReportFileName = RptPath & "\ItemUse2.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus1.Text = ""

    End Sub
    Sub RunReport2()

        lblStatus1.Text = "Printing Inventory Analysis..."
        lblStatus1.Update()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "RR2-1.0"
            RPT.Load("C:\IB\ReportsCR2016\InvAnal.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

            setCrystalPrinter()
            SetDbConnection()

            strLocation = "RR2-2.0"
            RPT.SetParameterValue("CompanyName", frmMain.Text)
            strLocation = "RR2-2.1"
            RPT.SetParameterValue("First", Val(txtRange0.Text))
            strLocation = "RR2-2.2"
            RPT.SetParameterValue("Last", Val(txtRange1.Text))

            strLocation = "RRO2-3.0"
            RPT.PrintToPrinter(1, True, 0, 0)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine RunReport2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "RunReport2", vbOK)
            LogError(Me.Name, "RunReport2", strLocation, ex.Message)
        End Try
        'With RPT
        '    .ReportFileName = RptPath & "\InvAnal.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{GetItemsAll2.ITEM_NUM} in " & Val(txtRange(0)) & " to " & Val(txtRange(1))
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus1.Text = ""

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdPreview0_Click(sender As Object, e As EventArgs) Handles cmdPreview0.Click

        lblStatus1.Text = "Calculating peak usage..."
        lblStatus1.Update()

        Me.Cursor = Cursors.WaitCursor
        CalcItemUse(Val(txtRange0.Text), Val(txtRange1.Text), True, False)
        Me.Cursor = Cursors.Default

        'RunReport1()
        frmViewReport.lblReportName.Text = "ItemUse2.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdPreview1_Click(sender As Object, e As EventArgs) Handles cmdPreview1.Click

        lblStatus1.Text = "Calculating peak usage..."
        lblStatus1.Update()

        Me.Cursor = Cursors.WaitCursor
        CalcItemUse(Val(txtRange0.Text), Val(txtRange1.Text), False, True)
        Me.Cursor = Cursors.Default

        'RunReport2()
        frmViewReport.lblReportName.Text = "InvAnal.rpt"
        frmViewReport.Show()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim flag1 As Boolean, flag2 As Boolean

        If chkRpt1.Checked Then
            flag1 = True
        Else
            flag1 = False
        End If

        If chkRpt2.Checked Then
            flag2 = True
        Else
            flag2 = False
        End If

        lblStatus1.Text = "Calculating peak usage..."
        lblStatus1.Update()

        Me.Cursor = Cursors.WaitCursor
        CalcItemUse(Val(txtRange0.Text), Val(txtRange1.Text), flag1, flag2)
        Me.Cursor = Cursors.Default

        If chkRpt1.Checked Then
            RunReport1()
        End If

        If chkRpt2.Checked Then
            RunReport2()
        End If

    End Sub

    Private Sub chkRpt1_CheckedChanged(sender As Object, e As EventArgs) Handles chkRpt1.CheckedChanged, chkRpt2.CheckedChanged

        If chkRpt1.Checked Or chkRpt2.Checked Then
            cmdOK.Enabled = True
        Else
            cmdOK.Enabled = False
        End If

    End Sub

End Class