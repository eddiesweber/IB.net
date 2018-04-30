Module Main

    Public configdb As ADODB.Connection
    Public DB As ADODB.Connection
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
    'Public RPT As CrystalReport
    Public RptPath As String
    Public DateSpin As Integer
    Public CommFlag As Boolean
    Public DataPath As String
    Public PPort As String
    Public PPort2 As String
    Public CurVend As String
    Public CurPO As Integer

    Public Const APPNAME = "IB20"
    Public Const COMMPW = "BUX"

    Public Sub OpenData()

        Dim q As String
        Dim temp As New ADODB.Recordset
        Dim i As Integer
        Dim j As Integer

        'Close old Database
        If DB.State = ConnectionState.Open Then
            DB.Close()
            DB = Nothing
        End If

        For Each currentForm As Form In Application.OpenForms
            If currentForm.Name = "frmCompany" Or currentForm.Name = "frmMain" Then
                currentForm.Close()
            End If
        Next

        'Look up data directory
        On Error GoTo BadCompany
        q = "Select * From IBConfig where Location_ID='" & Company & "'"
        Call temp.Open(q, configdb, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If temp.EOF Then GoTo BadCompany
        DBName = temp!DBName
        ServerName = temp!ServerName
        temp.Close()

        'On Error GoTo NoDB
        CS = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(ServerName)
        DB = New ADODB.Connection
        Call DB.Open(CS, , ,)
        DB.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        q = "Select * From Company where Company_ID='" & Company & "'"
        Call temp.Open(q, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        CompanyName = temp!COMPANY_NM
        temp.Close()
        frmMain.Text = "Indoor Billboard - " & Company
        'Rearrange CS the way Crystal likes
        CryCS = "DSN=" & Trim(ServerName) & ";DSQ=" & Trim(DBName) & ";UID=<<Use Integrated Security>>"

        Exit Sub

BadCompany:
        If Form.ActiveForm.Name = "frmCompany" Then
            frmCompany.Show()
        Else
            frmCompany.ShowDialog()
        End If

    End Sub

    Public Sub PostInvChange(Dat As Date, Typ As String, Item As Long, Source As String, Dest As String, Qty As Single, flag As Boolean)

        'Handles non-sale changes to inventory
        'Used by Inventory Adjustments, Purchase Order
        'Tables updated: ItemMaster(R/O) - if flag is true, InventoryChange
        Dim s As String, ADOCmd As New ADODB.Command
        s = "spPostInvChange ('" & Format(Dat, "MM/DD/YYYY") & "','" _
        & Typ & "'," & Item & ",'" & Source & "','" & Dest & "'," & Qty & "," & flag & ")"
        With ADOCmd
            .ActiveConnection = DB
            .CommandType = ADODB.CommandTypeEnum.adCmdStoredProc
            .CommandText = s
            .Execute()
        End With

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

End Module
