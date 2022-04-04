<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBarang
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
        Me.LabelText = New System.Windows.Forms.Label()
        Me.TxtCariBarang = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.BackColor = System.Drawing.Color.Transparent
        Me.LabelJudul.Font = New System.Drawing.Font("Forte", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(346, 74)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(345, 47)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "Form Cari Barang"
        '
        'LabelText
        '
        Me.LabelText.AutoSize = True
        Me.LabelText.BackColor = System.Drawing.Color.Transparent
        Me.LabelText.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelText.Location = New System.Drawing.Point(53, 176)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(158, 22)
        Me.LabelText.TabIndex = 1
        Me.LabelText.Text = "Data Yang Dicari"
        '
        'TxtCariBarang
        '
        Me.TxtCariBarang.Location = New System.Drawing.Point(246, 178)
        Me.TxtCariBarang.Name = "TxtCariBarang"
        Me.TxtCariBarang.Size = New System.Drawing.Size(293, 22)
        Me.TxtCariBarang.TabIndex = 2
        '
        'BtnCari
        '
        Me.BtnCari.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCari.Image = Global.Penjualan_Baru.My.Resources.Resources.search
        Me.BtnCari.Location = New System.Drawing.Point(562, 163)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(111, 52)
        Me.BtnCari.TabIndex = 3
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Forte", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Image = Global.Penjualan_Baru.My.Resources.Resources.plus
        Me.BtnTambah.Location = New System.Drawing.Point(57, 460)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(130, 46)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(59, 221)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowHeadersWidth = 51
        Me.DGBarang.RowTemplate.Height = 24
        Me.DGBarang.Size = New System.Drawing.Size(613, 222)
        Me.DGBarang.TabIndex = 6
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Penjualan_Baru.My.Resources.Resources.PURPLEE
        Me.ClientSize = New System.Drawing.Size(1106, 721)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.TxtCariBarang)
        Me.Controls.Add(Me.LabelText)
        Me.Controls.Add(Me.LabelJudul)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "FormCariBarang"
        Me.Text = "FormCariBarang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelJudul As Label
    Friend WithEvents LabelText As Label
    Friend WithEvents TxtCariBarang As TextBox
    Friend WithEvents BtnCari As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents DGBarang As DataGridView
End Class
