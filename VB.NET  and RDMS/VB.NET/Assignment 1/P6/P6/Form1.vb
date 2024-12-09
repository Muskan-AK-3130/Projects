Public Class Form1
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox1.Text = MonthCalendar1.SelectionStart.Day.ToString()
        TextBox2.Text = MonthCalendar1.SelectionStart.Month.ToString()
        TextBox3.Text = MonthCalendar1.SelectionStart.Year.ToString()
    End Sub
End Class
