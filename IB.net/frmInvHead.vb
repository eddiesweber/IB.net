Option Explicit On

Imports System.Data.SqlClient

Public Class frmInvHead

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim CurState As String
    Dim bCancel As Boolean
    Dim ItemTot As Single, ItemTaxable As Single, ItemCount As Integer
    Dim OldRoute As Integer, OldDept As Integer, OldTax As Single
    Dim LastDate As Date
    Dim bTextChanged As Boolean

    Private Sub frmInvHead_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 33, 33)

        buserchange = False
        bInit = True

        'data1.ConnectionString = CS
        'data2.ConnectionString = CS
        'data3.ConnectionString = CS
        'data1.RecordSource = "Select * From InvoiceHeader Where 1=0"
        'data1.Enabled = True
        'data1.Refresh

        'rs = data1.Recordset
        'Call RORS.Open("InvoiceQty", DB, adOpenDynamic, adLockOptimistic)

        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        ''Set text box lengths based on tabledef
        'Dim c As Control, fld As String

        'For Each c In Me.Controls
        '    If TypeOf c Is TextBox Then
        '        fld = c.DataField
        '        If fld > "" Then
        '            Select Case rs.Fields(fld).Type
        '                Case adChar, adVarChar, adVarWChar
        '                    c.MaxLength = rs.Fields(fld).DefinedSize
        '                Case adTinyInt
        '                    c.MaxLength = 1
        '                Case adSmallInt
        '                    c.MaxLength = 5
        '                Case adInteger, adSingle
        '                    c.MaxLength = 10
        '                Case Else
        '                    c.MaxLength = 20
        '            End Select
        '        End If
        '    End If
        'Next c

        'Me.Show
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

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False

        If cmdReset.Enabled Then
            txtData1.Text = CurCust
            'txtData_LostFocus 1
        End If

        buserchange = True
        bInit = False

    End Sub

    Private Sub lblCurInvoice_TextChanged(sender As Object, e As EventArgs) Handles lblCurInvoice.TextChanged

        buserchange = False
        GetData()
        buserchange = True

    End Sub

    Private Sub lstDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDept.SelectedIndexChanged

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

        If sender.name <> "txtData13" And sender.name <> "txtData14" And sender.name <> "txtData15" Then
            bTextChanged = True
        End If

        If buserchange Then
            SetModeChange()
        End If

        If buserchange Then
            If Not cmdReset.Enabled Then SetModeChange()
        Else
            'Handle invisible boxes
            Select Case sender.name
                Case "txtData2"
                    'lstDept.BoundText = txtData2.Text
                    lstDept.SelectedIndex = lstDept.FindStringExact(txtData2.Text)
                Case "txtData6"
                    cmbTax.SelectedIndex = cmbTax.FindStringExact(txtData6.Text)
                    'cmbTax.BoundText = txtData6.Text
                Case "txtData10"
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
        End If
        Select Case sender.name
            Case "txtData1"
                'GetData2 (handled in txtdata_lostfocus, GetData)
                If txtData1.Text > "" Then
                    GetData2()

                    If DsInvoiceHeader.InvoiceHeader.Rows.Count = 0 Then
                        MessageBox.Show(Me, "Customer missing department or route.", "Validation Error", vbOKOnly)
                        txtData1.Select()
                        Exit Sub
                    End If

                    'If RS4.RecordCount = 0 Then
                    If txtCustName.Text.Trim = "" Then
                        MessageBox.Show(Me, "Customer not found.", "Validation Error", vbOKOnly)
                        txtData1.Select()
                        Exit Sub
                    End If

                    buserchange = False

                    txtData2.Text = lstDept.SelectedValue

                    GetData9()

                    buserchange = True
                End If

            Case "txtData2" 'dept
                'GetData9
            Case "txtData5"
                GetTaxCodes()
            Case "txtData7" 'tax amount
                txtData14.Text = txtData7.Text
            Case "txtData13", "txtData14", "txtData15"
                sender.text = Format(Val(sender.text), "#####0.00")

                If sender.text <> "txtData15" And buserchange Then
                    txtData15.Text = Val(txtData13.Text) + Val(txtData14.Text)
                End If
        End Select

    End Sub

    Sub GetData()

        If CurInvoice > 0 Then
            InvoiceHeaderTableAdapter.Connection.ConnectionString = CS
            InvoiceHeaderTableAdapter.Fill(DsInvoiceHeader.InvoiceHeader, CurInvoice)
            '    data1.RecordSource = "Select * from InvoiceHeader Where INV_NUMBER=" & CurInvoice
            '    rs = data1.Recordset

            If DsInvoiceHeader.InvoiceHeader.Rows.Count = 0 Then
                frmFindInvoice.Show()
                frmFindInvoice.BringToFront()

                Exit Sub
            End If
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

        Dim q As String

        CurCust = DsInvoiceHeader.InvoiceHeader(0)("CUST_NUM")

        'Get customer departments
        SpGetCustDeptsTableAdapter.Connection.ConnectionString = CS
        SpGetCustDeptsTableAdapter.Fill(DsspGetCustDepts.spGetCustDepts, CurCust)
        'data2.RecordSource = q
        'RS2 = data2.Recordset

        GetData3()

        'Get customer info
        txtCustName.Text = GetCustName()

    End Sub

    Sub GetData3()

        Dim intRow As Integer

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

    End Sub

    Sub GetData9()

        'Dim route1 As Integer, route2 As Integer

        'If Not bInit Then
        '    'RS2.MoveFirst
        '    'RS2.Find "Dept=" & txtData(2)
        '    On Error Resume Next
        '    route1 = 0
        '    route1 = RS2!FirstofROUTE
        '    If route1 = 9 Then
        '        route2 = 0
        '        route2 = RS2!FirstofDEF_ROUTE
        '        If route2 <> 0 Then route1 = route2
        '    End If
        '    rs!ROUTE = CStr(route1)
        '    rs![SEQUENCE] = CStr(RS2!FirstofSEQUENCE)
        '    rs!TAX_ST = RS2!DEL_STATE
        '    rs!TAX_LOCODE = ""
        '    rs!TAX_LOCODE = RS2!TAX_LOCODE
        '    'lstDept.BoundText = RS2!DEPT
        '    'txtData(2).Text = CStr(RS2!DEPT)
        '    rs!CALCULATED = 0
        '    If RS4!PAY_TYPE = "I" And RS4!CC_NUM > "" Then
        '        rs!PAY_TYPE = "C"
        '    Else
        '        rs!PAY_TYPE = RS4!PAY_TYPE
        '    End If
        'End If

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
                        If Not sqlReader.IsDBNull("ext") Then
                            ItemTot = sqlReader("ext")
                        End If

                        strLocation = "GII6.0"
                        If Not sqlReader.IsDBNull("TAXBASIS") Then
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

        'If txtData(5).Text <> CurState Then
        '    Dim q As String, q1 As String
        '    CurState = txtData(5).Text
        '    q = "spGetTaxCodes '" & CurState & "'"
        '    data3.RecordSource = q
        '    data3.Enabled = True
        '    data3.Refresh
        '    cmbTax.BoundText = txtData(6).Text
        '    If data3.Recordset.BOF And data3.Recordset.EOF Then cmbTax.Text = ""
        'End If

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

    Sub closedata()

        'On Error Resume Next
        'rs.Close
        'RORS.Close

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