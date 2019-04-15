Public Class Rentals
    Dim cid, rid, typantall, pris As Integer
    Dim m_comment, dloc, pickuploc, m_username, uttyp As String
    Dim dtime, m_pickuptime As Date

    Public Sub New()

    End Sub

    Public Sub New(Comment, CustomerID, DeliveryLocation, DeliveryTime, PickupLocation, PickupTime, RentalID, Total_Pris, Username, Utleie_Type, Utleie_Type_Antall)
        m_comment = Comment
        cid = CustomerID
        rid = RentalID
        typantall = Utleie_Type_Antall
        pris = Total_Pris
        dloc = DeliveryLocation
        dtime = DeliveryTime
        pickuploc = PickupLocation
        m_pickuptime = PickupTime
        m_username = Username
        uttyp = Utleie_Type

    End Sub

    Public Property CustomerID() As Integer
        Get
            Return cid
        End Get
        Set(value As Integer)
            cid = value
        End Set
    End Property

    Public Property Comment() As String
        Get
            Return m_comment
        End Get
        Set(value As String)
            m_comment = value
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

    Public Property PickupLocation() As String
        Get
            Return pickuploc
        End Get
        Set(value As String)
            pickuploc = value
        End Set
    End Property

    Public Property DeliveryTime() As Date
        Get
            Return dtime
        End Get
        Set(value As Date)
            dtime = value
        End Set
    End Property
    Public Property PickupTime() As Date
        Get
            Return m_pickuptime
        End Get
        Set(value As Date)
            m_pickuptime = value
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
    Public Property Utleie_Type_Antall() As Integer
        Get
            Return typantall
        End Get
        Set(value As Integer)
            typantall = value
        End Set
    End Property
    Public Property Utleie_Type() As String
        Get
            Return uttyp
        End Get
        Set(value As String)
            uttyp = value
        End Set
    End Property
    Public Property Total_Pris() As Integer
        Get
            Return pris
        End Get
        Set(value As Integer)
            pris = value
        End Set
    End Property
    Public Property Username() As String
        Get
            Return m_username
        End Get
        Set(value As String)
            m_username = value
        End Set
    End Property
End Class
