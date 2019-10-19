Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDept

    Dim buserchange As Boolean
    Dim CurState As String
    'Dim CurState As String * 2
    Dim bCancel As Boolean
    Dim blnNewRecord As Boolean
    Dim bTextChanged As Boolean
    Dim Result As DialogResult


    Private Sub frmDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        buserchange = False
        bTextChanged = False

        GetWindowPos(Me, 66, 66)

        If Dir("frmDeptgrdRoute.xml") <> "" Then
            grdRoute.LoadLayout("frmDeptgrdRoute.xml")
        End If

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
                            c1tb.MaxLength = DsCustomerDepartment.CustomerDepartment.Columns(c1tb.DataField).MaxLength
                        End If
                    Case "System.DateTime"
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
                    Case Else
                        MsgBox(c1tb.Name & ": " & c1tb.DataType.ToString)
                End Select
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

    Private Sub frmDept_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdRoute.SaveLayout("frmDeptgrdRoute.xml")

    End Sub

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs) Handles txtData0.TextChanged, txtData9.TextChanged, txtData8.TextChanged, txtData7.TextChanged, txtData6.TextChanged, txtData5.TextChanged, txtData4.TextChanged, txtData3.TextChanged, txtData2.TextChanged, txtData11.TextChanged, txmData1.TextChanged, txmData0.TextChanged

        bTextChanged = True

        ' This needs to be done for each text box
        If buserchange Then
            SetModeChange()
        Else
            ''Handle invisible boxes
            Select Case sender.name
                Case "txtData1"
                    lstDept.SelectedIndex = lstDept.FindString(txtData1.Text)
                Case "txtData10"
                    cmbTax.SelectedIndex = cmbTax.FindString(txtData10.Text)
            End Select
        End If

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        If cmdReset.Enabled = False Then
            buserchange = False
            GetData()
            buserchange = True
        End If

    End Sub

    Private Sub GetData()

        txtCustName.Text = GetCustName()

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            bTextChanged = False

            CustomerDepartmentTableAdapter.Connection.ConnectionString = CS
            CustomerDepartmentTableAdapter.Fill(DsCustomerDepartment.CustomerDepartment, CurCust)
            'data1.Refresh
            'rs = data1.Recordset
        End If

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            cmdNew.PerformClick()
        Else
            GetData2()
        End If

    End Sub

    Private Sub GetData2()

        Dim intRow As Integer

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            CurDept = 0
            Exit Sub
        End If

        CustomerDepartmentBindingSource.MoveFirst()
        If CurDept > 0 Then
            intRow = CustomerDepartmentBindingSource.Find("DEPT", CurDept)

            If intRow >= 0 Then
                CustomerDepartmentBindingSource.Position = intRow
            End If
        End If

        CurDept = DsCustomerDepartment.CustomerDepartment.Rows(CustomerDepartmentBindingSource.Position)("DEPT")
        lstDept.SelectedIndex = lstDept.FindString(txtData1.Text)
        cmbTax.SelectedIndex = cmbTax.FindString(txtData10.Text)

        GetDataRoute()

    End Sub

    Sub GetTaxCodes()

        If txtData5.Text <> txtTaxState.Text Then

            CurState = txtData5.Text

            SpGetTaxCodesTableAdapter.Connection.ConnectionString = CS
            SpGetTaxCodesTableAdapter.Fill(DsspGetTaxCodes.spGetTaxCodes, CurState)

            If DsspGetTaxCodes.spGetTaxCodes.Rows.Count = 0 Then
                cmbTax.Text = ""
            End If

            txtTaxState.Text = CurState

        End If

    End Sub

    Private Sub GetDataRoute()

        Dim D As Integer

        If Me.Visible Then
            SetModeReg()
        End If

        ForceUpdates()

        GetTaxCodes()

        'Get routes for dept
        D = 0
        D = DsCustomerDepartment.CustomerDepartment(CustomerDepartmentBindingSource.Position)("DEPT")

        CustomerRouteTableAdapter.Connection.ConnectionString = CS
        CustomerRouteTableAdapter.Fill(DsCustomerRoute.CustomerRoute, CurCust, D)
        'data2.RecordSource = q
        'RS2 = data2.Recordset

    End Sub

    Private Sub CustomerDepartmentBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles CustomerDepartmentBindingSource.AddingNew

        Dim drv As DataRowView = DirectCast(CustomerDepartmentBindingSource.List, DataView).AddNew()

        'Defaults from CustomerMaster
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM CustomerMaster WHERE CUST_NUM=" & CurCust, connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    dataReader.Read()

                    drv.Row.Item("CUST_NUM") = CurCust
                    drv.Row.Item("DEL_NAME") = dataReader("BILL_NAME")

                    If txtData1.Text = 1 Then
                        drv.Row.Item("DEL_ADDR") = dataReader("BILL_STR")
                        drv.Row.Item("DEL_CITY") = dataReader("BILL_CTY")
                        drv.Row.Item("DEL_STATE") = dataReader("BILL_STATE")
                        drv.Row.Item("DEL_ZIP") = dataReader("BILL_ZIP")
                        drv.Row.Item("CONTACT") = dataReader("CONTACT")
                        drv.Row.Item("DEL_PHONE") = dataReader("PHONE")

                        GetTaxCodes()
                    End If
                End If
                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error adding new item" & vbNewLine & "Error : " & ex.Message, "Adding new", vbOKCancel)
                LogError(Me.Name, "CustomerDepartmentBindingSource_AddingNew", "1.0", ex.Message)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

        e.NewObject = drv

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        Dim D As Integer

        buserchange = False

        'Default dept
        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            D = 1
        Else
            CustomerDepartmentBindingSource.MoveFirst()
            D = txtData1.Text + 1
        End If

        CustomerDepartmentBindingSource.AddNew()
        'rs.addnew

        SetModeAdd()

        txtData1.Text = D

        blnNewRecord = True
        buserchange = True

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim Result As DialogResult

        buserchange = False
        bCancel = False

        CurDept = txtData1.Text

        Try
            CustomerDepartmentBindingSource.EndEdit()
            CustomerDepartmentTableAdapter.Update(DsCustomerDepartment.CustomerDepartment)
        Catch ex As Exception
            bCancel = True

            Result = MessageBox.Show(Me, "Error updating department" & vbNewLine & "Error : " & ex.Message, "New Customer Number", vbOKCancel)
            LogError(Me.Name, "cmdUpdate_Click", "1.0", ex.Message)
            If Result = vbCancel Then
                Exit Sub
            Else
                Exit Try
            End If
        End Try

        If Not bCancel Then
            'update succeeded
            GetData()
            CurCust = txtData0.Text
            CurDept = txtData1.Text
            SetModeReg()
            'If M = adEditAdd Then grdRoute.SetFocus
        End If

        blnNewRecord = False
        buserchange = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intResult As Integer

        CurDept = txtData1.Text
        If ChkInvoiceExists() Then Exit Sub
        intResult = MsgBox("This will delete the dept., its routes and items." & Chr(10) & "Are you sure?", vbOKCancel + vbQuestion, "Delete Record")
        If intResult = vbCancel Then
            Exit Sub
        Else
            Dim customersDeptartmentRow As dsCustomerDepartment.CustomerDepartmentRow
            customersDeptartmentRow = DsCustomerDepartment.CustomerDepartment.FindByCUST_NUMDEPT(CurCust, CurDept)

            customersDeptartmentRow.Delete()

            CustomerDepartmentTableAdapter.Update(DsCustomerDepartment.CustomerDepartment)
        End If


        If Not bCancel Then
            'lblCurCust_Change
            buserchange = False
            GetData()
            buserchange = True
        End If

        bCancel = False

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
        cmdItem.Enabled = False
        grdRoute.Enabled = False
        lstDept.Visible = False
        'txtData1.Visible = True
        'If rs.EditMode = adEditAdd Then
        '    txtData1.Enabled = True
        'Else
        '    txtData1.Enabled = False
        'End If

    End Sub

    Public Sub SetModeAdd()

        'rs!CUST_NUM = CurCust
        'txtData(0).DataChanged = False
        SetModeChange()
        'txtData1.Enabled = True
        'txtData2.SetFocus

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindCust.Enabled = True
        cmdItem.Enabled = True
        grdRoute.Enabled = True
        'txtData1.Visible = False
        lstDept.Visible = True

    End Sub

    Private Sub lstDept_Click(sender As Object, e As EventArgs) Handles lstDept.Click

        If buserchange Then
            buserchange = False
            CurDept = lstDept.SelectedText
            GetData2()
            buserchange = True
        End If

    End Sub

    Sub closedata()

        'On Error Resume Next
        'rs.Close
        'RS2.Close

    End Sub

    Sub ForceUpdates()

        ''Make sure grid data is updated by closing recordsets
        'On Error Resume Next
        'If RS2.EditMode > 0 Then RS2.Update

    End Sub

    Private Sub cmdFindCust_Click(sender As Object, e As EventArgs) Handles cmdFindCust.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        buserchange = False

        CustomerDepartmentBindingSource.CancelEdit()

        If blnNewRecord = True Then
            If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
                cmdNew.PerformClick()
            Else
                GetData2()
                SetModeReg()
            End If
        Else
            GetData2()
            SetModeReg()
        End If

        buserchange = True

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

    Private Sub cmdItem_Click(sender As Object, e As EventArgs) Handles cmdItem.Click

        frmRentOrd.Show()

    End Sub

    Private Sub cmdSurcharge_Click(sender As Object, e As EventArgs) Handles cmdSurcharge.Click

        frmCustSurcharge.Show()

    End Sub

End Class