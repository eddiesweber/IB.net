Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCustCanc

    Private Sub frmCustCanc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 22, 22)

        txtCust.Text = frmCust.txtData0.Text & " " & frmCust.txtData1.Text

        datDate.Value = Now

        txtMemo.Select()

    End Sub

    Private Sub frmCustCanc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim q As String
        Dim Result As DialogResult

        Me.Cursor = Cursors.WaitCursor

        Me.Enabled = False

        Try
            Using sqlConn As New SqlClient.SqlConnection
                sqlConn.ConnectionString = CS
                sqlConn.Open()

                Using sqlDA As New SqlDataAdapter()
                    Using sqlCmd As New SqlCommand
                        sqlCmd.Connection = sqlConn
                        sqlCmd.CommandType = CommandType.StoredProcedure

                        sqlCmd.CommandText = "spCancelCustomer"
                        sqlCmd.Parameters.Add("CustNum", SqlDbType.VarChar).Value = CurCust
                        sqlCmd.Parameters.Add("RunDate", SqlDbType.VarChar).Value = datDate.Text
                        sqlCmd.Parameters.Add("Memo", SqlDbType.VarChar).Value = txtMemo.Text
                        sqlDA.SelectCommand = sqlCmd

                        sqlCmd.ExecuteNonQuery()
                    End Using
                End Using
            End Using

            CustFileChanged = True

            CurCust = 0

            Me.Close()
        Catch ex As Exception
            LogError(Me.Name, "cmdOK_CLick", "1.0", ex.Message)
            Result = MessageBox.Show(Me, "Error cancelling customer" & vbNewLine & "Error : " & ex.Message, "Cancel Customer", vbOKCancel)
        Finally
            Me.Cursor = Cursors.Default

            Me.Enabled = True
        End Try
    End Sub

End Class