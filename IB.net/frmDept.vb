Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDept

    Dim buserchange As Boolean
    Dim CurState As String
    'Dim CurState As String * 2
    Dim bCancel As Boolean
    ' intDept is replacing txtdata1
    Dim intDept As Integer
    ' strTAX_LOCODE is replacing txtdata10
    Dim strTAX_LOCODE As String
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

        txtData2.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_NAMEColumn.MaxLength
        txtData3.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_ADDRColumn.MaxLength
        txtData4.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_CITYColumn.MaxLength
        txtData5.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_STATEColumn.MaxLength
        txtData6.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_ZIPColumn.MaxLength
        txtData7.MaxLength = DsCustomerDepartment.CustomerDepartment.CONTACTColumn.MaxLength
        txtData8.MaxLength = DsCustomerDepartment.CustomerDepartment.MESSAGEColumn.MaxLength
        txtData9.MaxLength = DsCustomerDepartment.CustomerDepartment.Del_EmailColumn.MaxLength
        txtData11.MaxLength = DsCustomerDepartment.CustomerDepartment.SALESMANColumn.MaxLength
        txmData0.MaxLength = DsCustomerDepartment.CustomerDepartment.DEL_PHONEColumn.MaxLength
        txmData1.MaxLength = DsCustomerDepartment.CustomerDepartment.Del_FaxColumn.MaxLength

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

    Private Sub frmDept_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdRoute.SaveLayout("frmDeptgrdRoute.xml")

    End Sub

    Private Sub boxfocus(ByVal sender As Object, ByVal e As System.EventArgs)

        bTextChanged = True

        If buserchange Then
            SetModeChange()
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
            Me.CustomerDepartmentTableAdapter.Fill(Me.DsCustomerDepartment.CustomerDepartment, CurCust)
        End If

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            cmdNew.PerformClick()
        Else
            intDept = DsCustomerDepartment.CustomerDepartment.Rows(0)("DEPT")

            GetData2()
        End If

    End Sub

    Private Sub GetData2()

        Dim intRow As Integer

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            CurDept = 0
            Exit Sub
        End If

        ' "Select * from CustomerDepartment Where Cust_Num=" & CurCust
        If CurDept > 0 Then
            CustomerDepartmentBindingSource.MoveFirst()
            intRow = CustomerDepartmentBindingSource.Find("DEPT", CurDept)

            If intRow >= 0 Then
                CustomerDepartmentBindingSource.Position = intRow
            End If
        End If

        ' What if it doesn't find a row?
        CurDept = DsCustomerDepartment.CustomerDepartment.Rows(intRow)("DEPT")

        ' Both following lines do the same, keeping to see other way of getting position
        'lstDept.SelectedIndex = lstDept.Find(intDept.ToString, C1.Win.C1List.MatchCompareEnum.Equal, True, 0, 0)
        lstDept.SelectedIndex = CustomerDepartmentBindingSource.Position

        intDept = lstDept.SelectedText

        'cmbTax.BoundText = txtData10.Text
        cmbTax.SelectedIndex = cmbTax.FindString(strTAX_LOCODE)
        If Not DBNull.Value.Equals(DsCustomerDepartment.CustomerDepartment.Rows(0)("TAX_LOCODE")) Then
            strTAX_LOCODE = DsCustomerDepartment.CustomerDepartment.Rows(0)("TAX_LOCODE")
        Else
            strTAX_LOCODE = ""
        End If

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

        If Me.Visible Then
            SetModeReg()
        End If

        ForceUpdates()

        ' Moved to getdata2
        'GetTaxCodes()

        'Get routes for dept
        If intDept > 0 Then
            CustomerRouteTableAdapter.Connection.ConnectionString = CS
            CustomerRouteTableAdapter.Fill(DsCustomerRoute.CustomerRoute, CurCust, intDept)
            'Set RS2 = data2.Recordset
        End If

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

                    'txtData0.Text = CurCust
                    drv.Row.Item("CUST_NUM") = CurCust

                    'txtData2.Text = dataReader("BILL_NAME")
                    drv.Row.Item("DEL_NAME") = dataReader("BILL_NAME")

                    If intDept = 1 Then
                        'txtData3.Text = dataReader("BILL_STR")
                        drv.Row.Item("DEL_ADDR") = dataReader("BILL_STR")
                        'txtData4.Text = dataReader("BILL_CTY")
                        drv.Row.Item("DEL_CITY") = dataReader("BILL_CTY")
                        'txtData5.Text = dataReader("BILL_STATE")
                        drv.Row.Item("DEL_STATE") = dataReader("BILL_STATE")
                        'txtData6.Text = dataReader("BILL_ZIP")
                        drv.Row.Item("DEL_ZIP") = dataReader("BILL_ZIP")
                        'txtData7.Text = dataReader("CONTACT")
                        drv.Row.Item("CONTACT") = dataReader("CONTACT")
                        'txmData0.Text = dataReader("PHONE")
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

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            D = 1
        Else
            CustomerDepartmentBindingSource.MoveFirst()
            'D = txtData1.Text + 1
            D = intDept + 1
        End If

        CustomerDepartmentBindingSource.AddNew()
        'Dim newRow As DataRowView = CustomerDepartmentBindingSource.AddNew()

        SetModeAdd()

        'txtData1.Text = D
        intDept = D

        blnNewRecord = True
        buserchange = True

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim Result As DialogResult

        buserchange = False
        bCancel = False

        CurDept = intDept


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
            CurDept = intDept
            SetModeReg()
            'If M = adEditAdd Then grdRoute.SetFocus
        End If

        blnNewRecord = False
        buserchange = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intResult As Integer
        Dim q As String

        'CurDept = txtData1.Text
        CurDept = intDept
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

        intDept = lstDept.SelectedText

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

    Private Sub txmData0_TextChanged(sender As Object, e As EventArgs) Handles txmData0.TextChanged

        If buserchange Then
            SetModeChange()
        End If

    End Sub

    Private Sub txmData1_TextChanged(sender As Object, e As EventArgs) Handles txmData1.TextChanged

        If buserchange Then
            SetModeChange()
        End If

    End Sub

    Private Sub txtData_Change(Index As Integer)

        ' This needs to be done for each text box
        If buserchange Then
            SetModeChange()
        Else
            'Handle invisible boxes
            Select Case Index
                Case 1
                    'lstDept.BoundText = txtData(1).Text
                Case 10
                    'cmbTax.BoundText = txtData(10).Text
            End Select
        End If

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