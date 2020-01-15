Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            strLocation = "FLL1.0"
            GetWindowPos(Me, 15, 15)

            strLocation = "FLL2.0"
            txtUserName.Text = Username.Trim
            txtPassword.Text = Password.Trim
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine frmLogin_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmLogin_Load", vbOK)
            LogError(Me.Name, "frmLogin_Load", strLocation, ex.Message)
        End Try

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Try
            strLocation = "CSC1.0"
            Username = txtUserName.Text.Trim
            Password = txtPassword.Text.Trim

            strLocation = "CSC2.0"
            SaveSettings()
            SaveWindowPos(Me)

            Me.Dispose()
        Catch ex As Exception
            Result = MessageBox.Show(Me, "Error in routine frmLogin_Load (" & strLocation & ")" & vbNewLine & "Error : " & ex.Message, "frmLogin_Load", vbOK)
            LogError(Me.Name, "frmLogin_Load", strLocation, ex.Message)
        End Try

    End Sub

End Class