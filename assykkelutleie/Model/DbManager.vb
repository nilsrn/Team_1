Imports MySql.Data.MySqlClient

Public Class DbManager

    Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;" 'Vurdere sikkerheten her

    ' Function for creating a new user and storing it in the DB. Not finished. 
    Public Shared Sub insertNewUser(username As String, password As String, salt As String) 'Nils
        If Not DuplicateUser(username) Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim insertNewUser As String = "INSERT INTO UserAccount(Username, Password, Salt) VALUES(@user,@pass,@salt)"
                Dim SqlCommand As New MySqlCommand(insertNewUser, SqlConnection)
                SqlCommand.Parameters.AddWithValue("@user", username)
                SqlCommand.Parameters.AddWithValue("@pass", password)
                SqlCommand.Parameters.AddWithValue("@salt", salt)

                If ConnectedToServerAsync(SqlConnection).Result Then
                    SqlCommand.ExecuteNonQuery()
                    MsgBox(String.Format("{0} har blitt registrert som bruker", username))
                End If
                Return
            End Using
        End If
        MsgBox(String.Format("{0} er allerede registrert i systemet", username))
    End Sub

    ' Function to check if a user already exists
    Private Shared Function DuplicateUser(username As String) As Boolean ' Nils
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkUserQuery As String = "SELECT COUNT(Username) FROM UserAccount WHERE username =@user"
            Dim sqlCommand As New MySqlCommand(checkUserQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@user", username)
            If ConnectedToServerAsync(SqlConnection).Result Then
                Dim results As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar)
                If results > 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Using
        Return True
    End Function

    ' Function for logging in
    Public Shared Sub Login(username As String, password As String) 'Nils
        Dim salt As String = ""

        Using SqlConnection As New MySqlConnection(connectionString)
            Dim readSaltQuery As String = "SELECT * FROM UserAccount WHERE username=@user"
            Dim sqlCommand As New MySqlCommand(readSaltQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@user", username)

            If ConnectedToServerAsync(SqlConnection).Result Then
                Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    salt = reader("Salt").ToString()
                End While
                reader.Close()

                Dim pass = Encryption.HashString(password)
                Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))

                Dim checkLoginQuery As String = "SELECT COUNT(*) FROM UserAccount WHERE Username =@user AND Password =@pass"
                Dim sqlCommand0 As New MySqlCommand(checkLoginQuery, SqlConnection)
                sqlCommand0.Parameters.AddWithValue("@user", username)
                sqlCommand0.Parameters.AddWithValue("@pass", hashedAndSalted)

                Dim results As Integer = Convert.ToInt32(sqlCommand0.ExecuteScalar)
                If results = 1 Then
                    MsgBox("Velkommen: " & username)
                    mainView.Show()
                    loginView.Hide()
                Else
                    MsgBox("Feil brukernavn eller passord.")
                End If
            End If
        End Using
    End Sub


    'Function to verify that the application is connected to the Database. 
    Public Shared Async Function ConnectedToServerAsync(SqlConnection) As Task(Of Boolean) ' Nils
        Try
            Await SqlConnection.OpenAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return SqlConnection.State
    End Function 'Add If ConnectedToServerAsync(SqlConnection).Result Then' to verify that the connection is established before executing the query

End Class
