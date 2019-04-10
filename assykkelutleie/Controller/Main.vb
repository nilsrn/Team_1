Imports MySql.Data.MySqlClient

Public Class Main
    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;"

    'Sven-Erik
    Public Shared Sub main(view, button)
        'Enables all buttons except the one active
        For Each ctl As Control In mainView.Controls
            ctl.Enabled = True
        Next
        button.Enabled = False

        'The correct form is loaded to mainView.PanelMainView depending on the button
        mainView.PanelMainView.Controls.Clear()
        view.TopLevel = False
        mainView.PanelMainView.Controls.Add(view)
        view.Show()
    End Sub
End Class
