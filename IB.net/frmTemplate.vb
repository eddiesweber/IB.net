Imports System.Data.SqlClient

Public Class frmTemplate

    Private Sub ExecuteScalar_Click(sender As Object, e As EventArgs) Handles ExecuteScalar.Click

        Dim q As String
        Dim LastDate As Date

        q = "SELECT Max(Rundate) RunDate FROM CalcLog Where ProcessDate>0"

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(q, connection)

            Try
                strLocation = "GCL1.0"
                connection.Open()
                LastDate = cmd.ExecuteScalar()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetCalcLog (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetCalcLog", vbOK)
                LogError(Me.Name, "GetCalcLog", strLocation, ex.Message)
            End Try

        End Using

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("Select max(CUST_NUM) as CUST_NUM from CustomerMaster", connection)

            Try
                connection.Open()
                CurCust = Convert.ToInt32(cmd.ExecuteScalar()) + 1
                'txtData0.Text = CurCust
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting a new customer number" & vbNewLine & "Error : " & ex.Message, "New Customer Number", vbOKCancel)
                LogError(Me.Name, "cmdUpdate_Click", "1.0", ex.Message)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim q As String

        'q = "DELETE " & dr("TableName") & " WHERE [" & dr("FieldName") & "]<'" & Format(CutoffDate, "MM/DD/YYYY") & "'"
        Try
            Using connection As New SqlConnection(CS)
                strLocation = "CO10.0"
                Dim command As New SqlCommand(q, connection)
                command.Connection.Open()
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
            LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
        End Try



    End Sub

    Private Sub cmdStoredProcedure_Click(sender As Object, e As EventArgs) Handles cmdStoredProcedure.Click

        Dim ItemTot As Single, ItemTaxable As Single, ItemCount As Integer

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "GII1.0"
                connection.Open()

                strLocation = "GII2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spGetInvInfo"
                cmd.Parameters.Add("Invnum", SqlDbType.Int).Value = CurInvoice

                strLocation = "GII3.0"
                Using sqlReader = cmd.ExecuteReader()
                    If sqlReader.HasRows = True Then
                        strLocation = "GII4.0"
                        sqlReader.Read()

                        strLocation = "GII5.0"
                        If Not sqlReader.IsDBNull("ext") Then
                            ItemTot = sqlReader("ext")
                        End If
                    End If
                End Using
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetItemInfo (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetItemInfo", vbOK)
                LogError(Me.Name, "GetItemInfo", strLocation, ex.Message)
            End Try

        End Using

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        ' frmCompany
        Dim strSQL As String

        'lstCompany.Items.Clear()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        strSQL = "Select * From IBConfig"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                If dataReader.HasRows Then
                    Do While dataReader.Read()
                        'lstCompany.Items.Add(dataReader.Item("Location_ID"))
                    Loop
                End If
                dataReader.Close()

            Catch ex As Exception
                LogError(Me.Name, "frmCompany_Load", "1.0", ex.Message)
                MessageBox.Show("Error in form: frmCompany, error loading division names to listbox." & vbNewLine & ex.Message)
            End Try
        End Using

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        strSQL = "Select * From IBConfig where Location_ID='" & Company & "'"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                If dataReader.HasRows Then
                    DBName = dataReader.Item("DBName")
                    Server = dataReader.Item("ServerName")
                End If

                dataReader.Close()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                LogError(Me.Name, "cmdConnectDivision_Click", "1.0", ex.Message)
                MessageBox.Show("Error getting division name (FSC-CCD1.0)" & vbNewLine & ex.Message, "Division Name")

                Exit Sub
            End Try
        End Using

    End Sub
End Class