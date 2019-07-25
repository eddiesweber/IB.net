Option Explicit On

Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Imports System.Data.SqlClient

Public Class frmRouteEdit

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' TEST HARD 
    Private Sub frmRouteEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer, j As Integer, s As String

        GetWindowPos(Me, 66, 66)

        If Dir("frmRouteEditTDBGrid1.xml") <> "" Then
            TDBGrid1.LoadLayout("frmRouteEditTDBGrid1.xml")
        End If

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

    Private Sub frmRouteEdit_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        TDBGrid1.SaveLayout("frmRouteEditTDBGrid1.xml")

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

        If DsspGetRouteTemp.spGetRouteTemp.Rows.Count > 0 Then
            SavCust = DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("CUST_NUM")
            SavDept = DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("DEPT")
            SavOld = DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("OLD_WEEKDAY")
            SavWeek = DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("Week")
        End If

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

        Try
            strLocation = "GD1.0"
            SpGetRouteTempTableAdapter.Connection.ConnectionString = CS
            SpGetRouteTempTableAdapter.Fill(DsspGetRouteTemp.spGetRouteTemp, OptVal)
            '    q = "spGetRouteTemp " & OptVal
            '    Data1.RecordSource = q
            '    Data1.Enabled = True
            '    Data1.Refresh
            '    rs = Data1.Recordset
            '    TDBGrid1.Refresh

            If SavCust <> 0 Then
                If SavWeek < 3 Then
                    strLocation = "GD2.0"
                    SpGetRouteTempBindingSource.MoveFirst()
                    intRow = SpGetRouteTempBindingSource.Find("CUST_NUM", SavCust)

                    strLocation = "GD3.0"
                    If intRow >= 0 Then
                        SpGetRouteTempBindingSource.Position = intRow
                    End If
                Else
                    strLocation = "GD4.0"
                    SpGetRouteTempBindingSource.MoveLast()
                    intRow = SpGetRouteTempBindingSource.Find("CUST_NUM", SavCust)

                    If intRow >= 0 Then
                        Do While SpGetRouteTempBindingSource.Position <= SpGetRouteTempBindingSource.Count
                            strLocation = "GD5.0"
                            If DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("CUST_NUM") <> SavCust Then
                                SpGetRouteTempBindingSource.MovePrevious()
                                Exit Do
                            Else
                                strLocation = "GD6.0"
                                If SpGetRouteTempBindingSource.Position < SpGetRouteTempBindingSource.Count Then
                                    SpGetRouteTempBindingSource.MoveNext()
                                Else
                                    Exit Do
                                End If
                            End If
                        Loop
                        strLocation = "GD7.0"
                        SpGetRouteTempBindingSource.Position = intRow
                    End If
                    'rs.MoveLast
                    'rs.Find q, 0, adSearchBackward
                End If
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine GetData (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "GetData", vbOK)
            LogError(Me.Name, "GetData", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub lstDays0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDays0.SelectedIndexChanged

        ' Does this actually get called?  Listboxes are disabled
        'Dim L As ListBox

        'L = lstDays(Index)

        'If L.Visible Then
        '    TDBGrid1.Columns(2).Text = L.List(L.ListIndex)
        '    L.Visible = False

        '    'TDBGrid1.SetFocus
        '    'TDBGrid1_AfterColUpdate 2
        'End If

    End Sub

    Private Sub optSort0_CheckedChanged(sender As Object, e As EventArgs) Handles optSort0.CheckedChanged, optSort2.CheckedChanged, optSort1.CheckedChanged

        GetData()

    End Sub

    Private Sub TDBGrid1_AfterColUpdate(sender As Object, e As ColEventArgs) Handles TDBGrid1.AfterColUpdate

        Dim s As String, D As Integer, W As Integer

        If e.ColIndex = 2 Then
            'Handle changed weekday
            s = UCase(TDBGrid1.Columns(4).Text)   ' This should be 4, not 2 since we rearranged the grid
            D = Microsoft.VisualBasic.Right(s, 1)
            W = TDBGrid1.Columns(1).Text
            If Microsoft.VisualBasic.Left(s, 1) = "A" Then
                If W = 2 Then W = 1
                If W = 4 Then W = 3
            ElseIf Microsoft.VisualBasic.Left(s, 1) = "B" Then
                If W = 1 Then W = 2
                If W = 3 Then W = 4
            Else
                W = Microsoft.VisualBasic.Left(s, 1)
            End If

            TDBGrid1.Columns(0).Text = D
            TDBGrid1.Columns(1).Text = W
        End If

        TDBGrid1.Update()

    End Sub

    Private Sub TDBGrid1_AfterUpdate(sender As Object, e As EventArgs) Handles TDBGrid1.AfterUpdate

        Dim ADOCmd As New ADODB.Command, q As String, q1 As String, W As Integer, W2 As Integer

        Me.Cursor = Cursors.WaitCursor

        'Change other instance of biweekly
        Try
            strLocation = "TGA1.0"
            If Microsoft.VisualBasic.Left(DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("Weekday"), 1) >= "A" Then
                q = " Where CUST_NUM=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("CUST_NUM") &
                " AND DEPT=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("DEPT")

                strLocation = "TGA2.0"
                W = DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("Week")
                If W < 3 Then
                    q = q & " AND WEEK>2"
                    W2 = W + 2
                Else
                    q = q & " AND WEEK<3"
                    W2 = W - 2
                End If

                strLocation = "TGA3.0"
                q = q & " And OLD_ROUTE=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("OLD_ROUTE") &
                    " AND OLD_SEQUENCE=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("OLD_SEQUENCE")
                strLocation = "TGA4.0"
                q1 = "Update RouteTemp Set [Week]=" & W2 & ",[Day]=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("Day") &
                ",[WEEKDAY]='" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("Weekday") & "',"
                strLocation = "TGA5.0"
                q1 = q1 & "[ROUTE]=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("ROUTE") &
                ",[SEQUENCE]=" & DsspGetRouteTemp.spGetRouteTemp.Rows(SpGetRouteTempBindingSource.Position)("SEQUENCE")
                q1 = q1 & q

                strLocation = "TGA6.0"
                Using connection As New SqlConnection(CS)
                    strLocation = "TGA7.0"
                    Dim cmd As SqlCommand = New SqlCommand(q1, connection)
                    connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
                'With ADOCmd
                '    .CommandText = q1
                '    .ActiveConnection = CS
                '    .Execute()
                'End With
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Result = MessageBox.Show(Me, "Error in routine TDBGrid1_AfterUpdate (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "TDBGrid1_AfterUpdate", vbOK)
            LogError(Me.Name, "TDBGrid1_AfterUpdate", strLocation, ex.Message)
        End Try

        Me.Cursor = Cursors.Default

        Timer1.Enabled = True

    End Sub

End Class