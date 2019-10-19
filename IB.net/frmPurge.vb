Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPurge

    Private Sub frmPurge_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetWindowPos(Me, 33, 33)

        PurgeTableAdapter.Connection.ConnectionString = CS
        PurgeTableAdapter.Fill(DsPurge.Purge)

        LoadScreen()

    End Sub

    Private Sub frmPurge_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        cmdOK.Top = Me.Height - 75
        cmdCancel.Top = Me.Height - 75
        cmdCancel.Left = Me.Width - 110

    End Sub

    Private Sub frmPurge_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub LoadScreen()

        Dim i As Integer
        Dim LineSpace As Integer = 20
        Dim L As Integer
        Dim Result As DialogResult
        Dim newLabel As New Label

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "LS1.0"
            For Each dr As DataRow In PurgeTableAdapter.GetData()
                strLocation = "LS2.0"
                i = dr("key")
                L = lblName0.Top + (i - 1) * LineSpace

                strLocation = "LS3.0"
                newLabel = New Label
                newLabel.Enabled = True
                newLabel.Visible = True
                newLabel.ForeColor = lblName0.ForeColor
                newLabel.Name = "lblname" + i.ToString
                newLabel.Size = New System.Drawing.Size(160, 13)
                newLabel.Location = New Point(10, L)
                newLabel.Text = dr("Description")
                Me.Controls.Add(newLabel)

                strLocation = "LS4.0"
                newLabel = New Label
                newLabel.Enabled = True
                newLabel.Visible = True
                newLabel.ForeColor = lblName0.ForeColor
                newLabel.Name = "lblMonth" + i.ToString
                newLabel.Size = New System.Drawing.Size(160, 13)
                newLabel.Location = New Point(170, L)
                newLabel.Text = dr("Months")
                Me.Controls.Add(newLabel)

                strLocation = "LS5.0"
                newLabel = New Label
                newLabel.Enabled = True
                newLabel.Visible = True
                newLabel.ForeColor = lblName0.ForeColor
                newLabel.Name = "lblCount" + i.ToString
                newLabel.Size = New System.Drawing.Size(160, 13)
                newLabel.Location = New Point(220, L)
                newLabel.Text = ""
                Me.Controls.Add(newLabel)
            Next

            strLocation = "LS6.0"
            cmdOK.Top = L + 25
            cmdCancel.Top = L + 25
            Me.Height = L + 100

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine LoadScreen (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LoadScreen", vbOK)
            LogError(Me.Name, "LoadScreen", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        MessageBox.Show(Me, "This routine appears to be unused, not tested in new IB.net program, exiting...", vbOK)
        Exit Sub

        Dim i As Integer
        Dim q As String
        Dim CutoffDate As Date
        Dim ct As Integer
        Dim cust As Long

        Result = MessageBox.Show(Me, "Are you sure?", "Purge Data", vbYesNo)
        If Result = vbNo Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        For Each dr As DataRow In PurgeTableAdapter.GetData()
            i = dr("key")
            If dr("TableName") = "Special" Then
                Select Case dr("FieldName")
                    Case "Cancel"
                        'Cancelled customers purge
                        ct = 0
                        CutoffDate = DateAdd("m", 0 - dr("Months"), Now())

                        CustomerMasterTableAdapter.Connection.ConnectionString = CS
                        CustomerMasterTableAdapter.Fill(DsCustomerMasterPurge.CustomerMaster, CutoffDate)

                        If DsCustomerMasterPurge.CustomerMaster.Rows.Count > 0 Then
                            For Each rowCustomerMaster As DataRow In DsCustomerMasterPurge.CustomerMaster
                                cust = dr.Item("CUST_NUM")
                                dr.Delete()

                                If cust > 0 Then
                                    q = "DELETE  CancCustDepartment WHERE CUST_NUM=" & cust
                                    Using connection As New SqlConnection(CS)
                                        strLocation = "CO10.0"
                                        Dim command As New SqlCommand(q, connection)
                                        command.Connection.Open()
                                        command.ExecuteNonQuery()
                                    End Using

                                    q = "DELETE  CancCustRoute WHERE CUST_NUM=" & cust
                                    Using connection As New SqlConnection(CS)
                                        strLocation = "CO10.0"
                                        Dim command As New SqlCommand(q, connection)
                                        command.Connection.Open()
                                        command.ExecuteNonQuery()
                                    End Using

                                    q = "DELETE CancCustInventory WHERE CUST_NUM=" & cust
                                    Using connection As New SqlConnection(CS)
                                        strLocation = "CO10.0"
                                        Dim command As New SqlCommand(q, connection)
                                        command.Connection.Open()
                                        command.ExecuteNonQuery()
                                    End Using

                                    ct = ct + 1
                                End If
                            Next
                        End If

                        'lblCount & i. = ct
                        For Each ctrl As Control In Me.Controls
                            If TypeOf ctrl Is Label Then
                                If ctrl.Name = "lblCount" & i.ToString.Trim Then
                                    ctrl.Text = i.ToString.Trim
                                End If
                            End If
                        Next

                        DsCustomerMasterPurge.Clear()
                    Case "Label"
                        'Delete label files
                        'On Error GoTo DeleteFailed
                        ct = 0
                        CutoffDate = DateAdd("m", 0 - dr("Months"), Now())
'Labels:
                            'For Each td In DB.TableDefs
                            '    q = td.Name
                            '    If Left(q, 6) = "Labels" And td.DateCreated < CutoffDate Then
                            '        DB.TableDefs.Delete q
                            '        ct = ct + 1
                            '        Set td = Nothing
                            '        GoTo Labels
                            '    End If
                            'Next
                            'lblCount(i) = ct
                            'DoEvents
                    Case "VolMonth"
                        'Purge VolumeByMonth
                        'On Error GoTo PurgeFailed

                        CutoffDate = DateAdd("m", 0 - dr("Months"), Now())
                        q = "DELETE  VolumeByMonth WHERE YR_MONTH<" & CutoffDate
                        Using connection As New SqlConnection(CS)
                            strLocation = "CO10.0"
                            Dim command As New SqlCommand(q, connection)
                            command.Connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                    Case Else
                        MessageBox.Show(Me, "Unrecognized special routine: " & dr("FieldName"), vbOKOnly)
                End Select
            Else
                'Standard purge routine
                CutoffDate = DateAdd("m", 0 - dr("Months"), Now())

                q = "DELETE " & dr("TableName") & " WHERE [" & dr("FieldName") & "]<'" & Format(CutoffDate, "MM/DD/YYYY") & "'"
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
            End If
        Next

    End Sub
End Class