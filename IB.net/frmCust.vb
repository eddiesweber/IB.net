Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCust

    Dim buserchange As Boolean
    Dim bCancel As Boolean
    Dim bTextChanged As Boolean
    Dim strPAY_TYPE As String

    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        buserchange = False
        bTextChanged = False

        GetWindowPos(Me, 66, 66)

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
                            c1tb.MaxLength = DS_CustomerMaster1.CustomerMaster.Columns(c1tb.DataField).MaxLength
                        End If
                    Case "System.DateTime"
                        c1tb.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
                    Case Else
                        MsgBox(c1tb.Name & ": " & c1tb.DataType.ToString)
                End Select
            End If
        Next

        Line1.Y2 = Me.Height

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            lblCurCust.Text = CurCust
        End If

        buserchange = True

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub frmCust_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs) Handles txtData0.TextChanged

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

        bTextChanged = False

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            CustomerMasterTableAdapter.Connection.ConnectionString = CS
            Me.CustomerMasterTableAdapter.Fill(Me.DS_CustomerMaster1.CustomerMaster, CurCust)

            SetModeReg()
        End If

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

        frmDept.Show()

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

        bTextChanged = False

        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFind.Enabled = True
        cmdEditDept.Enabled = True

    End Sub

    Private Sub CustomerMasterBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles CustomerMasterBindingSource.AddingNew

        Dim drv As DataRowView = DirectCast(CustomerMasterBindingSource.List, DataView).AddNew()

        drv.Row.Item("CUST_NUM") = -1
        drv.Row.Item("BILL_NAME") = txtData1.Text.ToUpper
        drv.Row.Item("PAY_TYPE") = "I"
        drv.Row.Item("MAIL_STATEMENT") = False
        drv.Row.Item("Last_Change") = Now()

        e.NewObject = drv

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        If bTextChanged = True Then
            MessageBox.Show("Please click on 'save' or 'reset' before you add an new user.", "Add new user")
            Exit Sub
        End If

        buserchange = False
        bTextChanged = False

        CustomerMasterBindingSource.AddNew()

        SetModeAdd()

        buserchange = True

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        buserchange = False
        bTextChanged = False

        CustomerMasterBindingSource.CancelEdit()

        GetData()

        SetModeReg()

        buserchange = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        If bTextChanged = True Then
            MessageBox.Show("Please click on 'save' or 'reset' before you cancel the user.", "Cancel user")
            Exit Sub
        End If

        bTextChanged = False
        frmCustCanc.ShowDialog()
        lblCurCust.Text = CurCust

        'Dim intYesNo As Int16
        'Dim blnFindCustOpened As Boolean

        'intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        'If intYesNo = vbYes Then
        '    Dim customersRow As DS_CustomerMaster.CustomerMasterRow
        '    customersRow = DS_CustomerMaster1.CustomerMaster.FindByCUST_NUM(CurCust)

        '    customersRow.Delete()

        '    CustomerMasterTableAdapter.Update(DS_CustomerMaster1.CustomerMaster)

        '    blnFindCustOpened = False
        '    For count As Integer = My.Application.OpenForms.Count - 1 To 1 Step -1
        '        If My.Application.OpenForms(count).Name = "frmFindCust" Then
        '            My.Application.OpenForms(count).Close()
        '        End If
        '    Next

        '    CurCust = 0

        '    frmFindCust.Show()
        '    frmFindCust.BringToFront()
        'End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim Result As DialogResult
        Dim blnNew As Boolean = False

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
            blnNew = True
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand("Select max(CUST_NUM) as CUST_NUM from CustomerMaster", connection)

                Try
                    connection.Open()
                    CurCust = Convert.ToInt32(cmd.ExecuteScalar()) + 1
                    txtData0.Text = CurCust
                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error getting a new customer number" & vbNewLine & "Error : " & ex.Message, "New Customer Number", vbOKCancel)
                    LogError(Me.Name, "cmdUpdate_Click", "1.0", ex.Message)
                    If Result = vbCancel Then
                        Exit Sub
                    Else
                        Exit Try
                    End If
                End Try

            End Using
        End If

        If Not bCancel Then
            txtLastChanged.Text = Now()
            CustomerMasterBindingSource.EndEdit()
            CustomerMasterTableAdapter.Update(DS_CustomerMaster1.CustomerMaster)

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

    Private Sub chkData_CheckedChanged(sender As Object, e As EventArgs) Handles chkData.CheckedChanged

        If buserchange Then
            SetModeChange()
        End If

    End Sub

    Private Sub optData0_CheckedChanged(sender As Object, e As EventArgs) Handles optData0.CheckedChanged

        Optionchanged(0)

    End Sub

    Private Sub optData1_CheckedChanged(sender As Object, e As EventArgs) Handles optData1.CheckedChanged

        Optionchanged(1)

    End Sub

    Private Sub Optionchanged(intOption As Integer)

        If buserchange Then
            ' Shouldn't have to do this, does it just uncheck the opposite option box
            'optData(1 - Index).Value = Not (optData(Index).Value)
            'txtOption.Visible = True
            If optData0.Checked = True Then
                txtOption.Text = optData0.Tag
            Else
                txtOption.Text = optData1.Tag
            End If
            'txtOption.Visible = False
        End If

        If intOption = 0 Then
            txtData11.Text = ""
            txtData11.Enabled = False
        Else
            txtData11.Enabled = True
        End If

    End Sub

    Private Sub txtOption_TextChanged(sender As Object, e As EventArgs) Handles txtOption.TextChanged

        If buserchange Then
            SetModeChange()
        Else
            If optData0.Tag = Trim(txtOption.Text) Then
                optData0.Checked = True
            Else
                optData1.Checked = True
            End If
        End If

    End Sub

End Class