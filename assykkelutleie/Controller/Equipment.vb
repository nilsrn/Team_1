Public Class Equipment
    Dim m_equipmentType, m_defaultLocation, m_currentLocation, m_status As String
    Dim m_id As Integer

    Public Sub New()
    End Sub

    Public Sub New(CurrentLocation, DefaultLocation, EquipmentID, EquipmentType, Status)
        m_id = EquipmentID
        m_equipmentType = EquipmentType
        m_defaultLocation = DefaultLocation
        m_currentLocation = CurrentLocation
        m_status = Status
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            m_id = row("EquipmentID")
            m_equipmentType = row("EquipmentType")
            m_defaultLocation = row("DefaultLocation")
            m_currentLocation = row("CurrentLocation")
            m_status = row("Status")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide information for the transportation view.
        Return String.Format("UtstyrID: {0} ({1}) skal fraktes fra {2} til {3}.", EquipmentID, EquipmentType, CurrentLocation, DefaultLocation)
    End Function

    Public Property EquipmentID() As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
        End Set
    End Property
    Public Property EquipmentType() As String
        Get
            Return m_equipmentType
        End Get
        Set(value As String)
            m_equipmentType = value
        End Set
    End Property
    Public Property DefaultLocation() As String
        Get
            Return m_defaultLocation
        End Get
        Set(value As String)
            m_defaultLocation = value
        End Set
    End Property
    Public Property CurrentLocation() As String
        Get
            Return m_currentLocation
        End Get
        Set(value As String)
            m_currentLocation = value
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
