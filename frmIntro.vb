Public Class frmIntro

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        frmPacMan.Show() 'Start Game
        Me.Close()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        frmInstructions.Show() 'Show instructions
        Me.Close()
    End Sub

    Private Sub timGhosts_Tick(sender As Object, e As EventArgs) Handles timGhosts.Tick
        Static count As Integer = 0
        count += 1
        Select Case count
            Case Is < 200
                If picBlinky.Left < 460 Then
                    picBlinky.Left += 3
                Else
                    lblBlinky.Visible = True
                    lblBlinky.Left = picBlinky.Left - 16
                    lblBlinky.Top = picBlinky.Top + 25
                End If
            Case Is < 375
                If picPinky.Left < 340 Then
                    picPinky.Left += 3
                Else
                    lblPinky.Visible = True
                    lblPinky.Left = picPinky.Left - 14
                    lblPinky.Top = picPinky.Top + 25
                End If
            Case Is < 500
                If picInky.Left < 220 Then
                    picInky.Left += 3
                Else
                    lblInky.Visible = True
                    lblInky.Left = picInky.Left - 7
                    lblInky.Top = picInky.Top + 25
                End If
            Case Is < 600
                If picClyde.Left < 100 Then
                    picClyde.Left += 3
                Else
                    lblClyde.Visible = True
                    lblClyde.Left = picClyde.Left - 16
                    lblClyde.Top = picClyde.Top + 25
                End If
        End Select
    End Sub

    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picBlinky.Left = -25
        picBlinky.Top = 190
        picPinky.Left = -25
        picPinky.Top = 190
        picInky.Left = -25
        picInky.Top = 190
        picClyde.Left = -25
        picClyde.Top = 190
    End Sub
End Class