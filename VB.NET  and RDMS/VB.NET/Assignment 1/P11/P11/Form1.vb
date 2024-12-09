Public Class Form1
    Dim p1 As String
    Dim p2 As String
    Dim cnt As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        p1 = InputBox("Select an X/O", "Tic Tac Toe", "X")
        If p1 = "X" Then
            p2 = "O"
        Else
            p2 = "X"
        End If
        GroupBox1.Enabled = True
        cnt = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        If sender.text = "" Then
            If cnt Mod 2 = 0 Then
                sender.text = p2
                checkwinner(p2)
            Else
                sender.text = p1
                checkwinner(p1)
            End If
            cnt += 1
        End If
    End Sub
    Sub checkwinner(ByVal p As String)
        Dim flag As Boolean
        If Button1.Text <> "" And Button1.Text = Button2.Text And Button1.Text = Button3.Text Then
            flag = True
        ElseIf Button4.Text <> "" And Button4.Text = Button5.Text And Button4.Text = Button6.Text Then
            flag = True
        ElseIf Button7.Text <> "" And Button7.Text = Button8.Text And Button7.Text = Button9.Text Then
            flag = True
        ElseIf Button1.Text <> "" And Button1.Text = Button4.Text And Button1.Text = Button7.Text Then
            flag = True
        ElseIf Button2.Text <> "" And Button2.Text = Button5.Text And Button2.Text = Button8.Text Then
            flag = True
        ElseIf Button3.Text <> "" And Button3.Text = Button6.Text And Button3.Text = Button9.Text Then
            flag = True
        ElseIf Button1.Text <> "" And Button1.Text = Button5.Text And Button1.Text = Button9.Text Then
            flag = True
        ElseIf Button3.Text <> "" And Button3.Text = Button5.Text And Button3.Text = Button7.Text Then
            flag = True
        End If
        If flag = True Then
            MessageBox.Show("Winner is " & p)
            clear()
            GroupBox1.Enabled = False
            Exit Sub
        End If
        If cnt = 9 Then
            MessageBox.Show("No one wins")
            clear()
            GroupBox1.Enabled = False
        End If
    End Sub
    Sub clear()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub
End Class
