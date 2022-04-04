<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.LabelKode = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelHarga = New System.Windows.Forms.Label()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.LbBaris = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelKode
        '
        Me.LabelKode.AutoSize = True
        Me.LabelKode.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKode.Location = New System.Drawing.Point(35, 53)
        Me.LabelKode.Name = "LabelKode"
        Me.LabelKode.Size = New System.Drawing.Size(115, 21)
        Me.LabelKode.TabIndex = 0
        Me.LabelKode.Text = "Kode Barang"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(35, 110)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(123, 21)
        Me.LabelNama.TabIndex = 1
        Me.LabelNama.Text = "Nama Barang"
        '
        'LabelHarga
        '
        Me.LabelHarga.AutoSize = True
        Me.LabelHarga.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHarga.Location = New System.Drawing.Point(35, 179)
        Me.LabelHarga.Name = "LabelHarga"
        Me.LabelHarga.Size = New System.Drawing.Size(123, 21)
        Me.LabelHarga.TabIndex = 2
        Me.LabelHarga.Text = "Harga Barang"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStock.Location = New System.Drawing.Point(35, 241)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(54, 21)
        Me.LabelStock.TabIndex = 3
        Me.LabelStock.Text = "Stock"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(188, 52)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(237, 22)
        Me.TxtKode.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(188, 109)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(237, 22)
        Me.TxtNama.TabIndex = 5
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(188, 178)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(237, 22)
        Me.TxtHarga.TabIndex = 6
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(188, 240)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(237, 22)
        Me.TxtStok.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Controls.Add(Me.TxtStok)
        Me.GroupBox1.Controls.Add(Me.LabelKode)
        Me.GroupBox1.Controls.Add(Me.LabelStock)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.LabelNama)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.LabelHarga)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 298)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(488, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 308)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Image = Global.Penjualan_Baru.My.Resources.Resources.save
        Me.BtnSimpan.Location = New System.Drawing.Point(44, 134)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(130, 49)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Image = Global.Penjualan_Baru.My.Resources.Resources.close
        Me.BtnBatal.Location = New System.Drawing.Point(44, 248)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(130, 40)
        Me.BtnBatal.TabIndex = 3
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Image = Global.Penjualan_Baru.My.Resources.Resources.trash
        Me.BtnHapus.Location = New System.Drawing.Point(44, 189)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(130, 53)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.Penjualan_Baru.My.Resources.Resources.pencil
        Me.BtnEdit.Location = New System.Drawing.Point(44, 78)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(130, 50)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = Global.Penjualan_Baru.My.Resources.Resources.plus
        Me.BtnTambah.Location = New System.Drawing.Point(44, 25)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(130, 52)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnCari)
        Me.GroupBox3.Controls.Add(Me.TxtCari)
        Me.GroupBox3.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(703, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(387, 109)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masukkan yang ingin dicari"
        '
        'BtnCari
        '
        Me.BtnCari.Image = Global.Penjualan_Baru.My.Resources.Resources.search
        Me.BtnCari.Location = New System.Drawing.Point(268, 38)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(111, 52)
        Me.BtnCari.TabIndex = 1
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(15, 51)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(231, 32)
        Me.TxtCari.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnLast)
        Me.GroupBox4.Controls.Add(Me.BtnNext)
        Me.GroupBox4.Controls.Add(Me.BtnPrev)
        Me.GroupBox4.Controls.Add(Me.BtnFirst)
        Me.GroupBox4.Location = New System.Drawing.Point(703, 295)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(387, 109)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'BtnLast
        '
        Me.BtnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.Location = New System.Drawing.Point(304, 33)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(75, 40)
        Me.BtnLast.TabIndex = 3
        Me.BtnLast.Text = ">>"
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(221, 33)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 40)
        Me.BtnNext.TabIndex = 2
        Me.BtnNext.Text = ">"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrev
        '
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrev.Location = New System.Drawing.Point(103, 33)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(75, 40)
        Me.BtnPrev.TabIndex = 1
        Me.BtnPrev.Text = "<"
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.Location = New System.Drawing.Point(22, 33)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(75, 40)
        Me.BtnFirst.TabIndex = 0
        Me.BtnFirst.Text = "<<"
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Forte", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(442, 13)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(259, 47)
        Me.LabelJudul.TabIndex = 13
        Me.LabelJudul.Text = "Form Barang"
        '
        'DGBarang
        '
        Me.DGBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGBarang.Location = New System.Drawing.Point(58, 385)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowHeadersWidth = 51
        Me.DGBarang.RowTemplate.Height = 24
        Me.DGBarang.Size = New System.Drawing.Size(575, 285)
        Me.DGBarang.TabIndex = 14
        '
        'LbBaris
        '
        Me.LbBaris.AutoSize = True
        Me.LbBaris.BackColor = System.Drawing.Color.Transparent
        Me.LbBaris.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBaris.Location = New System.Drawing.Point(225, 684)
        Me.LbBaris.Name = "LbBaris"
        Me.LbBaris.Size = New System.Drawing.Size(183, 21)
        Me.LbBaris.TabIndex = 15
        Me.LbBaris.Text = "Data ke 0 dari 0 data"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Penjualan_Baru.My.Resources.Resources.PURPLEE
        Me.ClientSize = New System.Drawing.Size(1112, 734)
        Me.Controls.Add(Me.LbBaris)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.LabelJudul)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelKode As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelHarga As Label
    Friend WithEvents LabelStock As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtHarga As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents LabelJudul As Label
    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents LbBaris As Label
End Class
