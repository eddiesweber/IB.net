Imports System.IO
Imports System.Data.SqlClient

Module modError

    Public Sub LogError(strForm As String, strModule As String, strPosition As String, strErrorDescription As String)

        Dim strQuery As String
        Dim strComputerName As String = System.Windows.Forms.SystemInformation.ComputerName
        Dim strUserName As String = System.Windows.Forms.SystemInformation.UserName

        strErrorDescription = Replace(strErrorDescription, "'", "")
        strErrorDescription = Replace(strErrorDescription, Chr(34), "")

        strQuery = "INSERT INTO ErrorLog (Application, ErrorDate, Form, Module, Position, ErrorDescription, ComputerName, UserName)"
        strQuery = strQuery & " VALUES ('IB.net', '" & Now() & "', '" & strForm & "', '" & strModule & "', '" & strPosition & "', '" & strErrorDescription & "', '" & strComputerName & "', '" & strUserName & "')"

        Using Command As New SqlCommand(strQuery, configDB)
            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                If Not File.Exists("ErrorLog.txt") Then
                    Using sw As StreamWriter = File.CreateText("ErrorLog.txt")
                        sw.WriteLine("Date" & vbTab & "Form" & vbTab & "Module" & vbTab & "Position" & vbTab & "Error Description" & vbTab & "Computer Name" & vbTab & "Username")
                        sw.WriteLine(Now() & vbTab & strForm & vbTab & strModule & vbTab & strPosition & vbTab & strErrorDescription & vbTab & strComputerName & vbTab & strUserName)
                    End Using
                Else
                    Using sw As StreamWriter = File.AppendText("ErrorLog.txt")
                        sw.WriteLine(Now() & vbTab & strForm & vbTab & strModule & vbTab & strPosition & vbTab & strErrorDescription & vbTab & strComputerName & vbTab & strUserName)
                    End Using
                End If
            End Try
        End Using

    End Sub

End Module
