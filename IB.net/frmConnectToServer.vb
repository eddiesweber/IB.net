Option Explicit On

Imports System.Data.SqlClient

Public Class frmConnectToServer

    Private Sub frmConnectToServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intIndex As Integer

        Try
            strLocation = "FCTS1.0"
            lstServerName.ClearFields()
            lstServerName.AddItem("indoorbillboard.database.windows.net")
            lstServerName.AddItem("IBSERVER2016\SQLEXPRESS")
            'lstServerName.AddItem("SQLIB")
            'lstServerName.AddItem("192.168.1.18")
            lstServerName.Update()

            strLocation = "FCTS2.0"
            lstStatus.ClearFields()
            lstStatus.AddItem("Trying to connect to server")
            If CheckConnectionServer() = False Then
                lstStatus.AddItem("Unable to connect to - " & Server.Trim)
            Else
                lstStatus.AddItem("Connected to - " & Server)

                strLocation = "FCTS3.0"
                intIndex = lstServerName.Find(Server.Trim, C1.Win.C1List.MatchCompareEnum.Equal, True, 0, 0)
                If intIndex > 0 Then
                    lstServerName.SelectedIndex = intIndex
                End If
            End If

            strLocation = "FCTS4.0"
            If InStr(1, lstServerName.SelectedText, "windows.net") > 0 Then
                frmLogin.ShowDialog()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine frmConnectToServer_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmConnectToServer_Load", vbOK)
            LogError(Me.Name, "frmConnectToServer_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Try
            strLocation = "CCC1.0"
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
            lstStatus.ClearItems()
            lstStatus.AddItem("Trying to connect to server")

            strLocation = "CCC2.0"
            If InStr(1, Server, "windows.net") > 0 Then
                frmLogin.ShowDialog()
                ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;User ID=" & Username & ";Password=" & Password
            Else
                ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;Integrated Security=True"
            End If

            strLocation = "CCC3.0"
            Using configDB As New SqlConnection(ConfigCS)
                configDB.Open()
                lstStatus.AddItem("Connected to - " & Server.Trim)
            End Using

            lstStatus.AddItem("Loading company data")
            OpenData()

            lstStatus.AddItem("Finished connecting - Success")
            Me.Cursor = Cursors.Default
            Me.Dispose()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            lstStatus.AddItem("Error connecting - Not connected")
            Result = MessageBox.Show(Me, "Error in routine cmdConnect_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdConnect_Click", vbOK)
            LogError(Me.Name, "cmdConnect_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdAutoConnect_Click(sender As Object, e As EventArgs) Handles cmdAutoConnect.Click

        lstStatus.ClearItems()

        If optLosAngeles.Checked = False And optPortland.Checked = False And optSanFrancisco.Checked = False And optSeattle.Checked = False Then
            MessageBox.Show(Me, "Please select a location", "Select Location")
            Exit Sub
        End If

        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Try
            strLocation = "CCC1.0"
            SaveWindowPos(Me)

            Me.Dispose()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine frmLogin_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmLogin_Load", vbOK)
            LogError(Me.Name, "frmLogin_Load", strLocation, ex.Message)
        End Try

    End Sub

End Class