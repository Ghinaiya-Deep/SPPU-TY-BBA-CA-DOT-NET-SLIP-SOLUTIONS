Imports System.Reflection.Emit

Partial Class Vote
    Inherits System.Web.UI.Page

    ' Static variables to store vote counts
    Shared good As Integer = 0
    Shared satisfactory As Integer = 0
    Shared bad As Integer = 0

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim selected As String = RadioButtonList1.SelectedValue

        If selected = "Good" Then
            good += 1
        ElseIf selected = "Satisfactory" Then
            satisfactory += 1
        ElseIf selected = "Bad" Then
            bad += 1
        End If

        Dim total As Integer = good + satisfactory + bad
        If total > 0 Then
            Label2.Text = CInt((good * 100) / total) & "%"
            Label3.Text = CInt((satisfactory * 100) / total) & "%"
            Label4.Text = CInt((bad * 100) / total) & "%"
        End If
    End Sub
End Class
