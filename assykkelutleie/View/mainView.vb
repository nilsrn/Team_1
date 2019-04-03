Public Class mainView
    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        Me.Enabled = True
        btnRental.Enabled = False

        rentalView.TopLevel = False
        rentalView.TopMost = True
        PanelMainView.Controls.Add(rentalView)
        rentalView.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Me.Enabled = True
        btnCustomers.Enabled = False

        customersView.TopLevel = False
        customersView.TopMost = True
        PanelMainView.Controls.Add(customersView)
        customersView.Show()
    End Sub

    Private Sub btnBicycles_Click(sender As Object, e As EventArgs) Handles btnBicycles.Click
        Me.Enabled = True
        btnBicycles.Enabled = False

        bicyclesView.TopLevel = False
        bicyclesView.TopMost = True
        PanelMainView.Controls.Add(bicyclesView)
        bicyclesView.Show()
    End Sub

    Private Sub btnTransport_Click(sender As Object, e As EventArgs) Handles btnTransport.Click
        Me.Enabled = True
        btnTransport.Enabled = False

        transportView.TopLevel = False
        transportView.TopMost = True
        PanelMainView.Controls.Add(transportView)
        transportView.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Enabled = True
        btnAdmin.Enabled = False

        adminView.TopLevel = False
        adminView.TopMost = True
        PanelMainView.Controls.Add(adminView)
        adminView.Show()
    End Sub
End Class