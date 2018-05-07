Public Class frmCompany
    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.IBconfigTableAdapter.Fill(Me.MasterDataSet.IBconfig)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Application.Exit()

    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Company = lstCompany.Text

        Me.Close()

    End Sub

End Class