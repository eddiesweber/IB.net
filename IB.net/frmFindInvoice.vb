Option Explicit On

Imports System.ComponentModel

Public Class frmFindInvoice

    Dim buserchange As Boolean

    Private Sub frmFindInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)

        datDate.Value = Now

        CurDate = datDate.Value

        chkAll.Checked = True

        ''''''''''''''''''''''''''''''''''''''''''''''''
        'From Activated
        buserchange = True

        'If Not Val(lstData(0).BoundText) = CurInvoice Then
        '    lstData(0).BoundText = CStr(CurInvoice)
        '    If lstData(0).BoundText = CStr(CurInvoice) Then lstdata_Click 0
        'End If


    End Sub

    Sub GetData()

        Dim dtInvoiceDate As Date = Format(CurDate, "Short Date")

        Me.Cursor = Cursors.WaitCursor

        buserchange = False

        Try
            strLocation = "GD1.0"
            SpGetInvNumTableAdapter.Connection.ConnectionString = CS
            If chkAll.Checked Then
                SpGetInvNumTableAdapter.Fill(DsspGetInvNum.spGetInvNum, Nothing)
            Else
                SpGetInvNumTableAdapter.Fill(DsspGetInvNum.spGetInvNum, dtInvoiceDate)
            End If

            strLocation = "GD2.0"
            SpGetInvRouteTableAdapter.Connection.ConnectionString = CS
            If chkAll.Checked Then
                SpGetInvRouteTableAdapter.Fill(DsspGetInvRoute.spGetInvRoute, Nothing)
            Else
                SpGetInvRouteTableAdapter.Fill(DsspGetInvRoute.spGetInvRoute, dtInvoiceDate)
            End If

            strLocation = "GD3.0"
            SpGetInvCustNumTableAdapter.Connection.ConnectionString = CS
            If chkAll.Checked Then
                SpGetInvCustNumTableAdapter.Fill(DsspGetInvCustNum.spGetInvCustNum, Nothing)
            Else
                SpGetInvCustNumTableAdapter.Fill(DsspGetInvCustNum.spGetInvCustNum, dtInvoiceDate)
            End If

            strLocation = "GD4.0"
            SpGetInvCustAlphaTableAdapter.Connection.ConnectionString = CS
            If chkAll.Checked Then
                SpGetInvCustAlphaTableAdapter.Fill(DsspGetInvCustAlpha.spGetInvCustAlpha, Nothing)
            Else
                SpGetInvCustAlphaTableAdapter.Fill(DsspGetInvCustAlpha.spGetInvCustAlpha, dtInvoiceDate)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        Finally
            buserchange = True

            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub SetOtherListsToSameinvoice(lstSender As ListBox)

        If buserchange Then
            Try
                Dim strListName As String = lstSender.Name

                strLocation = "LD0SIC1.0"
                If strListName <> "lstData0" Then
                    SpGetInvNumBindingSource.Position = SpGetInvNumBindingSource.Find("INV_NUMBER", lstSender.SelectedValue.ToString)
                End If

                strLocation = "LD0SIC2.0"
                If strListName <> "lstData1" Then
                    SpGetInvRouteBindingSource.Position = SpGetInvRouteBindingSource.Find("INV_NUMBER", lstSender.SelectedValue.ToString)
                End If

                strLocation = "LD0SIC3.0"
                If strListName <> "lstData2" Then
                    SpGetInvCustNumBindingSource.Position = SpGetInvCustNumBindingSource.Find("INV_NUMBER", lstSender.SelectedValue.ToString)
                End If

                strLocation = "LD0SIC4.0"
                If strListName <> "lstData3" Then
                    SpGetInvCustAlphaBindingSource.Position = SpGetInvCustAlphaBindingSource.Find("INV_NUMBER", lstSender.SelectedValue.ToString)
                End If

                strLocation = "LD0SIC5.0"
                buserchange = False
                datDate.Value = DsspGetInvNum.spGetInvNum.Rows(SpGetInvNumBindingSource.Position)("DATE")
                buserchange = True
            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error in routine lstData0_SelectedIndexChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstData0_SelectedIndexChanged", vbOK)
                LogError(Me.Name, "lstData0_SelectedIndexChanged", strLocation, ex.Message)
            End Try
        End If

    End Sub

    Private Sub lstData0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstData0.SelectedIndexChanged, lstData3.SelectedIndexChanged, lstData2.SelectedIndexChanged, lstData1.SelectedIndexChanged

        SetOtherListsToSameinvoice(sender)

        ''Set other lists to same invoice
        'If buserchange Then
        '    Try
        '        Dim objList As ListBox = CType(sender, ListBox)
        '        Dim strListName As String = objList.Name

        '        strLocation = "LD0SIC1.0"
        '        If strListName <> "lstData0" Then
        '            SpGetInvNumBindingSource.Position = SpGetInvNumBindingSource.Find("INV_NUMBER", objList.SelectedValue.ToString)
        '        End If

        '        strLocation = "LD0SIC2.0"
        '        If strListName <> "lstData1" Then
        '            SpGetInvRouteBindingSource.Position = SpGetInvRouteBindingSource.Find("INV_NUMBER", objList.SelectedValue.ToString)
        '        End If

        '        strLocation = "LD0SIC3.0"
        '        If strListName <> "lstData2" Then
        '            SpGetInvCustNumBindingSource.Position = SpGetInvCustNumBindingSource.Find("INV_NUMBER", objList.SelectedValue.ToString)
        '        End If

        '        strLocation = "LD0SIC4.0"
        '        If strListName <> "lstData3" Then
        '            SpGetInvCustAlphaBindingSource.Position = SpGetInvCustAlphaBindingSource.Find("INV_NUMBER", objList.SelectedValue.ToString)
        '        End If

        '        strLocation = "LD0SIC5.0"
        '        buserchange = False
        '        datDate.Value = DsspGetInvNum.spGetInvNum.Rows(SpGetInvNumBindingSource.Position)("DATE")
        '        buserchange = True
        '    Catch ex As Exception
        '        Result = MessageBox.Show(Me, "Error in routine lstData0_SelectedIndexChanged (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "lstData0_SelectedIndexChanged", vbOK)
        '        LogError(Me.Name, "lstData0_SelectedIndexChanged", strLocation, ex.Message)
        '    End Try
        'End If

    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged

        If chkAll.Checked = False Then
            CurDate = CDate(datDate.Value)
        End If

        GetData()

        SetOtherListsToSameinvoice(lstData0)

    End Sub

    Private Sub datDate_ValueChanged(sender As Object, e As EventArgs) Handles datDate.ValueChanged

        If buserchange Then
            CurDate = CDate(datDate.Value)
            chkAll.Checked = False

            GetData()

            SetOtherListsToSameinvoice(lstData0)
        End If

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click, lstData2.DoubleClick, lstData1.DoubleClick, lstData0.DoubleClick, lstData3.DoubleClick

        CurInvoice = lstData0.SelectedItem("INV_NUMBER")
        CurCust = lstData2.SelectedItem("CUST_NUM")

        SetLabelOnAllOpenForms(CurInvoice, "lblCurInvoice")

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

        SetOtherListsToSameinvoice(lstData0)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub

    Private Sub frmFindInvoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        buserchange = False

        SaveWindowPos(Me)

    End Sub

End Class