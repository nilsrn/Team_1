Public Class Rentals
    Dim cid, rid, typantall, pris As Integer
    Dim m_comment, dloc, pickuploc, m_username, uttyp As String
    Dim dtime, m_pickuptime As Date



    Public Sub New(RentalID, CustomerID, Username, PickupLocation, DeliveryLocation, PickupTime, DeliveryTime, Utleie_Type, Utleie_Type_Antall, Total_Pris, Comment)
        rid = RentalID
        cid = CustomerID
        m_username = Username
        pickuploc = PickupLocation
        dloc = DeliveryLocation
        m_pickuptime = PickupTime
        dtime = DeliveryTime
        uttyp = Utleie_Type
        typantall = Utleie_Type_Antall
        pris = Total_Pris
        m_comment = Comment

    End Sub
    Public Sub New(table As DataTable)
        For Each row In table.Rows
            rid = row("RentalID")
            cid = row("CustomerID")
            m_username = row("Username")
            pickuploc = row("PickupLocation")
            dloc = row("DeliveryLocation")
            m_pickuptime = row("PickupTime")
            dtime = row("DeliveryTime")
            uttyp = row("Utleie_Type")
            typantall = row("Utleie_Type_Antall")
            pris = row("Total_Pris")
            m_comment = row("Comment")

        Next
    End Sub

    Public Sub New()
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
