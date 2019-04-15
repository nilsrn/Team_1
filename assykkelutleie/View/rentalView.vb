Imports MySql.Data.MySqlClient
Public Class rentalView
    Private Function GetAllCustomer() 'Returns a DataTable with all customers.
        Dim customer As New Customer()
        Dim customerTable As DataTable = DbManager.GetAll(customer)
        Return customerTable
    End Function
    Private Function GetAllRentals() 'Returns a DataTable with all customers.
        Dim rentals As Rentals()
        Dim rentalTable As DataTable = DbManager.GetAll(rentals)
        Return rentalTable
    End Function
    Private Sub PutCustomer(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows

            firstnametxt.Text = row("FirstName")
            surnametxt.Text = row("Surname")
            mailtxt.Text = row("Email")
            presentcustomerid.Text = row("CustomerID")
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
    Private Sub PutLbRentals(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbrentals.DataSource = table
        lbrentals.DisplayMember = "RentalID"
        lbrentals.ValueMember = "RentalID"
    End Sub

    Private Sub rentalView_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CbPutComboBox()
        PutLbRentals(GetAllRentals)
    End Sub

    Private Sub rentalcomplete_Click(sender As Object, e As EventArgs) Handles rentalcomplete.Click

        Dim BicycleType, equipment, PickupLocation, DeliveryLocation As String
        Dim PickupTime, DeliveryTime As Date
        Dim CustomerID As Integer

        Try

            CustomerID = presentcustomerid.Text
            BicycleType = pickbike.SelectedValue
            equipment = pickequipment.SelectedValue
            PickupLocation = extradition.SelectedValue
            DeliveryLocation = filing.SelectedValue
            PickupTime = extraditiondate.Value.ToString()
            DeliveryTime = filing.ValueMember.ToString()


            Dim updateRentals As New Rentals(CustomerID, DeliveryLocation, DeliveryTime, PickupLocation, PickupTime)
            Dim updateRented As New RentedBicycles()
            DbManager.InsertOrUpdate(updateRentals)
        Catch ex As Exception
            End Try


    End Sub
End Class