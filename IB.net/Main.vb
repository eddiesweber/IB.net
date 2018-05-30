Imports System.Data.SqlClient

Module Main

    Public configdb As SqlConnection
    Public DB As SqlConnection
    Public CS As String
    Public CryCS As String
    Public ConfigCS As String
    Public DBName As String
    Public ServerName As String

    ' *** Eddie - 04/22/2018: Can't set strings to a specific size
    'Public Company As String * 10
    'Public CompanyName As String * 32
    Public Company As String
    Public gCompanyName As String

    Public CurCust As Long
    Public CustFileChanged As Boolean
    Public CurDept As Integer
    Public CurItem As Long
    Public ItemFileChanged As Boolean

    ' *** Eddie - 04/22/2018: Can't set strings to a specific size
    'Public CurType As String * 1
    Public CurType As String

    Public CurDate As Date
    Public CurInvoice As Long
    'Public RPT As CrystalReport
    Public RptPath As String
    Public DateSpin As Integer
    Public CommFlag As Boolean
    Public DataPath As String
    Public PPort As String
    Public PPort2 As String
    Public CurVend As String
    Public CurPO As Integer

    Public Const APPNAME = "IB.net"
    Public Const COMMPW = "BUX"

    Public Sub PostInvChange(Dat As Date, Typ As String, Item As Long, Source As String, Dest As String, Qty As Single, flag As Boolean)

        ''Handles non-sale changes to inventory
        ''Used by Inventory Adjustments, Purchase Order
        ''Tables updated: ItemMaster(R/O) - if flag is true, InventoryChange
        'Dim s As String, ADOCmd As New ADODB.Command
        's = "spPostInvChange ('" & Format(Dat, "MM/DD/YYYY") & "','" _
        '& Typ & "'," & Item & ",'" & Source & "','" & Dest & "'," & Qty & "," & flag & ")"
        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
        '    .CommandText = s
        '    .Execute()
        'End With

    End Sub

    Public Sub GetWindowPos(ByVal fm As Form, ByVal DefL As Integer, ByVal DefT As Integer)
        Dim L As Integer, T As Integer, W As Integer, H As Integer
        Dim WS As Integer, sectionname As String

        sectionname = "Form " & fm.Name
        T = CInt(GetSetting(APPNAME, sectionname, "Top", DefT))
        L = CInt(GetSetting(APPNAME, sectionname, "Left", DefL))
        WS = CInt(GetSetting(APPNAME, sectionname, "Windowstate", 0))
        H = CInt(GetSetting(APPNAME, sectionname, "Height", 0))
        W = CInt(GetSetting(APPNAME, sectionname, "Width", 0))

        If H = 0 Or W = 0 Then
            fm.Left = L
            fm.Top = T
        Else
            fm.Left = L
            fm.Top = T
            fm.Width = W
            fm.Height = H
        End If

        fm.WindowState = WS

    End Sub

    Public Sub SaveWindowPos(ByVal fm As Form)

        Dim e As Integer, Sizable As Boolean, sectionname As String

        'Is form sizable?
        e = fm.FormBorderStyle
        Sizable = (e = 2) Or (e = 5)

        'Save Screen Position Info
        sectionname = "Form " & fm.Name
        e = fm.WindowState
        If e = 1 Then
            e = 0
        End If

        SaveSetting(APPNAME, sectionname, "WindowState", e)
        fm.WindowState = 0
        SaveSetting(APPNAME, sectionname, "Top", fm.Top)
        SaveSetting(APPNAME, sectionname, "Left", fm.Left)
        If Sizable Then
            SaveSetting(APPNAME, sectionname, "Height", fm.Height)
            SaveSetting(APPNAME, sectionname, "Width", fm.Width)
        End If

    End Sub

End Module
