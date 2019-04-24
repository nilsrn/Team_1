Imports MySql.Data.MySqlClient
Public Class statisticsView
#Region "General code for the form"
    Private Sub StatisticsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbManager.GetStatistics(Me.DataGridView1)
    End Sub
#End Region

#Region "Code for the Popularity tab"
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DbManager.GetStatistics(Me.DataGridView1)
    End Sub
#End Region

#Region "Code for the Profit tab"
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
#End Region
End Class