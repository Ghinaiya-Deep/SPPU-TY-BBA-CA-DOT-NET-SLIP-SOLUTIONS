Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DetailsView1_ItemInserted(sender As Object, e As DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
        MsgBox("Record Inserted Successfully........")
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_RowUpdated(sender As Object, e As GridViewUpdatedEventArgs) Handles GridView1.RowUpdated
        MsgBox("Record Updated Successfully........")
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_RowDeleted(sender As Object, e As GridViewDeletedEventArgs) Handles GridView1.RowDeleted
        MsgBox("Record Deleted Successfully........")
        GridView1.DataBind()
    End Sub


End Class