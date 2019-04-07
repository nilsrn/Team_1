Imports MySql.Data.MySqlClient

Public Class Config
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"

    'Sven-Erik
    Public Shared Sub main(view, button)
        'Enables all buttons except the one active
        For Each ctl As Control In mainView.Controls
            ctl.Enabled = True
        Next
        button.Enabled = False

        'The correct form is loaded to mainView.PanelMainView depending on the button
        mainView.PanelMainView.Controls.Clear()
        view.TopLevel = False
        mainView.PanelMainView.Controls.Add(view)
        view.Show()
    End Sub

    'Sven-Erik
    Public Shared Sub refreshBicycle()
        'Refreshes "Sykkeloversikt"
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim framenbr As Integer
            Dim bicycleType, defaultLocation, currentLocation, status As String
            Dim sql As New MySqlCommand("SELECT * FROM Bicycle ORDER BY BicycleID", sqlconnection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable
            da.SelectCommand = sql
            da.Fill(table)

            bicyclesView.lstBicycles.Items.Clear()
            For Each row In table.Rows
                framenbr = row("BicycleID")
                bicycleType = row("BicycleType")
                defaultLocation = row("DefaultLocation")
                currentLocation = row("CurrentLocation")
                status = row("Status")
                bicyclesView.lstBicycles.Items.Add(framenbr & " " & bicycleType & " " & defaultLocation & " " & currentLocation & " " & status)
            Next row
        End Using
    End Sub
End Class
