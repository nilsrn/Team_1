Public Class mainView
    'Sven-Erik
    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        Main.main(rentalView, btnRental)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Main.main(customersView, btnCustomers)
    End Sub

    Private Sub btnBicycles_Click(sender As Object, e As EventArgs) Handles btnBicycles.Click
        Main.main(bicycleView, btnBicycles)
    End Sub

    Private Sub btnTransport_Click(sender As Object, e As EventArgs) Handles btnTransport.Click
        Main.main(transportView, btnTransport)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Main.main(adminView, btnAdmin)
    End Sub
End Class