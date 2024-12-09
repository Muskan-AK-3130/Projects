Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As New ListViewItem(TextBox1.Text)
        row.SubItems.Add(TextBox2.Text)
        row.SubItems.Add(TextBox3.Text)
        row.SubItems.Add(TextBox4.Text)
        row.SubItems.Add(TextBox5.Text)
        row.SubItems.Add(TextBox5.Text)
        ListView1.Items.Add(row)

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Enter correct Application Number")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Enter Name")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Enter Email")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "Enter Contact Number")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "Enter Address")
            TextBox5.Focus()
        ElseIf TextBox6.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "Enter Course")
            TextBox6.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rno As Integer
        Dim flag As Boolean
        rno = InputBox("Enter Application Number to delete ")
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).Text = rno Then
                ListView1.Items.RemoveAt(i)
                flag = True
                Exit Sub
            End If
        Next
        If flag = False Then
            MsgBox("Application Number does not exist")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
