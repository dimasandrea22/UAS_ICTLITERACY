Public Class Kalkulator
    Dim op As String
    Dim num1 As Integer
    Dim num2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Buttonplus_Click(sender As Object, e As EventArgs) Handles Buttonplus.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "+"
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "-"
    End Sub

    Private Sub ButtonKali_Click(sender As Object, e As EventArgs) Handles ButtonKali.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "*"
    End Sub

    Private Sub ButtonBagi_Click(sender As Object, e As EventArgs) Handles ButtonBagi.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        op = "/"
    End Sub

    Private Sub ButtonHasil_Click(sender As Object, e As EventArgs) Handles ButtonHasil.Click
        num2 = TextBox1.Text
        If op = "+" Then
            TextBox1.Text = num1 + num2
        ElseIf op = "-" Then
            TextBox1.Text = num1 - num2
        ElseIf op = "/" Then
            TextBox1.Text = num1 / num2
        ElseIf op = "*" Then
            TextBox1.Text = num1 * num2
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        FormPilihan.Show()
        TextBox1.Text = ""
    End Sub
End Class