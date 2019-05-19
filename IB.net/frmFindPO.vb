Option Explicit On

Imports System.ComponentModel

Public Class frmFindPO

    Private Sub frmFindPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "GD1.0"
            SpGetPOsNumTableAdapter.Connection.ConnectionString = CS
            SpGetPOsNumTableAdapter.Fill(Me.DsspGetPOsNum.SpGetPOsNum)

            strLocation = "GD2.0"
            SpGetPOsAlphaTableAdapter.Connection.ConnectionString = CS
            SpGetPOsAlphaTableAdapter.Fill(Me.DsspGetPOsAlpha.SpGetPOsAlpha)

            If CurPO > 0 Then
                strLocation = "GD3.0"
                SpGetPOsAlphaBindingSource.Position = SpGetPOsAlphaBindingSource.Find("seq", CurPO)
                strLocation = "GD4.0"
                SpGetPOsNumBindingSource.Position = SpGetPOsNumBindingSource.Find("seq", CurPO)
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
            SpGetPOsAlphaBindingSource.Position = SpGetPOsAlphaBindingSource.Find("seq", lstCustNum.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstCustNum_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstCustNum_Click", vbOK)
            LogError(Me.Name, "lstCustNum_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstCustName_Click(sender As Object, e As EventArgs) Handles lstCustName.Click

        Try
            strLocation = "LCNC1.0"
            SpGetPOsNumBindingSource.Position = SpGetPOsNumBindingSource.Find("seq", lstCustName.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "lstCustName_Click" & vbNewLine & "Error : " & ex.Message, "lstCustName_Click", vbOK)
            LogError(Me.Name, "lstCustName_Click", "1.0", ex.Message)
        End Try

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click, lstCustNum.DoubleClick, lstCustName.DoubleClick

        CurPO = lstCustNum.SelectedItem(0)
        SetLabelOnAllOpenForms(CurPO, "lblCurPO")

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub frmFindPO_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

End Class