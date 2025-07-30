Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        Dim a As Integer = CInt(TextBox1.Text)

        For i = 1 To 10
            ListBox1.Items.Add(a * i)
        Next

    End Sub
End Class
