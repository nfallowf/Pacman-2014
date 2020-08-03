Public Class frmInstructions

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmIntro.Show() 'Back to title screen
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmPacMan.Show() 'Start Game
        Me.Close()
    End Sub

End Class