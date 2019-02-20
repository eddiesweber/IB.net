Public Class frmMain2

    Dim altServer As String
    Dim altDB As String

    Private Sub frmMain2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtServer.Text = "IBSERVER2016\SQLEXPRESS"
        'txtServer.Text = "indoorbillboard.database.windows.net"
        'txtServer.Text = "SQLIB"
        txtDB.Text = "master"

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        altServer = txtServer.Text
        altDB = txtDB.Text

        'ConfigCS = "Data Source=SQLIB;Initial Catalog=" & altDB & ";Integrated Security=True"
        'ConfigCS = "Data Source=indoorbillboard.database.windows.net;Initial Catalog=master;User ID=ibadmin;Password="
        ConfigCS = "Data Source=" & altServer & ";Initial Catalog=" & altDB & ";Integrated Security=True"

        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Application.Exit()

    End Sub

End Class