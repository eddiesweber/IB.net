Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmViewCust

    Private buserchange As Boolean

    Private Sub frmViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        GetWindowPos(Me, 0, 0)

        If Dir("frmViewCustgrdDept.xml") <> "" Then
            grdDept.LoadLayout("frmViewCustgrdDept.xml")
        End If
        If Dir("frmViewCustgrdRoute.xml") <> "" Then
            grdRoute.LoadLayout("frmViewCustgrdRoute.xml")
        End If
        If Dir("frmViewCustgrdItem.xml") <> "" Then
            grdItem.LoadLayout("frmViewCustgrdItem.xml")
        End If

        If CurDept = 0 Then
            CurDept = 1
        End If

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            lblCurCust.Text = CurCust
        End If

        buserchange = True

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmViewCust_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdDept.SaveLayout("frmViewCustgrdDept.xml")
        grdRoute.SaveLayout("frmViewCustgrdRoute.xml")
        grdItem.SaveLayout("frmViewCustgrdItem.xml")

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        buserchange = False
        GetData()
        buserchange = True

    End Sub

    Private Sub GetData()

        If CurCust = 0 Then
            frmFindCust.Show()
            frmFindCust.BringToFront()
        Else
            Try
                strLocation = "GD1.0"
                Me.Cursor = Cursors.WaitCursor
                Me.SpGetCustTableAdapter.Connection.ConnectionString = CS
                Me.SpGetCustTableAdapter.Fill(IBPortlandDataSet.spGetCust, CurCust)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine Getdata (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
                LogError(Me.Name, "GetData", strLocation, ex.Message)
            End Try

            GetAverage()
            GetData1()
            GetData2()
        End If

    End Sub

    Private Sub GetData1()

        Dim intRow As Integer

        Try
            'Get customer departments
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GDO1.0"
            Me.SpGetCustDeptTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustDeptTableAdapter.Fill(IBPortlandDataSet.SpGetCustDept, CurCust)

            If IBPortlandDataSet.Tables("spGetCust").Rows.Count > 0 Then
                strLocation = "GDO2.0"
                SpGetCustDeptBindingSource.MoveFirst()

                If CurDept > 0 Then
                    strLocation = "GDO3.0"
                    intRow = SpGetCustDeptBindingSource.Find("DEPT", CurDept)
                    If intRow >= 0 Then
                        SpGetCustDeptBindingSource.Position = intRow
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata1 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData1", vbOK)
            LogError(Me.Name, "GetData1", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub GetData2()

        Try
            'Get routes and items for dept
            Me.Cursor = Cursors.WaitCursor

            strLocation = "GDT1.0"
            If IBPortlandDataSet.Tables("SpGetCustDept").Rows.Count = 0 Then
                CurDept = 1
            Else
                CurDept = CInt(grdDept.Columns("Dept").CellValue(Me.grdDept.Row))
            End If

            strLocation = "GDT2.0"
            Me.SpGetCustRouteTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustRouteTableAdapter.Fill(IBPortlandDataSet.SpGetCustRoute, CurCust, CurDept)

            strLocation = "GDT3.0"
            Me.SpGetCustItemTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustItemTableAdapter.Fill(IBPortlandDataSet.SpGetCustItem, CurCust, CurDept)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine Getdata2 (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData2", vbOK)
            LogError(Me.Name, "GetData2", strLocation, ex.Message)
        End Try


    End Sub

    Sub GetAverage()

        Try
            Using sqlConn As New SqlClient.SqlConnection
                strLocation = "GA1.0"
                sqlConn.ConnectionString = CS
                sqlConn.Open()

                Using sqlDA As New SqlDataAdapter()
                    Using sqlCmd As New SqlCommand
                        strLocation = "GA2.0"
                        sqlCmd.Connection = sqlConn
                        sqlCmd.CommandType = CommandType.StoredProcedure

                        sqlCmd.CommandText = "spGetAverageCust"
                        sqlCmd.Parameters.Add("CustNum", SqlDbType.VarChar).Value = CurCust
                        sqlDA.SelectCommand = sqlCmd

                        Using sqlReader = sqlCmd.ExecuteReader()
                            ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                            'If sqlReader.Read() Then
                            strLocation = "GA3.0"
                            If sqlReader.HasRows = True Then
                                sqlReader.Read()

                                strLocation = "GA4.0"
                                txtAverage.ReadOnly = False
                                txtAverage.Text = "0"
                                If Not sqlReader.IsDBNull(0) Then
                                    txtAverage.Text = RoundOff(sqlReader.GetDouble(0)).ToString()
                                End If
                                txtAverage.ReadOnly = True
                            End If
                        End Using
                    End Using

                    Using sqlCmd As New SqlCommand
                        strLocation = "GA5.0"
                        sqlCmd.Connection = sqlConn
                        sqlCmd.CommandType = CommandType.StoredProcedure

                        sqlCmd.CommandText = "spGetAvgPaper"
                        sqlCmd.Parameters.Add("Cust", SqlDbType.Char).Value = CurCust
                        sqlDA.SelectCommand = sqlCmd

                        Using sqlReader = sqlCmd.ExecuteReader()
                            ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                            'If sqlReader.Read() Then
                            strLocation = "GA6.0"
                            If sqlReader.HasRows = True Then
                                sqlReader.Read()

                                strLocation = "GA7.0"
                                txtAverage2.ReadOnly = False
                                txtAverage2.Text = "0"
                                If Not sqlReader.IsDBNull(0) Then
                                    txtAverage2.Text = RoundOff(sqlReader.GetDouble(0)).ToString()
                                End If
                                txtAverage2.ReadOnly = True
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine GetAverage (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetDGetAverageata2", vbOK)
            LogError(Me.Name, "GetAverage", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub grdDept_RowColChange(sender As Object, e As RowColChangeEventArgs) Handles grdDept.RowColChange

        If buserchange Then
            If IsNumeric(grdDept.Columns("Dept").CellValue(Me.grdDept.Row)) Then
                CurDept = CInt(grdDept.Columns("Dept").CellValue(Me.grdDept.Row))
            End If

            GetData2()
        End If

    End Sub

    Private Sub ShowSalesHistory()

        frmSOHist.Show()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        buserchange = False
        GetData()
        buserchange = True

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Private Sub cmdEditCust_Click(sender As Object, e As EventArgs) Handles cmdEditCust.Click

        frmCust.Show()
        frmCust.BringToFront()

    End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

        frmDept.Show()

    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click

        frmRentOrd.Show()

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Me.Cursor = Cursors.WaitCursor

        RPT.Load(RptPath & "CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        setCrystalPrinter()
        SetDbConnection()

        RPT.SetParameterValue("CompanyName", frmMain.Text)
        RPT.SetParameterValue("CustNum", CurCust)

        RPT.PrintToPrinter(1, True, 0, 0)

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub mnuSalesHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuSalesHistory.Click

        frmSOHist.Show()

    End Sub

    Private Sub mnuItemHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuItemHistory.Click

        frmROHist.Show()

    End Sub

    Private Sub mnuNotes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuNotes.Click

        frmNotes.Show()

    End Sub

    Private Sub mnuArHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuArHistory.Click

        frmViewReport.lblReportName.Text = "deadbeatcust.rpt"
        frmViewReport.Show()

    End Sub

End Class