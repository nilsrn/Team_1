Imports MySql.Data.MySqlClient

Public Class DbManager

    'Dim connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"

    ' Funksjon for å opprette ny bruker. Denne må mappes til admin-panelet. 
    Public Shared Sub insertNewUser(username As String, password As String, salt As String)
        Dim connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
        If Not DuplicateUser(username) Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim insertNewUser As String = "INSERT INTO users(username, password, salt) VALUES(@user,@pass,@salt)"
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

    ' Funksjon for å sjekke om bruker fins fra før 
    Private Shared Function DuplicateUser(username As String) As Boolean
        Dim connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkUserQuery As String = "SELECT COUNT(username) FROM users WHERE username =@user"
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

    ' Funksjon for å logge inn
    Public Shared Sub Login(username As String, password As String)
        Dim salt As String = ""
        Dim connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim readSaltQuery As String = "SELECT * FROM users WHERE username=@user"
            Dim sqlCommand As New MySqlCommand(readSaltQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@user", username)

            If ConnectedToServerAsync(SqlConnection).Result Then
                Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    salt = reader("salt").ToString()
                End While
                reader.Close()

                Dim pass = Encryption.HashString(password)
                Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))

                Dim checkLoginQuery As String = "SELECT COUNT(*) FROM users WHERE username =@user AND password =@pass"
                Dim sqlCommand0 As New MySqlCommand(checkLoginQuery, SqlConnection)
                sqlCommand.Parameters.AddWithValue("@user", username)
                sqlCommand.Parameters.AddWithValue("@pass", hashedAndSalted)

                Dim results As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar)
                If results = 1 Then
                    MsgBox("Velkommen: " & username)
                Else
                    MsgBox("Feil brukernavn eller passord.")
                End If
            End If
        End Using
    End Sub


    'Funksjon for å forsikre seg om at man har kontakt med databasen
    Public Shared Async Function ConnectedToServerAsync(SqlConnection) As Task(Of Boolean)
        Try
            Await SqlConnection.OpenAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return SqlConnection.State
    End Function


End Class
