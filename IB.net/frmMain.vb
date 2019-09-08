Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Configuration
Imports C1.Win.C1Command

Public Class frmMain

    Dim blnNoClick As Boolean = False

    Private Sub cmdVersion_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdVersion.Click

        MessageBox.Show("Version 3.03 - September 8th, 2019")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim command As New SqlCommand
        Dim blnConnected As Boolean = False
        Dim strSectionName As String
        Dim Result As DialogResult
        Dim blnExit As Boolean = False
        Dim strSQL As String

        If PrevInstance() Then
            Exit Sub
        End If

        CommFlag = False
        DataPath = Application.StartupPath()
        If Dir("ReportFolder.txt") <> "" Then
            RptPath = My.Computer.FileSystem.ReadAllText("ReportFolder.txt")
        Else
            RptPath = Application.StartupPath() '& "\reports"
        End If

        strSectionName = "Data"
        Company = GetSetting(APPNAME, strSectionName, "Company", "")
        Server = GetSetting(APPNAME, strSectionName, "Server", "")
        DBName = GetSetting(APPNAME, strSectionName, "DBName", "")
        Username = GetSetting(APPNAME, strSectionName, "Username", "")

        Try
            strLocation = "FML1.0"
            Dim wrapper As New Simple3Des("I1!n2@()")
            Password = wrapper.DecryptData(GetSetting(APPNAME, strSectionName, "Password", ""))
        Catch ex As Exception
            Password = ""
            Result = MessageBox.Show(Me, "Error in routine frmMain_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmMain_Load", vbOK)
            LogError(Me.Name, "frmMain_Load", strLocation, ex.Message)
        End Try

        'Screen Position
        GetWindowPos(Me, 15, 15)
        Me.Show()

        'OpenData()

        CurCust = GetSetting(APPNAME, strSectionName, "CurCust", 0)
        CurItem = GetSetting(APPNAME, strSectionName, "CurItem", 0)
        CurType = GetSetting(APPNAME, strSectionName, "CurType", "")
        CurVend = GetSetting(APPNAME, strSectionName, "CurVend", "")

        strPrinterName = GetSetting(APPNAME, "Printer", "DefaultPrinter", "")

        SelectPrinter(True)

        ' Check to see if we have a good connection to server
        If Server.Trim <> "" Then
            If InStr(1, Server, "windows.net") > 0 Then
                If Username.Trim <> "" And Password.Trim <> "" Then
                    ConfigCS = "Data Source=" & Server & ";Initial Catalog=IBGlobal;User ID=" & Username & ";Password=" & Password
                End If
            Else
                ConfigCS = "Data Source=" & Server & ";Initial Catalog=master;Integrated Security=True"
            End If
        End If

        If CheckConnectionServer() = False Then
            frmSetConnection.ShowDialog()
            Do While CheckConnectionServer() = False And blnExit = False
                Result = MessageBox.Show("Cannot connect to the server, do you want to try setup again?", "Connect to Server", MessageBoxButtons.YesNo)
                If Result = DialogResult.No Then
                    blnExit = True
                Else
                    frmSetConnection.ShowDialog()
                End If
            Loop

            If blnExit = True Then
                Me.Close()

                Exit Sub
            End If
        End If

        If DBName.Trim <> "" Then
            If InStr(1, Server, "windows.net") > 0 Then
                CS = "Data Source=" & Trim(Server) & ";Initial Catalog=" & Trim(DBName) & ";User ID=" & Username & ";Password=" & Password
            Else
                CS = "Integrated Security=True;Initial Catalog=" & Trim(DBName) & ";Data Source=" & Trim(Server)
            End If
        End If

        If CheckConnectionDivision() = False Then
            frmSetConnection.ShowDialog()
            Do While CheckConnectionDivision() = False And blnExit = False
                Result = MessageBox.Show("Cannot connect to the division db, do you want to try setup again?", "Connect to Server", MessageBoxButtons.YesNo)
                If Result = DialogResult.No Then
                    blnExit = True
                Else
                    frmSetConnection.ShowDialog()
                End If
            Loop

            If blnExit = True Then
                Me.Close()

                Exit Sub
            End If
        End If

        ' Get company (division) name
        Me.Text = ""
        strSQL = "Select * From Company where Company_ID='" & Company & "'"
        Using cmdCompany As New SqlCommand(strSQL, DB)
            Try
                strLocation = "FML2.0"
                Dim dataReader As SqlDataReader = cmdCompany.ExecuteReader()
                dataReader.Read()

                strLocation = "FML3.0"
                If dataReader.HasRows Then
                    Me.Text = "Indoor Billboard - " & dataReader.Item("Company_NM")
                    dataReader.Close()

                    'Rearrange CS the way Crystal likes
                    CryCS = "DSN=" & Trim(Server) & ";DSQ=" & Trim(Company) & ";UID=<<Use Integrated Security>>"
                Else
                    MessageBox.Show("Company " & Company & " not found in company table", "Company Name")
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine frmMain_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmMain_Load", vbOK)
                LogError(Me.Name, "frmMain_Load", strLocation, ex.Message)

                Exit Sub
            End Try
        End Using

    End Sub

    Private Sub cmdPrintSetup_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdPrintSetup.Click

        SelectPrinter(False)

    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveSettings()

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

        frmInvoice.Show()

    End Sub

    Private Sub cmdNewInvoice_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdNewInvoice.Click

        CurInvoice = -1
        frmInvHead.Show()

    End Sub

    Private Sub cmdHeaders_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdHeaders.Click

        frmInvHead.Show()

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

        'If Not CommFlag Then
        '    frmPW.ShowDialog()

        '    If CommFlag Then
        frmSlsmn.Show()
        '    End If
        'End If

    End Sub

    Private Sub cmdRates_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRates.Click

        frmCommRate.Show()

    End Sub

    Private Sub cmdProcessRentals_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdProcessRentals.Click

        frmRentComm.Show()

    End Sub

    Private Sub cmdRevenueReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRevenueReports.Click

    End Sub

    Private Sub cmdCommissionReports_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCommissionReports.Click

    End Sub

    Private Sub mnuCommission_Select(sender As Object, e As EventArgs) Handles mnuCommission.[Select]

        If Not CommFlag Then
            frmPW.ShowDialog()

            If CommFlag Then
                My.Computer.Keyboard.SendKeys("%M")
                Exit Sub
            End If
        End If

        If CommFlag Then
            cmdSalesPeople.Enabled = True
            cmdRates.Enabled = True
            cmdProcessRentals.Enabled = True
            cmdEditCommissions.Enabled = True
            cmdRevenueReports.Enabled = True
            cmdCommissionReports.Enabled = True
        End If

    End Sub

    Private Sub cmdGeneralSearch_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdGeneralSearch.Click

        frmFindCustSrch.Show()

    End Sub

    Private Sub cmdAreaSearch_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAreaSearch.Click

        frmZipSearch.Show()

    End Sub

    Private Sub cmdSetupConnectionToDB_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSetupConnectionToDB.Click

        frmSetConnection.ShowDialog()

    End Sub

    Private Sub cmdRestoreCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRestoreCustomer.Click

        frmRestoreCustomer.Show()

    End Sub

    Private Sub cmdAdagioExport_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAdagioExport.Click

        Dim strCSV As String
        Dim strSQL As String = "SELECT CUST_NUM, BILL_NAME, BILL_STR, CARE_OF, BILL_CTY, BILL_STATE, BILL_ZIP, PHONE, FAX_NO, MAIL_STATEMENT, EMAIL FROM CustomerMaster"
        Dim strFax As String
        Dim strPhone As String
        Dim objWriter As New System.IO.StreamWriter("xportcust.csv")
        Dim strCSZ As String

        Using connection As New SqlConnection(CS)
            strLocation = "CAEC1.0"
            Dim cmd As SqlCommand = New SqlCommand(strSQL, connection)

            Try
                Me.Cursor = Cursors.WaitCursor

                strLocation = "CAEC2.0"
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                If dataReader.HasRows = True Then
                    Do While dataReader.Read()
                        strLocation = "CAEC3.0"
                        If Not IsDBNull(dataReader.Item("FAX_NO")) Then
                            strFax = Replace(dataReader.Item("FAX_NO"), "-", "")
                            strFax = Replace(strFax, "(", "")
                            strFax = Trim(Replace(strFax, ")", ""))
                        Else
                            strFax = ""
                        End If

                        strLocation = "CAEC4.0"
                        If Not IsDBNull(dataReader.Item("PHONE")) Then
                            strPhone = Replace(dataReader.Item("PHONE"), "-", "")
                            strPhone = Replace(strPhone, "(", "")
                            strPhone = Trim(Replace(strPhone, ")", ""))
                        Else
                            strPhone = ""
                        End If

                        strLocation = "CAEC5.0"
                        strCSV = Chr(34) & dataReader.Item("EMAIL") & Chr(34)
                        strCSV = strCSV & ", " & Chr(34) & dataReader.Item("CUST_NUM").ToString & Chr(34)
                        strCSV = strCSV & ", " & Chr(34) & dataReader.Item("BILL_NAME") & Chr(34)

                        strLocation = "CAEC6.0"
                        If Not IsDBNull(dataReader.Item("BILL_STR")) Then
                            strCSV = strCSV & ", " & Chr(34) & dataReader.Item("BILL_STR") & Chr(34)
                        Else
                            strCSV = strCSV & ", " & Chr(34) & "" & Chr(34)
                        End If

                        strLocation = "CAEC7.0"
                        strCSZ = ""
                        If Not IsDBNull(dataReader.Item("BILL_CTY")) Then
                            strCSZ = dataReader.Item("BILL_CTY")
                        End If

                        If Not IsDBNull(dataReader.Item("BILL_STATE")) Then
                            strCSZ = Trim(strCSZ & " " & dataReader.Item("BILL_STATE"))
                        End If

                        If Not IsDBNull(dataReader.Item("BILL_ZIP")) Then
                            strCSZ = Trim(strCSZ & " " & dataReader.Item("BILL_ZIP"))
                        End If
                        strCSV = strCSV & ", " & Chr(34) & strCSZ & Chr(34)

                        strLocation = "CAEC8.0"
                        strCSV = strCSV & ", " & Chr(34) & strPhone & Chr(34)
                        strCSV = strCSV & ", " & Chr(34) & strFax & Chr(34)

                        strLocation = "CAEC9.0"
                        If Not IsDBNull(dataReader.Item("CARE_OF")) Then
                            strCSV = strCSV & ", " & Chr(34) & dataReader.Item("CARE_OF") & Chr(34)
                        Else
                            strCSV = strCSV & ", " & Chr(34) & "" & Chr(34)
                        End If

                        strLocation = "CAEC10.0"
                        If dataReader.Item("MAIL_STATEMENT") = True Then
                            strCSV = strCSV & ", " & Chr(34) & "1" & Chr(34)
                        Else
                            strCSV = strCSV & ", " & Chr(34) & "0" & Chr(34)
                        End If
                        strLocation = "CAEC11.0"
                        strCSV = strCSV & ", " & Chr(34) & dataReader.Item("EMAIL") & Chr(34)

                        strLocation = "CAEC12.0"
                        objWriter.Write(strCSV & vbNewLine)
                    Loop
                End If
                dataReader.Close()
                objWriter.Close()

                MessageBox.Show("Finished Export")

                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Result = MessageBox.Show(Me, "Error in routine UpdateInvoiceQty (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "UpdateInvoiceQty", vbOK)
                LogError(Me.Name, "UpdateInvoiceQty", strLocation, ex.Message)
            End Try
        End Using

    End Sub

    Private Sub cmdEditCommissions_Click(sender As Object, e As ClickEventArgs) Handles cmdEditCommissions.Click

        frmCommEdit.Show()

    End Sub
End Class
