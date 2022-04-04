Public Class ClsEntTransaksi
    Inherits ClassEntBarang
    Private jumlah As Integer
    Private kd_nota As String
    Private kd_pelanggan As String
    Private tanggal As String


    Public Property JumlahBarang As Integer
        Get
            Return jumlah
        End Get
        Set(value As Integer)
            jumlah = value
        End Set
    End Property

    Public Property TanggalNota As String
        Get
            Return tanggal
        End Get


        Set(value As String)
            tanggal = value
        End Set
    End Property
    Public Property Kdnota As String
        Get
            Return kd_nota
        End Get
        Set(value As String)
            kd_nota = value
        End Set
    End Property

    Public Property Kdpelanggan As String
        Get
            Return kd_pelanggan
        End Get
        Set(value As String)
            kd_pelanggan = value
        End Set
    End Property



End Class
