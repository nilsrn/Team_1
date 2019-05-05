Public Class Status
    Dim _status2 As String ' ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()

    End Sub

    Public Sub New(Status2)
        _status2 = Status2
    End Sub

    Public Property Status() As String
        Get
            Return _status2
        End Get
        Set(value As String)
            _status2 = value
        End Set
    End Property
End Class
