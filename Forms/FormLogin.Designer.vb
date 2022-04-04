<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelKode
        '
        Me.LabelKode.AutoSize = True
        Me.LabelKode.BackColor = System.Drawing.Color.Transparent
        Me.LabelKode.Font = New System.Drawing.Font("Forte", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKode.Location = New System.Drawing.Point(305, 204)
        Me.LabelKode.Name = "LabelKode"
        Me.LabelKode.Size = New System.Drawing.Size(146, 31)
        Me.LabelKode.TabIndex = 0
        Me.LabelKode.Text = "Kode Kasir"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.BackColor = System.Drawing.Color.Transparent
        Me.LabelPass.Font = New System.Drawing.Font("Forte", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.Location = New System.Drawing.Point(305, 275)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(131, 31)
        Me.LabelPass.TabIndex = 1
        Me.LabelPass.Text = "Password"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(507, 213)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(299, 22)
        Me.TxtKode.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(507, 283)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(299, 22)
        Me.TxtPass.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Forte", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(392, 363)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(111, 51)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Forte", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(563, 363)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(111, 51)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Penjualan_Baru.My.Resources.Resources.store2
        Me.ClientSize = New System.Drawing.Size(991, 546)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.LabelPass)
        Me.Controls.Add(Me.LabelKode)
        Me.Name = "FormLogin"
        Me.Text = "FormLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelKode As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
End Class
