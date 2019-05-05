Public Class RentedEquipment
    Dim _eqid, _price, rid As Integer ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _datefrom, _dateto As String

    Public Sub New()

    End Sub

    Public Sub New(EquipmentID, RentalID, Price, DateFrom, DateTo)
        _datefrom = DateFrom
        _dateto = DateTo
        _eqid = EquipmentID
        _price = Price
        rid = RentalID

    End Sub
    Public Property DateFrom() As String
        Get
            Return _datefrom
        End Get
        Set(value As String)
            _datefrom = value
        End Set
    End Property
    Public Property DateTo() As String
        Get
            Return _dateto
        End Get
        Set(value As String)
            _dateto = value
        End Set
    End Property
    Public Property EquipmentID() As Integer
        Get
            Return _eqid
        End Get
        Set(value As Integer)
            _eqid = value
        End Set
    End Property
    Public Property Price() As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property
    Public Property RentalID() As Integer
        Get
            Return rid
        End Get
        Set(value As Integer)
            rid = value
        End Set
    End Property
End Class
