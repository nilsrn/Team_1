﻿Public Class adminView

#Region "General code for the form"
    Private Sub adminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates all listboxes and comboboxes when the form loads.
        GetAllUsers()
        GetAllLocations()
        GetAllBicycleType()
        GetAllEquipmentType()
        CbGetUserLocations()
        CbGetAccountTypes()
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click  'Sub for the ContextMenuStrip that deletes the selcted item in the listboxes based on the current active tab. 
        If MsgBox("Er du sikker på at du vil slette valgt objekt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If TabControl1.SelectedTab Is TabUsers Then
                Try
                    Dim user As New UserAccount()
                    Dim selectedUser As String = lbUsers.SelectedValue.ToString
                    DbManager.Delete(user, "Username", selectedUser)
                Catch ex As Exception
                    MsgBox("Brukeren ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                GetAllUsers()
            ElseIf TabControl1.SelectedTab Is TabLocations Then
                Try
                    Dim location As New Location()
                    Dim selectedLocation As String = lbLocations.SelectedValue.ToString
                    DbManager.Delete(location, "Name", selectedLocation)
                Catch ex As Exception
                    MsgBox("Lokasjonen ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                GetAllLocations()
            ElseIf TabControl1.SelectedTab Is TabBicycleTypes Then
                Try
                    Dim bicycleType As New BicycleType()
                    Dim selectedBicycleType As String = lbBicycleType.SelectedValue.ToString
                    DbManager.Delete(bicycleType, "Name", selectedBicycleType)
                Catch ex As Exception
                    MsgBox("Sykkeltypen ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                GetAllBicycleType()
            ElseIf TabControl1.SelectedTab Is TabEquipmentType Then
                Try
                    Dim equipmentType As New EquipmentType()
                    Dim selectedEquipmentType As String = lbEquipmentType.SelectedValue.ToString
                    DbManager.Delete(equipmentType, "Name", selectedEquipmentType)
                Catch ex As Exception
                    MsgBox("Utstyrstypen ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                GetAllEquipmentType()
            End If
        End If
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
        Dim accountType As New AccountType()
        cbAccountType.DataSource = DbManager.GetAll(accountType)
        cbAccountType.DisplayMember = "Name"
        cbAccountType.ValueMember = "Name"
    End Sub

    Private Sub GetAllUsers()   'Gets all users and populates the listbox
        Dim user As New UserAccount()
        Dim usertable As DataTable = DbManager.GetAll(user)
        PutUserAccounts(usertable)
    End Sub

    Private Sub PutUserAccounts(table As DataTable)  'Populates the users listbox with data received from the DB. 
        lbUsers.DataSource = table
        lbUsers.DisplayMember = "Username"
        lbUsers.ValueMember = "Username"
    End Sub

    Private Sub PutUserAccount(usertable As DataTable)    'Populates the textboxes with the selected user data.
        For Each row In usertable.Rows
            tbUsername.Text = row("Username")
            tbFirstName.Text = row("Firstname")
            tbSurname.Text = row("Surname")
            tbEmail.Text = row("Email")
            tbUserPhoneNumber.Text = row("TelephoneNumber")
            cbAccountType.Text = row("AccountType")
            cbUserLocation.Text = row("Location")
        Next
    End Sub

    Private Sub lbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbUsers.SelectedIndexChanged   'Populates the textboxes based on the chosen user in the listbox.
        Dim userselected As New UserAccount()
        PutUserAccount(DbManager.GetSpecific(userselected, lbUsers.SelectedValue.ToString()))
    End Sub

    Private Sub btnUserClear_Click(sender As Object, e As EventArgs) Handles btnUserClear.Click 'Clears the content of the textboxes. 
        tbUsername.Text = ""
        tbFirstName.Text = ""
        tbSurname.Text = ""
        tbEmail.Text = ""
        tbUserPhoneNumber.Text = ""
        cbAccountType.Text = ""
        cbUserLocation.Text = ""
    End Sub

    Private Sub btnUserSearch_Click(sender As Object, e As EventArgs) Handles btnUserSearch.Click 'Searches for useraccounts based on the username in the textboxt field and lists the results in the listbox below.
        Dim username As String = tbUsername.Text
        Dim usersearch As New UserAccount()
        Dim usertable As DataTable = DbManager.GetSpecific(usersearch, username)
        PutUserAccount(usertable)
    End Sub

    Private Sub btnUserSave_Click(sender As Object, e As EventArgs) Handles btnUserSave.Click ' Updates an existing User or creates a new if the name is unique. Due to using the general Update function for editing users the password must be set for each edit. 
        Dim username, firstname, surname, email, telephoneNumber, accounttype, location As String
        Dim password0, password, salt
        Try
            username = tbUsername.Text
            password0 = Encryption.HashString(tbPassword.Text) 'Hashes the password typed in the tbPassword field.
            salt = Encryption.GenerateSalt
            password = Encryption.HashString(String.Format("{0}{1}", password0, salt)) ' Merges the password and salt and hashes them again. This value gets stored as the password in the database.
            firstname = tbFirstName.Text
            surname = tbSurname.Text
            email = tbEmail.Text
            telephoneNumber = tbUserPhoneNumber.Text
            accounttype = cbAccountType.Text
            location = cbUserLocation.Text
            If tbPassword.Text = "" Then
                MsgBox("Passord må settes på nytt ved endring eller oppdatering av brukerkonto")
            Else
                Dim updateUser As New UserAccount(username, password, salt, accounttype, location, firstname, surname, email, telephoneNumber)
                DbManager.InsertOrUpdate(updateUser)
            End If
        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        tbPassword.Text = ""
        GetAllUsers()
    End Sub
#End Region

#Region "Code for the location tab"
    Private Sub GetAllLocations() 'Returns a DataTable with all the locations registered
        Dim location As New Location()
        Dim locationsTable As DataTable = DbManager.GetAll(location)
        PutLbLocations(locationsTable)
    End Sub

    Private Sub PutLocation(table As DataTable) 'Populates the textboxes with selected location data.
        For Each row In table.Rows
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
        Dim locationselected As New Location()
        PutLocation(DbManager.GetSpecific(locationselected, lbLocations.SelectedValue.ToString()))
    End Sub

    Private Sub btnLocationSearch_Click(sender As Object, e As EventArgs) Handles btnLocationSearch.Click 'Search function for locations
        Dim locationSearch As New Location()
        Dim location As String = tbLocationSearch.Text
        Dim locationTable As DataTable = DbManager.GetSpecific(locationSearch, location)
        PutLbLocations(locationTable)
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
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        GetAllLocations()
    End Sub

    Private Sub btnLocationClear_Click(sender As Object, e As EventArgs) Handles btnLocationClear.Click 'Clears the content of the textboxes. 
        tbLocationName.Text = ""
        tbLocationAddress.Text = ""
        tbLocationTelephoneNumber.Text = ""
    End Sub

#End Region

#Region "Code For the BicycleType tab"
    Private Sub PutLbBicycleType(bicycleTypeTable As DataTable)  'Populates the BicycleType listbox with data received from the DB. 
        lbBicycleType.DataSource = bicycleTypeTable
        lbBicycleType.DisplayMember = "Name"
        lbBicycleType.ValueMember = "Name"
    End Sub

    Private Sub GetAllBicycleType()   'Gets all BicycleTypes and populates the listbox
        Dim BicycleType As New BicycleType()
        Dim bicycleTypeTable As DataTable = DbManager.GetAll(BicycleType)
        PutLbBicycleType(bicycleTypeTable)
    End Sub

    Private Sub PutBicycleType(table As DataTable) 'Populates the textboxes with selected location data.
        For Each row In table.Rows
            tbBicycleTypeName.Text = row("Name")
            tbBicycleTypeDescription.Text = row("Description")
            tbBicycleTypeGearSystem.Text = row("Gearsystem")
            tbBicycleTypeWheelSize.Text = row("Wheelsize")
            tbBicycleTypeFrameSize.Text = row("Framesize")
            tbBicycleTypeRateDay.Text = row("Rateday")
            tbBicycleTypeRateHour.Text = row("Ratehour")
        Next
    End Sub

    Private Sub lbBicycleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBicycleType.SelectedIndexChanged 'Populates the textboxes based on the chosen BicycleType in the listbox.
        Dim bicycletypeselected As New BicycleType()
        PutBicycleType(DbManager.GetSpecific(bicycletypeselected, lbBicycleType.SelectedValue.ToString()))
    End Sub

    Private Sub btnBicycleTypeSave_Click(sender As Object, e As EventArgs) Handles btnBicycleTypeSave.Click 'Updates an existing BicycleType or creates a new if the name is unique.
        Dim name, description, gearSystem, wheelSize, frameSize As String
        Dim rateHour, rateDay As Integer
        Try
            name = tbBicycleTypeName.Text
            description = tbBicycleTypeDescription.Text
            gearSystem = tbBicycleTypeGearSystem.Text
            wheelSize = tbBicycleTypeWheelSize.Text
            frameSize = tbBicycleTypeFrameSize.Text
            rateHour = tbBicycleTypeRateHour.Text
            rateDay = tbBicycleTypeRateDay.Text
            Dim updateBicycleType As New BicycleType(name, description, gearSystem, wheelSize, frameSize, rateHour, rateDay)
            DbManager.InsertOrUpdate(updateBicycleType)
        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding: " & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        GetAllBicycleType()
    End Sub

    Private Sub btnBicycleTypeClear_Click(sender As Object, e As EventArgs) Handles btnBicycleTypeClear.Click 'Clears the content of the textboxes. 
        tbBicycleTypeName.Text = ""
        tbBicycleTypeDescription.Text = ""
        tbBicycleTypeGearSystem.Text = ""
        tbBicycleTypeWheelSize.Text = ""
        tbBicycleTypeFrameSize.Text = ""
        tbBicycleTypeRateHour.Text = ""
        tbBicycleTypeRateDay.Text = ""
    End Sub
#End Region

#Region "Code for the BicycleType tab"
    Private Sub PutLbEquipmentType(equipmentTypeTable As DataTable)  'Populates the BicycleType listbox with data received from the DB. 
        lbEquipmentType.DataSource = equipmentTypeTable
        lbEquipmentType.DisplayMember = "Name"
        lbEquipmentType.ValueMember = "Name"
    End Sub

    Private Sub GetAllEquipmentType()   'Gets all BicycleTypes and populates the listbox
        Dim EquipmentType As New EquipmentType()
        Dim equipmentTypeTable As DataTable = DbManager.GetAll(EquipmentType)
        PutLbEquipmentType(equipmentTypeTable)
    End Sub

    Private Sub PutEquipmentType(table As DataTable) 'Populates the textboxes with selected location data.
        For Each row In table.Rows
            tbEquipmentTypeName.Text = row("Name")
            tbEquipmentTypeDescription.Text = row("Description")
            tbEquipmentTypeRateDay.Text = row("Rateday")
            tbEquipmentTypeRateHour.Text = row("Ratehour")
        Next
    End Sub

    Private Sub lbEquipmentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEquipmentType.SelectedIndexChanged 'Populates the textboxes based on the chosen BicycleType in the listbox.
        Dim equipmenttypeselected As New EquipmentType()
        PutEquipmentType(DbManager.GetSpecific(equipmenttypeselected, lbEquipmentType.SelectedValue.ToString()))
    End Sub

    Private Sub btnEquipmentTypeSave_Click(sender As Object, e As EventArgs) Handles btnEquipmentTypeSave.Click 'Updates an existing BicycleType or creates a new if the name is unique.
        Dim name, description As String
        Dim rateHour, rateDay As Integer
        Try
            name = tbEquipmentTypeName.Text
            description = tbEquipmentTypeDescription.Text
            rateHour = tbEquipmentTypeRateHour.Text
            rateDay = tbEquipmentTypeRateDay.Text
            Dim updateEquipmentType As New EquipmentType(name, description, rateHour, rateDay)
            DbManager.InsertOrUpdate(updateEquipmentType)
        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding: " & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        GetAllEquipmentType()
    End Sub

    Private Sub btnEquipmentTypeClear_Click(sender As Object, e As EventArgs) Handles btnEquipmentTypeClear.Click 'Clears the content of the textboxes. 
        tbEquipmentTypeName.Text = ""
        tbEquipmentTypeDescription.Text = ""
        tbEquipmentTypeRateHour.Text = ""
        tbEquipmentTypeRateDay.Text = ""
    End Sub

#End Region
End Class

