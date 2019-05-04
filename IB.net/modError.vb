Imports System.Data.SqlClient

Module modError

    Public Sub LogError(strForm As String, strModule As String, strPosition As String, strErrorDescription As String)

        Dim q As String
        Dim strComputerName As String = System.Windows.Forms.SystemInformation.ComputerName
        Dim strUserName As String = System.Windows.Forms.SystemInformation.UserName

        q = "INSERT INTO ErrorLog (ErrorDate, Form, Module, Position, ErrorDescription, ComputerName, UserName)"
        q = q & " VALUES ('" & Now() & "', '" & strForm & "', '" & strModule & "', '" & strPosition & "', '" & strErrorDescription & "', '" & strComputerName & "', '" & strUserName & "')"

        Using Command As New SqlCommand(q, configDB)
            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                'MsgBox("Error: " & ex.Message)
            End Try
        End Using

    End Sub

End Module
