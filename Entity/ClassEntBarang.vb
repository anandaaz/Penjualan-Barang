Public Class ClassEntBarang
    Inherits ClassEntKasir
    Private kode As String
    Private nama As String
    Private harga As Integer
    Private stok As Integer

    Public Property kodeBarang() As String
        Get
            Return kode
        End Get
        Set(value As String)
            kode = value
        End Set
    End Property

    Public Property namaBarang() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property hargaBarang() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property

    Public Property stokBarang() As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property
End Class


