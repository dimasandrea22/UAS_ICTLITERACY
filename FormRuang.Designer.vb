<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRuang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRuang))
        Me.BtnLimSegiempat = New System.Windows.Forms.Button()
        Me.BtnLimSegitiga = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnKerucut = New System.Windows.Forms.Button()
        Me.BtnBola = New System.Windows.Forms.Button()
        Me.BtnTabung = New System.Windows.Forms.Button()
        Me.BtnPrisma = New System.Windows.Forms.Button()
        Me.BtnBalok = New System.Windows.Forms.Button()
        Me.BtnKubus = New System.Windows.Forms.Button()
        Me.LblDatar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLimSegiempat
        '
        Me.BtnLimSegiempat.Location = New System.Drawing.Point(889, 470)
        Me.BtnLimSegiempat.Name = "BtnLimSegiempat"
        Me.BtnLimSegiempat.Size = New System.Drawing.Size(132, 53)
        Me.BtnLimSegiempat.TabIndex = 27
        Me.BtnLimSegiempat.Text = "Limas Segi Empat"
        Me.BtnLimSegiempat.UseVisualStyleBackColor = True
        '
        'BtnLimSegitiga
        '
        Me.BtnLimSegitiga.Location = New System.Drawing.Point(889, 396)
        Me.BtnLimSegitiga.Name = "BtnLimSegitiga"
        Me.BtnLimSegitiga.Size = New System.Drawing.Size(132, 53)
        Me.BtnLimSegitiga.TabIndex = 26
        Me.BtnLimSegitiga.Text = "Limas Segi Tiga"
        Me.BtnLimSegitiga.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(645, 545)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(160, 49)
        Me.BtnBack.TabIndex = 24
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnKerucut
        '
        Me.BtnKerucut.Location = New System.Drawing.Point(738, 465)
        Me.BtnKerucut.Name = "BtnKerucut"
        Me.BtnKerucut.Size = New System.Drawing.Size(132, 58)
        Me.BtnKerucut.TabIndex = 23
        Me.BtnKerucut.Text = "Kerucut"
        Me.BtnKerucut.UseVisualStyleBackColor = True
        '
        'BtnBola
        '
        Me.BtnBola.Location = New System.Drawing.Point(581, 465)
        Me.BtnBola.Name = "BtnBola"
        Me.BtnBola.Size = New System.Drawing.Size(134, 58)
        Me.BtnBola.TabIndex = 22
        Me.BtnBola.Text = "Bola"
        Me.BtnBola.UseVisualStyleBackColor = True
        '
        'BtnTabung
        '
        Me.BtnTabung.Location = New System.Drawing.Point(410, 465)
        Me.BtnTabung.Name = "BtnTabung"
        Me.BtnTabung.Size = New System.Drawing.Size(135, 58)
        Me.BtnTabung.TabIndex = 21
        Me.BtnTabung.Text = "Tabung"
        Me.BtnTabung.UseVisualStyleBackColor = True
        '
        'BtnPrisma
        '
        Me.BtnPrisma.Location = New System.Drawing.Point(738, 396)
        Me.BtnPrisma.Name = "BtnPrisma"
        Me.BtnPrisma.Size = New System.Drawing.Size(132, 53)
        Me.BtnPrisma.TabIndex = 20
        Me.BtnPrisma.Text = "Prisma Segi Tiga"
        Me.BtnPrisma.UseVisualStyleBackColor = True
        '
        'BtnBalok
        '
        Me.BtnBalok.Location = New System.Drawing.Point(581, 396)
        Me.BtnBalok.Name = "BtnBalok"
        Me.BtnBalok.Size = New System.Drawing.Size(134, 53)
        Me.BtnBalok.TabIndex = 19
        Me.BtnBalok.Text = "Balok"
        Me.BtnBalok.UseVisualStyleBackColor = True
        '
        'BtnKubus
        '
        Me.BtnKubus.Location = New System.Drawing.Point(410, 396)
        Me.BtnKubus.Name = "BtnKubus"
        Me.BtnKubus.Size = New System.Drawing.Size(135, 53)
        Me.BtnKubus.TabIndex = 18
        Me.BtnKubus.Text = "Kubus"
        Me.BtnKubus.UseVisualStyleBackColor = True
        '
        'LblDatar
        '
        Me.LblDatar.AutoSize = True
        Me.LblDatar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatar.Location = New System.Drawing.Point(394, 7)
        Me.LblDatar.Name = "LblDatar"
        Me.LblDatar.Size = New System.Drawing.Size(644, 29)
        Me.LblDatar.TabIndex = 17
        Me.LblDatar.Text = "Program Perhitungan Luas dan Volume Bangun Ruang"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(399, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 318)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FormRuang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1482, 653)
        Me.Controls.Add(Me.BtnLimSegiempat)
        Me.Controls.Add(Me.BtnLimSegitiga)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnKerucut)
        Me.Controls.Add(Me.BtnBola)
        Me.Controls.Add(Me.BtnTabung)
        Me.Controls.Add(Me.BtnPrisma)
        Me.Controls.Add(Me.BtnBalok)
        Me.Controls.Add(Me.BtnKubus)
        Me.Controls.Add(Me.LblDatar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRuang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Hitung Bangun Ruang"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLimSegiempat As Button
    Friend WithEvents BtnLimSegitiga As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnKerucut As Button
    Friend WithEvents BtnBola As Button
    Friend WithEvents BtnTabung As Button
    Friend WithEvents BtnPrisma As Button
    Friend WithEvents BtnBalok As Button
    Friend WithEvents BtnKubus As Button
    Friend WithEvents LblDatar As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
