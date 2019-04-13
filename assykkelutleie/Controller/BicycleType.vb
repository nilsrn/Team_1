Public Class BicycleType 'Sven-Erik
    Dim m_navn, m_beskrivelse, m_gir, m_hjul, m_ramme As String
    Dim m_pristime, m_prisdag As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name, Description, GearSystem, WheelSize, FrameSize, RateHour, RateDay)
        m_navn = Name
        m_beskrivelse = Description
        m_gir = GearSystem
        m_hjul = WheelSize
        m_ramme = FrameSize
        m_pristime = RateHour
        m_prisdag = RateDay
    End Sub

    Public Property Name() As String
        Get
            Return m_navn
        End Get
        Set(value As String)
            m_navn = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_beskrivelse
        End Get
        Set(value As String)
            m_beskrivelse = value
        End Set
    End Property

    Public Property gearSystem() As String
        Get
            Return m_gir
        End Get
        Set(value As String)
            m_gir = value
        End Set
    End Property

    Public Property WheelSize() As String
        Get
            Return m_hjul
        End Get
        Set(value As String)
            m_hjul = value
        End Set
    End Property

    Public Property FrameSize() As String
        Get
            Return m_ramme
        End Get
        Set(value As String)
            m_ramme = value
        End Set
    End Property

    Public Property rateHour() As Integer
        Get
            Return m_pristime
        End Get
        Set(value As Integer)
            m_pristime = value
        End Set
    End Property

    Public Property rateDay() As Integer
        Get
            Return m_prisdag
        End Get
        Set(value As Integer)
            m_prisdag = value
        End Set
    End Property
End Class
