Public Class frmTextboxTest
    Private Sub frmTextboxTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUserName.Enabled = True
        txtUserName.Update()
        txtUserName.Text = Username.Trim

        txtPassword.Enabled = True
        txtPassword.Update()
        txtPassword.Text = Password.Trim

    End Sub
End Class