Imports MySql.Data.MySqlClient

Public Class Form1
    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"


    Public Sub CustomerRegister_Click(sender As Object, e As EventArgs) Handles CustomerRegister.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim firstname As String = firstnameTxt.Text
            Dim surname As String = surnameTxt.Text
            Dim TelephoneNumber As Integer = phoneTxt.Text
            Dim email As String = emailTxt.Text
            Dim birth As Date = birthTxt.Text

            Dim query As String

            query = "INSERT INTO Customer"
            query = query & " (FirstName, Surname, TelephoneNumber, Email)"
            query = query & " VALUES "
            query &= " ('" & firstname & "', " & "'" & surname & "', " & "'" & TelephoneNumber & "', " & "'" & email & "')"
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

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()

            Dim CustomerID As Integer
            Dim firstname As String
            Dim surname As String
            Dim email As String
            Dim phone As Integer
            Dim search As Integer = txtSearch.Text.ToString()
            Dim sql As New MySqlCommand("SELECT * FROM Customer WHERE TelephoneNumber = '" & search & "'", connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable

            da.SelectCommand = sql
            da.Fill(table)
            connection.Close()

            Dim row As DataRow
            ListBox1.Items.Clear()
            For Each row In table.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                ListBox1.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)
            Next row
            txtSearch.Text = ""
            If phone <> search Then
                MessageBox.Show("Fant ikke " & search & " i databasen")
            End If
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " &
            mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim connection As New MySqlConnection(connectionString)
        Try

            connection.Open()
            Dim CustomerID As Integer
            Dim phone As Integer
            Dim firstname As String
            Dim surname As String
            Dim email As String
            
            Dim sql As New MySqlCommand("SELECT * FROM Customer ORDER BY CustomerID", connection)
            Dim da As New MySqlDataAdapter
            Dim interntabell As New DataTable
            da.SelectCommand = sql
            da.Fill(interntabell)
            connection.Close()


            ListBox1.Items.Clear()
            For Each row In interntabell.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                ListBox1.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)

            Next row
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    Public searchID As String

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim connection As New MySqlConnection(connectionString)

        searchID = ListBox1.SelectedItem
        Dim editcustomer As New endre
        editcustomer.Show()

    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        Dim connection As New MySqlConnection(connectionString)
        Try

            connection.Open()
            Dim CustomerID As Integer
            Dim phone As Integer
            Dim firstname As String
            Dim surname As String
            Dim email As String

            Dim sql As New MySqlCommand("SELECT * FROM Customer ORDER BY CustomerID", connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable
            da.SelectCommand = sql
            da.Fill(table)
            connection.Close()


            ListBox1.Items.Clear()
            For Each row In table.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                ListBox1.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)

            Next row
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub


    'Private shared Function checkPhonenumber(phone As Integer) As Boolean
    'Using connection As New MySqlConnection(connectionString)
    'Dim checkphone As String = "Select COUNT(TelephoneNumber) From Customer where TelephoneNumber=" & "'" & phone & "'"
    'Dim sqlcheck As New MySqlCommand(checkphone, connection)
    '   sqlcheck.Parameters.AddWithValue("TelephoneNumber", phone)
    'esults As Integer = Convert.ToInt32(sqlcheck.ExecuteScalar)
    'If results > 0 Then
    'Return True
    'Else
    'lse

    'End If



    'End Using
    'Return True
    ' End Function
End Class
