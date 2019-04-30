Imports MySql.Data.MySqlClient
Public Class rentalView
#Region "Functions"
    Private Sub CbPutComboBox() 'Populates the comboboxes.

        Dim bicycle As New Bicycle()
        Dim location As New Location()
        Dim equipment As New Equipment()


        pickbike.DataSource = DbManager.GetAll(bicycle)
        pickequipment.DataSource = DbManager.GetAll(equipment)
        extradition.DataSource = DbManager.GetAll(location)
        filing.DataSource = DbManager.GetAll(location)

        pickbike.DisplayMember = "BicycleID"
        pickequipment.DisplayMember = "EquipmentID"
        extradition.DisplayMember = "Name"
        filing.DisplayMember = "Name"

        pickbike.ValueMember = "BicycleID"
        pickequipment.ValueMember = "EquipmentID"
        extradition.ValueMember = "Name"
        filing.ValueMember = "Name"

    End Sub
    Private Sub PutLbRentals(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbrentals.DataSource = table
        lbrentals.DisplayMember = "RentalID"
        lbrentals.ValueMember = "RentalID"
    End Sub

    Private Function GetAllRentals() 'Returns a DataTable with all rentals
        Dim rentals As New Rentals()
        Dim rentalTable As DataTable = DbManager.GetAll(rentals)
        Return rentalTable
    End Function

    Private Function GetAllInvoice() 'Returns a DataTable with all Invoice
        Dim invoice As New Invoice()
        Dim invoiceTable As DataTable = DbManager.GetAll(invoice)
        Return invoiceTable
    End Function
    Private Function bikepricetotal() 'Counts days between pickup/delivery and multiplies with day-rate for bicycle type
        Dim bikerateday As Integer
        Dim bikeprice As Integer
        Dim borrow As DateTime = Convert.ToDateTime(extraditiondate.Text)
        Dim back As DateTime = Convert.ToDateTime(filingdate.Text)
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays = Convert.ToInt32(CountDays.Days)
        Dim bicycletype As New BicycleType()
        Dim typelist As DataTable = DbManager.GetAll(bicycletype)
        For Each row In typelist.Rows
            bikerateday = row("RateDay")
        Next
        bikeprice = bikerateday * totaldays()
        Return bikeprice
    End Function
    Private Function equipmentpricetotal() 'Counts days between pickup/delivery and multiplies with day-rate for equipment type 
        Dim equipmentrateday As Integer
        Dim equipmenteprice As Integer
        Dim borrow As DateTime = Convert.ToDateTime(extraditiondate.Text)
        Dim back As DateTime = Convert.ToDateTime(filingdate.Text)
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays = Convert.ToInt32(CountDays.Days)
        Dim equipmenttype As New EquipmentType()
        Dim typelist As DataTable = DbManager.GetAll(equipmenttype)
        For Each row In typelist.Rows
            equipmentrateday = row("RateDay")
        Next
        equipmenteprice = equipmentrateday * totaldays()
        Return equipmenteprice
    End Function


    Private Function totaldays() 'Function showing number of days something is rented

        Dim borrow As DateTime = Convert.ToDateTime(extraditiondate.Text)
        Dim back As DateTime = Convert.ToDateTime(filingdate.Text)
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays = Convert.ToInt32(CountDays.Days)

        Return datetodays
    End Function

    Private Function discount() ' Function calculating discount

        Dim thediscount As Integer
        If ButtonClickCount = 1 Or ButtonClickCount = 2 Or ButtonClickCount = 3 Or ButtonClickCount = 4 Then
            thediscount = (equipmentpricetotal() + bikepricetotal())
        ElseIf ButtonClickCount = 5 Then
            thediscount = (equipmentpricetotal() + bikepricetotal()) * 0.85
        ElseIf ButtonClickCount = 10 Then
            thediscount = (equipmentpricetotal() + bikepricetotal()) * 0.7
        End If
        Return thediscount
    End Function
    Private Sub PutCustomer(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows

            firstnametxt.Text = row("FirstName")
            surnametxt.Text = row("Surname")
            mailtxt.Text = row("Email")
            presentcustomerid.Text = row("CustomerID")
        Next
    End Sub
    Private Sub makeInvoice() 'Sub for writing an invoice for the client
        Dim rid, InvoiceNumber, Total_Pris, CustomerID, kid As Integer
        Dim InvoiceDate, DueDate As Date
        Dim rentalsummary As String
        Dim rental As New Rentals()
        Dim list As DataTable = DbManager.GetAll(rental)
        For Each row In list.Rows
            rid = row("RentalID")
        Next
        CustomerID = presentcustomerid.Text
        rentalsummary = commenttxt.Text
        InvoiceDate = Date.Today.AddDays(11)
        DueDate = Date.Today.AddDays(30)
        kid = Int((9999 * Rnd()) + 1111)
        Total_Pris = discount()
        Dim insertInvoice As New Invoice(InvoiceNumber, CustomerID, rid, InvoiceDate, DueDate, kid, Total_Pris, rentalsummary)
        DbManager.Insert(insertInvoice)
    End Sub
    Private Sub rentedbicycleequipment() 'sub for updating tables RentedBicycles and RentedEquipment when a rental is placed
        Dim rid, BicycleID, EquipmentID, pricebike, priceequipment As Integer
        Dim datefrom, dateto As Date
        Dim rental As New Rentals()
        Dim list As DataTable = DbManager.GetAll(rental)
        For Each row In list.Rows
            rid = row("RentalID")
        Next

        BicycleID = pickbike.SelectedValue
        EquipmentID = pickequipment.SelectedValue
        datefrom = extraditiondate.Text
        dateto = filingdate.Text
        pricebike = bikepricetotal()
        priceequipment = equipmentpricetotal()

        Dim insertRentedBicycle As New RentedBicycles(BicycleID, rid, pricebike, datefrom, dateto)
        Dim insertRentedEquipment As New RentedEquipment(EquipmentID, rid, priceequipment, datefrom, dateto)
        DbManager.Insert(insertRentedBicycle)
        DbManager.Insert(insertRentedEquipment)
    End Sub
    Private Sub updatebike() 'updates status and location when a bike is rented
        Dim BicycleID As Integer
        Dim BicycleType, DefaultLocation, CurrentLocation, Status As String
        Dim bike As New Bicycle()
        Dim list As DataTable = DbManager.GetAll(bike)
        For Each row In list.Rows
            BicycleType = row("BicycleType")
            DefaultLocation = row("DefaultLocation")
        Next
        BicycleID = pickbike.SelectedValue
        CurrentLocation = filing.SelectedValue
        Status = "Utleid"
        Dim updatebicycle As New Bicycle(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status)
        DbManager.Update(updatebicycle)
    End Sub
    Private Sub updateequipment() 'updates status and location when equipment is rented
        Dim EquipmentID As Integer
        Dim EquipmentType, DefaultLocation, CurrentLocation, Status As String
        Dim equipment As New Equipment()
        Dim list As DataTable = DbManager.GetAll(equipment)
        For Each row In list.Rows
            EquipmentType = row("EquipmentType")
            DefaultLocation = row("DefaultLocation")
        Next
        EquipmentID = pickbike.SelectedValue
        CurrentLocation = filing.SelectedValue
        Status = "Utleid"
        Dim updateequipment As New Equipment(EquipmentID, EquipmentType, DefaultLocation, CurrentLocation, Status)
        DbManager.Update(updateequipment)
    End Sub



#End Region

#Region "Actions"
    Private Sub rentalView_Load(sender As Object, e As EventArgs) Handles Me.Load
        PutLbRentals(GetAllRentals)
        CbPutComboBox()
    End Sub
    Private Sub rentalcomplete_Click(sender As Object, e As EventArgs) Handles rentalcomplete.Click 'Inserts data into tables Rentals, Invoice, Rentedbicycles and rentedequipment. Updates status on bicycle/equipment-location

        Dim PickupLocation, DeliveryLocation, Comment, Username, Utleie_Type As String
        Dim PickupTime, DeliveryTime As Date
        Dim CustomerID, Utleie_Type_Antall, Total_Pris, RentalID As Integer

        Try
            PickupLocation = extradition.SelectedValue
            DeliveryLocation = filing.SelectedValue
            PickupTime = extraditiondate.Text
            DeliveryTime = filingdate.Text
            Comment = commenttxt.Text
            Utleie_Type = "Døgn"
            Utleie_Type_Antall = totaldays()
            Username = My.Settings.username
            Total_Pris = discount()
            CustomerID = presentcustomerid.Text
            Dim insertRentals As New Rentals(RentalID, CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment)
            DbManager.Insert(insertRentals)

            makeInvoice()
            rentedbicycleequipment()
            updatebike()
            updateequipment()
            PutLbRentals(GetAllRentals)
            MsgBox("Kunden er registrert!")
            MsgBox(discount())
            txtsearch.Text = " "
            firstnametxt.Text = " "
            surnametxt.Text = " "
            mailtxt.Text = " "
            presentcustomerid.Text = " "
            commenttxt.Text = " "
            extraditiondate.Text = Date.Today
            filingdate.Text = Date.Today
            filing.Text = ""
            extradition.Text = ""
            pickbike.Text = ""
            pickequipment.Text = ""
            lbOversikt.Items.Clear()
            ButtonClickCount = 0

        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
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
        Dim invoice As New Invoice()

    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click 'Deletes the selcted item.
        If MsgBox("Sikker på at du vil slette bestillingen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim rental As New Rentals()
                Dim invoice As New Invoice()
                Dim bike As New RentedBicycles()
                Dim equipment As New RentedEquipment()
                Dim rentalID As Integer = lbrentals.SelectedValue

                DbManager.Delete(bike, "RentalID", rentalID)

                DbManager.Delete(equipment, "RentalID", rentalID)

                DbManager.Delete(invoice, "RentalID", rentalID)

                DbManager.Delete(rental, "RentalID", rentalID)

            Catch ex As Exception
            End Try
        End If
        PutLbRentals(GetAllRentals)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PutLbRentals(GetAllRentals)
    End Sub


    Private ButtonClickCount As Integer = 0
    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click
        ButtonClickCount = ButtonClickCount + 1
        lbOversikt.Items.Add("Sykkel: " & pickbike.SelectedValue & " med utstyr: " & pickequipment.SelectedValue)
    End Sub


#End Region

End Class