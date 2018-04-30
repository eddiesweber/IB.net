Imports System.ComponentModel

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sectionname As String

        If PrevInstance() Then Exit Sub

        CommFlag = False
        DataPath = Application.StartupPath()
        RptPath = Application.StartupPath() '& "\reports"

        'Open configuration db
        On Error GoTo nocdb

        ConfigCS = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=IB2016\SQLEXPRESS"
        configdb = New ADODB.Connection
        configdb.CommandTimeout = 60
        configdb.ConnectionString = ConfigCS

        configdb.Open()

        GoTo CDBOpen

CDBProblem:
        frmMain2.ShowDialog() ' Gives user a chance to change config location
        configdb.ConnectionString = ConfigCS
        configdb.Open()

CDBOpen:
        'Get INI items
        sectionname = "Data"
        Company = GetSetting(APPNAME, sectionname, "Company", "None")
        CurCust = GetSetting(APPNAME, sectionname, "CurCust", 0)
        CurItem = GetSetting(APPNAME, sectionname, "CurItem", 0)
        CurType = GetSetting(APPNAME, sectionname, "CurType", "")

        'Screen Position
        'GetWindowPos Me, 200, 200
        Me.Show()

        'RPT = Report1
        'RPT.PrinterSelect

        OpenData()

        Exit Sub

nocdb:
        Resume CDBProblem

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim sectionname As String

        'Save file info to registry
        sectionname = "Data"
        SaveSetting(APPNAME, sectionname, "CurCust", CurCust)
        SaveSetting(APPNAME, sectionname, "CurItem", CurItem)
        SaveSetting(APPNAME, sectionname, "CurType", CurType)

        'Save Screen Position
        'SaveWindowPos Me

        'unload all forms
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())

        ' Exit application
        Application.Exit()

    End Sub

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
