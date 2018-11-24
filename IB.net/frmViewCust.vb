Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmViewCust

    Private buserchange As Boolean

    Private Sub frmViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 0, 0)

        If Dir("grdDept.xml") <> "" Then
            grdDept.LoadLayout("grdDept.xml")
        End If
        If Dir("grdRoute.xml") <> "" Then
            grdRoute.LoadLayout("grdRoute.xml")
        End If
        If Dir("grdItem.xml") <> "" Then
            grdItem.LoadLayout("grdItem.xml")
        End If
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
        GetAverage()
        GetData1()
        GetData2()
        'End If

    End Sub

    Private Sub GetData1()
        'Get customer departments
        Me.SpGetCustDeptTableAdapter.Fill(IBPortlandDataSet.SpGetCustDept, CurCust)
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
        Me.SpGetCustRouteTableAdapter.Fill(IBPortlandDataSet.SpGetCustRoute, CurCust, CurDept)
        Me.SpGetCustItemTableAdapter.Fill(IBPortlandDataSet.SpGetCustItem, CurCust, CurDept)
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
        'ARS.Open(q, DB, ADODB.CursorTypeEnum.adOpenForwardOnly)
        'txtAverage.Text = "0"
        'If ARS.RecordCount = 1 Then
        'If Not IsDBNull(ARS!AVERAGE) Then
        'txtAverage.Text = RoundOff(ARS!AVERAGE)
        'End If
        'End If
        'ARS.Close()

        Using sqlConn As New SqlClient.SqlConnection
            sqlConn.ConnectionString = CS
            sqlConn.Open()

            Using sqlDA As New SqlDataAdapter()
                Using sqlCmd As New SqlCommand
                    sqlCmd.Connection = sqlConn
                    sqlCmd.CommandType = CommandType.StoredProcedure

                    sqlCmd.CommandText = "spGetAverageCust"
                    sqlCmd.Parameters.Add("CustNum", SqlDbType.VarChar).Value = CurCust
                    sqlDA.SelectCommand = sqlCmd

                    Using sqlReader = sqlCmd.ExecuteReader()
                        ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                        If sqlReader.Read() Then
                            txtAverage.Text = "0"
                            If Not sqlReader.IsDBNull(0) Then
                                txtAverage.Text = RoundOff(sqlReader.GetDouble(0)).ToString()
                                'Dim dblTemp = RoundOff(sqlReader.GetDouble(0)).ToString()
                            End If
                        End If
                    End Using
                End Using

                Using sqlCmd As New SqlCommand
                    sqlCmd.Connection = sqlConn
                    sqlCmd.CommandType = CommandType.StoredProcedure

                    sqlCmd.CommandText = "spGetAvgPaper"
                    sqlCmd.Parameters.Add("Cust", SqlDbType.Char).Value = CurCust
                    sqlDA.SelectCommand = sqlCmd

                    Using sqlReader = sqlCmd.ExecuteReader()
                        ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                        If sqlReader.Read() Then
                            txtAverage2.Text = "0"
                            If Not sqlReader.IsDBNull(0) Then
                                txtAverage2.Text = RoundOff(sqlReader.GetDouble(0)).ToString()
                            End If
                        End If
                    End Using
                End Using
            End Using
        End Using

        'q = "spGetAvgPaper (" & CurCust & ")"
        'ARS.Open(q, DB, ADODB.CursorTypeEnum.adOpenForwardOnly)
        'txtAverage2.Text = "0"
        'If ARS.RecordCount = 1 Then
        'If Not IsDBNull(ARS!AVERAGE) Then
        'txtAverage2.Text = RoundOff(ARS!AVERAGE)
        'End If
        'End If
        'ARS.Close()

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        buserchange = False
        GetData()
        buserchange = True

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub frmViewCust_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdDept.SaveLayout("grdDept.xml")
        grdRoute.SaveLayout("grdRoute.xml")
        grdItem.SaveLayout("grdItem.xml")
        'SaveColWidths(Me, grdDept)
        'SaveColWidths(Me, grdRoute)
        'SaveColWidths(Me, grdItem)

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdEditCust_Click(sender As Object, e As EventArgs) Handles cmdEditCust.Click

        frmCust.Show()
        frmCust.BringToFront()

    End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

    End Sub

    Private Sub grdDept_Click(sender As Object, e As EventArgs) Handles grdDept.Click

        CurDept = grdDept.Row

        GetData2()

    End Sub

End Class