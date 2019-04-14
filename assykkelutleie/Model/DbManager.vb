Imports MySql.Data.MySqlClient
Imports System.Reflection 'Provides objects that describe assemblies, modules and types.

Public Class DbManager
#Region "General databse functions"
    Private Shared connectionString As String = "Server=mysql-ait.stud.idi.ntnu.no;Database=nilsrle;Uid=nilsrle;Pwd=TnAzsu4O;" 'Vurdere sikkerheten her
    'Private Shared connectionString As String = "Server=mysql.stud.ntnu.no;Database=nilsrle_assykkelutleie;Uid=nilsrle_team1;Pwd=Tastatur123;"

    ' Login
    Public Shared Sub Login(username As String, password As String) 'Nils
        Dim salt As String = "" 'Empty because using a DataReader wich will get the specific users salt from the DB. 

        Using sqlconnection As New MySqlConnection(connectionString)
            Dim readsaltquery As String = "SELECT * FROM UserAccount WHERE username=@user"
            Dim sqlcommand As New MySqlCommand(readsaltquery, sqlconnection)
            sqlcommand.Parameters.AddWithValue("@user", username)

            If ConnectedToServerAsync(sqlconnection).Result Then
                Dim reader As MySqlDataReader = sqlcommand.ExecuteReader() 'Gets the salt for the user
                While reader.Read()
                    salt = reader("salt").ToString()
                End While
                reader.Close()

                Dim pass = Encryption.HashString(password)
                Dim hashedandsalted = Encryption.HashString(String.Format("{0}{1}", pass, salt))

                Dim checkloginquery As String = "SELECT COUNT(*) FROM UserAccount WHERE username =@user AND password =@pass"
                Dim sqlcommand1 As New MySqlCommand(checkloginquery, sqlconnection)
                sqlcommand1.Parameters.AddWithValue("@user", username)
                sqlcommand1.Parameters.AddWithValue("@pass", hashedandsalted)

                Dim results As Integer = Convert.ToInt32(sqlcommand1.ExecuteScalar) ' Reads the ammount of results
                If results = 1 Then
                    MsgBox("Velkommen: " & username, MsgBoxStyle.Information, "AS SykkelUtleie")
                    mainView.Show()
                    loginView.Hide()
                Else
                    MsgBox("Feil brukernavn eller passord.", MsgBoxStyle.Critical, "AS SykkelUtleie")
                End If
            End If
        End Using
    End Sub

    'Function to verify that the application is connected to the database. Also opens a connection to the database
    Public Shared Async Function ConnectedToServerAsync(SqlConnection) As Task(Of Boolean) ' Nils
        Try
            Await SqlConnection.OpenAsync()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return SqlConnection.State
    End Function 'Add; "If ConnectedToServerAsync(SqlConnection).Result Then" to verify that the connection is established and open a connection to the database before executing a query
#End Region

#Region "Get functions for the database"
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
#End Region

#Region "Insert, update and delete functions for the database"
    Public Shared Sub Insert(x As Object)   'Adds an object(x) to the database
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim sqlcommand As New MySqlCommand("INSERT INTO " & GetTableName(x) & " (" & GetAllTableNames(x) & ") VALUES (" & GetAllValues(x) & ")", sqlconnection)
            If ConnectedToServerAsync(sqlconnection).Result Then
                sqlcommand.ExecuteNonQuery()
            End If
        End Using
    End Sub

    Public Shared Sub Update(x As Object)  'Gets all the tables and values for the object(x) to be updated and then updates the record.
        Dim tableList As New List(Of String)
        tableList = GetProperties(x)
        Using sqlconnection As New MySqlConnection(connectionString)
            For Each row In tableList
                Dim sqlcommand As New MySqlCommand("UPDATE " & GetTableName(x) & " SET " & row & " = @value WHERE " & tableList.First() & " = @primarykey", sqlconnection)
                sqlcommand.Parameters.AddWithValue("@value", CallByName(x, row, CallType.Method))    'Gets the value of the object's property
                sqlcommand.Parameters.AddWithValue("@primarykey", CallByName(x, tableList.First(), CallType.Method))   'Gets the value for the first property(primary key) for the object(x).
                If ConnectedToServerAsync(sqlconnection).Result Then
                    sqlcommand.ExecuteNonQuery()
                    sqlconnection.Close()
                End If
            Next
        End Using
    End Sub

    Public Shared Sub InsertOrUpdate(x As Object)   'Checks if the object exists. If it does not exist it will execute an Insert. If it does exist it will do an Update.
        Dim listOfProperties = GetProperties(x)
        If GetSpecific(x, Encryption.Escaping(CallByName(x, listOfProperties(0), CallType.Method))).rows.count() = 0 Then
            Insert(x)
            MsgBox(String.Format("{0} har blitt opprettet", x))
        Else
            Update(x)
            MsgBox(String.Format("{0} har blitt oppdatert", x))
        End If
    End Sub

    Public Shared Sub Delete(x As Object, column As String, condition As String) 'Deletes an object(x) from the database
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim sqlcommand As New MySqlCommand("DELETE FROM " & GetTableName(x) & " WHERE " & column & " = @condition", sqlconnection)
            sqlcommand.Parameters.AddWithValue("@condition", condition)
            If ConnectedToServerAsync(sqlconnection).Result Then
                sqlcommand.ExecuteNonQuery()
            End If
        End Using
    End Sub
#End Region

#Region "bicycleView"
    Public Shared Function bicycleFilter(obj As Object, BicycleStatus As String)   'Selects a spesfic record from the "Status" row in the DB.
        Using sqlconnection As New MySqlConnection(connectionString)
            Dim returntable As New DataTable
            Try
                Dim listOfTables As New List(Of String)
                listOfTables = GetProperties(obj)
                Dim sql As New MySqlCommand("SELECT * from " & GetTableName(obj) & " WHERE Status= @input", sqlconnection)
                sql.Parameters.AddWithValue("@input", BicycleStatus)
                Dim da As New MySqlDataAdapter(sql)
                da.Fill(returntable)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return returntable
        End Using
    End Function
#End Region

    ' Function to check if a customer already exists
    Public Shared Function duplicateCustomer(CustomerID As Integer) As Boolean ' Ådne og Silje 🙂
        Using SqlConnection As New MySqlConnection(connectionString)
            Dim checkCustomerQuery As String = "SELECT COUNT(CustomerID) FROM Customer WHERE CustomerID =@phone"
            Dim sqlCommand As New MySqlCommand(checkCustomerQuery, SqlConnection)
            sqlCommand.Parameters.AddWithValue("@phone", CustomerID)
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
End Class

