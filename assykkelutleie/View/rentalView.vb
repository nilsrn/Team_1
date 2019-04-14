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
        Dim customer As String = txtsearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutCustomer(customerTable)

    End Sub
    Private Sub CbPutComboBox() 'Populates the comboboxes.

        Dim bicycletype As New BicycleType()
        Dim location As New Location()
        Dim equipment As New Equipment()


        pickbike.DataSource = DbManager.GetAll(bicycletype)
        pickequipment.DataSource = DbManager.GetAll(Equipment)
        extradition.DataSource = DbManager.GetAll(location)
        filing.DataSource = DbManager.GetAll(location)

        pickbike.DisplayMember = "Name"
        pickequipment.DisplayMember = "Name"
        extradition.DisplayMember = "Name"
        filing.DisplayMember = "Name"

        pickbike.ValueMember = "Name"
        pickequipment.ValueMember = "Name"
        extradition.ValueMember = "Name"
        filing.ValueMember = "Name"

    End Sub
End Class