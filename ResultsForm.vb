Public Class ResultsForm

    Private Sub GoBackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToolStripMenuItem.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            BeginnersLevelForm.UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        BeginnersLevelForm.ExitButtonDialogResult = MessageBox.Show("Thank you for playing Marvellous Maths! Are you sure you want to leave?", "Congrats, you completed the game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If BeginnersLevelForm.ExitButtonDialogResult = DialogResult.Yes Then
            WelcomeForm.Close()
            BeginnersLevelForm.Close()
            IntermediateLevel.Close()
            AdvLevelForm.Close()
            Me.Close()
        End If
    End Sub

    Private Sub GoBackToWelcomeFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToWelcomeFormToolStripMenuItem.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            BeginnersLevelForm.UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        BeginnersLevelForm.ExitButtonDialogResult = MessageBox.Show("Thank you for playing Marvellous Maths! Are you sure you want to leave?", "Congrats, you completed the game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If BeginnersLevelForm.ExitButtonDialogResult = DialogResult.Yes Then
            WelcomeForm.Close()
            BeginnersLevelForm.Close()
            IntermediateLevel.Close()
            AdvLevelForm.Close()
            Me.Close()
        End If
    End Sub

    Private Sub ResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserListBox.Items.Add(AdvLevelForm.UserName)
        ScoreListBox.Items.Add(Convert.ToString(BeginnersLevelForm.UserScore))
        UserListBox.SelectedIndex = 3
        ScoreListBox.SelectedIndex = 3
        AdvLevelForm.Timer1.Enabled = False
        AdvLevelForm.Timer2.Enabled = False
    End Sub

End Class