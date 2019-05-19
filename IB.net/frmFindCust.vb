Option Explicit On

Imports System.ComponentModel

Public Class frmFindCust

    Private Sub frmFindCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        GetData()

    End Sub

    Private Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "GD1.0"
            SpGetCustsNumTableAdapter.Connection.ConnectionString = CS
            SpGetCustsNumTableAdapter.Fill(Me.DsspGetCustsNum.SpGetCustsNum)

            strLocation = "GD2.0"
            SpGetCustsAlphaTableAdapter.Connection.ConnectionString = CS
            SpGetCustsAlphaTableAdapter.Fill(Me.DsspGetCustsAlpha.SpGetCustsAlpha)

            If CurCust > 0 Then
                strLocation = "GD3.0"
                SpGetCustsNumBindingSource.Position = SpGetCustsNumBindingSource.Find("CUST_NUM", CurCust)
                strLocation = "GD4.0"
                SpGetCustsAlphaBindingSource.Position = SpGetCustsAlphaBindingSource.Find("CUST_NUM", CurCust)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub lstCustNum_Click(sender As Object, e As EventArgs) Handles lstCustNum.Click

        Try
            strLocation = "LCNC1.0"
            SpGetCustsAlphaBindingSource.Position = SpGetCustsAlphaBindingSource.Find("CUST_NUM", lstCustNum.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstCustNum_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstCustNum_Click", vbOK)
            LogError(Me.Name, "lstCustNum_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstCustName_Click(sender As Object, e As EventArgs) Handles lstCustName.Click

        Try
            strLocation = "LCNC1.0"
            SpGetCustsNumBindingSource.Position = SpGetCustsNumBindingSource.Find("CUST_NUM", lstCustName.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstCustName_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstCustName_Click", vbOK)
            LogError(Me.Name, "lstCustName_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click, lstCustNum.DoubleClick, lstCustName.DoubleClick

        CurCust = lstCustNum.SelectedItem("CUST_NUM")

        SetLabelOnAllOpenForms(CurCust, "lblCurCust")

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub frmFindCust_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

End Class