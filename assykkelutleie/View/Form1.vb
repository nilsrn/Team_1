Imports MySql.Data.MySqlClient

Public Class Form1
    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"


    Public Sub CustomerRegister_Click(sender As Object, e As EventArgs) Handles CustomerRegister.Click
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim firstname As String = firstnameTxt.Text
            Dim surname As String = surnameTxt.Text
            Dim TelephoneNumber As Integer = phoneTxt.Text
            Dim email As String = emailTxt.Text
            Dim query As String

            If firstnameTxt.Text = "" Or surnameTxt.Text = "" Or phoneTxt.Text = "" Or emailTxt.Text = "" Then
                MsgBox("Fyll ut alle feltene")
            Else


                query = "INSERT INTO Customer"
                query = query & " (FirstName, Surname, TelephoneNumber, Email)"
                query = query & " VALUES "
                query &= " ('" & firstname & "', " & "'" & surname & "', " & "'" & TelephoneNumber & "', " & "'" & email & "')"

                MsgBox("Kunde er registrert")

                Dim sql As New MySqlCommand(query, connection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable

                da.SelectCommand = sql
                da.Fill(table)

                connection.Close()
                CustomerRefresh.refreshCustomers()
            End If
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling" & mistake.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub

    Function tyepCheckInt(ByVal input As String) As Boolean
        Try
            Convert.ToInt32(input)
            Return True

        Catch ex As Exception
            Return False


        End Try
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()

            Dim CustomerID As Integer
            Dim firstname As String
            Dim surname As String
            Dim email As String
            Dim phone As Integer
            Dim search As Integer
            Dim sql As New MySqlCommand("SELECT * FROM Customer WHERE TelephoneNumber = '" & search & "'", connection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable

            da.SelectCommand = sql
            da.Fill(table)
            connection.Close()

            Dim row As DataRow


            If (IsNumeric(txtSearch.Text) = True) Then
                search = CInt(txtSearch.Text)
                ListBox1.Items.Clear()
                For Each row In table.Rows
                    CustomerID = row("CustomerID")
                    firstname = row("FirstName")
                    surname = row("Surname")
                    email = row("Email")
                    phone = row("TelephoneNumber")
                    ListBox1.Items.Add(firstname & " " & surname & " " & email & " " & phone)
                Next row
                txtSearch.Text = ""


            ElseIf phone <> search Then
                MessageBox.Show("Fant ikke " & search & " i databasen")
            ElseIf (IsNumeric(txtSearch.Text) = True) Then
                search = CInt(txtSearch.Text)
            Else
                MessageBox.Show("Skriv inn et nummer")


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
            MsgBox("Alt gikk greit med å koble til databasen")
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
                ListBox1.Items.Add(firstname & " " & surname & " " & email & " " & phone)

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


End Class
