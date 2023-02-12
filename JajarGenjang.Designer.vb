<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JajarGenjang
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
        Me.TxtAlas = New System.Windows.Forms.TextBox()
        Me.LblAlas = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(197, 322)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(121, 22)
        Me.TxtTinggi.TabIndex = 33
        '
        'LblTinggi
        '
        Me.LblTinggi.AutoSize = True
        Me.LblTinggi.Location = New System.Drawing.Point(12, 322)
        Me.LblTinggi.Name = "LblTinggi"
        Me.LblTinggi.Size = New System.Drawing.Size(0, 16)
        Me.LblTinggi.TabIndex = 32
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 464)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 34)
        Me.BtnBack.TabIndex = 31
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(197, 464)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 34)
        Me.BtnReset.TabIndex = 30
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(197, 420)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 29
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(12, 426)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 28
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(197, 369)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 34)
        Me.BtnHitung.TabIndex = 27
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtAlas
        '
        Me.TxtAlas.Location = New System.Drawing.Point(197, 271)
        Me.TxtAlas.Name = "TxtAlas"
        Me.TxtAlas.Size = New System.Drawing.Size(121, 22)
        Me.TxtAlas.TabIndex = 26
        '
        'LblAlas
        '
        Me.LblAlas.AutoSize = True
        Me.LblAlas.Location = New System.Drawing.Point(12, 271)
        Me.LblAlas.Name = "LblAlas"
        Me.LblAlas.Size = New System.Drawing.Size(0, 16)
        Me.LblAlas.TabIndex = 25
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(12, 231)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 24
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Keliling", "Luas"})
        Me.ComboBox1.Location = New System.Drawing.Point(197, 223)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.jajar_genjang
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 180)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'JajarGenjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(382, 513)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.LblTinggi)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtAlas)
        Me.Controls.Add(Me.LblAlas)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "JajarGenjang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jajar Genjang"
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
    Friend WithEvents TxtAlas As TextBox
    Friend WithEvents LblAlas As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
