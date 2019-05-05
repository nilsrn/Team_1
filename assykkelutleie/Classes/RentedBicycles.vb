Public Class RentedBicycles
    Dim _bicycleid, _price, _rentalid As Integer ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _datefrom, _dateto As String

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, RentalID, Price, DateFrom, DateTo)
        _bicycleid = BicycleID
        _rentalid = RentalID
        _price = Price
        _datefrom = DateFrom
        _dateto = DateTo
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            _bicycleid = row("BicycleID")
            _rentalid = row("RentalID")
            _price = row("Price")
            _datefrom = row("DateFrom")
            _dateto = row("DateTo")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide more information
        Return String.Format("SykkelID: {0} (UtleieID: {1}) er utleid fra {2}", _bicycleid, _rentalid, _datefrom)
    End Function

    Public Property BicycleID() As Integer
        Get
            Return _bicycleid
        End Get
        Set(value As Integer)
            _bicycleid = value
        End Set
    End Property

    Public Property RentalID() As Integer
        Get
            Return _rentalid
        End Get
        Set(value As Integer)
            _rentalid = value
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
End Class
