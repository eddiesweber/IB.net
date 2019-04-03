Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmRentOrd

    Dim buserchange As Boolean
    Dim buserchange2 As Boolean
    Dim bTextChanged As Boolean
    Dim qtychgflag(0 To 3) As Integer
    Dim SalesOpt As Integer
    Dim bCancel As Boolean
    ' intDept is replacing txtdata1
    Dim intDept As Integer

    Private Sub frmRentOrd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        buserchange = False
        bTextChanged = False

        GetWindowPos(Me, 66, 33)

        Me.SpGetSalesmenTableAdapter.Connection.ConnectionString = CS
        Me.SpGetSalesmenTableAdapter.Fill(Me.DsspGetSalesmen.spGetSalesmen)

        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Then
                Dim b As Binding = c.DataBindings("Text")
                If Not b Is Nothing Then
                    Dim bs As BindingSource = DirectCast(b.DataSource, BindingSource)
                    Dim tb As TextBox = DirectCast(c, TextBox)
                    Dim ds As DataSet = DirectCast(bs.DataSource, DataSet)
                    tb.MaxLength = ds.Tables(bs.DataMember).Columns(b.BindingMemberInfo.BindingField).MaxLength
                End If
            ElseIf TypeOf c Is RichTextBox Then
                Dim b As Binding = c.DataBindings("Text")
                If Not b Is Nothing Then
                    Dim bs As BindingSource = DirectCast(b.DataSource, BindingSource)
                    Dim tb As TextBox = DirectCast(c, TextBox)
                    Dim ds As DataSet = DirectCast(bs.DataSource, DataSet)
                    tb.MaxLength = ds.Tables(bs.DataMember).Columns(b.BindingMemberInfo.BindingField).MaxLength
                End If
            End If
        Next

        'txtData2.MaxLength = DsCustomerInventory.CustomerInventory.ITEM_NUMColumn.MaxLength
        'txtData4.MaxLength = DsCustomerInventory.CustomerInventory.SALES_1Column.MaxLength
        'txtData5.MaxLength = DsCustomerInventory.CustomerInventory.SALES_2Column.MaxLength
        'txtData6.MaxLength = DsCustomerInventory.CustomerInventory.SALES_3Column.MaxLength
        'txtData7.MaxLength = DsCustomerInventory.CustomerInventory.SALES_1PCTColumn.MaxLength
        'txtData8.MaxLength = DsCustomerInventory.CustomerInventory.SALES_2PCTColumn.MaxLength
        'txtData9.MaxLength = DsCustomerInventory.CustomerInventory.SALES_3PCTColumn.MaxLength
        'txtData10.MaxLength = DsCustomerInventory.CustomerInventory.LOAN_QTYColumn.MaxLength
        'txtData11.MaxLength = DsCustomerInventory.CustomerInventory.INV_QTYColumn.MaxLength
        'txtData12.MaxLength = DsCustomerInventory.CustomerInventory.MIN_QTYColumn.MaxLength
        'txtData13.MaxLength = DsCustomerInventory.CustomerInventory.DEL_QTYColumn.MaxLength
        'txtData19.MaxLength = DsCustomerInventory.CustomerInventory.UNIT_PRICEColumn.MaxLength
        'txtData20.MaxLength = DsCustomerInventory.CustomerInventory.NAME_SIZEColumn.MaxLength

        ' Create one event handler for each text box
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.TextChanged, AddressOf boxfocus
            End If
        Next

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            lblCurCust.Text = CurCust
        End If

        buserchange = True

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub SetLengths(ByVal cx As Control)
        For Each c As Control In cx.Controls
            If TypeOf c Is TextBox Then
                Dim b As Binding = c.DataBindings("Text")
                If Not b Is Nothing Then
                    Dim bs As BindingSource = DirectCast(b.DataSource, BindingSource)
                    Dim tb As TextBox = DirectCast(c, TextBox)
                    Dim ds As DataSet = DirectCast(bs.DataSource, DataSet)
                    tb.MaxLength = ds.Tables(bs.DataMember).Columns(b.BindingMemberInfo.BindingField).MaxLength
                End If
            ElseIf TypeOf c Is RichTextBox Then
                Dim b As Binding = c.DataBindings("Text")
                If Not b Is Nothing Then
                    Dim bs As BindingSource = DirectCast(b.DataSource, BindingSource)
                    Dim tb As TextBox = DirectCast(c, TextBox)
                    Dim ds As DataSet = DirectCast(bs.DataSource, DataSet)
                    tb.MaxLength = ds.Tables(bs.DataMember).Columns(b.BindingMemberInfo.BindingField).MaxLength
                End If
            End If
        Next
    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        If cmdReset.Enabled = False Then
            GetData()
        End If
        buserchange = True

    End Sub

    Private Sub boxfocus(ByVal sender As Object, ByVal e As System.EventArgs)

        bTextChanged = True

        If buserchange Then
            SetModeChange()
        End If

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

        ' rs
        Me.CustomerInventoryTableAdapter.Connection.ConnectionString = CS
        Me.CustomerInventoryTableAdapter.Fill(Me.DsCustomerInventory.CustomerInventory, CurCust, CurDept)

        GetData3()

        txtCustName.Text = GetCustName()

        SetModeReg

        SetControls()

    End Sub

    Sub GetData3()

        Dim intRow As Integer

        If DsCustomerInventory.CustomerInventory.Rows.Count = 0 Then
            cmdNew.PerformClick()
        Else
            If CurItem > 0 Then
                CustomerInventoryBindingSource.MoveFirst()
                intRow = CustomerInventoryBindingSource.Find("ITEM_NUM", CurItem)

                If intRow >= 0 Then
                    Me.CustomerInventoryBindingSource.Position = intRow
                End If
            Else
                CustomerInventoryBindingSource.MoveFirst()
            End If

            SetModeReg()

            SetControls()
        End If


    End Sub

    Public Sub SetModeAdd()

        SetModeChange()
        txtData2.Select()

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

            'If rs.EditMode = adEditAdd Then
            '    txtData2.Enabled = True
            '    cmdFindItem.Visible = True
            'Else
            '    txtData2.Enabled = False
            '    cmdFindItem.Visible = False
            'End If
        End If

    End Sub

    Sub SetControls()

        Dim s As String

        buserchange = False

        lstDept.SelectedIndex = lstDept.FindString(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("DEPT"))

        s = GetItemDesc(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("ITEM_NUM"))
        txtItemDesc.Text = s

        txtCurrent0.Text = "0"
        txtCurrent0.Text = CStr(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LOAN_QTY"))
        txtCurrent1.Text = "0"
        txtCurrent1.Text = CStr(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("INV_QTY"))
        txtCurrent2.Text = "0"
        txtCurrent2.Text = CStr(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("MIN_QTY"))
        txtCurrent3.Text = "0"
        txtCurrent3.Text = CStr(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("DEL_QTY"))

        txtChange0.Text = "0"
        txtChange1.Text = "0"
        txtChange2.Text = "0"
        txtChange3.Text = "0"

        SetSalesOpt()
        SetScreen()

    End Sub

    Sub SetSalesOpt()

        'Set up sales section on reposition or change
        Dim OldOpt As Integer
        Dim i As Integer

        OldOpt = SalesOpt

        If Not IsDBNull(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_2")) Then
            If DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_2") > "0" Then
                optSales2.Checked = True
                txtData6.Enabled = True
                txtData9.Enabled = True
                txtData5.Enabled = True
                txtData8.Enabled = True
                GoTo ChkPct
            End If
        End If

        txtData6.Enabled = False
        txtData9.Enabled = False

        If Not IsDBNull(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_1")) Then
            If DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_1") > "0" Then
                optSales1.Checked = True
                txtData5.Enabled = True
                txtData8.Enabled = True
                GoTo ChkPct
            End If
        End If

        txtData5.Enabled = False
        txtData8.Enabled = False
        optSales0.Checked = True
ChkPct:
        'Change default percents
        If buserchange Then
            If SalesOpt < 3 And SalesOpt <> OldOpt Then
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_1PCT") = 100
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_2PCT") = 0
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3PCT") = 0
                Exit Sub
            End If
            If Not DBNull.Value.Equals(DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3")) And SalesOpt <> OldOpt Then
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_2PCT") = 50
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3PCT") = 0
            End If
            If DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3") > "0" Then
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_2PCT") = 33.3
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3PCT") = 33.3
            End If
        End If

        If 0 < SalesOpt Then
            optSales0.Enabled = True
        Else
            optSales0.Enabled = False
        End If

        If 1 < SalesOpt Then
            optSales1.Enabled = True
        Else
            optSales1.Enabled = False
        End If

        If 2 < SalesOpt Then
            optSales2.Enabled = True
        Else
            optSales2.Enabled = False
        End If

    End Sub

    Sub SetScreen()

        If chkLoan.Checked = True Then
            txtChange1.Enabled = False
            txtChange2.Enabled = False
            scrChange1.Enabled = False
            scrChange2.Enabled = False
            txtData11.Enabled = False
            txtData12.Enabled = False
            scrQty11.Enabled = False
            scrQty12.Enabled = False
            txtData19.Visible = False
            txtTotal.Visible = False
            lblLabel6.Visible = False
            txtChange0.Enabled = True
            scrChange0.Enabled = True
            txtData10.Enabled = True
            scrQty10.Enabled = True
        Else
            txtChange1.Enabled = True
            txtChange2.Enabled = True
            scrChange1.Enabled = True
            scrChange2.Enabled = True
            txtData11.Enabled = True
            txtData12.Enabled = True
            scrQty11.Enabled = True
            scrQty12.Enabled = True
            txtData19.Visible = True
            txtTotal.Visible = True
            lblLabel6.Visible = True
            txtChange0.Enabled = False
            scrChange0.Enabled = False
            txtData10.Enabled = False
            scrQty10.Enabled = False
        End If

    End Sub

    Sub SetSalesPct()

        'Adjust so =100
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_1PCT") = CStr(100 - Val(txtData8.Text) - Val(txtData9.Text))

    End Sub

    Private Sub lstDept_Click(sender As Object, e As EventArgs)

        'intDept = lstDept.SelectedText
        intDept = lstDept.SelectedItem

        If buserchange Then
            buserchange = False
            'CurDept = CInt(lstDept.SelectedText)
            CurDept = CInt(lstDept.SelectedItem)
            GetData2()
            buserchange = True
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Dim Result As DialogResult

        If bTextChanged = True Then
            Result = MessageBox.Show(Me, "Do you want to exit the form without saving your changes?", "Exit form", vbYesNo)
            If Result = vbYes Then
                Exit Sub
            End If
        End If

        SaveWindowPos(Me)

        Me.Close()

    End Sub

    Private Sub lstItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItem.SelectedIndexChanged

        If buserchange Then
            buserchange = False
            If CustomerInventoryBindingSource.Count > 0 Then
                CurItem = CType(CustomerInventoryBindingSource.Current, DataRowView).Item("ITEM_NUM").ToString()

                buserchange2 = True
                'rs.Bookmark = lstItem.SelectedItem
                buserchange2 = False

                GetData2()

                CurType = DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("ITEM_TYPE")
            End If

            buserchange = True
        End If

    End Sub

    Private Sub lstDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDept.SelectedIndexChanged

        If buserchange Then
            buserchange = False
            If SpGetCustDeptBindingSource.Count > 0 Then
                CurDept = CType(SpGetCustDeptBindingSource.Current, DataRowView).Item("DEPT").ToString()
                GetData2()
            End If
            buserchange = True
        End If

    End Sub

    Private Sub lstSales_DoubleClick(sender As Object, e As EventArgs) Handles lstSales.DoubleClick

        If SalesOpt = 1 Then
            DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_1") =
                CType(SpGetSalesmenBindingSource.Current, DataRowView).Item("Sales").ToString()
            Exit Sub
        End If

        If SalesOpt = 2 Then
            DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_2") =
                CType(SpGetSalesmenBindingSource.Current, DataRowView).Item("Sales").ToString()
            Exit Sub
        End If

        If SalesOpt > 2 Then
            DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("Sales_3") =
                CType(SpGetSalesmenBindingSource.Current, DataRowView).Item("Sales").ToString()
            Exit Sub
        End If

    End Sub

    Private Sub optSales0_CheckedChanged(sender As Object, e As EventArgs) Handles optSales0.CheckedChanged

        If optSales0.Checked = True Then
            SalesOpt = 1
        End If

    End Sub

    Private Sub optSales1_CheckedChanged(sender As Object, e As EventArgs) Handles optSales1.CheckedChanged

        If optSales1.Checked = True Then
            SalesOpt = 2
        End If

    End Sub

    Private Sub optSales2_CheckedChanged(sender As Object, e As EventArgs) Handles optSales2.CheckedChanged

        If optSales2.Checked = True Then
            SalesOpt = 3
        End If

    End Sub

    Sub AutoItem()

        'automatically adds 99999 after 1st item this customer
        Dim q As String
        Dim Result As DialogResult

        q = "Insert CustomerInventory (CUST_NUM,DEPT,ITEM_NUM,ITEM_TYPE)" & " Values (" & CurCust & "," & CurDept & ",99999,'R')"

        Using Command As New SqlCommand(q, DB)
            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in AutoItem Routine" & vbNewLine & "Error : " & ex.Message, "Insert Customer Inventory", vbOK)
                LogError(Me.Name, "AutoItem", "1.0", ex.Message)
            End Try
        End Using

    End Sub

    Private Sub chkData0_Click(sender As Object, e As EventArgs) Handles chkData0.Click

        If buserchange Then
            SetModeChange()
        End If

    End Sub

    Private Sub chkLoan_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoan.CheckedChanged

        If buserchange Then
            bTextChanged = True

            If chkLoan.Checked = True Then
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LINE_TYPE") = 2
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("INV_QTY") = 0
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("MIN_QTY") = 0
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("UNIT_PRICE") = 0
            Else
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LINE_TYPE") = 1
                DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LOAN_QTY") = 0
            End If

            SetScreen()
        End If

    End Sub

    Private Sub cmdFindCust_Click(sender As Object, e As EventArgs) Handles cmdFindCust.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        buserchange = False

        CustomerInventoryBindingSource.AddNew()

        'ADO control does not set defaults from table def
        txtData2.Text = 0
        txtData14.Text = 1
        txtData19.Text = 0
        chkData0.Checked = DsspGetCustDept.SpGetCustDept.Rows(SpGetCustDeptBindingSource.Position)("Tax")

        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("INV_QTY") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("MIN_QTY") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("DEL_QTY") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LOAN_QTY") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_1PCT") = 100
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_2PCT") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("SALES_3PCT") = 0
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("CUST_NUM") = CurCust
        DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("DEPT") = CurDept
        CustomerInventoryBindingSource.EndEdit()
        CustomerInventoryTableAdapter.Update(DsCustomerInventory.CustomerInventory)

        SetModeAdd()
        SetControls()

        buserchange = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intResult As Integer
        Dim q As String

        bCancel = False

        PostRentOrder(True)

        CurDept = intDept
        intResult = MsgBox("This will delete the current item." & Chr(10) & "Are you sure?", vbOKCancel + vbQuestion, "Delete Record")
        If intResult = vbCancel Then
            Exit Sub
        Else
            Dim customersInventoryRow As dsCustomerInventory.CustomerInventoryRow
            customersInventoryRow = DsCustomerInventory.CustomerInventory.FindByCUST_NUMDEPTITEM_NUMLINE_TYPE(txtData0.Text, txtData1.Text, txtData2.Text, txtData14.Text)

            customersInventoryRow.Delete()

            CustomerInventoryTableAdapter.Update(DsCustomerInventory.CustomerInventory)
        End If

        If Not bCancel Then
            GetData3()

            buserchange = True
        End If

        bCancel = False

    End Sub

    Private Sub PostRentOrder(DelFlag As Boolean)

        Dim IQty As Single
        Dim LQty As Single
        Dim q As String
        Dim Result As DialogResult
        Dim strResult As String

        'Post RO Transaction
        CurItem = txtData2.Text
        CurType = txtData3.Text

        If DelFlag Then
            IQty = 0
            LQty = 0
            IQty = 0 - DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("INV_QTY")
            LQty = 0 - DsCustomerInventory.CustomerInventory.Rows(CustomerInventoryBindingSource.Position)("LOAN_QTY")
        Else
            IQty = Val(txtChange0.Text)
            LQty = Val(txtChange0.Text)
        End If

        If IQty <> 0 Or LQty <> 0 Then
            q = "Insert RentOrder (CUST_NUM,DEPT,ITEM_NUM,LINE_TYPE,ITEM_TYPE,SALES_1,SALES_2,SALES_3,SALES_1PCT,SALES_2PCT,SALES_3PCT,INV_QTY,LOAN_QTY,MEMO)"
            q = q & " Values(" & txtData0.Text
            q = q & ",'" & txtData1.Text
            q = q & "'," & CurItem
            q = q & "," & txtData14.Text
            q = q & ",'" & CurType
            q = q & "','" & txtData4.Text
            q = q & "','" & txtData5.Text
            q = q & "','" & txtData6.Text
            q = q & "'," & txtData7.Text
            q = q & "," & txtData8.Text
            q = q & "," & txtData9.Text
            q = q & "," & IQty
            q = q & "," & LQty
            q = q & ",'" & txtMemo.Text & "')"

            'Update inventory quantities
            q = q & Chr(10) & "UPDATE ItemMaster" & CurType
            q = q & " SET RENTED = RENTED + " & CStr(IQty) & ", LOANED = LOANED + " & CStr(LQty)
            q = q & " WHERE ITEM_NUM=" & CStr(CurItem)

            Using Command As New SqlCommand(q, DB)
                Try
                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error in routine PostRentOrder" & vbNewLine & "Error : " & ex.Message, "Updating ItemMaster" & CurType, vbOK)
                    LogError(Me.Name, "PostRentOrder", "1.0", ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub chkData0_CheckedChanged(sender As Object, e As EventArgs) Handles chkData0.CheckedChanged

        bTextChanged = True

    End Sub
End Class