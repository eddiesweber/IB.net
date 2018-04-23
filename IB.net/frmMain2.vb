Public Class frmMain2

    Dim altServer As String
    Dim altDB As String

    Private Sub frmMain2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtServer.Text = "IB2016\SQLEXPRESS"
        txtDB.Text = "master"

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        altServer = txtServer.Text
        altDB = txtDB.Text
        ConfigCS = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & altDB & ";Data Source=" & altServer

        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Application.Exit()

    End Sub

End Class