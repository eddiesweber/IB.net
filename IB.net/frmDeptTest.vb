Public Class frmDeptTest
    Private Sub frmDeptTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustomerDepartmentTableAdapter.Fill(DsCustomerDepartment.CustomerDepartment, 1008)

    End Sub
End Class