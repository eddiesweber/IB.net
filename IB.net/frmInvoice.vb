Option Explicit On

Imports System.ComponentModel

Public Class frmInvoice

    Dim buserchange As Boolean

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        If Dir("frmInvoiceItem.xml") <> "" Then
            grdItem.LoadLayout("frmInvoiceItem.xml")
        End If

        buserchange = False

        If CurInvoice < 1 Then
            frmFindInvoice.Show()
            frmFindInvoice.BringToFront()
        Else
            lblCurInvoice.Text = ""
            lblCurInvoice.Text = CurInvoice
        End If

        buserchange = True

    End Sub

    Private Sub lblCurInvoice_TextChanged(sender As Object, e As EventArgs) Handles lblCurInvoice.TextChanged

        Try
            Me.Cursor = Cursors.WaitCursor

            ''Header info
            strLocation = "LCITC1.0"
            SpGetInvoiceHeadingTableAdapter.Connection.ConnectionString = CS
            SpGetInvoiceHeadingTableAdapter.Fill(DsspGetInvoiceHeading.spGetInvoiceHeading, CurInvoice)

            ''Items info
            strLocation = "LCITC2.0"
            SpGetInvoiceItemsTableAdapter.Connection.ConnectionString = CS
            SpGetInvoiceItemsTableAdapter.Fill(DsspGetInvoiceItems.spGetInvoiceItems, CurInvoice)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine lblCurInvoice_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lblCurInvoice_TextChanged", vbOK)
            LogError(Me.Name, "lblCurInvoice_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdRebill_Click(sender As Object, e As EventArgs) Handles cmdRebill.Click

        frmInvRebill.Show()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindInvoice.Show()
        frmFindInvoice.BringToFront()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdEditInv_Click(sender As Object, e As EventArgs) Handles cmdEditInv.Click

        frmInvHead.Show()

    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click

        CurItem = grdItem.Columns(0).Value
        frmInvItem.Show()

    End Sub

    Private Sub frmInvoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdItem.SaveLayout("frmInvoiceItem.xml")

    End Sub

End Class