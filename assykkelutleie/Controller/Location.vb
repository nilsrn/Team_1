Public Class Location
    Dim m_navn, m_adresse As String
    Dim m_telefon As Integer

    Public Sub New()

    End Sub

    Public Sub New(name, address, telephoneNumber)
        m_navn = name
        m_adresse = address
        m_telefon = telephoneNumber
    End Sub

    Public Property Name() As String
        Get
            Return m_navn
        End Get
        Set(value As String)
            m_navn = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return m_adresse
        End Get
        Set(value As String)
            m_adresse = value
        End Set
    End Property

    Public Property telephoneNumber() As Integer
        Get
            Return m_telefon
        End Get
        Set(value As Integer)
            m_telefon = value
        End Set
    End Property
End Class
