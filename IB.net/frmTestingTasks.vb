Public Class frmTestingTasks
    Private Sub TestingTasksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TestingTasksBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.TestingTasksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsTestingTasks)

    End Sub

    Private Sub frmTestingTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CurTask As Integer

        TestersTableAdapter.Connection.ConnectionString = connGlobal
        TestersTableAdapter.Fill(DsTesters.Testers)
        cmbTester.MaxDropDownItems = TestersBindingSource.Count

        TestingStatusTableAdapter.Connection.ConnectionString = connGlobal
        TestingStatusTableAdapter.Fill(DsTestingStatus.TestingStatus)
        cmbTester.MaxDropDownItems = TestingStatusBindingSource.Count

        If IsNumeric(lblCurTaskNumber.Text) Then
            CurTask = CLng(lblCurTaskNumber.Text)

            If CurTask > 0 Then
                TestingTasksTableAdapter.Fill(DsTestingTasks.TestingTasks, CurTask)
            End If
        End If

    End Sub

    Private Sub lblCurTaskNumber_TextChanged(sender As Object, e As EventArgs) Handles lblCurTaskNumber.TextChanged

        Dim CurTask As Integer

        If IsNumeric(lblCurTaskNumber.Text) Then
            CurTask = CLng(lblCurTaskNumber.Text)

            If CurTask > 0 Then
                TestingTasksTableAdapter.Connection.ConnectionString = connGlobal
                TestingTasksTableAdapter.Fill(DsTestingTasks.TestingTasks, CurTask)
            End If
        End If

    End Sub
End Class