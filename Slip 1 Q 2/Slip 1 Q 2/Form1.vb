Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TY Slips Solutions\.Net Solutions\Slip 1 Q 2\Employee.accdb;")

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("INSERT INTO Employee (Eno, Ename, Salary) VALUES (?, ?, ?)", conn)
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text)
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text)
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee details saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim adapter As New OleDbDataAdapter("SELECT * FROM Employee", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class