Imports MySql.Data.MySqlClient
Public Class transportView
#Region "Functions"
    Private Sub PutLbRentals(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbRentals.DataSource = table
        lbRentals.DisplayMember = "RentalID"
        lbRentals.ValueMember = "RentalID"
    End Sub

    Private Sub PutLbBicycles(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbFramenbr.DataSource = table
        lbFramenbr.DisplayMember = "BicycleID"
        lbFramenbr.ValueMember = "BicycleID"
    End Sub

    Private Function GetAllRentals() 'Returns a DataTable with all rentals.
        Dim rental As New Rentals()
        Dim rentalsTable As DataTable = DbManager.GetAll(rental)
        Return rentalsTable
    End Function

    Private Function GetAllBicycles() 'Returns a DataTable with all bicycles.
        Dim bicycle As New RentedBicycles()
        Dim bicyclesTable As DataTable = DbManager.GetAll(bicycle)
        Return bicyclesTable
    End Function

    Private Sub PutRentals(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtRentalID.Text = row("RentalID")
            txtPickupLocation.Text = row("DeliveryLocation")
            txtPickupTime.Text = row("DeliveryTime")
        Next
    End Sub

    Private Sub PutBicycles(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtFramenbr.Text = row("BicycleID")
            txtDeliveryLocation.Text = row("DefaultLocation")
        Next
    End Sub

    Private Sub GetAllForTransport()    'Gets all bicycles and equipment that has a different CurrentLocation then the DefaultLocation. 
        Dim bicycle As New Bicycle()
        Dim bicycleList As DataTable = DbManager.GetAll(bicycle)
        Dim equipmentSearch As New Equipment()
        Dim equipmentList As DataTable = DbManager.GetAll(equipmentSearch)
        lbTransportation.Items.Clear()
        For Each row In bicycleList.Rows
            If Not row("DefaultLocation") = row("CurrentLocation") Then
                Dim b = New Bicycle With {.BicycleID = row("BicycleID"), .BicycleType = row("BicycleType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation")}  'Oppretter sykkelobjektet og legger til i listboksen
                lbTransportation.Items.Add(b)
            End If
        Next
        For Each row In equipmentList.Rows
            If Not row("DefaultLocation") = row("CurrentLocation") Then
                Dim e = New Equipment With {.EquipmentID = row("EquipmentID"), .EquipmentType = row("EquipmentType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation")} 'Oppretter utstyrsobjektet og legger til i listboksen
                lbTransportation.Items.Add(e)
            End If
        Next
    End Sub

#End Region

#Region "Actions"
    Private Sub transportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listbox when the form loads.
        PutLbRentals(GetAllRentals)
        GetAllForTransport()
    End Sub

    Private Sub LbRentals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbRentals.SelectedIndexChanged 'Populates the other listbox based on the rentalID in the listbox.
        Dim rentalsSearch As New RentedBicycles()
        Dim rentals As String = lbRentals.SelectedValue.ToString()
        Dim rentalsTable As DataTable = DbManager.GetSpecific(rentalsSearch, rentals)
        PutLbBicycles(rentalsTable)
    End Sub

    Private Sub LbFramenbr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFramenbr.SelectedIndexChanged 'Populates the textboxes based on the chosen bicycle in the listbox.
        Dim rentalsSearch As New Rentals()
        Dim bicycleSearch As New Bicycle()

        PutRentals(DbManager.GetSpecific(rentalsSearch, lbRentals.SelectedValue.ToString()))
        PutBicycles(DbManager.GetSpecific(bicycleSearch, lbFramenbr.SelectedValue.ToString()))
    End Sub

    Private Sub BtnBicyclesSearch_Click(sender As Object, e As EventArgs) Handles btnBicyclesSearch.Click 'Updates the listbox according to the user input.
        Dim rentalsSearch As New Rentals()
        Dim rentals As String = txtRentalSearch.Text
        Dim rentalsTable As DataTable = DbManager.GetSpecific(rentalsSearch, rentals)
        PutLbRentals(rentalsTable)
        If txtRentalSearch.Text = "" Then
            PutLbRentals(GetAllRentals)
        End If
    End Sub

    Private Sub BtnBicycleSave_Click(sender As Object, e As EventArgs) Handles btnBicycleSave.Click 'Updates the DB according to the input.

    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click ' Sub for the ContextMenuStrip that updates the CurrentLocation to the DefaultLocation when an item has been transported. Checks if it is a bicycle or equipment before updating.
        If lbTransportation.SelectedIndices.Count > 0 Then
            If lbTransportation.SelectedItem.ToString.StartsWith("SykkelID") Then
                Dim bicycle As New Bicycle()
                Dim getBicycle As New DataTable
                getBicycle = DbManager.GetSpecific(bicycle, lbTransportation.SelectedItem.BicycleID())
                bicycle = New Bicycle(getBicycle)
                bicycle.CurrentLocation() = bicycle.DefaultLocation()
                DbManager.Update(bicycle)
            Else
                Dim equipment As New Equipment()
                Dim utstyrTable As DataTable = DbManager.GetSpecific(equipment, lbTransportation.SelectedItem.EquipmentID())
                equipment = New Equipment(utstyrTable)
                equipment.CurrentLocation() = equipment.DefaultLocation()
                DbManager.Update(equipment)
            End If
        Else
            MsgBox("Du må høyreklikke på et objekt for å returnere det")
        End If
        GetAllForTransport()
    End Sub
#End Region
End Class