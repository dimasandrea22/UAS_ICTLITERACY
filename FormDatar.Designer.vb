<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatar))
        Me.LblDatar = New System.Windows.Forms.Label()
        Me.BtnPersegi = New System.Windows.Forms.Button()
        Me.BtnPersegiPjg = New System.Windows.Forms.Button()
        Me.BtnSegitiga = New System.Windows.Forms.Button()
        Me.BtnLingkaran = New System.Windows.Forms.Button()
        Me.BtnKetupat = New System.Windows.Forms.Button()
        Me.BtnLayang = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnTrapesium = New System.Windows.Forms.Button()
        Me.BtnJajarGenjang = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDatar
        '
        Me.LblDatar.AutoSize = True
        Me.LblDatar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDatar.Location = New System.Drawing.Point(364, 24)
        Me.LblDatar.Name = "LblDatar"
        Me.LblDatar.Size = New System.Drawing.Size(632, 29)
        Me.LblDatar.TabIndex = 1
        Me.LblDatar.Text = "Program Perhitungan Luas dan Keliling Bangun Datar"
        '
        'BtnPersegi
        '
        Me.BtnPersegi.Location = New System.Drawing.Point(369, 423)
        Me.BtnPersegi.Name = "BtnPersegi"
        Me.BtnPersegi.Size = New System.Drawing.Size(135, 53)
        Me.BtnPersegi.TabIndex = 7
        Me.BtnPersegi.Text = "Persegi"
        Me.BtnPersegi.UseVisualStyleBackColor = True
        '
        'BtnPersegiPjg
        '
        Me.BtnPersegiPjg.Location = New System.Drawing.Point(540, 423)
        Me.BtnPersegiPjg.Name = "BtnPersegiPjg"
        Me.BtnPersegiPjg.Size = New System.Drawing.Size(134, 53)
        Me.BtnPersegiPjg.TabIndex = 8
        Me.BtnPersegiPjg.Text = "Persegi Panjang"
        Me.BtnPersegiPjg.UseVisualStyleBackColor = True
        '
        'BtnSegitiga
        '
        Me.BtnSegitiga.Location = New System.Drawing.Point(697, 423)
        Me.BtnSegitiga.Name = "BtnSegitiga"
        Me.BtnSegitiga.Size = New System.Drawing.Size(132, 53)
        Me.BtnSegitiga.TabIndex = 9
        Me.BtnSegitiga.Text = "Segitiga"
        Me.BtnSegitiga.UseVisualStyleBackColor = True
        '
        'BtnLingkaran
        '
        Me.BtnLingkaran.Location = New System.Drawing.Point(369, 492)
        Me.BtnLingkaran.Name = "BtnLingkaran"
        Me.BtnLingkaran.Size = New System.Drawing.Size(135, 58)
        Me.BtnLingkaran.TabIndex = 10
        Me.BtnLingkaran.Text = "Lingkaran"
        Me.BtnLingkaran.UseVisualStyleBackColor = True
        '
        'BtnKetupat
        '
        Me.BtnKetupat.Location = New System.Drawing.Point(540, 492)
        Me.BtnKetupat.Name = "BtnKetupat"
        Me.BtnKetupat.Size = New System.Drawing.Size(134, 58)
        Me.BtnKetupat.TabIndex = 11
        Me.BtnKetupat.Text = "Belah Ketupat"
        Me.BtnKetupat.UseVisualStyleBackColor = True
        '
        'BtnLayang
        '
        Me.BtnLayang.Location = New System.Drawing.Point(697, 492)
        Me.BtnLayang.Name = "BtnLayang"
        Me.BtnLayang.Size = New System.Drawing.Size(132, 58)
        Me.BtnLayang.TabIndex = 12
        Me.BtnLayang.Text = "Layang-layang"
        Me.BtnLayang.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(604, 572)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(160, 49)
        Me.BtnBack.TabIndex = 13
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnTrapesium
        '
        Me.BtnTrapesium.Location = New System.Drawing.Point(848, 423)
        Me.BtnTrapesium.Name = "BtnTrapesium"
        Me.BtnTrapesium.Size = New System.Drawing.Size(132, 53)
        Me.BtnTrapesium.TabIndex = 15
        Me.BtnTrapesium.Text = "Trapesium"
        Me.BtnTrapesium.UseVisualStyleBackColor = True
        '
        'BtnJajarGenjang
        '
        Me.BtnJajarGenjang.Location = New System.Drawing.Point(848, 497)
        Me.BtnJajarGenjang.Name = "BtnJajarGenjang"
        Me.BtnJajarGenjang.Size = New System.Drawing.Size(132, 53)
        Me.BtnJajarGenjang.TabIndex = 16
        Me.BtnJajarGenjang.Text = "Jajar Genjang"
        Me.BtnJajarGenjang.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(369, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 340)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'FormDatar
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1353, 854)
        Me.Controls.Add(Me.BtnJajarGenjang)
        Me.Controls.Add(Me.BtnTrapesium)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnLayang)
        Me.Controls.Add(Me.BtnKetupat)
        Me.Controls.Add(Me.BtnLingkaran)
        Me.Controls.Add(Me.BtnSegitiga)
        Me.Controls.Add(Me.BtnPersegiPjg)
        Me.Controls.Add(Me.BtnPersegi)
        Me.Controls.Add(Me.LblDatar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDatar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Hitung Bangun Datar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDatar As Label
    Friend WithEvents BtnPersegi As Button
    Friend WithEvents BtnPersegiPjg As Button
    Friend WithEvents BtnSegitiga As Button
    Friend WithEvents BtnLingkaran As Button
    Friend WithEvents BtnKetupat As Button
    Friend WithEvents BtnLayang As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTrapesium As Button
    Friend WithEvents BtnJajarGenjang As Button
End Class
