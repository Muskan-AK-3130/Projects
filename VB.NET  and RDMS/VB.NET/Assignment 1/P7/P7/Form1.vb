Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox19.Text = Val(TextBox5.Text) + Val(TextBox12.Text) + Val(TextBox6.Text) + Val(TextBox13.Text) + Val(TextBox7.Text) + Val(TextBox14.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox9.Text) + Val(TextBox16.Text) + Val(TextBox10.Text) + Val(TextBox17.Text) + Val(TextBox11.Text) + Val(TextBox18.Text)
        TextBox20.Text = Val(TextBox19.Text) / 7
        If TextBox20.Text > 90 Then
            TextBox21.Text = "A+"
        ElseIf TextBox20.Text > 80 Then
            TextBox21.Text = "B"
        ElseIf TextBox20.Text > 70 Then
            TextBox21.Text = "C"
        ElseIf TextBox20.Text > 60 Then
            TextBox21.Text = "D"
        ElseIf TextBox20.Text > 35 Then
            TextBox21.Text = "E"
        Else
            TextBox21.Text = "FAIL"
        End If
    End Sub
End Class
