Public Class RentedBicycles
    Dim m_rammenummer, m_price, m_rentalid As Integer

    Dim m_datefrom, m_dateto As Date

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, DateFrom, DateTo, Price, RentalID)
        m_rammenummer = BicycleID
        m_datefrom = DateFrom
        m_price = Price
        m_dateto = DateTo
        m_rentalid = RentalID
    End Sub

    Public Property BicycleID() As Integer
        Get
            Return m_rammenummer
        End Get
        Set(value As Integer)
            m_rammenummer = value
        End Set
    End Property

    Public Property DateFrom() As Date
        Get
            Return m_datefrom
        End Get
        Set(value As Date)
            m_datefrom = value
        End Set
    End Property
    Public Property DateTo() As Date
        Get
            Return m_dateto
        End Get
        Set(value As Date)
            m_dateto = value
        End Set
    End Property
    Public Property Price() As Integer
        Get
            Return m_price
        End Get
        Set(value As Integer)
            m_price = value
        End Set
    End Property
    Public Property RentalID() As Integer
        Get
            Return m_rentalid
        End Get
        Set(value As Integer)
            m_rentalid = value
        End Set
    End Property


End Class
