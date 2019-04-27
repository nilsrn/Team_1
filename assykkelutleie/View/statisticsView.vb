Public Class statisticsView
#Region "General code for the form"
    Private Sub StatisticsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbManager.GetStatistics(Me.DataGridView1)
        GetProfit()
    End Sub
#End Region

#Region "Code for the Popularity tab"
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DbManager.GetStatistics(Me.DataGridView1)
    End Sub
#End Region

#Region "Code for the Profit tab"
    Private Sub GetProfit()
        txtTotal.Text = DbManager.GetSum(DateTimePicker1.Value)
        txtAverage.Text = Math.Round(DbManager.GetSum(DateTimePicker1.Value) / 12, 2)
        txtJanuary.Text = DbManager.GetMonth(DateTimePicker1.Value, 1)
        txtFebruary.Text = DbManager.GetMonth(DateTimePicker1.Value, 2)
        txtMarch.Text = DbManager.GetMonth(DateTimePicker1.Value, 3)
        txtApril.Text = DbManager.GetMonth(DateTimePicker1.Value, 4)
        txtMay.Text = DbManager.GetMonth(DateTimePicker1.Value, 5)
        txtJune.Text = DbManager.GetMonth(DateTimePicker1.Value, 6)
        txtJuly.Text = DbManager.GetMonth(DateTimePicker1.Value, 7)
        txtAugust.Text = DbManager.GetMonth(DateTimePicker1.Value, 8)
        txtSeptember.Text = DbManager.GetMonth(DateTimePicker1.Value, 9)
        txtOctober.Text = DbManager.GetMonth(DateTimePicker1.Value, 10)
        txtNovember.Text = DbManager.GetMonth(DateTimePicker1.Value, 11)
        txtDecember.Text = DbManager.GetMonth(DateTimePicker1.Value, 12)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        GetProfit()
    End Sub
#End Region
End Class