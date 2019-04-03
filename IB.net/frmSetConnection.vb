Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmSetConnection

    Private Sub frmSetConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim intIndex As Integer

        'lstServerName.AddItem("SQLIB")
        lstServerName.AddItem("indoorbillboard.database.windows.net")
        'lstServerName.AddItem("IBSERVER2016\SQLEXPRESS")
        'lstServerName.AddItem("192.168.1.18")

        Me.Show()

        txtUserName.Enabled = True
        txtPassword.Enabled = True
        txtUserName.Text = Username.Trim
        txtPassword.Text = Password.Trim
        txtUserName.Enabled = False
        txtPassword.Enabled = False

        If Server.Trim <> "" Then
            intIndex = lstServerName.Find(Server.Trim, C1.Win.C1List.MatchCompareEnum.Equal, True, 0, 0)
            If intIndex > 0 Then
                lstServerName.SelectedIndex = intIndex
            End If
        End If

        If InStr(1, lstServerName.SelectedText, "windows.net") > 0 Then
            txtUserName.Enabled = True
            txtUserName.Text = Username
            txtPassword.Enabled = True
            txtPassword.Text = Password
        Else
            txtUserName.Text = ""
            txtUserName.Enabled = False
            txtPassword.Text = ""
            txtPassword.Enabled = False
        End If

        grpServer.Text = "Not Connected"
        grpDivision.Text = "Not Connected"

    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click

        Dim strSQL As String = ""

        cmdConnectDivision.Enabled = False

        grpServer.Text = "Not Connected"

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

            grpServer.Text = "Server - Connected"
            cmdConnectDivision.Enabled = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            LogError(Me.Name, "cmdConnect_Click", "1.0", ex.Message)
            MessageBox.Show("Can't connect to Master DB, please try again. (FSC-CC1.0)" & vbNewLine & vbNewLine & ex.Message, "Connect to Master")

            Exit Sub
        End Try

        lstDivision.ClearItems()
        strSQL = "Select * From IBConfig"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                If dataReader.HasRows Then
                    Do While dataReader.Read()
                        lstDivision.AddItem(dataReader.Item("Location_ID"))
                    Loop
                End If
                dataReader.Close()

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                LogError(Me.Name, "cmdConnect_Click", "2.0", ex.Message)
                MessageBox.Show("Error in form: frmSetConnection, error loading division names to listbox. (FSC-CC2.0)" & vbNewLine & ex.Message, "Load Division")

                Exit Sub
            End Try
        End Using

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdConnectDivision_Click(sender As Object, e As EventArgs) Handles cmdConnectDivision.Click

        Dim strSQL As String

        If lstDivision.SelectedText.Trim = "" Then
            MessageBox.Show("Please select a division", "Select Division")

            Exit Sub
        Else
            Company = lstDivision.SelectedText
        End If

        Me.Cursor = Cursors.WaitCursor

        ' Get DBName and Server Name from Master/IBConfig
        DBName = ""
        ServerName = ""
        strSQL = "Select * From IBConfig where Location_ID='" & Company & "'"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                If dataReader.HasRows Then
                    DBName = dataReader.Item("DBName")
                    Server = dataReader.Item("ServerName")
                End If

                dataReader.Close()
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                LogError(Me.Name, "cmdConnectDivision_Click", "1.0", ex.Message)
                MessageBox.Show("Error getting division name (FSC-CCD1.0)" & vbNewLine & ex.Message, "Division Name")

                Exit Sub
            End Try
        End Using

        ' Open connection to database
        If InStr(1, Server, "windows.net") > 0 Then
            Username = txtUserName.Text
            Password = txtPassword.Text
            CS = "Data Source=" & Trim(Server) & ";Initial Catalog=" & Trim(DBName) & ";User ID=" & Username & ";Password=" & Password
        Else
            CS = "Integrated Security=True;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(Server)
        End If

        Try
            DB = New SqlConnection(CS)
            DB.Open()
            grpDivision.Text = "Division - Connected"
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            LogError(Me.Name, "cmdConnectDivision_Click", "2.0", ex.Message)
            MessageBox.Show("Can't connect to Divisions DB, please try again. (FSC-CCD2.0)" & vbNewLine & vbNewLine & ex.Message, "Select Division")

            Exit Sub
        End Try

        ' Get company (division) name
        frmMain.Text = ""
        strSQL = "Select * From Company where Company_ID='" & Company & "'"
        Using Command As New SqlCommand(strSQL, DB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                If dataReader.HasRows Then
                    frmMain.Text = "Indoor Billboard - " & dataReader.Item("Company_NM")
                    dataReader.Close()

                    'Rearrange CS the way Crystal likes
                    CryCS = "DSN=" & Trim(Server) & ";DSQ=" & Trim(Company) & ";UID=<<Use Integrated Security>>"
                Else
                    MessageBox.Show("Company " & Company & " not found in company table", "Company Name")
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                LogError(Me.Name, "cmdConnectDivision", "3.0", ex.Message)
                MessageBox.Show("Error getting company name (FSC-CCD3.0)" & vbNewLine & ex.Message, "Company Name")

                Exit Sub
            End Try
        End Using

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub lstServerName_Click(sender As Object, e As EventArgs) Handles lstServerName.Click

        If InStr(1, lstServerName.SelectedText, "windows.net") > 0 Then
            txtUserName.Enabled = True
            txtUserName.Text = Username
            txtPassword.Enabled = True
            txtPassword.Text = Password
        Else
            txtUserName.Text = ""
            txtUserName.Enabled = False
            txtPassword.Text = ""
            txtPassword.Enabled = False
        End If

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Main.SaveSettings()

        Me.Close()

    End Sub

    Private Sub frmSetConnection_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ' Close master Database
        If Not IsNothing(DB) Then
            Try
                If DB.State = ConnectionState.Open Then
                    DB.Close()
                End If
            Finally
                DB = Nothing
            End Try
        End If

        ' Close divison Database
        If Not IsNothing(configDB) Then
            Try
                If configDB.State = ConnectionState.Open Then
                    configDB.Close()
                End If
            Finally
                configDB = Nothing
            End Try
        End If

    End Sub

End Class