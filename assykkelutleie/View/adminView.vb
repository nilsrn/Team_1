Public Class adminView 'Nils

#Region "General code for the form"
    Private Sub adminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
            GetAllUsers()
            PutLbLocations(GetAllLocations)
            CbGetUserLocations()
            CbGetAccountTypes()
        End Sub
#End Region

#Region "Code for the UserAccount tab"
    Private Sub CbGetUserLocations()    'Populates the location combo box.
            Dim location As New Location()
            cbUserLocation.DataSource = DbManager.GetAll(location)
            cbUserLocation.DisplayMember = "Name"
            cbUserLocation.ValueMember = "Name"
        End Sub

        Private Sub CbGetAccountTypes()    'Populates the Accounttypes combo box.
            Dim user As New UserAccount()
            cbAccountType.DataSource = DbManager.GetAll(user)
            cbAccountType.DisplayMember = "AccountType"
            cbAccountType.ValueMember = "AccountType"
        End Sub

        Private Sub PutUserAccounts(table As DataTable)  'Populates the users listbox with data received from the DB. 
            lbUsers.DataSource = table
            lbUsers.DisplayMember = "username"
            lbUsers.ValueMember = "username"
        End Sub

        Private Sub GetAllUsers()   'Gets all users and populates the listbox
            Dim user As New UserAccount()
            Dim usertable As DataTable = DbManager.GetAll(user)
            PutUserAccounts(usertable)
        End Sub

        Private Sub PutUserAccount(userTable As DataTable)    'Populates the textboxes with the selected user data.
            For Each row In userTable.Rows
                tbUsername.Text = row("username")
                tbFirstName.Text = row("firstname")
                tbSurname.Text = row("surname")
                tbPassword.Text = row("password")
                tbEmail.Text = row("email")
                tbPhoneNumber.Text = row("TelephoneNumber")
                cbAccountType.Text = row("AccountType")
                cbUserLocation.Text = row("Location")
            Next
        End Sub

        Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged   'Populates the textboxes based on the chosen user in the listbox.
            Dim usersearch As New UserAccount()
            PutUserAccount(DbManager.GetSpecific(usersearch, lbUsers.SelectedValue.ToString()))
        End Sub

        Private Sub btnUserSearch_Click(sender As Object, e As EventArgs) Handles btnUserSearch.Click 'Searches for useraccounts based on the username in the textboxt field and lists the results in the listbox below.
            Dim username As String = tbUsernameSearch.Text

        End Sub

        Private Sub btnUserSave_Click(sender As Object, e As EventArgs) Handles btnUserSave.Click
            Dim username, firstname, surname, password, salt, email, telephoneNumber, accounttype, userlocation As String
            Try
                username = tbUsername.Text
                firstname = tbFirstName.Text
                surname = tbSurname.Text
                password = tbPassword.Text
                salt = Encryption.GenerateSalt
                email = tbEmail.Text
                telephoneNumber = tbLocationTelephoneNumber.Text
                accounttype = cbAccountType.Text
                userlocation = cbUserLocation.Text

                Dim updateUser As New UserAccount(username, accounttype, Location, firstname, surname, email, telephoneNumber)
                DbManager.InsertOrUpdate(updateUser)
            Catch ex As Exception
                MsgBox("Feil input - all tekst må fylles ut")
            End Try

            GetAllUsers()
        End Sub
#End Region

#Region "Code for the location tab"
    Private Sub btnLocationSearch_Click(sender As Object, e As EventArgs) Handles btnLocationSearch.Click 'Search function for locations
            Dim locationSearch As New Location()
            Dim location As String = tbLocationSearch.Text
            Dim locationTable As DataTable = DbManager.GetSpecific(locationSearch, location)
            PutLbLocations(locationTable)
        End Sub

        Private Function GetAllLocations() 'Returns a DataTable with all the locations registered
            Dim location As New Location()
            Dim locationsTable As DataTable = DbManager.GetAll(location)
            Return locationsTable
        End Function

        Private Sub PutLocation(list As DataTable) 'Populates the textboxes with selected location data.
            For Each row In list.Rows
                tbLocationName.Text = row("Name")
                tbLocationAddress.Text = row("Address")
                tbLocationTelephoneNumber.Text = row("TelephoneNumber")
            Next
        End Sub

        Private Sub PutLbLocations(table As DataTable) 'Populates the locations listbox with data received from the DB. 
            lbLocations.DataSource = table
            lbLocations.DisplayMember = "Name"
            lbLocations.ValueMember = "Name"
        End Sub

        Private Sub lbLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLocations.SelectedIndexChanged 'Populates the textboxes based on the chosen location in the listbox.
            Dim locationSearch As New Location()
            PutLocation(DbManager.GetSpecific(locationSearch, lbLocations.SelectedValue.ToString()))
        End Sub

        Private Sub PutUserLocations()    ' Populates the location combobox with the name values from the DB
            Dim location As New Location()
            cbUserLocation.DataSource = DbManager.GetAll(location)
            cbUserLocation.DisplayMember = "Name"
            cbUserLocation.ValueMember = "Name"
        End Sub

        Private Sub btnSaveLocation_Click(sender As Object, e As EventArgs) Handles btnSaveLocation.Click 'Updates an existing location or creates a new location if the name is unique.
            Dim name, address, telephoneNumber As String
            Try
                name = tbLocationName.Text
                address = tbLocationAddress.Text
                telephoneNumber = tbLocationTelephoneNumber.Text
                Dim updateLocation As New Location(name, address, telephoneNumber)
                DbManager.InsertOrUpdate(updateLocation)
            Catch ex As Exception
                MsgBox("Du må fylle inn verdier i alle feltene.")
            End Try
            PutLbLocations(GetAllLocations)
        End Sub
#End Region

#Region "Code For the BicycleType tab"
#End Region

#Region "Code for the BicycleType tab"
#End Region
End Class

