Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmInvHead

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim CurState As String
    Dim bCancel As Boolean
    Dim ItemTot As Double, ItemTaxable As Double, ItemCount As Integer
    Dim OldRoute As Integer, OldDept As Integer, OldTax As Single
    Dim LastDate As Date
    Dim bTextChanged As Boolean

    Private Sub frmInvHead_Load(tb As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 33, 33)

        buserchange = False
        bInit = True

        Line1.Y2 = Me.Height

        'Set text box lengths based on tabledef
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is C1.Win.C1Input.C1TextBox Then
                Dim c1tb As C1.Win.C1Input.C1TextBox = ctrl

                Select Case c1tb.DataType.ToString
                    Case "System.Int16"
                        c1tb.MaxLength = 5
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer
                    Case "System.Int32"
                        c1tb.MaxLength = 10
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer
                    Case "System.Int64"
                        c1tb.MaxLength = 19
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer
                    Case "System.Integer"
                        c1tb.MaxLength = 10
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer
                    Case "System.Double"
                        c1tb.MaxLength = 10
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
                    Case "System.Single"
                        c1tb.MaxLength = 10
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
                    Case "System.Decimal"
                        c1tb.MaxLength = 10
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
                    Case "System.String"
                        If c1tb.DataField <> "" Then
                            c1tb.MaxLength = DsInvoiceHeader.InvoiceHeader.Columns(c1tb.DataField).MaxLength
                        End If
                    Case "System.DateTime"
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
                    Case Else
                        MsgBox(c1tb.Name & ": " & c1tb.DataType.ToString)
                End Select
            End If
        Next

        bInit = False

        GetCalcLog()

        If CurInvoice < 1 Then
            frmFindInvoice.Show()
            frmFindInvoice.BringToFront()
        Else
            lblCurInvoice.Text = ""
            lblCurInvoice.Text = CurInvoice

            GetItemInfo()

            If Val(txtData13.Text) <> ItemTot Then
                GetData() 'cmdCalc_Click
            End If

            bInit = False
            buserchange = True
        End If

    End Sub

    Private Sub frmInvHead_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'buserchange = False
        SaveWindowPos(Me)

    End Sub

    Private Sub lblCurCust_TextChanged(tb As Object, e As EventArgs) Handles lblCurCust.TextChanged

        'If Me.Visible = True Then
        buserchange = False

            If cmdReset.Enabled Then
                txtData1.Text = CurCust
                'txtData_LostFocus 1
            End If

            buserchange = True
            bInit = False
        'End If

    End Sub

    Private Sub lblCurInvoice_TextChanged(tb As Object, e As EventArgs) Handles lblCurInvoice.TextChanged

        If Me.Visible = True Then
            buserchange = False
            GetData()
            buserchange = True
        End If

    End Sub

    Private Sub lstDept_SelectedIndexChanged(tb As Object, e As EventArgs) Handles lstDept.SelectedIndexChanged

        If buserchange And CurDept <> lstDept.SelectedValue Then
            If Not cmdReset.Enabled Then
                SetModeChange()
            End If

            CurDept = lstDept.SelectedValue

            GetData3()

            buserchange = False

            txtData2.Text = CurDept

            GetData9()

            buserchange = True
        End If

    End Sub

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs) Handles txtData0.TextChanged, txtData9.TextChanged, txtData8.TextChanged, txtData7.TextChanged, txtData6.TextChanged, txtData5.TextChanged, txtData4.TextChanged, txtData3.TextChanged, txtData2.TextChanged, txtData15.TextChanged, txtData14.TextChanged, txtData13.TextChanged, txtData10.TextChanged, txtData1.TextChanged, datData0.TextChanged

        Dim tb As TextBox = sender

        If tb.Name <> "txtData13" And tb.Name <> "txtData14" And tb.Name <> "txtData15" Then
            bTextChanged = True
        End If

        If buserchange Then
            SetModeChange()
        End If

        If buserchange Then
            If Not cmdReset.Enabled Then SetModeChange()
        Else
            Try
                Me.Cursor = Cursors.WaitCursor

                'Handle invisible boxes
                Select Case tb.Name
                    Case "txtData2"
                        strLocation = "TD0TC1.0"
                        'lstDept.BoundText = txtData2.Text
                        lstDept.SelectedIndex = lstDept.FindStringExact(txtData2.Text)
                    Case "txtData6"
                        strLocation = "TD0TC2.0"
                        cmbTax.SelectedIndex = cmbTax.FindStringExact(txtData6.Text)
                    'cmbTax.BoundText = txtData6.Text
                    Case "txtData10"
                        strLocation = "TD0TC3.0"
                        If txtData10.Text = "A" Then
                            chkCC.Visible = False
                        Else
                            chkCC.Visible = True
                            If txtData10.Text = "C" Then
                                chkCC.Checked = True
                            Else
                                chkCC.Checked = False
                            End If
                        End If
                End Select

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine txtData0_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "txtData0_TextChanged", vbOK)
                LogError(Me.Name, "txtData0_TextChanged", strLocation, ex.Message)
            End Try
        End If

        Try
            Me.Cursor = Cursors.WaitCursor

            Select Case tb.Name
                Case "txtData1"
                    'GetData2 (handled in txtdata_lostfocus, GetData)
                    If txtData1.Text > "" Then
                        GetData2()

                        strLocation = "TD0TC4.0"
                        If DsInvoiceHeader.InvoiceHeader.Rows.Count = 0 Then
                            MessageBox.Show(Me, "Customer missing department or route.", "Validation Error", vbOKOnly)
                            txtData1.Select()
                            Exit Sub
                        End If

                        'If RS4.RecordCount = 0 Then
                        strLocation = "TD0TC5.0"
                        If txtCustName.Text.Trim = "" Then
                            MessageBox.Show(Me, "Customer not found.", "Validation Error", vbOKOnly)
                            txtData1.Select()
                            Exit Sub
                        End If

                        buserchange = False

                        strLocation = "TD0TC6.0"
                        txtData2.Text = lstDept.SelectedValue

                        strLocation = "TD0TC7.0"
                        GetData9()

                        buserchange = True
                    End If

                Case "txtData2" 'dept
                'GetData9
                Case "txtData5"
                    GetTaxCodes()
                Case "txtData7" 'tax amount
                    strLocation = "TD0TC8.0"
                    txtData14.Text = txtData7.Text
                Case "txtData13", "txtData14", "txtData15"
                    ' Done in format of textbox
                    strLocation = "TD0TC9.0"
                    If tb.Name <> "txtData15" And buserchange Then
                        txtData15.Text = Val(txtData13.Text) + Val(txtData14.Text)
                    End If
                    txtData13.Text = Format(Val(txtData13.Text), "#####0.00")
                    txtData14.Text = Format(Val(txtData14.Text), "#####0.00")
                    txtData15.Text = Format(Val(txtData15.Text), "#####0.00")
            End Select

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine txtData0_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "txtData0_TextChanged", vbOK)
            LogError(Me.Name, "txtData0_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Sub GetData()

        If CurInvoice > 0 Then
            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "GD1.0"
                InvoiceHeaderTableAdapter.Connection.ConnectionString = CS
                InvoiceHeaderTableAdapter.Fill(DsInvoiceHeader.InvoiceHeader, CurInvoice)
                '    data1.RecordSource = "Select * from InvoiceHeader Where INV_NUMBER=" & CurInvoice
                '    rs = data1.Recordset

                strLocation = "GD2.0"
                If DsInvoiceHeader.InvoiceHeader.Rows.Count = 0 Then
                    frmFindInvoice.Show()
                    frmFindInvoice.BringToFront()

                    Exit Sub
                End If

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
                LogError(Me.Name, "GetData", strLocation, ex.Message)
            End Try
        Else
            frmFindInvoice.Show()
            frmFindInvoice.BringToFront()

            Exit Sub
        End If

        CurDate = DsInvoiceHeader.InvoiceHeader(0)("DATE")
        CurDept = DsInvoiceHeader.InvoiceHeader(0)("DEPT")

        GetData2()

        SetModeReg()

    End Sub

    Sub GetData2()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GDT1.0"
            CurCust = DsInvoiceHeader.InvoiceHeader(0)("CUST_NUM")

            'Get customer departments
            strLocation = "GDT2.0"
            SpGetCustDeptsTableAdapter.Connection.ConnectionString = CS
            SpGetCustDeptsTableAdapter.Fill(DsspGetCustDepts.spGetCustDepts, CurCust)
            'data2.RecordSource = q
            'RS2 = data2.Recordset

            strLocation = "GDT3.0"
            GetData3()

            'Get customer info
            strLocation = "GDT4.0"
            CustomerMasterTableAdapter.Connection.ConnectionString = CS
            CustomerMasterTableAdapter.Fill(DS_CustomerMaster.CustomerMaster, CurCust)
            'q = "SELECT * FROM CustomerMaster WHERE CUST_NUM=" & CurCust
            'Call RS4.Open(q, DB, adOpenStatic)
            If DS_CustomerMaster.CustomerMaster.Rows.Count > 0 Then
                txtCustName.Text = DS_CustomerMaster.CustomerMaster.Rows(0)("BILL_NAME")
            Else
                txtCustName.Text = ""
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine GetData2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData2", vbOK)
            LogError(Me.Name, "GetData2", strLocation, ex.Message)
        End Try

    End Sub

    Sub GetData3()

        Dim intRow As Integer

        Try
            If DsspGetCustDepts.spGetCustDepts.Rows.Count > 0 Then
                SpGetCustDeptsBindingSource.MoveFirst()

                intRow = SpGetCustDeptsBindingSource.Find("DEPT", CurDept)

                If intRow >= 0 Then
                    SpGetCustDeptsBindingSource.Position = intRow
                    'lstDept.BoundText = RS2!DEPT
                End If

                CurDept = txtData2.Text
                txtCustDept.Text = DsspGetCustDepts.spGetCustDepts(SpGetCustDeptsBindingSource.Position)("DEL_NAME")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Sub GetData9()

        Dim route1 As Integer, route2 As Integer

        If Not bInit Then
            Try
                If SpGetCustDeptsBindingSource.Position >= 0 Then
                    strLocation = "GDN1.0"
                    route1 = 0
                    route1 = DsspGetCustDepts.spGetCustDepts.Rows(SpGetCustDeptsBindingSource.Position)("FirstofROUTE")
                    If route1 = 9 Then
                        route2 = 0
                        route2 = DsspGetCustDepts.spGetCustDepts.Rows(SpGetCustDeptsBindingSource.Position)("FirstofDEF_ROUTE")
                        If route2 <> 0 Then route1 = route2
                    End If
                    strLocation = "GDN2.0"
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("ROUTE") = CStr(route1)
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("SEQUENCE") = CStr(DsspGetCustDepts.spGetCustDepts.Rows(SpGetCustDeptsBindingSource.Position)("FirstofSEQUENCE"))
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("TAX_ST") = DsspGetCustDepts.spGetCustDepts.Rows(SpGetCustDeptsBindingSource.Position)("DEL_STATE")
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("TAX_LOCODE") = ""
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("TAX_LOCODE") = DsspGetCustDepts.spGetCustDepts.Rows(SpGetCustDeptsBindingSource.Position)("TAX_LOCODE")
                    'lstDept.BoundText = RS2!DEPT
                    'txtData(2).Text = CStr(RS2!DEPT)
                    strLocation = "GDN3.0"
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("CALCULATED") = 0
                    strLocation = "GDN4.0"
                    DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("PAY_TYPE") = DS_CustomerMaster.CustomerMaster.Rows(0)("PAY_TYPE")
                    If IsDBNull(DS_CustomerMaster.CustomerMaster.Rows(0)("CC_NUM")) = False Then
                        If DS_CustomerMaster.CustomerMaster.Rows(0)("PAY_TYPE") = "I" And DS_CustomerMaster.CustomerMaster.Rows(0)("CC_NUM") > "" Then
                            DsInvoiceHeader.InvoiceHeader(InvoiceHeaderBindingSource.Position)("PAY_TYPE") = "C"
                        End If
                    End If
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetData9 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData9", vbOK)
                LogError(Me.Name, "GetData9", strLocation, ex.Message)
                If Dir("StopOnError.txt") <> "" Then
                    Stop
                End If

            End Try
        End If

    End Sub

    Sub GetItemInfo()

        'Sets item variables on current invoice
        ItemTot = 0
        ItemTaxable = 0
        ItemCount = 0

        If CurInvoice = 0 Then
            Exit Sub
        End If

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "GII1.0"
                connection.Open()

                strLocation = "GII2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spGetInvInfo"
                cmd.Parameters.Add("Invnum", SqlDbType.Int).Value = CurInvoice

                strLocation = "GII3.0"
                Using sqlReader = cmd.ExecuteReader()
                    If sqlReader.HasRows = True Then
                        strLocation = "GII4.0"
                        sqlReader.Read()

                        strLocation = "GII5.0"
                        If Not IsDBNull(sqlReader("ext")) Then
                            ItemTot = sqlReader("ext")
                        End If

                        strLocation = "GII6.0"
                        If Not IsDBNull(sqlReader("TAXBASIS")) Then
                            ItemTaxable = sqlReader("TAXBASIS")
                        End If

                        strLocation = "GII7.0"
                        ItemCount = sqlReader("Cnt")
                    End If
                End Using
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetItemInfo (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetItemInfo", vbOK)
                LogError(Me.Name, "GetItemInfo", strLocation, ex.Message)
                If Dir("StopOnError.txt") <> "" Then
                    Stop
                End If
            End Try

        End Using

        lblStatus.Text = "Invoice has " & CStr(ItemCount) & " items."
        If ItemCount = 0 Then
            cmdLoad.Enabled = True
            cmdCalc.Enabled = False
        Else
            cmdLoad.Enabled = False
            cmdCalc.Enabled = True
        End If

    End Sub

    Sub GetTaxCodes()

        If txtData5.Text <> CurState Then
            CurState = txtData5.Text

            SpGetTaxCodesTableAdapter.Connection.ConnectionString = CS
            SpGetTaxCodesTableAdapter.Fill(DsspGetTaxCodes.spGetTaxCodes, CurState)
            'q = "spGetTaxCodes '" & CurState & "'"
            'data3.RecordSource = q
            'data3.Enabled = True
            'data3.Refresh

            cmbTax.Text = ""
            If txtData6.Text <> "" Then
                cmbTax.SelectedIndex = lstDept.FindStringExact(txtData6.Text)
            End If
        End If

    End Sub

    Sub GetCalcLog()

        Dim q As String

        q = "SELECT Max(Rundate) RunDate FROM CalcLog Where ProcessDate>0"

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(q, connection)

            Try
                strLocation = "GCL1.0"
                connection.Open()
                LastDate = cmd.ExecuteScalar()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetCalcLog (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetCalcLog", vbOK)
                LogError(Me.Name, "GetCalcLog", strLocation, ex.Message)
            End Try

        End Using

        'If CLRS.EOF Then
        '    LastDate = 0
        'Else
        '    LastDate = CLRS!RunDate
        'End If

    End Sub
    Private Sub UpdateInvoiceQty()

        '        Dim Memo As String
        '        'Record changes in InvoiceQty
        '        Memo = ""
        '        If Val(txtData(2)) <> OldDept Then Memo = "Dept changed from " & CStr(OldDept) & " to " & txtData(2) & " "
        '        If Val(txtData(3)) <> OldRoute Then Memo = Memo & "Route changed from " & CStr(OldRoute) & " to " & txtData(3)
        '        If Memo > "" Then
        '            On Error GoTo UpdateErr1
        '            RORS.AddNew
        '            RORS!INV_NUMBER = Val(txtData(0))
        '            RORS!DEPT = Val(txtData(2))
        '            RORS!Memo = Left(Memo, 50)
        '            RORS.Update
        '        End If
        '        OldDept = Val(txtData(2))
        '        OldRoute = Val(txtData(3))
        '        If Val(txtData(7)) <> OldTax Then
        '            On Error GoTo UpdateErr1
        '            RORS.AddNew
        '            RORS!INV_NUMBER = Val(txtData(0))
        '            RORS!DEPT = Val(txtData(2))
        '            RORS!ITEM_NUM = 999999
        '            RORS!LINE_TYPE = 0
        '            RORS!BILL_QTY = RoundOff(Val(txtData(7)) - OldTax)
        '            RORS.Update
        '            OldTax = Val(txtData(7))
        '        End If
        'RODone:
        '        CurDate = CDate(datData(0).Date)
        '        CurInvoice = CLng(txtData(0))
        '        CurCust = CLng(txtData(1))
        '        CurDept = CInt(txtData(2))

        '        Exit Sub

        'UpdateErr1:
        '        MsgBox Error, vbOKOnly, "Error updating InvoiceQty"
        'bCancel = True
        '        Resume RODone

    End Sub
    Private Sub UpdateCalcLog()

        'Dim q As String
        'q = "Update CalcLog Set LastChange=Getdate() Where RunDate='" & Format(CurDate, "MM/DD/YYYY") & "'"
        'Dim ADOCmd As New ADODB.Command
        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandText = q
        '    .Execute
        'End With

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

    End Sub

    Sub closedata()

        'On Error Resume Next
        'rs.Close
        'RORS.Close

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Public Sub SetModeChange()

        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFindCust.Enabled = False
        cmdExit.Enabled = False
        cmdFindInv.Enabled = False
        cmdLoad.Enabled = False
        cmdItem.Enabled = False
        OldRoute = 0
        OldDept = 0
        OldTax = 0

        'OldRoute = rs!ROUTE
        'OldDept = rs!DEPT
        'OldTax = rs!TAX_MON

    End Sub

    Public Sub SetModeAdd()

        txtData0.Text = "(New)"
        'txtData0.DataChanged = False
        datData0.Value = Format(Now, "MM/DD/YYYY")

        SetModeChange()

        cmdFindCust.Enabled = True
        cmdCalc.Enabled = False
        txtData1.Enabled = True
        txtData5.Enabled = True
        txtData6.Enabled = True
        datData0.Enabled = True

        lblStatus.Text = ""
        'rs!CUST_NUM = CStr(CurCust)

        'txtData_LostFocus 1

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True

        If ItemCount = 0 Then
            cmdDelete.Enabled = True
            cmdCalc.Enabled = False
        Else
            cmdDelete.Enabled = False
            cmdCalc.Enabled = True
        End If

        cmdItem.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindInv.Enabled = True
        cmdFindCust.Enabled = False
        txtData1.Enabled = False
        txtData5.Enabled = False
        txtData6.Enabled = False
        datData0.Enabled = False

    End Sub

End Class