Imports System.Data.SqlClient
Public Class frmConnectToServer
    Private Sub frmConnectToServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intIndex As Integer

        lstServerName.AddItem("SQLIB")
        lstServerName.AddItem("indoorbillboard.database.windows.net")
        lstServerName.AddItem("IBSERVER2016\SQLEXPRESS")
        lstServerName.AddItem("192.168.1.18")
        lstServerName.Update()

        txtUserName.Enabled = True
        txtUserName.Update()
        txtUserName.Text = Username.Trim

        txtPassword.Enabled = True
        txtPassword.Update()
        txtPassword.Text = Password.Trim

        If CheckConnectionServer() = False Then
            lblSelectServer.Text = "Not Connected"
        Else
            lblSelectServer.Text = "Connected"

            intIndex = lstServerName.Find(Server.Trim, C1.Win.C1List.MatchCompareEnum.Equal, True, 0, 0)
            If intIndex > 0 Then
                lstServerName.SelectedIndex = intIndex
            End If
        End If

        If InStr(1, lstServerName.SelectedText, "windows.net") > 0 Then
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        Else
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        End If

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Dim strSQL As String = ""

        If txtOther.Text.Trim <> "" Then
            Server = txtOther.Text.Trim
        Else
            If lstServerName.SelectedText.Trim = "" Then
                MessageBox.Show("Please select a server name", "Server Name")

                Exit Sub
            Else
                Server = lstServerName.SelectedText
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        If InStr(1, Server, "windows.net") > 0 Then
            Username = txtUserName.Text
            Password = txtPassword.Text
            ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;User ID=" & Username & ";Password=" & Password
        Else
            ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;Integrated Security=True"
        End If

        Try
            configDB = New SqlConnection(ConfigCS)
            configDB.Open()

            lblSelectServer.Text = "Connected"
            Me.Cursor = Cursors.Default

            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine cmdConnect_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdConnect_Click", vbOK)
            LogError(Me.Name, "cmdConnect_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged

        If chkPassword.Checked = True Then
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        Else
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        End If

    End Sub

    Private Sub lstServerName_Click(sender As Object, e As EventArgs) Handles lstServerName.Click

        If InStr(1, lstServerName.SelectedText, "windows.net") > 0 Then
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        Else
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        End If

    End Sub
End Class