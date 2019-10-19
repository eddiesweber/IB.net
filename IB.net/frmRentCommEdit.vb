Option Explicit On
Imports System.ComponentModel
Imports System.Web.UI.WebControls
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1TrueDBGrid

Public Class frmRentCommEdit

    Dim CurSales As String
    Dim buserchange As Boolean

    Private Sub frmRentCommEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'GetWindowPos(Me, 0, 0)
        'GetColWidths Me, TDBGrid1

        GetData()

        SpGetSalesmenTableAdapter.Connection.ConnectionString = CS
        SpGetSalesmenTableAdapter.Fill(DsspGetSalesmen.spGetSalesmen)
        'Data2.ConnectionString = CS
        'Data2.RecordSource = "spGetSalesmen"
        'Data2.Enabled = True
        'Data2.Refresh

    End Sub

    Private Sub frmRentCommEdit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Sub GetData()

        ' Clear grid?

        If optCust0.Checked Then
            RevenueByCust_ChangeTableAdapter.Connection.ConnectionString = CS
            RevenueByCust_ChangeTableAdapter.Fill(DsRevenuebyCust_Change.RevenueByCust)
            TDBGrid1.DataSource = RevenueByCustBindingSource
        Else
            RevenueByCustTableAdapter.Connection.ConnectionString = CS
            RevenueByCustTableAdapter.Fill(Me.DsRevenuebyCust.RevenueByCust)
            TDBGrid1.DataSource = RevenueByCust_ChangeBindingSource
        End If
        TDBGrid1.Refresh()

        'q = "Select * from RevenuebyCust"
        'If optCust1.Checked Then
        '    q = q & " WHERE [CHANGE]<>0"
        'End If
        'q = q & " Order By BILL_NAME"

        'Data1.RecordSource = q
        'Data1.Enabled = True
        'Data1.Refresh
        'rs = Data1.Recordset
        'TDBGrid1.Refresh

    End Sub

    Sub SetPercent()

        Dim i As Integer, n As Integer, k As Integer
        Dim T As Single, A As Single

        For i = 2 To 6 Step 2
            If TDBGrid1.Columns(i).Text > "" Then n = n + 1
        Next i

        For i = 2 To 6 Step 2
            If TDBGrid1.Columns(i).Text > "" Then
                k = k + 1
                If k < n Then
                    A = RoundOff(100 / n)
                Else
                    A = 100 - T
                End If
                TDBGrid1.Columns(i + 1).Value = A
                T = T + A
            Else
                TDBGrid1.Columns(i + 1).Value = 0
            End If
        Next i

    End Sub

    Private Sub optCust0_CheckedChanged(sender As Object, e As EventArgs) Handles optCust0.CheckedChanged, optCust1.CheckedChanged

        GetData()

    End Sub

    Private Sub lstSales2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSales2.SelectedIndexChanged

        Dim L As DataList

        'L  = lstSales2
        L.DataSource = lstSales2

        If buserchange Then
            'TDBGrid1.Columns(TDBGrid1.Col).Value = L.BoundText
            TDBGrid1.Columns(TDBGrid1.Col).Value = L.SelectedValue
            L.Visible = False
            SetPercent()
            TDBGrid1.Col = TDBGrid1.Col + 1
            'TDBGrid1.SetFocus
        End If

    End Sub

    Private Sub lstSales2_Leave(sender As Object, e As EventArgs) Handles lstSales2.Leave

        lstSales2.Visible = False

    End Sub

    Private Sub TDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles TDBGrid1.AfterColUpdate

        Dim i As Integer

        i = e.ColIndex

        If (i = 2 Or i = 4 Or i = 6) Then
            SetPercent()
        End If

    End Sub

    Private Sub TDBGrid1_ButtonClick(sender As Object, e As ColEventArgs) Handles TDBGrid1.ButtonClick

        'Dim Co As Column
        'Dim T As Integer
        'Dim i As Integer
        'Dim s As String
        'Dim LB As DataList

        'Co = TDBGrid1.Columns(e.ColIndex)
        's = Co(0).Text
        'LB = lstSales2

        'T = TDBGrid1.Top + TDBGrid1.RowTop(TDBGrid1.Row)
        'If T + LB.Height > Me.ScaleHeight Then
        '    T = T - LB.Height + TDBGrid1.RowHeight
        'End If

        'buserchange = False

        'With LB
        '    .Left = Co.Left + Co.Width
        '    .Top = T
        '    .Visible = True
        '    .ZOrder 0
        '    .BoundText = s
        '    .SetFocus
        'End With

        buserchange = True

    End Sub

    Private Sub TDBGrid1_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles TDBGrid1.RowColChange

        If TDBGrid1.Col < 2 Then
            TDBGrid1.Col = 2
        End If

        If TDBGrid1.Col > 8 Then
            TDBGrid1.Col = 14
        End If

    End Sub

    Private Sub TDBGrid1_Scroll(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles TDBGrid1.Scroll

        lstSales2.Visible = False

    End Sub
End Class