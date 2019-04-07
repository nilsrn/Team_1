Imports MySql.Data.MySqlClient

Public Class bicyclesView
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
    Public searchID As String

    'Sven-Erik
    Private Sub BicycleRegister_Click(sender As Object, e As EventArgs) Handles btnBicycleRegister.Click
        Using sqlconnection As New MySqlConnection(connectionString)
            If DbManager.connectedToServerAsync(sqlconnection).Result Then
                Dim framenbr As Integer = txtFramenbr.Text
                Dim bicycleType As String = cmbType.SelectedItem
                Dim defaultLocation As String = cmbDefaultLoc.SelectedItem
                Dim currentLocation As String = cmbCurrentLoc.SelectedItem
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

                'Adds the inserted values to the database
                Dim query As String
                query = "INSERT INTO Bicycle"
                query = query & " (BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status"
                query = query & " VALUES "
                query &= " ('" & framenbr & "', " & "'" & bicycleType & "', " & "'" & defaultLocation & "', " & "'" & currentLocation & "', " & "'" & status & "')"
                MsgBox(query)
                Dim sql As New MySqlCommand(query, sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable

                da.SelectCommand = sql
                da.Fill(table)
            End If
        End Using

        'Refreshes the list in "Sykkeloversikt"
        Config.refreshBicycle()
    End Sub

    'Sven-Erik
    Private Sub BicyclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.refreshBicycle()
    End Sub

    'Sven-Erik
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Search for BicycleID in the database
        Using sqlconnection As New MySqlConnection(connectionString)
            If DbManager.connectedToServerAsync(sqlconnection).Result Then
                Dim framenbr As Integer
                Dim bicycleType, defaultLocation, currentLocation, status As String
                Dim search As Integer = txtSearch.Text.ToString()
                Dim sql As New MySqlCommand("SELECT * FROM Bicycle WHERE BicycleID = '" & search & "'", sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable

                da.SelectCommand = sql
                da.Fill(table)

                Dim row As DataRow
                lstBicycles.Items.Clear()
                For Each row In table.Rows
                    framenbr = row("BicycleID")
                    bicycleType = row("BicycleType")
                    defaultLocation = row("DefaultLocation")
                    currentLocation = row("CurrentLocation")
                    status = row("Status")
                    lstBicycles.Items.Add(framenbr & " " & bicycleType & " " & defaultLocation & " " & currentLocation & " " & status)
                Next row
                txtSearch.Text = ""
                If framenbr <> search Then
                    MessageBox.Show("Fant ikke " & search & " i databasen")
                End If
            End If
        End Using
    End Sub

    Private Sub EndreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndreToolStripMenuItem.Click
        Dim connection As New MySqlConnection(connectionString)

        'Opens the bicyclesChgView form in order to edit values
        searchID = lstBicycles.SelectedItem
        Dim editbicycle As New bicyclesChgView
        editbicycle.Show()
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click
        'Deletes the selcted item in lstBicycles
        Using sqlconnection As New MySqlConnection(connectionString)
            If DbManager.connectedToServerAsync(sqlconnection).Result Then
                searchID = lstBicycles.SelectedItem
                Convert.ToInt32(searchID)

                Dim query As String
                query = "DELETE FROM Bicycle WHERE BicycleID= " & searchID

                MsgBox("Sikker på at du vil slette kunden?", MsgBoxStyle.YesNo)
                If MsgBoxResult.Yes Then
                    Dim insertsql As New MySqlCommand(query, sqlconnection)
                    Dim da As New MySqlDataAdapter
                    Dim table As New DataTable
                    da.SelectCommand = insertsql
                    da.Fill(table)
                End If
            End If
        End Using

        Config.refreshBicycle()
    End Sub

    Private Sub lstBicycles_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstBicycles.MouseDown
        'ContextMenuStrip only shows when an item is selected in the listbox
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lstBicycles.SelectedIndices.Count > 0 Then
                lstBicycles.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lstBicycles.ContextMenuStrip = Nothing
            End If
        End If
    End Sub
End Class