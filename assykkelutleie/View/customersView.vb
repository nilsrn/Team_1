Imports MySql.Data.MySqlClient

Public Class customersView
    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"

    Private Sub CustomerRegister_Click(sender As Object, e As EventArgs) Handles CustomerRegister.Click
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

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs)
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
            lstCustomers.Items.Clear()
            For Each row In table.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                lstCustomers.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)
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

    Private Sub CustomersView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


            lstCustomers.Items.Clear()
            For Each row In interntabell.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                lstCustomers.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)

            Next row
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Public searchID As String

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim connection As New MySqlConnection(connectionString)

        searchID = lstCustomers.SelectedItem
        Dim editcustomer As New customersChgView
        editcustomer.Show()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs)
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


            lstCustomers.Items.Clear()
            For Each row In table.Rows
                CustomerID = row("CustomerID")
                firstname = row("FirstName")
                surname = row("Surname")
                email = row("Email")
                phone = row("TelephoneNumber")
                lstCustomers.Items.Add(CustomerID & " " & firstname & " " & surname & " " & email & " " & phone)

            Next row
        Catch mistake As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & mistake.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub lstCustomers_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ContextMenuStrip only shows when an item is selected in the listbox.
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lstCustomers.SelectedIndices.Count > 0 Then
                lstCustomers.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lstCustomers.ContextMenuStrip = Nothing
            End If
        End If
    End Sub
End Class