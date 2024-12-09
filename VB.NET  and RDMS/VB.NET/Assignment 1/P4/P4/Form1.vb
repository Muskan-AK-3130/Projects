Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Text = TextBox1.Text * 10 / 100
        TextBox3.Text = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Text = TextBox1.Text * 20 / 100
        TextBox3.Text = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox2.Text = TextBox1.Text * 25 / 100
        TextBox3.Text = TextBox1.Text - TextBox2.Text
    End Sub
End Class
