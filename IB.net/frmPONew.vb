Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmPONew

    Dim buserchange As Boolean
    Dim bInit As Boolean
    'Dim CurState As String * 2
    Dim CurState As String
    Dim bCancel As Boolean
    Dim bAddMode As Boolean
    Dim bAddMode2 As Boolean
    Dim bEditInProgress As Boolean
    Public RDate As Date
    Public RCancel As Boolean
    Dim Result As DialogResult

    Private Sub frmPONew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        If Dir("frmPONewgrdPO.xml") <> "" Then
            grdPO.LoadLayout("frmPONewgrdPO.xml")
        End If

        buserchange = False
        bInit = True
        RDate = Now()

        'data1.ConnectionString = CS
        'data1.Enabled = True
        'data2.ConnectionString = CS
        'data2.Enabled = True
        'Data3.ConnectionString = CS
        'Data3.Enabled = True
        'Data4.ConnectionString = CS
        'Data4.Enabled = True

        ''Set text box lengths based on tabledef
        'Dim c As Control, fld As String
        'Dim R As New ADODB.Recordset
        'Dim ADOConn As New ADODB.Connection
        'R.Open "Select * from POMaster Where 1=0", DB, adOpenStatic
        'For Each c In Me.Controls
        '    If c.Name = "txtData" Then
        '        fld = c.DataField
        '        If fld > "" Then
        '            Select Case R.Fields(fld).Type
        '                Case adChar, adVarChar, adVarWChar
        '                    c.MaxLength = R.Fields(fld).DefinedSize
        '                Case adTinyInt
        '                    c.MaxLength = 1
        '                Case adSmallInt
        '                    c.MaxLength = 5
        '                Case adInteger, adSingle
        '                    c.MaxLength = 10
        '                Case Else
        '                    c.MaxLength = 20
        '            End Select
        '        End If
        '    End If
        'Next c
        'R.Close()

        GetData()

    End Sub

    Sub GetData()

        Dim intRow As Integer

        POMasterTableAdapter.Connection.ConnectionString = CS
        POMasterTableAdapter.Fill(Me.DsPOMaster.POMaster)
        'data1.RecordSource = "POMaster"
        'data1.Refresh
        'Set rs = data1.Recordset

        If DsPOMaster.POMaster.Rows.Count = 0 Then
            cmdNew.PerformClick()
            Exit Sub
        Else
            If CurPO > 0 Then
                intRow = POMasterBindingSource.Find("Seq", CurPO)

                If intRow >= 0 Then
                    POMasterBindingSource.Position = intRow
                End If
            Else
                POMasterBindingSource.MoveLast()
            End If

            CurPO = DsPOMaster.POMaster.Rows(POMasterBindingSource.Position)("seq")

            GetData2()
        End If

        CurVend = DsPOMaster.POMaster.Rows(POMasterBindingSource.Position)("Vendor")

        GetData4()

        SetModeReg()

        buserchange = True

    End Sub

    Sub GetData2()

        'Dim s As String
        'Dim D As Integer, q As String, CRS As New ADODB.Recordset
        'Dim ADOCmd As New ADODB.Command

        If Not bAddMode Then
            Using Command As New SqlCommand()
                Try
                    Command.Connection = DB
                    Command.CommandText = "spEditPO"
                    Command.CommandType = CommandType.StoredProcedure
                    Command.Parameters.Add("PO", SqlDbType.Int).Value = DsPOMaster.POMaster.Rows(POMasterBindingSource.Position)("seq")

                    Command.ExecuteNonQuery()
                Catch ex As Exception
                    Result = MessageBox.Show(Me, "Error in Getdata2 Routine" & vbNewLine & "Error : " & ex.Message, "GetData2", vbOK)
                    LogError(Me.Name, "GetData2", "1.0", ex.Message)
                End Try
            End Using
        End If

        POItemTempTableAdapter.Connection.ConnectionString = CS
        POItemTempTableAdapter.Fill(DsPOItemTemp_ItemMasterO.POItemTemp, CurPO)
        's = "Select t.*, i.Descr from POItemTemp t left join ItemMasterO i on t.item_num = i.item_num where t.PO_Seq = " & rs!seq
        'data2.RecordSource = s
        'data2.Refresh

        GetData3()

        bEditInProgress = False

    End Sub

    Sub GetData3()

        SpTotalPOTableAdapter.Connection.ConnectionString = CS
        SpTotalPOTableAdapter.Fill(DsspTotalPO.spTotalPO, Val(txtData0.Text))
        'Dim s As String
        's = "exec spTotalPO " & Val(txtData(0))
        'Data3.RecordSource = s
        'Data3.Refresh

    End Sub

    Sub GetData4()

        VendMasterTableAdapter.Connection.ConnectionString = CS
        VendMasterTableAdapter.Fill(DsVendMaster_Vendor.VendMaster, CurVend)
        'Dim s As String
        's = "Select * from VendMaster where Vendor = '" & CurVend & "'"
        'Data4.RecordSource = s
        'Data4.Refresh

    End Sub

    Sub closedata()

        'On Error Resume Next
        'rs.Close()
        'RS2.Close()

    End Sub

    Sub ForceUpdates()

        ''Make sure grid data is updated by closing recordsets
        'On Error Resume Next
        If bEditInProgress Then
            'RS2.Update()
        End If

    End Sub

    Public Sub SetModeChange()

        cmdNew.Enabled = False
        cmdDelete.Enabled = False
        cmdReset.Enabled = True
        'cmdReset.Cancel = True
        cmdUpdate.Enabled = True
        'cmdUpdate.Default = True
        cmdFindPO.Enabled = False
        cmdExit.Enabled = False
        cmdPrint.Enabled = False

    End Sub

    Public Sub SetModeReg()

        cmdNew.Enabled = True

        If Val(txtTotal1.Text) = 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If

        cmdReset.Enabled = False
        cmdUpdate.Enabled = False
        cmdExit.Enabled = True
        cmdFindPO.Enabled = True
        cmdPrint.Enabled = True

    End Sub

    Public Sub ClearTemp()

        'Dim D As Integer, q As String, CRS As New ADODB.Recordset
        'Dim ADOCmd As New ADODB.Command

        Using Command As New SqlCommand()
            Try
                Command.Connection = DB
                Command.CommandText = "spResetPO"
                Command.CommandType = CommandType.StoredProcedure
                Command.Parameters.Add("PO", SqlDbType.Int).Value = Val(txtData0.Text)

                Command.ExecuteNonQuery()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in ClearTemp Routine" & vbNewLine & "Error : " & ex.Message, "ClearTemp", vbOK)
                LogError(Me.Name, "ClearTemp", "1.0", ex.Message)
            End Try
        End Using
        'ADOCmd.ActiveConnection = DB
        'q = "exec spResetPO " & Val(txtData0.Text)
        'ADOCmd.CommandText = q
        'ADOCmd.Execute()

    End Sub

    Private Sub frmPONew_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Using Command As New SqlCommand()
            Try
                Command.Connection = DB
                Command.CommandText = "spUpdatePOTotals"
                Command.CommandType = CommandType.StoredProcedure

                Command.ExecuteNonQuery()
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in frmPONew_Closing Routine" & vbNewLine & "Error : " & ex.Message, "frmPONew_Closing", vbOK)
                LogError(Me.Name, "frmPONew_Closing", "1.0", ex.Message)
            End Try
        End Using
        'ADOCmd.ActiveConnection = DB
        'q = "exec spUpdatePOTotals"
        'ADOCmd.CommandText = q
        'ADOCmd.Execute()

        SaveWindowPos(Me)

        grdPO.SaveLayout("frmPONewgrdPO.xml")

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click

        ClearTemp()

        Me.Close()

    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

    End Sub

    Private Sub cmdFindPO_Click(sender As Object, e As EventArgs) Handles cmdFindPO.Click

        frmFindPO.Show()
        frmFindPO.BringToFront()

    End Sub
End Class