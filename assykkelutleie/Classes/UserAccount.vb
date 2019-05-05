Public Class UserAccount
    Dim _username, _password, _salt, _accountType, _location, _firstName, _surname, _email, _telephoneNumber As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New(username, password, salt, accountType, location, firstName, surname, email, telephoneNumber)
        _username = username
        _password = password
        _salt = salt
        _accountType = accountType
        _location = location
        _firstName = firstName
        _surname = surname
        _email = email
        _telephoneNumber = telephoneNumber
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            _username = row("Username")
            _password = row("Password")
            _salt = row("Salt")
            _accountType = row("AccountType")
            _location = row("Location")
            _firstName = row("FirstName")
            _surname = row("Surname")
            _email = row("Email")
            _telephoneNumber = row("TelephoneNumber")
        Next
    End Sub

    Public Sub New()
    End Sub

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Salt() As String
        Get
            Return _salt
        End Get
        Set(value As String)
            _salt = value
        End Set
    End Property

    Public Property AccountType() As String
        Get
            Return _accountType
        End Get
        Set(value As String)
            _accountType = value
        End Set
    End Property

    Public Property Location() As String
        Get
            Return _location
        End Get
        Set(value As String)
            _location = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property TelephoneNumber() As String
        Get
            Return _telephoneNumber
        End Get
        Set(value As String)
            _telephoneNumber = value
        End Set
    End Property

End Class
