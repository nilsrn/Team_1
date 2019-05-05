Public Class AccountType
    Dim _AccountType As String ' The _ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()
    End Sub

    Public Sub New(AccountType)
        _AccountType = AccountType
    End Sub

    Public Property AccountType() As String
        Get
            Return _AccountType
        End Get
        Set(value As String)
            _AccountType = value
        End Set
    End Property
End Class
