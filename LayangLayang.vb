Public Class LayangLayang
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Keliling" Then
            LblD1.Text = "Masukkan Sisi 1"
            LblD2.Text = "Masukkan Sisi 2"
            LblSisi3.Text = "Masukkan Sisi 3"
            LblSisi4.Text = "Masukkan Sisi 4"
            LblSisi3.Show()
            LblSisi4.Show()
            TxtSisi3.Show()
            TxtSisi4.Show()
        ElseIf ComboBox1.Text = "Luas" Then
            LblSisi3.Hide()
            LblSisi4.Hide()
            TxtSisi3.Hide()
            TxtSisi4.Hide()
            LblD1.Text = "Masukkan Diagonal 1"
            LblD2.Text = "Masukkan Diagonal 2"
        End If
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = Val(TxtD1.Text) + Val(TxtD2.Text) + Val(TxtSisi3.Text) + Val(TxtSisi4.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = 1 / 2 * Val(TxtD1.Text) * Val(TxtD2.Text)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtD1.Text = ""
        TxtD2.Text = ""
        TxtSisi3.Text = ""
        TxtSisi4.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtD1.Text = ""
        TxtD2.Text = ""
        TxtSisi3.Text = ""
        TxtSisi4.Text = ""
        ComboBox1.Focus()
    End Sub
End Class