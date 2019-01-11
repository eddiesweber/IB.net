Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmViewCust

    Private buserchange As Boolean

    Private Sub frmViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        cmdFind.Select()

    End Sub

    Private Sub frmViewCust_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        grdDept.SaveLayout("frmViewCustgrdDept.xml")
        grdRoute.SaveLayout("frmViewCustgrdRoute.xml")
        grdItem.SaveLayout("frmViewCustgrdItem.xml")

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
        Me.SpGetCustTableAdapter.Connection.ConnectionString = CS
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
        Me.SpGetCustDeptTableAdapter.Connection.ConnectionString = CS
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
        Me.SpGetCustRouteTableAdapter.Connection.ConnectionString = CS
        Me.SpGetCustRouteTableAdapter.Fill(IBPortlandDataSet.SpGetCustRoute, CurCust, CurDept)

        Me.SpGetCustItemTableAdapter.Connection.ConnectionString = CS
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
                        If sqlReader.Read() Then
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

        If IsNumeric(grdDept.Columns(0).CellValue(Me.grdDept.Row)) Then
            CurDept = CInt(grdDept.Columns(0).CellValue(Me.grdDept.Row))
        End If

        GetData2()

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

    'Private Sub SalesHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesHistoryToolStripMenuItem.Click

    '    frmSOHist.Show()

    'End Sub

    Private Sub cmdEditDept_Click(sender As Object, e As EventArgs) Handles cmdEditDept.Click

        frmDept.Show()

    End Sub

    Private Sub cmdEditItem_Click(sender As Object, e As EventArgs) Handles cmdEditItem.Click

        frmRentOrd.Show()

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        Dim ConnInfo As CrystalDecisions.Shared.ConnectionInfo = New CrystalDecisions.Shared.ConnectionInfo

        ConnInfo.IntegratedSecurity = True
        ConnInfo.ServerName = "IBSERVER2016\SQLEXPRESS"
        'ConnInfo.UserID = ""
        'ConnInfo.Password = ""
        ConnInfo.DatabaseName = "IBSEA"

        'RPT.Load(DataPath & "\Custinfo.rpt")
        RPT.Load("C:\IB\IB_DEV\Custinfo.rpt")

        If RPT.DataDefinition.ParameterFields.Count > 0 Then
            MessageBox.Show("RPT.DataDefinition.ParameterFields.Count" & RPT.DataDefinition.ParameterFields.Count)
        Else
            MessageBox.Show("0")
        End If

        'If (RPT.DataDefinition.ParameterFields.Count > 0) Then
        '    For Each rptParam As ParameterFieldDefinition In RPT.DataDefinition.ParameterFields
        '        ' check the reportname is empty - this ensures we set parameters in the main report only
        '        If (rptParam.ReportName = "") Then
        '            ' get the parameter name
        '            Dim strName As String = rptParam.ParameterFieldName
        '            ' check name and set value if correct
        '            If (strName = "Correct Name") Then
        '                Dim objVal As Object = "My Value"
        '                RPT.SetParameterValue(rptParam.ParameterFieldName, objVal)
        '            End If
        '        End If
        '    Next
        'End If

        'RPT.SetDataSource(ds)
        'RPT.RecordSelectionFormula = "{CustomerMaster.CUST_NUM}=" & CStr(CurCust)
        'RPT.SetParameterValue("COMPANY", CompanyName)
        '        RPT.SetParameterValue("CustomerMaster.CUST_NUM", CStr(CurCust))
        RPT.PrintToPrinter(1, True, 0, 0)

        ' Examples
        ' crReport.RecordSelectionFormula = "{SALESORDER.SALESORDERID} = '" + salesOrder.Id.ToString() + "'"
        ' crReport.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Server.MapPath(filename));

        '//Define New connection for Crystal Report
        'CrystalDecisions.Shared.ConnectionInfo connectionInfo = New CrystalDecisions.Shared.ConnectionInfo();
        'connectionInfo.DatabaseName = initialCatalog;
        'connectionInfo.UserID = username;
        'connectionInfo.Password = password;
        'connectionInfo.ServerName = dataSource;

        'oRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
        'oRpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
        'oRpt.DataDefinition.FormulaFields["RazSoc"].Text = "'" + ((Entidades.Sesion)Session["Sesion"]).Cuit.RazonSocial + "'";

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

        MessageBox.Show("Sales History")

    End Sub

    Private Sub mnuItemHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuItemHistory.Click

        MessageBox.Show("Item History")

    End Sub

    Private Sub mnuNotes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuNotes.Click

        MessageBox.Show("Notes")

    End Sub

    Private Sub mnuArHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuArHistory.Click

        MessageBox.Show("AR History")

    End Sub

End Class