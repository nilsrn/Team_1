Public Class Equipment
    Dim currloc, deflocc, type, m_status As String
    Dim id As Integer
    Public Sub New()
    End Sub

    Public Sub New(CurrentLocation, DefaultLocation, EquipmentID, EquipmentType, Status)

        currloc = CurrentLocation
        deflocc = DefaultLocation
        id = EquipmentID
        type = EquipmentType
        m_status = Status

    End Sub
    Public Property EquipmentID() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property EquipmentType() As String
        Get
            Return type
        End Get
        Set(value As String)
            type = value
        End Set
    End Property
    Public Property DefaultLocation() As String
        Get
            Return deflocc
        End Get
        Set(value As String)
            deflocc = value
        End Set
    End Property
    Public Property CurrentLocation() As String
        Get
            Return currloc
        End Get
        Set(value As String)
            currloc = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return m_status
        End Get
        Set(value As String)
            m_status = value
        End Set
    End Property

End Class
