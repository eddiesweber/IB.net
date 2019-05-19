Option Explicit On

Imports System.ComponentModel

Public Class frmFindVend

    Private Sub frmFindVend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        GetData()

    End Sub

    Private Sub GetData()

        Me.Cursor = Cursors.Arrow

        Try
            strLocation = "GD1.0"
            VendMasterTableAdapter.Connection.ConnectionString = CS
            VendMasterTableAdapter.Fill(DsVendMasterFind_Vendor.VendMaster)

            strLocation = "GD2.0"
            VendMasterTableAdapter1.Connection.ConnectionString = CS
            VendMasterTableAdapter1.Fill(DsVendMasterFind_VendorName.VendMaster)

            If CurVend <> "" Then
                strLocation = "GD3.0"
                VendMasterBindingSource1.Position = VendMasterBindingSource1.Find("Vendor", CurVend)
                strLocation = "GD4.0"
                VendMasterBindingSource.Position = VendMasterBindingSource.Find("Vendor", CurVend)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub lstCustNum_Click(sender As Object, e As EventArgs) Handles lstCustNum.Click

        Try
            strLocation = "LCNC1.0"
            VendMasterBindingSource1.Position = VendMasterBindingSource1.Find("Vendor", lstCustNum.SelectedValue)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstCustNum_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstCustNum_Click", vbOK)
            LogError(Me.Name, "lstCustNum_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstCustName_Click(sender As Object, e As EventArgs) Handles lstCustName.Click

        Try
            strLocation = "LCNC1.0"
            VendMasterBindingSource.Position = VendMasterBindingSource.Find("Vendor", lstCustName.SelectedValue)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstCustName_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstCustName_Click", vbOK)
            LogError(Me.Name, "lstCustName_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click, lstCustNum.DoubleClick, lstCustName.DoubleClick

        CurVend = lstCustNum.SelectedItem(0)
        SetLabelOnAllOpenForms(CurVend, "lblCurVend")

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub frmFindVend_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

End Class