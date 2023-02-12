<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPilihan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPilihan))
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.BtnDatar = New System.Windows.Forms.Button()
        Me.BtnRuang = New System.Windows.Forms.Button()
        Me.BtnOperasi = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMenu
        '
        Me.LblMenu.AutoSize = True
        Me.LblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.Location = New System.Drawing.Point(490, 3)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(477, 42)
        Me.LblMenu.TabIndex = 0
        Me.LblMenu.Text = "Pilih Program Perhitungan"
        '
        'BtnDatar
        '
        Me.BtnDatar.Location = New System.Drawing.Point(411, 287)
        Me.BtnDatar.Name = "BtnDatar"
        Me.BtnDatar.Size = New System.Drawing.Size(149, 45)
        Me.BtnDatar.TabIndex = 4
        Me.BtnDatar.Text = "Bangun Datar"
        Me.BtnDatar.UseVisualStyleBackColor = True
        '
        'BtnRuang
        '
        Me.BtnRuang.Location = New System.Drawing.Point(922, 287)
        Me.BtnRuang.Name = "BtnRuang"
        Me.BtnRuang.Size = New System.Drawing.Size(149, 45)
        Me.BtnRuang.TabIndex = 5
        Me.BtnRuang.Text = "Bangun Ruang"
        Me.BtnRuang.UseVisualStyleBackColor = True
        '
        'BtnOperasi
        '
        Me.BtnOperasi.Location = New System.Drawing.Point(676, 575)
        Me.BtnOperasi.Name = "BtnOperasi"
        Me.BtnOperasi.Size = New System.Drawing.Size(149, 45)
        Me.BtnOperasi.TabIndex = 6
        Me.BtnOperasi.Text = "Operasi Hitung"
        Me.BtnOperasi.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(676, 651)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(149, 45)
        Me.BtnHome.TabIndex = 7
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(554, 338)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(373, 221)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(815, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(373, 221)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(301, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 221)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FormPilihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1482, 703)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnOperasi)
        Me.Controls.Add(Me.BtnRuang)
        Me.Controls.Add(Me.BtnDatar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPilihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPilihan"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMenu As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnDatar As Button
    Friend WithEvents BtnRuang As Button
    Friend WithEvents BtnOperasi As Button
    Friend WithEvents BtnHome As Button
End Class
