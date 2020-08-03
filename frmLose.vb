Public Class frmLose

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        level = 1
        score = 0
        frmPacMan.Show()
        Me.Close()
    End Sub

    Private Sub frmLose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = score
        lblLevel.Text = level
    End Sub
End Class