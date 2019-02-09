Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmDept

    Dim rs As ADODB.Recordset
    Dim RS2 As ADODB.Recordset
    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim CurState As String
    'Dim CurState As String * 2
    Dim bCancel As Boolean

    Private Sub frmDept_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            lblCurCust.Text = CurCust
        End If

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        bInit = True
        'If cmdReset.Enabled = False Then
        GetData()
        'End If
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
                        txtData4.Text = dataReader("BILL_CITY")
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

    Sub GetData()

        Dim q As String, q1 As String

        'Get customer departments
        txtCustName.Text = GetCustName()

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            Me.CustomerDepartmentTableAdapter.Fill(Me.DsCustomerDepartment.CustomerDepartment, CurCust)
        End If


        'data1.RecordSource = "Select * from CustomerDepartment Where Cust_Num=" & CurCust
        'data1.Refresh

        'Set rs = data1.Recordset

        'If rs.BOF And rs.EOF Then
        'cmdNew_Click
        'Else
        GetData2()
        'End If

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

        Dim D As Integer

        If Me.Visible Then
            SetModeReg()
        End If

        ForceUpdates()

        GetTaxCodes()

        'Get routes for dept
        If IsNumeric(txtData1.Text) Then
            D = txtData1.Text
        Else
            D = 1
        End If


        'data2.RecordSource = q
        'data2.Refresh
        'Set RS2 = data2.Recordset

    End Sub

    Sub GetTaxCodes()

        If txtData5.Text <> txtTaxState.Text Then

            Dim Result As DialogResult

            CurState = txtData5.Text

            ' Fill customer numbers listbox
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand("spGetTaxCodes", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("Taxstate", SqlDbType.VarChar).Value = CurState

                Try
                    connection.Open()
                    txtTaxState.Text = Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error getting the tax codes" & vbNewLine & "Error : " & ex.Message, "Getting Tax Codes", vbOKCancel)
                    If Result = vbCancel Then
                        Exit Sub
                    Else
                        Exit Try
                    End If
                End Try

            End Using

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
End Class