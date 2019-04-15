Imports MySql.Data.MySqlClient
Public Class customerView
    Private Sub PutLbCustomer(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbCustomer.DataSource = table
        lbCustomer.DisplayMember = "Surname"
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

    Private Sub SlettToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlettToolStripMenuItem.Click 'Deletes the selected item
        If MsgBox("Sikker på at du vil slette kunden?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim customer As New Customer()
                Dim customerID As Integer = lbCustomer.SelectedValue
                DbManager.Delete(customer, "CustomerID", customerID)
            Catch ex As Exception
            End Try
        End If
        PutLbCustomer(GetAllCustomer)
    End Sub

    Private Sub BtnCustomerSave_Click(sender As Object, e As EventArgs) Handles btnCustomerSave.Click
        Dim firstname, surname, email As String
        Dim phone As Integer
        If txtTelephone.Text = "" Then
            MessageBox.Show("Telefonnummer må fylles ut")
        Else
            Try
                firstname = txtFirstname.Text
                surname = txtSurname.Text
                email = txtEmail.Text
                phone = txtTelephone.Text

                Dim updateCustomer As New Customer(firstname, surname, email, phone)
                DbManager.InsertOrUpdate(updateCustomer) 'blir ikke oppdatert eller laget ny
            Catch ex As Exception
            End Try
        End If
        PutLbCustomer(GetAllCustomer)
    End Sub

End Class
'Dim connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"
'Using sqlconnection As New MySqlConnection(connectionString)
'Dim firstname As String = txtFirstname.Text
'Dim surname As String = txtSurname.Text
'Dim phone As Integer = txtTelephone.Text
'Dim email As String = txtEmail.Text
'Dim query As String
'If DbManager.duplicateCustomer(phone) = True Then
'query = "UPDATE Customer "
'query &= "SET FirstName='" & firstname & "', Surname='" & surname & "', Email='" & email & "' "
'query &= "WHERE CustomerID='" & phone & "'"
'ElseIf DbManager.duplicateCustomer(phone) = False Then
'query = "INSERT INTO Customer (CustomerID, FirstName, Surname, Email) "
'query &= "VALUES ('" & phone & "', " & "'" & firstname & "', " & "'" & surname & "', " & "'" & email & "')"
'End If
'Dim sql As New MySqlCommand(query, sqlconnection)
'Dim da As New MySqlDataAdapter
'Dim table As New DataTable
'da.SelectCommand = sql
'da.Fill(table)
'End Using