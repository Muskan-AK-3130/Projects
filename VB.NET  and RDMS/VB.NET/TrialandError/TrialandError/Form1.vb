Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'create a new ListView
        Dim ListView1 As ListView
            ListView1 = Me.ListView1
            ListView1.View = View.Details

            'Creating the list items
            Dim ListItem1 As ListViewItem
            ListItem1 = ListView1.Items.Add("Item 1")

            'How can I put this in the 2nd column
            Dim ListItem2 As ListViewItem
        ListItem2 = ListView1.Items.Add("Item 2")

    End Sub
End Class
