Public Class Persegi
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormDatar.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtSisi.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtSisi.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Keliling" Then
            TxtHasil.Text = 4 * Val(TxtSisi.Text)
        ElseIf ComboBox1.Text = "Luas" Then
            TxtHasil.Text = Val(TxtSisi.Text * TxtSisi.Text)
        End If
    End Sub

    Private Sub Persegi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class