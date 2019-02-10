Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmMain

    Private Sub cmdVersion_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdVersion.Click

        MessageBox.Show("Version 3.0 - January 27, 2019")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand

        Dim sectionname As String
        'Dim Result As DialogResult

        If PrevInstance() Then
            Exit Sub
        End If

        CommFlag = False
        DataPath = Application.StartupPath()
        RptPath = Application.StartupPath() '& "\reports"

        sectionname = "Data"
        Company = GetSetting(APPNAME, sectionname, "Company", "None")
        CurCust = GetSetting(APPNAME, sectionname, "CurCust", 0)
        CurItem = GetSetting(APPNAME, sectionname, "CurItem", 0)
        CurType = GetSetting(APPNAME, sectionname, "CurType", "")

        ' Uses app.config - must import System.Configuration 
        ConfigCS = ConfigurationManager.ConnectionStrings("CS").ConnectionString
        'ConfigCS = "Data Source=SQLIB;Initial Catalog=master;Integrated Security=True"

        configDB = New SqlConnection(ConfigCS)
        configDB.ConnectionString = ConfigCS

        ' Open connection to master database
        Do While configdb.State = ConnectionState.Closed
            Try
                Me.Cursor = Cursors.WaitCursor
                configDB.Open()
            Catch ex As Exception
                frmMain2.ShowDialog() ' Gives user a chance to change config location
                configDB.ConnectionString = ConfigCS
            Finally
                Me.Cursor = Cursors.Default
            End Try
        Loop

        If Trim(Company) = "None" Then
            frmCompany.ShowDialog()
        End If

        DBName = ""
        ServerName = ""

        'Screen Position
        GetWindowPos(Me, 15, 15)
        Me.Show()

        'RPT = Report1
        'RPT.PrinterSelect
        Dim pPrint As Boolean = pDialog.ShowDialog()
        'MessageBox.Show(pDialog.PrinterSettings.PrinterName)

        OpenData()

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim SectionName As String

        'Save file info to registry
        SectionName = "Data"
        SaveSetting(APPNAME, SectionName, "Company", Company)
        SaveSetting(APPNAME, SectionName, "CurCust", CurCust)
        SaveSetting(APPNAME, SectionName, "CurItem", CurItem)
        SaveSetting(APPNAME, SectionName, "CurType", CurType)

        SaveWindowPos(Me)

        Application.Exit()

    End Sub

    Function PrevInstance() As Boolean

        If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub cmdSelectDivision_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSelectDivision.Click

        frmCompany.ShowDialog()

        If DB Is Nothing Then
            Application.Exit()
        End If

    End Sub

    Private Sub cmdPrintSetup_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPrintSetup.Click

        Dim pPrint As Boolean = pDialog.ShowDialog()
        'MessageBox.Show(pDialog.PrinterSettings.PrinterName)

    End Sub

    Private Sub cmdFindCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdFindCustomer.Click

        frmFindCust.Show()

    End Sub

    Private Sub cmdViewCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdViewCustomer.Click

        frmViewCust.Show()

    End Sub

    Private Sub cmdTaxCode_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdTaxCode.Click

        frmTax.Show()

    End Sub

    Private Sub cmdCategories_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCategories.Click

        frmCat.Show()

    End Sub

    Private Sub cmdRouteMaster_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRouteMaster.Click

        frmRouteMast.Show()

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdExit.Click

        Application.Exit()

    End Sub

    Private Sub cmdPurge_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPurge.Click

        frmPurge.Show()

    End Sub

    Private Sub cmdCustomerMaster_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCustomerMaster.Click

        frmCust.Show()

    End Sub

    Private Sub cmdDepartmentsRoutes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDepartmentsRoutes.Click

        frmDept.Show()
        'frmDeptTest.Show()


    End Sub

    Private Sub cmdItemsStandingOrders_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItemsStandingOrders.Click

        frmRentOrd.Show()

    End Sub

    Private Sub cmdSurchargesDiscounts_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSurchargesDiscounts.Click

        frmCustSurcharge.Show()

    End Sub

    Private Sub cmdDeliveryQuantities_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDeliveryQuantities.Click

        frmDelQty.Show()

    End Sub

    Private Sub cmdSalesHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSalesHistory.Click

        frmSOHist.Show()

    End Sub

    Private Sub cmdViewOldInvoice_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdViewOldInvoice.Click

        frmInvHist.Show()

    End Sub

    Private Sub cmdItemHistory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItemHistory.Click

        frmROHist.Show()

    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCalculate.Click

        frmDayCalc.Show()

    End Sub

    Private Sub cmdUndoCalculations_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdUndoCalculations.Click

        frmUndo.Show()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdFind.Click

        frmFindInvoice.Show()

    End Sub

    Private Sub cmdView_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdView.Click

        'frmInvoice.Show

    End Sub

    Private Sub cmdNewInvoice_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdNewInvoice.Click

        CurInvoice = -1
        'frmInvHead.Show

    End Sub

    Private Sub cmdHeaders_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdHeaders.Click

        'frmInvHead.Show

    End Sub

    Private Sub cmdItems_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItems.Click

        frmInvItem.Show()

    End Sub

    Private Sub cmdRebill_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRebill.Click

        frmInvRebill.Show()

    End Sub

    Private Sub cmdHolidaySchedule_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdHolidaySchedule.Click

        frmHoliday.Show()

    End Sub

    Private Sub cmdTripsheetsRouteLoad_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdTripsheetsRouteLoad.Click

        frmRptDay1.Show()

    End Sub

    Private Sub cmdInvoices_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdInvoices.Click

        frmRptInv.Show()

    End Sub

    Private Sub cmdLabels_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdLabels.Click

        'frmRptLabel.Show

    End Sub

    Private Sub cmdRecapVolume_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRecapVolume.Click

        'On Error Resume Next
        frmRptDay2.Show()

    End Sub

    Private Sub cmdProcess_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdProcess.Click

        'On Error Resume Next
        frmDayProc.Show()

    End Sub

    Private Sub cmdCustomerReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCustomerReports.Click

        frmRptCustNew.Show()

    End Sub

    Private Sub cmdExceptions_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdExceptions.Click

        frmRptExcept.Show()

    End Sub

    Private Sub cmdAverageRevenue_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAverageRevenue.Click

        frmRptAvgRev.Show()

    End Sub

    Private Sub cmdMiscReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdMiscReports.Click

        frmmiscrpt.Show()

    End Sub

    Private Sub cmdSalesTaxReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSalesTaxReports.Click

        frmsalestaxreports.Show()

    End Sub

    Private Sub cmdSalesReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSalesReports.Click

        frmRptSales.Show()

    End Sub

    Private Sub cmdItemUsage_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItemUsage.Click

        frmRptItemUse.Show()

    End Sub

    Private Sub cmdItemReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItemReports.Click

        frmitemreports.Show()

    End Sub

    Private Sub cmdDeptList_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDeptList.Click

        frmdeptlist.Show()

    End Sub

    Private Sub cmdRouting_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRouting.Click

        frmRoute.Show()

    End Sub

    Private Sub cmdFindItem_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdFindItem.Click

        frmFindItem.Show()

    End Sub

    Private Sub cmdViewItem_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdViewItem.Click

        frmViewItem.Show()

    End Sub

    Private Sub cmdVendors_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdVendors.Click

        frmVend.Show()

    End Sub

    Private Sub cmdItemMaster_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdItemMaster.Click

        frmItem.Show()

    End Sub

    Private Sub cmfPurchaseOrderReceipts_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmfPurchaseOrderReceipts.Click

        frmPONew.Show()

    End Sub

    Private Sub cmdPhysicalInventory_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPhysicalInventory.Click

        'On Error Resume Next
        frmInvPhys.Show()

    End Sub

    Private Sub cmdInventoryAdjustments_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdInventoryAdjustments.Click

        frmInvAdj.Show()

    End Sub

    Private Sub cmdReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdReports.Click

        frmInvRpt.Show()

    End Sub


    Private Sub cmdSalesPeople_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSalesPeople.Click

        frmSlsmn.Show()

    End Sub

    Private Sub cmdRates_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRates.Click

        'frmCommRate.Show

    End Sub

    Private Sub cmdProcessRentals_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdProcessRentals.Click

    End Sub

    Private Sub cmdRevenueReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRevenueReports.Click

    End Sub

    Private Sub cmdCommissionReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCommissionReports.Click

    End Sub

    Private Sub mnuCommission_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles mnuCommission.Click

        '    If Not CommFlag Then
        '        frmPW.Show 1
        '        If CommFlag Then
        '            SendKeys "%M"
        '            Exit Sub
        '        End If
        '    End If

        '    If CommFlag Then
        '        mnuCommSales.Enabled = True
        '        mnuCommRate.Enabled = True
        '        mnuCommEdit.Enabled = True
        '        mnuCommLoadR.Enabled = True
        '        mnuCommRptRev.Enabled = True
        '        mnuCommRptComm.Enabled = True
        '    End If

    End Sub

    Private Sub cmdGeneralSearch_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdGeneralSearch.Click

        frmFindCustSrch.Show()

    End Sub

    Private Sub cmdAreaSearch_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAreaSearch.Click

        frmZipSearch.Show()

    End Sub
End Class
