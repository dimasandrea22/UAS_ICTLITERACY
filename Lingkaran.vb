Public Class Lingkaran
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = 2 * 22 / 7 * Val(TxtJari.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = 22 / 7 * Val(TxtJari.Text) * Val(TxtJari.Text)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtJari.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtJari.Text = ""
        ComboBox1.Focus()
    End Sub
End Class