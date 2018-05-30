Option Explicit On

Imports System.Data.SqlClient

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand

        Dim sectionname As String
        Dim Result As DialogResult
        Dim q As String

        If PrevInstance() Then
            Exit Sub
        End If

        CommFlag = False
        DataPath = Application.StartupPath()
        RptPath = Application.StartupPath() '& "\reports"

        sectionname = "Data"
        Company = GetSetting(APPNAME, sectionname, "Company", "None")
        CurCust = GetSetting(APPNAME, sectionname, "CurCust", 0)
        CurItem = GetSetting(APPNAME, sectionname, "CurItem", 0)
        CurType = GetSetting(APPNAME, sectionname, "CurType", "")

        ConfigCS = "Data Source=IB2016\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
        configdb = New SqlConnection(ConfigCS)
        configdb.ConnectionString = ConfigCS

        ' Open connection to master database
        Do While configdb.State = ConnectionState.Closed
            Try
                configdb.Open()
            Catch ex As Exception
                frmMain2.ShowDialog() ' Gives user a chance to change config location
                configdb.ConnectionString = ConfigCS
            End Try
        Loop

        If Trim(Company) = "None" Then
            frmCompany.ShowDialog()
        End If

        DBName = ""
        ServerName = ""

        ' Get DBName and Server Name from Master/IBConfig
        Do While DBName = "" And ServerName = ""
            q = "Select * From IBConfig where Location_ID='" & Company & "'"
            command = New SqlCommand(q, configdb)
            Try
                Dim dataReader As SqlDataReader = command.ExecuteReader()

                dataReader.Read()
                DBName = dataReader(2)
                ServerName = dataReader(1)

                dataReader.Close()

            Catch ex As Exception
                frmCompany.ShowDialog()
            End Try
        Loop

        CS = "Integrated Security=True;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(ServerName)
        DB = New SqlConnection(CS)
        DB.ConnectionString = CS
        q = "Select * From Company where Company_ID='" & Company & "'"

        ' Create the Command and Parameter objects.
        command = New SqlCommand(q, DB)

        Try
            DB.Open()

            Dim dataReader As SqlDataReader = command.ExecuteReader()

            dataReader.Read()

            gCompanyName = dataReader(0)

            dataReader.Close()
            Me.Text = "Indoor Billboard - " & Company
            'Rearrange CS the way Crystal likes
            CryCS = "DSN=" & Trim(ServerName) & ";DSQ=" & Trim(DBName) & ";UID=<<Use Integrated Security>>"

        Catch ex As Exception
            frmMain2.ShowDialog()
        End Try

        'Call temp.Open(q, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        'CompanyName = temp!COMPANY_NM
        'temp.Close()


        'Screen Position
        GetWindowPos(Me, 15, 15)
        Me.Show()

        'RPT = Report1
        'RPT.PrinterSelect


        'OpenData()

    End Sub

    'Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    '    Dim sectionname As String

    '    'Save file info to registry
    '    sectionname = "Data"
    '    SaveSetting(APPNAME, sectionname, "CurCust", CurCust)
    '    SaveSetting(APPNAME, sectionname, "CurItem", CurItem)
    '    SaveSetting(APPNAME, sectionname, "CurType", CurType)

    '    'Save Screen Position
    '    'SaveWindowPos Me

    '    'unload all forms
    '    My.Application.OpenForms.Cast(Of Form)() _
    '          .Except({Me}) _
    '          .ToList() _
    '          .ForEach(Sub(form) form.Close())

    '    ' Exit application
    '    Application.Exit()

    'End Sub

    Function PrevInstance() As Boolean

        If UBound(Diagnostics.Process.GetProcessesByName _
           (Diagnostics.Process.GetCurrentProcess.ProcessName)) _
           > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub SelectDivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectDivisionToolStripMenuItem.Click

        'frmCompany.ShowDialog()

        If DB Is Nothing Then
            Application.Exit()
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub FindCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindCustomerToolStripMenuItem.Click

        frmFindCust.Show()

    End Sub

    Private Sub ViewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCustomerToolStripMenuItem.Click

        frmViewCust.Show()

    End Sub

End Class
