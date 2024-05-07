Public Class AdvLevelForm
    Dim Imgback As Image = My.Resources.GameLogo
    Dim ImgF1 As Image = My.Resources.a
    Dim ImgF2 As Image = My.Resources.b
    Dim ImgF3 As Image = My.Resources.c
    Dim ImgF4 As Image = My.Resources.d
    Dim ImgF5 As Image = My.Resources.e
    Dim ImgF6 As Image = My.Resources.f
    Dim ImgF7 As Image = My.Resources.g
    Dim ImgF8 As Image = My.Resources.h
    Dim ImgF9 As Image = My.Resources.i
    Dim ImgF10 As Image = My.Resources.j
    Dim ImgF11 As Image = My.Resources.k
    Dim ImgF12 As Image = My.Resources.l
    Dim ImgF13 As Image = My.Resources.m
    Dim ImgF14 As Image = My.Resources.n
    Dim ImgF15 As Image = My.Resources.o
    Dim ImgF16 As Image = My.Resources.p
    Dim ImgF17 As Image = My.Resources.q
    Dim ImgF18 As Image = My.Resources.r
    Dim ImgF19 As Image = My.Resources.s
    Dim ImgF20 As Image = My.Resources.t
    Friend ExitButtonDialogResult As DialogResult
    Friend UserName As String

    Private Sub CloseForm5()
        WelcomeForm.Close()
        Me.Close()
    End Sub

    Friend Sub UserNamePic()
        If WelcomeForm.Username = "Black Widow" Then
            UsernamePicBox.Image = My.Resources.Black_Widow
            UserName = "Black Widow"
        ElseIf WelcomeForm.Username = "Captain America" Then
            UsernamePicBox.Image = My.Resources.Captain_America
            UserName = "Captain America"
        ElseIf WelcomeForm.Username = "Hulk" Then
            UsernamePicBox.Image = My.Resources.Hulk
            UserName = "Hulk"
        ElseIf WelcomeForm.Username = "Iron Man" Then
            UsernamePicBox.Image = My.Resources.Iron_Man
            UserName = "Iron Man"
        ElseIf WelcomeForm.Username = "Thor" Then
            UsernamePicBox.Image = My.Resources.Thor
            UserName = "Thor"
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PBoxm.Click
        If PBoxm.Image Is ImgBack Then
            PBoxm.Image = ImgF13
        Else
            PBoxm.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxn_Click(sender As System.Object, e As System.EventArgs) Handles PBoxn.Click
        If PBoxn.Image Is ImgBack Then
            PBoxn.Image = ImgF14
        Else
            PBoxn.Image = ImgBack
        End If
    End Sub

    Private Sub AdvLevelForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IntermediateLevel.IntermediateTimer.Enabled = False
        IntermediateLevel.Timer1.Enabled = False
        UserNameLbl2.Text = WelcomeForm.Username
        Call UserNamePic()
        Scoretxtbox.Text = BeginnersLevelForm.UserScore
        Scoretxtbox.Enabled = False
        Timer1.Enabled = True
        PBoxa.Image = Imgback
        PBoxb.Image = Imgback
        PBoxc.Image = Imgback
        PBoxd.Image = Imgback
        PBoxe.Image = Imgback
        PBoxf.Image = Imgback
        PBoxg.Image = Imgback
        PBoxh.Image = Imgback
        PBoxi.Image = Imgback
        PBoxj.Image = Imgback
        PBoxk.Image = Imgback
        PBoxl.Image = Imgback
        PBoxm.Image = Imgback
        PBoxn.Image = Imgback
        PBoxo.Image = Imgback
        PBoxp.Image = Imgback
        PBoxq.Image = Imgback
        PBoxr.Image = Imgback
        PBoxs.Image = Imgback
        PBoxt.Image = Imgback


    End Sub

    Private Sub PBoxd_Click(sender As System.Object, e As System.EventArgs) Handles PBoxd.Click
        If PBoxd.Image Is ImgBack Then
            PBoxd.Image = ImgF4
        Else
            PBoxd.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxa_Click(sender As System.Object, e As System.EventArgs) Handles PBoxa.Click
        If PBoxa.Image Is ImgBack Then
            PBoxa.Image = ImgF1
        Else
            PBoxa.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxb_Click(sender As System.Object, e As System.EventArgs) Handles PBoxb.Click
        If PBoxb.Image Is ImgBack Then
            PBoxb.Image = ImgF2
        Else
            PBoxb.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxc_Click(sender As System.Object, e As System.EventArgs) Handles PBoxc.Click
        If PBoxc.Image Is ImgBack Then
            PBoxc.Image = ImgF3
        Else
            PBoxc.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxe_Click(sender As System.Object, e As System.EventArgs) Handles PBoxe.Click
        If PBoxe.Image Is ImgBack Then
            PBoxe.Image = ImgF5
        Else
            PBoxe.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxf_Click(sender As System.Object, e As System.EventArgs) Handles PBoxf.Click
        If PBoxf.Image Is ImgBack Then
            PBoxf.Image = ImgF6
        Else
            PBoxf.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxg_Click(sender As System.Object, e As System.EventArgs) Handles PBoxg.Click
        If PBoxg.Image Is ImgBack Then
            PBoxg.Image = ImgF7
        Else
            PBoxg.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxh_Click(sender As System.Object, e As System.EventArgs) Handles PBoxh.Click
        If PBoxh.Image Is ImgBack Then
            PBoxh.Image = ImgF8
        Else
            PBoxh.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxi_Click(sender As System.Object, e As System.EventArgs) Handles PBoxi.Click
        If PBoxi.Image Is ImgBack Then
            PBoxi.Image = ImgF9
        Else
            PBoxi.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxj_Click(sender As System.Object, e As System.EventArgs) Handles PBoxj.Click
        If PBoxj.Image Is ImgBack Then
            PBoxj.Image = ImgF10
        Else
            PBoxj.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxk_Click(sender As System.Object, e As System.EventArgs) Handles PBoxk.Click
        If PBoxk.Image Is ImgBack Then
            PBoxk.Image = ImgF11
        Else
            PBoxk.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxl_Click(sender As System.Object, e As System.EventArgs) Handles PBoxl.Click
        If PBoxl.Image Is ImgBack Then
            PBoxl.Image = ImgF12
        Else
            PBoxl.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxo_Click(sender As System.Object, e As System.EventArgs) Handles PBoxo.Click
        If PBoxo.Image Is ImgBack Then
            PBoxo.Image = ImgF15
        Else
            PBoxo.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxp_Click(sender As System.Object, e As System.EventArgs) Handles PBoxp.Click
        If PBoxp.Image Is ImgBack Then
            PBoxp.Image = ImgF16
        Else
            PBoxp.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxq_Click(sender As System.Object, e As System.EventArgs) Handles PBoxq.Click
        If PBoxq.Image Is ImgBack Then
            PBoxq.Image = ImgF17
        Else
            PBoxq.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxr_Click(sender As System.Object, e As System.EventArgs) Handles PBoxr.Click
        If PBoxr.Image Is ImgBack Then
            PBoxr.Image = ImgF18
        Else
            PBoxr.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxs_Click(sender As System.Object, e As System.EventArgs) Handles PBoxs.Click
        If PBoxs.Image Is ImgBack Then
            PBoxs.Image = ImgF19
        Else
            PBoxs.Image = ImgBack
        End If
    End Sub

    Private Sub PBoxt_Click(sender As System.Object, e As System.EventArgs) Handles PBoxt.Click
        If PBoxt.Image Is ImgBack Then
            PBoxt.Image = ImgF20
        Else
            PBoxt.Image = ImgBack
        End If
    End Sub

    Private Sub ExitBtn1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (PBoxa.Image Is ImgF1 And PBoxa.Visible = True) And (PBoxl.Image Is ImgF12 And PBoxl.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxa.Enabled = False
            PBoxl.Enabled = False
            PBoxa.Visible = False
            PBoxl.Visible = False
        End If
        If (PBoxb.Image Is ImgF2 And PBoxb.Visible = True) And (PBoxh.Image Is ImgF8 And PBoxh.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxb.Enabled = False
            PBoxh.Enabled = False
            PBoxb.Visible = False
            PBoxh.Visible = False
         End If
        If (PBoxc.Image Is ImgF3 And PBoxc.Visible = True) And (PBoxg.Image Is ImgF7 And PBoxg.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxc.Enabled = False
            PBoxg.Enabled = False
            PBoxc.Visible = False
            PBoxg.Visible = False
        End If
        If (PBoxd.Image Is ImgF4 And PBoxd.Visible = True) And (PBoxe.Image Is ImgF5 And PBoxe.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxd.Enabled = False
            PBoxe.Enabled = False
            PBoxd.Visible = False
            PBoxe.Visible = False
        End If
        If (PBoxf.Image Is ImgF6 And PBoxf.Visible = True) And (PBoxo.Image Is ImgF15 And PBoxo.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxf.Enabled = False
            PBoxo.Enabled = False
            PBoxf.Visible = False
            PBoxo.Visible = False
       End If
        If (PBoxi.Image Is ImgF9 And PBoxi.Visible = True) And (PBoxr.Image Is ImgF18 And PBoxr.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxi.Enabled = False
            PBoxr.Enabled = False
            PBoxi.Visible = False
            PBoxr.Visible = False
      End If
        If (PBoxj.Image Is ImgF10 And PBoxj.Visible = True) And (PBoxn.Image Is ImgF14 And PBoxn.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxj.Enabled = False
            PBoxn.Enabled = False
            PBoxj.Visible = False
            PBoxn.Visible = False
         End If
        If (PBoxm.Image Is ImgF13 And PBoxm.Visible = True) And (PBoxt.Image Is ImgF20 And PBoxt.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxm.Enabled = False
            PBoxt.Enabled = False
            PBoxm.Visible = False
            PBoxt.Visible = False
          End If
        If (PBoxk.Image Is ImgF11 And PBoxk.Visible = True) And (PBoxs.Image Is ImgF19 And PBoxs.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxk.Enabled = False
            PBoxs.Enabled = False
            PBoxk.Visible = False
            PBoxs.Visible = False
         End If
        If (PBoxq.Image Is ImgF17 And PBoxq.Visible = True) And (PBoxp.Image Is ImgF16 And PBoxp.Visible = True) Then
            BeginnersLevelForm.UserScore += 10
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
            PBoxp.Enabled = False
            PBoxq.Enabled = False
            PBoxp.Visible = False
            PBoxq.Visible = False
        End If
        If PBoxa.Visible = False And PBoxb.Visible = False And PBoxc.Visible = False And PBoxd.Visible = False And PBoxe.Visible = False And PBoxf.Visible = False And PBoxg.Visible = False And PBoxh.Visible = False And PBoxi.Visible = False And PBoxj.Visible = False And PBoxk.Visible = False And PBoxm.Visible = False And PBoxn.Visible = False And PBoxo.Visible = False And PBoxp.Visible = False And PBoxq.Visible = False And PBoxr.Visible = False And PBoxs.Visible = False And PBoxt.Visible = False Then
            Me.Hide()
            ResultsForm.Show()
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm5()
        End If
    End Sub

    Private Sub GoToToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoToToolStripMenuItem.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            BeginnersLevelForm.UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub AboutBoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutBoxToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If (PBoxq.Image Is ImgF17 And PBoxq.Visible = True) And Not (PBoxp.Image Is ImgF16 And PBoxp.Visible = True) Then
            PBoxq.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If
        If (PBoxp.Image Is ImgF16 And PBoxp.Visible = True) And Not (PBoxq.Image Is ImgF17 And PBoxq.Visible = True) Then
            PBoxp.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxk.Image Is ImgF11 And PBoxk.Visible = True) And Not (PBoxs.Image Is ImgF19 And PBoxs.Visible = True) Then
            PBoxk.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxs.Image Is ImgF19 And PBoxs.Visible = True) And Not (PBoxk.Image Is ImgF11 And PBoxk.Visible = True) Then
            PBoxs.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxm.Image Is ImgF13 And PBoxm.Visible = True) And Not (PBoxt.Image Is ImgF20 And PBoxt.Visible = True) Then
            PBoxm.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxt.Image Is ImgF20 And PBoxt.Visible = True) And Not (PBoxm.Image Is ImgF13 And PBoxm.Visible = True) Then
            PBoxt.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxj.Image Is ImgF10 And PBoxj.Visible = True) And Not (PBoxn.Image Is ImgF14 And PBoxn.Visible = True) Then
            PBoxj.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxn.Image Is ImgF14 And PBoxn.Visible = True) And Not (PBoxj.Image Is ImgF10 And PBoxj.Visible = True) Then
            PBoxn.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxi.Image Is ImgF9 And PBoxi.Visible = True) And Not (PBoxr.Image Is ImgF18 And PBoxr.Visible = True) Then
            PBoxi.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxr.Image Is ImgF18 And PBoxr.Visible = True) And Not (PBoxi.Image Is ImgF9 And PBoxi.Visible = True) Then
            PBoxr.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxf.Image Is ImgF6 And PBoxf.Visible = True) And Not (PBoxo.Image Is ImgF15 And PBoxo.Visible = True) Then
            PBoxf.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxo.Image Is ImgF15 And PBoxo.Visible = True) And Not (PBoxf.Image Is ImgF6 And PBoxf.Visible = True) Then
            PBoxo.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxd.Image Is ImgF4 And PBoxd.Visible = True) And Not (PBoxe.Image Is ImgF5 And PBoxe.Visible = True) Then
            PBoxd.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxe.Image Is ImgF5 And PBoxe.Visible = True) And Not (PBoxd.Image Is ImgF4 And PBoxd.Visible = True) Then
            PBoxe.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxc.Image Is ImgF3 And PBoxc.Visible = True) And Not (PBoxg.Image Is ImgF7 And PBoxg.Visible = True) Then
            PBoxc.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxg.Image Is ImgF7 And PBoxg.Visible = True) And Not (PBoxc.Image Is ImgF3 And PBoxc.Visible = True) Then
            PBoxg.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxb.Image Is ImgF2 And PBoxb.Visible = True) And Not (PBoxh.Image Is ImgF8 And PBoxh.Visible = True) Then
            PBoxb.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxh.Image Is ImgF8 And PBoxh.Visible = True) And Not (PBoxb.Image Is ImgF2 And PBoxb.Visible = True) Then
            PBoxh.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxa.Image Is ImgF1 And PBoxa.Visible = True) And Not (PBoxl.Image Is ImgF12 And PBoxl.Visible = True) Then
            PBoxa.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

        If (PBoxl.Image Is ImgF12 And PBoxl.Visible = True) And Not (PBoxa.Image Is ImgF1 And PBoxa.Visible = True) Then
            PBoxl.Image = Imgback
            BeginnersLevelForm.UserScore -= 5
            Scoretxtbox.Text = Convert.ToString(BeginnersLevelForm.UserScore)
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm5()
        End If
    End Sub
End Class