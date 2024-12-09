Public Class Form1

    Dim cntP As Integer = 0
    Dim cntA As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            Dim item As New ListViewItem(Label2.Text)
            item.SubItems.Add(RadioButton1.Text)
            ListView1.Items.Add(item)
            cntP += 1
        ElseIf RadioButton2.Checked Then
            Dim item As New ListViewItem(Label2.Text)
            item.SubItems.Add(RadioButton2.Text)
            ListView1.Items.Add(item)
            cntA += 1
        Else
            MessageBox.Show("Please Select Present or Absent")
        End If
        Label2.Text = Val(Label2.Text) + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = cntP
        TextBox2.Text = cntA
    End Sub
End Class
