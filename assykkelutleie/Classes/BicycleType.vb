Public Class BicycleType
    Dim _Name, _Description, _GearSystem, _WheelSize, _FrameSize As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _RateHour, _RateDay As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name, Description, GearSystem, WheelSize, FrameSize, RateHour, RateDay)
        _Name = Name
        _Description = Description
        _GearSystem = GearSystem
        _WheelSize = WheelSize
        _FrameSize = FrameSize
        _RateHour = RateHour
        _RateDay = RateDay
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            _Name = row("Name")
            _Description = row("Description")
            _GearSystem = row("GearSystem")
            _WheelSize = row("WheelSize")
            _FrameSize = row("FrameSize")
            _RateHour = row("RateHour")
            _RateDay = row("RateDay")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide information for the statistics view.
        Return String.Format("BicycleType: {0} ({1}) har blitt bestilt x ganger", Name, Description)
    End Function

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property

    Public Property gearSystem() As String
        Get
            Return _GearSystem
        End Get
        Set(value As String)
            _GearSystem = value
        End Set
    End Property

    Public Property WheelSize() As String
        Get
            Return _WheelSize
        End Get
        Set(value As String)
            _WheelSize = value
        End Set
    End Property

    Public Property FrameSize() As String
        Get
            Return _FrameSize
        End Get
        Set(value As String)
            _FrameSize = value
        End Set
    End Property

    Public Property rateHour() As Integer
        Get
            Return _RateHour
        End Get
        Set(value As Integer)
            _RateHour = value
        End Set
    End Property

    Public Property rateDay() As Integer
        Get
            Return _RateDay
        End Get
        Set(value As Integer)
            _RateDay = value
        End Set
    End Property
End Class
