Public Class ClassEntKasir
    Private kode As String
    Private nama As String
    Private pass As String
    Private level As String

    Public Property kodeKasir() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property namaKasir() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property passKasir() As String
        Get
            Return pass
        End Get
        Set(value As String)
            pass = value
        End Set
    End Property

    Public Property levelKasir() As String
        Get
            Return level
        End Get
        Set(value As String)
            level = value
        End Set
    End Property
End Class