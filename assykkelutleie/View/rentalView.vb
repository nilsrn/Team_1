Imports MySql.Data.MySqlClient
Public Class rentalView
    Private Function GetAllCustomer() 'Returns a DataTable with all customers.
        Dim customer As New Customer()
        Dim customerTable As DataTable = DbManager.GetAll(customer)
        Return customerTable
    End Function
    Private Sub PutCustomer(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows

            firstnametxt.Text = row("FirstName")
            surnametxt.Text = row("Surname")
            mailtxt.Text = row("Email")
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim customerSearch As New Customer()
        Dim customer As String = txtCustomerSearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutLbCustomer(customerTable)
        If txtCustomerSearch.Text = "" Then
            PutLbCustomer(GetAllCustomer)
        End If
    End Sub
End Class