Public Class WelcomeForm
    'The variable used to store the username will be used in every other form to identify the user and display the username 
    Friend Username As String
    'This sub procedure was created to close form 1. It prevents repitition when coding for exit butttons
    Private Sub CloseForm1()
        Me.Close()
    End Sub
    'This sub procedure is declared as friend because it can be used throughout the project to access the about box in any form
    Friend Sub ViewAboutBox()
        AboutBoxGame.Show()
    End Sub
    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Call CloseForm1()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Call CloseForm1()
    End Sub

    Private Sub AboutBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBtn.Click
        Call ViewAboutBox()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call ViewAboutBox()
    End Sub
    'The program will not allow users to access the next form without selecting a username first. This is an example of data validation.
    '
    Private Sub BeginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginBtn.Click
        If UsernameListBox.SelectedItem = "" Then
            MessageBox.Show("Please select a valid username before continuing", "Select a username", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Username = Convert.ToString(UsernameListBox.SelectedItem)
            Me.Hide()
            BeginnersLevelForm.Visible = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Call ViewAboutBox()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        Call CloseForm1()
    End Sub

End Class
