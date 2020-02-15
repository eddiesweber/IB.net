Public Class frmVersion
    Private Sub frmVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblVersion.Text = dVersion
        lblDate.Text = Format(dtVersionDate, "MMMM dd, yyyy")

    End Sub
End Class