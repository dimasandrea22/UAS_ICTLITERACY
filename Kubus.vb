Public Class Kubus
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        If ComboBox1.Text = "Luas Permukaan" Then
            TxtHasil.Text = 6 * Val(TxtSisi.Text * TxtSisi.Text)
        ElseIf ComboBox1.Text = "Volume" Then
            TxtHasil.Text = Val(TxtSisi.Text * TxtSisi.Text * TxtSisi.Text)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtSisi.Text = ""
        ComboBox1.Focus()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormRuang.Show()
        Me.Hide()
        ComboBox1.Text = ""
        TxtHasil.Text = ""
        TxtSisi.Text = ""
        ComboBox1.Focus()
    End Sub
End Class