Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Data.SqlClient

Public Class frmTestingMain

    Dim blnNew As Boolean
    Dim blnEdit As Boolean
    Dim blnNoClick As Boolean
    Dim blnFormLoadStarted As Boolean = False

    Private Sub frmTestingMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intRow As Int16

        blnNoClick = True
        blnFormLoadStarted = True

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTM_FTML1.0"
            GetWindowPos(Me, 200, 22)

            strLocation = "FTM_FTML2.0"
            If Dir("frmTestingMaingrdTestingHeader.xml") <> "" Then
                grdTestingHeader.LoadLayout("frmTestingMaingrdTestingHeader.xml")
            End If

            strLocation = "FTM_FTML3.0"
            Me.TestingHeaderTableAdapter.Connection.ConnectionString = connGlobal
            Me.TestingHeaderTableAdapter.Fill(DsTestingHeader.TestingHeader)

            strLocation = "FTM_FTML4.0"
            Me.TestersTableAdapter.Connection.ConnectionString = connGlobal
            Me.TestersTableAdapter.Fill(Me.DsTesters.Testers)
            lstTesters.ColumnWidth = lstTesters.Width - 5

            strLocation = "FTM_FTML5.0"
            intRow = lstTesters.FindString(grdTestingHeader.Columns("Tester").Value.ToString.Trim)
            If intRow >= 0 Then
                lstTesters.SelectedIndex = intRow
            End If

            strLocation = "FTM_FTML6.0"
            Me.TestingStatusTableAdapter.Connection.ConnectionString = connGlobal
            Me.TestingStatusTableAdapter.Fill(Me.DsTestingStatus.TestingStatus)
            lstStatus.ColumnWidth = lstStatus.Width - 5

            strLocation = "FTM_FTML7.0"
            intRow = lstStatus.FindString(grdTestingHeader.Columns("Status").Value.ToString.Trim)
            If intRow >= 0 Then
                lstStatus.SelectedIndex = intRow
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmTax_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmTax_Load", vbOK)
            LogError(Me.Name, "frmTax_Load", strLocation, ex.Message)
        Finally
            blnNoClick = False
            SetModeReg()
        End Try

    End Sub

    Private Sub frmTestingMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        If blnNew = True Or blnEdit = True Then
            Dim intYesNo As Int16

            intYesNo = MsgBox("Do you want to save your changes before exiting?", vbYesNo, "Save Record")
            If intYesNo = vbYes Then
                UpdateAllItemsOnFormAfterSave()
            End If
        End If

        SaveWindowPos(Me)

        grdTestingHeader.SaveLayout("frmTestingMaingrdTestingHeader.xml")

    End Sub

    Private Sub UpdateAllItemsOnFormAfterSave()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTM_UAIOFAS1.0"
            grdTestingHeader.UpdateData()

            strLocation = "FTM_UAIOFAS2.0"
            Me.TestingHeaderBindingSource.EndEdit()
            Me.TestingHeaderTableAdapter.Update(DsTestingHeader.TestingHeader)

            strLocation = "FTM_UAIOFAS3.0"
            SetModeReg()

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine UpdateAllItemsOnFormAfterSave (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateAllItemsOnFormAfterSave", vbOK)
            LogError(Me.Name, "UpdateAllItemsOnFormAfterSave", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        TestingHeaderBindingSource.AddNew()
        AddNewRecord()

    End Sub

    Private Sub grdTestingHeader_OnAddNew(sender As Object, e As EventArgs) Handles grdTestingHeader.OnAddNew

        AddNewRecord()

    End Sub

    Public Sub AddNewRecord()

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTM_ANR1.0"
            SetModeNew()

            strLocation = "FTM_ANR2.0"
            ' Set default values and clear nulls for the rest of the fields
            grdTestingHeader.Columns("ScreenName").Value = ""
            grdTestingHeader.Columns("Tester").Value = ""
            grdTestingHeader.Columns("Created").Value = Now()
            grdTestingHeader.Columns("LastModified").Value = Now()
            grdTestingHeader.Columns("EditSequence").Value = 1
            grdTestingHeader.Columns("DisplayOrder").Value = 1
            grdTestingHeader.Columns("Menu").Value = ""
            grdTestingHeader.Columns("SubMenu1").Value = ""
            grdTestingHeader.Columns("SubMenu2").Value = ""
            grdTestingHeader.Columns("ReadyToTest").Value = 0
            grdTestingHeader.Columns("Status").Value = "Not Started"

            strLocation = "FTM_ANR3.0"
            cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value.ToString.Trim

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine AddNewRecord (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "AddNewRecord", vbOK)
            LogError(Me.Name, "AddNewRecord", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingHeader_AfterInsert(sender As Object, e As EventArgs) Handles grdTestingHeader.AfterInsert

        SetModeReg()

    End Sub

    Private Sub grdTestingHeader_BeforeRowColChange(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingHeader.BeforeRowColChange

        If grdTestingHeader.Row >= 0 And grdTestingHeader.DestinationRow >= 0 Then
            If grdTestingHeader.Row <> grdTestingHeader.DestinationRow Then
                If blnEdit = True Or blnNew = True Then
                    Try
                        Me.Cursor = Cursors.WaitCursor

                        ' Validate fields
                        strLocation = "FTM_GTHBRCC1.0"
                        If grdTestingHeader.Columns("ScreenName").Value.ToString.Trim = "" Then
                            MessageBox.Show("ScreenName - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTM_GTHBRCC2.0"
                        If grdTestingHeader.Columns("Tester").Value.ToString.Trim = "" Then
                            MessageBox.Show("Tester - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTM_GTHBRCC3.0"
                        If grdTestingHeader.Columns("DisplayOrder").Value < 1 Then
                            MessageBox.Show("DisplayOrder - must have a value")
                            e.Cancel = True
                        End If

                        'strLocation = "FTM_GTHBCU4.0"
                        'If grdTestingHeader.Columns("Menu").Value.ToString.Trim = "" Then
                        '    MessageBox.Show("Menu - must have a value")
                        '    e.Cancel = True
                        'End If

                        strLocation = "FTM_GTHBRCC5.0"
                        If grdTestingHeader.Columns("Status").Value.ToString.Trim = "" Then
                            MessageBox.Show("Status - must have a value")
                            e.Cancel = True
                        End If

                        strLocation = "FTM_GTHBRCC6.0"
                        If grdTestingHeader.Columns("EditSequence").Value < 0 Then
                            grdTestingHeader.Columns("EditSequence").Value = 1
                        Else
                            grdTestingHeader.Columns("EditSequence").Value = grdTestingHeader.Columns("EditSequence").Value + 1
                        End If

                        strLocation = "FTM_GTHBRCC7.0"
                        grdTestingHeader.Columns("LastModified").Value = Now()

                        UpdateAllItemsOnFormAfterSave()

                        Me.Cursor = Cursors.Default
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_BeforeRowColChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_BeforeRowColChange", vbOK)
                        LogError(Me.Name, "grdTestingHeader_BeforeRowColChange", strLocation, ex.Message)
                    End Try
                End If

                blnNoClick = True
            End If
        End If

    End Sub

    Private Sub grdTestingHeader_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles grdTestingHeader.RowColChange

        Dim intRow As Int16

        Try
            Me.Cursor = Cursors.WaitCursor

            If e.LastRow >= 0 Then
                If grdTestingHeader.Row <> e.LastRow Then
                    strLocation = "FTM_GTHRCC1.0"
                    cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value

                    strLocation = "FTM_GTHRCC2.0"
                    intRow = lstTesters.FindString(grdTestingHeader.Columns("Tester").Value.ToString.Trim)
                    If intRow >= 0 Then
                        lstTesters.SelectedIndex = intRow
                    End If

                    strLocation = "FTM_GTHRCC3.0"
                    intRow = lstStatus.FindString(grdTestingHeader.Columns("Status").Value.ToString.Trim)
                    If intRow >= 0 Then
                        lstStatus.SelectedIndex = intRow
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_RowColChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_RowColChange", vbOK)
            LogError(Me.Name, "grdTestingHeader_RowColChange", strLocation, ex.Message)
        Finally
            blnNoClick = False
        End Try

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbYes Then
            grdTestingHeader.Delete()
            UpdateAllItemsOnFormAfterSave()
        End If

    End Sub

    Private Sub grdTestingHeader_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingHeader.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub grdTestingHeader_AfterDelete(sender As Object, e As EventArgs) Handles grdTestingHeader.AfterDelete

        UpdateAllItemsOnFormAfterSave()

    End Sub

    Private Sub lstTesters_RowChange(sender As Object, e As EventArgs) Handles lstTesters.RowChange

        Try
            strLocation = "FTM_LTRC1.0"
            If blnNoClick = False Then
                blnEdit = True
                SetModeChange()
                grdTestingHeader.Columns("Tester").Value = lstTesters.SelectedText
            End If
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstTesters_RowChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstTesters_RowChange", vbOK)
            LogError(Me.Name, "lstTesters_RowChange", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstStatus_RowChange(sender As Object, e As EventArgs) Handles lstStatus.RowChange

        Try
            strLocation = "FTM_LSRC1.0"
            If blnNoClick = False Then
                blnEdit = True
                SetModeChange()
                grdTestingHeader.Columns("Status").Value = lstStatus.SelectedText
            End If
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstStatus_RowChange (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstStatus_RowChange", vbOK)
            LogError(Me.Name, "lstStatus_RowChange", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingHeader_BeforeColEdit(sender As Object, e As BeforeColEditEventArgs) Handles grdTestingHeader.BeforeColEdit

        If blnNoClick = False Then
            SetModeChange()
        End If

    End Sub

    Private Sub txtScreenName_TextChanged(sender As Object, e As EventArgs) Handles txtScreenName.TextChanged, txtSubMenu2.TextChanged, txtSubMenu1.TextChanged, txtMenu.TextChanged, txtDisplayOrder.TextChanged

        If blnNoClick = False Then
            SetModeChange()
        End If

    End Sub

    Private Sub chkReadyToTest_ValueChanged(sender As Object, e As EventArgs) Handles chkReadyToTest.ValueChanged

        If blnNoClick = False Then
            SetModeChange()
        End If

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        TestingHeaderBindingSource.CancelEdit()
        SetModeReg()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        UpdateAllItemsOnFormAfterSave()
        SetModeReg()

    End Sub

    Private Sub cmdShowTasks_Click(sender As Object, e As EventArgs) Handles cmdShowTasks.Click

        frmTestingTasks.lblCurTaskNumber.Text = grdTestingHeader.Columns("ID").Value
        frmTestingTasks.Show()

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

    Private Sub cmdShowTasks_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdShowTasks.MouseDown

        If e.Button = MouseButtons.Right Then

            Dim intPosition As Int16
            Dim strFormName As String
            Dim intRow As Integer
            Dim intRowsAffected As Integer
            Dim strSQL As String = ""
            Dim cmd As SqlCommand = New SqlCommand

            Result = MessageBox.Show(Me, "First delete all testing records, are you sure you want to continue?", "Delete testing", vbYesNo)
            If Result = vbNo Then
                Exit Sub
            End If

            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "GF1"
                Using connection As New SqlConnection(connGlobal)
                    connection.Open()
                    cmd.Connection = connection

                    Result = MessageBox.Show(Me, "Do you want to re-add the headers?", "Header Records", vbYesNo)
                    If Result = vbYes Then
                        cmd.CommandText = "DELETE FROM TestingHeader"
                        intRowsAffected = cmd.ExecuteNonQuery()

                        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\Users\eddie.IBEDDIE\source\repos\IB.net\IB.net")
                            If Strings.Right(foundFile, 3) = ".vb" Then
                                'If foundFile.Trim = "C:\Users\eddie.IBEDDIE\source\repos\IB.net\IB.net\frmTax.vb" Then
                                If InStr(foundFile, "Designer") = False Then
                                    intPosition = InStrRev(foundFile, "\")
                                    If Mid(foundFile, intPosition + 1, 2) <> "ds" Then
                                        strFormName = Mid(foundFile, intPosition + 1, foundFile.Length - intPosition)

                                        strSQL = "INSERT INTO TestingHeader "
                                        strSQL &= "(Created, LastModified, EditSequence, ScreenName, Tester, Status, DisplayOrder, Menu, SubMenu1, Submenu2, ReadyToTest)  "
                                        strSQL &= "VALUES ('" & Now() & "', '" & Now() & "', 1, '" & strFormName.Trim & "', 'Eddie', 'Not Started', 99999, '', '', '', 0)"

                                        cmd.CommandText = strSQL
                                        cmd.ExecuteNonQuery()
                                    End If
                                End If
                            End If
                        Next

                        ' Refresh the grid
                        TestingHeaderTableAdapter.Fill(DsTestingHeader.TestingHeader)

                    End If

                    cmd.CommandText = "DELETE FROM TestingTasks"
                    intRowsAffected = cmd.ExecuteNonQuery()

                    For intRow = 0 To grdTestingHeader.RowCount - 1
                        grdTestingHeader.Row = intRow

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Option Explicit', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Load form position', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Save form position', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Font Sizes', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Tab Positions', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Hide hidden labels', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Load Grid Positions', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Save Grid Positions', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'TestBox max length', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Anchoring', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()

                        strSQL = "INSERT INTO TestingTasks "
                        strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                        strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Error checking', 'Not Started', '')"

                        cmd.CommandText = strSQL
                        cmd.ExecuteNonQuery()
                    Next
                End Using

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
            End Try

            MessageBox.Show("Finished")
        End If
    End Sub

    'Private Sub grdTestingHeader_BeforeInsert(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingHeader.BeforeInsert

    '    Try
    '        ' Don't insert unless all required fields are filled in
    '        Me.Cursor = Cursors.WaitCursor

    '        strLocation = "GTHBI1.0"
    '        If IsDBNull(grdTestingHeader.Columns("ScreenName").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTHBI2.0"
    '        If IsDBNull(grdTestingHeader.Columns("Tester").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTHBI3.0"
    '        If IsDBNull(grdTestingHeader.Columns("DisplayOrder").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTHBI4.0"
    '        If IsDBNull(grdTestingHeader.Columns("Menu").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTHBI5.0"
    '        If IsDBNull(grdTestingHeader.Columns("ReadyToTest").Value) Then
    '            e.Cancel = True
    '        End If

    '        strLocation = "GTHBI6.0"
    '        If IsDBNull(grdTestingHeader.Columns("Status").Value) Then
    '            e.Cancel = True
    '        End If

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_BeforeInsert (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_BeforeInsert", vbOK)
    '        LogError(Me.Name, "grdTestingHeader_BeforeInsert", strLocation, ex.Message)
    '    End Try

    'End Sub

    'Private Sub grdTestingHeader_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles grdTestingHeader.BeforeColUpdate

    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        ' Validate fields
    '        Select Case e.Column.Name.Trim
    '            Case "ScreenName"
    '                strLocation = "GTHBCU1.0"
    '                If grdTestingHeader.Columns("ScreenName").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Tester"
    '                strLocation = "GTHBCU2.0"
    '                If grdTestingHeader.Columns("Tester").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "DisplayOrder"
    '                strLocation = "GTHBCU3.0"
    '                If grdTestingHeader.Columns("DisplayOrder").Value < 1 Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Menu"
    '                strLocation = "GTHBCU4.0"
    '                If grdTestingHeader.Columns("Menu").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '            Case "Status"
    '                strLocation = "GTHBCU5.0"
    '                If grdTestingHeader.Columns("Status").Value.ToString.Trim = "" Then
    '                    MessageBox.Show(e.Column.Name & " - must have a value")
    '                    e.Cancel = True
    '                End If
    '        End Select

    '        strLocation = "GTHBCU6.0"
    '        If grdTestingHeader.Columns("EditSequence").Value < 0 Then
    '            grdTestingHeader.Columns("EditSequence").Value = 1
    '        Else
    '            grdTestingHeader.Columns("EditSequence").Value = grdTestingHeader.Columns("EditSequence").Value + 1
    '        End If

    '        strLocation = "GTHBCU7.0"
    '        grdTestingHeader.Columns("LastModified").Value = Now()

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_BeforeColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_BeforeColUpdate", vbOK)
    '        LogError(Me.Name, "grdTestingHeader_BeforeColUpdate", strLocation, ex.Message)
    '    End Try

    '    ' Check to see if anyone else has changed the record since data was loaded
    '    ' - Save original record

    'End Sub

    'Private Sub grdTestingHeader_AfterColUpdate(sender As Object, e As ColEventArgs) Handles grdTestingHeader.AfterColUpdate

    '    Try
    '        Me.Cursor = Cursors.WaitCursor

    '        strLocation = "GTHACU1.0"
    '        UpdateAllItemsOnFormAfterSave()

    '        strLocation = "GTHACU2.0"
    '        cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value.ToString.Trim

    '        Me.Cursor = Cursors.Default
    '    Catch ex As Exception
    '        Me.Cursor = Cursors.Default
    '        Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_AfterColUpdate", vbOK)
    '        LogError(Me.Name, "grdTestingHeader_AfterColUpdate", strLocation, ex.Message)
    '    End Try

    'End Sub

End Class