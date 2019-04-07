Public Class adminView 'Nils

    Private Sub adminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        PutLbLocations(GetAllLocations)
        CbPutUserLocations()
    End Sub

    Private Sub btnUserSearch_Click(sender As Object, e As EventArgs) Handles btnUserSearch.Click 'Searches for useraccounts based on the username in the textboxt field and lists the results in the listbox below.
        Dim username As String = tbUsernameSearch.Text

    End Sub

    Private Sub CbPutUserLocations()    'Populates the location combo box.
        Dim location As New Location()
        cbLocation.DataSource = DbManager.GetAll(location)
        cbLocation.DisplayMember = "Name"
        cbLocation.ValueMember = "Name"
    End Sub


    Private Sub btnLocationSearch_Click(sender As Object, e As EventArgs) Handles btnLocationSearch.Click 'Updates the listbox according to the user input
        Dim locationSearch As New Location()
        Dim location As String = tbLocationSearch.Text
        Dim locationTable As DataTable = DbManager.GetSpecific(locationSearch, location)
        PutLbLocations(locationTable)
    End Sub

    Private Function GetAllLocations() 'Returns a DataTable with all locations
        Dim location As New Location()
        Dim locationsTable As DataTable = DbManager.GetAll(location)
        Return locationsTable
    End Function

    Private Sub PutLocation(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            tbLocationName.Text = row("Name")
            tbLocationAddress.Text = row("Address")
            tbLocationTelephoneNumber.Text = row("TelephoneNumber")
        Next
    End Sub

    Private Sub PutLbLocations(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbLocations.DataSource = table
        lbLocations.DisplayMember = "Name"
        lbLocations.ValueMember = "Name"
    End Sub

    Private Sub lbLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLocations.SelectedIndexChanged 'Populates the textboxes based on the chosen location in the listbox.
        Dim locationSearch As New Location()
        PutLocation(DbManager.GetSpecific(locationSearch, lbLocations.SelectedValue.ToString()))
    End Sub

End Class

