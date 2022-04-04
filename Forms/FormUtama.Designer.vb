<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OlahDataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaToolStripMenuItem, Me.BarangToolStripMenuItem, Me.CariBarangToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BaToolStripMenuItem
        '
        Me.BaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.BaToolStripMenuItem.Name = "BaToolStripMenuItem"
        Me.BaToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.BaToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataBarangToolStripMenuItem})
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'OlahDataBarangToolStripMenuItem
        '
        Me.OlahDataBarangToolStripMenuItem.Name = "OlahDataBarangToolStripMenuItem"
        Me.OlahDataBarangToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.OlahDataBarangToolStripMenuItem.Text = "Olah Data Barang"
        '
        'CariBarangToolStripMenuItem
        '
        Me.CariBarangToolStripMenuItem.Name = "CariBarangToolStripMenuItem"
        Me.CariBarangToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.CariBarangToolStripMenuItem.Text = "Cari Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OlahDataTransaksiToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'OlahDataTransaksiToolStripMenuItem
        '
        Me.OlahDataTransaksiToolStripMenuItem.Name = "OlahDataTransaksiToolStripMenuItem"
        Me.OlahDataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(222, 26)
        Me.OlahDataTransaksiToolStripMenuItem.Text = "Olah Data Transaksi"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Penjualan_Baru.My.Resources.Resources.Pastel_purple_aesthetic_lavender
        Me.ClientSize = New System.Drawing.Size(924, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CariBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OlahDataTransaksiToolStripMenuItem As ToolStripMenuItem
End Class
