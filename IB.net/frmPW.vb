Public Class frmPW

    Private Sub frmPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = frmMain.Left + 213
        Me.Top = frmMain.Top + 53
        'Me.Move frmMain.Left + 3200, frmMain.Top + 800

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        If txtPW.Text = COMMPW Then
            CommFlag = True
            Me.Close()
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub
End Class