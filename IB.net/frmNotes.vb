Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmNotes

    Dim rs As ADODB.Recordset
    Dim buserchange As Boolean
    Dim bInit As Boolean
    Dim bCancel As Boolean

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetWindowPos(Me, 66, 66)

        buserchange = False
        bInit = True

        GetData()

        lblName.Text = "NOTES FOR CUSTOMER# " & CurCust


    End Sub

    Private Sub frmNotes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        SaveWindowPos(Me)

    End Sub

    Public Sub GetData()

        '        Dim q As String
        '        If CurCust > 0 Then
        '            q = "Select comments from CustomerMaster Where Cust_Num=" & CurCust
        '            Data1.RecordSource = q
        '            Data1.Enabled = True
        '            Data1.Refresh
        '           Set rs = Data1.Recordset
        '       End If

        Dim result As String
        Dim strTemp As String
        Dim queryString As String = "Select comments from CustomerMaster Where Cust_Num=" & CurCust

        If CurCust > 0 Then
            Using connection As New SqlConnection(CS)
                Dim cmd As SqlCommand = New SqlCommand(queryString, connection)

                Try
                    connection.Open()
                    'Dim dataReader As SqlDataReader = cmd.ExecuteScalar()
                    strTemp = cmd.ExecuteScalar().ToString
                    'MessageBox.Show(strTemp)
                    lblNotes.Text = strTemp

                    'dataReader.Close()
                Catch ex As Exception
                    result = MessageBox.Show(Me, "Error getting the customer notes" & vbNewLine & "Error : " & ex.Message, "Getting Customer Notes", vbOKCancel)
                    LogError(Me.Name, "GetData", "1.0", ex.Message)
                    If result = vbCancel Then
                        Exit Sub
                    Else
                        Exit Try
                    End If
                End Try

            End Using
        End If

    End Sub

    Public Sub closedata()

        '    If rs Is Nothing Then Exit Sub
        '       bCancel = False
        '       rs.Close()

        '       If Not bCancel Then
        '           Set rs = Nothing
        '           On Error Resume Next
        '        End If
        '       bCancel = False

    End Sub
End Class