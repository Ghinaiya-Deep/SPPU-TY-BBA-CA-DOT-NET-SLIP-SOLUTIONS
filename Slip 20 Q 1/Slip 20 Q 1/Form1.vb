Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear existing nodes (optional)
        TreeView1.Nodes.Clear()

        ' Root node
        TreeView1.Nodes.Add("BCA")
        TreeView1.Nodes.Add("BBA")

        TreeView1.Nodes(0).Nodes.Add("FY")
        TreeView1.Nodes(0).Nodes.Add("FY")
        TreeView1.Nodes(0).Nodes.Add("FY")

        TreeView1.Nodes(1).Nodes.Add("FY")
        TreeView1.Nodes(1).Nodes.Add("FY")
        TreeView1.Nodes(1).Nodes.Add("FY")
    End Sub
End Class
