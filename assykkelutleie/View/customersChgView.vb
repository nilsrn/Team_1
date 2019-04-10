Imports MySql.Data.MySqlClient

Public Class customersChgView
    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
    Private searchID As String = customersView.searchID

    Private Sub UpdateCustomer_Click(sender As Object, e As EventArgs) Handles updateCustomer.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Convert.ToInt32(searchID)


            Dim query As String
            query = "UPDATE Customer "
            query = query & "SET FirstName='" & firstnametxt.Text & "', Surname='" & surnametxt.Text & "', TelephoneNumber='" & phonetxt.Text & "', Email='" & mailtxt.Text
            query &= "' WHERE CustomerID='" & searchID & "'"

            Dim insertsql As New MySqlCommand(query, connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable
            da.SelectCommand = insertsql
            da.Fill(table)
            connection.Close()
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub DeleteCustomer_Click(sender As Object, e As EventArgs) Handles deleteCustomer.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Convert.ToInt32(searchID)


            Dim query As String
            query = "DELETE FROM Customer WHERE CustomerID= " & searchID

            MsgBox("Sikker på at du vil slette kunden?", MsgBoxStyle.YesNo)
            If MsgBoxResult.Yes Then

                Dim insertsql As New MySqlCommand(query, connection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable
                da.SelectCommand = insertsql
                da.Fill(table)
                connection.Close()
            Else
                MsgBox("OK")
            End If

        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub CustomersChgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New MySqlConnection(connectionString)
        Dim id, phonenumber As Integer
        Dim Firstname, surname, email As String

        searchID = searchID.Split(" ").First()

        Try
            connection.Open()
            Dim sql As New MySqlCommand("SELECT * FROM Customer where CustomerID= " & searchID, connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable

            da.SelectCommand = sql
            da.Fill(interntabell)
            connection.Close()
            Dim row As DataRow

            For Each row In interntabell.Rows
                id = row("CustomerID")
                Firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phonenumber = row("TelephoneNumber")

            Next row
            idlabel.Text = id
            firstnametxt.Text = Firstname
            surnametxt.Text = surname
            phonetxt.Text = phonenumber
            mailtxt.Text = email



        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()

        End Try
    End Sub
End Class