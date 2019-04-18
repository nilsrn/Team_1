Public Class BicycleType 'Sven-Erik
    Dim m_Name, m_Description, m_GearSystem, m_WheelSize, m_FrameSize As String
    Dim m_RateHour, m_RateDay As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name, Description, GearSystem, WheelSize, FrameSize, RateHour, RateDay)
        m_Name = Name
        m_Description = Description
        m_GearSystem = GearSystem
        m_WheelSize = WheelSize
        m_FrameSize = FrameSize
        m_RateHour = RateHour
        m_RateDay = RateDay
    End Sub

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(value As String)
            m_Description = value
        End Set
    End Property

    Public Property gearSystem() As String
        Get
            Return m_GearSystem
        End Get
        Set(value As String)
            m_GearSystem = value
        End Set
    End Property

    Public Property WheelSize() As String
        Get
            Return m_WheelSize
        End Get
        Set(value As String)
            m_WheelSize = value
        End Set
    End Property

    Public Property FrameSize() As String
        Get
            Return m_FrameSize
        End Get
        Set(value As String)
            m_FrameSize = value
        End Set
    End Property

    Public Property rateHour() As Integer
        Get
            Return m_RateHour
        End Get
        Set(value As Integer)
            m_RateHour = value
        End Set
    End Property

    Public Property rateDay() As Integer
        Get
            Return m_RateDay
        End Get
        Set(value As Integer)
            m_RateDay = value
        End Set
    End Property
End Class
