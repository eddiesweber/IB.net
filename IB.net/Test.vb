Public Class Test
    Private Sub C1ContextMenu1_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TestersTableAdapter.Connection.ConnectionString = connGlobal
        Me.TestersTableAdapter.Fill(Me.DsTesters.Testers)

    End Sub
End Class