Imports MySql.Data.MySqlClient
Public Class rentalView
#Region "Functions"
    Private Sub CbPutComboBox() 'Populates the comboboxes.

        Dim bikeid, equipmentid As Integer
        Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
        Dim sql As New MySqlConnection(connectionString)
        Dim query As String = "SELECT BicycleID, BicycleType FROM `Bicycle` WHERE Status='Ledig'"
        Dim query2 As String = "SELECT EquipmentID, EquipmentType FROM `Equipment` WHERE Status='Ledig'"
        Dim command As New MySqlCommand(query, sql)
        Dim command2 As New MySqlCommand(query2, sql)
        Dim adapter As New MySqlDataAdapter()
        Dim adapter2 As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim table2 As New DataTable()
        adapter.SelectCommand = command
        adapter.Fill(table)
        adapter2.SelectCommand = command2
        adapter2.Fill(table2)


        For Each row In table.Rows
            bikeid = row("BicycleID")
            pickbike.Items.Add(bikeid)
        Next
        For Each row In table2.Rows
            equipmentid = row("EquipmentID")
            pickequipment.Items.Add(equipmentid)

        Next

        Dim location As New Location()
        extradition.DataSource = DbManager.GetAll(location)
        filing.DataSource = DbManager.GetAll(location)

        extradition.DisplayMember = "Name"
        filing.DisplayMember = "Name"
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
        Dim borrow As Date = extraditiondate.Value.Date
        Dim back As Date = filingdate.Value.Date
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays As Integer = CountDays.Days
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
        Dim borrow As Date = extraditiondate.Value.Date
        Dim back As Date = filingdate.Value.Date
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays As Integer = CountDays.Days
        Dim equipmenttype As New EquipmentType()
        Dim typelist As DataTable = DbManager.GetAll(equipmenttype)
        For Each row In typelist.Rows
            equipmentrateday = row("RateDay")
        Next
        equipmenteprice = equipmentrateday * totaldays()
        Return equipmenteprice
    End Function


    Private Function totaldays() 'Function showing number of days something is rented
        Dim borrow As Date = extraditiondate.Value.Date
        Dim back As Date = filingdate.Value.Date
        Dim CountDays As TimeSpan = back.Subtract(borrow)
        Dim datetodays As Integer = CountDays.Days
        Return datetodays
    End Function

    Private Function discount() ' Function calculating discount based on number of selected items
        Dim thediscount As Integer
        If ButtonClickCount = 1 Or ButtonClickCount = 2 Or ButtonClickCount = 3 Or ButtonClickCount = 4 Then
            thediscount = totalprice()
        ElseIf ButtonClickCount = 5 Or ButtonClickCount = 6 Or ButtonClickCount = 7 Or ButtonClickCount = 8 Or ButtonClickCount = 9 Then
            thediscount = totalprice() * 0.85
        ElseIf ButtonClickCount >= 10 Then
            thediscount = totalprice() * 0.7
        End If
        Return thediscount
    End Function

    Private Function totalpriceperday() 'Function to calculate total price of bicycles and equipment per day based on prices added to the listbox
        Dim total As Integer
        For Each Str As String In lbSummary.Items
            total = total + CInt(Str)
        Next
        Return total
    End Function

    Private Function totalprice() 'Function that multiplies total price per day with the total number of days to get the total price of the order
        Dim totalp As Integer
        totalp = totalpriceperday() * totaldays()
        Return totalp
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
        Dim rid, InvoiceNumber, price, CustomerID, kid As Integer
        Dim InvoiceDate As String = ""
        Dim DueDate As String = ""
        Dim rentalsummary As String
        Dim rental As New Rentals()
        Dim list As DataTable = DbManager.GetAll(rental)
        For Each row In list.Rows
            rid = row("RentalID")
            InvoiceDate = row("PickupTime")
            DueDate = row("DeliveryTime")
        Next
        CustomerID = presentcustomerid.Text
        rentalsummary = commenttxt.Text
        kid = Int((9999 * Rnd()) + 1111)
        price = discount()
        Dim insertInvoice As New Invoice(InvoiceNumber, CustomerID, rid, InvoiceDate, DueDate, kid, price, rentalsummary)
        DbManager.Insert(insertInvoice)
    End Sub

    Private Sub rentedbicycleequipment() 'Sub for updating tables RentedBicycles and RentedEquipment when a rental is placed
        Dim rid, BicycleID, EquipmentID, pricebike, priceequipment As Integer
        Dim datefrom, dateto As String
        Dim rental As New Rentals()
        Dim list As DataTable = DbManager.GetAll(rental)
        For Each row In list.Rows
            rid = row("RentalID")
        Next

        BicycleID = pickbike.Text
        EquipmentID = pickequipment.Text
        datefrom = extraditiondate.Value.ToString("yyyy-MM-dd")
        dateto = filingdate.Value.ToString("yyyy-MM-dd")
        pricebike = bikepricetotal()
        priceequipment = equipmentpricetotal()
        Dim insertRentedBicycle As New RentedBicycles(BicycleID, rid, pricebike, datefrom, dateto)
        Dim insertRentedEquipment As New RentedEquipment(EquipmentID, rid, priceequipment, datefrom, dateto)
        DbManager.Insert(insertRentedBicycle)
        DbManager.Insert(insertRentedEquipment)
    End Sub
    Private Sub updatebike() 'Updates status and location when a bike is rented
        Dim BicycleID As Integer
        Dim BicycleType As String = ""
        Dim DefaultLocation As String = ""
        Dim CurrentLocation As String
        Dim Status As String = ""
        Dim bike As New Bicycle()
        Dim list As DataTable = DbManager.GetAll(bike)
        For Each row In list.Rows
            BicycleType = row("BicycleType")
            DefaultLocation = row("DefaultLocation")
            Status = row("Status")
        Next
        BicycleID = pickbike.SelectedValue
        CurrentLocation = filing.SelectedValue
        Dim updatebicycle As New Bicycle(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status)
        DbManager.Update(updatebicycle)
    End Sub
    Private Sub updateequipment() 'Updates status and location when equipment is rented
        Dim EquipmentID As Integer
        Dim EquipmentType As String = ""
        Dim DefaultLocation As String = ""
        Dim CurrentLocation As String
        Dim Status As String = ""
        Dim equipment As New Equipment()
        Dim list As DataTable = DbManager.GetAll(equipment)
        For Each row In list.Rows
            EquipmentType = row("EquipmentType")
            DefaultLocation = row("DefaultLocation")
            Status = row("Status")
        Next
        EquipmentID = pickequipment.SelectedValue
        CurrentLocation = filing.SelectedValue
        Dim updateequipment As New Equipment(EquipmentID, EquipmentType, DefaultLocation, CurrentLocation, Status)
        DbManager.Update(updateequipment)
    End Sub
