Imports System.Data.SqlClient

Public Class frmFindItem

    'Dim TypeOpt As String * 1
    Dim TypeOpt As String
    Dim Result As DialogResult


    Private Sub frmFindItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        TypeOpt = "B"

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        'Data1.ConnectionString = CS
        'Data1.RecordSource = "spGetItemsNum ('" & TypeOpt & "')"
        'Data1.Enabled = True
        'Data1.Refresh
        SpGetItemsNumTableAdapter.Connection.ConnectionString = CS
        SpGetItemsNumTableAdapter.Fill(DsspGetItemsNum.spGetItemsNum, TypeOpt)

        'Data2.ConnectionString = CS
        'Data2.RecordSource = "spGetItemsAlpha ('" & TypeOpt & "')"
        'Data2.Enabled = True
        'Data2.Refresh
        SpGetItemsAlphaTableAdapter.Connection.ConnectionString = CS
        SpGetItemsAlphaTableAdapter.Fill(DsspGetItemsAlpha.spGetItemsAlpha, TypeOpt)

        'Data3.ConnectionString = CS
        'Data3.RecordSource = "spGetItemsVend1 ('" & TypeOpt & "')"
        'Data3.Enabled = True
        'Data3.Refresh
        SpGetItemsVend1TableAdapter.Connection.ConnectionString = CS
        SpGetItemsVend1TableAdapter.Fill(DsspGetItemsVend1.spGetItemsVend1, TypeOpt)

        Me.Cursor = Cursors.Arrow

    End Sub

    Sub GetVendor()

        Dim s As String
        'RSx As New ADODB.Recordset

        's = "Select vendor from ItemMasterO  where item_num = " & LstItemNum.BoundText & " union select vendor from ItemMasterR where item_num = " & LstItemNum.BoundText
        'RSx.Open s, DB

        'If Not IsNull(RSx(0)) Then CurVend = RSx(0)

        'RSx.Close()

        'cmbVendor.BoundText = CurVend

        s = "Select vendor from ItemMasterO  where item_num = " & LstItemNum.SelectedItem & " union select vendor from ItemMasterR where item_num = " & LstItemNum.SelectedItem

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand(s, connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows Then
                    CurVend = dataReader(0)
                End If

                dataReader.Close()

            Catch ex As Exception
                LogError(Me.Name, "GetVendor", "2.0", ex.Message)
                Result = MessageBox.Show(Me, "Error getting the vendor" & vbNewLine & "Error : " & ex.Message, "Getting Vendor", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

    End Sub


End Class