Imports System.Data.SqlClient

Public Class frmPurge

    Private Sub frmPurge_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetWindowPos(Me, 33, 33)
        LoadScreen()

    End Sub

    Sub LoadScreen()

        Dim i As Integer
        Dim LineSpace As Integer = 16
        Dim L As Integer
        Dim Result As DialogResult
        Dim newLabel As New Label

        Using connection As New SqlConnection(CS)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Purge", connection)

            Try
                connection.Open()
                Dim dataReader As SqlDataReader = cmd.ExecuteReader()

                Do While dataReader.Read()
                    i = dataReader("Key")
                    L = lblName0.Top + (i - 1) * LineSpace

                    newLabel.Name = "Label" + i.ToString
                    'newLabel.Left = lblName0.Location.X
                    'newLabel.Top = lblName0.Location.Y + (LineSpace * i)
                    newLabel.Location = New Point(lblName0.Location.Y + (LineSpace * i), 3)
                    newLabel.Text = dataReader("Description")
                    newLabel.Visible = True

                    Me.Controls.Add(newLabel)
                Loop
                dataReader.Close()

                '                'Load the form
                '                While Not PRS.EOF
                '                    i = PRS!Key
                '                    L = lblname(0).Top + (i - 1) * LineSpace
                '                    Load lblname(i)
                '    With lblname(i)
                '                        .Top = L
                '                        .Caption = PRS!Description
                '                        .Visible = True
                '                    End With
                '                    Load lblMonth(i)
                '    With lblMonth(i)
                '                        .Top = L
                '                        .Caption = PRS!Months
                '                        .Visible = True
                '                    End With
                '                    Load lblCount(i)
                '    With lblCount(i)
                '                        .Top = L
                '                        .Caption = ""
                '                        .Visible = True
                '                    End With
                '                    PRS.MoveNext
                'Wend
                'Me.Height = L + 1300





            Catch ex As Exception
                Result = MessageBox.Show(Me, "Error getting the customer numbers" & vbNewLine & "Error : " & ex.Message, "Getting Customer Numbers", vbOKCancel)
                If Result = vbCancel Then
                    Exit Sub
                Else
                    Exit Try
                End If
            End Try

        End Using



    End Sub

End Class