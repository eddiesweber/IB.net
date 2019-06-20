Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmInvRebill

    Dim NewDate As Date

    Private Sub frmInvRebill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 200, 200)

        If CurInvoice = 0 Then
            frmFindInvoice.Show()
            frmFindInvoice.BringToFront()
        Else
            lblCurInvoice.Text = CurInvoice
        End If

    End Sub

    Private Sub frmInvRebill_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Private Sub lblCurInvoice_TextChanged(sender As Object, e As EventArgs) Handles lblCurInvoice.TextChanged

        'TotalInvoice - Header info
        If CurInvoice > 0 Then
            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "LCITC1.0"
                SpGetInvoiceHeadingTableAdapter.Connection.ConnectionString = CS
                SpGetInvoiceHeadingTableAdapter.Fill(DsspGetInvoiceHeading.spGetInvoiceHeading, CurInvoice)

                strLocation = "LCITC2.0"
                NewDate = DsspGetInvoiceHeading.spGetInvoiceHeading.Rows(SpGetInvoiceHeadingBindingSource.Position)("Date")
                datNewDate.Value = Format(NewDate, "Short Date")

                txtMemo.Text = ""
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine lblCurInvoice_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lblCurInvoice_TextChanged", vbOK)
                LogError(Me.Name, "lblCurInvoice_TextChanged", strLocation, ex.Message)
            End Try
        End If

    End Sub

    Private Sub datNewDate_ValueChanged(sender As Object, e As EventArgs) Handles datNewDate.ValueChanged

        Dim D1 As Integer
        Dim RunDate As Date

        'Validate for weekend and get weekday
        RunDate = Format(datNewDate.Value, "Short Date")
Calc:
        D1 = GetWeekDay(RunDate)
        If D1 = 99 Then
            RunDate = DateAdd(DateInterval.Day, 1, RunDate)
            datNewDate.Value = Format(RunDate, "Short Date")
            GoTo Calc
        End If
        lblDate.Text = "Day " & D1.ToString

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim OldInv As Long
        Dim NewInv As Long
        Dim Opt As Integer
        Dim Memo As String
        Dim DefMemo As String
        Dim q As String
        Dim ChangeMemo As String
        Dim ADOCmd As New ADODB.Command

        NewDate = Format(datNewDate.Value, "Short Date")

        If optAction0.Checked Then
            Opt = 1
        Else
            Opt = 2
        End If

        Me.Enabled = False
        lblStatus.Text = "Rebilling Invoice"

        Using connection As New SqlConnection(CS)
            Me.Cursor = Cursors.WaitCursor

            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "CO1.0"
                If NewDate = DsspGetInvoiceHeading.spGetInvoiceHeading.Rows(SpGetInvoiceHeadingBindingSource.Position)("Date") Then
                    Me.Cursor = Cursors.Default
                    Me.Enabled = True

                    MsgBox("New Date must be different.", vbOKOnly, "Need new date")

                    Exit Sub
                End If

                strLocation = "CO2.0"
                OldInv = DsspGetInvoiceHeading.spGetInvoiceHeading.Rows(SpGetInvoiceHeadingBindingSource.Position)("INV_NUMBER")
                NewInv = GetInvoiceNum()

                strLocation = "CO3.0"
                Memo = txtMemo.Text
                DefMemo = Format(DsspGetInvoiceHeading.spGetInvoiceHeading.Rows(SpGetInvoiceHeadingBindingSource.Position)("Date"), "Short Date") & " invoice " & CStr(OldInv)
                If Opt = 1 Then
                    DefMemo = DefMemo & " recollected as " & CStr(NewInv)
                    ChangeMemo = "Recollect " & Format(NewDate, "Short Date")
                Else
                    DefMemo = DefMemo & " rescheduled as " & CStr(NewInv)
                    ChangeMemo = "Reschedule " & Format(NewDate, "Short Date")
                End If

                If Memo = "" Then
                    Memo = DefMemo
                    txtMemo.Text = Memo
                End If

                strLocation = "CO4.0"
                connection.Open()

                strLocation = "CO5.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spRebillInvoice"

                strLocation = "CO6.0"
                cmd.Parameters.Add("OldInv", SqlDbType.Int).Value = OldInv
                cmd.Parameters.Add("NewInv", SqlDbType.Int).Value = NewInv
                cmd.Parameters.Add("NEWDATE", SqlDbType.DateTime).Value = Format(NewDate, "Short Date")
                cmd.Parameters.Add("Memo", SqlDbType.VarChar).Value = Memo
                cmd.Parameters.Add("Changememo", SqlDbType.VarChar).Value = ChangeMemo
                cmd.Parameters.Add("Action", SqlDbType.Int).Value = Opt

                strLocation = "CO7.0"
                cmd.ExecuteNonQuery()

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine cmdOK_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdOK_Click", vbOK)
                LogError(Me.Name, "cmdOK_Click", strLocation, ex.Message)
            End Try

        End Using
        'q = "spRebillInvoice " & OldInv & "," & NewInv & ",'" & Format(NewDate, "Short Date") & "','" & Memo & "','" & ChangeMemo & "'," & Opt

        Me.Cursor = Cursors.Default
        Me.Enabled = True

        lblStatus.Text = DefMemo
        CurInvoice = NewInv

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub cmdFindInv_Click(sender As Object, e As EventArgs) Handles cmdFindInv.Click

        frmFindInvoice.Show()
        frmFindInvoice.BringToFront()

    End Sub

End Class