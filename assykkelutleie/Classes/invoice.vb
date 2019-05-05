Public Class Invoice

    Dim _summary As String
    Dim _duedate, _invoicedate As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 
    Dim _nr, _cid, _rid, _kid, _amount As Integer

    Public Sub New()

    End Sub

    Public Sub New(InvoiceNumber, CustomerID, RentalID, InvoiceDate, DueDate, KIDnumber, Amount, RentalSummary)
        _nr = InvoiceNumber
        _cid = CustomerID
        _rid = RentalID
        _invoicedate = InvoiceDate
        _duedate = DueDate
        _kid = KIDnumber
        _amount = Amount
        _summary = RentalSummary

    End Sub

    Public Property InvoiceNumber() As Integer
        Get
            Return _nr
        End Get
        Set(value As Integer)
            _nr = value
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
    Public Property RentalID() As Integer
        Get
            Return _rid
        End Get
        Set(value As Integer)
            _rid = value
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
            Return _summary
        End Get
        Set(value As String)
            _summary = value
        End Set
    End Property
End Class
