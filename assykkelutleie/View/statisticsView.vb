Public Class statisticsView
#Region "General code for the form"
    Private Sub StatisticsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllForStatistics()
    End Sub
#End Region

#Region "Code for the Popularity tab"
    Private Sub GetAllForStatistics()    'Gets number of used bicycletyes. 
        Dim bicycletype As New BicycleType()
        Dim StatisticsList As DataTable = DbManager.GetAll(bicycletype)

        lbStatistics.Items.Clear()
        For Each row In StatisticsList.Rows
            Dim b = New BicycleType With {.Name = row("Name"), .Description = row("Description")}  'Oppretter sykkelobjektet og legger til i listboksen
            lbStatistics.Items.Add(b)
        Next
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetAllForStatistics()
    End Sub
#End Region

#Region "Code for the Profit tab"
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
#End Region
End Class