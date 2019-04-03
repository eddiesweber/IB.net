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

        ''Set text box lengths based on tabledef
        'Dim c As Control, fld As String
        'Dim R As New ADODB.Recordset
        'Dim ADOConn As New ADODB.Connection
        'R.Open "Select * from CustomerSurcharge Where 1=0", DB, adOpenStatic
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
        Dim strResult As String

        If DsspGetCustDept.SpGetCustDept.Rows.Count = 0 Then
            CurDept = 0
            Exit Sub
        End If

        ' rs2 - "spGetCustDept (" & CurCust & ")"
        If CurDept > 0 Then
            SpGetCustDeptBindingSource.MoveFirst()

            intRow = SpGetCustDeptBindingSource.Find("DEPT", CurDept)
            'strResult = LogError(Me.Name, "GetData2", "1.0", ex.Message)

            If intRow >= 0 Then
                SpGetCustDeptBindingSource.Position = intRow
            End If
        Else
            SpGetCustDeptBindingSource.MoveFirst()
        End If

        CurDept = DsspGetCustDept.SpGetCustDept.Rows(intRow)("DEPT")

        ' rs / data1
        Me.CustomerSurchargeTableAdapter.Connection.ConnectionString = CS
        Me.CustomerSurchargeTableAdapter.Fill(Me.DsCustomerSurcharge.CustomerSurcharge, CurCust, CurDept)

        GetData3()

    End Sub

    Sub GetData3()

        Dim intRow As Integer

        If DsCustomerSurcharge.CustomerSurcharge.Rows.Count = 0 Then
            cmdNew.PerformClick()
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

        Dim s As String, i As Integer

        buserchange = False

        lstDept.SelectedIndex = lstDept.FindString(DsCustomerSurcharge.CustomerSurcharge.Rows(CustomerSurchargeBindingSource.Position)("DEPT"))
        s = GetItemDesc(DsCustomerSurcharge.CustomerSurcharge.Rows(CustomerSurchargeBindingSource.Position)("ITEM_NUM"))
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

    Private Sub lstDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDept.SelectedIndexChanged

        If buserchange Then
            buserchange = False

            If SpGetCustDeptBindingSource.Count > 0 Then
                CurDept = CType(SpGetCustDeptBindingSource.Current, DataRowView).Item("Dept").ToString()
            End If

            GetData2()

            buserchange = True
        End If

    End Sub

    Private Sub cmdFindCust_Click(sender As Object, e As EventArgs) Handles cmdFindCust.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub frmCustSurcharge_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Keeps events from firing when closing
        buserchange = False

    End Sub
End Class