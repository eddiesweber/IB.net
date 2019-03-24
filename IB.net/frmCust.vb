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

        txtData1.MaxLength = DS_CustomerMaster1.CustomerMaster.BILL_NAMEColumn.MaxLength
        txtData2.MaxLength = DS_CustomerMaster1.CustomerMaster.BILL_STRColumn.MaxLength
        txtData3.MaxLength = DS_CustomerMaster1.CustomerMaster.BILL_CTYColumn.MaxLength
        txtData4.MaxLength = DS_CustomerMaster1.CustomerMaster.BILL_STATEColumn.MaxLength
        txtData5.MaxLength = DS_CustomerMaster1.CustomerMaster.BILL_ZIPColumn.MaxLength
        txtData6.MaxLength = DS_CustomerMaster1.CustomerMaster.CARE_OFColumn.MaxLength
        txtData7.MaxLength = DS_CustomerMaster1.CustomerMaster.CONTACTColumn.MaxLength
        txtData8.MaxLength = DS_CustomerMaster1.CustomerMaster.EMAILColumn.MaxLength
        txtData9.MaxLength = DS_CustomerMaster1.CustomerMaster.URLColumn.MaxLength
        txtData10.MaxLength = DS_CustomerMaster1.CustomerMaster.COUNTYColumn.MaxLength
        txtData11.MaxLength = DS_CustomerMaster1.CustomerMaster.CC_NUMColumn.MaxLength
        txtData17.MaxLength = DS_CustomerMaster1.CustomerMaster.COMMENTSColumn.MaxLength
        txtOption.MaxLength = DS_CustomerMaster1.CustomerMaster.PAY_TYPEColumn.MaxLength
        txmData0.MaxLength = DS_CustomerMaster1.CustomerMaster.PHONEColumn.MaxLength
        txmData1.MaxLength = DS_CustomerMaster1.CustomerMaster.FAX_NOColumn.MaxLength

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

    Private Sub frmCust_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

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

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        If bTextChanged = True Then
            MessageBox.Show("Please click on 'save' or 'reset' before you add an new user.", "Add new user")
            Exit Sub
        End If

        buserchange = False
        bTextChanged = False

        CustomerMasterBindingSource.AddNew()
        txtData0.Text = -1

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

                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error getting a new customer number" & vbNewLine & "Error : " & ex.Message, "New Customer Number", vbOKCancel)
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
            newCustomersRow.PAY_TYPE = "I"
            newCustomersRow.MAIL_STATEMENT = False
            newCustomersRow.Last_Change = Now()

            DS_CustomerMaster1.CustomerMaster.Rows.Add(newCustomersRow)
            CustomerMasterTableAdapter.Update(DS_CustomerMaster1.CustomerMaster)

            GetData()
            bCancel = True
        End If

        If Not bCancel Then
            'Dim customersRow As DS_CustomerMaster.CustomerMasterRow
            'customersRow = DS_CustomerMaster1.CustomerMaster.FindByCUST_NUM(CurCust)

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

        Dim i As Integer

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
            Dim i As Integer

            If optData0.Tag = Trim(txtOption.Text) Then
                optData0.Checked = True
            Else
                optData1.Checked = True
            End If
        End If

    End Sub

End Class