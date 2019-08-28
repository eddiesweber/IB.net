Option Explicit On

Imports System.Data.SqlClient

Public Class frmCompany

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSQL As String

        lstCompany.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        strSQL = "Select * From IBConfig"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                If dataReader.HasRows Then
                    Do While dataReader.Read()
                        lstCompany.Items.Add(dataReader.Item("Location_ID"))
                    Loop
                End If
                dataReader.Close()

            Catch ex As Exception
                LogError(Me.Name, "frmCompany_Load", "1.0", ex.Message)
                MessageBox.Show("Error in form: frmCompany, error loading division names to listbox." & vbNewLine & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Dim NewCo As String

        If lstCompany.SelectedIndex >= 0 Then
            NewCo = lstCompany.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select a division.")

            Exit Sub
        End If

        If NewCo <> Company Then
            Company = NewCo
            CurCust = 0
            CurDept = 0
            CurItem = 0
            CurInvoice = 0

            'OpenData()
        End If

        If Not DB Is Nothing Then
            Company = lstCompany.SelectedItem.ToString

            Me.Close()
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Application.Exit()

    End Sub
End Class