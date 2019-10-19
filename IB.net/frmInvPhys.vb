Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid

Public Class frmInvPhys

    Dim buserchange As Boolean
    Dim bInit As Boolean
    'Dim CurState As String * 2
    Dim CurState As String
    Dim bCancel As Boolean
    Dim bEditInProgress As Boolean

    Private Sub frmInvPhys_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        If Dir("frmInvPhysgrdItemTemp.xml") <> "" Then
            grdItemTemp.LoadLayout("frmInvPhysgrdItemTemp.xml")
        End If

        Me.Show()

        frmInvPhys2.ShowDialog()

        If lblStatus.Text = "Cancel" Then
            Me.Close()
            Exit Sub
        End If

        buserchange = False
        bInit = True

        GetData2()

        If lblStatus.Text = "Old" Then
            bEditInProgress = True
            SetModeChange()
        End If

    End Sub

    Private Sub frmInvPhys_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        If Not bEditInProgress And IsDate(lblDate) Then
            Result = MsgBox("Done with this worksheet?", vbYesNo, "Exit Program")
            If Result = vbYes Then
                ClearItemTemp()
            End If
        End If

        SaveWindowPos(Me)

        grdItemTemp.SaveLayout("frmInvPhysgrdItemTemp.xml")

    End Sub

    Sub GetData()

        Dim intQueryResult As Integer

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                Me.Cursor = Cursors.WaitCursor
                strLocation = "GD1.0"
                connection.Open()

                strLocation = "GD2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spLoadItemTemp"
                cmd.Parameters.Add("Dat", SqlDbType.Date).Value = CDate(lblDate.Text)

                strLocation = "GD3.0"
                intQueryResult = cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine GetData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
                LogError(Me.Name, "GetData", strLocation, ex.Message)
            End Try
        End Using
        'q = "exec spLoadItemTemp '" & lblDate.Text & "'"

        GetData2()

    End Sub

    Private Sub GetData2()

        Try
            's = "Select * from ItemTemp Order by "
            Me.Cursor = Cursors.WaitCursor

            If optSort0.Checked Then
                's = s & "item_num"
                strLocation = "GD2-1.0"
                ItemTempBindingSource.Sort = "item_num ASC"
            End If
            If optSort1.Checked Then
                's = s & "descr"
                strLocation = "GD2-2.0"
                ItemTempBindingSource.Sort = "descr ASC"
            End If
            If optSort2.Checked Then
                's = s & "vendor, vend_item"
                ItemTempBindingSource.Sort = "vendor ASC, vend_item ASC"
            End If

            'RS2 = data2.Recordset
            Me.Cursor = Cursors.Default

            ItemTempTableAdapter.Connection.ConnectionString = CS
            ItemTempTableAdapter.Fill(Me.DsItemTemp.ItemTemp)

            SetModeReg()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine GetData2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData2", vbOK)
            LogError(Me.Name, "GetData2", strLocation, ex.Message)
        End Try

    End Sub

    Public Sub SetModeChange()

        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True

    End Sub

    Public Sub SetModeReg()

        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True

    End Sub

    Public Sub ClearItemTemp()

        Dim intQueryResult As Integer

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                Me.Cursor = Cursors.WaitCursor
                strLocation = "CIT1.0"
                connection.Open()

                strLocation = "CIT2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spClearItemTemp"
                cmd.Parameters.Add("Dat", SqlDbType.Date).Value = CDate(lblDate.Text)

                strLocation = "CIT3.0"
                intQueryResult = cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine ClearItemTemp (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "ClearItemTemp", vbOK)
                LogError(Me.Name, "ClearItemTemp", strLocation, ex.Message)
            End Try
        End Using
        'q = "exec spClearItemTemp '" & lblDate.Text & "'"

    End Sub

    Sub closedata()

        'On Error Resume Next
        'RS2.Close()

    End Sub

    Sub ForceUpdates()

        ''Make sure grid data is updated by closing recordsets
        'On Error Resume Next
        'If bEditInProgress Then RS2.Update()

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        bEditInProgress = False

        GetData()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "CU1.0"
            grdItemTemp.UpdateData()

            strLocation = "CU2.0"
            ItemTempTableAdapter.Update(DsItemTemp.ItemTemp)
            'q = "exec spPostItemTemp '" & lblDate & "'"

            bEditInProgress = False

            SetModeReg()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine cmdUpdate_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdUpdate_Click", vbOK)
            LogError(Me.Name, "cmdUpdate_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdItemTemp_TextChanged(sender As Object, e As EventArgs) Handles grdItemTemp.TextChanged

        bEditInProgress = True

        SetModeChange()

    End Sub

    Private Sub grdItemTemp_AfterColUpdate(sender As Object, e As ColEventArgs) Handles grdItemTemp.AfterColUpdate

        Try
            Me.Cursor = Cursors.WaitCursor
            strLocation = "IPDGAU1.0"
            grdItemTemp.Columns("Phys_Count").Value = 0

            strLocation = "IPDGAU2.0"
            If grdItemTemp.Columns("Count1").Text > "" Then
                grdItemTemp.Columns("Phys_Count").Value = grdItemTemp.Columns("Phys_Count").Value + grdItemTemp.Columns("Count1").Value
            End If

            strLocation = "IPDGAU3.0"
            If grdItemTemp.Columns("Count2").Text > "" Then
                grdItemTemp.Columns("Phys_Count").Value = grdItemTemp.Columns("Phys_Count").Value + grdItemTemp.Columns("Count2").Value
            End If

            strLocation = "IPDGAU4.0"
            If grdItemTemp.Columns("Count3").Text > "" Then
                grdItemTemp.Columns("Phys_Count").Value = grdItemTemp.Columns("Phys_Count").Value + grdItemTemp.Columns("Count3").Value
            End If

            strLocation = "IPDGAU5.0"
            If grdItemTemp.Columns("Count4").Text > "" Then
                grdItemTemp.Columns("Phys_Count").Value = grdItemTemp.Columns("Phys_Count").Value + grdItemTemp.Columns("Count4").Value
            End If

            bEditInProgress = True
            SetModeChange()

            strLocation = "IPDGAU6.0"
            grdItemTemp.UpdateData()

            strLocation = "IPDGAU7.0"
            ItemTempTableAdapter.Update(DsItemTemp.ItemTemp)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdItemTemp_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdItemTemp_AfterColUpdate", vbOK)
            LogError(Me.Name, "grdItemTemp_AfterColUpdate", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default


    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Private Sub optSort0_CheckedChanged(sender As Object, e As EventArgs) Handles optSort0.CheckedChanged, optSort2.CheckedChanged, optSort1.CheckedChanged

        GetData2()

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Dim LD As Date
        LD = lblDate.Text

        ItemTempBindingSource.MoveFirst()
        'data2.Recordset.MoveFirst

        frmViewReport.lblReportName.Text = "ItemTemp.rpt"
        frmViewReport.Show()
        'With RPT
        '    .Destination = crptToWindow
        '    .ReportFileName = RptPath & "\ItemTemp.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{ItemTemp.Date} = Date(" & Format(LD, "yyyy,mm,dd") & ")"
        '    .Action = 1
        '    .PageZoom(100)
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

    End Sub
End Class