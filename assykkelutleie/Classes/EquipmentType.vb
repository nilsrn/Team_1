Public Class EquipmentType
    Dim m_name, m_description As String
    Dim m_ratehour, m_rateday As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name, Description, RateHour, RateDay)
        m_name = Name
        m_description = Description
        m_ratehour = RateHour
        m_rateday = RateDay
    End Sub

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_description
        End Get
        Set(value As String)
            m_description = value
        End Set
    End Property


    Public Property rateHour() As Integer
        Get
            Return m_ratehour
        End Get
        Set(value As Integer)
            m_ratehour = value
        End Set
    End Property

    Public Property rateDay() As Integer
        Get
            Return m_rateday
        End Get
        Set(value As Integer)
            m_rateday = value
        End Set
    End Property
End Class
