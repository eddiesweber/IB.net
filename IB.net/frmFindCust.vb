'Option Explicit On

Imports System.Data.SqlClient

Public Class frmFindCust

    Public intCustNum(2500) As Integer
    Public strCustName(2500) As String

    Private Sub frmFindCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 333, 66)
        Me.Show()

        GetData()

    End Sub

    Private Sub GetData()

        Dim Result As DialogResult
        Dim intCustomers As Integer

        intCustomers = 0

        ' Fill customer numbers listbox
        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("spGetCustsNum", connection)
            cmd.CommandType = CommandType.StoredProcedure

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                lstCustNum.ClearSelected()

                Do While dataReader.Read()
                    lstCustNum.Items.Add(dataReader(0))

                    ' Also load array for lookups when lists are clicked
                    intCustomers = intCustomers + 1
                    intCustNum(intCustomers) = dataReader(0)
                    strCustName(intCustomers) = dataReader(1)

                Loop
                dataReader.Close()

            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting the customer numbers" & vbNewLine & "Error : " & ex.Message, "Getting Customer Numbers", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("spGetCustsAlpha", connection)
            cmd.CommandType = CommandType.StoredProcedure

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                lstCustName.ClearSelected()

                Do While dataReader.Read()
                    lstCustName.Items.Add(dataReader(1))
                Loop
                dataReader.Close()

            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting the customer names" & vbNewLine & "Error : " & ex.Message, "Getting Customer Names", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using

    End Sub

    Private Sub lstCustNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustNum.SelectedIndexChanged

        Dim intCompanies As Integer

        ' Change lstCustName to match customer number
        intCompanies = Array.IndexOf(intCustNum, lstCustNum.SelectedItem)

        lstCustName.SelectedIndex = lstCustName.FindStringExact(strCustName(intCompanies))

    End Sub

    Private Sub lstCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustName.SelectedIndexChanged

        Dim intCompanies As Integer

        ' Change lstCustName to match customer number
        intCompanies = Array.IndexOf(strCustName, lstCustName.SelectedItem)

        lstCustNum.SelectedIndex = lstCustNum.FindStringExact(Trim(Str(intCustNum(intCompanies))))

    End Sub

    Private Sub lstCustName_DoubleClick(sender As Object, e As EventArgs) Handles lstCustName.DoubleClick

        cmdSelect_Click(sender, e)

    End Sub

    Private Sub frmFindCust_Leave(sender As Object, e As EventArgs) Handles Me.Leave

        SaveWindowPos(Me)

    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click

        Dim frm As Form

        CurCust = CLng(lstCustNum.SelectedItem)

        For Each frm In My.Application.OpenForms
            ' Alternate way to get "textbox" control list
            ' Dim ctrls() As Control = frm.Controls.Find("TextBox1", True)
            For Each ctl As Control In frm.Controls
                If TypeOf ctl Is Label Then
                    If ctl.Name = "lblCurCust" Then
                        ctl.Text = CurCust
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        GetData()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Hide()

    End Sub
End Class