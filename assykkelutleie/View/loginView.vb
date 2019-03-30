' Background image: Free photo by Vishal Banik on Unsplash
' Logo made with https://hatchful.shopify.com/ 
Public Class loginView

    Private Sub loginView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = Me.txtUsername.Text
        Dim password As String = Me.txtPassword.Text
        DbManager.Login(username, password)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
