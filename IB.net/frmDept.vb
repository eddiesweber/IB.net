Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDept

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim CurState As String
    'Dim CurState As String * 2
    Dim bCancel As Boolean

    Private Sub frmDept_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        CustomerDepartmentTableAdapter.Connection.ConnectionString = CS
        CustomerRouteTableAdapter.Connection.ConnectionString = CS
        SpGetTaxCodesTableAdapter.Connection.ConnectionString = CS

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            lblCurCust.Text = CurCust
        End If

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        bInit = True

        If cmdReset.Enabled = False Then
            GetData()
        End If

        buserchange = True
        bInit = False

    End Sub

    Private Sub frmDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        If Dir("frmViewCustgrdRoute.xml") <> "" Then
            grdRoute.LoadLayout("frmViewCustgrdRoute.xml")
        End If

        buserchange = False
        bInit = True

        CustomerDepartmentTableAdapter.Connection.ConnectionString = CS
        CustomerRouteTableAdapter.Connection.ConnectionString = CS
        SpGetTaxCodesTableAdapter.Connection.ConnectionString = CS

        'data3.ConnectionString = CS
        'data3.Enabled = True

        'Set text box lengths based on tabledef
        '        Dim c As Control, fld As String
        '        Dim R As New ADODB.Recordset
        '        Dim ADOConn As New ADODB.Connection
        '        R.Open "Select * from CustomerDepartment Where 1=0", DB, adOpenStatic
        'For Each c In Me.Controls
        '            If c.Name = "txtData" Then
        '                fld = c.DataField
        '                If fld > "" Then
        '                    Select Case R.Fields(fld).Type
        '                        Case adChar, adVarChar, adVarWChar
        '                            c.MaxLength = R.Fields(fld).DefinedSize
        '                        Case adTinyInt
        '                            c.MaxLength = 1
        '                        Case adSmallInt
        '                            c.MaxLength = 5
        '                        Case adInteger, adSingle
        '                            c.MaxLength = 10
        '                        Case Else
        '                            c.MaxLength = 20
        '                    End Select
        '                End If
        '            End If
        '        Next c
        '        R.Close()

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        Dim D As Integer
        Dim q As String
        Dim Result As DialogResult

        buserchange = False

        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            D = 1
        Else
            CustomerDepartmentBindingSource.MoveFirst()
            D = txtData1.Text + 1
        End If

        CustomerDepartmentBindingSource.AddNew()

        SetModeAdd()

        txtData1.Text = D
        txtData0.Text = CurCust

        'Defaults from CustomerMaster
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM CustomerMaster WHERE CUST_NUM=" & CurCust, connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    dataReader.Read()

                    txtData2.Text = dataReader("BILL_NAME")

                    If D = 1 Then
                        txtData3.Text = dataReader("BILL_STR")
                        txtData4.Text = dataReader("BILL_CTY")
                        txtData5.Text = dataReader("BILL_STATE")
                        txtData6.Text = dataReader("BILL_ZIP")
                        txtData7.Text = dataReader("CONTACT")
                        txmData0.Text = dataReader("phone")

                        GetTaxCodes()
                    End If
                End If
                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting data from customer master" & vbNewLine & "Error : " & ex.Message, "Customer Master", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

        buserchange = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intResult As Integer
        Dim q As String
        Dim ADOCmd As New ADODB.Command
        ADOCmd.ActiveConnection = DB

        CurDept = txtData1.Text
        If ChkInvoiceExists() Then Exit Sub
        intResult = MsgBox("This will delete the dept., its routes and items." & Chr(10) & "Are you sure?", vbOKCancel + vbQuestion, "Delete Record")
        If intResult = vbCancel Then
            Exit Sub
        Else
            'q = "DELETE CustomerRoute WHERE CUST_NUM=" & CStr(CurCust) & " AND DEPT=" & CStr(CurDept)
            'ADOCmd.CommandText = q
            'ADOCmd.Execute()
            Dim customersDeptartmentRow As dsCustomerDepartment.CustomerDepartmentRow
            customersDeptartmentRow = DsCustomerDepartment.CustomerDepartment.FindByCUST_NUMDEPT(CurCust, CurDept)

            customersDeptartmentRow.Delete()

            CustomerDepartmentTableAdapter.Update(DsCustomerDepartment.CustomerDepartment)

            'q = "DELETE CustomerInventory WHERE CUST_NUM=" & CStr(CurCust) & " AND DEPT=" & CStr(CurDept)
            'ADOCmd.CommandText = q
            'ADOCmd.Execute()

            'rs.Delete()
        End If


        If Not bCancel Then
            'Data1.Refresh
            'lblCurCust_Change
            buserchange = False
            GetData()
            buserchange = True
        End If
        bCancel = False

    End Sub

    Sub GetData()

        'Get customer departments
        txtCustName.Text = GetCustName()

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            'data1.RecordSource = "Select * from CustomerDepartment Where Cust_Num=" & CurCust
            Me.CustomerDepartmentTableAdapter.Fill(Me.DsCustomerDepartment.CustomerDepartment, CurCust)
        End If

        'Set rs = data1.Recordset
        'If rs.BOF And rs.EOF Then
        If DsCustomerDepartment.CustomerDepartment.Rows.Count = 0 Then
            cmdNew.PerformClick()
        Else
            GetData2()
        End If

    End Sub

    Sub GetData2()

        'Goto current department
        If DsCustomerDepartment.Tables("CustomerDepartment").Rows.Count = 0 Then
            CurDept = 0
            Exit Sub
        End If

        'If CurDept > 0 Then
        '    rs.MoveFirst()
        '    'rs.Find "DEPT=" & CurDept
        '    If rs.EOF Then rs.MoveFirst()
        'Else
        '    rs.MoveFirst()
        'End If

        'CurDept = rs!DEPT

        'lstDept.BoundText = txtData(1).Text
        'cmbTax.BoundText = txtData(10).Text

        GetDataRoute()

    End Sub

    Private Sub GetDataRoute()

        If Me.Visible Then
            SetModeReg()
        End If

        ForceUpdates()

        GetTaxCodes()

        'Get routes for dept
        If IsNumeric(txtData1.Text) Then
            CustomerRouteTableAdapter.Fill(DsCustomerRoute.CustomerRoute, CurCust, txtData1.Text)
            'Set RS2 = data2.Recordset
        End If

    End Sub

    Sub GetTaxCodes()

        If txtData5.Text <> txtTaxState.Text Then

            CurState = txtData5.Text

            ' data3.RecordSource = "spGetTaxCodes '" & CurState & "'"
            SpGetTaxCodesTableAdapter.Fill(DsspGetTaxCodes.spGetTaxCodes, CurState)
            If DsspGetTaxCodes.spGetTaxCodes.Rows.Count = 0 Then
                cmbTax.Text = ""
            End If

            txtTaxState.Text = CurState

        End If

    End Sub


    Sub ForceUpdates()

        'Make sure grid data is updated by closing recordsets
        'On Error Resume Next
        'If RS2.EditMode > 0 Then RS2.Update()

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
        txtData1.Visible = True
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
        txtData1.Enabled = True
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
        txtData1.Visible = False
        lstDept.Visible = True

    End Sub

    Private Sub frmDept_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdRoute.SaveLayout("frmViewCustgrdRoute.xml")

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim M As Integer

        buserchange = False
        bCancel = False

        'M = rs.EditMode
        ''If RS.EditMode = dbEditNone Then RS.Edit

        'CurDept = rs!DEPT

        'rs.Update()

        'If Not bCancel Then
        '    'update succeeded
        '    GetData()
        '    CurCust = txtData0.Text
        '    CurDept = txtData1.Text
        '    SetModeReg()
        '    If M = adEditAdd Then grdRoute.SetFocus
        'End If

        buserchange = True

    End Sub
End Class