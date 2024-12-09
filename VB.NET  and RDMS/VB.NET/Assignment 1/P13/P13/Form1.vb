Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        If TextBox3.Text > 100000 Then
            TextBox4.Text = TextBox3.Text - (Val(TextBox3.Text) * 0.2)
        ElseIf TextBox3.Text > 75000 Then
            TextBox4.Text = TextBox3.Text - (Val(TextBox3.Text) * 0.15)
        ElseIf TextBox3.Text > 50000 Then
            TextBox4.Text = TextBox3.Text - (Val(TextBox3.Text) * 0.1)
        Else
            TextBox4.Text = TextBox3.Text - (Val(TextBox3.Text) * 0.05)
        End If
    End Sub
End Class
