Public Class FormDatar
    Private Sub FormDatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPersegi_Click(sender As Object, e As EventArgs) Handles BtnPersegi.Click
        Persegi.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPersegiPjg_Click(sender As Object, e As EventArgs) Handles BtnPersegiPjg.Click
        PersegiPanjang.Show()
        Me.Hide()
    End Sub

    Private Sub LblDatar_Click(sender As Object, e As EventArgs) Handles LblDatar.Click

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormPilihan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSegitiga_Click(sender As Object, e As EventArgs) Handles BtnSegitiga.Click
        Segitiga.Show()
        Me.Hide()
    End Sub

    Private Sub BtnTrapesium_Click(sender As Object, e As EventArgs) Handles BtnTrapesium.Click
        Trapesium.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLingkaran_Click(sender As Object, e As EventArgs) Handles BtnLingkaran.Click
        Lingkaran.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKetupat_Click(sender As Object, e As EventArgs) Handles BtnKetupat.Click
        BelahKetupat.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLayang_Click(sender As Object, e As EventArgs) Handles BtnLayang.Click
        LayangLayang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJajarGenjang_Click(sender As Object, e As EventArgs) Handles BtnJajarGenjang.Click
        JajarGenjang.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class