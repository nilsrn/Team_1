Public Class Customer
    Dim _phone As Integer
    Dim _firstname, _surname, _email As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()

    End Sub

    Public Sub New(CustomerID, FirstName, Surname, Email)

        _phone = CustomerID
        _firstname = FirstName
        _surname = Surname
        _email = Email
    End Sub
    Public Property CustomerID() As Integer
        Get
            Return _phone
        End Get
        Set(value As Integer)
            _phone = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
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
End Class
