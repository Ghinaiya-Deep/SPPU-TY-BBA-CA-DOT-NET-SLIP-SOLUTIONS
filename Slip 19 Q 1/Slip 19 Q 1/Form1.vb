Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Dim rev As String = StrReverse(str)

        If str = rev Then
            MsgBox("The String is Palindrome")
        Else
            MsgBox("The String is not Palindrome")
        End If
    End Sub
End Class
