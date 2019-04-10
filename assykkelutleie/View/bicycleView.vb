Imports MySql.Data.MySqlClient

Public Class bicycleView
    Private Sub CbPutBicycleLocations() 'Populates the location combobox.
        Dim location As New Location()
        cbDefaultLoc.DataSource = DbManager.GetAll(location)
        cbCurrentLoc.DataSource = DbManager.GetAll(location)
        cbDefaultLoc.DisplayMember = "Name"
        cbCurrentLoc.DisplayMember = "Name"
        cbDefaultLoc.ValueMember = "Name"
        cbCurrentLoc.ValueMember = "Name"
    End Sub

    Private Sub CbPutBicycleType() 'Populates the bicycletype combobox.
        Dim bicycletype As New BicycleType()
        cbType.DataSource = DbManager.GetAll(bicycletype)
        cbType.DisplayMember = "Name"
        cbType.ValueMember = "Name"
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

    Private Sub PutBicycles(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtFramenbr.Text = row("BicycleID")
            cbType.SelectedItem = row("BicycleType")
            cbDefaultLoc.SelectedItem = row("DefaultLocation")
            cbCurrentLoc.SelectedItem = row("DefaultLocation")
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

    Private Sub BicyclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        CbPutBicycleLocations()
        CbPutBicycleType()
        PutLbBicycles(GetAllBicycles)
    End Sub

    Private Sub BtnBicyclesSearch_Click(sender As Object, e As EventArgs) Handles btnBicyclesSearch.Click 'Updates the listbox according to the user input.
        Dim bicycleSearch As New Bicycle()
        Dim bicycle As String = txtBicycleSearch.Text
        Dim bicycleTable As DataTable = DbManager.GetSpecific(bicycleSearch, bicycle)
        PutLbBicycles(bicycleTable)
        If txtBicycleSearch.Text = "" Then
            PutLbBicycles(GetAllBicycles)
        End If
    End Sub

    Private Sub LbBicycles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBicycle.SelectedIndexChanged 'Populates the textboxes based on the chosen location in the listbox.
        Dim bicyclesSearch As New Bicycle()
        PutBicycles(DbManager.GetSpecific(bicyclesSearch, lbBicycle.SelectedValue.ToString()))
    End Sub

    Private Sub lstBicycles_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ContextMenuStrip only shows when an item is selected in the listbox.
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbBicycle.SelectedIndices.Count > 0 Then
                lbBicycle.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lbBicycle.ContextMenuStrip = Nothing
            End If
        End If
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click 'Deletes the selcted item.
        Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
        If MsgBox("Sikker på at du vil slette sykkelen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using sqlconnection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM Bicycle WHERE BicycleID= " & txtFramenbr.Text
                Dim insertsql As New MySqlCommand(query, sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable
                da.SelectCommand = insertsql
                da.Fill(table)
            End Using
            PutLbBicycles(GetAllBicycles)
        End If
    End Sub

    Private Sub BtnBicycleSave_Click(sender As Object, e As EventArgs) Handles btnBicycleSave.Click
        Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim framenbr As Integer = txtFramenbr.Text
            Dim bicycleType As String = cbType.SelectedItem.ToString
            Dim defaultLocation As String = cbDefaultLoc.SelectedItem.ToString
            Dim currentLocation As String = cbCurrentLoc.SelectedItem.ToString
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

            'Dim query As String
            'If framenbr ikke allerede eksisterer Then
            'query = "INSERT INTO Bicycle (BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status) "
            'query &= "VALUES ('" & framenbr & "', " & "'" & bicycleType & "', " & "'" & defaultLocation & "', " & "'" & currentLocation & "', " & "'" & status & "')"

            'Else If framenbr allerede eksisterer Then
            'query = "UPDATE INTO Bicycle"
            'query &= "SET BicycleType='" & bicycleType & "', DefaultLocation='" & defaultLocation & "', CurrentLocation='" & currentLocation & "', Status='" & status & "' "
            'query &= "WHERE BicycleID='" & framenbr & "'"
            'End if

            'Dim sql As New MySqlCommand(query, sqlconnection)
            'Dim da As New MySqlDataAdapter
            'Dim table As New DataTable
            'da.SelectCommand = sql
            'da.Fill(table)
        End Using
        PutLbBicycles(GetAllBicycles)
    End Sub
End Class