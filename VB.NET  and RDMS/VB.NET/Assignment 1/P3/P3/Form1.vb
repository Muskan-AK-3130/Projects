Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.MaxLength = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "A" Or TextBox1.Text = "E" Or TextBox1.Text = "I" Or TextBox1.Text = "O" Or TextBox1.Text = "U" Or TextBox1.Text = "a" Or TextBox1.Text = "e" Or TextBox1.Text = "i" Or TextBox1.Text = "o" Or TextBox1.Text = "u" Then
            TextBox2.Text = "Vowel"
        Else
            TextBox2.Text = "Consonant"
        End If

    End Sub
End Class
