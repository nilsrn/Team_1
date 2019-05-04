Public Class RentedBicycles
    Dim m_bicycleid, m_price, m_rentalid As Integer ' m_ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim m_datefrom, m_dateto As String

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, RentalID, Price, DateFrom, DateTo)
        m_bicycleid = BicycleID
        m_rentalid = RentalID
        m_price = Price
        m_datefrom = DateFrom
        m_dateto = DateTo
    End Sub

    Public Sub New(table As DataTable)
        For Each row In table.Rows
            m_bicycleid = row("BicycleID")
            m_rentalid = row("RentalID")
            m_price = row("Price")
            m_datefrom = row("DateFrom")
            m_dateto = row("DateTo")
        Next
    End Sub

    Public Overrides Function ToString() As String 'Overrides the ToString method to provide more information
        Return String.Format("SykkelID: {0} (UtleieID: {1}) er utleid fra {2}", m_bicycleid, m_rentalid, m_datefrom)
    End Function

    Public Property BicycleID() As Integer
        Get
            Return m_bicycleid
        End Get
        Set(value As Integer)
            m_bicycleid = value
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

    Public Property Price() As Integer
        Get
            Return m_price
        End Get
        Set(value As Integer)
            m_price = value
        End Set
    End Property

    Public Property DateFrom() As String
        Get
            Return m_datefrom
        End Get
        Set(value As String)
            m_datefrom = value
        End Set
    End Property

    Public Property DateTo() As String
        Get
            Return m_dateto
        End Get
        Set(value As String)
            m_dateto = value
        End Set
    End Property
End Class
