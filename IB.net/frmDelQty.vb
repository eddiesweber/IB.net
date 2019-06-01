Imports System.ComponentModel

Public Class frmDelQty

    Dim buserchange As Boolean
    Dim buserchange2 As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean
    Dim bTextChanged As Boolean

    Private Sub frmDelQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        buserchange = False
        bInit = True
        bTextChanged = False

        GetWindowPos(Me, 166, 166)

        If Dir("frmDelQtygrdItems.xml") <> "" Then
            grdItems.LoadLayout("frmDelQtygrdItems.xml")
        End If

        'Line1(0).Y2 = Me.ScaleHeight
        'Line1(1).Y2 = Me.ScaleHeight

        SetModeReg()

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

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs) Handles txtData0.TextChanged, txtdata1.TextChanged

        bTextChanged = True

        If buserchange Then
            SetModeChange()
        Else
            'Handle invisible boxes
            Select Case sender.name
                Case "txtData1"
                    'lstDept.BoundText = txtData(1).Text
            End Select
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

        Dim q As String

        'Goto current department
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
            Else
                intRow = 0
            End If
        Else
            SpGetCustDeptBindingSource.MoveFirst()
        End If

        CurDept = DsspGetCustDept.SpGetCustDept.Rows(intRow)("DEPT")
        txtCustDept.Text = DsspGetCustDept.SpGetCustDept.Rows(intRow)("Name")

        ' rs / data1
        VwGetDelQtyTableAdapter.Connection.ConnectionString = CS
        VwGetDelQtyTableAdapter.Fill(DsvwGetDelQty.vwGetDelQty, CurCust, CurDept)


        If DsvwGetDelQty.vwGetDelQty.Rows.Count = 0 Then
            frmFindCust.Show()
            Exit Sub
        End If

        SetNew2Old()

    End Sub

    Sub SetNew2Old()

        'Dim X As Single
        'If rs.RecordCount > 0 Then
        '    rs.MoveFirst
        '    While Not rs.EOF
        '        X = Val(grdItems.Columns(3).Value)
        '        grdItems.Columns(3).Value = X
        '        grdItems.Columns(4).Text = grdItems.Columns(3).Text
        '        rs.MoveNext
        '    Wend
        '    rs.MoveFirst
        'End If

    End Sub
    Sub SetOld2New()

        'rs.MoveFirst
        'While Not rs.EOF
        '    grdItems.Columns(3).Text = grdItems.Columns(4).Text
        '    rs.MoveNext
        'Wend

    End Sub

    Public Sub SetModeChange()

        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFindCust.Enabled = False
        cmdExit.Enabled = False
        lstDept.Visible = False
        txtdata1.Visible = True
        txtdata1.Enabled = False

    End Sub

    Public Sub SetModeReg()

        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindCust.Enabled = True
        txtdata1.Visible = False
        lstDept.Visible = True

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

    Private Sub frmDelQty_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Keeps events from firing when closing
        buserchange = False

        SaveWindowPos(Me)

        grdItems.SaveLayout("frmDelQtygrdItems.xml")

    End Sub

End Class