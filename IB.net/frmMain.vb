﻿Option Explicit On

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
        Dim pPrint As Boolean = pDialog.ShowDialog()
        'MessageBox.Show(pDialog.PrinterSettings.PrinterName)

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

        SaveWindowPos(Me)

        Application.Exit()

    End Sub

    Function PrevInstance() As Boolean

        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub cmdSelectDivision_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSelectDivision.Click

        frmCompany.ShowDialog()

        If DB Is Nothing Then
            Application.Exit()
        End If

    End Sub

    Private Sub cmdPrintSetup_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPrintSetup.Click

        Dim pPrint As Boolean = pDialog.ShowDialog()
        'MessageBox.Show(pDialog.PrinterSettings.PrinterName)

    End Sub

    Private Sub cmdFindCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdFindCustomer.Click

        frmFindCust.Show()

    End Sub

    Private Sub cmdViewCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdViewCustomer.Click

        frmViewCust.Show()

    End Sub

    Private Sub cmdTaxCode_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdTaxCode.Click

        frmTax.Show()

    End Sub

    Private Sub cmdCategories_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCategories.Click

        frmCat.Show()

    End Sub

    Private Sub cmdRouteMaster_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRouteMaster.Click

        frmRouteMast.Show()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdExit.Click

        Application.Exit()

    End Sub

End Class
