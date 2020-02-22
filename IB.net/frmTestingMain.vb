Option Explicit On
Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Data.SqlClient


Public Class frmTestingMain

    Dim blnNew As Boolean
    Dim blnEdit As Boolean
    Dim blnNoClick As Boolean

    Private Sub frmTestingMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "FTML1.0"
            'GetWindowPos(Me, 200, 22)

            strLocation = "FTML2.0"
            If Dir("frmTestingMaingrdTestingHeader.xml") <> "" Then
                'grdTestingHeader.LoadLayout("frmTestingMaingrdTestingHeader.xml")
            End If

            strLocation = "FTML3.0"
            blnNoClick = True
            TestingHeaderTableAdapter.Connection.ConnectionString = connGlobal
            TestingHeaderTableAdapter.Fill(DsTestingHeader.TestingHeader)
            blnNoClick = False

            strLocation = "FTML4.0"
            TestersTableAdapter.Connection.ConnectionString = connGlobal
            TestersTableAdapter.Fill(Me.DsTesters.Testers)
            lstTesters.ColumnWidth = lstTesters.Width - 5

            strLocation = "FTML5.0"
            TestingStatusTableAdapter.Connection.ConnectionString = connGlobal
            TestingStatusTableAdapter.Fill(Me.DsTestingStatus.TestingStatus)
            lstStatus.ColumnWidth = lstStatus.Width - 5

            'strLocation = "FTML6.0"
            'grdTestingHeader.Columns("Tester").DropDown = tdrpTesters

            'strLocation = "FTML7.0"
            'grdTestingHeader.Columns("Status").DropDown = tdrpStatus

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            blnNoClick = False
            Result = MessageBox.Show(Me, "Error in routine frmTax_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmTax_Load", vbOK)
            LogError(Me.Name, "frmTax_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub frmTestingMain_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        If blnNew = True Or blnEdit = True Then
            Dim intYesNo As Int16

            intYesNo = MsgBox("Do you want to save your changes before exiting?", vbYesNo, "Save Record")
            If intYesNo = vbYes Then
                e.Cancel = True
            End If
        End If

        SaveWindowPos(Me)

        grdTestingHeader.SaveLayout("frmTestingMaingrdTestingHeader.xml")

    End Sub

    Private Sub grdTestingHeader_TextChanged(sender As Object, e As EventArgs) Handles grdTestingHeader.TextChanged

        blnEdit = True

    End Sub

    Private Sub grdTestingHeader_OnAddNew(sender As Object, e As EventArgs) Handles grdTestingHeader.OnAddNew

        Try
            strLocation = "GTOAN1.0"
            blnNew = True

            strLocation = "GTOAN2.0"
            ' Set default values and clear nulls for TestingHeader table
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

            cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value.ToString.Trim
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_OnAddNew (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_OnAddNew", vbOK)
            LogError(Me.Name, "grdTestingHeader_OnAddNew", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingHeader_BeforeInsert(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingHeader.BeforeInsert

        ' Validate fields
        If IsDBNull(grdTestingHeader.Columns("ScreenName").Value) Then
            e.Cancel = True
        End If
        If IsDBNull(grdTestingHeader.Columns("Tester").Value) Then
            e.Cancel = True
        End If
        If IsDBNull(grdTestingHeader.Columns("DisplayOrder").Value) Then
            e.Cancel = True
        End If
        If IsDBNull(grdTestingHeader.Columns("Menu").Value) Then
            e.Cancel = True
        End If
        If IsDBNull(grdTestingHeader.Columns("ReadyToTest").Value) Then
            e.Cancel = True
        End If
        If IsDBNull(grdTestingHeader.Columns("Status").Value) Then
            e.Cancel = True
        End If

    End Sub

    Private Sub grdTestingHeader_AfterInsert(sender As Object, e As EventArgs) Handles grdTestingHeader.AfterInsert

        blnNew = False
        blnEdit = False

    End Sub

    Private Sub grdTestingHeader_BeforeColUpdate(sender As Object, e As BeforeColUpdateEventArgs) Handles grdTestingHeader.BeforeColUpdate

        ' Validate fields
        If grdTestingHeader.Columns("ScreenName").Value.ToString.Trim = "" Then
            MessageBox.Show(e.Column.Name & " - must have a value")
            e.Cancel = True
        End If

        If grdTestingHeader.Columns("Tester").Value.ToString.Trim = "" Then
            MessageBox.Show(e.Column.Name & " - must have a value")
            e.Cancel = True
        End If

        If grdTestingHeader.Columns("EditSequence").Value < 1 Then
            grdTestingHeader.Columns("EditSequence").Value = 1
        End If

        If grdTestingHeader.Columns("DisplayOrder").Value < 1 Then
            MessageBox.Show(e.Column.Name & " - must have a value")
            e.Cancel = True
        End If

        If grdTestingHeader.Columns("Menu").Value.ToString.Trim = "" Then
            MessageBox.Show(e.Column.Name & " - must have a value")
            e.Cancel = True
        End If

        If grdTestingHeader.Columns("Status").Value.ToString.Trim = "" Then
            MessageBox.Show(e.Column.Name & " - must have a value")
            e.Cancel = True
        End If

        ' Check to see if anyone else has changed the record since data was loaded
        ' - Save original record

    End Sub

    Private Sub grdTestingHeader_AfterColUpdate(sender As Object, e As ColEventArgs) Handles grdTestingHeader.AfterColUpdate

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GTHACU1.0"
            grdTestingHeader.UpdateData()

            strLocation = "GTHACU2.0"
            TestingHeaderTableAdapter.Update(DsTestingHeader.TestingHeader)

            strLocation = "GTHACU3.0"
            blnNew = False
            blnEdit = False

            strLocation = "GTHACU4.0"
            cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value.ToString.Trim

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_AfterColUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_AfterColUpdate", vbOK)
            LogError(Me.Name, "grdTestingHeader_AfterColUpdate", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingHeader_BeforeDelete(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTestingHeader.BeforeDelete

        Dim intYesNo As Int16

        intYesNo = MsgBox("Are you sure you want to delete this record?", vbYesNo, "Delete Record Confirmation")
        If intYesNo = vbNo Then
            e.Cancel = True
        End If

    End Sub

    Private Sub grdTestingHeader_AfterDelete(sender As Object, e As EventArgs) Handles grdTestingHeader.AfterDelete

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GTHAD1.0"
            grdTestingHeader.UpdateData()

            strLocation = "GTHAD2.0"
            TestingHeaderTableAdapter.Update(DsTestingHeader.TestingHeader)

            strLocation = "GTHAD3.0"
            blnNew = False
            blnEdit = False

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine grdTestingHeader_AfterDelete (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "grdTestingHeader_AfterDelete", vbOK)
            LogError(Me.Name, "grdTestingHeader_AfterDelete", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdTestingHeader_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles grdTestingHeader.RowColChange

        Dim intCount As Int16

        If grdTestingHeader.Row <> e.LastRow Then
            cmdShowTasks.Text = "Show tasks for screen " & grdTestingHeader.Columns("ScreenName").Value

            intCount = lstStatus.Find(Trim(grdTestingHeader.Columns("Status").Value), C1.Win.C1List.MatchCompareEnum.Equal, True, 0, 0)
            For intCount = 1 To lstStatus.ListCount
                If intCount > 0 Then
                    lstStatus.SelectedIndex = intCount
                End If
            Next
        End If
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs)

        Me.Dispose()

    End Sub

    Private Sub cmdShowTasks_Click(sender As Object, e As EventArgs) Handles cmdShowTasks.Click

        frmTestingTasks.lblCurTaskNumber.Text = grdTestingHeader.Columns("ID").Value
        frmTestingTasks.Show()

    End Sub

    Private Sub TestingHeaderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TestingHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TestingHeaderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTestingHeader)

    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs)

        Test.Show()

    End Sub

    Private Sub cmdShowTasks_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdShowTasks.MouseDown

        If e.Button = MouseButtons.Right Then

            Dim intPosition As Int16
            Dim strFormName As String
            Dim intRow As Integer
            Dim intRowsAffected As Integer

            Result = MessageBox.Show(Me, "First delete all testing records, are you sure you want to continue?", "Delete testing", vbYesNo)
            If Result = vbNo Then
                Exit Sub
            End If

            Result = MessageBox.Show(Me, "Do you want to re-add the headers?", "Header Records", vbYesNo)
            If Result = vbYes Then
                Using connection As New SqlConnection(connGlobal)
                    Dim cmd As SqlCommand = New SqlCommand("DELETE FROM TestingHeader", connection)

                    Try
                        strLocation = "GF1"
                        connection.Open()
                        intRowsAffected = cmd.ExecuteNonQuery()
                        MessageBox.Show(Me, "Records Deleted: " & intRowsAffected)
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                        LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
                    End Try
                End Using

                For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\Users\eddie.IBEDDIE\source\repos\IB.net\IB.net")
                    If Strings.Right(foundFile, 3) = ".vb" Then
                        If InStr(foundFile, "Designer") = False Then
                            intPosition = InStrRev(foundFile, "\")
                            If Mid(foundFile, intPosition + 1, 2) <> "ds" Then
                                strFormName = Mid(foundFile, intPosition + 1, foundFile.Length - intPosition)

                                grdTestingHeader.MoveLast()
                                grdTestingHeader.Row = grdTestingHeader.Row + 1
                                grdTestingHeader.Select()

                                grdTestingHeader.Columns("ScreenName").Value = strFormName.Trim
                                grdTestingHeader.Columns("Tester").Value = "Eddie"
                                grdTestingHeader.Columns("Created").Value = Now()
                                grdTestingHeader.Columns("LastModified").Value = Now()
                                grdTestingHeader.Columns("EditSequence").Value = 1
                                grdTestingHeader.Columns("DisplayOrder").Value = 99999
                                grdTestingHeader.Columns("Menu").Value = ""
                                grdTestingHeader.Columns("SubMenu1").Value = ""
                                grdTestingHeader.Columns("SubMenu2").Value = ""
                                grdTestingHeader.Columns("ReadyToTest").Value = 0
                                grdTestingHeader.Columns("Status").Value = "Not Started"

                                grdTestingHeader.Update()
                                TestingHeaderTableAdapter.Update(DsTestingHeader.TestingHeader)
                            End If
                        End If
                    End If
                Next

                ' Refresh the grid
                TestingHeaderTableAdapter.Fill(DsTestingHeader.TestingHeader)
            End If

            Dim strSQL As String = ""

            Using conn As New SqlConnection(connGlobal)
                Using comm As New SqlCommand()
                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = strSQL
                    End With

                    Try
                        conn.Open()

                        For intRow = 0 To grdTestingHeader.RowCount - 1
                            grdTestingHeader.Row = intRow

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Load form position', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Save form position', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Font Sizes', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Tab Positions', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Hide text boxes', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Load Grid Positions', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            'strSQL = "INSERT INTO TestingTasks "
                            'strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            'strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Save Grid Positions', 'Not Started', '')"

                            'comm.CommandText = strSQL
                            'comm.ExecuteNonQuery()

                            strSQL = "INSERT INTO TestingTasks "
                            strSQL &= "(TestingHeaderID, Created, LastModified, EditSequence, ScreenName, Tester, Task, Status, Comments)  "
                            strSQL &= "VALUES (" & grdTestingHeader.Columns("ID").Value & ", '" & Now() & "', '" & Now() & "', 1, '" & Trim(grdTestingHeader.Columns("ScreenName").Value) & "', 'Eddie', 'Error checking', 'Not Started', '')"

                            comm.CommandText = strSQL
                            comm.ExecuteNonQuery()
                        Next
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using

            MessageBox.Show("Finished")

        End If

    End Sub

End Class