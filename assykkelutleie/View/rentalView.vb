Imports MySql.Data.MySqlClient
Public Class rentalView
#Region "Functions"
    Private Sub CbPutComboBox() 'Populates the comboboxes.

        Dim bicycletype As New BicycleType()
        Dim location As New Location()
        Dim equipment As New EquipmentType()


        pickbike.DataSource = DbManager.GetAll(bicycletype)
        pickequipment.DataSource = DbManager.GetAll(equipment)
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
    Private Function GetAllCustomer() 'Returns a DataTable with all customers.
        Dim customer As New Customer()
        Dim customerTable As DataTable = DbManager.GetAll(customer)
        Return customerTable
    End Function
    Private Function GetAllRentals() 'Returns a DataTable with all rentals
        Dim rentals As New Rentals()
        Dim rentalTable As DataTable = DbManager.GetAll(rentals)
        Return rentalTable
    End Function
    Private Function GetAllBicycles() 'Returns a DataTable with all bicycles.
        Dim bicycle As New Bicycle()
        Dim bicyclesTable As DataTable = DbManager.GetAll(bicycle)
        Return bicyclesTable
    End Function
    Private Sub PutCustomer(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows

            firstnametxt.Text = row("FirstName")
            surnametxt.Text = row("Surname")
            mailtxt.Text = row("Email")
            presentcustomerid.Text = row("CustomerID")
        Next
    End Sub
    Private Sub PutRentals(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            pickbike2.SelectedValue = row("Name")
            pickequipment2.SelectedValue = row("Name")
            extradition2.SelectedValue = row("PickupLocation")
            filing2.SelectedValue = row("DeliveryLocation")
            extraditiondate2.Text = row("PickupTime")
            filingdate2.Text = row("DeliveryTime")

        Next
    End Sub
#End Region

#Region "Actions"
    Private Sub rentalView_Load(sender As Object, e As EventArgs) Handles Me.Load
        PutLbRentals(GetAllRentals)
        CbPutComboBox()
    End Sub
    Private Sub rentalcomplete_Click(sender As Object, e As EventArgs) Handles rentalcomplete.Click

        Dim BicycleType, equipment, PickupLocation, DeliveryLocation, Comment, Username, Utleie_Type As String
        Dim PickupTime, DeliveryTime As Date
        Dim CustomerID, RentalID, Utleie_Type_Antall, Total_Pris As Integer

        Try

            CustomerID = presentcustomerid.Text
            BicycleType = pickbike.SelectedValue
            equipment = pickequipment.SelectedValue
            PickupLocation = extradition.SelectedValue
            DeliveryLocation = filing.SelectedValue
            PickupTime = extraditiondate.Text
            DeliveryTime = filing.Text
            RentalID = RentalID + 1
            Comment = commenttxt.Text
            Dim updateRentals As New Rentals(RentalID, CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment)

            DbManager.InsertOrUpdate(updateRentals)
            PutLbRentals(GetAllRentals)
        Catch ex As Exception
        End Try


    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim customerSearch As New Customer()
        Dim customer As String = txtsearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutCustomer(customerTable)

    End Sub

    Private Sub searchrentals_Click(sender As Object, e As EventArgs) Handles searchrentals.Click
        Dim rentalSearch As New Rentals()
        Dim rental As String = txtrentalsearch.Text
        Dim rentalTable As DataTable = DbManager.GetSpecific(rentalSearch, rental)
        PutLbRentals(rentalTable)
        If txtrentalsearch.Text = "" Then
            MsgBox("Skriv noe i søkefeltet")
        End If
    End Sub
    Private Sub lbrentals_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ContextMenuStrip only shows when an item is selected in the listbox.
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbrentals.SelectedIndices.Count > 0 Then
                lbrentals.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lbrentals.ContextMenuStrip = Nothing
            End If
        End If
    End Sub
    Private Sub LbBicycles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbrentals.SelectedIndexChanged 'Populates the textboxes based on the chosen bicycle in the listbox.
        Dim rentalSearch As New Rentals()
        PutRentals(DbManager.GetSpecific(rentalSearch, lbrentals.SelectedValue.ToString()))
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click 'Deletes the selcted item.
        If MsgBox("Sikker på at du vil slette bestillingen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim rental As New Rentals()
                Dim rentalID As Integer = lbrentals.SelectedValue
                DbManager.Delete(rental, "RentalID", rentalID)
            Catch ex As Exception
            End Try
        End If

    End Sub
#End Region

End Class