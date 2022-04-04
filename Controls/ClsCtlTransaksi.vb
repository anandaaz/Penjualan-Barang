Imports System.Data.OleDb

Public Class ClsCtlTransaksi : Implements InfProsesTransaksi

    Public Function InsertDataNota(Ob As Object) As OleDbCommand Implements InfProsesTransaksi.InsertDataNota
        'Throw New NotImplementedException()
        Dim data As ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("insert into nota values('" & data.Kdnota & "','" _
                               & data.Kdpelanggan & "','" & data.kodeKasir & "'," _
                               & data.TanggalNota & ")", BUKAKONEKSI)
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertDataPelanggan(Ob As Object) As OleDbCommand Implements InfProsesTransaksi.InsertDataPelanggan
        'Throw New NotImplementedException()
        Dim data As ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("insert into pelanggan values('" & data.Kdpelanggan & "','','','')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertDataDetail(Ob As Object) As OleDbCommand Implements InfProsesTransaksi.InsertDataDetail
        'Throw New NotImplementedException()
        Dim data As ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("insert into detail_nota values('" & data.Kdnota & "','" _
                               & data.kodeBarang & "'," & data.JumlahBarang & "," _
                               & data.hargaBarang & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function UpdateDataDetail(Ob As Object, kd_nota As String, kd_barang As String) As OleDbCommand Implements InfProsesTransaksi.UpdateDataDetail
        'Throw New NotImplementedException()
        Dim data As New ClsEntTransaksi
        data = Ob
        CMD = New OleDbCommand("update detail_nota set jumlah_barang=" & data.JumlahBarang & ", harga_barang=" & data.hargaBarang _
                               & " where kd_barang='" & data.kodeBarang & "' And kd_nota='" & data.Kdnota & "'", BUKAKONEKSI)
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function DeleteDataDetail(kd_nota As String, kd_barang As String) As OleDbCommand Implements InfProsesTransaksi.DeleteDataDetail
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from detail_nota where kd_barang Like '%" & kd_barang & "%' And kd_nota Like'%" & kd_nota & "%'", BUKAKONEKSI)
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilDataDetail(kd_nota As String) As DataView Implements InfProsesTransaksi.tampilDataDetail
        Try
            DTA = New OleDbDataAdapter("Select barang.kd_barang,barang.nama_barang, barang.harga_satuan, detail_nota.jumlah_barang " _
            & "from nota inner join detail_nota on  detail_nota.kd_nota=nota.no_nota inner join barang on detail_nota.kd_barang=barang.kd_barang" _
                                       & " where kd_nota Like '%" & kd_nota & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Detail")
            Dim grid As New DataView(DTS.Tables("Tabel_Detail"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Cek(kd_nota As String, kd_barang As String) As DataView Implements InfProsesTransaksi.Cek
        Try
            DTA = New OleDbDataAdapter("select * from detail_nota" _
                               & " where kd_barang Like '%" & kd_barang & "%' And kd_nota Like'%" & kd_nota & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProsesTransaksi.cariData
        'Throw New NotImplementedException()
        Try
            DTA = New OleDbDataAdapter("select nama_barang, harga_satuan, stok from barang where nama_barang like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function kodeNotaBaru() As Object Implements InfProsesTransaksi.kodeNotaBaru
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(no_nota,4)) from Nota", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "N" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function kodeNotaLama() As Object Implements InfProsesTransaksi.kodeNotaLama
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(no_nota,4)) from Nota", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "N" & Strings.Right("000" & kodeakhir, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilkodePelangganLama() As Object Implements InfProsesTransaksi.TampilkodePelangganLama
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_pelanggan,4)) from Pelanggan", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P" & Strings.Right("000" & kodeakhir, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilkodePelangganBaru() As Object Implements InfProsesTransaksi.TampilkodePelangganBaru
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_pelanggan,4)) from Pelanggan", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "P" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function totalTransaksi(kd_nota As String) As Object Implements InfProsesTransaksi.totalTransaksi
        Dim baris As Integer
        Dim totalHarga As Integer
        Try
            DTA = New OleDbDataAdapter("Select barang.kd_barang, barang.nama_barang, barang.harga_satuan, detail_nota.jumlah_barang" _
            & " from nota inner join detail_nota on  detail_nota.kd_nota=nota.no_nota inner join barang on detail_nota.kd_barang=barang.kd_barang" _
                                       & " where kd_nota Like '%" & kd_nota & "%'", BUKAKONEKSI)

            DTS = New DataSet
            DTA.Fill(DTS, "total")
            baris = DTGrid.Rows.Count - 1
            For baris = 0 To baris
                totalHarga = totalHarga + Val((DTS.Tables("total").Rows(baris).Item(2) * DTS.Tables("total").Rows(baris).Item(3)))
            Next
            Return totalHarga
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function totalBarang(kd_nota As String) As Object Implements InfProsesTransaksi.totalBarang
        'Throw New NotImplementedException
        Dim total_Barang As Integer
        Dim baris As Integer
        Try
            DTA = New OleDbDataAdapter("Select barang.kd_barang, barang.nama_barang, barang.harga_satuan, detail_nota.jumlah_barang " _
            & " from nota inner join detail_nota on  detail_nota.kd_nota=nota.no_nota inner join barang on detail_nota.kd_barang=barang.kd_barang " _
                                       & " where kd_nota Like '%" & kd_nota & "%'", BUKAKONEKSI)
            DTS = New DataSet
            DTA.Fill(DTS, "total")
            baris = DTGrid.Rows.Count - 1
            For baris = 0 To baris
                total_Barang = total_Barang + Val(DTS.Tables("total").Rows(baris).Item(3))
            Next
            Return total_Barang
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class