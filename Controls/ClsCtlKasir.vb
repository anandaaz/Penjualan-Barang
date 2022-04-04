Imports System.Data.OleDb
Imports Penjualan_Baru

Public Class ClsCtlKasir : Implements InfProses
    Public Function loginKasir(kode As String) As DataView

        Try
            DTA = New OleDbDataAdapter("select * from Kasir where kd_kasir='" & kode & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cari_kasir")
            Dim grid As New DataView(DTS.Tables("cari_kasir"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function
End Class