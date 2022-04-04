Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OlahDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataBarangToolStripMenuItem.Click
        FormBarang.Show()
    End Sub

    Private Sub CariBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CariBarangToolStripMenuItem.Click
        FormCariBarang.Show()
    End Sub

    Private Sub OlahDataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OlahDataTransaksiToolStripMenuItem.Click
        FormTransaksi.Show()
    End Sub
End Class