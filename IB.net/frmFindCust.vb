Option Explicit On

Imports System.Data.SqlClient

Public Class frmFindCust

    Private Sub frmFindCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Result As DialogResult

        ' Fill customer numbers listbox
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("spGetCustsNum", connection)
            cmd.CommandType = CommandType.StoredProcedure

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                lstCustNum.ClearSelected()

                Do While dataReader.Read()
                    lstCustNum.Items.Add(dataReader(0))
                Loop
                dataReader.Close()

            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting the customer numbers" & vbNewLine & "Error : " & ex.Message, "Getting Customer Numbers", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("spGetCustsAlpha", connection)
            cmd.CommandType = CommandType.StoredProcedure

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                lstCustName.ClearSelected()

                Do While dataReader.Read()
                    lstCustName.Items.Add(dataReader(1))
                Loop
                dataReader.Close()

            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting the customer names" & vbNewLine & "Error : " & ex.Message, "Getting Customer Names", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

    End Sub

End Class