Imports System.ComponentModel

Public Class frmRouteEdit

    Private Sub frmRouteEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer, j As Integer, s As String

        GetWindowPos(Me, 66, 66)
        'GetColWidths Me, TDBGrid1

        'Data1.ConnectionString = CS

        GetData()

        'Load list boxes
        For i = 1 To 2
            For j = 1 To 5
                If i = 1 Then s = "A" Else s = "B"
                s = s & j
                lstDays0.Items.Add(s)
            Next j
        Next i
        For i = 1 To 4
            For j = 1 To 5
                s = i
                s = s & j
                lstDays1.Items.Add(s)
            Next j
        Next i

    End Sub

    Private Sub frmRouteEdit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)
        'SaveColWidths Me, TDBGrid1

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub

    Sub GetData()

        Dim q As String
        Dim q1 As String
        Dim OptVal As Integer
        Dim SavCust As Long
        Dim SavDept As Integer
        Dim SavOld As String
        'Dim SavOld As String * 2
        Dim SavWeek As Integer
        Dim opt1 As Int16
        Dim opt2 As Int16
        Dim intRow As Int32

        Me.Cursor = Cursors.WaitCursor

        'This does not work in original program
        'SavCust = rs!CUST_NUM
        'SavDept = rs!DEPT
        'SavOld = rs!OLD_WEEKDAY
        'SavWeek = rs!Week
        'rs.Close

        If optSort1.Checked = True Then
            opt1 = 1
        Else
            opt1 = 0
        End If
        If optSort2.Checked = True Then
            opt2 = 1
        Else
            opt2 = 0
        End If
        OptVal = opt1 + 2 * opt2
        'OptVal = Math.Abs(optSort1.Text) + 2 * Math.Abs(optSort2.Text)

        SpGetRouteTempTableAdapter.Connection.ConnectionString = CS
        SpGetRouteTempTableAdapter.Fill(DsspGetRouteTemp.spGetRouteTemp, OptVal)
        '    q = "spGetRouteTemp " & OptVal
        '    Data1.RecordSource = q
        '    Data1.Enabled = True
        '    Data1.Refresh
        '    rs = Data1.Recordset
        '    TDBGrid1.Refresh

        If SavCust <> 0 Then
            'q = "CUST_NUM=" & SavCust '& " AND DEPT=" & SavDept & " AND OLD_WEEKDAY='" & SavOld & "'"

            'rs
            If SavWeek < 3 Then
                SpGetRouteTempBindingSource.MoveFirst()
                intRow = SpGetRouteTempBindingSource.Find("CUST_NUM", SavCust)

                If intRow >= 0 Then
                    SpGetRouteTempBindingSource.Position = intRow
                End If
            Else
                SpGetRouteTempBindingSource.MoveLast()
                intRow = SpGetRouteTempBindingSource.Find("CUST_NUM", SavCust)

                If intRow >= 0 Then
                    Do While SpGetRouteTempBindingSource.Position <= SpGetRouteTempBindingSource.Count
                        If DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("CUST_NUM") <> SavCust Then
                            SpGetRouteTempBindingSource.MovePrevious()
                            Exit Do
                        Else
                            If SpGetRouteTempBindingSource.Position < SpGetRouteTempBindingSource.Count Then
                                SpGetRouteTempBindingSource.MoveNext()
                            Else
                                Exit Do
                            End If
                        End If
                    Loop
                    SpGetRouteTempBindingSource.Position = intRow
                End If
                'rs.MoveLast
                'rs.Find q, 0, adSearchBackward
            End If
        End If

        Me.Cursor = Cursors.Default

    End Sub

End Class