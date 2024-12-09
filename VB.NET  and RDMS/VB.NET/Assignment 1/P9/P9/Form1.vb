Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Integer.Parse(TextBox1.Text)
        TextBox2.Text = Convert.ToString(n, 2)
        TextBox3.Text = Convert.ToString(n, 8)
        TextBox4.Text = n.ToString
        TextBox5.Text = Convert.ToString(n, 16)
    End Sub
End Class
