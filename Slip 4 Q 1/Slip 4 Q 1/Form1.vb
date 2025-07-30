Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim d As DateTime
        d = DateTimePicker1.Value
        TextBox1.Text = d.Day
        TextBox2.Text = d.Month
        TextBox3.Text = d.Year
    End Sub
End Class
