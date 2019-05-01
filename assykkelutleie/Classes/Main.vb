Public Class Main
    Public Shared Sub main(view, button)
        'The correct form is loaded to mainView.PanelMainView depending on the button
        mainView.SplitContainer1.Panel2.Controls.Clear()
        view.TopLevel = False
        mainView.SplitContainer1.Panel2.Controls.Add(view)
        view.Show()
    End Sub

    Public Shared Sub logout() 'Logout
        mainView.Hide()
        loginView.txtUsername.Text = ""
        loginView.txtPassword.Text = ""
        loginView.Show()
    End Sub
End Class
