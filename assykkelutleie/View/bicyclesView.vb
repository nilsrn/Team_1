Imports MySql.Data.MySqlClient

Public Class bicyclesView
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"

    Private Sub BicycleRegister_Click(sender As Object, e As EventArgs) Handles bicycleRegister.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim terrengsykkel As String
            Dim Downhill As String
            Dim Racer As String
            Dim Barnesykkel As String

            Dim query As String
            query = "INSERT INTO nyesykler"
            query = query & " (RammenummerID, Sykkeltype, Hjulstørrelse, Girsystem, Lokasjon, tilstand, Status "
            query = query & " VALUES "

            query &= " ('" & terrengsykkel & "', " & "'" & Downhill & "', " & "'" & Racer & "', " & "'" & Barnesykkel & "')"
            MsgBox(query)
            Dim sql As New MySqlCommand(query, connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)

            connection.Close()
            'End If
        Catch feil As MySqlException
            MsgBox("Feil ved tilkobling" & feil.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public searchID As String

    Private Sub BicyclesLst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bicyclesLst.SelectedIndexChanged
        Dim connection As New MySqlConnection(connectionString)

        searchID = bicyclesLst.SelectedItem
        Dim editcustomer As New bicyclesChgView
        editcustomer.Show()
    End Sub
End Class