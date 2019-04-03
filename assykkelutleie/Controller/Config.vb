Public Class Config
    'Sven-Erik
    Public Shared Sub main(view, button)
        mainView.Enabled = True
        button.Enabled = False

        view.TopLevel = False
        view.TopMost = True
        PanelMainView.Controls.Add(view)
        view.Show()
    End Sub
End Class
