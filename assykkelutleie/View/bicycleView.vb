Imports MySql.Data.MySqlClient
Public Class bicycleView 'Sven-Erik
#Region "General code for the form"
    Private Sub BicyclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        CbPutComboBox()
        GetAllBicycles()
        GetAllEquipments()
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click  'Sub for the ContextMenuStrip that deletes the selcted item in the listboxes based on the current active tab. 
        If MsgBox("Er du sikker på at du vil slette valgt objekt?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If TabControl1.SelectedTab Is TabBicycle Then
                Try
                    Dim bicycle As New Bicycle()
                    Dim bicycleID As Integer = lbBicycle.SelectedValue
                    DbManager.Delete(bicycle, "BicycleID", bicycleID)
                Catch ex As Exception
                    MsgBox("Sykkelen ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                BicycleFilter()
            ElseIf TabControl1.SelectedTab Is TabEquipment Then
                Try
                    Dim equipment As New Equipment()
                    Dim selectedEquipment As String = lbEquipment.SelectedValue.ToString
                    DbManager.Delete(equipment, "EquipmentID", selectedEquipment)
                Catch ex As Exception
                    MsgBox("Utstyret ble ikke slettet. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
                End Try
                EquipmentFilter()
            End If
        End If
    End Sub

    Private Sub CbPutComboBox() 'Populates the comboboxes.
        Dim status As New Status()
        Dim bicycletype As New BicycleType()
        Dim equipmenttype As New EquipmentType()
        Dim location As New Location()

        'Adds an extra row "Alle" to  cbStatusSearch
        Dim dt As DataTable = DbManager.GetAll(status)
        Dim row As DataRow = dt.NewRow
        row("Name") = "Alle"
        dt.Rows.InsertAt(row, 0)

        cbBicycleType.DataSource = DbManager.GetAll(bicycletype)
        cbEquipmentType.DataSource = DbManager.GetAll(equipmenttype)
        cbBicycleDefaultLoc.DataSource = DbManager.GetAll(location)
        cbEquipmentDefaultLoc.DataSource = DbManager.GetAll(location)
        cbBicycleCurrentLoc.DataSource = DbManager.GetAll(location)
        cbEquipmentCurrentLoc.DataSource = DbManager.GetAll(location)

        cbBicycleType.DisplayMember = "Name"
        cbEquipmentType.DisplayMember = "Name"
        cbBicycleDefaultLoc.DisplayMember = "Name"
        cbEquipmentDefaultLoc.DisplayMember = "Name"
        cbBicycleCurrentLoc.DisplayMember = "Name"
        cbEquipmentCurrentLoc.DisplayMember = "Name"
        cbBicycleStatus.DisplayMember = "Name"
        cbEquipmentStatus.DisplayMember = "Name"

        cbBicycleType.ValueMember = "Name"
        cbEquipmentType.ValueMember = "Name"
        cbBicycleDefaultLoc.ValueMember = "Name"
        cbEquipmentDefaultLoc.ValueMember = "Name"
        cbBicycleCurrentLoc.ValueMember = "Name"
        cbEquipmentCurrentLoc.ValueMember = "Name"
        cbBicycleStatus.ValueMember = "Name"
        cbEquipmentStatus.ValueMember = "Name"

        cbBicycleStatus.DataSource = dt
        cbEquipmentStatus.DataSource = dt
        cbBicycleStatus.SelectedIndex = 0
        cbEquipmentStatus.SelectedIndex = 0
    End Sub
#End Region

#Region "Code for the Bicycle tab"
    Private Sub GetAllBicycles()   'Gets all bicycles and populates the listbox
        Dim bicycle As New Bicycle()
        Dim bicycletable As DataTable = DbManager.GetAll(bicycle)
        PutBicycles(bicycletable)
    End Sub

    Private Sub PutBicycles(table As DataTable)  'Populates the listbox with data received from the DB. 
        lbBicycle.DataSource = table
        lbBicycle.DisplayMember = "BicycleID"
        lbBicycle.ValueMember = "BicycleID"
    End Sub

    Private Sub PutBicycle(bicycletable As DataTable)    'Populates the textboxes with the selected data.
        For Each row In bicycletable.Rows
            txtBicycleID.Text = row("BicycleID")
            cbBicycleType.SelectedValue = row("BicycleType")
            cbBicycleDefaultLoc.SelectedValue = row("DefaultLocation")
            cbBicycleCurrentLoc.SelectedValue = row("CurrentLocation")
            If row("Status") = "Ledig" Then
                rbBicycleAvailable.Checked = True
            ElseIf row("Status") = "Utleid" Then
                rbBicycleRented.Checked = True
            ElseIf row("Status") = "Service" Then
                rbBicycleService.Checked = True
            ElseIf row("Status") = "Stjålet" Then
                rbBicycleStolen.Checked = True
            End If
        Next
    End Sub

    Private Sub BicycleFilter() 'Bicycles corresponding with the filter.
        If cbBicycleStatus.SelectedValue.ToString = "Alle" Then
            GetAllBicycles()
        Else
            Dim bicycleSearch As New Bicycle()
            Dim status As String = cbBicycleStatus.SelectedValue.ToString
            Dim bicycleTable As DataTable = DbManager.GetFilter(bicycleSearch, "Status", status)
            PutBicycles(bicycleTable)
        End If
    End Sub

    Private Function bicycleStatus() ' Function to check selected status
        Dim status As String
        If rbBicycleAvailable.Checked = True Then
            status = "Ledig"
        ElseIf rbBicycleRented.Checked = True Then
            status = "Utleid"
        ElseIf rbBicycleService.Checked = True Then
            status = "Service"
        ElseIf rbBicycleStolen.Checked = True Then
            status = "Stjålet"
        End If
        Return status
    End Function

    Private Sub LbBicycle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBicycle.SelectedIndexChanged 'Populates the textboxes based on the chosen bicycle in the listbox.
        Dim bicycleSelected As New Bicycle()
        PutBicycle(DbManager.GetSpecific(bicycleSelected, lbBicycle.SelectedValue.ToString()))
    End Sub

    Private Sub BtnBicycleSearch_Click(sender As Object, e As EventArgs) Handles btnBicycleSearch.Click 'Searches for bicycles based on the framenbr in the textboxt field and lists the results in the listbox.
        cbBicycleStatus.SelectedValue = "Alle"
        Dim bicycle As String = txtBicycleID.Text
        Dim bicycleSearch As New Bicycle()
        Dim bicycleTable As DataTable = DbManager.GetSpecific(bicycleSearch, bicycle)
        PutBicycles(bicycleTable)
        If txtBicycleID.Text = "" Then
            BicycleFilter()
        End If
    End Sub

    Private Sub BtnBicycleSave_Click(sender As Object, e As EventArgs) Handles btnBicycleSave.Click 'Adds or updates the DB according to the input.
        Dim framenbr As Integer
        Dim bicycleType, defaultLocation, currentLocation, status As String
        Try
            framenbr = txtBicycleID.Text
            bicycleType = cbBicycleType.SelectedValue
            defaultLocation = cbBicycleDefaultLoc.SelectedValue
            currentLocation = cbBicycleCurrentLoc.SelectedValue
            status = bicycleStatus()
            If txtBicycleID.Text = "" Then
                MessageBox.Show("Rammenummer må fylles ut")
            Else
                Dim updateBicycle As New Bicycle(framenbr, bicycleType, defaultLocation, currentLocation, status)
                DbManager.InsertOrUpdate(updateBicycle)
            End If
        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        BicycleFilter()
    End Sub

    Private Sub CbBicycleSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBicycleStatus.SelectedIndexChanged 'Updates the listbox according to the filter input.
        BicycleFilter()
    End Sub
#End Region

#Region "Code for the Equipment tab"
    Private Sub GetAllEquipments()   'Gets all equipments and populates the listbox
        Dim equipment As New Equipment()
        Dim equipmenttable As DataTable = DbManager.GetAll(equipment)
        PutEquipments(equipmenttable)
    End Sub

    Private Sub PutEquipments(table As DataTable)  'Populates the listbox with data received from the DB. 
        lbEquipment.DataSource = table
        lbEquipment.DisplayMember = "EquipmentID"
        lbEquipment.ValueMember = "EquipmentID"
    End Sub

    Private Sub PutEquipment(equipmenttable As DataTable)    'Populates the textboxes with the selected data.
        For Each row In equipmenttable.Rows
            txtEquipmentID.Text = row("EquipmentID")
            cbEquipmentType.SelectedValue = row("EquipmentType")
            cbEquipmentDefaultLoc.SelectedValue = row("DefaultLocation")
            cbEquipmentCurrentLoc.SelectedValue = row("CurrentLocation")
            If row("Status") = "Ledig" Then
                rbEquipmentAvailable.Checked = True
            ElseIf row("Status") = "Utleid" Then
                rbEquipmentRented.Checked = True
            ElseIf row("Status") = "Service" Then
                rbEquipmentService.Checked = True
            ElseIf row("Status") = "Stjålet" Then
                rbEquipmentStolen.Checked = True
            End If
        Next
    End Sub

    Private Sub EquipmentFilter() 'Equipments corresponding with the filter.
        If cbEquipmentStatus.SelectedValue.ToString = "Alle" Then
            GetAllEquipments()
        Else
            Dim equipmentSearch As New Equipment()
            Dim status As String = cbEquipmentStatus.SelectedValue.ToString
            Dim equipmentTable As DataTable = DbManager.GetFilter(equipmentSearch, "Status", status)
            PutEquipments(equipmentTable)
        End If
    End Sub

    Private Function EquipmentStatus() ' Function to check selected status
        Dim status As String
        If rbEquipmentAvailable.Checked = True Then
            status = "Ledig"
        ElseIf rbEquipmentRented.Checked = True Then
            status = "Utleid"
        ElseIf rbEquipmentService.Checked = True Then
            status = "Service"
        ElseIf rbEquipmentStolen.Checked = True Then
            status = "Stjålet"
        End If
        Return status
    End Function

    Private Sub LbEquipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEquipment.SelectedIndexChanged 'Populates the textboxes based on the chosen equipment in the listbox.
        Dim equipmentSelected As New Equipment()
        PutEquipment(DbManager.GetSpecific(equipmentSelected, lbEquipment.SelectedValue.ToString()))
    End Sub

    Private Sub BtnEquipmentSearch_Click(sender As Object, e As EventArgs) Handles btnEquipmentSearch.Click 'Searches for equipments based on the framenbr in the textboxt field and lists the results in the listbox.
        cbEquipmentStatus.SelectedValue = "Alle"
        Dim equipment As String = txtEquipmentID.Text
        Dim equipmentSearch As New Equipment()
        Dim equipmentTable As DataTable = DbManager.GetSpecific(equipmentSearch, equipment)
        PutEquipment(equipmentTable)
        If txtEquipmentID.Text = "" Then
            EquipmentFilter()
        End If
    End Sub

    Private Sub BtnEquipmentSave_Click(sender As Object, e As EventArgs) Handles btnEquipmentSave.Click 'Adds or updates the DB according to the input.
        Dim equipmentID As Integer
        Dim equipmentType, defaultLocation, currentLocation, status As String
        Try
            equipmentID = txtEquipmentID.Text
            equipmentType = cbEquipmentType.SelectedValue
            defaultLocation = cbEquipmentDefaultLoc.SelectedValue
            currentLocation = cbEquipmentCurrentLoc.SelectedValue
            status = EquipmentStatus()
            If txtEquipmentID.Text = "" Then
                MessageBox.Show("Utstyr ID må fylles ut")
            Else
                Dim updateEquipment As New Equipment(equipmentID, equipmentType, defaultLocation, currentLocation, status)
                DbManager.InsertOrUpdate(updateEquipment)
            End If
        Catch ex As Exception
            MsgBox("Noe gikk galt. Feilmelding:" & ex.Message, MsgBoxStyle.Critical, "Feilmelding")
        End Try
        EquipmentFilter()
    End Sub

    Private Sub CbEquipmentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEquipmentStatus.SelectedIndexChanged 'Updates the listbox according to the filter input.
        EquipmentFilter()
    End Sub
#End Region
End Class