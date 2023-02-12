<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrismaSegi3
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
        Me.LblTinggiPrisma = New System.Windows.Forms.Label()
        Me.TxtLebar = New System.Windows.Forms.TextBox()
        Me.LblTinggiSegi3 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtPanjang = New System.Windows.Forms.TextBox()
        Me.LblAlas = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(209, 366)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(121, 22)
        Me.TxtTinggi.TabIndex = 49
        '
        'LblTinggiPrisma
        '
        Me.LblTinggiPrisma.AutoSize = True
        Me.LblTinggiPrisma.Location = New System.Drawing.Point(24, 366)
        Me.LblTinggiPrisma.Name = "LblTinggiPrisma"
        Me.LblTinggiPrisma.Size = New System.Drawing.Size(0, 16)
        Me.LblTinggiPrisma.TabIndex = 48
        '
        'TxtLebar
        '
        Me.TxtLebar.Location = New System.Drawing.Point(209, 330)
        Me.TxtLebar.Name = "TxtLebar"
        Me.TxtLebar.Size = New System.Drawing.Size(121, 22)
        Me.TxtLebar.TabIndex = 47
        '
        'LblTinggiSegi3
        '
        Me.LblTinggiSegi3.AutoSize = True
        Me.LblTinggiSegi3.Location = New System.Drawing.Point(24, 330)
        Me.LblTinggiSegi3.Name = "LblTinggiSegi3"
        Me.LblTinggiSegi3.Size = New System.Drawing.Size(0, 16)
        Me.LblTinggiSegi3.TabIndex = 46
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(24, 489)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 34)
        Me.BtnBack.TabIndex = 45
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(209, 489)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 34)
        Me.BtnReset.TabIndex = 44
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(209, 445)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 43
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(24, 451)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 42
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(209, 399)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 34)
        Me.BtnHitung.TabIndex = 41
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtPanjang
        '
        Me.TxtPanjang.Location = New System.Drawing.Point(209, 292)
        Me.TxtPanjang.Name = "TxtPanjang"
        Me.TxtPanjang.Size = New System.Drawing.Size(121, 22)
        Me.TxtPanjang.TabIndex = 40
        '
        'LblAlas
        '
        Me.LblAlas.AutoSize = True
        Me.LblAlas.Location = New System.Drawing.Point(24, 292)
        Me.LblAlas.Name = "LblAlas"
        Me.LblAlas.Size = New System.Drawing.Size(0, 16)
        Me.LblAlas.TabIndex = 39
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(24, 256)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 38
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Volume", "Luas Permukaan"})
        Me.ComboBox1.Location = New System.Drawing.Point(209, 248)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.Prisma_Segitiga
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 180)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PrismaSegi3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 528)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.LblTinggiPrisma)
        Me.Controls.Add(Me.TxtLebar)
        Me.Controls.Add(Me.LblTinggiSegi3)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtPanjang)
        Me.Controls.Add(Me.LblAlas)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrismaSegi3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrismaSegi3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTinggi As TextBox
    Friend WithEvents LblTinggiPrisma As Label
    Friend WithEvents TxtLebar As TextBox
    Friend WithEvents LblTinggiSegi3 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TxtPanjang As TextBox
    Friend WithEvents LblAlas As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
