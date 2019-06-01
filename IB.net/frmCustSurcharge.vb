Imports System.ComponentModel

Public Class frmCustSurcharge

    Dim buserchange As Boolean
    Dim buserchange2 As Boolean
    Dim qtychgflag(0 To 3) As Integer
    Dim bInit As Boolean
    Dim SalesOpt As Integer
    Dim bCancel As Boolean
    Dim bTextChanged As Boolean

    Private Sub frmCustSurcharge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 33)

        buserchange = False
        bInit = True

        'data2.ConnectionString = CS
        'data1.ConnectionString = CS

        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        'txtData0.MaxLength = txtData0.DataField.Length
        'txtData1.MaxLength = txtData1.DataField.Length
        'txtData2.MaxLength = txtData2.DataField.Length
        'txtData3.MaxLength = txtData3.DataField.Length
        'txtData19.MaxLength = txtData19.DataField.Length

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            lblCurCust.Text = CurCust
        End If

        buserchange = True

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        If cmdReset.Enabled = False Then
            GetData()
        End If
        buserchange = True

    End Sub

    Sub GetData()

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            bTextChanged = False

            Me.SpGetCustDeptTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustDeptTableAdapter.Fill(Me.DsspGetCustDept.SpGetCustDept, CurCust)
        End If

        If DsspGetCustDept.SpGetCustDept.Rows.Count = 0 Then
            MessageBox.Show("No departments set up")
            Me.Close()
        Else
            GetData2()

            txtCustName.Text = GetCustName()
        End If

    End Sub

    Sub GetData2()

        Dim intRow As Integer

        If DsspGetCustDept.SpGetCustDept.Rows.Count = 0 Then
            CurDept = 0
            Exit Sub
        Else
            If CurDept = 0 Then
                CurDept = DsspGetCustDept.SpGetCustDept.Rows(0)("DEPT")
            End If
        End If

        ' rs2 - "spGetCustDept (" & CurCust & ")"
        If CurDept > 0 Then
            SpGetCustDeptBindingSource.MoveFirst()

            intRow = SpGetCustDeptBindingSource.Find("DEPT", CurDept)

            If intRow >= 0 Then
                SpGetCustDeptBindingSource.Position = intRow
            End If
        Else
            SpGetCustDeptBindingSource.MoveFirst()
        End If

        CurDept = DsspGetCustDept.SpGetCustDept.Rows(intRow)("DEPT")
        txtCustDept.Text = DsspGetCustDept.SpGetCustDept.Rows(intRow)("Name")

        ' rs / data1
        Me.CustomerSurchargeTableAdapter.Connection.ConnectionString = CS
        Me.CustomerSurchargeTableAdapter.Fill(Me.DsCustomerSurcharge.CustomerSurcharge, CurCust, CurDept)

        GetData3()

    End Sub

    Sub GetData3()

        Dim intRow As Integer

        If DsCustomerSurcharge.CustomerSurcharge.Rows.Count = 0 Then
            'cmdNew.PerformClick()
        Else
            If CurItem > 0 Then
                CustomerSurchargeBindingSource.MoveFirst()
                intRow = CustomerSurchargeBindingSource.Find("ITEM_NUM", CurItem)

                If intRow >= 0 Then
                    CustomerSurchargeBindingSource.Position = intRow
                End If
            Else
                CustomerSurchargeBindingSource.MoveFirst()
            End If

            SetModeReg()

            SetControls()
        End If

    End Sub

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs) Handles txtData0.TextChanged, txtData3.TextChanged, txtData2.TextChanged, txtData19.TextChanged, txtData1.TextChanged

        bTextChanged = True

        If buserchange Then
            SetModeChange()
        Else
            'Handle invisible boxes
            Select Case sender.name
                Case "txtData1"
                    'lstDept.BoundText = txtData(1).Text
                Case "txtData2"
                    If Not buserchange2 Then
                        'lstItem.BoundText = txtData(2).Text
                    End If
            End Select
        End If

    End Sub

    Private Sub lstDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDept.SelectedIndexChanged

        If buserchange Then
            buserchange = False

            CurDept = lstDept.SelectedValue

            GetData2()

            buserchange = True
        End If

    End Sub

    Private Sub txtData2_LostFocus(Index As Integer)

        'If txtData2.Text > "0" Then

        '    Dim Des As String

        '    Des = GetItemDesc(txtData2.Text)
        '    If Des = "error" Then
        '        MessageBox.Show(Me, "Item not found.", vbOKOnly, "Validation Error")
        '        txtData2.Select()

        '        Exit Sub
        '    End If

        '    DsCustomerSurcharge.CustomerSurcharge.Rows(CustomerSurchargeBindingSource.Position)("ITEM_TYPE") = CurType
        '    txtItemDesc.Text = Des
        'End If

    End Sub

    Sub SetScreen()

        txtData19.Visible = True

    End Sub

    Sub SetControls()

        Dim s As String

        buserchange = False

        'lstDept.SelectedIndex = lstDept.FindString(DsCustomerSurcharge.CustomerSurcharge.Rows(CustomerSurchargeBindingSource.Position)("DEPT"))
        's = GetItemDesc(DsCustomerSurcharge.CustomerSurcharge.Rows(CustomerSurchargeBindingSource.Position)("ITEM_NUM"))
        lstDept.SelectedIndex = lstDept.FindString(CurDept)
        s = GetItemDesc(CurDept)
        txtItemDesc.Text = s

        SetScreen()

    End Sub

    Public Sub SetModeAdd()

        SetModeChange()
        txtData2.Select()

    End Sub

    Public Sub SetModeChange()

        If Not cmdReset.Enabled Then
            cmdNew.Enabled = False
            cmdDelete.Enabled = False
            cmdReset.Enabled = True
            'cmdReset.Cancel = True
            cmdUpdate.Enabled = True
            'cmdUpdate.Default = True
            cmdFindCust.Enabled = False
            cmdExit.Enabled = False
            lstDept.Visible = False
            txtData1.Visible = True
            txtData1.Enabled = False
            lstItem.Visible = False
            txtData2.Visible = True

            If bTextChanged = True Then
                txtData2.Enabled = True
                cmdFindItem.Visible = True
            Else
                txtData2.Enabled = False
                cmdFindItem.Visible = False
            End If
        End If

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindCust.Enabled = True
        txtData1.Visible = False
        lstDept.Visible = True
        txtData2.Visible = False
        lstItem.Visible = True
        cmdFindItem.Visible = False

    End Sub

    Private Sub cmdFindCust_Click(sender As Object, e As EventArgs) Handles cmdFindCust.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub frmCustSurcharge_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Keeps events from firing when closing
        buserchange = False

        SaveWindowPos(Me)

    End Sub

    Private Sub CustomerSurchargeBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles CustomerSurchargeBindingSource.AddingNew

        Dim drv As DataRowView = DirectCast(CustomerSurchargeBindingSource.List, DataView).AddNew()

        drv.Row.Item("CUST_NUM") = CurCust
        drv.Row.Item("Dept") = CurDept
        drv.Row.Item("Item_Num") = 0
        drv.Row.Item("Item_Type") = "O"
        drv.Row.Item("Rate") = 0

        e.NewObject = drv

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        buserchange = False

        CustomerSurchargeBindingSource.AddNew()

        SetModeAdd()

        SetControls()

        buserchange = True

        'buserchange = False
        'rs.AddNew
        ''ADO control does not set defaults from table def
        'rs!ITEM_NUM = 0
        'rs!Rate = 0
        'rs!ITEM_TYPE = "O"
        'rs!CUST_NUM = CurCust
        'rs!DEPT = CurDept

        'SetModeAdd()
        'SetControls()
        'buserchange = True

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        buserchange = False
        bCancel = False

        'Check required data
        If txtData0.Text > "" And txtData1.Text > "" And txtData2.Text > "" Then
        Else
            MessageBox.Show(Me, "Customer, Dept. and Item are required.", "Missing Data", vbOKOnly)
            Exit Sub
        End If

        ''Test for good key value
        'Dim q As String
        'If rs.EditMode = adEditAdd And txtData(2).Text > "" Then
        '    q = "Select count(*)  CT from CustomerSurcharge Where CUST_NUM=" & txtData(0)
        '    q = q & " And DEPT='" & txtData(1) & "'"
        '    q = q & " And ITEM_NUM=" & txtData(2)
        '    Call rstemp.Open(q, DB, adOpenForwardOnly)
        '    rstemp.MoveFirst()

        '    If rstemp!ct > 0 Then
        '        MsgBox "Item already exists", vbOKOnly, "Duplicate Index"
        '    bCancel = True
        '    End If
        '    rstemp.Close()
        '            Set rstemp = Nothing
        'End If
        'If bCancel Then Exit Sub
        'On Error GoTo BadUpdate
        'rs.Update
        'On Error GoTo 0
        'If Not bCancel Then
        '    'update succeeded
        '    buserchange = False
        '    CurItem = Val(txtData(2).Text)
        '    CurType = txtData(3).Text
        '    SurchargeRO
        '    data1.Refresh
        'Set rs = data1.Recordset
        'GetData3()
        '    SetModeReg()
        'End If
        'bCancel = False
        'buserchange = True

        'Exit Sub

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        'Dim s As String
        's = "Delete CustomerInventory where CUST_NUM = " & CurCust & " and Dept = " & CurDept & " and Item_Num = " & CurItem
        'bCancel = False
        'rs.Delete
        'If Not bCancel Then
        '    buserchange = False
        '    DB.Execute s
        '    Data1.Refresh
        '    Set rs = Data1.Recordset
        '    'DoEvents

        '    GetData3()
        '    buserchange = True
        'End If
        'bCancel = False

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        'Dim M As Integer
        'buserchange = False
        'M = rs.EditMode
        'On Error Resume Next
        'DoEvents
        'rs.CancelUpdate
        'rs.CancelUpdate
        'On Error GoTo 0
        'If M = adEditAdd Then
        '    If rs.RecordCount = 0 Then
        '        cmdNew_Click()
        '    Else
        '        GetData3()
        '        SetModeReg()
        '    End If
        'Else
        '    GetData()
        '    SetModeReg()
        '    SetControls()
        'End If
        'buserchange = True

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

End Class