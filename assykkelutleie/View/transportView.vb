Imports MySql.Data.MySqlClient
Public Class transportView
    Private Sub PutLbRentalID(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbRentalID.DataSource = table
        lbRentalID.DisplayMember = "RentalID"
        lbRentalID.ValueMember = "RentalID"
    End Sub
    Private Function GetAllRentals() 'Returns a DataTable with all rentals.
        Dim rental As New Rentals()
        Dim rentalsTable As DataTable = DbManager.GetAll(rental)
        Return rentalsTable
    End Function

    Private Sub transportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        PutLbRentalID(GetAllRentals)
    End Sub
End Class