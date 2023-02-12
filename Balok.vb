Public Class Balok
    Private Sub Balok_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = 2 * (Val(TxtPanjang.Text * TxtLebar.Text) + Val(TxtPanjang.Text * TxtTinggi.Text) + Val(TxtTinggi.Text * TxtLebar.Text))
        ElseIf ComboBox1.Text = "Volume" Then
            TxtHasil.Text = Val(TxtPanjang.Text * TxtLebar.Text * TxtTinggi.Text)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtPanjang.Text = ""
        TxtLebar.Text = ""
        TxtTinggi.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormRuang.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtPanjang.Text = ""
        TxtLebar.Text = ""
        TxtTinggi.Text = ""
        ComboBox1.Focus()
    End Sub
End Class