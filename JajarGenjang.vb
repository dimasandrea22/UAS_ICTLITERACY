Public Class JajarGenjang
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Keliling" Then
            LblAlas.Text = "Masukkan Alas"
            LblTinggi.Text = "Masukkan Sisi Miring"
        ElseIf ComboBox1.Text = "Luas" Then
            LblTinggi.Text = "Masukkan Tinggi"
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = 2 * (Val(TxtAlas.Text) + Val(TxtTinggi.Text))
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = Val(TxtAlas.Text) * Val(TxtTinggi.Text)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtTinggi.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtTinggi.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class