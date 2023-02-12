Public Class Trapesium
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Keliling" Then
            LblBawah.Text = "Masukkan Sisi 1"
            LblAtas.Text = "Masukkan Sisi 2"
            LblSisi1.Text = "Masukkan Sisi 3"
            LblSisi2.Text = "Masukkan Sisi 4"
            LblSisi2.Show()
            TxtSisi2.Show()
        ElseIf ComboBox1.Text = "Luas" Then
            LblBawah.Text = "Masukkan Sisi Bawah"
            LblAtas.Text = "Masukkan Sisi Atas"
            LblSisi1.Text = "Masukkan Tinggi"
            LblSisi2.Hide()
            TxtSisi2.Hide()
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = Val(TxtBawah.Text) + Val(TxtAtas.Text) + Val(TxtSisi1.Text) + Val(TxtSisi2.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = 1 / 2 * (Val(TxtAtas.Text) + Val(TxtBawah.Text)) * Val(TxtSisi1.Text)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtBawah.Text = ""
        TxtAtas.Text = ""
        TxtSisi1.Text = ""
        TxtSisi2.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtBawah.Text = ""
        TxtAtas.Text = ""
        TxtSisi1.Text = ""
        TxtSisi2.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub
End Class