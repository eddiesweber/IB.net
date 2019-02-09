Option Explicit On

Imports System.Data.SqlClient

Public Class frmCust

    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean

    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        Me.Show()
        Me.Enabled = False

        Me.Cursor = Cursors.WaitCursor

        Me.CustomerMasterTableAdapter.Connection.ConnectionString = CS

        If CurCust > 0 Then
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)

            'Set rs = data1.Recordset
            'Line1(0).Y2 = Me.ScaleHeight
            'Line1(1).Y2 = Me.ScaleHeight

            ''Set text box lengths based on rs
            'Dim c As Control, fld As String
            'For Each c In Me.Controls
            '    If TypeOf c Is TextBox Then
            '        fld = c.DataField
            '        If fld > "" Then
            '            Select Case data1.Recordset.Fields(fld).Type
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
        End If

        If DS_CustomerMaster1.CustomerMaster.Rows.Count > 0 Then
            Me.Show()
            GetData()
        Else
            CurCust = 0
            lblCurCust.Text = 0
        End If

        Me.Enabled = True
        Me.Cursor = Cursors.Arrow

    End Sub

    Sub GetData()

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)

            If Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString = "" Then
                txtData11.Text = CCDecrypt(Me.DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.ToString)
            End If
        End If

        'Set rs = data1.Recordset
        'If rs.EOF And rs.BOF Then
        'cmdNew_Click
        'Else
        'If rs.RecordCount > 1 Then cmdFind_Click
        'End If

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

        frmDept.Show()

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        If Not cmdReset.Enabled Then
            buserchange = False
            GetData()
            buserchange = True
        End If

    End Sub

    Public Sub SetModeChange()

        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFind.Enabled = False
        cmdExit.Enabled = False
        cmdEditDept.Enabled = False

    End Sub

    Public Sub SetModeAdd()

        txtData0.Text = -1
        'txtData0.DataChanged = False
        SetModeChange()
        txtData1.Select()

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFind.Enabled = True
        cmdEditDept.Enabled = True

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        CustomerMasterBindingSource.AddNew()
        txtData0.Text = -1

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        CustomerMasterBindingSource.CancelEdit()

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intYesNo As Int16
        Dim blnFindCustOpened As Boolean

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbYes Then
            Dim customersRow As DS_CustomerMaster.CustomerMasterRow
            customersRow = DS_CustomerMaster1.CustomerMaster.FindByCUST_NUM(CurCust)

            customersRow.Delete()

            CustomerMasterTableAdapter.Update(DS_CustomerMaster1.CustomerMaster)

            blnFindCustOpened = False
            For count As Integer = My.Application.OpenForms.Count - 1 To 1 Step -1
                If My.Application.OpenForms(count).Name = "frmFindCust" Then
                    My.Application.OpenForms(count).Close()
                End If
            Next

            CurCust = 0

            frmFindCust.Show()
            frmFindCust.BringToFront()
        End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim Result As DialogResult

        buserchange = False
        bCancel = False

        'Check required data
        If txtData1.Text.Trim() <> "" Then
        Else
            MessageBox.Show("Name is required.")
            bCancel = True
        End If

        'Test for good key value
        If txtData0.Text = -1 And Not bCancel Then
            'Get default key value
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand("Select max(CUST_NUM) as CUST_NUM from CustomerMaster", connection)

                Try
                    connection.Open()
                    CurCust = Convert.ToInt32(cmd.ExecuteScalar())

                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error getting the tax codes" & vbNewLine & "Error : " & ex.Message, "Getting Tax Codes", vbOKCancel)
                    If Result = vbCancel Then
                        Exit Sub
                    Else
                        Exit Try
                    End If
                End Try

            End Using

            Dim newCustomersRow As DS_CustomerMaster.CustomerMasterRow
            newCustomersRow = DS_CustomerMaster1.CustomerMaster.NewCustomerMasterRow

            newCustomersRow.CUST_NUM = CurCust
            newCustomersRow.BILL_NAME = txtData1.Text.ToUpper

            DS_CustomerMaster1.CustomerMaster.Rows.Add(newCustomersRow)
        End If


        If Not bCancel Then
            Dim customersRow As DS_CustomerMaster.CustomerMasterRow
            customersRow = DS_CustomerMaster1.CustomerMaster.FindByCUST_NUM(CurCust)

            customersRow.Last_Change = Now()

            If txtData11.Text.Length() > 0 Then
                customersRow.CC_NUM = CCEncrypt(txtData11.Text)
            End If

            CustomerMasterBindingSource.EndEdit()
            CustomerMasterTableAdapter.Update(DS_CustomerMaster1.CustomerMaster)
            SetModeReg()
        End If

        buserchange = True

    End Sub

    Private Sub lblCurCust_Click(sender As Object, e As EventArgs) Handles lblCurCust.Click

        If Not cmdReset.Enabled Then
            buserchange = False
            GetData()
            buserchange = True
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

End Class