Option Explicit On

Imports System.ComponentModel

Public Class frmInvAdj

    Dim buserchange As Boolean
    Dim Dat As Date
    Dim Typ As Char
    'Dim Typ As String * 1
    Dim Item As Long
    'Dim Source As String * 1
    Dim Source As Char
    'Dim Dest As String * 1
    Dim Dest As Char
    Dim Qty As Single

    Private Sub frmInvAdj_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 6, 133)
        buserchange = False

        Try
            strLocation = "FIAL1.0"
            lstAction.Items.Add("Purchase")
            lstAction.Items.Add("Move to Damaged")
            lstAction.Items.Add("Restore from Damaged")
            lstAction.Items.Add("Dispose from Owned")
            lstAction.Items.Add("Dispose from Damaged")
            lstAction.SelectedIndex = 0

            strLocation = "FIAL2.0"
            txtQty.Text = "0"
            Dat = Now
            datDate.Value = Now

            lblCurItem.Text = CurItem

            buserchange = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmInvAdj_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmInvAdj_Load", vbOK)
            LogError(Me.Name, "frmInvAdj_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub frmInvAdj_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub lblCurItem_TextChanged(sender As Object, e As EventArgs) Handles lblCurItem.TextChanged

        txtItem.Text = CurItem
        txtItemLostFocus()
            txtQty.Select()

    End Sub

    Private Sub txtItem_GotFocus(sender As Object, e As EventArgs)

        txtItem.SelectionStart = 0
        txtItem.SelectionLength = Len(txtItem.Text)

    End Sub

    Private Sub txtItem_LostFocus(sender As Object, e As EventArgs)

        txtItemLostFocus()

    End Sub

    Private Sub txtItemLostFocus()

        Try
            If txtItem.Text <> "" Then
                Dim Des As String = GetItemDesc(txtItem.Text)

                strLocation = "TILF1.0"
                If Des = "error" Then
                    MsgBox("Item not found.", vbOKOnly, "Validation Error")
                    txtItem.Select()

                    Exit Sub
                End If

                strLocation = "TILF2.0"
                txtType.Text = CurType
                strLocation = "TILF3.0"
                txtItemDesc.Text = Des
                strLocation = "TILF4.0"
                Item = txtItem.Text
                Typ = txtType.Text
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine txtItemLostFocus (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "txtItemLostFocus", vbOK)
            LogError(Me.Name, "txtItemLostFocus", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub txtItem_Enter(sender As Object, e As EventArgs)

        txtQty.SelectionStart = 0
        txtQty.SelectionLength = Len(txtQty.Text)

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

        Qty = Val(txtQty.Text)
        ValidateQty()

    End Sub

    Sub ValidateQty()

        If Val(txtQty.Text) <> 0 And txtItem.Text <> "" Then
            cmdUpdate.Enabled = True
        Else
            cmdUpdate.Enabled = False
        End If

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        Dat = datDate.Value

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdCancel.MouseDown

        txtItem.Text = ""

    End Sub

    Private Sub cmdFindItem_Click(sender As Object, e As EventArgs) Handles cmdFindItem.Click

        frmFindItem.Show()
        frmFindItem.BringToFront()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        'Dim s As String
        'Dim ADOCmd As New ADODB.Command
        'ADOCmd.ActiveConnection = DB

        Select Case lstAction.SelectedIndex
            Case 0 ' Purchase
                Source = "P"
                Dest = "O"
            Case 1 ' Damaged
                Source = ""
                Dest = "D"
            Case 2 ' Restore from damaged
                Source = "D"
                Dest = ""
            Case 3 ' Dispose from owned
                Source = "O"
                Dest = "S"
            Case 4 ' Dispose from damaged
                Source = "D"
                Dest = "S"
        End Select

        PostInvChange(Dat, Typ, Item, Source, Dest, Qty, True)

        lblStatus.Text = "Updated item " & CStr(Item) & " (" & Typ & "), " & lstAction.SelectedItem & ", Qty=" & CStr(Qty)
        txtQty.Text = "0"
        txtItem.Select()

    End Sub

End Class