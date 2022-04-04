Imports System.Data.OleDb
Public Class FormTransaksi
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNota.Text = KontrolTransaksi.kodeNotaLama
        TxtKdPelanggan.Text = KontrolTransaksi.TampilkodePelangganLama
        TxtKdKasir.Text = EntitasKasir.kodeKasir
        TxtKasir.Text = EntitasKasir.namaKasir
        TxtNota.Enabled = False
        TxtTanggal.Enabled = False
        TxtTanggal.Text = Format(Now, "yyyy-MM-dd")
        RefreshGrid()
        RefreshList()
    End Sub

    Private Sub Isibox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGTransaksi.Rows(br)
                TxtKdBrg.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(1).Value.ToString
                TxtHarga.Text = .Cells(2).Value.ToString
                TxtBanyak.Text = .Cells(3).Value.ToString
            End With
        End If
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.DataSource = DTGrid
            DGTransaksi.Rows(baris = DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
            Isibox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolTransaksi.tampilDataDetail(TxtNota.Text).ToTable
        DGTransaksi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
            Isibox(baris)
        End If

        LabelTotal.Text = KontrolTransaksi.totalTransaksi(TxtNota.Text)
        LabelJml.Text = KontrolTransaksi.totalBarang(TxtNota.Text)
    End Sub

    Private Sub RefreshList()
        DTGrid = KontrolTransaksi.tampilDataDetail(TxtNota.Text).ToTable
        Dim strItem(2) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = DTGrid.Rows(i).Item(1).ToString
                strItem(2) = DTGrid.Rows(i).Item(2).ToString
            Next
        End If
        LabelTotal.Text = KontrolTransaksi.totalTransaksi(TxtNota.Text)
        LabelJml.Text = KontrolTransaksi.totalBarang(TxtNota.Text)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        FormCariBarang.Show()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        TxtNota.Text = KontrolTransaksi.kodeNotaBaru
        TxtKdPelanggan.Text = KontrolTransaksi.TampilkodePelangganLama
        Dim DateTime As String = Format(Now, "yyyy-MM-dd")
        With EntitasTransaksi
            .Kdnota = TxtNota.Text
            .Kdpelanggan = txtKdPelanggan.Text
            .kodeKasir = TxtKdKasir.Text
            .TanggalNota = DateTime
        End With
        KontrolTransaksi.InsertDataNota(EntitasTransaksi)
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        RefreshGrid()

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        With EntitasTransaksi
            .Kodebarang = TxtKdBrg.Text
            .HargaBarang = TxtHarga.Text
            .Kdnota = TxtNota.Text
            .JumlahBarang = TxtBanyak.Text
        End With
        DTGrid = KontrolTransaksi.Cek(TxtNota.Text, TxtKdBrg.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            KontrolTransaksi.UpdateDataDetail(EntitasTransaksi, TxtNota.Text, TxtKdBrg.Text)
        Else
            KontrolTransaksi.InsertDataDetail(EntitasTransaksi)
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        End If
        RefreshGrid()
    End Sub
    Private Sub DGTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTransaksi.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGTransaksi.Rows(baris).Selected = True
            Isibox(baris)
        End If
    End Sub
    Private Sub TxtPotongan_Leave(sender As Object, e As EventArgs) Handles TxtPotongan.Leave
        TxtTotal.Text = LabelTotal.Text - TxtPotongan.Text
    End Sub
    Private Sub TxtBayar_Leave(sender As Object, e As EventArgs) Handles TxtBayar.Leave
        TxtKembali.Text = TxtBayar.Text - TxtTotal.Text
    End Sub

    Private Sub TxtBanyak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBanyak.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            Dim total As Integer
            total = EntitasTransaksi.JumlahBarang + Val(TxtBanyak.Text)
            EntitasTransaksi.JumlahBarang = total
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub DGTransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTransaksi.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGTransaksi.Rows(baris).Selected = True
            Isibox(baris)
        End If
    End Sub

    Private Sub TxtPotongan_TextChanged(sender As Object, e As EventArgs) Handles TxtPotongan.TextChanged
        TxtTotal.Text = LabelTotal.Text - TxtPotongan.Text
    End Sub

    Private Sub TxtBayar_TextChanged(sender As Object, e As EventArgs) Handles TxtBayar.TextChanged
        TxtKembali.Text = TxtBayar.Text - TxtTotal.Text
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin menghapus " & TxtKdBrg.Text & "-" & TxtNama.Text & " ? ",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolTransaksi.DeleteDataDetail(TxtNota.Text, TxtKdBrg.Text)
        End If
        RefreshGrid()
    End Sub
End Class