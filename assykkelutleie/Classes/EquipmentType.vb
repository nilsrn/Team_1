Public Class EquipmentType
    Dim _name, _description As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _ratehour, _rateday As Integer

    Public Sub New()

    End Sub

    Public Sub New(Name, Description, RateHour, RateDay)
        _name = Name
        _description = Description
        _ratehour = RateHour
        _rateday = RateDay
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property


    Public Property rateHour() As Integer
        Get
            Return _ratehour
        End Get
        Set(value As Integer)
            _ratehour = value
        End Set
    End Property

    Public Property rateDay() As Integer
        Get
            Return _rateday
        End Get
        Set(value As Integer)
            _rateday = value
        End Set
    End Property
End Class
