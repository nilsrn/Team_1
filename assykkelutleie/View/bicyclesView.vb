Imports MySql.Data.MySqlClient

Public Class bicyclesView
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
    Public searchID As String

    'Sven-Erik
    Private Sub BicycleRegister_Click(sender As Object, e As EventArgs) Handles btnBicycleRegister.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
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
            Dim sql As New MySqlCommand(query, connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable

            da.SelectCommand = sql
            da.Fill(table)
            connection.Close()

        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling" & mistake.Message)
        Finally
            connection.Dispose()
        End Try

        'Refreshes the list in "Sykkeloversikt"
        Config.refreshBicycle()
    End Sub

    'Sven-Erik
    Private Sub BicyclesLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBicycles.SelectedIndexChanged
        Dim connection As New MySqlConnection(connectionString)

        'Opens the bicyclesChgView form in order to edit values
        searchID = lstBicycles.SelectedItem
        Dim editbicycle As New bicyclesChgView
        editbicycle.Show()
    End Sub

    'Sven-Erik
    Private Sub BicyclesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Config.refreshBicycle()
    End Sub

    'Sven-Erik
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            'Search for BicycleID in the database
            Dim framenbr As Integer
            Dim bicycleType, defaultLocation, currentLocation, status As String
            Dim search As Integer = txtSearch.Text.ToString()
            Dim sql As New MySqlCommand("SELECT * FROM Bicycle WHERE BicycleID = '" & search & "'", connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable

            da.SelectCommand = sql
            da.Fill(table)
            connection.Close()

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
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class