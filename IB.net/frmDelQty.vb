Imports System.ComponentModel

Public Class frmDelQty

    Dim blnEdit As Boolean
    Dim blnNoClick As Boolean
    Dim blnFormLoadStarted As Boolean = False

    Private Sub frmDelQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        blnNoClick = True
        blnFormLoadStarted = True

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FDQ_FDQL1.0"
            'GetWindowPos(Me, 166, 166)

            strLocation = "FDQ_FDQL1.0"
            If Dir("frmDelQtygrdItems.xml") <> "" Then
                'grdItems.LoadLayout("frmDelQtygrdItems.xml")
            End If

            strLocation = "FDQ_FDQL1.0"
            If CurCust = 0 Then
                frmFindCust.Show()
                frmFindCust.BringToFront()
            Else
                lblCurCust.Text = CurCust
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmDelQty_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmDelQty_Load", vbOK)
            LogError(Me.Name, "frmDelQty_Load", strLocation, ex.Message)
        Finally
            blnNoClick = False
            SetModeReg()
        End Try

    End Sub

    Private Sub frmDelQty_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Keeps events from firing when closing
        blnNoClick = True

        If blnEdit = True Then
            Dim intYesNo As Int16

            intYesNo = MessageBox.Show(Me, "Do you want to save your changes before exiting?", vbYesNo, "Save Record")
            If intYesNo = vbYes Then
                If UpdateAllItemsOnFormAfterSave() = False Then
                    intYesNo = MessageBox.Show(Me, "There was an error saving changes, do you still want to exit?", vbYesNo, "Error saving data")
                    If intYesNo <> vbYes Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If

        SaveWindowPos(Me)

        grdItems.SaveLayout("frmDelQtygrdItems.xml")

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs)

        GetData()

    End Sub

    Public Function UpdateAllItemsOnFormAfterSave() As Boolean

        UpdateAllItemsOnFormAfterSave = False

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTM_UAIOFAS1.0"
            grdItems.UpdateData()

            strLocation = "FTM_UAIOFAS2.0"
            'Me.SpGetCustDeptTableAdapter.EndEdit()
            'Me.SpGetCustDeptTableAdapter.Update(dsTestingHeader.TestingHeader)

            ' use this - eddie - 3/20/20
            ' [SpUpdateCustomerDepartment]

            strLocation = "FTM_UAIOFAS3.0"
            SetModeReg()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine UpdateAllItemsOnFormAfterSave (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateAllItemsOnFormAfterSave", vbOK)
            LogError(Me.Name, "UpdateAllItemsOnFormAfterSave", strLocation, ex.Message)
        End Try

    End Function

    Private Sub txtData0_TextChanged(sender As Object, e As EventArgs)

        'bTextChanged = True

        'If buserchange Then
        '    SetModeChange()
        'Else
        '    'Handle invisible boxes
        '    Select Case sender.name
        '        Case "txtData1"
        '            'lstDept.BoundText = txtData(1).Text
        '    End Select
        'End If

    End Sub

    Sub GetData()

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            'bTextChanged = False

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

        ' use this - eddie - 3/20/20
        ' [SpUpdateCustomerDepartment]

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

    Private Sub lstDept_SelectedIndexChanged(sender As Object, e As EventArgs)

        'If buserchange Then
        '    buserchange = False

        '    If SpGetCustDeptBindingSource.Count > 0 Then
        '        CurDept = CType(SpGetCustDeptBindingSource.Current, DataRowView).Item("Dept").ToString()
        '    End If

        '    GetData2()

        '    buserchange = True
        'End If

    End Sub

    Private Sub cmdFindCust_Click(sender As Object, e As EventArgs)

        If blnEdit = True Then
            Dim intYesNo As Int16

            intYesNo = MsgBox("Do you want to save your changes before changing customer?", vbYesNo, "Save Record")
            If intYesNo = vbYes Then
                If UpdateAllItemsOnFormAfterSave() = False Then
                    MessageBox.Show(Me, "There was an error saving changes, your changes were not saved.", vbOKOnly, "Error saving data")
                    Exit Sub
                End If
            End If
        End If

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

End Class