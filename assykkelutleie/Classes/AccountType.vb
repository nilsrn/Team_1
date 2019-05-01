Public Class AccountType
    Dim m_AccountType As String

    Public Sub New()
    End Sub

    Public Sub New(AccountType)
        m_AccountType = AccountType
    End Sub

    Public Property AccountType() As String
        Get
            Return m_AccountType
        End Get
        Set(value As String)
            m_AccountType = value
        End Set
    End Property
End Class
