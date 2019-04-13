Public Class Location 'Class that defines a location.
    Dim m_name, m_address, m_telephoneNumber As String ' m_ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()
    End Sub

    Public Sub New(name, address, telephoneNumber)
        m_name = name
        m_address = address
        m_telephoneNumber = telephoneNumber
    End Sub

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return m_address
        End Get
        Set(value As String)
            m_address = value
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
End Class