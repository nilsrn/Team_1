Public Class Status
    Dim m_status2 As String ' m_ prefix means member variable. Helps create a clear distinction between a public property and the private member variable backing it. 

    Public Sub New()

    End Sub

    Public Sub New(Status2)
        m_status2 = Status2
    End Sub

    Public Property Status() As String
        Get
            Return m_status2
        End Get
        Set(value As String)
            m_status2 = value
        End Set
    End Property
End Class
