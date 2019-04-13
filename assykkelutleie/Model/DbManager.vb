Imports MySql.Data.MySqlClient
Imports System.Reflection 'Provides objects that describe assemblies, modules and types.

Public Class DbManager

    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;" 'Vurdere sikkerheten her
    'Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"

    Public Shared Function Escaping(str As String) 'General function for escaping to avoid SQL-injection
        str.Replace("'", "\'")
        Return str
    End Function

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
            Dim readsaltquery As String = "SELECT * FROM UserAccount WHERE username=@user"
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

                Dim checkloginquery As String = "SELECT COUNT(*) FROM UserAccount WHERE username =@user AND password =@pass"
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
                Dim sql As New MySqlCommand("SELECT * from " & GetTableName(obj) & " WHERE " & listOfTables(0) & " = @primaryKey", sqlconnection)
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
            Dim sql As New MySqlCommand("SELECT * from " & GetTableName(obj), sqlconnection)
            Dim da As New MySqlDataAdapter(sql)
            Dim returntable As New DataTable
            da.Fill(returntable)
            Return returntable
        End Using
    End Function

    Public Shared Function GetAllValues(x) 'Gets the propertyvalues for an object(x) to insert into the database 
        Dim tableList As New List(Of String)
        tableList = GetProperties(x)
        Dim objectStringValues As String = ""
        For Each rad In tableList
            Dim objectValue = CallByName(x, rad, CallType.Method)
            If objectValue.ToString().Equals("True") Then objectValue = "1"
            If objectValue.ToString().Equals("False") Then objectValue = "0"
            objectStringValues = objectStringValues & "'" & objectValue & "'" & ", "
        Next
        objectStringValues = objectStringValues.Substring(0, objectStringValues.Length - 2) 'Removes the last comma in the string to avoid syntaxerrors 
        Return objectStringValues
    End Function

    Public Shared Function Insert(x As Object)   'Adds an object(x) to the database
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim sqlcommand As New MySqlCommand("INSERT INTO " & GetTableName(x) & " (" & GetAllTableNames(x) & ") VALUES (" & GetAllValues(x) & ")", sqlconnection)
            If connectedToServerAsync(sqlconnection).Result Then
                sqlcommand.ExecuteNonQuery()
            End If
        End Using
        Return True
    End Function

    Public Shared Sub Update(x As Object)  'Gets all the tables and values for the object(x) to be updated and then updates the record.
        Dim tableList As New List(Of String)
        tableList = GetProperties(x)
        Using sqlconnection As New MySqlConnection(connectionString)
            For Each row In tableList
                Dim sqlcommand As New MySqlCommand("UPDATE " & GetTableName(x) & " SET " & row & " = @value WHERE " & tableList.First() & " = @primarykey", sqlconnection)
                sqlcommand.Parameters.AddWithValue("@value", CallByName(x, row, CallType.Method))    'Gets the value of the object's property
                sqlcommand.Parameters.AddWithValue("@primarykey", CallByName(x, tableList.First(), CallType.Method))   'Gets the value for the first property(primary key) for the object(x).
                Try
                    sqlconnection.Open()
                    sqlcommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                sqlconnection.Close()
            Next
        End Using
    End Sub

    Public Shared Function InsertOrUpdate(x As Object)   'Sjekker om objektet finnes fra før og kjører insert dersom det ikke gjør det, eller oppdater dersom det finnes
        Dim listeAvProperties = GetProperties(x)
        If GetSpecific(x, Escaping(CallByName(x, listeAvProperties(0), CallType.Method))).rows.count() = 0 Then
            Insert(x)
            MsgBox(String.Format("{0} har blitt opprettet", x))
        Else
            Update(x)
            MsgBox(String.Format("{0} har blitt oppdatert", x))
        End If
        Return True
    End Function

    Public Shared Sub Delete(x As Object, column As String, condition As String) 'Deletes an object(x) from the database
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim sqlcommand As New MySqlCommand("DELETE FROM " & GetTableName(x) & " WHERE " & column & " = @condition", sqlconnection)
            sqlcommand.Parameters.AddWithValue("@condition", condition)
            If connectedToServerAsync(sqlconnection).Result Then
                sqlcommand.ExecuteNonQuery()
            End If
        End Using
    End Sub

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
End Class

