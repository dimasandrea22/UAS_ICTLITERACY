<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Balok
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
        Me.TxtLebar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtPanjang = New System.Windows.Forms.TextBox()
        Me.LblPanjang = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtLebar
        '
        Me.TxtLebar.Location = New System.Drawing.Point(224, 330)
        Me.TxtLebar.Name = "TxtLebar"
        Me.TxtLebar.Size = New System.Drawing.Size(121, 22)
        Me.TxtLebar.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Masukkan Lebar"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(39, 489)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 34)
        Me.BtnBack.TabIndex = 31
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(224, 489)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 34)
        Me.BtnReset.TabIndex = 30
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(224, 445)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 29
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(39, 451)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 28
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(224, 399)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 34)
        Me.BtnHitung.TabIndex = 27
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtPanjang
        '
        Me.TxtPanjang.Location = New System.Drawing.Point(224, 292)
        Me.TxtPanjang.Name = "TxtPanjang"
        Me.TxtPanjang.Size = New System.Drawing.Size(121, 22)
        Me.TxtPanjang.TabIndex = 26
        '
        'LblPanjang
        '
        Me.LblPanjang.AutoSize = True
        Me.LblPanjang.Location = New System.Drawing.Point(39, 292)
        Me.LblPanjang.Name = "LblPanjang"
        Me.LblPanjang.Size = New System.Drawing.Size(122, 16)
        Me.LblPanjang.TabIndex = 25
        Me.LblPanjang.Text = "Masukkan Panjang"
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(39, 256)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 24
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Volume", "Luas Permukaan"})
        Me.ComboBox1.Location = New System.Drawing.Point(224, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.Balok
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 180)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(224, 366)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(121, 22)
        Me.TxtTinggi.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Masukkan Tinggi"
        '
        'Balok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 528)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtLebar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtPanjang)
        Me.Controls.Add(Me.LblPanjang)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Balok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balok"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtLebar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TxtPanjang As TextBox
    Friend WithEvents LblPanjang As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtTinggi As TextBox
    Friend WithEvents Label2 As Label
End Class
