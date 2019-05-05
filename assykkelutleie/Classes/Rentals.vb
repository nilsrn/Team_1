Public Class Rentals
    Dim _rid, _cid, _typeammount, _price As Integer
    Dim _username, _pickuploc, _dloc, _rentaltype, _comment As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _pickuptime, _dtime As String

    Public Sub New()

    End Sub

    Public Sub New(RentalID, CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment)
        _rid = RentalID
        _cid = CustomerID
        _username = Username
        _pickuploc = PickupLocation
        _dloc = DeliveryLocation
        _pickuptime = PickupTime
        _dtime = DeliveryTime
        _rentaltype = Utleie_Type
        _typeammount = Utleie_Type_Antall
        _price = Total_Pris
        _comment = Comment
    End Sub

    Public Property RentalID() As Integer
        Get
            Return _rid
        End Get
        Set(value As Integer)
            _rid = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return _cid
        End Get
        Set(value As Integer)
            _cid = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property PickupLocation() As String
        Get
            Return _pickuploc
        End Get
        Set(value As String)
            _pickuploc = value
        End Set
    End Property

    Public Property DeliveryLocation() As String
        Get
            Return _dloc
        End Get
        Set(value As String)
            _dloc = value
        End Set
    End Property

    Public Property PickupTime() As String 'Date
        Get
            Return _pickuptime
        End Get
        Set(value As String) 'Date)
            _pickuptime = value
        End Set
    End Property

    Public Property DeliveryTime() As String 'Date
        Get
            Return _dtime
        End Get
        Set(value As String) 'Date)
            _dtime = value
        End Set
    End Property

    Public Property Utleie_Type() As String
        Get
            Return _rentaltype
        End Get
        Set(value As String)
            _rentaltype = value
        End Set
    End Property

    Public Property Utleie_Type_Antall() As Integer
        Get
            Return _typeammount
        End Get
        Set(value As Integer)
            _typeammount = value
        End Set
    End Property

    Public Property Total_Pris() As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            _price = value
        End Set
    End Property

    Public Property Comment() As String
        Get
            Return _comment
        End Get
        Set(value As String)
            _comment = value
        End Set
    End Property
End Class
