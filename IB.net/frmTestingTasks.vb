Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class frmTestingTasks

    Dim blnNew As Boolean
    Dim blnEdit As Boolean
    Dim blnNoClick As Boolean
    Dim blnFormLoadStarted As Boolean = False

    Private Sub frmTestingTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intRow As Int16
        Dim CurTask As Integer

        blnNoClick = True
        blnFormLoadStarted = True

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTT_FTTL1.0"
            'GetWindowPos(Me, 200, 200)

            strLocation = "FTT_FTTL2.0"
            If Dir("frmTestingTasksgrdTestingTasks.xml") <> "" Then
                'grdTestingTasks.LoadLayout("frmTestingTasksgrdTestingTasks.xml")
            End If

            strLocation = "FTT_FTTL3.0"
            Me.TestersTableAdapter.Connection.ConnectionString = connGlobal
            Me.TestersTableAdapter.Fill(DsTesters.Testers)
            cmbTester.MaxDropDownItems = TestersBindingSource.Count

            strLocation = "FTT_FTTL4.0"
            Me.TestingStatusTableAdapter.Connection.ConnectionString = connGlobal
            Me.TestingStatusTableAdapter.Fill(DsTestingStatus.TestingStatus)
            cmbTester.MaxDropDownItems = TestingStatusBindingSource.Count

            strLocation = "FTT_FTTL5.0"
            If IsNumeric(lblCurTaskNumber.Text) Then
                CurTask = CLng(lblCurTaskNumber.Text)

                If CurTask > 0 Then
                    blnNoClick = True
                    Me.TestingTasksTableAdapter.Connection.ConnectionString = connGlobal
                    Me.TestingTasksTableAdapter.Fill(DsTestingTasks.TestingTasks, CurTask)
                    blnNoClick = False
                End If
            End If

            strLocation = "FTT_FTTL6.0"
            intRow = cmbTester.FindString(grdTestingTasks.Columns("Tester").Value.ToString.Trim)
            If intRow >= 0 Then
                cmbTester.SelectedIndex = intRow
            End If

            strLocation = "FTT_FTTL7.0"
            intRow = cmbStatus.FindString(grdTestingTasks.Columns("Status").Value.ToString.Trim)
            If intRow >= 0 Then
                cmbStatus.SelectedIndex = intRow
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmTestingTasks_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmTestingTasks_Load", vbOK)
            LogError(Me.Name, "frmTestingTasks_Load", strLocation, ex.Message)
        Finally
            blnNoClick = False
            SetModeReg()
        End Try

    End Sub

    Private Sub frmTestingTasks_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        If blnNew = True Or blnEdit = True Then
            Dim intYesNo As Int16

            intYesNo = MsgBox("Do you want to save your changes before exiting?", vbYesNo, "Save Record")
            If intYesNo = vbYes Then
                UpdateAllItemsOnFormAfterSave()
            End If
        End If

        SaveWindowPos(Me)

        grdTestingTasks.SaveLayout("frmTestingTasksgrdTestingTasks.xml")

    End Sub

    Private Sub UpdateAllItemsOnFormAfterSave()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTT_UAIOFAS1.0"
            grdTestingTasks.UpdateData()

            strLocation = "FTT_UAIOFAS2.0"
            Me.TestingTasksBindingSource.EndEdit()
            Me.TestingTasksTableAdapter.Update(DsTestingTasks.TestingTasks)

            strLocation = "FTT_UAIOFAS3.0"
            SetModeReg()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine UpdateAllItemsOnFormAfterSave (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateAllItemsOnFormAfterSave", vbOK)
            LogError(Me.Name, "UpdateAllItemsOnFormAfterSave", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lblCurTaskNumber_TextChanged(sender As Object, e As EventArgs)

        Dim CurTask As Integer

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTT_LCTTC1.0"
            If IsNumeric(lblCurTaskNumber.Text) Then
                CurTask = CLng(lblCurTaskNumber.Text)

                If CurTask > 0 Then
                    strLocation = "FTT_LCTTC2.0"
                    Me.TestingTasksTableAdapter.Connection.ConnectionString = connGlobal
                    Me.TestingTasksTableAdapter.Fill(DsTestingTasks.TestingTasks, CurTask)
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine lblCurTaskNumber_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lblCurTaskNumber_TextChanged", vbOK)
            LogError(Me.Name, "lblCurTaskNumber_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        AddNewRecord()

    End Sub

    Private Sub grdTestingTasks_OnAddNew(sender As Object, e As EventArgs) Handles grdTestingTasks.OnAddNew

        AddNewRecord()

    End Sub

    Public Sub AddNewRecord()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTT_ANR1.0"
            SetModeNew()

            strLocation = "FTT_ANR2.0"
            ' Set default values and clear nulls for the rest of the fields
            grdTestingTasks.Columns("TestingHeaderID").Value = CLng(lblCurTaskNumber.Text)
            grdTestingTasks.Columns("Created").Value = Now()
            grdTestingTasks.Columns("LastModified").Value = Now()
            grdTestingTasks.Columns("EditSequence").Value = 1
            grdTestingTasks.Columns("ScreenName").Value = frmTestingMain.txtScreenName.Text.Trim
            grdTestingTasks.Columns("Tester").Value = ""
            grdTestingTasks.Columns("Task").Value = 1
            grdTestingTasks.Columns("Status").Value = "Not Started"
            grdTestingTasks.Columns("Comments").Value = ""

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine AddNewRecord (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "AddNewRecord", vbOK)
            LogError(Me.Name, "AddNewRecord", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingTasks_AfterInsert(sender As Object, e As EventArgs) Handles grdTestingTasks.AfterInsert

        SetModeReg()

    End Sub

    Private Sub grdTestingTasks_BeforeRowColChange(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingTasks.BeforeRowColChange

        If grdTestingTasks.Row >= 0 And grdTestingTasks.DestinationRow >= 0 Then
            If grdTestingTasks.Row <> grdTestingTasks.DestinationRow Then
                If blnEdit = True Or blnNew = True Then
                    Try
                        Me.Cursor = Cursors.WaitCursor

                        ' Validate fields
                        strLocation = "FTT_GTTBRCC1.0"
                        If grdTestingTasks.Columns("ScreenName").Value.ToString.Trim = "" Then
                            MessageBox.Show("ScreenName - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTT_GTTBRCC2.0"
                        If grdTestingTasks.Columns("Tester").Value.ToString.Trim = "" Then
                            MessageBox.Show("Tester - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTT_GTTBRCC3.0"
                        If grdTestingTasks.Columns("DisplayOrder").Value < 1 Then
                            MessageBox.Show("DisplayOrder - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTT_GTTBRCC4.0"
                        If grdTestingTasks.Columns("Status").Value.ToString.Trim = "" Then
                            MessageBox.Show("Status - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTT_GTTBRCC6.0"
                        If grdTestingTasks.Columns("EditSequence").Value < 0 Then
                            grdTestingTasks.Columns("EditSequence").Value = 1
                        Else
                            grdTestingTasks.Columns("EditSequence").Value = grdTestingTasks.Columns("EditSequence").Value + 1
                        End If

                        strLocation = "FTT_GTHBRCC7.0"
                        grdTestingTasks.Columns("LastModified").Value = Now()

                        UpdateAllItemsOnFormAfterSave()

                        Me.Cursor = Cursors.Default
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Result = MessageBox.Show(Me, "Error in routine grdTestingTasks_BeforeRowColChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingTasks_BeforeRowColChange", vbOK)
                        LogError(Me.Name, "grdTestingTasks_BeforeRowColChange", strLocation, ex.Message)
                    End Try

                    ' Check to see if anyone else has changed the record since data was loaded
                    ' - Save original record
                End If

                blnNoClick = True
            End If
        End If

    End Sub

    Private Sub grdTestingTasks_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles grdTestingTasks.RowColChange

        Dim intRow As Int16

        Try
            Me.Cursor = Cursors.WaitCursor

            If e.LastRow >= 0 Then
                If grdTestingTasks.Row <> e.LastRow Then
                    strLocation = "FTT_GTTRCC1.0"
                    intRow = cmbTester.FindString(grdTestingTasks.Columns("Tester").Value.ToString.Trim)
                    If intRow >= 0 Then
                        cmbTester.SelectedIndex = intRow
                    End If

                    strLocation = "FTT_GTTRCC2.0"
                    intRow = cmbStatus.FindString(grdTestingTasks.Columns("Status").Value.ToString.Trim)
                    If intRow >= 0 Then
                        cmbStatus.SelectedIndex = intRow
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdTestingTasks_RowColChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingTasks_RowColChange", vbOK)
            LogError(Me.Name, "grdTestingTasks_RowColChange", strLocation, ex.Message)
        Finally
            blnNoClick = False
        End Try

    End Sub

    Private Sub txtScreenName_TextChanged(sender As Object, e As EventArgs) Handles txtScreenName.TextChanged, txtTask.TextChanged, txtComments.TextChanged

        If blnNoClick = False Then
            blnEdit = True
        End If

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbYes Then
            grdTestingTasks.Delete()
            UpdateAllItemsOnFormAfterSave()
        End If

    End Sub

    Private Sub grdTestingTasks_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingTasks.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub grdTestingTasks_AfterDelete(sender As Object, e As EventArgs) Handles grdTestingTasks.AfterDelete

        UpdateAllItemsOnFormAfterSave()

    End Sub

    Private Sub cmbStatus_TextChanged(sender As Object, e As EventArgs) Handles cmbStatus.TextChanged

        Try
            strLocation = "FTT_CSTC1.0"
            If blnNoClick = False Then
                blnEdit = True
                grdTestingTasks.Columns("Status").Value = cmbStatus.Text
            End If
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine cmbStatus_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmbStatus_TextChanged", vbOK)
            LogError(Me.Name, "cmbStatus_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmbTester_TextChanged(sender As Object, e As EventArgs) Handles cmbTester.TextChanged

        Try
            strLocation = "FTT_CTTC1.0"
            If blnNoClick = False Then
                blnEdit = True
                grdTestingTasks.Columns("Tester").Value = cmbTester.Text
            End If
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine cmbTester_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmbTester_TextChanged", vbOK)
            LogError(Me.Name, "cmbTester_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        TestingTasksBindingSource.CancelEdit()
        UpdateAllItemsOnFormAfterSave()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        UpdateAllItemsOnFormAfterSave()
        blnEdit = False

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        Me.Dispose()

    End Sub


    Public Sub SetModeNew()

        blnNew = True
        SetModeChange()

    End Sub

    Public Sub SetModeChange()

        blnEdit = True
        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        cmdUpdate.Enabled = True
        cmdExit.Enabled = False

    End Sub

    Public Sub SetModeReg()

        blnEdit = False
        blnNew = False
        cmdNew.Enabled = True
        cmdDelete.Enabled = True
        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True

    End Sub

    'Private Sub grdTestingTasks_BeforeInsert(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingTasks.BeforeInsert
    '    Try
    '        ' Don't insert unless all required fields are filled in
    '        Me.Cursor = Cursors.WaitCursor

    '        strLocation = "GTTBI1.0"
    '        If IsDBNull(grdTestingTasks.Columns("TestingHeaderID").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI2.0"
    '        If IsDBNull(grdTestingTasks.Columns("Created").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI3.0"
    '        If IsDBNull(grdTestingTasks.Columns("LastModified").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI4.0"
    '        If IsDBNull(grdTestingTasks.Columns("EditSequence").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI5.0"
    '        If IsDBNull(grdTestingTasks.Columns("ScreenName").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI6.0"
    '        If IsDBNull(grdTestingTasks.Columns("Tester").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI7.0"
    '        If IsDBNull(grdTestingTasks.Columns("Task").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTTBI8.0"
    '        If IsDBNull(grdTestingTasks.Columns("Status").Value) Then
    '            e.Cancel = True
    '        End If

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingTasks_BeforeInsert (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingTasks_BeforeInsert", vbOK)
    '        LogError(Me.Name, "grdTestingTasks_BeforeInsert", strLocation, ex.Message)
    '    End Try

    'End Sub

    'Private Sub grdTestingTasks_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles grdTestingTasks.BeforeColUpdate

    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        ' Validate fields
    '        Select Case e.Column.Name.Trim
    '            Case "ScreenName"
    '                strLocation = "GTTBCU1.0"
    '                If grdTestingTasks.Columns("ScreenName").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Tester"
    '                strLocation = "GTTBCU2.0"
    '                If grdTestingTasks.Columns("Tester").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Task"
    '                strLocation = "GTTBCU3.0"
    '                If grdTestingTasks.Columns("DisplayOrder").Value < 1 Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Status"
    '                strLocation = "GTTBCU4.0"
    '                If grdTestingTasks.Columns("Status").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '        End Select

    '        strLocation = "GTTBCU6.0"
    '        If grdTestingTasks.Columns("EditSequence").Value < 0 Then
    '            grdTestingTasks.Columns("EditSequence").Value = 1
    '        Else
    '            grdTestingTasks.Columns("EditSequence").Value = grdTestingTasks.Columns("EditSequence").Value + 1
    '        End If

    '        strLocation = "GTHBCU7.0"
    '        grdTestingTasks.Columns("LastModified").Value = Now()

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingTasks_BeforeColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingTasks_BeforeColUpdate", vbOK)
    '        LogError(Me.Name, "grdTestingTasks_BeforeColUpdate", strLocation, ex.Message)
    '    End Try

    '    ' Check to see if anyone else has changed the record since data was loaded
    '    ' - Save original record

    'End Sub

    'Private Sub grdTestingTasks_AfterColUpdate(sender As Object, e As ColEventArgs) Handles grdTestingTasks.AfterColUpdate

    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        strLocation = "GTTACU1.0"
    '        UpdateAllItemsOnFormAfterSave()

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingTasks_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingTasks_AfterColUpdate", vbOK)
    '        LogError(Me.Name, "grdTestingTasks_AfterColUpdate", strLocation, ex.Message)
    '    End Try
    'End Sub

End Class