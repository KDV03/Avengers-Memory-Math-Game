<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeginnersLevelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeginnersLevelForm))
        Me.UserNameLbl = New System.Windows.Forms.Label()
        Me.UserGrpBox = New System.Windows.Forms.GroupBox()
        Me.UsernamePicBox = New System.Windows.Forms.PictureBox()
        Me.ScoreGrpBox = New System.Windows.Forms.GroupBox()
        Me.ScoreTxtBox = New System.Windows.Forms.TextBox()
        Me.BeginnersFormMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GoBackToWelcomeFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeginnerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTiponBeginnerLevel = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImgBox3 = New System.Windows.Forms.PictureBox()
        Me.Imgbox5 = New System.Windows.Forms.PictureBox()
        Me.ImgBox4 = New System.Windows.Forms.PictureBox()
        Me.ImgBox2 = New System.Windows.Forms.PictureBox()
        Me.ImgBox6 = New System.Windows.Forms.PictureBox()
        Me.ImgBox1 = New System.Windows.Forms.PictureBox()
        Me.BeginnerFormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GoBackToWelcomeFormToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UserGrpBox.SuspendLayout()
        CType(Me.UsernamePicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScoreGrpBox.SuspendLayout()
        Me.BeginnersFormMenuStrip.SuspendLayout()
        CType(Me.ImgBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imgbox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BeginnerFormContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserNameLbl
        '
        Me.UserNameLbl.AutoSize = True
        Me.UserNameLbl.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLbl.Location = New System.Drawing.Point(17, 208)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(31, 22)
        Me.UserNameLbl.TabIndex = 0
        Me.UserNameLbl.Text = "..."
        '
        'UserGrpBox
        '
        Me.UserGrpBox.Controls.Add(Me.UserNameLbl)
        Me.UserGrpBox.Controls.Add(Me.UsernamePicBox)
        Me.UserGrpBox.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserGrpBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UserGrpBox.Location = New System.Drawing.Point(21, 49)
        Me.UserGrpBox.Name = "UserGrpBox"
        Me.UserGrpBox.Size = New System.Drawing.Size(203, 277)
        Me.UserGrpBox.TabIndex = 2
        Me.UserGrpBox.TabStop = False
        Me.UserGrpBox.Text = "Username Details"
        '
        'UsernamePicBox
        '
        Me.UsernamePicBox.Location = New System.Drawing.Point(42, 56)
        Me.UsernamePicBox.Name = "UsernamePicBox"
        Me.UsernamePicBox.Size = New System.Drawing.Size(102, 103)
        Me.UsernamePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernamePicBox.TabIndex = 1
        Me.UsernamePicBox.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.UsernamePicBox, "Your current Username")
        '
        'ScoreGrpBox
        '
        Me.ScoreGrpBox.Controls.Add(Me.ScoreTxtBox)
        Me.ScoreGrpBox.Font = New System.Drawing.Font("Ravie", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreGrpBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ScoreGrpBox.Location = New System.Drawing.Point(21, 332)
        Me.ScoreGrpBox.Name = "ScoreGrpBox"
        Me.ScoreGrpBox.Size = New System.Drawing.Size(200, 196)
        Me.ScoreGrpBox.TabIndex = 3
        Me.ScoreGrpBox.TabStop = False
        Me.ScoreGrpBox.Text = "Score Box"
        '
        'ScoreTxtBox
        '
        Me.ScoreTxtBox.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTxtBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ScoreTxtBox.Location = New System.Drawing.Point(44, 85)
        Me.ScoreTxtBox.Name = "ScoreTxtBox"
        Me.ScoreTxtBox.ReadOnly = True
        Me.ScoreTxtBox.Size = New System.Drawing.Size(100, 51)
        Me.ScoreTxtBox.TabIndex = 11
        Me.ScoreTxtBox.Text = "0"
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ScoreTxtBox, "Your current score")
        '
        'BeginnersFormMenuStrip
        '
        Me.BeginnersFormMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BeginnersFormMenuStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginnersFormMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToWelcomeFormToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.BeginnersFormMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.BeginnersFormMenuStrip.Name = "BeginnersFormMenuStrip"
        Me.BeginnersFormMenuStrip.Size = New System.Drawing.Size(1029, 25)
        Me.BeginnersFormMenuStrip.TabIndex = 10
        Me.BeginnersFormMenuStrip.Text = "MenuStrip1"
        '
        'GoBackToWelcomeFormToolStripMenuItem
        '
        Me.GoBackToWelcomeFormToolStripMenuItem.Name = "GoBackToWelcomeFormToolStripMenuItem"
        Me.GoBackToWelcomeFormToolStripMenuItem.Size = New System.Drawing.Size(193, 21)
        Me.GoBackToWelcomeFormToolStripMenuItem.Text = "Go Back To Welcome Form"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BeginnerTimer
        '
        Me.BeginnerTimer.Enabled = True
        Me.BeginnerTimer.Interval = 5000
        '
        'ImgBox3
        '
        Me.ImgBox3.Image = CType(resources.GetObject("ImgBox3.Image"), System.Drawing.Image)
        Me.ImgBox3.Location = New System.Drawing.Point(527, 74)
        Me.ImgBox3.Name = "ImgBox3"
        Me.ImgBox3.Size = New System.Drawing.Size(190, 124)
        Me.ImgBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox3.TabIndex = 9
        Me.ImgBox3.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ImgBox3, "Click here to reveal the image below")
        '
        'Imgbox5
        '
        Me.Imgbox5.Image = CType(resources.GetObject("Imgbox5.Image"), System.Drawing.Image)
        Me.Imgbox5.Location = New System.Drawing.Point(763, 74)
        Me.Imgbox5.Name = "Imgbox5"
        Me.Imgbox5.Size = New System.Drawing.Size(190, 124)
        Me.Imgbox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Imgbox5.TabIndex = 8
        Me.Imgbox5.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.Imgbox5, "Click here to reveal the image below")
        '
        'ImgBox4
        '
        Me.ImgBox4.Image = CType(resources.GetObject("ImgBox4.Image"), System.Drawing.Image)
        Me.ImgBox4.Location = New System.Drawing.Point(296, 317)
        Me.ImgBox4.Name = "ImgBox4"
        Me.ImgBox4.Size = New System.Drawing.Size(190, 124)
        Me.ImgBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox4.TabIndex = 7
        Me.ImgBox4.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ImgBox4, "Click here to reveal the image below")
        '
        'ImgBox2
        '
        Me.ImgBox2.Image = CType(resources.GetObject("ImgBox2.Image"), System.Drawing.Image)
        Me.ImgBox2.Location = New System.Drawing.Point(527, 317)
        Me.ImgBox2.Name = "ImgBox2"
        Me.ImgBox2.Size = New System.Drawing.Size(190, 124)
        Me.ImgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox2.TabIndex = 6
        Me.ImgBox2.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ImgBox2, "Click here to reveal the image below")
        '
        'ImgBox6
        '
        Me.ImgBox6.Image = CType(resources.GetObject("ImgBox6.Image"), System.Drawing.Image)
        Me.ImgBox6.Location = New System.Drawing.Point(763, 317)
        Me.ImgBox6.Name = "ImgBox6"
        Me.ImgBox6.Size = New System.Drawing.Size(190, 124)
        Me.ImgBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox6.TabIndex = 5
        Me.ImgBox6.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ImgBox6, "Click here to reveal the image below")
        '
        'ImgBox1
        '
        Me.ImgBox1.Image = CType(resources.GetObject("ImgBox1.Image"), System.Drawing.Image)
        Me.ImgBox1.Location = New System.Drawing.Point(296, 74)
        Me.ImgBox1.Name = "ImgBox1"
        Me.ImgBox1.Size = New System.Drawing.Size(190, 124)
        Me.ImgBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox1.TabIndex = 4
        Me.ImgBox1.TabStop = False
        Me.ToolTiponBeginnerLevel.SetToolTip(Me.ImgBox1, "Click here to reveal the image below")
        '
        'BeginnerFormContextMenuStrip
        '
        Me.BeginnerFormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToWelcomeFormToolStripMenuItem1, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.BeginnerFormContextMenuStrip.Name = "BeginnerFormContextMenuStrip"
        Me.BeginnerFormContextMenuStrip.Size = New System.Drawing.Size(256, 76)
        '
        'GoBackToWelcomeFormToolStripMenuItem1
        '
        Me.GoBackToWelcomeFormToolStripMenuItem1.Name = "GoBackToWelcomeFormToolStripMenuItem1"
        Me.GoBackToWelcomeFormToolStripMenuItem1.Size = New System.Drawing.Size(255, 24)
        Me.GoBackToWelcomeFormToolStripMenuItem1.Text = "Go back to Welcome Form"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(255, 24)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(255, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 7000
        '
        'BeginnersLevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1029, 540)
        Me.ContextMenuStrip = Me.BeginnerFormContextMenuStrip
        Me.Controls.Add(Me.ImgBox3)
        Me.Controls.Add(Me.Imgbox5)
        Me.Controls.Add(Me.ImgBox4)
        Me.Controls.Add(Me.ImgBox2)
        Me.Controls.Add(Me.ImgBox6)
        Me.Controls.Add(Me.ImgBox1)
        Me.Controls.Add(Me.ScoreGrpBox)
        Me.Controls.Add(Me.UserGrpBox)
        Me.Controls.Add(Me.BeginnersFormMenuStrip)
        Me.Font = New System.Drawing.Font("Ravie", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MainMenuStrip = Me.BeginnersFormMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BeginnersLevelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beginner's Level"
        Me.UserGrpBox.ResumeLayout(False)
        Me.UserGrpBox.PerformLayout()
        CType(Me.UsernamePicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScoreGrpBox.ResumeLayout(False)
        Me.ScoreGrpBox.PerformLayout()
        Me.BeginnersFormMenuStrip.ResumeLayout(False)
        Me.BeginnersFormMenuStrip.PerformLayout()
        CType(Me.ImgBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imgbox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BeginnerFormContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserNameLbl As System.Windows.Forms.Label
    Friend WithEvents UsernamePicBox As System.Windows.Forms.PictureBox
    Friend WithEvents UserGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents ScoreGrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents ScoreTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ImgBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Imgbox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ImgBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BeginnersFormMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeginnerTimer As System.Windows.Forms.Timer
    Friend WithEvents GoBackToWelcomeFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTiponBeginnerLevel As System.Windows.Forms.ToolTip
    Friend WithEvents BeginnerFormContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GoBackToWelcomeFormToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
