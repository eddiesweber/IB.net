﻿Option Explicit On

Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Module Main

    Public configDB As SqlConnection
    Public DB As SqlConnection
    Public CS As String
    Public CryCS As String
    Public ConfigCS As String
    Public DBName As String
    Public ServerName As String
    Public strPrinterName As String

    ' *** Eddie - 04/22/2018: Can't set strings to a specific size
    'Public Company As String * 10
    'Public CompanyName As String * 32
    Public Company As String
    Public Server As String
    Public Username As String
    Public Password As String
    Public CompanyName As String

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

    'Public RPT As CrystalReports
    'Public RPT As New ReportDocument
    Public RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Public CTableLogInfo As TableLogOnInfo
    Public ConnInfo As CrystalDecisions.Shared.ConnectionInfo
    Public rptConnectionInfo = New CrystalDecisions.Shared.ConnectionInfo

    Public pDialog As New PrintDialog()

    Public RptPath As String
    Public DateSpin As Integer
    Public CommFlag As Boolean
    Public DataPath As String
    Public PPort As String
    Public PPort2 As String
    Public CurVend As String
    Public CurPO As Integer

    Public strLocation As String
    Public Result As DialogResult

    Public Const APPNAME As String = "IB.net"
    Public Const COMMPW As String = "BUX"

    Sub CalcItemUse(First As Long, Last As Long, IUFlag As Boolean, IMFlag As Boolean)

        'Collect information for ItemUse screen/report
        Dim q As String
        'Dim AR(11 To 45) As Integer
        Dim AR(45) As Integer
        Dim PD As Integer
        Dim W As Integer
        Dim D As Integer
        Dim LastItem As Single
        Dim LastType As String

        'Dim cmdSQL As SqlCommand

        'Get data
        Try
            Using connection As New SqlConnection(CS)
                Dim cmdSQL = New SqlCommand()
                cmdSQL.Connection = connection
                cmdSQL.Connection.Open()

                If IUFlag Then
                    strLocation = "CIU1.0"
                    cmdSQL.CommandText = "DELETE ItemReportTemp"
                    cmdSQL.ExecuteNonQuery()
                End If
                ''''''''''''''''''''''''''''
                ' Moved to routine ItemDone
                'Call IRRS.Open("ItemReportTemp", DB, adOpenDynamic, adLockOptimistic)

                strLocation = "CIU2.0"
                q = "Select PEAK_DAYS From Company where COMPANY_ID='" & Company & "'"
                cmdSQL.CommandText = q
                Using sqlReader As SqlDataReader = cmdSQL.ExecuteReader()
                    If sqlReader.Read() Then
                        PD = sqlReader.Item("PEAK_DAYS")
                    Else
                        Stop
                    End If
                End Using

                If IMFlag Then
                    strLocation = "CIU3.0"
                    q = "UPDATE ItemMasterO SET PEAK = 0 WHERE ITEM_NUM BETWEEN " & First & " AND " & Last
                    cmdSQL.CommandText = q
                    cmdSQL.ExecuteNonQuery()

                    strLocation = "CIU4.0"
                    q = "UPDATE ItemMasterR SET PEAK = 0 WHERE ITEM_NUM BETWEEN " & First & " AND " & Last
                    cmdSQL.CommandText = q
                    cmdSQL.ExecuteNonQuery()
                    'q = "SELECT ITEM_NUM,DESCR,TOTAL_OWN,RENTED,LOANED,PEAK FROM ItemMasterO WHERE ITEM_NUM BETWEEN " & First & " AND " & Last
                    'Call IMORS.Open(q, DB, adOpenDynamic, adLockOptimistic)

                    'q = "SELECT ITEM_NUM,DESCR,TOTAL_OWN,RENTED,LOANED,PEAK FROM ItemMasterR WHERE ITEM_NUM BETWEEN " & First & " AND " & Last
                    'Call IMRRS.Open(q, DB, adOpenDynamic, adLockOptimistic)

                    'If IMFlag Then
                    '    While Not IMORS.EOF
                    '        IMORS!peak = 0
                    '        IMORS.Update()
                    '        IMORS.MoveNext()
                    '    Wend
                    '    While Not IMRRS.EOF
                    '        IMRRS!peak = 0
                    '        IMRRS.Update()
                    '        IMRRS.MoveNext()
                    '    Wend
                    'End If
                End If

                strLocation = "CIU5.0"
                cmdSQL.CommandType = CommandType.StoredProcedure
                cmdSQL.CommandText = "SpGetItemUse"
                cmdSQL.Parameters.Add("item1", SqlDbType.Int).Value = First
                cmdSQL.Parameters.Add("item2", SqlDbType.Int).Value = Last
                'q = "SpGetItemUse (" & First & "," & Last & ")"
                'Call IURS.Open(q, DB, adOpenStatic)

                strLocation = "CIU6.0"
                Using sqlReader As SqlDataReader = cmdSQL.ExecuteReader()
                    LastItem = -1
                    LastType = ""
                    Do While sqlReader.Read()
                        strLocation = "CIU7.0"
                        If sqlReader("ITEM_NUM") <> LastItem Then
                            If LastItem <> -1 Then
                                ItemDone(AR, PD, LastType, LastItem, IUFlag)
                            End If

                            strLocation = "CIU8.0"
                            For W = 1 To 4
                                For D = 1 To 5
                                    AR(W * 10 + D) = 0
                                Next D
                            Next W
                            LastItem = sqlReader("ITEM_NUM")
                            LastType = sqlReader("ITEM_TYPE")
                        End If

                        strLocation = "CIU9.0"
                        D = CInt(Right(sqlReader("Weekday"), 1))
                        q = Left(sqlReader("Weekday"), 1)
                        Select Case q
                            Case "A"
                                AR(10 + D) = AR(10 + D) + sqlReader("Qty")
                                AR(30 + D) = AR(30 + D) + sqlReader("Qty")
                            Case "B"
                                AR(20 + D) = AR(20 + D) + sqlReader("Qty")
                                AR(40 + D) = AR(40 + D) + sqlReader("Qty")
                            Case Else
                                W = CInt(q)
                                AR(10 * W + D) = AR(10 * W + D) + sqlReader("Qty")
                        End Select
                    Loop
                    'LastItem = -1
                    'While Not IURS.EOF
                    '    If IURS!ITEM_NUM <> LastItem Then
                    '        If LastItem <> -1 Then GoSub ItemDone
                    '        For W = 1 To 4
                    '            For D = 1 To 5
                    '                AR(W * 10 + D) = 0
                    '            Next D
                    '        Next W
                    '        LastItem = IURS!ITEM_NUM
                    '        LastType = IURS!ITEM_TYPE
                    '    End If
                    '    D = CInt(Right(IURS!Weekday, 1))
                    '    q = Left(IURS!Weekday, 1)
                    '    Select Case q
                    '        Case "A"
                    '            AR(10 + D) = AR(10 + D) + IURS!Qty
                    '            AR(30 + D) = AR(30 + D) + IURS!Qty
                    '        Case "B"
                    '            AR(20 + D) = AR(20 + D) + IURS!Qty
                    '            AR(40 + D) = AR(40 + D) + IURS!Qty
                    '        Case Else
                    '            W = CInt(q)
                    '            AR(10 * W + D) = AR(10 * W + D) + IURS!Qty
                    '    End Select
                    '    IURS.MoveNext()
                    'Wend
                End Using

                strLocation = "CIU10.0"
                If LastItem <> -1 Then
                    ItemDone(AR, PD, LastType, LastItem, IUFlag)
                End If
            End Using
        Catch ex As Exception
            Result = MessageBox.Show("Error in routine CalcItemUse (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CalcItemUse", MessageBoxButtons.OK)
            LogError("Main.vb", "CalcItemUse", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub ItemDone(AR() As Integer, PD As Integer, LastType As String, LastItem As Single, IUFlag As Boolean)

        Dim q As String
        Dim ct As Integer
        Dim X As Integer

        Dim peak As Integer
        Dim W As Integer
        Dim d As Integer
        Dim wd As Integer

        Dim intTOTAL_OWN As Integer

        strLocation = "ID1.0"
        peak = 0
        For W = 1 To 4
            For d = 1 To 5
                wd = 10 * W + d
                X = AR(wd)
                ct = 1
                While ct < PD
                    wd = wd + 1
                    If wd Mod 10 = 6 Then
                        wd = wd + 5
                        If Int(wd / 10) = 5 Then wd = 11
                    End If
                    X = X + AR(wd)
                    ct = ct + 1
                End While

                If X > peak Then
                    peak = X
                End If
            Next d
        Next W

        Try
            strLocation = "ID2.0"
            'Load ItemReportTemp
            If LastType = "O" Then
                q = "SELECT ITEM_NUM,DESCR,TOTAL_OWN,RENTED,LOANED,PEAK FROM ItemMasterO WHERE ITEM_NUM = " & LastItem
                'IMRS = IMORS
            Else
                q = "SELECT ITEM_NUM,DESCR,TOTAL_OWN,RENTED,LOANED,PEAK FROM ItemMasterR WHERE ITEM_NUM = " & LastItem
                'IMRS = IMRRS
            End If
            'IMRS.Find "ITEM_NUM=" & LastItem

            Using connection As New SqlConnection(CS)
                strLocation = "ID3.0"
                connection.Open()
                Dim command As New SqlCommand(q, connection)
                Dim dataReader As SqlDataReader = command.ExecuteReader()

                strLocation = "ID4.0"
                If dataReader.Read() Then
                    If IUFlag Then
                        'Call IRRS.Open("ItemReportTemp", DB, adOpenDynamic, adLockOptimistic)
                        'IRRS.AddNew()

                        If IsNumeric(dataReader.Item("TOTAL_OWN")) = False Then
                            intTOTAL_OWN = 0
                        Else
                            intTOTAL_OWN = dataReader.Item("TOTAL_OWN")
                        End If

                        strLocation = "ID5.0"
                        q = "INSERT INTO ItemReportTemp " &
                         "(ITEM_NUM, DESCR, [11], [12], [13], [14], [15], [21], [22], [23], [24], [25], [31], [32], [33], [34], [35], [41], [42], [43], [44], [45], Peak, TOTAL_OWN, RENTED, LOANED) " &
                          "VALUES (" &
                          dataReader.Item("ITEM_NUM") & ", '" & Replace(dataReader.Item("DESCR"), "'", "") & "', " &
                          AR(11) & ", " & AR(12) & ", " & AR(13) & ", " & AR(14) & ", " & AR(15) & ", " &
                          AR(21) & ", " & AR(22) & ", " & AR(23) & ", " & AR(24) & ", " & AR(25) & ", " &
                          AR(31) & ", " & AR(32) & ", " & AR(33) & ", " & AR(34) & ", " & AR(35) & ", " &
                          AR(41) & ", " & AR(42) & ", " & AR(43) & ", " & AR(44) & ", " & AR(45) & ", " &
                          peak & ", " & intTOTAL_OWN & ", " & dataReader.Item("RENTED") & ", " & dataReader.Item("LOANED") & ")"
                        'For W = 1 To 4
                        '    For d = 1 To 5
                        '        wd = 10 * W + d
                        '        q = CStr(wd)
                        '        IRRS.Fields(q) = AR(wd)
                        '    Next d
                        'Next W
                        'IRRS!peak = peak
                        'IRRS!ITEM_NUM = IMRS!ITEM_NUM
                        'IRRS!DESCR = IMRS!DESCR
                        'IRRS!TOTAL_OWN = IMRS!TOTAL_OWN
                        'IRRS!RENTED = IMRS!RENTED
                        'IRRS!LOANED = IMRS!LOANED
                        'IRRS.Update()
                        strLocation = "ID6.0"
                        If dataReader.IsClosed = False Then
                            dataReader.Close()
                        End If

                        strLocation = "ID7.0"
                        command.CommandText = q
                        command.ExecuteNonQuery()
                    End If

                    strLocation = "ID8.0"
                    If dataReader.IsClosed = False Then
                        dataReader.Close()
                    End If

                    'Update ItemMaster
                    If LastType = "O" Then
                        q = "UPDATE ItemMasterO SET PEAK = 0 WHERE ITEM_NUM  =" & LastItem
                    Else
                        q = "UPDATE ItemMasterR SET PEAK = 0 WHERE ITEM_NUM  =" & LastItem
                    End If
                    strLocation = "ID8.0"
                    command.CommandText = q
                    command.ExecuteNonQuery()
                    'If IMFlag Then
                    '    'IMRS.Edit
                    '    IMRS!peak = peak
                    '    IMRS.Update()
                    'End If
                End If
            End Using
        Catch ex As Exception
            Result = MessageBox.Show("Error in routine ItemDone (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "ItemDone", MessageBoxButtons.OK)
            LogError("Main.vb", "ItemDone", strLocation, ex.Message)
            Stop
        End Try

        'peak = 0
        'For W = 1 To 4
        '    For D = 1 To 5
        '        wd = 10 * W + D
        '        X = AR(wd)
        '        ct = 1
        '        While ct < PD
        '            wd = wd + 1
        '            If wd Mod 10 = 6 Then
        '                wd = wd + 5
        '                If Int(wd / 10) = 5 Then wd = 11
        '            End If
        '            X = X + AR(wd)
        '            ct = ct + 1
        'Wend
        'If X > peak Then peak = X
        '    Next D
        'Next W

        ''Load ItemReportTemp
        'If LastType = "O" Then
        '    IMRS = IMORS
        'Else
        '    IMRS = IMRRS
        'End If
        'IMRS.Find "ITEM_NUM=" & LastItem
        'If IMRS.EOF Then Return
        'If IUFlag Then
        '    IRRS.AddNew()

        '    For W = 1 To 4
        '        For D = 1 To 5
        '            wd = 10 * W + D
        '            q = CStr(wd)
        '            IRRS.Fields(q) = AR(wd)
        '        Next D
        '    Next W
        '    IRRS!peak = peak
        '    IRRS!ITEM_NUM = IMRS!ITEM_NUM
        '    IRRS!DESCR = IMRS!DESCR
        '    IRRS!TOTAL_OWN = IMRS!TOTAL_OWN
        '    IRRS!RENTED = IMRS!RENTED
        '    IRRS!LOANED = IMRS!LOANED
        '    IRRS.Update()
        'End If
        ''Update ItemMaster
        'If IMFlag Then
        '    'IMRS.Edit
        '    IMRS!peak = peak
        '    IMRS.Update()
        'End If
        'Return

    End Sub

    Public Function GetWeekDay(D As Date) As Integer

        Dim Base As Date
        Dim Day As Integer
        Dim WDay As Integer
        Dim Week As Integer

        'Validate for weekend and get weekday
        Base = CDate("1/12/97") 'Sunday before week 1
        Day = DateDiff(DateInterval.Day, Base, D) Mod 28
        WDay = Day Mod 7

        If WDay = 0 Or WDay = 6 Then
            GetWeekDay = 99
        Else
            Week = Int(Day / 7) + 1
            GetWeekDay = Week * 10 + WDay
        End If

    End Function

    Public Sub SelectPrinter(bStartUp As Boolean)

        ' If strPrinterName is available at startup, set the priner
        If bStartUp = True Then
            If strPrinterName <> "" Then
                RPT.PrintOptions.NoPrinter = False
                RPT.PrintOptions.PrinterName = strPrinterName

                Exit Sub
            End If
        End If

        ' No saved printer, prompt user
        If pDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strPrinterName = pDialog.PrinterSettings.PrinterName

            If bStartUp = False Then
                Result = MessageBox.Show("Do you want to save the printer '" & strPrinterName & "' as your default printer?", "Save Printer", MessageBoxButtons.YesNo)
                If Result = DialogResult.Yes Then
                    SaveSetting(APPNAME, "Printer", "DefaultPrinter", strPrinterName)
                End If
            End If

            RPT.PrintOptions.NoPrinter = False
            RPT.PrintOptions.PrinterName = strPrinterName
        End If

    End Sub

    Public Sub setCrystalPrinter()

        If strPrinterName <> "" Then
            RPT.PrintOptions.NoPrinter = False
            RPT.PrintOptions.PrinterName = strPrinterName
        End If

    End Sub

    Public Sub SetDbConnection()

        ' Set database information
        ConnInfo = New CrystalDecisions.Shared.ConnectionInfo
        ConnInfo.ServerName = Server.Trim
        ConnInfo.DatabaseName = DBName.Trim
        ConnInfo.UserID = Username.Trim
        ConnInfo.Password = Password.Trim

        For Each CTable As Table In RPT.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = RPT.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

    End Sub


    Public Sub SaveSettings()

        Dim strSectionName As String

        'Save file info to registry
        strSectionName = "SS1.0"
        strSectionName = "Data"

        Try
            strSectionName = "SS2.0"
            SaveSetting(APPNAME, strSectionName, "Company", Company)
            SaveSetting(APPNAME, strSectionName, "Server", Server)
            SaveSetting(APPNAME, strSectionName, "DBName", DBName)
            SaveSetting(APPNAME, strSectionName, "Username", Username)

            strSectionName = "SS3.0"
            SaveSetting(APPNAME, strSectionName, "CurCust", CurCust)
            SaveSetting(APPNAME, strSectionName, "CurItem", CurItem)
            SaveSetting(APPNAME, strSectionName, "CurType", CurType)
            SaveSetting(APPNAME, strSectionName, "CurVend", CurVend)

            strSectionName = "SS4.0"
            Dim wrapper As New Simple3Des("I1!n2@()")
            SaveSetting(APPNAME, strSectionName, "Password", wrapper.EncryptData(Password))
        Catch ex As Exception
            SaveSetting(APPNAME, strSectionName, "Password", "")
            Result = MessageBox.Show("Error in routine SaveSettings (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "SaveSettings", MessageBoxButtons.OK)
            LogError("Main.vb", "SaveSettings", strLocation, ex.Message)
        End Try

    End Sub

    Public Function CheckConnectionServer() As Boolean

        Try
            strLocation = "CCS1.0"
            configDB = New SqlConnection(ConfigCS)
            configDB.Open()

            CheckConnectionServer = True
        Catch ex As Exception
            CheckConnectionServer = False
            Result = MessageBox.Show("Error in routine CheckConnectionServer (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CheckConnectionServer", MessageBoxButtons.OK)
            LogError("Main.vb", "CheckConnectionServer", strLocation, ex.Message)
        End Try

    End Function

    Public Function CheckConnectionDivision() As Boolean

        Try
            DB = New SqlConnection(CS)
            DB.Open()

            CheckConnectionDivision = True
        Catch ex As Exception
            CheckConnectionDivision = False
            Result = MessageBox.Show("Error in routine CheckConnectionDivision (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "CheckConnectionDivision", MessageBoxButtons.OK)
            LogError("Main.vb", "CheckConnectionDivision", strLocation, ex.Message)
        End Try

    End Function

    Public Sub OpenData()

        Dim strSQL As String

        ' Close old Database
        strLocation = "OD1.0"
        Try
            If DB.State = ConnectionState.Open Then
                DB.Close()
            End If
        Catch
            ' DB is already closed
        Finally
            DB = Nothing
        End Try

        ' Close opened forms
        strLocation = "OD2.0"
        For count As Integer = My.Application.OpenForms.Count - 1 To 1 Step -1
            If Not (My.Application.OpenForms(count).Name = "frmCompany" Or My.Application.OpenForms(count).Name = "frmMain") Then
                My.Application.OpenForms(count).Close()
            End If
        Next

        strLocation = "OD3.0"
        If Server.Trim <> "" Then
            If InStr(1, Server, "windows.net") > 0 Then
                ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;User ID=" & Username & ";Password=" & Password
            Else
                ConfigCS = "Data Source=" & Server & ";Initial Catalog=master;Integrated Security=True"
            End If
        End If

        strLocation = "OD4.0"
        configDB = New SqlConnection(ConfigCS)
        configDB.ConnectionString = ConfigCS

        Try
            strLocation = "OD5.0"
            configDB.Open()
        Catch ex As Exception
            Result = MessageBox.Show("Error in routine OpenData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "OpenData", MessageBoxButtons.OK)
            LogError("Main.vb", "OpenData", strLocation, ex.Message)
        End Try

        If configDB.State = ConnectionState.Closed Then
            Exit Sub
        End If

        ' Get DBName and Server Name from Master/IBConfig
        strLocation = "OD6.0"
        DBName = ""
        ServerName = ""
        strSQL = "Select * From IBConfig where Location_ID='" & Company & "'"
        Using Command As New SqlCommand(strSQL, configDB)
            Try
                strLocation = "OD7.0"
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                strLocation = "OD8.0"
                If dataReader.HasRows Then
                    DBName = dataReader.Item("DBName")
                    ServerName = dataReader.Item("ServerName")
                End If

                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show("Error in routine OpenData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "OpenData", MessageBoxButtons.OK)
                LogError("Main.vb", "OpenData", strLocation, ex.Message)
                Exit Sub
            End Try
        End Using

        If DBName.Trim = "" Or ServerName.TrimEnd = "" Then
            strLocation = "OD9.0"
            frmSetConnection.ShowDialog()
        End If

        If DBName.Trim = "" Or ServerName.TrimEnd = "" Then
            Exit Sub
        End If

        ' ReBuld connection string and open db
        strLocation = "OD10.0"
        CS = "Integrated Security=True;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(ServerName)
        ConfigCS = "Data Source=" & Trim(ServerName) & ";Initial Catalog=" & Trim(DBName) & ";User ID=" & Username & ";Password=" & Password

        strLocation = "OD8.0"
        DB = New SqlConnection(CS)
        DB.ConnectionString = CS
        DB.Open()

        frmMain.Text = ""

        Do While frmMain.Text = ""
            strSQL = "Select * From Company where Company_ID='" & Company & "'"
            Using Command As New SqlCommand(strSQL, DB)
                Try
                    strLocation = "OD11.0"
                    Dim dataReader As SqlDataReader = Command.ExecuteReader()
                    dataReader.Read()

                    strLocation = "OD12.0"
                    If dataReader.HasRows Then
                        CompanyName = dataReader.Item("Company_NM")
                        dataReader.Close()

                        frmMain.Text = "Indoor Billboard - " & CompanyName

                        'Rearrange CS the way Crystal likes
                        CryCS = "DSN=" & Trim(ServerName) & ";DSQ=" & Trim(DBName) & ";UID=<<Use Integrated Security>>"
                    Else
                        frmCompany.ShowDialog()
                    End If
                Catch ex As Exception
                    Result = MessageBox.Show("Error in routine OpenData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "OpenData", MessageBoxButtons.OK)
                    LogError("Main.vb", "OpenData", strLocation, ex.Message)

                    Application.Exit()
                End Try
            End Using
        Loop

        ' Close master Database
        Try
            If DB.State = ConnectionState.Open Then
                DB.Close()
            End If
        Catch
            ' DB is already closed
        Finally
            DB = Nothing
        End Try

    End Sub

    Public Function RoundOff(A As Single) As Single

        RoundOff = Int(Math.Abs(A) * 100 + 0.5) / 100 * Math.Sign(A)

    End Function

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
        Dim WS As Integer, strSectionName As String

        strSectionName = "Form " & fm.Name
        T = CInt(GetSetting(APPNAME, strSectionName, "Top", DefT))
        L = CInt(GetSetting(APPNAME, strSectionName, "Left", DefL))
        WS = CInt(GetSetting(APPNAME, strSectionName, "Windowstate", 0))
        H = CInt(GetSetting(APPNAME, strSectionName, "Height", 0))
        W = CInt(GetSetting(APPNAME, strSectionName, "Width", 0))

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

        Dim e As Integer, Sizable As Boolean, strSectionName As String

        'Is form sizable?
        e = fm.FormBorderStyle
        Sizable = (e = 4) Or (e = 6)

        'Save Screen Position Info
        strSectionName = "Form " & fm.Name
        e = fm.WindowState
        If e = 1 Then
            e = 0
        End If

        SaveSetting(APPNAME, strSectionName, "WindowState", e)
        fm.WindowState = 0
        SaveSetting(APPNAME, strSectionName, "Top", fm.Top)
        SaveSetting(APPNAME, strSectionName, "Left", fm.Left)
        If Sizable Then
            SaveSetting(APPNAME, strSectionName, "Height", fm.Height)
            SaveSetting(APPNAME, strSectionName, "Width", fm.Width)
        End If

    End Sub

    Public Function CCEncrypt(strText As String) As String

        Dim i As Integer
        'Dim strChar As String * 1
        Dim intCharValue As Integer
        Dim intOver As Integer
        Dim strTemp As String

        strTemp = Space(Len(strText))
        For i = 1 To Len(Trim(strText))
            If IsNumeric(Mid(strText, i, 1)) Then
                intCharValue = Asc(Mid(strText, i, 1))
                intCharValue = intCharValue + 13
                Do While intCharValue > 57
                    intOver = intCharValue - 57
                    intCharValue = 48 + intOver - 1
                Loop
                Mid(strTemp, i, 1) = Chr(intCharValue)
            End If
        Next

        CCEncrypt = strTemp

    End Function

    Public Function CCDecrypt(strText As String) As String

        Dim i As Integer
        'Dim strChar As String * 1
        Dim intCharValue As Integer
        Dim intunder As Integer
        Dim strTemp As String

        strTemp = Space(Len(strText))
        For i = 1 To Len(Trim(strText))
            intCharValue = Asc(Mid(strText, i, 1))
            intCharValue = intCharValue - 13
            Do While intCharValue < 48
                intunder = 48 - intCharValue
                intCharValue = 57 - intunder + 1
            Loop
            Mid(strTemp, i, 1) = Chr(intCharValue)
        Next

        CCDecrypt = strTemp

    End Function

    Public Function GetCustName()

        Dim q As String

        strLocation = "GCN1.0"
        q = "SELECT BILL_NAME FROM CustomerMaster WHERE CUST_NUM=" & CurCust
        GetCustName = "Not Found"

        Using Command As New SqlCommand(q, DB)
            Try
                strLocation = "GCN2.0"
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                strLocation = "GCN3.0"
                If dataReader.HasRows Then
                    GetCustName = dataReader.Item("BILL_NAME")
                End If

                dataReader.Close()
            Catch ex As Exception
                GetCustName = ""
                Result = MessageBox.Show("Error in routine GetCustName (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetCustName", MessageBoxButtons.OK)
                LogError("Main.vb", "GetCustName", strLocation, ex.Message)
            End Try
        End Using

    End Function

    Public Function GetItemDesc(INum As Long) As String

        Dim q As String
        Dim ITyp As String
        Dim blnFound As Boolean = True

        strLocation = "GID1.0"
        GetItemDesc = ""

        ITyp = "R"
        q = "SELECT DESCR FROM ItemMasterR WHERE ITEM_NUM=" & CStr(INum)

        Using Command As New SqlCommand(q, DB)
            Try
                strLocation = "GID2.0"
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                strLocation = "GID3.0"
                If dataReader.HasRows Then
                    GetItemDesc = dataReader(0)
                Else
                    blnFound = False
                End If

                dataReader.Close()
            Catch ex As Exception
                GetItemDesc = ""
                Result = MessageBox.Show("Error in routine GetItemDesc (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetItemDesc", MessageBoxButtons.OK)
                LogError("Main.vb", "GetItemDesc", strLocation, ex.Message)
            End Try
        End Using

        If blnFound = False Then
            strLocation = "GID4.0"
            ITyp = "O"
            q = "SELECT DESCR FROM ItemMasterO WHERE ITEM_NUM=" & INum

            Using Command As New SqlCommand(q, DB)
                Try
                    strLocation = "GID5.0"
                    Dim dataReader As SqlDataReader = Command.ExecuteReader()
                    dataReader.Read()

                    strLocation = "GID6.0"
                    If dataReader.HasRows Then
                        GetItemDesc = dataReader(0) ' Descr
                    Else
                        Exit Function
                    End If

                    dataReader.Close()
                Catch ex As Exception
                    GetItemDesc = ""
                    Result = MessageBox.Show("Error in routine GetItemDesc (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetItemDesc", MessageBoxButtons.OK)
                    LogError("Main.vb", "GetCustName", strLocation, ex.Message)
                End Try
            End Using
        End If

        CurItem = INum
        CurType = ITyp

    End Function

    Public Function ChkInvoiceExists() As Boolean

        'Warn if invoice exists for current cust/dept
        Static LastCust As Long
        Dim LastDept As Long
        Dim q As String
        Dim rstemp As New ADODB.Recordset
        Dim Result As DialogResult

        strLocation = "CIE1.0"
        q = "SELECT CUST_NUM, DEPT FROM InvoiceHeader"
        q = q & " WHERE CUST_NUM=" & CStr(CurCust)
        q = q & " AND DEPT=" & CStr(CurDept)

        ChkInvoiceExists = False

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(q, connection)

            Try
                strLocation = "CIE2.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    strLocation = "CIE3.0"
                    dataReader.Read()

                    If CurCust <> LastCust Or CurDept <> LastDept Then
                        MsgBox("Changes made here do not affect existing invoices.", vbOKOnly + vbInformation, "Invoices Exist")
                    End If
                    ChkInvoiceExists = True
                End If

                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show("Error in routine ChkInvoiceExists (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "ChkInvoiceExists", MessageBoxButtons.OK)
                LogError("Main.vb", "ChkInvoiceExists", strLocation, ex.Message)
            End Try
        End Using

        LastCust = CurCust
        LastDept = CurDept

    End Function

    Public Sub SetLabelOnAllOpenForms(strVariable As String, strLabelName As String)

        Dim frm As Form

        Try
            strLocation = "SLOAOF1.0"
            For Each frm In My.Application.OpenForms
                For Each ctl As Control In frm.Controls
                    If TypeOf ctl Is Label Then
                        If ctl.Name = strLabelName Then
                            strLocation = "SLOAOF2.0"
                            ctl.Text = strVariable
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            Result = MessageBox.Show("Error in routine SetLabelOnAllOpenForms (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "SetLabelOnAllOpenForms", MessageBoxButtons.OK)
            LogError("Main.vb", "SetLabelOnAllOpenForms", strLocation, ex.Message)
        End Try

    End Sub

    Public Function GetInvoiceNum() As Long

        GetInvoiceNum = 0

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand

            Try
                strLocation = "GIN1.0"
                connection.Open()

                strLocation = "GIN2.0"
                cmd.Connection = connection
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "spGetInvoiceNum"

                strLocation = "GIN3.0"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                LogError("Main.vb", "GetInvoiceNum", strLocation, ex.Message)
            End Try
        End Using
        'q = "spGetInvoiceNum"
        'Dim ADOCmd As New ADODB.Command
        'With ADOCmd
        '    .ActiveConnection = DB
        '    .CommandType = adCmdStoredProc
        '    .CommandText = q
        '    .Execute()
        'End With

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("Select Lastinv_Number from Company", connection)

            Try
                strLocation = "GIN4.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    strLocation = "GIN5.0"
                    dataReader.Read()

                    GetInvoiceNum = dataReader(0)
                End If
                dataReader.Close()
            Catch ex As Exception
                LogError("Main.vb", "GetInvoiceNum", strLocation, ex.Message)
            End Try
        End Using
        'q = "Select Lastinv_Number from Company"
        'Call R.Open(q, DB, adOpenStatic)
        'GetInvoiceNum = R.Fields(0)
        'R.Close()
    End Function

    'Public Sub SetDbConnection(ByVal rptCrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)

    '    ' Set database information
    '    ConnInfo = New CrystalDecisions.Shared.ConnectionInfo
    '    ConnInfo.ServerName = Server.Trim
    '    ConnInfo.DatabaseName = DBName.Trim
    '    ConnInfo.UserID = Username.Trim
    '    ConnInfo.Password = Password.Trim

    '    For Each CTable As Table In rptCrxReport.Database.Tables
    '        CTable.LogOnInfo.ConnectionInfo = rptConnectionInfo
    '        CTableLogInfo = CTable.LogOnInfo
    '        CTableLogInfo.ReportName = rptCrxReport.Name
    '        CTableLogInfo.TableName = CTable.Name
    '        CTable.ApplyLogOnInfo(CTableLogInfo)
    '    Next

    'End Sub

End Module
