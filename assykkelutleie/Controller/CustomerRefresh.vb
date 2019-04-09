
Imports MySql.Data.MySqlClient

Public Class CustomerRefresh
    Private Shared connectionstring As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"


    Public Shared Sub refreshCustomers()

        Using sqlconnection As New MySqlConnection(connectionstring)

            Dim CustomerID As Integer
            Dim phone As Integer
            Dim firstname As String
            Dim surname As String
            Dim email As String

            Dim sql As New MySqlCommand("SELECT * FROM Customer ORDER BY CustomerID", sqlconnection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable
            da.SelectCommand = sql
            da.Fill(table)

            Form1.ListBox1.Items.Clear()
            For Each row In table.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                Form1.ListBox1.Items.Add(firstname & " " & surname & " " & email & " " & phone)

            Next row
        End Using
    End Sub
End Class

