Public Class LimasSegi4
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luas Permukaan" Then
            LblAlas.Text = "Masukkan Luas Alas"
            LblTinggi.Text = "Masukkan Luas Sisi Tegak"
        ElseIf ComboBox1.Text = "Volume" Then
            LblAlas.Text = "Masukkan Luas Alas"
            LblTinggi.Text = "Masukkan Tinggi Limas"
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        LblAlas.Text = ""
        LblTinggi.Text = ""
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtHasil.Text = ""
        TxtTinggiLimas.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormRuang.Show()
        LblAlas.Text = ""
        LblTinggi.Text = ""
        ComboBox1.Text = ""
        TxtAlas.Text = ""
        TxtHasil.Text = ""
        TxtTinggiLimas.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = Val(TxtAlas.Text) + (4 * Val(TxtTinggiLimas.Text))
        ElseIf ComboBox1.Text = "Volume" Then
            TxtHasil.Text = 1 / 3 * Val(TxtAlas.Text) * Val(TxtTinggiLimas.Text)
        End If
    End Sub
End Class