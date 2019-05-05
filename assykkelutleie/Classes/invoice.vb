Public Class Invoice

    Dim summary As String
    Dim _duedate, _invoicedate As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim nr, cid, rid, _kid, _amount As Integer

    Public Sub New()

    End Sub

    Public Sub New(InvoiceNumber, CustomerID, RentalID, InvoiceDate, DueDate, KIDnumber, Amount, RentalSummary)
        nr = InvoiceNumber
        cid = CustomerID
        rid = RentalID
        _invoicedate = InvoiceDate
        _duedate = DueDate
        _kid = KIDnumber
        _amount = Amount
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
    Public Property InvoiceDate() As String
        Get
            Return _invoicedate
        End Get
        Set(value As String)
            _invoicedate = value
        End Set
    End Property
    Public Property DueDate() As String
        Get
            Return _duedate
        End Get
        Set(value As String)
            _duedate = value
        End Set
    End Property
    Public Property KIDNumber() As Integer
        Get
            Return _kid
        End Get
        Set(value As Integer)
            _kid = value
        End Set
    End Property
    Public Property Amount() As Integer
        Get
            Return _amount
        End Get
        Set(value As Integer)
            _amount = value
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
