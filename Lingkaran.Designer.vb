<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lingkaran
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtJari = New System.Windows.Forms.TextBox()
        Me.LblSisi = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 464)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 34)
        Me.BtnBack.TabIndex = 19
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(152, 464)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 34)
        Me.BtnReset.TabIndex = 18
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(152, 420)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 17
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(12, 426)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 16
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(152, 369)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 34)
        Me.BtnHitung.TabIndex = 15
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtJari
        '
        Me.TxtJari.Location = New System.Drawing.Point(152, 329)
        Me.TxtJari.Name = "TxtJari"
        Me.TxtJari.Size = New System.Drawing.Size(121, 22)
        Me.TxtJari.TabIndex = 14
        '
        'LblSisi
        '
        Me.LblSisi.AutoSize = True
        Me.LblSisi.Location = New System.Drawing.Point(12, 329)
        Me.LblSisi.Name = "LblSisi"
        Me.LblSisi.Size = New System.Drawing.Size(119, 16)
        Me.LblSisi.TabIndex = 13
        Me.LblSisi.Text = "Masukkan Jari Jari" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(12, 289)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 12
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Keliling", "Luas"})
        Me.ComboBox1.Location = New System.Drawing.Point(152, 286)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.lingkaran
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 226)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Lingkaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(382, 528)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtJari)
        Me.Controls.Add(Me.LblSisi)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lingkaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lingkaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TxtJari As TextBox
    Friend WithEvents LblSisi As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
