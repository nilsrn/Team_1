Imports MySql.Data.MySqlClient
Public Class transportView
    Private Sub PutLbRentalID(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbRentalID.DataSource = table
        lbRentalID.DisplayMember = "RentalID"
        lbRentalID.ValueMember = "RentalID"
    End Sub
    Private Function GetAllRentals() 'Returns a DataTable with all rentals.
        Dim rental As New Rentals()
        Dim rentalTable As DataTable = DbManager.GetAll(rental)
        Return rentalTable
    End Function
    Private Sub PutRental(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtRentalID.Text = row("RentalID")
            txtPickupLocation.Text = row("PickupLocation")
            txtPickupTime.Text = row("PickupTime")
            txtDeliveryLocation.Text = row("DeliveryLocation")
        Next
    End Sub

    Private Sub transportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        PutLbRentalID(GetAllRentals)
    End Sub
    Private Sub BtnBicyclesSearch_Click(sender As Object, e As EventArgs) Handles btnBicyclesSearch.Click 'Updates the listbox according to the user input.
        Dim rentalSearch As New Rentals()
        Dim rental As String = txtRentalSearch.Text
        Dim rentalTable As DataTable = DbManager.GetSpecific(rentalSearch, rental)
        PutLbRentalID(rentalTable)
        If txtRentalSearch.Text = "" Then
            PutLbRentalID(GetAllRentals)
        End If
    End Sub
    Private Sub LbRentalID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRentalID.SelectedIndexChanged 'Populates the textboxes based on the chosen rentalID in the listbox.
        Dim rentalSearch As New Rentals()
        PutRental(DbManager.GetSpecific(rentalSearch, lbRentalID.SelectedValue.ToString()))
    End Sub

End Class