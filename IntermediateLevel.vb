Public Class IntermediateLevel
    Dim ImgBack As Image = My.Resources.GameLogo
    Dim ImgFrnt1 As Image = My.Resources.A1
    Dim ImgFrnt2 As Image = My.Resources.E1
    Dim ImgFrnt3 As Image = My.Resources.A2
    Dim ImgFrnt4 As Image = My.Resources.E2
    Dim ImgFrnt5 As Image = My.Resources.A3
    Dim ImgFrnt6 As Image = My.Resources.E3
    Dim ImgFrnt7 As Image = My.Resources.A4
    Dim ImgFrnt8 As Image = My.Resources.E4
    Dim ImgFrnt9 As Image = My.Resources.A5
    Dim Imgfrnt10 As Image = My.Resources.E5
    Dim ImgFrnt11 As Image = My.Resources.A6
    Dim ImgFrnt12 As Image = My.Resources.E6

    Dim ExitButtonDialogResult As DialogResult
    Friend Sub UserNamePic()
        If WelcomeForm.Username = "Black Widow" Then
            UsernamePicBox.Image = My.Resources.Black_Widow
        ElseIf WelcomeForm.Username = "Captain America" Then
            UsernamePicBox.Image = My.Resources.Captain_America
        ElseIf WelcomeForm.Username = "Hulk" Then
            UsernamePicBox.Image = My.Resources.Hulk
        ElseIf WelcomeForm.Username = "Iron Man" Then
            UsernamePicBox.Image = My.Resources.Iron_Man
        ElseIf WelcomeForm.Username = "Thor" Then
            UsernamePicBox.Image = My.Resources.Thor
        End If
    End Sub
    Private Sub CloseForm3()
        WelcomeForm.Close()
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BeginnersLevelForm.BeginnerTimer.Enabled = False
        BeginnersLevelForm.Timer1.Enabled = False
        ScoreTxtBox.Enabled = False
        Call UserNamePic()
        UserNameLbl.Text = WelcomeForm.Username

        IntermediateTimer.Enabled = True

        ImgBox11.Image = ImgBack
        ImgBox10.Image = ImgBack
        ImgBox1.Image = ImgBack
        ImgBox6.Image = ImgBack
        ImgBox9.Image = ImgBack
        ImgBox7.Image = ImgBack
        ImgBox2.Image = ImgBack
        ImgBox3.Image = ImgBack
        ImgBox8.Image = ImgBack
        ImgBox4.Image = ImgBack
        ImgBox5.Image = ImgBack
        ImgBox12.Image = ImgBack
        ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm3()
        End If
    End Sub

    Private Sub ImgBox1_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox11.Click
        If ImgBox11.Image Is ImgBack Then
            ImgBox11.Image = ImgFrnt11
        Else
            ImgBox11.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox2_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox10.Click
        If ImgBox10.Image Is ImgBack Then
            ImgBox10.Image = Imgfrnt10
        Else
            ImgBox10.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox3_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox1.Click
        If ImgBox1.Image Is ImgBack Then
            ImgBox1.Image = ImgFrnt1
        Else
            ImgBox1.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox4_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox6.Click
        If ImgBox6.Image Is ImgBack Then
            ImgBox6.Image = ImgFrnt6
        Else
            ImgBox6.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox5_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox9.Click
        If ImgBox9.Image Is ImgBack Then
            ImgBox9.Image = ImgFrnt9
        Else
            ImgBox9.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox6_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox7.Click
        If ImgBox7.Image Is ImgBack Then
            ImgBox7.Image = ImgFrnt7
        Else
            ImgBox7.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox7_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox2.Click
        If ImgBox2.Image Is ImgBack Then
            ImgBox2.Image = ImgFrnt2
        Else
            ImgBox2.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox8_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox3.Click
        If ImgBox3.Image Is ImgBack Then
            ImgBox3.Image = ImgFrnt3
        Else
            ImgBox3.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox9_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox8.Click
        If ImgBox8.Image Is ImgBack Then
            ImgBox8.Image = ImgFrnt8
        Else
            ImgBox8.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox10_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox4.Click
        If ImgBox4.Image Is ImgBack Then
            ImgBox4.Image = ImgFrnt4
        Else
            ImgBox4.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox11_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox5.Click
        If ImgBox5.Image Is ImgBack Then
            ImgBox5.Image = ImgFrnt5
        Else
            ImgBox5.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox12_Click(sender As System.Object, e As System.EventArgs) Handles ImgBox12.Click
        If ImgBox12.Image Is ImgBack Then
            ImgBox12.Image = ImgFrnt12
        Else
            ImgBox12.Image = ImgBack
        End If
    End Sub

    Private Sub IntermediateTimer_Tick(sender As System.Object, e As System.EventArgs) Handles IntermediateTimer.Tick
        If (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) And (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox1.Enabled = False
            ImgBox1.Visible = False
            ImgBox2.Enabled = False
            ImgBox2.Visible = False
         End If

        If (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) And (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox3.Enabled = False
            ImgBox3.Visible = False
            ImgBox4.Enabled = False
            ImgBox4.Visible = False
          End If

        If (ImgBox5.Image Is ImgFrnt5 And ImgBox5.Visible = True) And (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox5.Enabled = False
            ImgBox5.Visible = False
            ImgBox6.Enabled = False
            ImgBox6.Visible = False
        End If

        If (ImgBox7.Image Is ImgFrnt7 And ImgBox7.Visible = True) And (ImgBox8.Image Is ImgFrnt8 And ImgBox8.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox7.Enabled = False
            ImgBox7.Visible = False
            ImgBox8.Enabled = False
            ImgBox8.Visible = False
        End If

        If (ImgBox9.Image Is ImgFrnt9 And ImgBox9.Visible = True) And (ImgBox10.Image Is Imgfrnt10 And ImgBox10.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox9.Enabled = False
            ImgBox9.Visible = False
            ImgBox10.Enabled = False
            ImgBox10.Visible = False
         End If

        If (ImgBox11.Image Is ImgFrnt11 And ImgBox11.Visible = True) And (ImgBox12.Image Is ImgFrnt12 And ImgBox12.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            ImgBox11.Enabled = False
            ImgBox11.Visible = False
            ImgBox12.Enabled = False
            ImgBox12.Visible = False
       End If

        If ImgBox1.Visible = False And ImgBox2.Visible = False And ImgBox3.Visible = False And ImgBox4.Visible = False And ImgBox5.Visible = False And ImgBox6.Visible = False And ImgBox7.Visible = False And ImgBox8.Visible = False And ImgBox9.Visible = False And ImgBox10.Visible = False And ImgBox11.Visible = False And ImgBox12.Visible = False Then
            Me.Hide()
            AdvLevelForm.Show()
        End If


    End Sub

    Private Sub AboutBoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutBoxToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub GoBackToWelcomeFormToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoBackToWelcomeFormToolStripMenuItem.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            BeginnersLevelForm.UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) And Not (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) Then
            ImgBox1.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) And Not (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) Then
            ImgBox2.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) And Not (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) Then
            ImgBox3.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) And Not (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) Then
            ImgBox4.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (ImgBox5.Image Is ImgFrnt5 And ImgBox5.Visible = True) And Not (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) Then
            ImgBox5.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) And Not (ImgBox5.Image Is ImgFrnt5 And ImgBox5.Visible = True) Then
            ImgBox6.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox7.Image Is ImgFrnt7 And ImgBox7.Visible = True) And Not (ImgBox8.Image Is ImgFrnt8 And ImgBox8.Visible = True) Then
            ImgBox7.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox8.Image Is ImgFrnt8 And ImgBox8.Visible = True) And Not (ImgBox7.Image Is ImgFrnt7 And ImgBox7.Visible = True) Then
            ImgBox8.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox9.Image Is ImgFrnt9 And ImgBox9.Visible = True) And Not (ImgBox10.Image Is Imgfrnt10 And ImgBox10.Visible = True) Then
            ImgBox9.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox10.Image Is Imgfrnt10 And ImgBox10.Visible = True) And Not (ImgBox9.Image Is ImgFrnt9 And ImgBox9.Visible = True) Then
            ImgBox10.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox11.Image Is ImgFrnt11 And ImgBox11.Visible = True) And Not (ImgBox12.Image Is ImgFrnt12 And ImgBox12.Visible = True) Then
            ImgBox11.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (ImgBox12.Image Is ImgFrnt12 And ImgBox12.Visible = True) And Not (ImgBox11.Image Is ImgFrnt11 And ImgBox11.Visible = True) Then
            ImgBox12.Image = ImgBack
            BeginnersLevelForm.UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm3()
        End If
    End Sub
End Class

