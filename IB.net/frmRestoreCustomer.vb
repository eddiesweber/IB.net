Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmRestoreCustomer

    Private Sub frmRestoreCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetWindowPos(Me, 66, 66)

    End Sub

    Private Sub frmRestoreCustomer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If txtCustNum.Text <= 0 Then
            MessageBox.Show(Me, "Please enter customer number", "Customer Number")
            Exit Sub
        End If

        If txtMemo.Text.Trim = "" Then
            MessageBox.Show(Me, "Please enter change memo", "Change Memo")
            Exit Sub
        End If

        Try
            strLocation = "COK1.0"
            Me.Cursor = Cursors.WaitCursor
            Me.Enabled = False

            Using sqlConn As New SqlClient.SqlConnection
                strLocation = "COK2.0"
                sqlConn.ConnectionString = CS
                sqlConn.Open()

                Using sqlDA As New SqlDataAdapter()
                    Using sqlCmd As New SqlCommand
                        strLocation = "COK3.0"
                        sqlCmd.Connection = sqlConn
                        sqlCmd.CommandType = CommandType.StoredProcedure

                        strLocation = "COK4.0"
                        sqlCmd.CommandText = "spRestoreCustomer"
                        sqlCmd.Parameters.Add("CustNum", SqlDbType.VarChar).Value = txtCustNum.Text
                        sqlCmd.Parameters.Add("Memo", SqlDbType.VarChar).Value = txtMemo.Text
                        sqlDA.SelectCommand = sqlCmd

                        strLocation = "COK5.0"
                        sqlCmd.ExecuteNonQuery()

                        MessageBox.Show(Me, "Finished restoring customer", "Customer Restored")

                        strLocation = "COK5.0"
                        CurCust = txtCustNum.Text

                        strLocation = "COK6.0"
                        frmFindCust.Show()
                        frmFindCust.BringToFront()

                        strLocation = "COK7.0"
                        frmFindCust.cmdRefresh.PerformClick()
                        SetLabelOnAllOpenForms(CurCust, "lblCurCust")

                        strLocation = "COK8.0"
                        frmViewCust.Show()
                        frmViewCust.BringToFront()

                        Me.Close()
                    End Using
                End Using
            End Using

            Me.Cursor = Cursors.Default
            Me.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Me.Enabled = True

            Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
            LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
        End Try

    End Sub
End Class