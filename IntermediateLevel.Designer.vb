<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntermediateLevel
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
        Me.UsernameGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserNameLbl = New System.Windows.Forms.Label()
        Me.UsernamePicBox = New System.Windows.Forms.PictureBox()
        Me.ScoreGroupBox = New System.Windows.Forms.GroupBox()
        Me.ScoreTxtBox = New System.Windows.Forms.TextBox()
        Me.IntermediateMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GoBackToWelcomeFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ImgBox12 = New System.Windows.Forms.PictureBox()
        Me.ImgBox3 = New System.Windows.Forms.PictureBox()
        Me.ImgBox5 = New System.Windows.Forms.PictureBox()
        Me.ImgBox2 = New System.Windows.Forms.PictureBox()
        Me.ImgBox4 = New System.Windows.Forms.PictureBox()
        Me.ImgBox7 = New System.Windows.Forms.PictureBox()
        Me.ImgBox8 = New System.Windows.Forms.PictureBox()
        Me.ImgBox9 = New System.Windows.Forms.PictureBox()
        Me.ImgBox6 = New System.Windows.Forms.PictureBox()
        Me.ImgBox1 = New System.Windows.Forms.PictureBox()
        Me.ImgBox10 = New System.Windows.Forms.PictureBox()
        Me.ImgBox11 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IntermediateLevelToolTipText = New System.Windows.Forms.ToolTip(Me.components)
        Me.IntermediateLevelcontextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsernameGroupBox.SuspendLayout()
        CType(Me.UsernamePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScoreGroupBox.SuspendLayout()
        Me.IntermediateMenuStrip.SuspendLayout()
        CType(Me.ImgBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IntermediateLevelcontextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameGroupBox
        '
        Me.UsernameGroupBox.Controls.Add(Me.UserNameLbl)
        Me.UsernameGroupBox.Controls.Add(Me.UsernamePicBox)
        Me.UsernameGroupBox.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UsernameGroupBox.Location = New System.Drawing.Point(32, 70)
        Me.UsernameGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernameGroupBox.Name = "UsernameGroupBox"
        Me.UsernameGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernameGroupBox.Size = New System.Drawing.Size(287, 346)
        Me.UsernameGroupBox.TabIndex = 5
        Me.UsernameGroupBox.TabStop = False
        Me.UsernameGroupBox.Text = "Username Details"
        '
        'UserNameLbl
        '
        Me.UserNameLbl.AutoSize = True
        Me.UserNameLbl.Font = New System.Drawing.Font("Ravie", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLbl.Location = New System.Drawing.Point(32, 250)
        Me.UserNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(36, 26)
        Me.UserNameLbl.TabIndex = 1
        Me.UserNameLbl.Text = "..."
        '
        'UsernamePicBox
        '
        Me.UsernamePicBox.BackColor = System.Drawing.Color.PaleGreen
        Me.UsernamePicBox.Location = New System.Drawing.Point(67, 59)
        Me.UsernamePicBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UsernamePicBox.Name = "UsernamePicBox"
        Me.UsernamePicBox.Size = New System.Drawing.Size(147, 134)
        Me.UsernamePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernamePicBox.TabIndex = 1
        Me.UsernamePicBox.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.UsernamePicBox, "Your current Username")
        '
        'ScoreGroupBox
        '
        Me.ScoreGroupBox.Controls.Add(Me.ScoreTxtBox)
        Me.ScoreGroupBox.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ScoreGroupBox.Location = New System.Drawing.Point(32, 423)
        Me.ScoreGroupBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScoreGroupBox.Name = "ScoreGroupBox"
        Me.ScoreGroupBox.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScoreGroupBox.Size = New System.Drawing.Size(280, 239)
        Me.ScoreGroupBox.TabIndex = 6
        Me.ScoreGroupBox.TabStop = False
        Me.ScoreGroupBox.Text = "Score Box"
        '
        'ScoreTxtBox
        '
        Me.ScoreTxtBox.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTxtBox.Location = New System.Drawing.Point(67, 105)
        Me.ScoreTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScoreTxtBox.Name = "ScoreTxtBox"
        Me.ScoreTxtBox.ReadOnly = True
        Me.ScoreTxtBox.Size = New System.Drawing.Size(115, 51)
        Me.ScoreTxtBox.TabIndex = 3
        Me.ScoreTxtBox.Text = "0"
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ScoreTxtBox, "Your current Score")
        '
        'IntermediateMenuStrip
        '
        Me.IntermediateMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IntermediateMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntermediateMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToWelcomeFormToolStripMenuItem, Me.AboutBoxToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.IntermediateMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.IntermediateMenuStrip.Name = "IntermediateMenuStrip"
        Me.IntermediateMenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.IntermediateMenuStrip.Size = New System.Drawing.Size(1371, 25)
        Me.IntermediateMenuStrip.TabIndex = 22
        Me.IntermediateMenuStrip.Text = "IntermediateMenuStrip"
        '
        'GoBackToWelcomeFormToolStripMenuItem
        '
        Me.GoBackToWelcomeFormToolStripMenuItem.Name = "GoBackToWelcomeFormToolStripMenuItem"
        Me.GoBackToWelcomeFormToolStripMenuItem.Size = New System.Drawing.Size(193, 21)
        Me.GoBackToWelcomeFormToolStripMenuItem.Text = "Go Back To Welcome Form"
        '
        'AboutBoxToolStripMenuItem
        '
        Me.AboutBoxToolStripMenuItem.Name = "AboutBoxToolStripMenuItem"
        Me.AboutBoxToolStripMenuItem.Size = New System.Drawing.Size(84, 21)
        Me.AboutBoxToolStripMenuItem.Text = "About Box"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'IntermediateTimer
        '
        Me.IntermediateTimer.Enabled = True
        Me.IntermediateTimer.Interval = 5000
        '
        'ImgBox12
        '
        Me.ImgBox12.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox12.Location = New System.Drawing.Point(1112, 414)
        Me.ImgBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox12.Name = "ImgBox12"
        Me.ImgBox12.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox12.TabIndex = 21
        Me.ImgBox12.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox12, "Click here to reveal the image ")
        '
        'ImgBox3
        '
        Me.ImgBox3.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox3.Location = New System.Drawing.Point(1112, 250)
        Me.ImgBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox3.Name = "ImgBox3"
        Me.ImgBox3.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox3.TabIndex = 20
        Me.ImgBox3.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox3, "Click here to reveal the image ")
        '
        'ImgBox5
        '
        Me.ImgBox5.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox5.Location = New System.Drawing.Point(859, 414)
        Me.ImgBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox5.Name = "ImgBox5"
        Me.ImgBox5.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox5.TabIndex = 19
        Me.ImgBox5.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox5, "Click here to reveal the image ")
        '
        'ImgBox2
        '
        Me.ImgBox2.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox2.Location = New System.Drawing.Point(859, 250)
        Me.ImgBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox2.Name = "ImgBox2"
        Me.ImgBox2.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox2.TabIndex = 18
        Me.ImgBox2.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox2, "Click here to reveal the image ")
        '
        'ImgBox4
        '
        Me.ImgBox4.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox4.Location = New System.Drawing.Point(605, 414)
        Me.ImgBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox4.Name = "ImgBox4"
        Me.ImgBox4.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox4.TabIndex = 17
        Me.ImgBox4.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox4, "Click here to reveal the image ")
        '
        'ImgBox7
        '
        Me.ImgBox7.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox7.Location = New System.Drawing.Point(605, 250)
        Me.ImgBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox7.Name = "ImgBox7"
        Me.ImgBox7.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox7.TabIndex = 16
        Me.ImgBox7.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox7, "Click here to reveal the image ")
        '
        'ImgBox8
        '
        Me.ImgBox8.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox8.Location = New System.Drawing.Point(345, 414)
        Me.ImgBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox8.Name = "ImgBox8"
        Me.ImgBox8.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox8.TabIndex = 15
        Me.ImgBox8.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox8, "Click here to reveal the image ")
        '
        'ImgBox9
        '
        Me.ImgBox9.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox9.Location = New System.Drawing.Point(345, 250)
        Me.ImgBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox9.Name = "ImgBox9"
        Me.ImgBox9.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox9.TabIndex = 10
        Me.ImgBox9.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox9, "Click here to reveal the image ")
        '
        'ImgBox6
        '
        Me.ImgBox6.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox6.Location = New System.Drawing.Point(1112, 89)
        Me.ImgBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox6.Name = "ImgBox6"
        Me.ImgBox6.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox6.TabIndex = 9
        Me.ImgBox6.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox6, "Click here to reveal the image ")
        '
        'ImgBox1
        '
        Me.ImgBox1.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox1.Location = New System.Drawing.Point(859, 89)
        Me.ImgBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox1.Name = "ImgBox1"
        Me.ImgBox1.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox1.TabIndex = 8
        Me.ImgBox1.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox1, "Click here to reveal the image ")
        '
        'ImgBox10
        '
        Me.ImgBox10.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox10.Location = New System.Drawing.Point(605, 89)
        Me.ImgBox10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox10.Name = "ImgBox10"
        Me.ImgBox10.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox10.TabIndex = 7
        Me.ImgBox10.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox10, "Click here to reveal the image ")
        '
        'ImgBox11
        '
        Me.ImgBox11.Image = Global.ISTN2IP_Frostbyte_Group_Assignment.My.Resources.Resources.GameLogo
        Me.ImgBox11.Location = New System.Drawing.Point(345, 89)
        Me.ImgBox11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImgBox11.Name = "ImgBox11"
        Me.ImgBox11.Size = New System.Drawing.Size(219, 134)
        Me.ImgBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox11.TabIndex = 4
        Me.ImgBox11.TabStop = False
        Me.IntermediateLevelToolTipText.SetToolTip(Me.ImgBox11, "Click here to reveal the image ")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 7000
        '
        'IntermediateLevelcontextMenuStrip
        '
        Me.IntermediateLevelcontextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.IntermediateLevelcontextMenuStrip.Name = "IntermediateLevelcontextMenuStrip"
        Me.IntermediateLevelcontextMenuStrip.Size = New System.Drawing.Size(120, 52)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'IntermediateLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1371, 676)
        Me.ContextMenuStrip = Me.IntermediateLevelcontextMenuStrip
        Me.Controls.Add(Me.IntermediateMenuStrip)
        Me.Controls.Add(Me.ImgBox12)
        Me.Controls.Add(Me.ImgBox3)
        Me.Controls.Add(Me.ImgBox5)
        Me.Controls.Add(Me.ImgBox2)
        Me.Controls.Add(Me.ImgBox4)
        Me.Controls.Add(Me.ImgBox7)
        Me.Controls.Add(Me.ImgBox8)
        Me.Controls.Add(Me.ImgBox9)
        Me.Controls.Add(Me.ImgBox6)
        Me.Controls.Add(Me.ImgBox1)
        Me.Controls.Add(Me.ImgBox10)
        Me.Controls.Add(Me.ScoreGroupBox)
        Me.Controls.Add(Me.UsernameGroupBox)
        Me.Controls.Add(Me.ImgBox11)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IntermediateLevel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intermediate Level"
        Me.IntermediateLevelToolTipText.SetToolTip(Me, "Click here to reveal the image ")
        Me.UsernameGroupBox.ResumeLayout(False)
        Me.UsernameGroupBox.PerformLayout()
        CType(Me.UsernamePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScoreGroupBox.ResumeLayout(False)
        Me.ScoreGroupBox.PerformLayout()
        Me.IntermediateMenuStrip.ResumeLayout(False)
        Me.IntermediateMenuStrip.PerformLayout()
        CType(Me.ImgBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IntermediateLevelcontextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImgBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UserNameLbl As System.Windows.Forms.Label
    Friend WithEvents UsernamePicBox As System.Windows.Forms.PictureBox
    Friend WithEvents ScoreGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ScoreTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ImgBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents IntermediateMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GoBackToWelcomeFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntermediateTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents IntermediateLevelToolTipText As System.Windows.Forms.ToolTip
    Friend WithEvents IntermediateLevelcontextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
