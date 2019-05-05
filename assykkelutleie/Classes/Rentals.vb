Public Class Rentals
    Dim rid, cid, typeammount, price As Integer
    Dim _username, pickuploc, dloc, rentaltype, _comment As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _pickuptime, dtime As String

    Public Sub New()

    End Sub

    Public Sub New(RentalID, CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment)
        rid = RentalID
        cid = CustomerID
        _username = Username
        pickuploc = PickupLocation
        dloc = DeliveryLocation
        _pickuptime = PickupTime
        dtime = DeliveryTime
        rentaltype = Utleie_Type
        typeammount = Utleie_Type_Antall
        price = Total_Pris
        _comment = Comment
    End Sub

    Public Property RentalID() As Integer
        Get
            Return rid
        End Get
        Set(value As Integer)
            rid = value
        End Set
    End Property

    Public Property CustomerID() As Integer
        Get
            Return cid
        End Get
        Set(value As Integer)
            cid = value
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
            Return pickuploc
        End Get
        Set(value As String)
            pickuploc = value
        End Set
    End Property

    Public Property DeliveryLocation() As String
        Get
            Return dloc
        End Get
        Set(value As String)
            dloc = value
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
            Return dtime
        End Get
        Set(value As String) 'Date)
            dtime = value
        End Set
    End Property

    Public Property Utleie_Type() As String
        Get
            Return rentaltype
        End Get
        Set(value As String)
            rentaltype = value
        End Set
    End Property

    Public Property Utleie_Type_Antall() As Integer
        Get
            Return typeammount
        End Get
        Set(value As Integer)
            typeammount = value
        End Set
    End Property

    Public Property Total_Pris() As Integer
        Get
            Return price
        End Get
        Set(value As Integer)
            price = value
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
