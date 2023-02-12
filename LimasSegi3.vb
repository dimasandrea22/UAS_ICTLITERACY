Public Class LimasSegi3
    Private Sub LimasSegi3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luas Permukaan" Then
            LblAlas.Text = "Masukkan Luas Alas"
            LblTinggiSegi3.Text = "Masukkan Luas Sisi Tegak"
        ElseIf ComboBox1.Text = "Volume" Then
            LblAlas.Text = "Masukkan Luas Alas"
            LblTinggiSegi3.Text = "Masukkan Tinggi Limas"
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormRuang.Show()
        LblAlas.Text = ""
        LblTinggiSegi3.Text = ""
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtHasil.Text = ""
        TxtTinggiLimas.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        LblAlas.Text = ""
        LblTinggiSegi3.Text = ""
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtHasil.Text = ""
        TxtTinggiLimas.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = (1 / 2 * Val(TxtAlas.Text)) + (3 * Val(TxtTinggiLimas.Text))
        ElseIf ComboBox1.Text = "Volume" Then
            TxtHasil.Text = 1 / 3 * Val(TxtAlas.Text) * Val(TxtTinggiLimas.Text)
        End If
    End Sub

    Private Sub LblTinggiSegi3_Click(sender As Object, e As EventArgs) Handles LblTinggiSegi3.Click

    End Sub

    Private Sub TxtHasil_TextChanged(sender As Object, e As EventArgs) Handles TxtHasil.TextChanged

    End Sub

    Private Sub LblHasil_Click(sender As Object, e As EventArgs) Handles LblHasil.Click

    End Sub

    Private Sub TxtAlas_TextChanged(sender As Object, e As EventArgs) Handles TxtAlas.TextChanged

    End Sub

    Private Sub LblAlas_Click(sender As Object, e As EventArgs) Handles LblAlas.Click

    End Sub

    Private Sub LblPilihan_Click(sender As Object, e As EventArgs) Handles LblPilihan.Click

    End Sub

    Private Sub TxtTinggiLimas_TextChanged(sender As Object, e As EventArgs) Handles TxtTinggiLimas.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class