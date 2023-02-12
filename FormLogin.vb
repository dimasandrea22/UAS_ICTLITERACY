Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "" Then
            MsgBox("Username Harus Diisi", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            TxtUsername.Focus()
        Else
            MsgBox("Selamat Datang " + TxtUsername.Text, MessageBoxButtons.OK)
            FormPilihan.Show()
            Me.Hide()
        End If
        TxtUsername.Text = ""
        TxtUsername.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim tanya = MessageBox.Show("Anda Yakin Ingin Menutup Aplikasi?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
