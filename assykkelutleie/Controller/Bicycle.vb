﻿Public Class Bicycle 'Sven-Erik
    Dim m_rammenummer As Integer
    Dim m_type, m_stdlok, m_gjlok, m_status As String

    Public Sub New()

    End Sub

    Public Sub New(BicycleID, BicycleType, DefaultLocation, CurrentLocation, Status)
        m_rammenummer = BicycleID
        m_type = BicycleType
        m_stdlok = DefaultLocation
        m_gjlok = CurrentLocation
        m_status = Status
    End Sub

    Public Property BicycleID() As Integer
        Get
            Return m_rammenummer
        End Get
        Set(value As Integer)
            m_rammenummer = value
        End Set
    End Property

    Public Property BicycleType() As String
        Get
            Return m_type
        End Get
        Set(value As String)
            m_type = value
        End Set
    End Property

    Public Property DefaultLocation() As String
        Get
            Return m_stdlok
        End Get
        Set(value As String)
            m_stdlok = value
        End Set
    End Property

    Public Property CurrentLocation() As String
        Get
            Return m_gjlok
        End Get
        Set(value As String)
            m_gjlok = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return m_status
        End Get
        Set(value As String)
            m_status = value
        End Set
    End Property
End Class
