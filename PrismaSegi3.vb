Public Class PrismaSegi3
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luas Permukaan" Then
            LblAlas.Text = "Masukkan Luas Alas"
            LblTinggiSegi3.Text = "Masukkan Keliling Alas"
            LblTinggiPrisma.Text = "Masukkan Tinggi Prisma"
            LblTinggiPrisma.Show()
            TxtTinggi.Show()
        ElseIf ComboBox1.Text = "Volume" Then
            LblAlas.Text = "Masukkan Luas Segitiga"
            LblTinggiSegi3.Text = "Masukkan Tinggi Prisma"
            LblTinggiPrisma.Hide()
            TxtTinggi.Hide()
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtPanjang.Text = ""
        TxtTinggi.Text = ""
        TxtLebar.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormRuang.Show()
        ComboBox1.Text = ""
        TxtPanjang.Text = ""
        TxtTinggi.Text = ""
        TxtLebar.Text = ""
        TxtHasil.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = (2 * Val(TxtPanjang.Text)) + (Val(TxtLebar.Text * TxtTinggi.Text))
        ElseIf ComboBox1.Text = "Volume" Then
            TxtHasil.Text = Val(TxtPanjang.Text) * Val(TxtLebar.Text)
        End If
    End Sub
End Class