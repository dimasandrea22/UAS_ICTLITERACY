Public Class FormPilihan
    Private Sub FormPilihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDatar.Click
        FormDatar.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnRuang.Click
        FormRuang.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim close = MessageBox.Show("Anda Yakin Ingin Kembali Ke Menu Utama?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = vbYes Then
            Me.Close()
            FormLogin.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub BtnOperasi_Click(sender As Object, e As EventArgs) Handles BtnOperasi.Click
        Me.Hide()
        Kalkulator.Show()
    End Sub
End Class