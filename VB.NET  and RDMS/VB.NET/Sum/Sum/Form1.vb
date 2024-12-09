Public Class Form1
    Dim operation As String
    Dim answer As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        operation = "+"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        operation = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        operation = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        operation = "/"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (operation Is "+") Then
            answer = Val(TextBox1.Text) + (TextBox2.Text)
        ElseIf (operation Is "-") Then
            answer = Val(TextBox1.Text) - (TextBox2.Text)
        ElseIf (operation Is "*") Then
            answer = Val(TextBox1.Text) * (TextBox2.Text)
        Else
            answer = Val(TextBox1.Text) / (TextBox2.Text)
        End If
        MessageBox.Show("Answer = " & answer)
    End Sub
End Class
