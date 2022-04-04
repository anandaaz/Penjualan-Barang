Public Class FormBarang
    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        RefreshGrid()
        TxtKode.Enabled = False
        Me.MdiParent = FormUtama
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TxtKode.Text = KontrolBarang.kodeBaru
        AturButton(False)
        modeProses = 1
        TxtNama.Text = ""
        TxtHarga.Text = ""
        TxtStok.Text = ""
        TxtKode.Text = KontrolBarang.kodeBaru()


    End Sub

    Dim baris As Integer
    Dim modeProses As Integer
    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnEdit.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = Not st
        BtnBatal.Enabled = Not st

        GroupBox1.Enabled = Not st
        GroupBox3.Enabled = st
        GroupBox4.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                TxtKode.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(1).Value.ToString
                TxtHarga.Text = .Cells(2).Value.ToString
                TxtStok.Text = .Cells(3).Value.ToString

            End With
            LbBaris.Text = "Data ke-" & br + 1 & " dari " & DGBarang.RowCount - 1 & "Data"
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            RefreshGrid()
        End If

    End Sub

    Private Sub DGBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCari.Text)
            TxtCari.Focus()
        End If

    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        DGBarang.ClearSelection()
        baris = 0
        DGBarang.Rows(baris).Selected = True

    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        DGBarang.ClearSelection()
        baris = DTGrid.Rows.Count - 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)

    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        DGBarang.ClearSelection()
        If baris > 0 Then baris = baris - 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)

    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        DGBarang.ClearSelection()
        If baris < DTGrid.Rows.Count - 1 Then baris = baris + 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        AturButton(False)
        TxtNama.Focus()
        modeProses = 2

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        RefreshGrid()
        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        With EntitasBarang
            .kodeBarang = TxtKode.Text
            .namaBarang = TxtNama.Text
            .hargaBarang = TxtHarga.Text
            .stokBarang = TxtStok.Text
        End With

        If modeProses = 1 Then
            KontrolBarang.InsertData(EntitasBarang)

        ElseIf modeProses = 2 Then
            KontrolBarang.updateData(EntitasBarang)

        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "INFORMASI")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(TxtKode.Text)
        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "PERINGATAN")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin akan menghapus" & TxtKode.Text & "-" & TxtNama.Text & "?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo, "KONFIRMASI") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(TxtKode.Text)
        End If
        RefreshGrid()

    End Sub

End Class