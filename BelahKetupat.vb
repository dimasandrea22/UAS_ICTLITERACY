Public Class BelahKetupat
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Keliling" Then
            LblD2.Hide()
            TxtD2.Hide()
            LblD1.Text = "Masukkan Sisi"
        ElseIf ComboBox1.Text = "Luas" Then
            LblD2.Show()
            TxtD2.Show()
            LblD1.Text = "Masukkan Diagonal 1"
            LblD2.Text = "Masukkan Diagonal 2"
        End If
    End Sub
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = 4 * Val(TxtD1.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = 1 / 2 * Val(TxtD1.Text) * Val(TxtD2.Text)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtD1.Text = ""
        TxtD2.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtD1.Text = ""
        TxtD2.Text = ""
        ComboBox1.Focus()
    End Sub
End Class