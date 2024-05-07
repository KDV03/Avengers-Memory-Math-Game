<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ResultsContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GoBackToWelcomeFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListBox = New System.Windows.Forms.ListBox()
        Me.ScoreListBox = New System.Windows.Forms.ListBox()
        Me.ResultsToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.ResultsLbl = New System.Windows.Forms.Label()
        Me.ResultsContextMenuStrip.SuspendLayout()
        Me.ResultsMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResultsContextMenuStrip
        '
        Me.ResultsContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ResultsContextMenuStrip.Name = "ResultsContextMenuStrip"
        Me.ResultsContextMenuStrip.Size = New System.Drawing.Size(259, 76)
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(258, 24)
        Me.GoBackToolStripMenuItem.Text = "Go Back To Welcome Form"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(258, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(258, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ResultsMenuStrip
        '
        Me.ResultsMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ResultsMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToWelcomeFormToolStripMenuItem, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ResultsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ResultsMenuStrip.Name = "ResultsMenuStrip"
        Me.ResultsMenuStrip.Size = New System.Drawing.Size(905, 25)
        Me.ResultsMenuStrip.TabIndex = 1
        Me.ResultsMenuStrip.Text = "MenuStrip1"
        '
        'GoBackToWelcomeFormToolStripMenuItem
        '
        Me.GoBackToWelcomeFormToolStripMenuItem.Name = "GoBackToWelcomeFormToolStripMenuItem"
        Me.GoBackToWelcomeFormToolStripMenuItem.Size = New System.Drawing.Size(189, 21)
        Me.GoBackToWelcomeFormToolStripMenuItem.Text = "Go Back To Welcome form"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(57, 21)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(42, 21)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'UserListBox
        '
        Me.UserListBox.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserListBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UserListBox.FormattingEnabled = True
        Me.UserListBox.ItemHeight = 27
        Me.UserListBox.Items.AddRange(New Object() {"Black Widow", "Hulk", "Iron Man"})
        Me.UserListBox.Location = New System.Drawing.Point(106, 161)
        Me.UserListBox.Name = "UserListBox"
        Me.UserListBox.Size = New System.Drawing.Size(303, 220)
        Me.UserListBox.TabIndex = 2
        Me.ResultsToolTipText.SetToolTip(Me.UserListBox, "List of users on scoreboard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your results are selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'ScoreListBox
        '
        Me.ScoreListBox.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreListBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ScoreListBox.FormattingEnabled = True
        Me.ScoreListBox.ItemHeight = 27
        Me.ScoreListBox.Items.AddRange(New Object() {"100", "165", "50"})
        Me.ScoreListBox.Location = New System.Drawing.Point(485, 161)
        Me.ScoreListBox.Name = "ScoreListBox"
        Me.ScoreListBox.Size = New System.Drawing.Size(301, 220)
        Me.ScoreListBox.TabIndex = 3
        Me.ResultsToolTipText.SetToolTip(Me.ScoreListBox, "List of scores of the correlated users" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your score is selected")
        '
        'ResultsLbl
        '
        Me.ResultsLbl.AutoSize = True
        Me.ResultsLbl.Font = New System.Drawing.Font("Ravie", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ResultsLbl.Location = New System.Drawing.Point(311, 53)
        Me.ResultsLbl.Name = "ResultsLbl"
        Me.ResultsLbl.Size = New System.Drawing.Size(281, 63)
        Me.ResultsLbl.TabIndex = 4
        Me.ResultsLbl.Text = "Results"
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(905, 574)
        Me.ContextMenuStrip = Me.ResultsContextMenuStrip
        Me.Controls.Add(Me.ResultsLbl)
        Me.Controls.Add(Me.ScoreListBox)
        Me.Controls.Add(Me.UserListBox)
        Me.Controls.Add(Me.ResultsMenuStrip)
        Me.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MainMenuStrip = Me.ResultsMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ResultsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results Screen"
        Me.ResultsContextMenuStrip.ResumeLayout(False)
        Me.ResultsMenuStrip.ResumeLayout(False)
        Me.ResultsMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ResultsContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GoBackToWelcomeFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserListBox As System.Windows.Forms.ListBox
    Friend WithEvents ScoreListBox As System.Windows.Forms.ListBox
    Friend WithEvents ResultsToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents ResultsLbl As System.Windows.Forms.Label
End Class
