Public Class customerView
    Private Sub PutLbCustomer(table As DataTable) 'Populates the listbox with data received from the DB. 
        lbCustomer.DataSource = table
        lbCustomer.DisplayMember = "CustomerID"
        lbCustomer.ValueMember = "CustomerID"
    End Sub

    Private Function GetAllBicycles() 'Returns a DataTable with all customers.
        Dim customer As New Customer()
        Dim customerTable As DataTable = DbManager.GetAll(customer)
        Return customerTable
    End Function

    Private Sub PutBicycles(list As DataTable) 'Populates the textboxes with data from the DB.
        For Each row In list.Rows
            txtFirstname.Text = row("FirstName")
            txtSurname.Text = row("SurName")
            txtTelephone.Text = row("TelephoneNumber")
            txtEmail.Text = row("Email")
        Next
    End Sub

    Private Sub CustomerView_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Populates listboxes and dropdownmenues when the form loads.
        PutLbCustomer(GetAllBicycles)
    End Sub

    Private Sub BtnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click 'Updates the listbox according to the user input.
        Dim customerSearch As New Bicycle()
        Dim customer As String = txtCustomerSearch.Text
        Dim customerTable As DataTable = DbManager.GetSpecific(customerSearch, customer)
        PutLbCustomer(customerTable)
        If txtCustomerSearch.Text = "" Then
            PutLbCustomer(GetAllBicycles)
        End If
    End Sub

    Private Sub LbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCustomer.SelectedIndexChanged 'Populates the textboxes based on the chosen customer in the listbox.
        Dim customerSearch As New Customer()
        PutBicycles(DbManager.GetSpecific(customerSearch, lbCustomer.SelectedValue.ToString()))
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

    End Sub

    Private Sub BtnBicycleSave_Click(sender As Object, e As EventArgs) Handles btnBicycleSave.Click

    End Sub
End Class