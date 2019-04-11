Imports MySql.Data.MySqlClient
Public Class customerView
    Private Sub PutLbCustomer(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbCustomer.DataSource = table
        lbCustomer.DisplayMember = "CustomerID"
        lbCustomer.ValueMember = "CustomerID"

    End Sub

    Private Function GetAllCustomer() 'Returns a DataTable with all customers.
        Dim customer As New Customer()
        Dim customerTable As DataTable = DbManager.GetAll(customer)
        Return customerTable
    End Function

    Private Sub PutCustomer(list As DataTable) 'Populates the textboxes with data from the DB.

        For Each row In list.Rows
            txtTelephone.Text = row("CustomerID")
            txtFirstname.Text = row("FirstName")
            txtSurname.Text = row("Surname")
            txtEmail.Text = row("Email")
        Next
    End Sub

    Private Sub CustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        PutLbCustomer(GetAllCustomer)
    End Sub

    Private Sub BtnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click 'Updates the listbox according to the user input.
        Dim customerSearch As New Customer()
        Dim customer As String = txtCustomerSearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutLbCustomer(customerTable)
        If txtCustomerSearch.Text = "" Then
            PutLbCustomer(GetAllCustomer)
        End If
    End Sub

    Private Sub LbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCustomer.SelectedIndexChanged 'Populates the textboxes based on the chosen customer in the listbox.
        Dim customerSearch As New Customer()
        PutCustomer(DbManager.GetSpecific(customerSearch, lbCustomer.SelectedValue.ToString()))
    End Sub

    Private Sub lbCustomer_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'ContextMenuStrip only shows when an item is selected in the listbox.
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lbCustomer.SelectedIndices.Count > 0 Then
                lbCustomer.ContextMenuStrip = Me.ContextMenuStrip1
            Else
                lbCustomer.ContextMenuStrip = Nothing
            End If
        End If
    End Sub

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click
        Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
        If MsgBox("Sikker på at du vil slette kunden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using sqlconnection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM Customer WHERE CustomerID= " & txtCustomerSearch.Text
                Dim insertsql As New MySqlCommand(query, sqlconnection)
                Dim da As New MySqlDataAdapter
                Dim table As New DataTable
                da.SelectCommand = insertsql
                da.Fill(table)
            End Using
            PutLbCustomer(GetAllCustomer)
        End If
    End Sub

    Private Sub BtnCustomerSave_Click(sender As Object, e As EventArgs) Handles btnCustomerSave.Click
        Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim firstname As String = txtFirstname.Text
            Dim surname As String = txtSurname.Text
            Dim phone As Integer = txtTelephone.Text
            Dim email As String = txtEmail.Text
            Dim query As String
            If DbManager.duplicateCustomer(phone) = True Then
                query = "UPDATE Customer "
                query &= "SET FirstName='" & firstname & "', Surname='" & surname & "', Email='" & email & "' "
                query &= "WHERE CustomerID='" & phone & "'"
            ElseIf DbManager.duplicateBicycle(phone) = False Then
                query = "INSERT INTO Customer (CustomerID, FirstName, Surname, Email) "
                query &= "VALUES ('" & phone & "', " & "'" & firstname & "', " & "'" & surname & "', " & "'" & email & "')"
            End If
            Dim sql As New MySqlCommand(query, sqlconnection)
            Dim da As New MySqlDataAdapter
            Dim table As New DataTable
            da.SelectCommand = sql
            da.Fill(table)
        End Using
        PutLbCustomer(GetAllCustomer)
    End Sub

End Class