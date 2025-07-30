Imports System.Reflection.Emit

Public Class WebForm1
    Inherits System.Web.UI.Page
    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.Items(0).Selected = True Then
            Image2.ImageUrl = "C:\Users\deepc\Downloads\ChatGPT Image Apr 9, 2025, 08_55_04 AM.png"
        ElseIf ListBox1.Items(1).Selected = True Then
            Image2.ImageUrl = "C:\Users\Admin\Pictures\watch.jpg"
        ElseIf ListBox1.Items(2).Selected = True Then
            Image2.ImageUrl = "C:\Users\Admin\Pictures\goggle.jpg"
        Else
            Image2.ImageUrl = "C:\Users\Admin\Pictures\pen.jpg"
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items(0).Selected = True Then
            Label1.Text = "Rs. 200"
        ElseIf ListBox1.Items(1).Selected = True Then
            Label1.Text = "Rs. 4000"
        ElseIf ListBox1.Items(2).Selected = True Then
            Label1.Text = "Rs. 2000"
        Else
            Label1.Text = "Rs. 100"
        End If
    End Sub
End Class