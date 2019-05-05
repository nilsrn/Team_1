Public Class Location 'Class that defines a location.
    Dim _name, _address, _telephoneNumber As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()
    End Sub

    Public Sub New(name, address, telephoneNumber)
        _name = name
        _address = address
        _telephoneNumber = telephoneNumber
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
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