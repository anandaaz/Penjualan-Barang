Imports System.Data.OleDb

Module ModKoneksi
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable

    Public strkon = "Provider=SQLOLEDB;Data Source=ANANDANZ;Initial Catalog=Penjualan_0486;Integrated Security=SSPI"
    Public koneksi As New OleDbConnection(strkon)

    Public Function BUKAKONEKSI() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return koneksi
    End Function
    Public Function TUTUPKONEKSI() As OleDbConnection
        koneksi.Close()
        Return koneksi
    End Function

End Module
