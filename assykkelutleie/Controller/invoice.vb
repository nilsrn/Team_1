﻿Public Class Invoice

    Dim summary As String
    Dim m_duedate, m_invoicedate As Date
    Dim nr, cid, rid, m_kid, m_amount As Integer

    Public Sub New()

    End Sub

    Public Sub New(InvoiceNumber, CustomerID, RentalID, InvoiceDate, DueDate, KIDnumber, Amount, RentalSummary)
        nr = InvoiceNumber
        cid = CustomerID
        rid = RentalID
        m_invoicedate = InvoiceDate
        m_duedate = DueDate
        m_kid = KIDnumber
        m_amount = Amount
        summary = RentalSummary

    End Sub

    Public Property InvoiceNumber() As Integer
        Get
            Return nr
        End Get
        Set(value As Integer)
            nr = value
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
    Public Property RentalID() As Integer
        Get
            Return rid
        End Get
        Set(value As Integer)
            rid = value
        End Set
    End Property
    Public Property InvoiceDate() As Date
        Get
            Return m_invoicedate
        End Get
        Set(value As Date)
            m_invoicedate = value
        End Set
    End Property
    Public Property DueDate() As Date
        Get
            Return m_duedate
        End Get
        Set(value As Date)
            m_duedate = value
        End Set
    End Property
    Public Property KIDNumber() As Integer
        Get
            Return m_kid
        End Get
        Set(value As Integer)
            m_kid = value
        End Set
    End Property
    Public Property Amount() As Integer
        Get
            Return m_amount
        End Get
        Set(value As Integer)
            m_amount = value
        End Set
    End Property
    Public Property RentalSummary() As String
        Get
            Return summary
        End Get
        Set(value As String)
            summary = value
        End Set
    End Property
End Class