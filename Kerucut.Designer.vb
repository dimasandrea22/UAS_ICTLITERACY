<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kerucut
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
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.LblTinggi = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtJari = New System.Windows.Forms.TextBox()
        Me.LblJari = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(197, 339)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(121, 22)
        Me.TxtTinggi.TabIndex = 45
        '
        'LblTinggi
        '
        Me.LblTinggi.AutoSize = True
        Me.LblTinggi.Location = New System.Drawing.Point(12, 339)
        Me.LblTinggi.Name = "LblTinggi"
        Me.LblTinggi.Size = New System.Drawing.Size(110, 16)
        Me.LblTinggi.TabIndex = 44
        Me.LblTinggi.Text = "Masukkan Tinggi"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 483)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 34)
        Me.BtnBack.TabIndex = 43
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(197, 483)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 34)
        Me.BtnReset.TabIndex = 42
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(197, 439)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 41
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(12, 445)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 40
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(197, 388)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 34)
        Me.BtnHitung.TabIndex = 39
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtJari
        '
        Me.TxtJari.Location = New System.Drawing.Point(197, 296)
        Me.TxtJari.Name = "TxtJari"
        Me.TxtJari.Size = New System.Drawing.Size(121, 22)
        Me.TxtJari.TabIndex = 38
        '
        'LblJari
        '
        Me.LblJari.AutoSize = True
        Me.LblJari.Location = New System.Drawing.Point(12, 296)
        Me.LblJari.Name = "LblJari"
        Me.LblJari.Size = New System.Drawing.Size(116, 16)
        Me.LblJari.TabIndex = 37
        Me.LblJari.Text = "Masukkan Jari-jari"
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(12, 256)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 36
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Volume", "Luas Permukaan"})
        Me.ComboBox1.Location = New System.Drawing.Point(197, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.kerucut
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 180)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Kerucut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 528)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.LblTinggi)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtJari)
        Me.Controls.Add(Me.LblJari)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Kerucut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kerucut"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTinggi As TextBox
    Friend WithEvents LblTinggi As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TxtJari As TextBox
    Friend WithEvents LblJari As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
