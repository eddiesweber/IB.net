Public Class frmViewItem

    Private Sub frmViewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 0, 0)
        If Dir("frmViewItemgrdPO.xml") <> "" Then
            grdPO.LoadLayout("frmViewItemgrdPO.xml")
        End If

        'data1(0).ConnectionString = CS
        'data2.ConnectionString = CS

        'Set rs = data1(0).Recordset

        ''''''''''' From Form Activate
        If CurType <> "R" And CurType <> "O" Then
            CurType = "R"
        End If

        If CurItem = 0 Then
            frmFindItem.Show()
            frmFindItem.BringToFront()
        Else
            lblCurItem.Text = CurItem
        End If

    End Sub

    Private Sub lblCurItem_TextChanged(sender As Object, e As EventArgs) Handles lblCurItem.TextChanged

        ''Get Item record
        'data1(0).Recordset.Close
        'data2.Recordset.Close

        SpGetItemTableAdapter.Connection.ConnectionString = CS
        SpGetItemTableAdapter.Fill(DsspGetItem.spGetItem, CurType, CurItem)
        'q = "spGetItem ('" & CurType & "'," & CurItem & ")"
        'data1(0).RecordSource = q
        'data1(0).Enabled = True
        'data1(0).Refresh

        SpGetItemPOTableAdapter.Connection.ConnectionString = CS
        SpGetItempoTableAdapter.Fill(DsspGetItemPO.spGetItemPO, CurItem)
        'q = "spGetItemPO (" & CurItem & ")"
        'data2.RecordSource = q
        'data2.Enabled = True
        'data2.Refresh

        If DsspGetItemPO.spGetItemPO.Rows.Count > 0 Then
            SpGetItemPOBindingSource.MoveLast()
        End If
        'If data2.Recordset.RecordCount > 0 Then
        '    data2.Recordset.MoveLast
        'End If

        If CurType = "R" Then
            txtType.Text = "Rental"
            Frame1.Visible = True
            grdPO.Visible = False
        Else
            txtType.Text = "Other"
            Frame1.Visible = False
            grdPO.Visible = True
        End If

        If DsspGetItem.spGetItem.Rows.Count > 0 Then
            lblAvailable.Text = CStr(DsspGetItem.spGetItem.Rows(0)("TOTAL_OWN") -
                DsspGetItem.spGetItem.Rows(0)("RENTED") -
                DsspGetItem.spGetItem.Rows(0)("LOANED") -
                DsspGetItem.spGetItem.Rows(0)("DAMAGED") -
                DsspGetItem.spGetItem.Rows(0)("COMMITTED"))
        End If

    End Sub

    'Private Sub Data1_MoveComplete(Index As Integer, ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)

    '    Dim R As ADODB.Recordset
    '    Set R = data1(0).Recordset
    '    On Error Resume Next
    '    lblAvailable.Caption = CStr(R!TOTAL_OWN - R!RENTED - R!LOANED - R!DAMAGED - R!COMMITTED)

    'End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs)

        SaveWindowPos(Me)

        grdPO.SaveLayout("frmViewItemgrdPO.xml")

    End Sub

    Private Sub cmdAdj_Click(sender As Object, e As EventArgs) Handles cmdAdj.Click

        frmInvAdj.Show()

    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click

        frmItem.Show()

    End Sub

    Private Sub cmdEditPO_Click(sender As Object, e As EventArgs) Handles cmdEditPO.Click

        frmPONew.Show()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindItem.Show()
        frmFindItem.BringToFront()

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        lblCurItem_TextChanged(sender, e)

    End Sub

    Private Sub cmdUsage_Click(sender As Object, e As EventArgs) Handles cmdUsage.Click

        'Dim WS As Integer
        'WS = RPT.WindowState
        'CalcItemUse CurItem, CurItem, True, False
        'With RPT
        '    .WindowState = 2
        '    .ReportFileName = RptPath & "\ItemUse.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .Destination = 0
        '    .Action = 1
        '    .PageZoom(80)
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With
        'RPT.WindowState = WS

    End Sub


End Class