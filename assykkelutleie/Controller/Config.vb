Public Class Config
    'Sven-Erik
    Public Shared Sub main(view, button)
        For Each ctl As Control In mainView.Controls
            ctl.Enabled = True
        Next
        button.Enabled = False

        mainView.PanelMainView.Controls.Clear()
        view.TopLevel = False
        mainView.PanelMainView.Controls.Add(view)
        view.Show()
    End Sub
End Class