#End Region

#Region "Actions"
    Private Sub rentalView_Load(sender As Object, e As EventArgs) Handles Me.Load 'Puts rentals in listbox and fills combobox when the form is loaded
        PutLbRentals(GetAllRentals)
        CbPutComboBox()
    End Sub
    Private Sub rentalcomplete_Click(sender As Object, e As EventArgs) Handles rentalcomplete.Click 'Inserts data into tables Rentals, Invoice, Rentedbicycles and rentedequipment. Updates status on bicycle/equipment-location
        Dim PickupLocation, DeliveryLocation, Comment, Username, rentaltype As String
        Dim PickupTime, DeliveryTime As String
        Dim CustomerID, typeammount, price As Integer
        Try
            PickupLocation = extradition.SelectedValue
            DeliveryLocation = filing.SelectedValue
            PickupTime = extraditiondate.Value.ToString("yyyy-MM-dd")
            DeliveryTime = filingdate.Value.ToString("yyyy-MM-dd")
            Comment = commenttxt.Text
            rentaltype = "Døgn"
            typeammount = totaldays()
            Username = My.Settings.username
            price = discount()
            CustomerID = presentcustomerid.Text
            Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
            Dim sql As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO Rentals (CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment) VALUES ('" & CustomerID & "', '" & Username & "', '" & PickupLocation & "', '" & DeliveryLocation & "', '" & PickupTime & "', '" & DeliveryTime & "', '" & rentaltype & "', '" & typeammount & "', '" & price & "', '" & Comment & "')"
            Dim command As New MySqlCommand(query, sql)
            Dim ad As New MySqlDataAdapter()
            Dim table As New DataTable()
            ad.SelectCommand = command
            ad.Fill(table)

            makeInvoice()
            rentedbicycleequipment()
            updatebike()
            updateequipment()
            PutLbRentals(GetAllRentals)
            MsgBox("Bestillingen er registrert!")
            txtsearch.Text = ""
            firstnametxt.Text = ""
            surnametxt.Text = ""
            mailtxt.Text = ""
            presentcustomerid.Text = ""
            commenttxt.Text = ""
            extraditiondate.Value = Today
            filingdate.Value = Today
            filing.Text = ""
            extradition.Text = ""
            pickbike.Text = ""
            pickequipment.Text = ""
            lbSummary.Items.Clear()
            ButtonClickCount = 0

        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click 'Puts customer information in textboxes based on the phone number in the search box
        Dim customerSearch As New Customer()
        Dim customer As String = txtsearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutCustomer(customerTable)
    End Sub

    Private Sub searchrentals_Click(sender As Object, e As EventArgs) Handles searchrentals.Click 'Searches for rentals based on the RentalID in the textboxt field and lists the results in the listbox.
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) 'Updates listbox to show newly added rentals
        PutLbRentals(GetAllRentals)
    End Sub

    Private ButtonClickCount As Integer = 0
    Private Sub btnLeggTil_Click(sender As Object, e As EventArgs) Handles btnLeggTil.Click 'Adds price of the selected items from the pickbike and pickequipment comboboxes to overview listbox and counts number of clicks on button
        ButtonClickCount = ButtonClickCount + 1
        Try
            Dim bicycleid As Integer = pickbike.Text
            Dim equipmentid As Integer = pickequipment.Text
            Dim equipmentrateday As Integer
            Dim bikerateday As Integer
            Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
            Dim sql As New MySqlConnection(connectionString)
            Dim query As String = "SELECT RateDay from BicycleType, Bicycle WHERE BicycleType.Name=Bicycle.BicycleType and BicycleID=" & bicycleid
            Dim query2 As String = "SELECT RateDay from EquipmentType, Equipment WHERE EquipmentType.Name=Equipment.EquipmentType and EquipmentID=" & equipmentid

            Dim command As New MySqlCommand(query, sql)
            Dim command2 As New MySqlCommand(query2, sql)
            Dim adapter As New MySqlDataAdapter()
            Dim adapter2 As New MySqlDataAdapter()

            Dim table As New DataTable()
            Dim table2 As New DataTable()
            adapter.SelectCommand = command
            adapter.Fill(table)
            adapter2.SelectCommand = command2
            adapter2.Fill(table2)

            For Each row In table.Rows
                bikerateday = row("RateDay")
            Next
            For Each row In table2.Rows
                equipmentrateday = row("RateDay")
            Next

            lbSummary.Items.Add(bikerateday)
            lbSummary.Items.Add(equipmentrateday)

        Catch ex As Exception
            MsgBox("Du må velge sykkel og utstyr fra nedtrekkslisten.")
        End Try
    End Sub


#End Region
End Class