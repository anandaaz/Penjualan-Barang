Public Class FormCariBarang
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub FormCariBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        With EntitasTransaksi
            .kodeBarang = FormTransaksi.TxtKdBrg.Text
            .hargaBarang = FormTransaksi.TxtHarga.Text
            .Kdnota = FormTransaksi.TxtNota.Text
            .JumlahBarang = FormTransaksi.TxtBanyak.Text
        End With
        DTGrid = KontrolTransaksi.Cek(FormTransaksi.TxtNota.Text, FormTransaksi.TxtKdBrg.Text).ToTable
        If DTGrid.Rows.Count > 0 Then
            KontrolTransaksi.UpdateDataDetail(EntitasTransaksi, FormTransaksi.TxtNota.Text, FormTransaksi.TxtKdBrg.Text)
        Else
            KontrolTransaksi.InsertDataDetail(EntitasTransaksi)
            MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "Info")
        End If
        RefreshGridTransaksi()

    End Sub

    Private Sub RefreshGridTransaksi()
        DTGrid = KontrolTransaksi.tampilDataDetail(FormTransaksi.TxtNota.Text).ToTable
        FormTransaksi.DGTransaksi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            FormTransaksi.DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            FormTransaksi.DGTransaksi.CurrentCell = FormTransaksi.DGTransaksi.Item(1, baris)
            Isibox(baris)
        End If
        FormTransaksi.LabelTotal.Text = KontrolTransaksi.totalTransaksi(FormTransaksi.TxtNota.Text)
        FormTransaksi.LabelJml.Text = KontrolTransaksi.totalBarang(FormTransaksi.TxtNota.Text)
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
        End If
    End Sub

    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        DTGrid = KontrolBarang.tampilData.ToTable
        baris = e.RowIndex
        DGBarang.Rows(baris).Selected = True
        Isibox(baris)
    End Sub
    Private Sub Isibox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                FormTransaksi.TxtKdBrg.Text = .Cells(0).Value.ToString
                FormTransaksi.TxtNama.Text = .Cells(1).Value.ToString
                FormTransaksi.TxtHarga.Text = .Cells(2).Value.ToString
                FormTransaksi.TxtBanyak.Text = "1"
            End With
        End If
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable
        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            Isibox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            RefreshGrid()
        End If

    End Sub
    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCariBarang.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCariBarang.Text)
            TxtCariBarang.Focus()
        End If
    End Sub
End Class