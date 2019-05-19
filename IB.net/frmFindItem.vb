Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmFindItem

    Dim TypeOpt As String
    Dim blnNoCLick As Boolean = False

    Private Sub frmFindItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        blnNoCLick = True
        GetWindowPos(Me, 333, 66)
        blnNoCLick = False

        TypeOpt = "B"

        GetData()

    End Sub

    Sub GetData()

        Me.Cursor = Cursors.WaitCursor

        Try
            strLocation = "GD1.0"
            SpGetItemsNumTableAdapter.Connection.ConnectionString = CS
            SpGetItemsNumTableAdapter.Fill(DsspGetItemsNum.spGetItemsNum, TypeOpt)

            strLocation = "GD2.0"
            SpGetItemsAlphaTableAdapter.Connection.ConnectionString = CS
            SpGetItemsAlphaTableAdapter.Fill(DsspGetItemsAlpha.spGetItemsAlpha, TypeOpt)

            strLocation = "GD3.0"
            SpGetItemsVend1TableAdapter.Connection.ConnectionString = CS
            SpGetItemsVend1TableAdapter.Fill(DsspGetItemsVend1.spGetItemsVend1, TypeOpt)

            If CurItem > 0 Then
                strLocation = "GD4.0"
                'LstItemNum.SelectedIndex = LstItemNum.FindStringExact(CurItem)
                SpGetItemsNumBindingSource.Position = SpGetItemsNumBindingSource.Find("ITEM_NUM", CurItem)
                strLocation = "GD5.0"
                SpGetItemsAlphaBindingSource.Position = SpGetItemsAlphaBindingSource.Find("ITEM_NUM", CurItem)

                GetVendor()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

    Sub GetVendor()

        Dim s As String

        Try
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GV1.0"
            s = "Select vendor from ItemMasterO where item_num = " & LstItemNum.SelectedValue.ToString() & " union select vendor from ItemMasterR where item_num = " & LstItemNum.SelectedValue.ToString()

            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand(s, connection)

                strLocation = "GV2.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows Then
                    strLocation = "GV3.0"
                    dataReader.Read()

                    If IsDBNull(dataReader("VENDOR")) Then
                        cmbVendor.SelectedIndex = 0
                        lstVendItem.ClearSelected()
                    Else
                        strLocation = "GV4.0"
                        CurVend = dataReader("VENDOR")
                        If CurVend.Trim <> "" Then
                            cmbVendor.SelectedIndex = cmbVendor.FindStringExact(CurVend)
                        End If
                    End If

                    dataReader.Close()
                End If
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default

            Result = MessageBox.Show(Me, "Error in routine GetVendor (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetVendor", vbOK)
            LogError(Me.Name, "GetVendor", strLocation, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub LstItemNum_Click(sender As Object, e As EventArgs) Handles LstItemNum.Click

        Try
            strLocation = "LINC1.0"
            SpGetItemsAlphaBindingSource.Position = SpGetItemsAlphaBindingSource.Find("ITEM_NUM", LstItemNum.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine LstItemNum_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LstItemNum_Click", vbOK)
            LogError(Me.Name, "LstItemNum_Click", strLocation, ex.Message)
        End Try

        GetVendor()

    End Sub

    Private Sub LstItemAlpha_Click(sender As Object, e As EventArgs) Handles LstItemAlpha.Click

        Try
            strLocation = "LIAC1.0"
            SpGetItemsNumBindingSource.Position = SpGetItemsNumBindingSource.Find("ITEM_NUM", LstItemAlpha.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine LstItemAlpha_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "LstItemAlpha_Click", vbOK)
            LogError(Me.Name, "LstItemAlpha_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstVendItem_Click(sender As Object, e As EventArgs) Handles lstVendItem.Click

        Try
            strLocation = "LVIC1.0"
            LstItemNum.SelectedIndex = LstItemNum.FindStringExact(lstVendItem.SelectedItem(0))
            strLocation = "LVIC2.0"
            LstItemAlpha.SelectedIndex = LstItemAlpha.FindStringExact(lstVendItem.SelectedValue.ToString)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine lstVendItem_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstVendItem_Click", vbOK)
            LogError(Me.Name, "lstVendItem_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmbVendor_TextChanged(sender As Object, e As EventArgs) Handles cmbVendor.TextChanged

        Try
            strLocation = "CVTC1.0"
            CurVend = cmbVendor.Text

            strLocation = "CVTC2.0"
            SpGetItemsVend2TableAdapter.Connection.ConnectionString = CS
            SpGetItemsVend2TableAdapter.Fill(DsspGetItemsVend2.spGetItemsVend2, TypeOpt, CurVend)
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine cmbVendor_TextChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmbVendor_TextChanged", vbOK)
            LogError(Me.Name, "cmbVendor_TextChanged", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub optType0_CheckedChanged(sender As Object, e As EventArgs) Handles optType0.CheckedChanged

        TypeOpt = "R"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub optType1_CheckedChanged(sender As Object, e As EventArgs) Handles optType1.CheckedChanged

        TypeOpt = "O"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub OptType2_CheckedChanged(sender As Object, e As EventArgs) Handles OptType2.CheckedChanged

        TypeOpt = "B"

        If blnNoCLick = False Then
            GetData()
        End If

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click, lstVendItem.DoubleClick, LstItemNum.DoubleClick, LstItemAlpha.DoubleClick

        Dim intRow As Integer

        Try
            strLocation = "CSC1.0"
            CurItem = LstItemNum.SelectedItem("ITEM_NUM")

            If CurItem > 0 Then
                strLocation = "CSC2.0"
                SpGetItemsNumBindingSource.MoveFirst()
                intRow = SpGetItemsNumBindingSource.Find("ITEM_NUM", CurItem)

                If intRow >= 0 Then
                    SpGetItemsNumBindingSource.Position = intRow
                End If
            End If

            strLocation = "CSC3.0"
            CurItem = DsspGetItemsNum.spGetItemsNum(intRow)("ITEM_NUM")
            CurType = DsspGetItemsNum.spGetItemsNum(intRow)("ITEM_TYPE")

            SetLabelOnAllOpenForms(CurItem, "lblCurItem")
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine cmdSelect_Click (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "cmdSelect_Click", vbOK)
            LogError(Me.Name, "cmdSelect_Click", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub frmFindItem_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

End Class