Public Class FormRuang
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        FormPilihan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKubus_Click(sender As Object, e As EventArgs) Handles BtnKubus.Click
        Kubus.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBalok_Click(sender As Object, e As EventArgs) Handles BtnBalok.Click
        Balok.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPrisma_Click(sender As Object, e As EventArgs) Handles BtnPrisma.Click
        Me.Hide()
        PrismaSegi3.Show()
    End Sub

    Private Sub BtnLimSegitiga_Click(sender As Object, e As EventArgs) Handles BtnLimSegitiga.Click
        Me.Hide()
        LimasSegi3.Show()
    End Sub

    Private Sub BtnTabung_Click(sender As Object, e As EventArgs) Handles BtnTabung.Click
        Me.Hide()
        Tabung.Show()
    End Sub

    Private Sub BtnBola_Click(sender As Object, e As EventArgs) Handles BtnBola.Click
        Me.Hide()
        Bola.Show()
    End Sub

    Private Sub BtnKerucut_Click(sender As Object, e As EventArgs) Handles BtnKerucut.Click
        Me.Hide()
        Kerucut.Show
    End Sub

    Private Sub BtnLimSegiempat_Click(sender As Object, e As EventArgs) Handles BtnLimSegiempat.Click
        Me.Hide()
        LimasSegi4.Show()
    End Sub
End Class