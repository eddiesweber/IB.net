Public Class frmPONew2

    Dim Dt As Date

    Private Sub frmPONew2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dt = frmPONew.RDate
        datDate.Value = Format(Dt, "Short Date")

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        frmPONew.RDate = datDate.Value
        frmPONew.RCancel = False

        Me.Close()

    End Sub

    Private Sub cmdButton_Click(sender As Object, e As EventArgs) Handles cmdButton.Click

        frmPONew.RCancel = True

        Me.Close()

    End Sub

End Class