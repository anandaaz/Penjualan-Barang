Imports System.Data.OleDb

Public Class ClsCtlBarang : Implements InfProses
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        'Throw New NotImplementedException()
        Dim data As New ClassEntBarang
        data = Ob
        CMD = New OleDbCommand("insert into barang values('" & data.kodeBarang & "','" _
                                & data.namaBarang & "'," & data.hargaBarang & "," _
                                & data.stokbarang & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        'Throw New NotImplementedException()
        Dim data As New ClassEntBarang
        data = Ob
        CMD = New OleDbCommand("update barang set nama_barang = '" _
                            & data.namaBarang & "', harga_satuan=" & data.hargaBarang _
                            & ", stok=" & data.stokBarang _
                            & " where kd_barang ='" & data.kodeBarang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        'Throw New NotImplementedException()
        CMD = New OleDbCommand("delete from barang " _
                             & " where kd_barang='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Barang", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Barang")
            Dim grid As New DataView(DTS.Tables("Tabel_Barang"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OleDbDataAdapter("Select * from Barang where nama_barang " _
                                      & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            'Throw New NotImplementedException()
        End Try
    End Function

    Function kodeBaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select max(right(kd_barang ,4)) from Barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "B" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            'Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekBarangDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(kd_barang) from detail_nota " _
                                       & "where kd_barang='" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
        Return cek
    End Function

End Class
