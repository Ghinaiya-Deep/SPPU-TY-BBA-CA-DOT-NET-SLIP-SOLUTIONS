Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Char
        Dim str As String
        a = TextBox1.Text

        If (TextBox1.Text.Length <= 1) Then
            If Char.IsUpper(a) Then
                str = "Upper Case"
            Else
                str = "Lower Case"
            End If

            If (a = "a" Or a = "A" Or a = "e" Or a = "E" Or a = "i" Or a = "I" Or a = "o" Or a = "O" Or a = "u" Or a = "U") Then
                MsgBox("This is a Vowel and " & str)
            Else
                MsgBox("This is a Consonant and " & str)

            End If
        End If
    End Sub
End Class
