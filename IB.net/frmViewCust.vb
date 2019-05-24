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

        Me.Cursor = Cursors.Arrow

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
            Me.SpGetCustTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustTableAdapter.Fill(IBPortlandDataSet.spGetCust, CurCust)

            GetAverage()
            GetData1()
            GetData2()
        End If

    End Sub

    Private Sub GetData1()

        'Get customer departments
        Me.SpGetCustDeptTableAdapter.Connection.ConnectionString = CS
        Me.SpGetCustDeptTableAdapter.Fill(IBPortlandDataSet.SpGetCustDept, CurCust)

        If IBPortlandDataSet.Tables("spGetCust").Rows.Count > 0 Then
            'data1(1).Recordset.MoveFirst
            If CurDept > 0 Then
                '   data1(1).Recordset.Find "DEPT=" & CStr(CurDept)
                '   If data1(1).Recordset.EOF Then data1(1).Recordset.MoveFirst
            End If
        End If

    End Sub

    Private Sub GetData2()

        'Get routes and items for dept
        If IBPortlandDataSet.Tables("SpGetCustDept").Rows.Count = 0 Then
            CurDept = 1
        Else
            CurDept = CInt(grdDept.Columns("Dept").CellValue(Me.grdDept.Row))
        End If

        'If buserchange Then
        Me.SpGetCustRouteTableAdapter.Connection.ConnectionString = CS
        Me.SpGetCustRouteTableAdapter.Fill(IBPortlandDataSet.SpGetCustRoute, CurCust, CurDept)

            Me.SpGetCustItemTableAdapter.Connection.ConnectionString = CS
            Me.SpGetCustItemTableAdapter.Fill(IBPortlandDataSet.SpGetCustItem, CurCust, CurDept)
        'End If


    End Sub

    Sub GetAverage()

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
                        'If sqlReader.Read() Then
                        If sqlReader.HasRows = True Then
                            sqlReader.Read()

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
                    sqlCmd.Connection = sqlConn
                    sqlCmd.CommandType = CommandType.StoredProcedure

                    sqlCmd.CommandText = "spGetAvgPaper"
                    sqlCmd.Parameters.Add("Cust", SqlDbType.Char).Value = CurCust
                    sqlDA.SelectCommand = sqlCmd

                    Using sqlReader = sqlCmd.ExecuteReader()
                        ' If the SqlDataReader.Read returns true then there is a customer with that ID'
                        'If sqlReader.Read() Then
                        If sqlReader.HasRows = True Then
                            sqlReader.Read()

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

    'Private Sub ITEMHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITEMHISTORYToolStripMenuItem.Click

    '    frmROHist.Show()

    'End Sub

    'Private Sub ARHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARHISTORYToolStripMenuItem.Click


    '    'With RPT
    '    '    .ReportFileName = RptPath & "\deadbeatcust.rpt"
    '    '    .Connect = CryCS
    '    '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
    '    '    ' .Formulas(1) = "COMPANY='" & CompanyName & "'"
    '    '    .SelectionFormula = "{custcopy.Cust # (2)}=" & CurCust
    '    '    '.SelectionFormula = "{ARCUSTSCOPY2.Cust # (2)}=" & CurCust
    '    '    '.SelectionFormula = "{custcopy.Cust # (2)}in [" & txtcustnum.Text & "]"
    '    '    .Action = 1
    '    '    .Destination = 0
    '    '    ' .Formulas(0) = ""
    '    '    ' .Formulas(1) = ""
    '    '    .ReportFileName = ""
    '    'End With

    'End Sub



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

    Private Sub SetDbConnection(ByVal rptCrxReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)

        ' Set database information
        ConnInfo = New CrystalDecisions.Shared.ConnectionInfo
        ConnInfo.ServerName = Server.Trim
        ConnInfo.DatabaseName = DBName.Trim
        ConnInfo.UserID = Username.Trim
        ConnInfo.Password = Password.Trim

        For Each CTable As Table In rptCrxReport.Database.Tables
            CTable.LogOnInfo.ConnectionInfo = ConnInfo
            CTableLogInfo = CTable.LogOnInfo
            CTableLogInfo.ReportName = rptCrxReport.Name
            CTableLogInfo.TableName = CTable.Name
            CTable.ApplyLogOnInfo(CTableLogInfo)
        Next

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Me.Cursor = Cursors.WaitCursor

        'Dim RPT As New ReportDocument
        RPT.Load("C:\IB\ReportsCR2016\CustInfo.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        SetDbConnection(RPT)

        RPT.SetParameterValue("CompanyName", frmMain.Text)
        RPT.SetParameterValue("CustNum", CurCust)

        RPT.PrintToPrinter(1, True, 0, 0)

        Me.Cursor = Cursors.Default

        'Report.Load(System.AppDomain.CurrentDomain.BaseDirectory() & "CustInfo.rpt")

        'Dim dt As New DataTable                     ' THE DATATABLE HAS THE DATA FROM THE DATABASE.
        'Report.SetDataSource(dt)                    ' SET REPORT DATA SOURCE.
        'Report.PrintToPrinter(1, True, 0, 0)        ' FINALY, PRINT IT.

        'With RPT
        '    .ReportFileName = DataPath & "\Custinfo.rpt"
        '    .Connect = CryCS
        '    .Formulas(0) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{CustomerMaster.CUST_NUM}=" & CStr(CurCust)
        '    .Destination = 1
        '    .Action = 1
        '    .Formulas(0) = ""
        '    .SelectionFormula = ""
        '    .ReportFileName = ""
        'End With

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

        'Me.Cursor = Cursors.WaitCursor

        'Dim rptCrxReport As New ReportDocument
        'rptCrxReport.Load("C:\IB\ReportsCR2016\deadbeatcust.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

        'SetDbConnection(rptCrxReport)

        ''rptCrxReport.SetParameterValue("CompanyName", frmMain.Text)
        'rptCrxReport.SetParameterValue("CustNum", CurCust)

        'rptCrxReport.PrintToPrinter(1, True, 0, 0)

        'Me.Cursor = Cursors.Default

        'With RPT
        '    .ReportFileName = RptPath & "\deadbeatcust.rpt"
        '    .Connect = CryCS
        '    '.Formulas(0) = "RUNDATE=Date(" & Format(RunDate, "yyyy,mm,dd") & ")"
        '    ' .Formulas(1) = "COMPANY='" & CompanyName & "'"
        '    .SelectionFormula = "{custcopy.Cust # (2)}=" & CurCust
        '    '.SelectionFormula = "{ARCUSTSCOPY2.Cust # (2)}=" & CurCust
        '    '.SelectionFormula = "{custcopy.Cust # (2)}in [" & txtcustnum.Text & "]"
        '    .Action = 1
        '    .Destination = 0
        '    ' .Formulas(0) = ""
        '    ' .Formulas(1) = ""
        '    .ReportF

    End Sub

End Class