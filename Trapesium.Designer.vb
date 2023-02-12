<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trapesium
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
        Me.TxtSisi1 = New System.Windows.Forms.TextBox()
        Me.LblSisi1 = New System.Windows.Forms.Label()
        Me.TxtAtas = New System.Windows.Forms.TextBox()
        Me.LblAtas = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtBawah = New System.Windows.Forms.TextBox()
        Me.LblBawah = New System.Windows.Forms.Label()
        Me.LblPilihan = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtSisi2 = New System.Windows.Forms.TextBox()
        Me.LblSisi2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSisi1
        '
        Me.TxtSisi1.Location = New System.Drawing.Point(217, 339)
        Me.TxtSisi1.Name = "TxtSisi1"
        Me.TxtSisi1.Size = New System.Drawing.Size(121, 22)
        Me.TxtSisi1.TabIndex = 49
        '
        'LblSisi1
        '
        Me.LblSisi1.AutoSize = True
        Me.LblSisi1.Location = New System.Drawing.Point(32, 345)
        Me.LblSisi1.Name = "LblSisi1"
        Me.LblSisi1.Size = New System.Drawing.Size(0, 16)
        Me.LblSisi1.TabIndex = 48
        '
        'TxtAtas
        '
        Me.TxtAtas.Location = New System.Drawing.Point(217, 302)
        Me.TxtAtas.Name = "TxtAtas"
        Me.TxtAtas.Size = New System.Drawing.Size(121, 22)
        Me.TxtAtas.TabIndex = 47
        '
        'LblAtas
        '
        Me.LblAtas.AutoSize = True
        Me.LblAtas.Location = New System.Drawing.Point(32, 308)
        Me.LblAtas.Name = "LblAtas"
        Me.LblAtas.Size = New System.Drawing.Size(0, 16)
        Me.LblAtas.TabIndex = 46
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(32, 514)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(121, 30)
        Me.BtnBack.TabIndex = 45
        Me.BtnBack.Text = "Kembali"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(217, 514)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(121, 30)
        Me.BtnReset.TabIndex = 44
        Me.BtnReset.Text = "Hapus"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(217, 470)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(121, 22)
        Me.TxtHasil.TabIndex = 43
        '
        'LblHasil
        '
        Me.LblHasil.AutoSize = True
        Me.LblHasil.Location = New System.Drawing.Point(32, 476)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(38, 16)
        Me.LblHasil.TabIndex = 42
        Me.LblHasil.Text = "Hasil"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(217, 419)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(121, 30)
        Me.BtnHitung.TabIndex = 41
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtBawah
        '
        Me.TxtBawah.Location = New System.Drawing.Point(217, 268)
        Me.TxtBawah.Name = "TxtBawah"
        Me.TxtBawah.Size = New System.Drawing.Size(121, 22)
        Me.TxtBawah.TabIndex = 40
        '
        'LblBawah
        '
        Me.LblBawah.AutoSize = True
        Me.LblBawah.Location = New System.Drawing.Point(32, 274)
        Me.LblBawah.Name = "LblBawah"
        Me.LblBawah.Size = New System.Drawing.Size(0, 16)
        Me.LblBawah.TabIndex = 39
        '
        'LblPilihan
        '
        Me.LblPilihan.AutoSize = True
        Me.LblPilihan.Location = New System.Drawing.Point(32, 239)
        Me.LblPilihan.Name = "LblPilihan"
        Me.LblPilihan.Size = New System.Drawing.Size(77, 16)
        Me.LblPilihan.TabIndex = 38
        Me.LblPilihan.Text = "Pilih Rumus"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Keliling", "Luas"})
        Me.ComboBox1.Location = New System.Drawing.Point(217, 231)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.UTS.My.Resources.Resources.trapesium
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PictureBox1.Location = New System.Drawing.Point(32, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 180)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'TxtSisi2
        '
        Me.TxtSisi2.Location = New System.Drawing.Point(217, 382)
        Me.TxtSisi2.Name = "TxtSisi2"
        Me.TxtSisi2.Size = New System.Drawing.Size(121, 22)
        Me.TxtSisi2.TabIndex = 51
        '
        'LblSisi2
        '
        Me.LblSisi2.AutoSize = True
        Me.LblSisi2.Location = New System.Drawing.Point(32, 388)
        Me.LblSisi2.Name = "LblSisi2"
        Me.LblSisi2.Size = New System.Drawing.Size(0, 16)
        Me.LblSisi2.TabIndex = 50
        '
        'Trapesium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(382, 553)
        Me.Controls.Add(Me.TxtSisi2)
        Me.Controls.Add(Me.LblSisi2)
        Me.Controls.Add(Me.TxtSisi1)
        Me.Controls.Add(Me.LblSisi1)
        Me.Controls.Add(Me.TxtAtas)
        Me.Controls.Add(Me.LblAtas)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtBawah)
        Me.Controls.Add(Me.LblBawah)
        Me.Controls.Add(Me.LblPilihan)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Trapesium"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trapesium"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSisi1 As TextBox
    Friend WithEvents LblSisi1 As Label
    Friend WithEvents TxtAtas As TextBox
    Friend WithEvents LblAtas As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents LblHasil As Label
    Friend WithEvents BtnHitung As Button
    Friend WithEvents TxtBawah As TextBox
    Friend WithEvents LblBawah As Label
    Friend WithEvents LblPilihan As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtSisi2 As TextBox
    Friend WithEvents LblSisi2 As Label
End Class
