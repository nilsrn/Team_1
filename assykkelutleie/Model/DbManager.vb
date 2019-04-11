Imports MySql.Data.MySqlClient
Imports System.Reflection 'Provides objects that describe assemblies, modules and types.

Public Class DbManager

    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;" 'Vurdere sikkerheten her

    ' Function for creating a new user and storing it in the DB. Not finished. 
    Public Shared Sub insertNewUser(username As String, password As String, salt As String, accountType As String, location As String, firstName As String, surname As String, email As String, telephonenumber As String) 'Nils
        If Not duplicateUser(username) Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim insertNewUser As String = "INSERT INTO UserAccount(Username, Password, Salt, AccountType, Location, FirstName, Surname, Email, TelephoneNumber) VALUES(@user,@pass,@salt,@acc,@loc,@first,@sur,@email,@tel)"
                Dim SqlCommand As New MySqlCommand(insertNewUser, SqlConnection)
                SqlCommand.Parameters.AddWithValue("@user", username)
                SqlCommand.Parameters.AddWithValue("@pass", password)
                SqlCommand.Parameters.AddWithValue("@salt", salt)
                SqlCommand.Parameters.AddWithValue("@acc", accountType)
                SqlCommand.Parameters.AddWithValue("@loc", location)
                SqlCommand.Parameters.AddWithValue("@first", firstName)
                SqlCommand.Parameters.AddWithValue("@sur", surname)
                SqlCommand.Parameters.AddWithValue("@email", email)
                SqlCommand.Parameters.AddWithValue("@tel", telephonenumber)

                If connectedToServerAsync(SqlConnection).Result Then
                    SqlCommand.ExecuteNonQuery()
                    MsgBox(String.Format("{0} har blitt registrert som bruker", username))
                End If
                Return
            End Using
        End If
        MsgBox(String.Format("{0} er allerede registrert i systemet", username))
    End Sub

    ' Function to check if a user already exists
    Private Shared Function duplicateUser(username As String) As Boolean ' Nils
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkUserQuery As String = "SELECT COUNT(Username) FROM UserAccount WHERE username =@user"
            Dim sqlCommand As New MySqlCommand(checkUserQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@user", username)
            If connectedToServerAsync(SqlConnection).Result Then
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
    Public Shared Sub login(username As String, password As String) 'nils
        Dim salt As String = ""

        Using sqlconnection As New MySqlConnection(connectionString)
            Dim readsaltquery As String = "select * from UserAccount where username=@user"
            Dim sqlcommand As New MySqlCommand(readsaltquery, sqlconnection)
            sqlcommand.Parameters.AddWithValue("@user", username)

            If connectedToServerAsync(sqlconnection).Result Then
                Dim reader As MySqlDataReader = sqlcommand.ExecuteReader()
                While reader.Read()
                    salt = reader("salt").ToString()
                End While
                reader.Close()

                Dim pass = Encryption.HashString(password)
                Dim hashedandsalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))

                Dim checkloginquery As String = "select count(*) from UserAccount where username =@user and password =@pass"
                Dim sqlcommand0 As New MySqlCommand(checkloginquery, sqlconnection)
                sqlcommand0.Parameters.AddWithValue("@user", username)
                sqlcommand0.Parameters.AddWithValue("@pass", hashedandsalted)

                Dim results As Integer = Convert.ToInt32(sqlcommand0.ExecuteScalar)
                If results = 1 Then
                    MsgBox("Velkommen: " & username)
                    mainView.Show()
                    loginView.Hide()
                Else
                    MsgBox("feil brukernavn eller passord.")
                End If
            End If
        End Using
    End Sub


    'Function to verify that the application is connected to the Database. 
    Public Shared Async Function connectedToServerAsync(SqlConnection) As Task(Of Boolean) ' Nils
        Try
            Await SqlConnection.OpenAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return SqlConnection.State
    End Function 'Add; "If ConnectedToServerAsync(SqlConnection).Result Then" to verify that the connection is established before executing the query



    Public Shared Function GetTableName(obj As Object)   'Gets the name to the object that equals the tablename in the database. 
        Dim t As Type = obj.GetType()
        Return t.Name
    End Function

    Public Shared Function GetProperties(obj As Object)   'Gets all properties since they have the same name as the collums in the tables
        Dim t As Type = obj.GetType()
        Dim returnList As New List(Of String)
        Dim props() As PropertyInfo = t.GetProperties()
        For Each prop In props
            returnList.Add(prop.Name)
        Next
        Return returnList
    End Function

    Public Shared Function GetAllTableNames(obj) 'Gets all tables to an object and generates a string listing them all in SQL-format
        Dim AllTables As New List(Of String)
        AllTables = GetProperties(obj)
        Dim stringOfAllTables As String = ""
        For Each row In AllTables
            stringOfAllTables = stringOfAllTables + row + ", "
        Next
        stringOfAllTables = stringOfAllTables.Substring(0, stringOfAllTables.Length - 2)    'Removes the last comma in the string to avoid syntaxerrors 
        Return stringOfAllTables
    End Function

    Public Shared Function GetSpecific(obj As Object, primaryKey As String)   'Selects a spesfic record based on the primarykey in the DB.
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim returntable As New DataTable
            Try
                Dim listOfTables As New List(Of String)
                listOfTables = GetProperties(obj)
                Dim sql As New MySqlCommand("select * from " & GetTableName(obj) & " where " & listOfTables(0) & " = @primaryKey", sqlconnection)
                sql.Parameters.AddWithValue("@primarykey", primaryKey)
                Dim da As New MySqlDataAdapter(sql)
                da.Fill(returntable)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return returntable
        End Using
    End Function

    Public Shared Function GetAll(obj As Object)  'Select all from from a given table
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim sql As New MySqlCommand("select * from " & GetTableName(obj), sqlconnection)
            Dim da As New MySqlDataAdapter(sql)
            Dim returntable As New DataTable
            da.Fill(returntable)
            Return returntable
        End Using
    End Function

    ' Function to check if a bicycle already exists
    Public Shared Function duplicateBicycle(bicycleID As Integer) As Boolean ' Sven-Erik
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkBicycleQuery As String = "SELECT COUNT(BicycleID) FROM Bicycle WHERE bicycleID =@bicycle"
            Dim sqlCommand As New MySqlCommand(checkBicycleQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@bicycle", bicycleID)
            If connectedToServerAsync(SqlConnection).Result Then
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

    ' Function to check if a customer already exists
    Public Shared Function duplicateCustomer(CustomerID As Integer) As Boolean ' Ådne og Silje 🙂
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkCustomerQuery As String = "SELECT COUNT(CustomerID) FROM Customer WHERE CustomerID =@phone"
            Dim sqlCommand As New MySqlCommand(checkCustomerQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@phone", CustomerID)
            If connectedToServerAsync(SqlConnection).Result Then
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


    ' Function for creating/updating a new bicycle and storing it in the DB.
    Public Shared Sub insertNewBicycle(bicycleID As Integer, BicycleType As String, DefaultLocation As String, CurrentLocation As String, Status As String) 'Sven-Erik
        If Not duplicateBicycle(bicycleID) Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim insertNewBicycle As String = "INSERT INTO Bicycle(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status) VALUES(@id,@type,@defloc,@curloc,@status)"
                Dim SqlCommand As New MySqlCommand(insertNewBicycle, SqlConnection)
                SqlCommand.Parameters.AddWithValue("@id", bicycleID)
                SqlCommand.Parameters.AddWithValue("@type", BicycleType)
                SqlCommand.Parameters.AddWithValue("@defloc", DefaultLocation)
                SqlCommand.Parameters.AddWithValue("@curloc", CurrentLocation)
                SqlCommand.Parameters.AddWithValue("@status", Status)

                If connectedToServerAsync(SqlConnection).Result Then
                    SqlCommand.ExecuteNonQuery()
                    MsgBox(String.Format("{0} har blitt registrert", bicycleID))
                End If
                Return
            End Using
        ElseIf duplicateBicycle(bicycleID) Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim updateBicycle As String = "UPDATE Bicycle SET BicycleType=@type, DefaultLocation=@defloc, CurrentLocation=@curloc, Status=@status WHERE BicycleID=@id"
                Dim SqlCommand As New MySqlCommand(updateBicycle, SqlConnection)
                SqlCommand.Parameters.AddWithValue("@id", bicycleID)
                SqlCommand.Parameters.AddWithValue("@type", BicycleType)
                SqlCommand.Parameters.AddWithValue("@defloc", DefaultLocation)
                SqlCommand.Parameters.AddWithValue("@curloc", CurrentLocation)
                SqlCommand.Parameters.AddWithValue("@status", Status)

                If connectedToServerAsync(SqlConnection).Result Then
                    SqlCommand.ExecuteNonQuery()
                    MsgBox(String.Format("{0} har blitt oppdatert", bicycleID))
                End If
                Return
            End Using
        End If
    End Sub

    ' Function for deleting a bicycle.
    Public Shared Sub DeleteBicycle(bicycleID As Integer) 'Sven-Erik
        If MsgBox("Sikker på at du vil slette sykkelen?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using SqlConnection As New MySqlConnection(connectionString)
                Dim deleteBicycle As String = "DELETE FROM Bicycle WHERE BicycleID=@id"
                Dim SqlCommand As New MySqlCommand(deleteBicycle, SqlConnection)
                SqlCommand.Parameters.AddWithValue("@id", bicycleID)
                If connectedToServerAsync(SqlConnection).Result Then
                    SqlCommand.ExecuteNonQuery()
                    MsgBox(String.Format("{0} har blitt slettet", bicycleID))
                End If
                Return
            End Using
        End If
    End Sub






    ' Function to check if an ID already exists. Not finished.
    Public Shared Function duplicateID(ID As String, DB As String, input As Integer) As Boolean ' Sven-Erik
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(@id) FROM @db WHERE @id=@input"
            Dim SqlCommand As New MySqlCommand(query, SqlConnection)
            SqlCommand.Parameters.AddWithValue("@id", ID)
            SqlCommand.Parameters.AddWithValue("@DB", DB)
            SqlCommand.Parameters.AddWithValue("@input", input)
            If connectedToServerAsync(SqlConnection).Result Then
                SqlCommand.ExecuteNonQuery()
            End If
            Return True
        End Using
    End Function
End Class

