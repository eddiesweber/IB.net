Imports System.Data.SqlClient
Imports CRDESIGNERLib

Module Main

    Public configDB As SqlConnection
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
    Public rptConnectionInfo = New CrystalDecisions.Shared.ConnectionInfo
    Public RPT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public pDialog As New PrintDialog()

    Public RptPath As String
    Public DateSpin As Integer
    Public CommFlag As Boolean
    Public DataPath As String
    Public PPort As String
    Public PPort2 As String
    Public CurVend As String
    Public CurPO As Integer

    Public Const APPNAME As String = "IB.net"
    Public Const COMMPW As String = "BUX"

    Public Sub OpenData()

        Dim strSQL As String

        ' Close old Database
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
        For count As Integer = My.Application.OpenForms.Count - 1 To 1 Step -1
            If Not (My.Application.OpenForms(count).Name = "frmCompany" Or My.Application.OpenForms(count).Name = "frmMain") Then
                My.Application.OpenForms(count).Close()
            End If
        Next

        ' Get DBName and Server Name from Master/IBConfig
        DBName = ""
        ServerName = ""
        Do While DBName = "" And ServerName = ""
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''CHANGE TO GO LIVE
            'strSQL = "Select * From IBConfig where Location_ID='" & Company & "'"
            strSQL = "Select * From TESTIBConfig where Location_ID='" & Company & "'"
            Using Command As New SqlCommand(strSQL, configDB)
                Try
                    Dim dataReader As SqlDataReader = Command.ExecuteReader()
                    dataReader.Read()

                    If dataReader.HasRows Then
                        DBName = dataReader.Item("DBName")
                        ServerName = dataReader.Item("ServerName")
                    Else
                        Company = "none"
                    End If

                    dataReader.Close()
                Catch ex As Exception
                    Company = "none"
                End Try
            End Using

            If Company = "none" Then
                frmCompany.Show()
            End If
        Loop

        ' ReBuld connection string and open db
        CS = "Integrated Security=True;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(ServerName)
        'CS = "Data Source=indoorbillboard.database.windows.net;Initial Catalog=" & Trim(DBName) & ";User ID=ibadmin;Password="
        DB = New SqlConnection(CS)
        DB.ConnectionString = CS
        DB.Open()

        frmMain.Text = ""

        Do While frmMain.Text = ""
            strSQL = "Select * From Company where Company_ID='" & Company & "'"
            Using Command As New SqlCommand(strSQL, DB)
                Try
                    Dim dataReader As SqlDataReader = Command.ExecuteReader()
                    dataReader.Read()

                    If dataReader.HasRows Then
                        CompanyName = dataReader.Item("Company_NM")
                        dataReader.Close()

                        frmMain.Text = "Indoor Billboard - " & CompanyName

                        'Rearrange CS the way Crystal likes
                        CryCS = "DSN=" & Trim(ServerName) & ";DSQ=" & Trim(DBName) & ";UID=<<Use Integrated Security>>"
                    Else
                        frmCompany.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error getting company name" & vbNewLine & ex.Message)

                    Application.Exit()
                End Try
            End Using
        Loop

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
        Sizable = (e = 4) Or (e = 6)

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

        Dim rstemp As New ADODB.Recordset
        Dim q As String

        q = "SELECT BILL_NAME FROM CustomerMaster WHERE CUST_NUM=" & CurCust
        GetCustName = "Not Found"

        Using Command As New SqlCommand(q, DB)
            Try
                Dim dataReader As SqlDataReader = Command.ExecuteReader()
                dataReader.Read()

                If dataReader.HasRows Then
                    GetCustName = dataReader.Item("BILL_NAME")
                End If

                dataReader.Close()
            Catch ex As Exception
                frmCompany.Show()
            End Try
        End Using

    End Function

    Public Function ChkInvoiceExists() As Boolean

        'Warn if invoice exists for current cust/dept
        Static LastCust As Long
        Dim LastDept As Long
        Dim q As String
        Dim rstemp As New ADODB.Recordset
        Dim Result As DialogResult

        q = "SELECT CUST_NUM, DEPT FROM InvoiceHeader"
        q = q & " WHERE CUST_NUM=" & CStr(CurCust)
        q = q & " AND DEPT=" & CStr(CurDept)

        ChkInvoiceExists = False

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(q, connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    dataReader.Read()

                    If CurCust <> LastCust Or CurDept <> LastDept Then
                        MsgBox("Changes made here do not affect existing invoices.", vbOKOnly + vbInformation, "Invoices Exist")
                    End If
                    ChkInvoiceExists = True
                End If

                dataReader.Close()
            Catch ex As Exception
                Result = MessageBox.Show("Error getting data from customer master" & vbNewLine & "Error : " & ex.Message, "Customer Master", MessageBoxButtons.OKCancel)
                If Result = vbCancel Then
                    Exit Function
                Else
                    Exit Try
                End If
            End Try
        End Using

        LastCust = CurCust
        LastDept = CurDept
    End Function

End Module
