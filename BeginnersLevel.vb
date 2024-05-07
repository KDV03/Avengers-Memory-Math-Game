Public Class BeginnersLevelForm
    'UserScore will be used throughout the form to store and increment the user's score
    Friend UserScore As Integer = 0
    'The standard back image is the game logo
    Dim ImgBack As Image = My.Resources.GameLogo
    'Each picture box is matched with another picture box.These picture boxes have corresponding images. E.g. Image 1 is matched with Image 2 and Image 3 is matched with Image 4 
    Dim ImgFrnt1 As Image = My.Resources._1
    Dim ImgFrnt2 As Image = My.Resources._2
    Dim ImgFrnt3 As Image = My.Resources._3
    Dim ImgFrnt4 As Image = My.Resources._4
    Dim ImgFrnt5 As Image = My.Resources._5
    Dim ImgFrnt6 As Image = My.Resources._6
    'This dialogresult will be used throughout the project to store the result of a messagebox when the exit button is clicked
    Friend ExitButtonDialogResult As DialogResult
    'This sub procedure was created to close form 2 and remaining open forms. It prevents repitition when coding for exit butttons
    Private Sub CloseForm2()
        WelcomeForm.Close()
        Me.Close()
    End Sub
    'This sub procedure is used in every other form to set the username image according to the username chosen from the list box
    'Friend Sub UserNamePic()
    '    If WelcomeForm.Username = "Black Widow" Then
    '        UsernamePicBox.Image = My.Resources.Black_Widow
    '    ElseIf WelcomeForm.Username = "Captain America" Then
    '        UsernamePicBox.Image = My.Resources.Captain_America
    '    ElseIf WelcomeForm.Username = "Hulk" Then
    '        UsernamePicBox.Image = My.Resources.Hulk
    '    ElseIf WelcomeForm.Username = "Iron Man" Then
    '        UsernamePicBox.Image = My.Resources.Iron_Man
    '    ElseIf WelcomeForm.Username = "Thor" Then
    '        UsernamePicBox.Image = My.Resources.Thor
    '    End If
    'End Sub

    Friend Sub UserNamePic()
        Select Case WelcomeForm.Username
            Case "Black Widow"
                UsernamePicBox.Image = My.Resources.Black_Widow
            Case "Captain America"
                UsernamePicBox.Image = My.Resources.Captain_America
            Case "Hulk"
                UsernamePicBox.Image = My.Resources.Hulk
            Case "Iron Man"
                UsernamePicBox.Image = My.Resources.Iron_Man
            Case "Thor"
                UsernamePicBox.Image = My.Resources.Thor
        End Select
    End Sub


    Private Sub BeginnersLevelForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserNameLbl.Text = WelcomeForm.Username
        ScoreTxtBox.Enabled = False
        'The sub procedure is being called to carry out its function
        Call UserNamePic()
        'The timer must be enabled when the form loads   
        BeginnerTimer.Enabled = True
        'This code sets all images to the standard back which is the game logo
        ImgBox1.Image = ImgBack
        ImgBox2.Image = ImgBack
        ImgBox3.Image = ImgBack
        ImgBox4.Image = ImgBack
        Imgbox5.Image = ImgBack
        ImgBox6.Image = ImgBack
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm2()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub GoBackToWelcomeFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToWelcomeFormToolStripMenuItem.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub ImgBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBox1.Click
        'This code allows the picturebox to respond when a user clicks on it
        If ImgBox1.Image Is ImgBack Then
            ImgBox1.Image = ImgFrnt1
        Else
            ImgBox1.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBox3.Click
        If ImgBox3.Image Is ImgBack Then
            ImgBox3.Image = ImgFrnt3
        Else
            ImgBox3.Image = ImgBack
        End If
    End Sub

    Private Sub Imgbox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imgbox5.Click
        If Imgbox5.Image Is ImgBack Then
            Imgbox5.Image = ImgFrnt5
        Else
            Imgbox5.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBox4.Click
        If ImgBox4.Image Is ImgBack Then
            ImgBox4.Image = ImgFrnt4
        Else
            ImgBox4.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBox2.Click
        If ImgBox2.Image Is ImgBack Then
            ImgBox2.Image = ImgFrnt2
        Else
            ImgBox2.Image = ImgBack
        End If
    End Sub

    Private Sub ImgBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImgBox6.Click
        If ImgBox6.Image Is ImgBack Then
            ImgBox6.Image = ImgFrnt6
        Else
            ImgBox6.Image = ImgBack
        End If
    End Sub
    'The code below increments the score when the collect memory blocks are active together. If the blocks do not match, then the program turns them both back

    Private Sub BeginnerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginnerTimer.Tick
        Dim imgBoxes() As PictureBox = {ImgBox1, ImgBox2, ImgBox3, ImgBox4, Imgbox5, ImgBox6}
        Dim matchedPairs() As Image = {ImgFrnt1, ImgFrnt2, ImgFrnt3, ImgFrnt4, ImgFrnt5, ImgFrnt6}

        For i As Integer = 0 To imgBoxes.Length - 2 Step 2
            If imgBoxes(i).Image Is matchedPairs(i) AndAlso imgBoxes(i + 1).Image Is matchedPairs(i + 1) AndAlso imgBoxes(i).Visible AndAlso imgBoxes(i + 1).Visible Then
                UserScore += 10
                ScoreTxtBox.Text = Convert.ToString(UserScore)
                imgBoxes(i).Enabled = False
                imgBoxes(i).Visible = False
                imgBoxes(i + 1).Enabled = False
                imgBoxes(i + 1).Visible = False
            End If
        Next

        If imgBoxes.All(Function(pb) Not pb.Visible) Then
            Me.Hide()
            IntermediateLevel.Show()
        End If
    End Sub

    'Private Sub BeginnerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginnerTimer.Tick
    '    If (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) And (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) Then
    '        UserScore += 10
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '        ImgBox1.Enabled = False
    '        ImgBox1.Visible = False
    '        ImgBox2.Enabled = False
    '        ImgBox2.Visible = False

    '    End If

    '    If (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) And (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) Then
    '        UserScore += 10
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '        ImgBox3.Enabled = False
    '        ImgBox3.Visible = False
    '        ImgBox4.Enabled = False
    '        ImgBox4.Visible = False

    '    End If

    '    If (Imgbox5.Image Is ImgFrnt5 And Imgbox5.Visible = True) And (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) Then
    '        UserScore += 10
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '        Imgbox5.Enabled = False
    '        Imgbox5.Visible = False
    '        ImgBox6.Enabled = False
    '        ImgBox6.Visible = False
    '    End If


    '    If ImgBox1.Visible = False And ImgBox2.Visible = False And ImgBox3.Visible = False And ImgBox4.Visible = False And Imgbox5.Visible = False And ImgBox6.Visible = False Then
    '        Me.Hide()
    '        IntermediateLevel.Show()
    '    End If



    'End Sub

    Private Sub GoBackToWelcomeFormToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoBackToWelcomeFormToolStripMenuItem1.Click
        Dim d As DialogResult
        d = MessageBox.Show("If you return to the welcome screen, your score will be lost. Are you sure you want to leave?", "Return to Welcome Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If d = Windows.Forms.DialogResult.Yes Then
            UserScore = 0
            Me.Hide()
            WelcomeForm.Show()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Call WelcomeForm.ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitButtonDialogResult = MessageBox.Show("If you exit the game, your score will be lost. Are you sure you want to leave?", "Leave the game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ExitButtonDialogResult = DialogResult.Yes Then
            Call CloseForm2()
        End If
    End Sub



    'Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    '    If Imgbox5.Image Is ImgFrnt5 AndAlso Imgbox5.Visible AndAlso Not (ImgBox6.Image Is ImgFrnt6 AndAlso ImgBox6.Visible) Then
    '        Imgbox5.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    ElseIf ImgBox6.Image Is ImgFrnt6 AndAlso ImgBox6.Visible AndAlso Not (Imgbox5.Image Is ImgFrnt5 AndAlso Imgbox5.Visible) Then
    '        ImgBox6.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    ElseIf ImgBox3.Image Is ImgFrnt3 AndAlso ImgBox3.Visible AndAlso Not (ImgBox4.Image Is ImgFrnt4 AndAlso ImgBox4.Visible) Then
    '        ImgBox3.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    ElseIf ImgBox4.Image Is ImgFrnt4 AndAlso ImgBox4.Visible AndAlso Not (ImgBox3.Image Is ImgFrnt3 AndAlso ImgBox3.Visible) Then
    '        ImgBox4.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    ElseIf ImgBox1.Image Is ImgFrnt1 AndAlso ImgBox1.Visible AndAlso Not (ImgBox2.Image Is ImgFrnt2 AndAlso ImgBox2.Visible) Then
    '        ImgBox1.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    ElseIf ImgBox2.Image Is ImgFrnt2 AndAlso ImgBox2.Visible AndAlso Not (ImgBox1.Image Is ImgFrnt1 AndAlso ImgBox1.Visible) Then
    '        ImgBox2.Image = ImgBack
    '        UserScore -= 5
    '        ScoreTxtBox.Text = Convert.ToString(UserScore)
    '    End If
    'End Sub

    'Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
    '    Dim imgBoxes() As PictureBox = {Imgbox5, ImgBox6, ImgBox3, ImgBox4, ImgBox1, ImgBox2}
    '    Dim matchedPairs() As Image = {ImgFrnt5, ImgFrnt6, ImgFrnt3, ImgFrnt4, ImgFrnt1, ImgFrnt2}

    '    For i As Integer = 0 To imgBoxes.Length - 1
    '        If imgBoxes(i).Visible Then
    '            If imgBoxes(i).Image Is matchedPairs(i) Then
    '                imgBoxes(i).Enabled = False
    '                imgBoxes(i).Visible = False
    '            Else
    '                imgBoxes(i).Image = ImgBack
    '                UserScore -= 5
    '                ScoreTxtBox.Text = Convert.ToString(UserScore)
    '            End If
    '        End If
    '    Next
    'End Sub


    Private Sub timer1_tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If (Imgbox5.Image Is ImgFrnt5 And Imgbox5.Visible = True) And Not (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) Then
            Imgbox5.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If

        If (ImgBox6.Image Is ImgFrnt6 And ImgBox6.Visible = True) And Not (Imgbox5.Image Is ImgFrnt5 And Imgbox5.Visible = True) Then
            ImgBox6.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If
        If (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) And Not (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) Then
            ImgBox3.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If
        If (ImgBox4.Image Is ImgFrnt4 And ImgBox4.Visible = True) And Not (ImgBox3.Image Is ImgFrnt3 And ImgBox3.Visible = True) Then
            ImgBox4.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If

        If (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) And Not (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) Then
            ImgBox1.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If
        If (ImgBox2.Image Is ImgFrnt2 And ImgBox2.Visible = True) And Not (ImgBox1.Image Is ImgFrnt1 And ImgBox1.Visible = True) Then
            ImgBox2.Image = ImgBack
            UserScore -= 5
            ScoreTxtBox.Text = Convert.ToString(UserScore)
        End If
    End Sub
End Class