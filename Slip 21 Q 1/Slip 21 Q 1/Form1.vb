Public Class Form1
    Private Sub btnCountWords_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sentence As String = TextBox1.Text.Trim()

        If sentence = "" Then
            MsgBox("Number of words: 0")
        Else
            Dim words() As String = sentence.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Dim wordCount As Integer = words.Length
            MsgBox("Number of words: " & wordCount)
        End If
    End Sub
End Class
