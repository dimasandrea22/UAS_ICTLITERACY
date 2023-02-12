Public Class Bola
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtHasil.Text = ""
        TxtJari.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormRuang.Show()
        TxtHasil.Text = ""
        TxtJari.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Volume" Then
            TxtHasil.Text = 4 / 3 * 22 / 7 * Val(TxtJari.Text) * Val(TxtJari.Text) * Val(TxtJari.Text)
        ElseIf ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = 4 * 22 / 7 * Val(TxtJari.Text) * Val(TxtJari.Text)
        End If
    End Sub
End Class