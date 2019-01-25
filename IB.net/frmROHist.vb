Option Explicit On
Imports System.ComponentModel

Public Class frmROHist

    Dim Startdate As Date

    Private Sub frmROHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        If Dir("frmROHistC1TrueDBGrid1.xml") <> "" Then
            C1TrueDBGrid1.LoadLayout("frmROHistC1TrueDBGrid1.xml")
        End If

        Me.SpGetRentHistTableAdapter.Connection.ConnectionString = CS

        Startdate = DateAdd("yyyy", -1, Now())
        datSince.Value = Startdate

        lblCurCust.Text = CurCust

    End Sub

    Private Sub frmROHist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

        C1TrueDBGrid1.SaveLayout("frmROHistC1TrueDBGrid1.xml")

    End Sub

    Private Sub GetData()

        Dim q As String

        If IsDate(datSince.Value) And CurCust > 0 Then
            Me.SpGetRentHistTableAdapter.Fill(DsROHist.spGetRentHist, CurCust, datSince.Value)
        End If

    End Sub

    Private Sub datSince_Click(sender As Object, e As EventArgs) Handles datSince.Click

        datSince_TextChanged(sender, e)

    End Sub

    Private Sub datSince_TextChanged(sender As Object, e As EventArgs) Handles datSince.TextChanged

        Dim NewDate As Date

        If IsDate(datSince.Value) Then
            NewDate = datSince.Value
        End If

        If NewDate <> Startdate Then
            Startdate = NewDate
            GetData()
        End If

    End Sub

    Private Sub lblCurCust_TextChanged(sender As Object, e As EventArgs) Handles lblCurCust.TextChanged

        txtCust.Text = CStr(CurCust)
        txtCustName.Text = GetCustName()

    End Sub

    Private Sub txtCust_TextChanged(sender As Object, e As EventArgs) Handles txtCust.TextChanged

        GetData()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click

        frmFindCust.Show()
        frmFindCust.BringToFront()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Close()

    End Sub


End Class