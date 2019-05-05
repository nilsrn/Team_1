Public Class Bicycle
    Dim _BicycleID As Integer
    Dim _BicycleType, _DefaultLocation, _CurrentLocation, _Status As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status)
        _BicycleID = BicycleID
        _BicycleType = BicycleType
        _DefaultLocation = DefaultLocation
        _CurrentLocation = CurrentLocation
        _Status = Status
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            _BicycleID = row("BicycleID")
            _BicycleType = row("BicycleType")
            _DefaultLocation = row("DefaultLocation")
            _CurrentLocation = row("CurrentLocation")
            _Status = row("Status")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide more information
        Return String.Format("SykkelID: {0} ({1}) befinner seg på {2} (standard: {3})", BicycleID, BicycleType, CurrentLocation, DefaultLocation)
    End Function

    Public Property BicycleID() As Integer
        Get
            Return _BicycleID
        End Get
        Set(value As Integer)
            _BicycleID = value
        End Set
    End Property

    Public Property BicycleType() As String
        Get
            Return _BicycleType
        End Get
        Set(value As String)
            _BicycleType = value
        End Set
    End Property

    Public Property DefaultLocation() As String
        Get
            Return _DefaultLocation
        End Get
        Set(value As String)
            _DefaultLocation = value
        End Set
    End Property

    Public Property CurrentLocation() As String
        Get
            Return _CurrentLocation
        End Get
        Set(value As String)
            _CurrentLocation = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
        End Set
    End Property
End Class
