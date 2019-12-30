Option Explicit On

Imports System.Data.SqlClient

Public Class frmInvItem

    'Dim rstemp As Recordset
    Dim buserchange As Boolean
    Dim qtychgflag(0 To 3) As Integer
    Dim bInit As Boolean
    Dim SalesOpt As Integer
    Dim bCancel As Boolean
    Dim stdCode As String
    Dim CLRS As New ADODB.Recordset

    Private Sub frmInvItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 33, 33)

        bInit = True
        buserchange = False

        lblCurItem.Text = ""
        lblCurInvoice.Text = ""

        SpGetSalesmenTableAdapter.Connection.ConnectionString = CS
        SpGetSalesmenTableAdapter.Fill(Me.DsspGetSalesmen.spGetSalesmen)
        'Data5.ConnectionString = CS
        'Data5.RecordSource = "spGetSalesmen"
        'Data5.Enabled = True
        'Data5.Refresh

        SpGetVolCodesTableAdapter.Connection.ConnectionString = CS
        SpGetVolCodesTableAdapter.Fill(Me.DsspGetVolCodes.spGetVolCodes)
        'data3.ConnectionString = CS
        'data3.RecordSource = "spGetVolCodes"
        'data3.Enabled = True
        'data3.Refresh

        'data1.ConnectionString = CS
        ''Call RORS.Open("InvoiceQty", DB, adOpenDynamic, adLockOptimistic)

        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        ''Set text box lengths based on tabledef
        'Dim c As Control, fld As String
        'Dim R As New ADODB.Recordset
        'R.Open "Select * from InvoiceItem Where 1=0", DB, adOpenStatic
        'For Each c In Me.Controls
        '    If c.Name = "txtData" Then
        '        fld = c.DataField
        '        If fld > "" Then
        '            Select Case R.Fields(fld).Type
        '                Case adChar, adVarChar, adVarWChar
        '                    c.MaxLength = R.Fields(fld).DefinedSize
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
        'R.Close()

        GetCalcLog()

        If CurInvoice = 0 Then
            frmFindInvoice.Show()
            frmFindInvoice.BringToFront()
        Else
            lblCurInvoice.Text = CurInvoice
        End If

    End Sub

    Private Sub lblCurInvoice_TextChanged(sender As Object, e As EventArgs) Handles lblCurInvoice.TextChanged

        buserchange = False
        bInit = True

        If cmdReset.Enabled = False Then
            GetData()
        End If

        buserchange = True
        bInit = False

    End Sub

    Private Sub lblCurItem_TextChanged(sender As Object, e As EventArgs) Handles lblCurItem.TextChanged

        'If rs.EditMode = adEditAdd Then
        '    rs!ITEM_NUM = CStr(CurItem)
        '    txtData(2).SetFocus
        'End If

    End Sub

    Sub GetData()

        'Dim q As String, q1 As String

        ''Get invoiceitems
        SpGetInvItemsTableAdapter.Connection.ConnectionString = CS
        SpGetInvItemsTableAdapter.Fill(DsspGetInvItems.spGetInvItems, CurInvoice)
        'q = "spGetInvItems (" & CurInvoice & ")"
        'data1.RecordSource = q
        'data1.Enabled = True
        'rs = data1.Recordset
        'data1.Refresh
        'rs = data1.Recordset

        ''Get customer dept name
        'On Error Resume Next
        'RS2.Close()
        SpGetInvNameTableAdapter.Connection.ConnectionString = CS
        SpGetInvNameTableAdapter.Fill(DsspGetInvName.spGetInvName, CurInvoice)
        'q = "spGetInvName " & CurInvoice
        'Call RS2.Open(q, DB, adOpenStatic)
        'txtCustDept.Text = RS2!DEL_NAME

        GetData3()

    End Sub

    Sub GetData3()

        'Goto current customer item
        If DsspGetInvItems.spGetInvItems.Rows.Count = 0 Then
            cmdNew.PerformClick()
        Else
            If CurItem > 0 Then
                'If RS Is Nothing Then Exit Sub
                SpGetInvItemsBindingSource.MoveFirst()
                SpGetInvItemsBindingSource.Find("ITEM_NUM", CurItem)
                If SpGetInvItemsBindingSource.Position = 0 Then
                    SpGetInvItemsBindingSource.MoveFirst()
                End If
            Else
                SpGetInvItemsBindingSource.MoveFirst()
            End If

            SetModeReg
            SetControls()
            stdCode = ""
        End If

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindInv.Enabled = True
        txtData2.Visible = False
        lstItem.Visible = True
        cmdFindItem.Visible = False

    End Sub

    Sub GetStdCode()

        Dim ITyp As String
        Dim INum As Long

        ITyp = "R"
        INum = txtData2.Text

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("SELECT VOL_CAT FROM ItemMasterR WHERE ITEM_NUM=" & CStr(INum), connection)

            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "GSC1.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = False Then
                    strLocation = "GSC2.0"
                    dataReader.Close()
                    ITyp = "O"

                    strLocation = "GSC3.0"
                    cmd.CommandText = "SELECT VOL_CAT FROM ItemMasterO WHERE ITEM_NUM=" & INum
                    dataReader = cmd.ExecuteReader()
                    'q = "SELECT VOL_CAT FROM ItemMasterO WHERE ITEM_NUM=" & INum
                    'Call rstemp.Open(q, DB, adOpenStatic)
                End If
                If dataReader.HasRows Then
                    strLocation = "GSC4.0"
                    dataReader.Read()
                    stdCode = ITyp & dataReader("VOL_CAT")
                End If

                'If rstemp.EOF Then
                '    rstemp.Close()
                '    ITyp = "O"
                '    q = "SELECT VOL_CAT FROM ItemMasterO WHERE ITEM_NUM=" & INum
                '    Call rstemp.Open(q, DB, adOpenStatic)
                'End If
                'If Not rstemp.EOF Then stdCode = ITyp & dataReader("VOL_CAT")
                'rstemp.Close()
                dataReader.Close()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
                LogError(Me.Name, "GetData", strLocation, ex.Message)
            End Try
        End Using

        'Dim rstemp As New ADODB.Recordset, q As String, ITyp As String * 1, INum As Long
        'ITyp = "R"
        'INum = txtData(2)
        'q = "SELECT VOL_CAT FROM ItemMasterR WHERE ITEM_NUM=" & CStr(INum)
        'Call rstemp.Open(q, DB, adOpenStatic)
        'If rstemp.EOF Then
        '    rstemp.Close()
        '    ITyp = "O"
        '    q = "SELECT VOL_CAT FROM ItemMasterO WHERE ITEM_NUM=" & INum
        '    Call rstemp.Open(q, DB, adOpenStatic)
        'End If
        'If Not rstemp.EOF Then stdCode = ITyp & rstemp!VOL_CAT
        'rstemp.Close()

    End Sub

    Sub SetScreen()

        If optAction1.Checked Then
            txtChange1.Enabled = False
            txtChange3.Enabled = False
            scrChange1.Enabled = False
            scrChange3.Enabled = False
            txtData11.Enabled = False
            txtData13.Enabled = False
            scrQty11.Enabled = False
            scrQty13.Enabled = False
            txtData19.Visible = False
            txtTotal.Visible = False
            lblLabel6.Visible = False
            txtChange0.Enabled = True
            scrChange0.Enabled = True
            txtData10.Enabled = True
            scrQty10.Enabled = True
        Else
            txtChange1.Enabled = True
            txtChange3.Enabled = True
            scrChange1.Enabled = True
            scrChange3.Enabled = True
            txtData11.Enabled = True
            txtData13.Enabled = True
            scrQty11.Enabled = True
            scrQty13.Enabled = True
            txtData19.Visible = True
            txtTotal.Visible = True
            lblLabel6.Visible = True
            txtChange0.Enabled = False
            scrChange0.Enabled = False
            txtData10.Enabled = False
            scrQty10.Enabled = False
        End If

    End Sub

    Sub closedata()

        'On Error Resume Next
        'rs.Close()
        'CLRS.Close()
        'RS2.Close()

    End Sub

    Sub SetControls()

        'DsspGetInvItems.spGetInvItems.Rows

        Dim s As String, i As Integer
        buserchange = False

        On Error Resume Next
        txtCurrent0.Text = "0"
        txtCurrent0.Text = CStr(DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("LOAN_QTY"))
        txtCurrent1.Text = "0"
        txtCurrent1.Text = CStr(DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("INV_QTY"))
        txtCurrent2.Text = "0"
        txtCurrent2.Text = CStr(DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("REQ_QTY"))
        txtCurrent3.Text = "0"
        txtCurrent3.Text = CStr(DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("BILL_QTY"))
        For i = 0 To 3
            txtChange0.Text = "0"
            txtChange1.Text = "0"
            txtChange2.Text = "0"
            txtChange3.Text = "0"
        Next i

        SetSalesOpt()

        SetScreen()

    End Sub

    Sub SetSalesOpt()

        'Set up sales section on reposition or change
        Dim OldOpt As Integer, i As Integer
        OldOpt = SalesOpt
        If DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("Sales_2") > "0" Then
            optSales2.Checked = True
            txtData6.Enabled = True
            txtData9.Enabled = True
            txtData5.Enabled = True
            txtData8.Enabled = True
            'If txtData(6) > "" Then SalesOpt = 4 Else SalesOpt = 3
            GoTo ChkPct
        End If
        txtData6.Enabled = False
        txtData9.Enabled = False
        If DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("Sales_1") > "0" Then
            optSales1.Checked = True
            txtData5.Enabled = True
            txtData8.Enabled = True
            'SalesOpt = 2
            GoTo ChkPct
        End If
        txtData5.Enabled = False
        txtData8.Enabled = False
        optSales0.Checked = True
        'SalesOpt = 1

