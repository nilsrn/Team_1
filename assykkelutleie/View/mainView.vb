Public Class mainView
    'Sven-Erik
    Private Sub btnRental_Click(sender As Object, e As EventArgs) Handles btnRental.Click
        Main.main(rentalView, btnRental)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Main.main(customerView, btnCustomers)
    End Sub

    Private Sub btnBicycles_Click(sender As Object, e As EventArgs) Handles btnBicycles.Click
        Main.main(bicycleView, btnBicycles)
    End Sub

    Private Sub btnTransport_Click(sender As Object, e As EventArgs) Handles btnTransport.Click
        Main.main(transportView, btnTransport)
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        If My.Settings.accounttype = "Administrator" Then
            Main.main(adminView, btnAdmin)
        Else
            MsgBox("Kun administratorer har tilgang her")
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Main.logout()
    End Sub

    Private Sub Window1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        End
    End Sub

End Class