Public Class Equipment
    Dim _equipmentType, _defaultLocation, _currentLocation, _status As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _id As Integer

    Public Sub New()

    End Sub

    Public Sub New(EquipmentID, EquipmentType, DefaultLocation, CurrentLocation, Status)
        _id = EquipmentID
        _equipmentType = EquipmentType
        _defaultLocation = DefaultLocation
        _currentLocation = CurrentLocation
        _status = Status
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            _id = row("EquipmentID")
            _equipmentType = row("EquipmentType")
            _defaultLocation = row("DefaultLocation")
            _currentLocation = row("CurrentLocation")
            _status = row("Status")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide more information.
        Return String.Format("UtstyrID: {0} ({1}) befinner seg på {2} (standard: {3})", EquipmentID, EquipmentType, CurrentLocation, DefaultLocation)
    End Function

    Public Property EquipmentID() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property EquipmentType() As String
        Get
            Return _equipmentType
        End Get
        Set(value As String)
            _equipmentType = value
        End Set
    End Property
    Public Property DefaultLocation() As String
        Get
            Return _defaultLocation
        End Get
        Set(value As String)
            _defaultLocation = value
        End Set
    End Property
    Public Property CurrentLocation() As String
        Get
            Return _currentLocation
        End Get
        Set(value As String)
            _currentLocation = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

End Class
