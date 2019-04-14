Public Class Equipment
    Dim currloc, deflocc, type, m_status As String
    Dim id As Integer
    Public Sub New(CurrentLocation, DefaultLocation, EquipmentID, EquipmentType, Status)

        currloc = CurrentLocation
        deflocc = DefaultLocation
        id = EquipmentID
        type = EquipmentType
        m_status = Status

    End Sub
    Public Property CustomerID() As Integer
        Get
            Return me_phone
        End Get
        Set(value As Integer)
            me_phone = value
        End Set
    End Property
End Class
