Public Class Bicycle 'Sven-Erik
    Dim m_BicycleID As Integer
    Dim m_BicycleType, m_DefaultLocation, m_CurrentLocation, m_Status As String

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status)
        m_BicycleID = BicycleID
        m_BicycleType = BicycleType
        m_DefaultLocation = DefaultLocation
        m_CurrentLocation = CurrentLocation
        m_Status = Status
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            m_BicycleID = row("BicycleID")
            m_BicycleType = row("BicycleType")
            m_DefaultLocation = row("DefaultLocation")
            m_CurrentLocation = row("CurrentLocation")
            m_Status = row("Status")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide information for the transportation view.
        Return String.Format("SykkelID: {0} ({1}) skal fraktes fra {2} til {3}", BicycleID, BicycleType, CurrentLocation, DefaultLocation)
    End Function

    Public Property BicycleID() As Integer
        Get
            Return m_BicycleID
        End Get
        Set(value As Integer)
            m_BicycleID = value
        End Set
    End Property

    Public Property BicycleType() As String
        Get
            Return m_BicycleType
        End Get
        Set(value As String)
            m_BicycleType = value
        End Set
    End Property

    Public Property DefaultLocation() As String
        Get
            Return m_DefaultLocation
        End Get
        Set(value As String)
            m_DefaultLocation = value
        End Set
    End Property

    Public Property CurrentLocation() As String
        Get
            Return m_CurrentLocation
        End Get
        Set(value As String)
            m_CurrentLocation = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return m_Status
        End Get
        Set(value As String)
            m_Status = value
        End Set
    End Property
End Class
