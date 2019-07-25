Option Explicit On

Imports System.Data.SqlClient

Public Class frmInvPhys2

    Dim DT As Date

    Private Sub frmInvPhys2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            strLocation = "FIP2-1.0"
            Me.Cursor = Cursors.WaitCursor

            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand("Select max([Date]) from ItemTemp", connection)

                strLocation = "FIP2-2.0"
                connection.Open()

                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                Option10.Enabled = False
                If dataReader.HasRows = True Then
                    dataReader.Read()

                    strLocation = "FIP2-3.0"
                    If Not IsDBNull(dataReader(0)) Then
                        If IsDate(dataReader(0)) Then
                            strLocation = "FIP2-4.0"
                            Option10.Enabled = True
                            DT = Format(dataReader(0), "Short Date")
                            Me.Visible = True
                            txtDate.Text = DT
                        End If
                    End If
                End If

                dataReader.Close()
                Me.Cursor = Cursors.Default
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmInvPhys2_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmInvPhys2_Load", vbOK)
            LogError(Me.Name, "frmInvPhys2_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click

        frmInvPhys.lblStatus.Text = "Cancel"
        Me.Close()

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        If Not IsDate(datDate.Text) And Option11.Checked = True Then
            MsgBox("You must enter a date", vbOKOnly, "No as of date")
            Exit Sub
        End If

        If Option10.Checked = True Then
            DT = txtDate.Value
            frmInvPhys.lblStatus.Text = "Old"
        Else
            Try
                Using connection As New SqlConnection(CS)
                    Dim cmd As SqlCommand = New SqlCommand

                    strLocation = "OBC1.0"
                    connection.Open()

                    strLocation = "OBC2.0"
                    cmd.Connection = connection
                    cmd.CommandType = CommandType.StoredProcedure

                    If Option10.Enabled Then
                        strLocation = "OBC3.0"
                        Result = MsgBox("Previous worksheet will be deleted", vbOKCancel, "Clear old Worksheet?")
                        DT = txtDate.Value

                        If Result = vbCancel Then
                            Exit Sub
                        End If

                        strLocation = "OBC4.0"
                        cmd.CommandText = "spClearItemTemp"
                        cmd.Parameters.Add("Dat", SqlDbType.Date).Value = Format(DT, "Short Date")
                        cmd.ExecuteNonQuery()
                    End If

                    DT = datDate.Value

                    strLocation = "OBC5.0"
                    cmd.CommandText = "spLoadItemTemp"
                    cmd.Parameters.Clear()
                    cmd.Parameters.Add("Dat", SqlDbType.Date).Value = Format(DT, "Short Date")
                    cmd.ExecuteNonQuery()
                End Using

                frmInvPhys.lblStatus.Text = "New"

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine OKButton_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "OKButton_Click", vbOK)
                LogError(Me.Name, "OKButton_Click", strLocation, ex.Message)
            End Try
        End If

        frmInvPhys.lblDate.Text = Format(DT, "Short Date")

        Me.Close()

    End Sub

End Class