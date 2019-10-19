Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports C1.Win.C1Input

Public Class frmRptInv

    Dim RunDate As Date
    Dim Stamp As Date
    Dim blnNoClear1 As Boolean = False
    Dim blnNoClear2 As Boolean = False

    Private Sub frmRptInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        GetCalcLog()

        ResetScreen()

        ' Form activated
        If IsDate(RunDate) = False Then
            Me.Close()
        End If


    End Sub

    Private Sub frmRptInv_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub GetCalcLog()

        CalcLogTableAdapter.Connection.ConnectionString = CS
        CalcLogTableAdapter.Fill(DsCalcLogOrderbyRunDate.CalcLog)
        'q = "SELECT * FROM CalcLog ORDER BY RunDate"
        'CLRS.Open q, DB, adOpenStatic

    End Sub

    Sub ResetScreen()

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
            If Not IsDBNull(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) Then
                If IsDate(DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("PrintDate")) Then
                    Exit Do
                End If
            End If
            CalcLogBindingSource.MovePrevious()
        Loop
        'CLRS.MoveLast()
        'CLRS.Find "PrintDate>'1/1/1900'", 0, adSearchBackward

        If CalcLogBindingSource.Position < 0 Then
            CalcLogBindingSource.MoveFirst()
        Else
            If CalcLogBindingSource.Position < DsCalcLogOrderbyRunDate.CalcLog.Rows.Count - 1 Then
                CalcLogBindingSource.MoveNext()
            End If
        End If
        'If CLRS.BOF Then
        '    CLRS.MoveFirst()
        'Else
        '    CLRS.MoveNext()
        '    If CLRS.EOF Then CLRS.MoveLast()
        'End If

        CurDate = DsCalcLogOrderbyRunDate.CalcLog.Rows(CalcLogBindingSource.Position)("RunDate")

        'Set date control
        RunDate = CurDate
        datDate.Value = Format(RunDate, "Short Date")
        'datDate_Change

        'Get standard message
        txtMemo.Text = DsCompany_CompanyID.Company.Rows(0)("SALESMESS")
        'txtMemo = CoRS!SALESMESS

    End Sub

    Sub GetCompany()

        'Get last run info from Company File
        CompanyTableAdapter.Connection.ConnectionString = CS
        CompanyTableAdapter.Fill(DsCompany_CompanyID.Company, Company)
        'q = "Select * From Company where COMPANY_ID='" & Company & "'"
        'CoRS.Open q, DB, adOpenStatic

    End Sub

    Sub RunReport1()

        Dim SF As String = ""
        Dim q2 As String = ""

        ''process selection criteria
        If chkDate.Checked Then
            SF = "{InvoiceHeader.DATE}=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        End If

        If chkNumber.Checked Then
            If SF > "" Then
                SF = SF & " and "
            End If
            SF = SF & "{InvoiceHeader.INV_NUMBER} in " & CStr(Val(txtNumber0.Text)) & " to " & CStr(Val(txtNumber1.Text))
        End If

        If optRoute1.Checked Then
            q2 = "{InvoiceHeader.ROUTE} IN ["
            If txtRoute1.Text > "" Then
                q2 = q2 & txtRoute1.Text & ","
            End If
            If txtRoute2.Text > "" Then
                q2 = q2 & txtRoute2.Text & ","
            End If
            If txtRoute3.Text > "" Then
                q2 = q2 & txtRoute3.Text & ","
            End If
            If txtRoute4.Text > "" Then
                q2 = q2 & txtRoute4.Text & ","
            End If
            If txtRoute5.Text > "" Then
                q2 = q2 & txtRoute5.Text & ","
            End If

            q2 = Strings.Left(q2, Len(q2) - 1) & "]"
            If Len(q2) < 12 Then
                MsgBox("You must select routes with 'only' option.", vbOKOnly, "No Routes Entered")
                Exit Sub
            End If
        ElseIf optRoute2.Checked Then
            If txtRoute0.Text = "" Then
                MsgBox("You must select route with 'exclude' option.", vbOKOnly, "No Route Entered")
                Exit Sub
            End If
            q2 = "{InvoiceHeader.ROUTE} <> " & txtRoute0.Text
        End If

        If Len(q2) > 0 Then
            If SF > "" Then SF = SF & " and "
            SF = SF & q2
        End If

        If optFormat2.Checked = True Then
            If SF > "" Then
                SF = SF & " and "
            End If
            SF = SF & "{InvoiceItem.REQ_QTY} <> 0"
            'RPT.ReportFileName = RptPath & "\plantloadinvoices.rpt"
            'With RPT
            '    .Destination = 1
            '    .Connect = CryCS
            '    .SelectionFormula = SF
            '    .Formulas(0) = "SALESMESS='" & txtMemo & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        Else
            'RPT.ReportFileName = RptPath & "\invoice.rpt"
            'With RPT
            '    .Destination = 1
            '    .Connect = CryCS
            '    .SelectionFormula = SF
            '    .Formulas(0) = "SALESMESS='" & txtMemo & "'"
            '    .Action = 1
            '    .Formulas(0) = ""
            '    .SelectionFormula = ""
            '    .ReportFileName = ""
            'End With
        End If

        'With RPT
        '    .Destination = 1
        '    .Connect = CryCS
        '    .SelectionFormula = SF
        '    .Formulas(0) = "SALESMESS='" & txtMemo & "'"
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

        lblStatus.Text = "Laser invoices printed for " & Format(RunDate, "MM/DD/YY")
        lblStatus.Update()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmPPort.ShowDialog()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim q As String

        Try
            'Make sure totals are correct
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand
                strLocation = "COC1.0"
                connection.Open()

                strLocation = "COC2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spInvoiceCheck"

                strLocation = "COC3.0"
                Using sqlReader = cmd.ExecuteReader()
                    If sqlReader.HasRows = True Then
                        strLocation = "COC4.0"
                        q = "("
                        Do While sqlReader.Read()
                            q = q & sqlReader("INV_NUMBER") & ","
                        Loop
                        q = Strings.Left(q, Len(q) - 1) & ")"

                        MsgBox("Invoices not correct " & q, vbOKOnly, "Repairs Needed")
                        Exit Sub
                    End If
                End Using
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine GetItemInfo (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetItemInfo", vbOK)
            LogError(Me.Name, "GetItemInfo", strLocation, ex.Message)
        End Try

        'q = "spInvoiceCheck"
        'rs.Open(q, DB)
        'If rs.RecordCount > 0 Then
        '    q = "("
        '    While Not rs.EOF
        '        q = q & rs!INV_NUMBER & ","
        '        rs.MoveNext()
        '    End While
        '    q = Strings.Left(q, Len(q) - 1) & ")"
        '    MsgBox("Invoices not correct " & q, vbOKOnly, "Repairs Needed")
        '    rs.Close()
        '    Exit Sub
        'End If
        'rs.Close()

        Me.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        lblStatus.Text = "Printing invoices..."
        lblStatus.Update()

        If optFormat0.Checked = True Then
            PrintInvoices()
        Else
            RunReport1()
        End If

        Me.Cursor = Cursors.Default
        Me.Enabled = True

    End Sub

    Sub PrintInvoices()

        Dim SF As String = ""
        Dim q As String = ""
        Dim q2 As String = ""
        Dim IRS As New ADODB.Recordset
        Dim LastInv As Long
        Dim PageCt As Integer
        Dim LineCt As Integer
        Dim LastDept As Integer
        Dim i As Integer
        Dim SvTax As Single
        Dim SvTotal As Single
        Dim SvTerms As Boolean
        Dim CH As Integer
        Dim ICt As Integer
        Dim strOCR As String
        Dim strOCR2 As String
        Dim intLeftMargin As Integer
        Dim intDEL_NAME_LENGTH As Integer
        Dim intCUST_NUM_LENGTH As Integer
        Dim intINV_NUMBER_LENGTH As Integer
        Dim intDATE_LENGTH As Integer
        Dim strDEL_NAME As String
        Dim strCUST_NUM As String
        Dim strINV_NUMBER As String
        Dim strDATE As String
        Dim strROUTE As String
        'Dim P As Printer

        intLeftMargin = 0
        intDEL_NAME_LENGTH = 25
        intCUST_NUM_LENGTH = 10
        intINV_NUMBER_LENGTH = 10
        intDATE_LENGTH = 15

        'Get printer
        If PPort = "" Then
            Me.Cursor = Cursors.WaitCursor
            frmPPort.ShowDialog()
            Me.Cursor = Cursors.Default
        End If

        If PPort = "" Then Exit Sub

        'CH = FreeFile()
        'Open PPort For Output As #CH

        GoTo PrinterOpen

TryPport2:

        On Error GoTo 0
        'Open PPort2 For Output As #CH

PrinterOpen:

        On Error GoTo 0

        'process selection criteria
        SF = ""
        If chkDate.Checked Then
            SF = " WHERE ih.DATE='" & Format(RunDate, "Short Date") & "'"
        End If

        If chkNumber.Checked Then
            If SF = "" Then
                SF = "WHERE "
            Else
                SF = SF & " AND "
            End If
            SF = SF & "ih.INV_NUMBER BETWEEN " & CStr(Val(txtNumber0.Text)) & " AND " & CStr(Val(txtNumber1.Text))
        End If

        If optRoute1.Checked Then
            q2 = "ROUTE IN ("

            If txtRoute1.Text > "" Then
                q2 = q2 & txtRoute1.Text & ","
            End If
            If txtRoute2.Text > "" Then
                q2 = q2 & txtRoute2.Text & ","
            End If
            If txtRoute3.Text > "" Then
                q2 = q2 & txtRoute3.Text & ","
            End If
            If txtRoute4.Text > "" Then
                q2 = q2 & txtRoute4.Text & ","
            End If
            If txtRoute5.Text > "" Then
                q2 = q2 & txtRoute5.Text & ","
            End If
            q2 = Strings.Left(q2, Len(q2) - 1) & ")"

            If Len(q2) < 12 Then
                MsgBox("You must select routes with 'only' option.", vbOKOnly, "No Routes Entered")
                'Close #CH
                Exit Sub
            End If
        ElseIf optRoute2.Checked Then
            q2 = "ROUTE NOT IN ("
            If txtRoute0.Text > "" Then
                q2 = q2 & txtRoute0.Text & ")"
            End If

            If Len(q2) < 16 Then
                MsgBox("You must select route with 'exclude' option.", vbOKOnly, "No Route Entered")
                'Close #CH
                Exit Sub
            End If
        End If

        If Len(q2) > 0 Then
            If SF = "" Then
                SF = "WHERE " & q2
            Else
                SF = SF & " AND " & q2
            End If
        End If

        'Get data
        q = "SELECT ih.INV_NUMBER, ii.LINE_TYPE, ii.ITEM_NUM, cd.DEL_NAME, cd.DEL_ADDR, cd.DEL_CITY, cd.DEL_STATE, cd.DEL_ZIP, ih.PAY_TYPE, ih.DATE, ih.CUST_NUM, ih.WEEKDAY, ih.ROUTE, ih.SEQUENCE, ii.DEPT, cd.MESSAGE, ih.TAX_MON, ih.INV_TOTAL, ii.ITEM_DESC, ii.NAME_SIZE, ii.INV_QTY, ii.REQ_QTY, ii.BILL_QTY, ii.UNIT_PRICE, ih.CHANGE_MEMO"
        q = q & " FROM (InvoiceHeader ih INNER JOIN InvoiceItem ii ON ih.INV_NUMBER = ii.INV_NUMBER) INNER JOIN CustomerDepartment cd ON (ii.DEPT = cd.DEPT) AND (ih.CUST_NUM = cd.CUST_NUM)"
        q = q & " " & SF
        q = q & " ORDER BY ih.ROUTE, ih.SEQUENCE, ih.INV_NUMBER, ii.DEPT, ii.LINE_TYPE, ii.ITEM_NUM"
        'IRS.Open q, DB, adOpenStatic

        LastInv = 0

        While Not IRS.EOF
            If IRS!INV_NUMBER <> LastInv Then
                If LastInv > 0 Then
                    'GoSub InvTotal
                End If

                PageCt = 1
                'GoSub Heading
                LastDept = 0
                LastInv = IRS!INV_NUMBER

                If IRS!PAY_TYPE = "A" Then
                    SvTerms = True
                Else
                    SvTerms = False
                End If

                If IsDBNull(IRS!TAX_MON) Then
                    SvTax = 0
                Else
                    SvTax = IRS!TAX_MON
                End If

                If IsDBNull(IRS!INV_TOTAL) Then
                    SvTotal = 0
                Else
                    SvTotal = IRS!INV_TOTAL
                End If

                ICt = ICt + 1
            End If

            If LineCt > 24 Then
                'GoSub FullPage
                'GoSub Heading
            End If

            If IRS!DEPT <> LastDept Then
                'GoSub PrintDept
                LastDept = IRS!DEPT
            End If

            'GoSub PrintLine

            strOCR = Space(intLeftMargin) &
            Strings.Left(Trim(IRS!DEL_NAME) & Space(intDEL_NAME_LENGTH), intDEL_NAME_LENGTH) &
            Strings.Left(Trim(IRS!CUST_NUM) & Space(intCUST_NUM_LENGTH), intCUST_NUM_LENGTH) &
            Strings.Left(Trim(IRS!INV_NUMBER) & Space(intINV_NUMBER_LENGTH), intINV_NUMBER_LENGTH)

            strOCR2 = Space(intLeftMargin) &
            Strings.Left(Format(IRS![Date], "Short Date") & Space(intDATE_LENGTH), intDATE_LENGTH) &
            Trim(IRS!ROUTE)

            IRS.MoveNext()
        End While

        If LastInv > 0 Then
            'GoSub InvTotal
        End If

        'Close #CH
        'IRS.Close()

        lblStatus.Text = "Printed " & ICt & " invoices for " & Format(RunDate, "Short Date")
        lblStatus.Update()

        Exit Sub

Heading:

        If PageCt = 1 And Not IsDBNull(IRS!CHANGE_MEMO) Then
            'Print #CH, IRS!CHANGE_MEMO
        Else
            'Print #CH, ""
        End If

        If IRS!PAY_TYPE = "A" Then
            q = "* CHARGE *"
        Else
            If IRS!PAY_TYPE = "I" Then
                q = "** CASH **"
            Else
                q = "CREDIT CARD"
            End If
        End If

        'Print #CH, IRS!DEL_NAME; Tab(33); q
        'Print #CH, IRS!DEL_ADDR; Tab(32); IRS!INV_NUMBER; Tab(47); PageCt
        'Print #CH, IRS!DEL_CITY; ", "; IRS!DEL_STATE; " "; IRS!DEL_ZIP; Tab(33); Format(IRS![Date], "Short Date"); Tab(47); IIf(IsNull(IRS!Weekday), "", IRS!Weekday)
        'Print #CH, TAB(32); IRS!CUST_NUM; Tab(43); IRS!ROUTE; "-"; RJust(IRS!SEQUENCE, 5, 1)
        'Print #CH, ""
        'Print #CH, ""
        LineCt = 8
        Return

PrintDept:

        'Print #CH, "Dept  "; IRS!DEPT; "  "; IIf(Not IsNull(IRS!MESSAGE), IRS!MESSAGE, "")
        LineCt = LineCt + 1
        Return

PrintLine:

        'Print #CH, RJust(IRS!REQ_QTY, 5, 0); " "; IIf(Not IsNull(IRS!ITEM_DESC), IRS!ITEM_DESC, ""); Tab(28); IIf(Not IsNull(IRS!NAME_SIZE), IRS!NAME_SIZE, ""); Tab(48); RJust(IRS!ITEM_NUM, 6, 0); RJust(IRS!INV_QTY, 6, 0); Tab(65); RJust(RoundOff(IIf(Not IsNull(IRS!BILL_QTY), IRS!BILL_QTY, 0) * IIf(Not IsNull(IRS!UNIT_PRICE), IRS!UNIT_PRICE, 0)), 9, 2)
        LineCt = LineCt + 1
        Return

FullPage:

        For i = LineCt To 33
            'Print #CH, ""
        Next i

        PageCt = PageCt + 1
        Return

InvTotal:

        For i = LineCt + 1 To 26
            'Print #CH, ""
        Next i

        If SvTax <> 0 Then
            'Print #CH, TAB(53); "State/City Tax"; RJust(SvTax, 9, 2)
        Else
            'Print #CH, ""
        End If

        'Print #CH, TAB(53); "Invoice Total "; RJust(SvTotal, 9, 2)
        'Print #CH, strOCR
        'Print #CH, ""
        'Print #CH, strOCR2

        LineCt = 31

        'GoSub FullPage
        Return

        Exit Sub

pport1err:
        'Try pport2
        Resume TryPport2

    End Sub

    Private Sub chkDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkDate.CheckedChanged

        If chkDate.Checked Then
            datDate.Enabled = True
        Else
            datDate.Enabled = False
        End If

    End Sub

    Private Sub chkNumber_CheckedChanged(sender As Object, e As EventArgs) Handles chkNumber.CheckedChanged

        If chkNumber.Checked Then
            txtNumber0.Enabled = True
            txtNumber1.Enabled = True
        Else
            txtNumber0.Enabled = False
            txtNumber1.Enabled = False
        End If

    End Sub

    Private Sub datDate_UpDownButtonClick(sender As Object, e As UpDownButtonClickEventArgs) Handles datDate.UpDownButtonClick

        ' Old code - If up arrow is clicked, datespin = 1; if down arrow clicked, datespin = -1
        'DateSpin = CDate(NewDate) - CDate(OldDate)

        ' New code, same result
        ' e.delta - up = 1, down = -1
        DateSpin = e.Delta

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        Dim D1 As Integer

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

    Private Sub txtRoute0_TextChanged(sender As Object, e As EventArgs) Handles txtRoute0.TextChanged

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

End Class