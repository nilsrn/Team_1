Imports MySql.Data.MySqlClient
Public Class bicycleView 'Sven-Erik
#Region "Functions"
    Private Sub CbPutComboBox() 'Populates the comboboxes.
        Dim status As New BicycleStatus()
        Dim bicycletype As New BicycleType()
        Dim location As New Location()

        'Adds an extra row "Alle" to  cbStatusSearch
        Dim dt As DataTable = DbManager.GetAll(status)
        Dim row As DataRow = dt.NewRow
        row("Name") = "Alle"
        dt.Rows.InsertAt(row, 0)

        cbType.DataSource = DbManager.GetAll(bicycletype)
        cbDefaultLoc.DataSource = DbManager.GetAll(location)
        cbCurrentLoc.DataSource = DbManager.GetAll(location)

        cbType.DisplayMember = "Name"
        cbDefaultLoc.DisplayMember = "Name"
        cbCurrentLoc.DisplayMember = "Name"
        cbStatusSearch.DisplayMember = "Name"

        cbType.ValueMember = "Name"
        cbDefaultLoc.ValueMember = "Name"
        cbCurrentLoc.ValueMember = "Name"
        cbStatusSearch.ValueMember = "Name"

        cbStatusSearch.DataSource = dt
        cbStatusSearch.SelectedIndex = 0
    End Sub

    Private Sub PutLbBicycles(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbBicycle.DataSource = table
        lbBicycle.DisplayMember = "BicycleID"
        lbBicycle.ValueMember = "BicycleID"
    End Sub

    Private Function GetAllBicycles() 'Returns a DataTable with all bicycles.
        Dim bicycle As New Bicycle()
        Dim bicyclesTable As DataTable = DbManager.GetAll(bicycle)
        Return bicyclesTable
    End Function

    Private Sub PutBicyclesFilter() 'Returns a DataTable with bicycles corresponding with the filter.
        If cbStatusSearch.SelectedValue.ToString = "Alle" Then
            PutLbBicycles(GetAllBicycles)
        Else
            Dim bicycleSearch As New Bicycle()
            Dim status As String = cbStatusSearch.SelectedValue.ToString
            Dim bicycleTable As DataTable = DbManager.GetFilter(bicycleSearch, "'Status'", status)
            PutLbBicycles(bicycleTable)
        End If
    End Sub

    Private Sub PutBicycles(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtFramenbr.Text = row("BicycleID")
            cbType.SelectedValue = row("BicycleType")
            cbDefaultLoc.SelectedValue = row("DefaultLocation")
            cbCurrentLoc.SelectedValue = row("CurrentLocation")
            If row("Status") = "Ledig" Then
                rbAvailable.Checked = True
            ElseIf row("Status") = "Utleid" Then
                rbRented.Checked = True
            ElseIf row("Status") = "Service" Then
                rbService.Checked = True
            ElseIf row("Status") = "Stjålet" Then
                rbStolen.Checked = True
            End If
        Next
    End Sub

    Private Function bicycleStatus() ' Function to check selected status
        Dim status As String
        If rbAvailable.Checked = True Then
            status = "Ledig"
        ElseIf rbRented.Checked = True Then
            status = "Utleid"
        ElseIf rbService.Checked = True Then
            status = "Service"
        ElseIf rbStolen.Checked = True Then
            status = "Stjålet"
        End If
        Return status
    End Function
#End Region

#Region "Actions"
    Private Sub BicyclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        CbPutComboBox()
        PutLbBicycles(GetAllBicycles)
    End Sub

    Private Sub BtnBicyclesSearch_Click(sender As Object, e As EventArgs) Handles btnBicyclesSearch.Click 'Updates the listbox according to the user input.
        Dim bicycleSearch As New Bicycle()
        Dim bicycle As String = txtFramenbr.Text
        Dim bicycleTable As DataTable = DbManager.GetSpecific(bicycleSearch, bicycle)
        PutLbBicycles(bicycleTable)
        If txtFramenbr.Text = "" Then
            PutBicyclesFilter()
            cbStatusSearch.SelectedValue = "Alle"
        End If
    End Sub

    Private Sub LbBicycles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBicycle.SelectedIndexChanged 'Populates the textboxes based on the chosen bicycle in the listbox.
        Dim bicyclesSearch As New Bicycle()
        PutBicycles(DbManager.GetSpecific(bicyclesSearch, lbBicycle.SelectedValue.ToString()))
    End Sub

    Private Sub lbBicycles_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ContextMenuStrip only shows when an item is selected in the listbox.
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbBicycle.SelectedIndices.Count > 0 Then
                lbBicycle.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lbBicycle.ContextMenuStrip = Nothing
            End If
        End If
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click 'Deletes the selcted item.
        If MsgBox("Sikker på at du vil slette sykkelen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim bicycle As New Bicycle()
                Dim bicycleID As Integer = lbBicycle.SelectedValue
                DbManager.Delete(bicycle, "BicycleID", bicycleID)
            Catch ex As Exception
            End Try
        End If
        PutBicyclesFilter()
    End Sub

    Private Sub BtnBicycleSave_Click(sender As Object, e As EventArgs) Handles btnBicycleSave.Click 'Adds or updates the DB according to the input.
        Dim framenbr As Integer
        Dim bicycleType, defaultLocation, currentLocation, status As String
        If txtFramenbr.Text = "" Then
            MessageBox.Show("Rammenummer må fylles ut")
        Else
            Try
                framenbr = txtFramenbr.Text
                bicycleType = cbType.SelectedValue
                defaultLocation = cbDefaultLoc.SelectedValue
                currentLocation = cbCurrentLoc.SelectedValue
                status = bicycleStatus()
                Dim updateBicycle As New Bicycle(framenbr, bicycleType, defaultLocation, currentLocation, status)
                DbManager.InsertOrUpdate(updateBicycle)
            Catch ex As Exception
            End Try
        End If
        PutBicyclesFilter()
    End Sub

    Private Sub CbStatusSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatusSearch.SelectedIndexChanged 'Updates the listbox according to the filter input.
        PutBicyclesFilter()
    End Sub
#End Region
End Class