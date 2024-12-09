Public Class Form1
    Dim flag As Boolean
    Dim ans As Single
    Dim op As String

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button10.Click, Button11.Click, Button13.Click, Button14.Click, Button15.Click, Button17.Click, Button18.Click, Button19.Click, Button22.Click
        If flag = True Then
            ans = TextBox1.Text
            TextBox1.Clear()
        End If
        flag = False
            TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button12.Click, Button16.Click, Button20.Click, Button24.Click
        flag = True
        If op = "" Then
            op = sender.text
            Exit Sub
        End If
        Select Case op
            Case "+"
                ans = ans + TextBox1.Text
            Case "-"
                ans = ans - TextBox1.Text
            Case "*"
                ans = ans * TextBox1.Text
            Case "/"
                ans = ans / TextBox1.Text
        End Select
        TextBox1.Text = ans
        op = sender.text
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = TextBox1.Text * -1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        flag = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        op = ""
        ans = 0
        flag = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text.IndexOf(".") < 0 Then
            TextBox1.Text = TextBox1.Text & "."
        End If
    End Sub
End Class
