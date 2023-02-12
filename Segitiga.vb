Public Class Segitiga
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas" Then
            TxtHasil.Text = 1 / 2 * Val(TxtAlas.Text * TxtTinggi.Text)
        ElseIf ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = Val(TxtAlas.Text) + Val(TxtTinggi.Text) + Val(TxtSisi.Text)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtTinggi.Text = ""
        TxtSisi.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtTinggi.Text = ""
        TxtSisi.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luas" Then
            LblAlas.Text = "Masukkan Alas"
            LblTinggi.Text = "Masukkan Tinggi"
            LblSisi.Hide()
            TxtSisi.Hide()
        ElseIf ComboBox1.Text = "Keliling" Then
            LblAlas.Text = "Masukkan Sisi ke 1"
            LblTinggi.Text = "Masukkan Sisi ke 2"
            LblSisi.Text = "Masukkan Sisi ke 3"
            LblSisi.Show()
            TxtSisi.Show()
        End If
    End Sub
End Class