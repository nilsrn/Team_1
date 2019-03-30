' Background image: Free photo by Vishal Banik on Unsplash
' Logo made with https://hatchful.shopify.com/ 

Public Class loginView 'Nils

    Private Sub loginView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True 'Hides the password typed in
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click 'Button that sends the username and password to the Login function. 
        Dim username As String = Me.txtUsername.Text
        Dim password As String = Me.txtPassword.Text
        DbManager.Login(username, password)
    End Sub

End Class
