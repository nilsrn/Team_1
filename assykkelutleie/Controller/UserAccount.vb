Public Class UserAccount
    Dim m_username, m_password, m_salt, m_accountType, m_location, m_firstName, m_surname, m_email, m_telephoneNumber As String

    Public Sub New(username, accountType, location, firstName, surname, email, telephoneNumber)
        m_username = username
        m_password = Encryption.HashString(Password)
        m_salt = Encryption.GenerateSalt()
        m_accountType = accountType
        m_location = location
        m_firstName = firstName
        m_surname = surname
        m_email = email
        m_telephoneNumber = telephoneNumber
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            m_username = row("Username")
            m_password = row("Password")
            m_salt = row("Salt")
            m_accountType = row("AccountType")
            m_location = row("Location")
            m_firstName = row("FirstName")
            m_surname = row("Surname")
            m_email = row("Email")
            m_telephoneNumber = row("TelephoneNumber")
        Next
    End Sub

    Public Sub New()
    End Sub

    Public Property username() As String
        Get
            Return m_username
        End Get
        Set(value As String)
            m_username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_password
        End Get
        Set(value As String)
            m_password = value
        End Set
    End Property

    Public Property Salt() As String
        Get
            Return m_salt
        End Get
        Set(value As String)
            m_salt = value
        End Set
    End Property

    Public Property AccountType() As String
        Get
            Return m_accountType
        End Get
        Set(value As String)
            m_accountType = value
        End Set
    End Property

    Public Property Location() As String
        Get
            Return m_location
        End Get
        Set(value As String)
            m_location = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return m_firstName
        End Get
        Set(value As String)
            m_firstName = value
        End Set
    End Property

    Public Property Surname() As String
        Get
            Return m_surname
        End Get
        Set(value As String)
            m_surname = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return m_email
        End Get
        Set(value As String)
            m_email = value
        End Set
    End Property

    Public Property TelephoneNumber() As String
        Get
            Return m_telephoneNumber
        End Get
        Set(value As String)
            m_telephoneNumber = value
        End Set
    End Property

    'Dim username As String = "Admins"
    'Dim password = Encryption.HashString("Tastatur123")
    'Dim salt = Encryption.GenerateSalt
    'Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", password, salt))

End Class
