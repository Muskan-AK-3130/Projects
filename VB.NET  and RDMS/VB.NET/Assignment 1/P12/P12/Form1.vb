Public Class Form1
    Dim sec As Integer = 0
    Dim min As Integer = 0
    Dim hr As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(hr, "00:") & Format(min, "00:") & Format(sec, "00")
        sec = sec + 1
        If (sec = 60) Then
            min = min + 1
            sec = 0
        End If
        If (min = 60) Then
            hr = hr + 1
            min = 0
            sec = 0
        End If
        If (hr = 24) Then
            hr = 0
            min = 0
            sec = 0
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hr = 0
        min = 0
        sec = 0
        Label1.Text = "00:00:00"
        Timer1.Enabled = False
    End Sub
End Class
