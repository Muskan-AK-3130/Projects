Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox1.Text.ToUpper
        TextBox3.Text = TextBox1.Text.ToLower
    End Sub
End Class
