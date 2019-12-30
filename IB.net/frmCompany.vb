Option Explicit On

Imports System.Data.SqlClient

Public Class frmCompany

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strLocation = "FCL1.0"
        lstCompany.Items.Clear()

        Dim strSQL As String = "Select * From IBConfig"

        Using Command As New SqlCommand(strSQL, configDB)
            Try
                strLocation = "FCL2.0"
                Dim dataReader As SqlDataReader = Command.ExecuteReader()

                strLocation = "FCL3.0"
                If dataReader.HasRows Then
                    Do While dataReader.Read()
                        strLocation = "FCL4.0"
                        lstCompany.Items.Add(dataReader.Item("Location_ID"))
                    Loop
                End If
                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in routine frmCompany_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmCompany_Load", vbOK)
                LogError(Me.Name, "frmCompany_Load", strLocation, ex.Message)
            End Try
        End Using

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Try
            strLocation = "COC1.0"
            If lstCompany.SelectedIndex >= 0 Then
                strLocation = "COC2.0"
                Dim NewCo As String = lstCompany.SelectedItem.ToString()

                If NewCo <> Company Then
                    CurCust = 0
                    CurDept = 0
                    CurItem = 0
                    CurInvoice = 0

                    strLocation = "COC3.0"
                    Company = NewCo

                    OpenData()
                End If

                If Not DB Is Nothing Then
                    strLocation = "COC4.0"
                    Company = lstCompany.SelectedItem.ToString

                    Me.Close()
                End If
            Else
                MessageBox.Show("Please select a division.")

                Exit Sub
            End If
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine cmdOpen_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOpen_Click", vbOK)
            LogError(Me.Name, "cmdOpen_Click", strLocation, ex.Message)
        End Try


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Application.Exit()

    End Sub
End Class