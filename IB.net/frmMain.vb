Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand

        Dim sectionname As String
        'Dim Result As DialogResult

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

        ' Uses app.config - must import System.Configuration 
        ConfigCS = ConfigurationManager.ConnectionStrings("CS").ConnectionString
        'ConfigCS = "Data Source=SQLIB;Initial Catalog=master;Integrated Security=True"

        configDB = New SqlConnection(ConfigCS)
        configDB.ConnectionString = ConfigCS

        ' Open connection to master database
        Do While configdb.State = ConnectionState.Closed
            Try
                Me.Cursor = Cursors.WaitCursor
                configDB.Open()
            Catch ex As Exception
                frmMain2.ShowDialog() ' Gives user a chance to change config location
                configDB.ConnectionString = ConfigCS
            Finally
                Me.Cursor = Cursors.Default
            End Try
        Loop

        If Trim(Company) = "None" Then
            frmCompany.ShowDialog()
        End If

        DBName = ""
        ServerName = ""

        'Screen Position
        GetWindowPos(Me, 15, 15)
        Me.Show()

        'RPT = Report1
        'RPT.PrinterSelect

        OpenData()

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim SectionName As String

        'Save file info to registry
        SectionName = "Data"
        SaveSetting(APPNAME, SectionName, "Company", Company)
        SaveSetting(APPNAME, SectionName, "CurCust", CurCust)
        SaveSetting(APPNAME, SectionName, "CurItem", CurItem)
        SaveSetting(APPNAME, SectionName, "CurType", CurType)

    End Sub

    'Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    'Dim SectionName As String

    'Save file info to registry
    '   SectionName = "Data"
    '  SaveSetting(APPNAME, sectionname, "CurCust", CurCust)
    ' SaveSetting(APPNAME, sectionname, "CurItem", CurItem)
    'SaveSetting(APPNAME, sectionname, "CurType", CurType)

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

        frmCompany.ShowDialog()

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

    Private Sub TaxCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaxCodeToolStripMenuItem.Click

        frmTax.Show()

    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click

        frmCat.Show()

    End Sub

    Private Sub RouteMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RouteMasterToolStripMenuItem.Click

        frmRouteMast.Show()

    End Sub
End Class
