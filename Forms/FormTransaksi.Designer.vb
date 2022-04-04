<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.Labeltgl = New System.Windows.Forms.Label()
        Me.LabelNota = New System.Windows.Forms.Label()
        Me.Labelkasir = New System.Windows.Forms.Label()
        Me.Labelnama = New System.Windows.Forms.Label()
        Me.TxtTanggal = New System.Windows.Forms.TextBox()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtKdKasir = New System.Windows.Forms.TextBox()
        Me.TxtKasir = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelJml = New System.Windows.Forms.Label()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtBanyak = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtKdBrg = New System.Windows.Forms.TextBox()
        Me.LabelKode = New System.Windows.Forms.Label()
        Me.LabelNma = New System.Windows.Forms.Label()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.LabelBanyak = New System.Windows.Forms.Label()
        Me.LabelPtong = New System.Windows.Forms.Label()
        Me.LabelTtal = New System.Windows.Forms.Label()
        Me.LabelByar = New System.Windows.Forms.Label()
        Me.LabelKbl = New System.Windows.Forms.Label()
        Me.TxtPotongan = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.LabelKdPlgan = New System.Windows.Forms.Label()
        Me.TxtKdPelanggan = New System.Windows.Forms.TextBox()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Forte", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelJudul.Location = New System.Drawing.Point(460, 9)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(273, 52)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "Toko Purple"
        '
        'Labeltgl
        '
        Me.Labeltgl.AutoSize = True
        Me.Labeltgl.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltgl.Location = New System.Drawing.Point(90, 70)
        Me.Labeltgl.Name = "Labeltgl"
        Me.Labeltgl.Size = New System.Drawing.Size(82, 22)
        Me.Labeltgl.TabIndex = 1
        Me.Labeltgl.Text = "Tanggal"
        '
        'LabelNota
        '
        Me.LabelNota.AutoSize = True
        Me.LabelNota.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNota.Location = New System.Drawing.Point(90, 107)
        Me.LabelNota.Name = "LabelNota"
        Me.LabelNota.Size = New System.Drawing.Size(55, 22)
        Me.LabelNota.TabIndex = 2
        Me.LabelNota.Text = "Nota"
        '
        'Labelkasir
        '
        Me.Labelkasir.AutoSize = True
        Me.Labelkasir.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelkasir.Location = New System.Drawing.Point(462, 70)
        Me.Labelkasir.Name = "Labelkasir"
        Me.Labelkasir.Size = New System.Drawing.Size(55, 22)
        Me.Labelkasir.TabIndex = 3
        Me.Labelkasir.Text = "Kasir"
        '
        'Labelnama
        '
        Me.Labelnama.AutoSize = True
        Me.Labelnama.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelnama.Location = New System.Drawing.Point(465, 107)
        Me.Labelnama.Name = "Labelnama"
        Me.Labelnama.Size = New System.Drawing.Size(113, 22)
        Me.Labelnama.TabIndex = 4
        Me.Labelnama.Text = "Nama Kasir"
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Location = New System.Drawing.Point(270, 70)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(159, 22)
        Me.TxtTanggal.TabIndex = 5
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(270, 107)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(159, 22)
        Me.TxtNota.TabIndex = 6
        '
        'TxtKdKasir
        '
        Me.TxtKdKasir.Location = New System.Drawing.Point(590, 72)
        Me.TxtKdKasir.Name = "TxtKdKasir"
        Me.TxtKdKasir.Size = New System.Drawing.Size(159, 22)
        Me.TxtKdKasir.TabIndex = 7
        '
        'TxtKasir
        '
        Me.TxtKasir.Location = New System.Drawing.Point(590, 107)
        Me.TxtKasir.Name = "TxtKasir"
        Me.TxtKasir.Size = New System.Drawing.Size(159, 22)
        Me.TxtKasir.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DGTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LabelTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LabelJml)
        Me.GroupBox1.Controls.Add(Me.BtnCari)
        Me.GroupBox1.Controls.Add(Me.TxtBanyak)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtKdBrg)
        Me.GroupBox1.Controls.Add(Me.LabelKode)
        Me.GroupBox1.Controls.Add(Me.LabelNma)
        Me.GroupBox1.Controls.Add(Me.LabelHarga)
        Me.GroupBox1.Controls.Add(Me.LabelBanyak)
        Me.GroupBox1.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 372)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(22, 130)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.RowHeadersWidth = 51
        Me.DGTransaksi.RowTemplate.Height = 24
        Me.DGTransaksi.Size = New System.Drawing.Size(611, 200)
        Me.DGTransaksi.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(556, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Label"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(424, 330)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(125, 21)
        Me.LabelTotal.TabIndex = 22
        Me.LabelTotal.Text = "Total Belanja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label"
        '
        'LabelJml
        '
        Me.LabelJml.AutoSize = True
        Me.LabelJml.Location = New System.Drawing.Point(27, 330)
        Me.LabelJml.Name = "LabelJml"
        Me.LabelJml.Size = New System.Drawing.Size(137, 21)
        Me.LabelJml.TabIndex = 20
        Me.LabelJml.Text = "Jumlah Barang"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(150, 83)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(63, 32)
        Me.BtnCari.TabIndex = 18
        Me.BtnCari.Text = "..."
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtBanyak
        '
        Me.TxtBanyak.Location = New System.Drawing.Point(528, 83)
        Me.TxtBanyak.Name = "TxtBanyak"
        Me.TxtBanyak.Size = New System.Drawing.Size(102, 32)
        Me.TxtBanyak.TabIndex = 17
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(385, 83)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(102, 32)
        Me.TxtHarga.TabIndex = 16
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(240, 83)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(102, 32)
        Me.TxtNama.TabIndex = 15
        '
        'TxtKdBrg
        '
        Me.TxtKdBrg.Location = New System.Drawing.Point(29, 83)
        Me.TxtKdBrg.Name = "TxtKdBrg"
        Me.TxtKdBrg.Size = New System.Drawing.Size(102, 32)
        Me.TxtKdBrg.TabIndex = 14
        '
        'LabelKode
        '
        Me.LabelKode.AutoSize = True
        Me.LabelKode.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKode.Location = New System.Drawing.Point(51, 42)
        Me.LabelKode.Name = "LabelKode"
        Me.LabelKode.Size = New System.Drawing.Size(55, 22)
        Me.LabelKode.TabIndex = 10
        Me.LabelKode.Text = "Kode"
        '
        'LabelNma
        '
        Me.LabelNma.AutoSize = True
        Me.LabelNma.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNma.Location = New System.Drawing.Point(258, 42)
        Me.LabelNma.Name = "LabelNma"
        Me.LabelNma.Size = New System.Drawing.Size(63, 22)
        Me.LabelNma.TabIndex = 11
        Me.LabelNma.Text = "Nama"
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHarga.Location = New System.Drawing.Point(407, 42)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(64, 22)
        Me.LabelHarga.TabIndex = 12
        Me.LabelHarga.Text = "Harga"
        '
        'LabelBanyak
        '
        Me.LabelBanyak.AutoSize = True
        Me.LabelBanyak.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBanyak.Location = New System.Drawing.Point(543, 42)
        Me.LabelBanyak.Name = "LabelBanyak"
        Me.LabelBanyak.Size = New System.Drawing.Size(75, 22)
        Me.LabelBanyak.TabIndex = 13
        Me.LabelBanyak.Text = "Banyak"
        '
        'LabelPtong
        '
        Me.LabelPtong.AutoSize = True
        Me.LabelPtong.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPtong.Location = New System.Drawing.Point(119, 594)
        Me.LabelPtong.Name = "LabelPtong"
        Me.LabelPtong.Size = New System.Drawing.Size(93, 22)
        Me.LabelPtong.TabIndex = 24
        Me.LabelPtong.Text = "Potongan"
        '
        'LabelTtal
        '
        Me.LabelTtal.AutoSize = True
        Me.LabelTtal.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTtal.Location = New System.Drawing.Point(118, 633)
        Me.LabelTtal.Name = "LabelTtal"
        Me.LabelTtal.Size = New System.Drawing.Size(114, 22)
        Me.LabelTtal.TabIndex = 25
        Me.LabelTtal.Text = "Total Bersih"
        '
        'LabelByar
        '
        Me.LabelByar.AutoSize = True
        Me.LabelByar.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelByar.Location = New System.Drawing.Point(118, 671)
        Me.LabelByar.Name = "LabelByar"
        Me.LabelByar.Size = New System.Drawing.Size(61, 22)
        Me.LabelByar.TabIndex = 26
        Me.LabelByar.Text = "Bayar"
        '
        'LabelKbl
        '
        Me.LabelKbl.AutoSize = True
        Me.LabelKbl.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKbl.Location = New System.Drawing.Point(118, 707)
        Me.LabelKbl.Name = "LabelKbl"
        Me.LabelKbl.Size = New System.Drawing.Size(82, 22)
        Me.LabelKbl.TabIndex = 27
        Me.LabelKbl.Text = "Kembali"
        '
        'TxtPotongan
        '
        Me.TxtPotongan.Location = New System.Drawing.Point(271, 596)
        Me.TxtPotongan.Name = "TxtPotongan"
        Me.TxtPotongan.Size = New System.Drawing.Size(164, 22)
        Me.TxtPotongan.TabIndex = 28
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(271, 633)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(164, 22)
        Me.TxtTotal.TabIndex = 29
        '
        'TxtBayar
        '
        Me.TxtBayar.Location = New System.Drawing.Point(271, 673)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(164, 22)
        Me.TxtBayar.TabIndex = 30
        '
        'TxtKembali
        '
        Me.TxtKembali.Location = New System.Drawing.Point(271, 709)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(164, 22)
        Me.TxtKembali.TabIndex = 31
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = Global.Penjualan_Baru.My.Resources.Resources.plus
        Me.BtnTambah.Location = New System.Drawing.Point(492, 587)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(130, 40)
        Me.BtnTambah.TabIndex = 32
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Image = Global.Penjualan_Baru.My.Resources.Resources.save
        Me.BtnSimpan.Location = New System.Drawing.Point(492, 633)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(130, 40)
        Me.BtnSimpan.TabIndex = 33
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Image = Global.Penjualan_Baru.My.Resources.Resources.close
        Me.BtnBatal.Location = New System.Drawing.Point(492, 679)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(130, 40)
        Me.BtnBatal.TabIndex = 34
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'LabelKdPlgan
        '
        Me.LabelKdPlgan.AutoSize = True
        Me.LabelKdPlgan.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKdPlgan.Location = New System.Drawing.Point(90, 149)
        Me.LabelKdPlgan.Name = "LabelKdPlgan"
        Me.LabelKdPlgan.Size = New System.Drawing.Size(154, 22)
        Me.LabelKdPlgan.TabIndex = 35
        Me.LabelKdPlgan.Text = "Kode Pelanggan"
        '
        'TxtKdPelanggan
        '
        Me.TxtKdPelanggan.Location = New System.Drawing.Point(270, 149)
        Me.TxtKdPelanggan.Name = "TxtKdPelanggan"
        Me.TxtKdPelanggan.Size = New System.Drawing.Size(159, 22)
        Me.TxtKdPelanggan.TabIndex = 36
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = Global.Penjualan_Baru.My.Resources.Resources.trash
        Me.BtnHapus.Location = New System.Drawing.Point(492, 725)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(130, 40)
        Me.BtnHapus.TabIndex = 37
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Penjualan_Baru.My.Resources.Resources.PURPLEE
        Me.ClientSize = New System.Drawing.Size(1115, 773)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.TxtKdPelanggan)
        Me.Controls.Add(Me.LabelKdPlgan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtKembali)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtPotongan)
        Me.Controls.Add(Me.LabelPtong)
        Me.Controls.Add(Me.LabelTtal)
        Me.Controls.Add(Me.LabelByar)
        Me.Controls.Add(Me.LabelKbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtKasir)
        Me.Controls.Add(Me.TxtKdKasir)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.TxtTanggal)
        Me.Controls.Add(Me.Labelnama)
        Me.Controls.Add(Me.Labelkasir)
        Me.Controls.Add(Me.LabelNota)
        Me.Controls.Add(Me.Labeltgl)
        Me.Controls.Add(Me.LabelJudul)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents Labeltgl As Label
    Friend WithEvents LabelNota As Label
    Friend WithEvents Labelkasir As Label
    Friend WithEvents Labelnama As Label
    Friend WithEvents TxtTanggal As TextBox
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents TxtKdKasir As TextBox
    Friend WithEvents TxtKasir As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelJml As Label
    Friend WithEvents BtnCari As Button
    Friend WithEvents TxtBanyak As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtKdBrg As TextBox
    Friend WithEvents LabelKode As Label
    Friend WithEvents LabelNma As Label
    Friend WithEvents LabelHarga As Label
    Friend WithEvents LabelBanyak As Label
    Friend WithEvents LabelPtong As Label
    Friend WithEvents LabelTtal As Label
    Friend WithEvents LabelByar As Label
    Friend WithEvents LabelKbl As Label
    Friend WithEvents TxtPotongan As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtBayar As TextBox
    Friend WithEvents TxtKembali As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents DGTransaksi As DataGridView
    Friend WithEvents LabelKdPlgan As Label
    Friend WithEvents TxtKdPelanggan As TextBox
    Friend WithEvents BtnHapus As Button
End Class
