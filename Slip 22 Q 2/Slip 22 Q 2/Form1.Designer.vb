<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximizedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColourToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ColourToolStripMenuItem
        '
        Me.ColourToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.GToolStripMenuItem})
        Me.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem"
        Me.ColourToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ColourToolStripMenuItem.Text = "Colour"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaximizedToolStripMenuItem, Me.MinimizedToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GToolStripMenuItem
        '
        Me.GToolStripMenuItem.Name = "GToolStripMenuItem"
        Me.GToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GToolStripMenuItem.Text = "Green"
        '
        'MaximizedToolStripMenuItem
        '
        Me.MaximizedToolStripMenuItem.Name = "MaximizedToolStripMenuItem"
        Me.MaximizedToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MaximizedToolStripMenuItem.Text = "Maximized"
        '
        'MinimizedToolStripMenuItem
        '
        Me.MinimizedToolStripMenuItem.Name = "MinimizedToolStripMenuItem"
        Me.MinimizedToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MinimizedToolStripMenuItem.Text = "Minimized"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximizedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
End Class
