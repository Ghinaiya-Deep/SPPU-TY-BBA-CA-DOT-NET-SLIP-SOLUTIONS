Public Class Form1
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GToolStripMenuItem.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub MaximizedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizedToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MinimizedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizedToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
