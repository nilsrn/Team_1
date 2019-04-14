Module Kladd
    'Sub Main()

    '    'Dim username As String = "Admins"
    ''Dim password = Encryption.HashString("Tastatur123")
    ''Dim salt = Encryption.GenerateSalt
    ''Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", password, salt))

    ''Console.WriteLine(password)
    ''Console.WriteLine(salt)
    ''Console.WriteLine(hashedAndSalted)


    ''DbManager.insertNewUser(username, hashedAndSalted, salt)
    ''DbManager.Login(username, "Tastatur123")
    '' Creates a new user and storing it in the DB. Not finished. will be moved
    'Public Shared Sub InsertNewUser(username As String, password As String, salt As String, accountType As String, location As String, firstName As String, surname As String, email As String, telephonenumber As String) 'Nils
    '    If Not DuplicatedUser(username) Then
    '        Using SqlConnection As New MySqlConnection(connectionString)
    '            Dim insertNewUser As String = "INSERT INTO UserAccount(Username, Password, Salt, AccountType, Location, FirstName, Surname, Email, TelephoneNumber) VALUES(@user,@pass,@salt,@acc,@loc,@first,@sur,@email,@tel)"
    '            Dim SqlCommand As New MySqlCommand(insertNewUser, SqlConnection)
    '            SqlCommand.Parameters.AddWithValue("@user", username)
    '            SqlCommand.Parameters.AddWithValue("@pass", password)
    '            SqlCommand.Parameters.AddWithValue("@salt", salt)
    '            SqlCommand.Parameters.AddWithValue("@acc", accountType)
    '            SqlCommand.Parameters.AddWithValue("@loc", location)
    '            SqlCommand.Parameters.AddWithValue("@first", firstName)
    '            SqlCommand.Parameters.AddWithValue("@sur", surname)
    '            SqlCommand.Parameters.AddWithValue("@email", email)
    '            SqlCommand.Parameters.AddWithValue("@tel", telephonenumber)

    '            If ConnectedToServerAsync(SqlConnection).Result Then
    '                SqlCommand.ExecuteNonQuery()
    '                MsgBox(String.Format("{0} har blitt registrert som bruker", username)) 'Needs verification 31
    '            End If
    '            Return
    '        End Using
    '    End If
    '    MsgBox(String.Format("{0} er allerede registrert i systemet", username)) 'Needs verification 31
    'End Sub

    '' Function to check if a user already exists - Must be made general
    'Public Shared Function DuplicatedUser(username As String) As Boolean ' Nils
    '    Using SqlConnection As New MySqlConnection(connectionString)
    '        Dim checkUserQuery As String = "SELECT COUNT(Username) FROM UserAccount WHERE username =@user"
    '        Dim sqlCommand As New MySqlCommand(checkUserQuery, SqlConnection)
    '        sqlCommand.Parameters.AddWithValue("@user", username)
    '        If ConnectedToServerAsync(SqlConnection).Result Then
    '            Dim results As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar)
    '            If results > 0 Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End If
    '    End Using
    '    Return True 'Returns true if the query fails to run
    'End Function
    'End Sub


End Module
