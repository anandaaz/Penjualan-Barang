Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtKode.Text = "" Then
            MsgBox("Isi kode kasir terlebih dahulu", vbOKOnly)
            TxtKode.Focus()
        ElseIf TxtPass.Text = "" Then
            MsgBox("Isi password terlebih dahulu", vbOKOnly)
            TxtPass.Focus()
        End If

        DTGrid = Kontrolkasir.loginKasir(TxtKode.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasKasir.kodeKasir = DTGrid.Rows(0).Item(0).ToString
            EntitasKasir.namaKasir = DTGrid.Rows(0).Item(1).ToString
            EntitasKasir.passKasir = DTGrid.Rows(0).Item(2).ToString
            EntitasKasir.levelKasir = DTGrid.Rows(0).Item(3).ToString

            If TxtPass.Text = EntitasKasir.passKasir Then
                MessageBox.Show("Selamat Datang " & EntitasKasir.namaKasir, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormUtama.Show()
                TxtPass.Text = ""
                TxtKode.Text = ""
                Me.Hide()

            Else
                MessageBox.Show("Password SALAH! !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtPass.Text = ""
                TxtPass.Focus()

            End If

        Else
            MessageBox.Show("Kode tidak dikenal!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPass.Text = ""
            TxtKode.Text = ""
            TxtPass.Focus()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class