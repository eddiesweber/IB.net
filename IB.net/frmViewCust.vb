Option Explicit On

Public Class frmViewCust

    Private buserchange As Boolean

    Private Sub frmViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer
        'GetWindowPos Me, 0, 0
        'GetColWidths Me, grdDept
        'GetColWidths Me, grdRoute
        'GetColWidths Me, grdItem

        'data1(0).ConnectionString = CS
        'data1(0).Enabled = True
        'data1(1).ConnectionString = CS
        'data1(1).Enabled = True
        'data1(2).ConnectionString = CS
        'data1(2).Enabled = True
        'data1(3).ConnectionString = CS
        'data1(3).Enabled = True

    End Sub

    Private Sub frmViewCust_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If CurDept = 0 Then
            CurDept = 1
        End If

        If CurCust = 0 Then
            frmFindCust.Show()
        Else
            lblCurCust.Text = CurCust
        End If

        buserchange = True

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        GetData()
        buserchange = True

    End Sub

    Private Sub GetData()
        'Get customer record
        Me.SpGetCustTableAdapter.Fill(IBPortlandDataSet.spGetCust, CurCust)
        'data1(0).RecordSource = "spGetCust(" & CurCust & ")"
        'data1(0).Refresh

        'If data1(0).Recordset.BOF Or data1(0).Recordset.EOF Then
        'CurCust = 0
        'frmFindCust.Show()
        'Exit Sub
        'Else
        'GetAverage()
        GetData1()
        GetData2()
        'End If

    End Sub

    Private Sub GetData1()
        'Get customer departments
        Me.SpGetCustDeptTableAdapter.Fill(IBPortlandDataSet.SpGetCustDept, 1008)
        'data1(1).RecordSource = "spGetCustDept(" & CurCust & ")"
        'data1(1).Refresh
        'If data1(1).Recordset.RecordCount > 0 Then
        'data1(1).Recordset.MoveFirst
        'If CurDept > 0 Then
        'data1(1).Recordset.Find "DEPT=" & CStr(CurDept)
        'If data1(1).Recordset.EOF Then data1(1).Recordset.MoveFirst
        'End If
        'End If
    End Sub

    Private Sub GetData2()
        'Get routes and items for dept
        Me.SpGetCustRouteTableAdapter.Fill(IBPortlandDataSet.SpGetCustRoute, 1008, 1)
        Me.SpGetCustItemTableAdapter.Fill(IBPortlandDataSet.SpGetCustItem, 1008, 1)
        'If buserchange Then
        'If data1(1).Recordset.EOF And data1(1).Recordset.BOF Then
        'CurDept = 1
        'Else
        'CurDept = data1(1).Recordset!DEPT
        'End If
        'End If
        'data1(2).RecordSource = "spGetCustRoute(" & CurCust & "," & CurDept & ")"
        'data1(2).Refresh
        'data1(3).RecordSource = "spGetCustItem(" & CurCust & "," & CurDept & ")"
        'data1(3).Refresh
    End Sub

    Sub GetAverage()
        'Dim ARS As New ADODB.Recordset, q As String, q1 As String
        'q = "spGetAverageCust (" & CurCust & ")"
        'ARS.Open q, DB, adOpenForwardOnly
        'txtAverage = "0"
        'If ARS.RecordCount = 1 Then
        'If Not IsNull(ARS!AVERAGE) Then
        'txtAverage = RoundOff(ARS!AVERAGE)
        'End If
        'End If
        'ARS.Close
        'q = "spGetAvgPaper (" & CurCust & ")"
        'ARS.Open q, DB, adOpenForwardOnly
        'txtAverage2 = "0"
        'If ARS.RecordCount = 1 Then
        'If Not IsNull(ARS!AVERAGE) Then
        'txtAverage2 = RoundOff(ARS!AVERAGE)
        'End If
        'End If
        'ARS.Close
    End Sub

End Class