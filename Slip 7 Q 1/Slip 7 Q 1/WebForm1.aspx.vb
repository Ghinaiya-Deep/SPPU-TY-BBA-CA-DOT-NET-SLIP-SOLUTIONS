Public Class WebForm1
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = CInt(TextBox1.Text)
        Dim i, sum As Integer
        sum = 0

        For i = 1 To n - 1
            If n Mod i = 0 Then
                sum = sum + i
            End If
        Next

        If n = sum Then
            MsgBox(n & " is a Perfect Number ")
        Else
            MsgBox(n & " is not a perfect Number")
        End If
    End Sub
End Class