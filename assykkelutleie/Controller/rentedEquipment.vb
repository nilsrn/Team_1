﻿Public Class rentedEquipment
    Dim m_eqid, m_price, rid As Integer
    Dim m_datefrom, m_dateto As Date

    Public Sub New()

    End Sub

    Public Sub New(DateFrom, DateTo, EquipmentID, Price, RentalID)
        m_datefrom = DateFrom
        m_dateto = DateTo
        m_eqid = EquipmentID
        m_price = Price
        rid = RentalID

    End Sub
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
    Public Property EquipmentID() As Integer
        Get
            Return m_eqid
        End Get
        Set(value As Integer)
            m_eqid = value
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
            Return rid
        End Get
        Set(value As Integer)
            rid = value
        End Set
    End Property
End Class