ChkPct:
        'Change default percents
        If buserchange Then
            If SalesOpt < 3 And SalesOpt <> OldOpt Then
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_1PCT") = 100
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_2PCT") = 0
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_3PCT") = 0
                Exit Sub
            End If
            If IsDBNull(DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_3")) And SalesOpt <> OldOpt Then
                'rs!SALES_1PCT = 50
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_2PCT") = 50
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_3PCT") = 0
            End If
            If DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_3") > "0" Then
                'rs!SALES_1PCT = 33.3
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_2PCT") = 33.3
                DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_3PCT") = 33.3
            End If
        End If

        For i = 0 To 2
            If i < SalesOpt Then
                Select Case i
                    Case 0
                        optSales0.Enabled = True
                    Case 1
                        optSales1.Enabled = True
                    Case 2
                        optSales2.Enabled = True
                End Select
                'optSales(i).Enabled = True
            Else
                Select Case i
                    Case 0
                        optSales0.Enabled = False
                    Case 1
                        optSales1.Enabled = False
                    Case 2
                        optSales2.Enabled = False
                End Select
                'optSales(i).Enabled = False
            End If
        Next i

    End Sub

    Sub SetSalesPct()

        ''Adjust so =100
        DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("SALES_1PCT") = CStr(100 - Val(txtData8.Text) - Val(txtData9.Text))

    End Sub

    Private Sub cmdFindInv_Click(sender As Object, e As EventArgs) Handles cmdFindInv.Click

        frmFindInvoice.Show()
        frmFindInvoice.BringToFront()

    End Sub

    Private Sub cmdFindItem_Click(sender As Object, e As EventArgs) Handles cmdFindItem.Click

        frmFindItem.Show()
        frmFindItem.BringToFront()

    End Sub

    Private Sub UpdateInvoiceQty(DelFlag As Boolean)

        Dim IQty As Single
        Dim LQty As Single
        Dim q As String
        Dim intRowsAffected As Integer

        CurItem = Val(txtData2.Text)

        If DelFlag Then
            IQty = 0 - DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("REQ_QTY")
            LQty = 0 - DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("BILL_QTY")
        Else
            IQty = Val(txtChange2.Text)
            LQty = Val(txtChange3.Text)
        End If

        If IQty <> 0 Or LQty <> 0 Then
            q = "Insert InvoiceQty (INV_NUMBER, DEPT, ITEM_NUM, LINE_TYPE, REQ_QTY, BILL_QTY, Memo)"
            q = q & " Values(" & DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("INV_NUMBER") & "," &
                                 DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("DEPT") & "," &
                                 DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("ITEM_NUM") & "," &
                                 DsspGetInvItems.spGetInvItems.Rows(SpGetInvItemsBindingSource.Position)("LINE_TYPE") & "," &
                                 IQty & "," & LQty & ",'" & txtMemo.Text & "')"
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand(q, connection)

                Try
                    strLocation = "UIQ"
                    connection.Open()
                    intRowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                    LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
                End Try
            End Using

            'With ADOCmd
            '    .ActiveConnection = DB
            '    .CommandText = q
            '    .Execute()
            'End With
        End If

        'If IQty <> 0 And Left(txtData3.Text, 1) = "O" Then
        If IQty <> 0 And Strings.Left(txtData3.Text, 1) = "O" Then
            'Adjust committed inventory
            q = GetItemDesc(CurItem) 'make sure curtype right
            q = "Update ItemMaster" & CurType
            q = q & " Set Committed=Committed+" & IQty
            q = q & " WHERE ITEM_NUM=" & CurItem

            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand(q, connection)

                Try
                    strLocation = "UIQ"
                    connection.Open()
                    intRowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                    LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
                End Try
            End Using
        End If

        'Update CalcLog
        Dim dtDate As Date = DsspGetInvName.spGetInvName.Rows(SpGetInvNameBindingSource.Position)("Date")
        If IsDate(dtDate) Then
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand("UPDATE CalcLog SET LastChange = now() WHERE RunDate = '" & dtDate, connection)

                Try
                    strLocation = "UIQ"
                    connection.Open()
                    intRowsAffected = cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                    LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
                End Try

            End Using
        End If
        'CLRS.MoveFirst()
        'CLRS.Find "RunDate=#" & Format(RS2![Date], "MM/DD/YYYY") & "#"
        'If Not CLRS.EOF Then
        '    CLRS!LastChange = Now()
        '    CLRS.Update()
        'End If

    End Sub

    Private Sub chkData_CheckedChanged(sender As Object, e As EventArgs) Handles chkData.CheckedChanged

        If buserchange Then
            SetModeChange
        End If

    End Sub

    Public Sub SetModeChange()

        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFindInv.Enabled = False
        cmdExit.Enabled = False
        lstItem.Visible = False
        txtData2.Visible = True
        'If rs.EditMode = adEditAdd Then
        '    txtData2.Enabled = True
        '    cmdFindItem.Visible = True
        'Else
        '    txtData2.Enabled = False
        '    cmdFindItem.Visible = False
        'End If

    End Sub

    Sub GetCalcLog()

        ' Eddie - Not using, not needed
        'Dim q As String
        'q = "SELECT * FROM CalcLog ORDER BY RunDate"
        ''CLRS.CursorLocation = adUseClient
        'Call CLRS.Open(q, DB, adOpenDynamic, adLockOptimistic)

    End Sub

End Class