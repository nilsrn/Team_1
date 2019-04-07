Public Class mainView
    'Sven-Erik
    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        Config.main(rentalView, btnRental)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Config.main(customersView, btnCustomers)
    End Sub

    Private Sub btnBicycles_Click(sender As Object, e As EventArgs) Handles btnBicycles.Click
        Config.main(bicyclesView, btnBicycles)
    End Sub

    Private Sub btnTransport_Click(sender As Object, e As EventArgs) Handles btnTransport.Click
        Config.main(transportView, btnTransport)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Config.main(adminView, btnAdmin)
    End Sub

    Private Sub mainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class