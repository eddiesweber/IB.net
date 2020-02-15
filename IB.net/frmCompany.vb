Option Explicit On

Imports System.Data.SqlClient

Public Class frmCompany

    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FCL1.0"
            Dim strSQL As String = "Select * From IBConfig"

            strLocation = "FCL2.0"
            lstCompany.Items.Clear()
            Using configDB As New SqlConnection(ConfigCS)
                configDB.Open()

                Using Command As New SqlCommand(strSQL, configDB)
                    strLocation = "FCL3.0"
                    Dim dataReader As SqlDataReader = Command.ExecuteReader()

                    strLocation = "FCL4.0"
                    'If dataReader.HasRows Then
                    Do While dataReader.Read()
                        strLocation = "FCL5.0"
                        lstCompany.Items.Add(dataReader.Item("Location_ID"))
                    Loop
                    'End If
                    dataReader.Close()
                End Using
            End Using

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmCompany_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmCompany_Load", vbOK)
            LogError(Me.Name, "frmCompany_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Try
            strLocation = "COC1.0"
            Me.Cursor = Cursors.WaitCursor

            If lstCompany.SelectedIndex >= 0 Then
                strLocation = "COC2.0"
                Dim NewCo As String = lstCompany.SelectedItem.ToString()

                strLocation = "COC3.0"
                CurCust = 0
                CurDept = 0
                CurItem = 0
                CurInvoice = 0
                Company = NewCo

                strLocation = "COC4.0"
                OpenData()

                strLocation = "COC5.0"
                Me.Dispose()
            Else
                MessageBox.Show("Please select a division.")

                Exit Sub
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine cmdOpen_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOpen_Click", vbOK)
            LogError(Me.Name, "cmdOpen_Click", strLocation, ex.Message)
        End Try


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Dispose()

    End Sub
End Class