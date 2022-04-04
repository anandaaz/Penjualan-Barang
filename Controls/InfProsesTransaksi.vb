Imports System.Data.OleDb
Public Interface InfProsesTransaksi
    Function InsertDataNota(Ob As Object) As OleDbCommand
    Function InsertDataPelanggan(Ob As Object) As OleDbCommand
    Function InsertDataDetail(Ob As Object) As OleDbCommand
    Function UpdateDataDetail(Ob As Object, kd_nota As String, kd_barang As String) As OleDbCommand
    Function DeleteDataDetail(kd_nota As String, kd_barang As String) As OleDbCommand
    Function tampilDataDetail(kd_nota As String) As DataView
    Function Cek(kd_nota As String, kd_barang As String) As DataView
    Function cariData(kunci As String) As DataView
    Function kodeNotaBaru()
    Function kodeNotaLama()
    Function TampilkodePelangganLama()
    Function TampilkodePelangganBaru()
    Function totalTransaksi(kd_nota As String)
    Function totalBarang(kd_nota As String)

End Interface
