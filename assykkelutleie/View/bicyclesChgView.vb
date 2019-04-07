Imports MySql.Data.MySqlClient

Public Class bicyclesChgView
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
    Private searchID As String = bicyclesView.searchID

    'Sven-Erik
    Private Sub BicycleRegister_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using sqlconnection As New MySqlConnection(connectionString)
            If DbManager.connectedToServerAsync(sqlconnection).Result Then
                Convert.ToInt32(searchID)

                Dim status As Integer
                If rbAvailable.Checked = True Then
                    status = "Ledig"
                ElseIf rbRented.Checked = True Then
                    status = "Utleid"
                ElseIf rbService.Checked = True Then
                    status = "Service"
                ElseIf rbStolen.Checked = True Then
                    status = "Stjålet"
                End If

                Dim query As String
                query = "UPDATE Bicycle "
                query = query & "SET BicycleID='" & txtFramenbr.Text & "', BicycleType='" & cmbType.SelectedItem & "', DefaultLocation='" & cmbDefaultLoc.SelectedItem & "', CurrentLocation='" & cmbCurrentLoc.SelectedItem & "', Status='" & status
                query &= "' WHERE BicycleID='" & searchID & "'"

                Dim insertsql As New MySqlCommand(query, sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable
                da.SelectCommand = insertsql
                da.Fill(table)
            End If
        End Using

        Config.refreshBicycle()
        customersChgView.Close()
    End Sub

    'Sven-Erik
    Private Sub BicyclesChgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using sqlconnection As New MySqlConnection(connectionString)
            If DbManager.connectedToServerAsync(sqlconnection).Result Then
                Dim framenbr As Integer
                Dim bicycleType, defaultLocation, currentLocation, status As String
                searchID = searchID.Split(" ").First()
                Dim sql As New MySqlCommand("SELECT * FROM Bicycle where BicycleID= " & searchID, sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim interntabell As New DataTable

                da.SelectCommand = sql
                da.Fill(interntabell)
                Dim row As DataRow

                For Each row In interntabell.Rows
                    framenbr = row("BicycleID")
                    bicycleType = row("BicycleType")
                    defaultLocation = row("DefaultLocation")
                    currentLocation = row("CurrentLocation")
                    status = row("Status")
                Next row
                txtFramenbr.Text = framenbr
                cmbType.SelectedItem = bicycleType
                cmbDefaultLoc.SelectedItem = defaultLocation
                cmbCurrentLoc.SelectedItem = currentLocation

                If status = "Ledig" Then
                    rbAvailable.Checked = True
                ElseIf status = "Utleid" Then
                    rbRented.Checked = True
                ElseIf status = "Service" Then
                    rbService.Checked = True
                ElseIf status = "Stjålet" Then
                    rbStolen.Checked = True
                End If
            End If
        End Using
    End Sub
End Class