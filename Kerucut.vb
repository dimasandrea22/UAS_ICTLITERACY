Public Class Kerucut
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Luas Permukaan" Then
            LblTinggi.Text = "Masukkan Sisi Miring"
        ElseIf ComboBox1.Text = "Volume" Then
            LblTinggi.Text = "Masukkan Tinggi"
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtHasil.Text = ""
        TxtJari.Text = ""
        TxtTinggi.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormRuang.Show()
        TxtHasil.Text = ""
        TxtJari.Text = ""
        TxtTinggi.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Volume" Then
            TxtHasil.Text = 1 / 3 * 22 / 7 * Val(TxtJari.Text) * Val(TxtJari.Text) * Val(TxtTinggi.Text)
        ElseIf ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = 22 / 7 * Val(TxtJari.Text) * (Val(TxtJari.Text) + Val(TxtTinggi.Text))
        End If
    End Sub
End Class