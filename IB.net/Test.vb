Public Class Test
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TestingHeaderTableAdapter.Connection.ConnectionString = connGlobal
        Me.TestingHeaderTableAdapter.Fill(Me.DsTestingHeaderWithTesters.TestingHeader)

        'add a relation
        Dim parentCol, childCol As DataColumn
        Dim relCustType As DataRelation
        parentCol = DsTestingHeaderWithTesters.Tables("TestingHeader").Columns("Tester")
        childCol = DsTestingHeaderWithTesters.Tables("Testers").Columns("Tester")
        relCustType = New DataRelation("Tester", parentCol, childCol)
        DsTestingHeaderWithTesters.Relations.Add(relCustType)

        C1List1.DataBindings.Add("Name", DsTestingHeaderWithTesters.Tables("Testers"), "Tester")
        'C1Combo1.DataBindings.Add("Tester Name", DsTestingHeaderWithTesters.Tables("Testers"), "Tester")

    End Sub

End Class