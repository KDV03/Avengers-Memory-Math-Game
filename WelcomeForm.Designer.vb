<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Me.NameOfGameLbl = New System.Windows.Forms.Label()
        Me.WelcomeGrpBox = New System.Windows.Forms.GroupBox()
        Me.UsernameListBox = New System.Windows.Forms.ListBox()
        Me.BeginBtn = New System.Windows.Forms.Button()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.WelcomeFormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeFormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoPicBox = New System.Windows.Forms.PictureBox()
        Me.ToolTiponWelcomeForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.WelcomeGrpBox.SuspendLayout()
        Me.WelcomeFormMenuStrip.SuspendLayout()
        Me.WelcomeFormContextMenuStrip.SuspendLayout()
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameOfGameLbl
        '
        Me.NameOfGameLbl.AutoSize = True
        Me.NameOfGameLbl.Font = New System.Drawing.Font("Ravie", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfGameLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.NameOfGameLbl.Location = New System.Drawing.Point(60, 53)
        Me.NameOfGameLbl.Name = "NameOfGameLbl"
        Me.NameOfGameLbl.Size = New System.Drawing.Size(615, 63)
        Me.NameOfGameLbl.TabIndex = 0
        Me.NameOfGameLbl.Text = "Marvellous Maths"
        '
        'WelcomeGrpBox
        '
        Me.WelcomeGrpBox.Controls.Add(Me.UsernameListBox)
        Me.WelcomeGrpBox.Controls.Add(Me.BeginBtn)
        Me.WelcomeGrpBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.WelcomeGrpBox.Location = New System.Drawing.Point(12, 149)
        Me.WelcomeGrpBox.Name = "WelcomeGrpBox"
        Me.WelcomeGrpBox.Size = New System.Drawing.Size(447, 300)
        Me.WelcomeGrpBox.TabIndex = 1
        Me.WelcomeGrpBox.TabStop = False
        Me.WelcomeGrpBox.Text = "Please select a username then click 'Begin' to continue"
        '
        'UsernameListBox
        '
        Me.UsernameListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.UsernameListBox.FormattingEnabled = True
        Me.UsernameListBox.ItemHeight = 27
        Me.UsernameListBox.Items.AddRange(New Object() {"Black Widow", "Captain America", "Hulk", "Iron Man", "Thor"})
        Me.UsernameListBox.Location = New System.Drawing.Point(17, 77)
        Me.UsernameListBox.Name = "UsernameListBox"
        Me.UsernameListBox.Size = New System.Drawing.Size(250, 139)
        Me.UsernameListBox.TabIndex = 1
        Me.ToolTiponWelcomeForm.SetToolTip(Me.UsernameListBox, "Select a character to use throughout the game")
        '
        'BeginBtn
        '
        Me.BeginBtn.Location = New System.Drawing.Point(301, 104)
        Me.BeginBtn.Name = "BeginBtn"
        Me.BeginBtn.Size = New System.Drawing.Size(128, 76)
        Me.BeginBtn.TabIndex = 0
        Me.BeginBtn.Text = "Begin"
        Me.ToolTiponWelcomeForm.SetToolTip(Me.BeginBtn, "Click here to begin the game")
        Me.BeginBtn.UseVisualStyleBackColor = True
        '
        'AboutBtn
        '
        Me.AboutBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.AboutBtn.Location = New System.Drawing.Point(27, 495)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(137, 48)
        Me.AboutBtn.TabIndex = 2
        Me.AboutBtn.Text = "A&bout"
        Me.ToolTiponWelcomeForm.SetToolTip(Me.AboutBtn, "Click here to find more information on the game" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alt+b to view information on the" & _
                " game")
        Me.AboutBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ExitBtn.Location = New System.Drawing.Point(614, 495)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(137, 48)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "E&xit"
        Me.ToolTiponWelcomeForm.SetToolTip(Me.ExitBtn, "Click here to exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alt+x to exit ")
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'WelcomeFormMenuStrip
        '
        Me.WelcomeFormMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.WelcomeFormMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.WelcomeFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.WelcomeFormMenuStrip.Name = "WelcomeFormMenuStrip"
        Me.WelcomeFormMenuStrip.Size = New System.Drawing.Size(782, 26)
        Me.WelcomeFormMenuStrip.TabIndex = 4
        Me.WelcomeFormMenuStrip.Text = "WelcomeFormMenuStrip"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WelcomeFormContextMenuStrip
        '
        Me.WelcomeFormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1, Me.ExitToolStripMenuItem2})
        Me.WelcomeFormContextMenuStrip.Name = "WelcomeFormContextMenuStrip"
        Me.WelcomeFormContextMenuStrip.Size = New System.Drawing.Size(120, 52)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(119, 24)
        Me.ExitToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(119, 24)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'LogoPicBox
        '
        Me.LogoPicBox.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.LogoPicBox.Location = New System.Drawing.Point(490, 209)
        Me.LogoPicBox.Name = "LogoPicBox"
        Me.LogoPicBox.Size = New System.Drawing.Size(280, 179)
        Me.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPicBox.TabIndex = 5
        Me.LogoPicBox.TabStop = False
        Me.ToolTiponWelcomeForm.SetToolTip(Me.LogoPicBox, "Game logo")
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(782, 555)
        Me.ContextMenuStrip = Me.WelcomeFormContextMenuStrip
        Me.Controls.Add(Me.LogoPicBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.AboutBtn)
        Me.Controls.Add(Me.WelcomeGrpBox)
        Me.Controls.Add(Me.NameOfGameLbl)
        Me.Controls.Add(Me.WelcomeFormMenuStrip)
        Me.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.WelcomeFormMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "WelcomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To Marvellous Maths"
        Me.WelcomeGrpBox.ResumeLayout(False)
        Me.WelcomeFormMenuStrip.ResumeLayout(False)
        Me.WelcomeFormMenuStrip.PerformLayout()
        Me.WelcomeFormContextMenuStrip.ResumeLayout(False)
        CType(Me.LogoPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameOfGameLbl As System.Windows.Forms.Label
    Friend WithEvents WelcomeGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents UsernameListBox As System.Windows.Forms.ListBox
    Friend WithEvents BeginBtn As System.Windows.Forms.Button
    Friend WithEvents AboutBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents WelcomeFormMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WelcomeFormContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTiponWelcomeForm As System.Windows.Forms.ToolTip

End Class
