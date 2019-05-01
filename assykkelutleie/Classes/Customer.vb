Public Class Customer
    Dim me_phone As Integer
    Dim me_firstname, me_surname, me_email As String ' m_ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()

    End Sub

    Public Sub New(CustomerID, FirstName, Surname, Email)

        me_phone = CustomerID
        me_firstname = FirstName
        me_surname = Surname
        me_email = Email
    End Sub
    Public Property CustomerID() As Integer
        Get
            Return me_phone
        End Get
        Set(value As Integer)
            me_phone = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return me_firstname
        End Get
        Set(value As String)
            me_firstname = value
        End Set
    End Property
    Public Property Surname() As String
        Get
            Return me_surname
        End Get
        Set(value As String)
            me_surname = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return me_email
        End Get
        Set(value As String)
            me_email = value
        End Set
    End Property
End Class
