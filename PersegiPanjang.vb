Public Class PersegiPanjang
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtLebar.Text = ""
        TxtPanjang.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtLebar.Text = ""
        TxtPanjang.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = 2 * Val(TxtPanjang.Text) + 2 * Val(TxtLebar.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = Val(TxtPanjang.Text * TxtLebar.Text)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TxtHasil_TextChanged(sender As Object, e As EventArgs) Handles TxtHasil.TextChanged

    End Sub

    Private Sub LblHasil_Click(sender As Object, e As EventArgs) Handles LblHasil.Click

    End Sub

    Private Sub TxtLebar_TextChanged(sender As Object, e As EventArgs) Handles TxtLebar.TextChanged

    End Sub

    Private Sub TxtPanjang_TextChanged(sender As Object, e As EventArgs) Handles TxtPanjang.TextChanged

    End Sub

    Private Sub LblPanjang_Click(sender As Object, e As EventArgs) Handles LblPanjang.Click

    End Sub

    Private Sub LblPilihan_Click(sender As Object, e As EventArgs) Handles LblPilihan.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class