Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Button1.Click, AddressOf Button1_Click
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim color As String = ListBox1.SelectedValue

        If color = "Red" Then
            bodyTag.Attributes("style") = "background-color:Red"
        ElseIf color = "Green" Then
            bodyTag.Attributes("style") = "background-color:Green"
        ElseIf color = "Blue" Then
            bodyTag.Attributes("style") = "background-color:Blue"
        ElseIf color = "Yellow" Then
            bodyTag.Attributes("style") = "background-color:Yellow"
        Else
            bodyTag.Attributes("style") = "background-color:White"
        End If
    End Sub
End Class
