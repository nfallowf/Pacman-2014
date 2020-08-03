Public Class frmPacMan

#Region "Variables"
    Dim dirTry As Integer 'move around corners if key pressed early
    Dim currentDir As Integer 'Pacmans direction
    Dim fruitCase As Integer = 0 ' Type of fruit
    Dim streak As Integer = 0 'Bonus Ghost Points
    Dim powerPill As Boolean = False 'Eat ghosts
    Dim countEat As Integer = 0 'Time to eat ghosts
    Dim count As Integer = 0 'time to release ghosts
    Dim lives As Integer = 3 'lives
    Dim blinkyLeft, blinkyRight, blinkyDown, blinkyUp As Boolean 'Blinky Direction
    Dim pinkyLeft, pinkyRight, pinkyDown, pinkyUp As Boolean 'Pinky Direction
    Dim inkyLeft, inkyRight, inkyDown, inkyUp As Boolean 'Inky direction
    Dim clydeLeft, clydeRight, clydeDown, clydeUp As Boolean ' Clyde direction
    Dim board(20, 25) As Integer 'Board Array
    Dim x As Integer = 10, y As Integer = 20 'Pacman start postion 
    Dim blinkyX As Integer = 10, blinkyY As Integer = 10 'Blinky Start postion
    Dim pinkyX As Integer = 10, PinkyY As Integer = 13 'Pinky Start Position
    Dim inkyX As Integer = 9, inkyY As Integer = 13 'Inky Start position
    Dim clydeX As Integer = 11, clydeY As Integer = 13 'Clyde start postion
    Dim dots(20, 25) As PictureBox 'Dots to collect
    Dim dotsLeft As Integer = 207 'Check for level complete
#End Region
#Region "WALLS and Dots"

    Private Sub frmPacMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize() 'Initialize Randomizer
        Me.Location = New Point(300, 10) 'Center Form
        'Walls
        For i As Integer = 0 To 19
            For j As Integer = 0 To 25
                board(i, j) = 0
            Next
        Next

        For i As Integer = 0 To 8
            board(1, i) = 1
            board(19, i) = 1
        Next

        For i As Integer = 16 To 24
            board(1, i) = 1
            board(19, i) = 1
        Next

        For i As Integer = 0 To 19
            board(i, 1) = 1
            board(i, 25) = 1
        Next
        board(3, 3) = 1
        board(3, 4) = 1
        board(4, 3) = 1
        board(4, 4) = 1

        board(16, 3) = 1
        board(17, 4) = 1
        board(17, 3) = 1
        board(16, 4) = 1

        For i As Integer = 0 To 4
            board(10, i) = 1

        Next

        board(6, 3) = 1
        board(6, 4) = 1
        board(7, 3) = 1
        board(7, 4) = 1
        board(8, 3) = 1
        board(8, 4) = 1

        board(12, 3) = 1
        board(12, 4) = 1
        board(13, 3) = 1
        board(13, 4) = 1
        board(14, 3) = 1
        board(14, 4) = 1

        board(3, 6) = 1
        board(4, 6) = 1

        board(16, 6) = 1
        board(17, 6) = 1

        For i As Integer = 8 To 12
            board(i, 6) = 1
        Next

        For i As Integer = 1 To 4
            board(i, 8) = 1

        Next

        For i As Integer = 16 To 19
            board(i, 8) = 1

        Next

        For i As Integer = 6 To 11
            board(6, i) = 1
            board(14, i) = 1

        Next

        For i As Integer = 6 To 9
            board(10, i) = 1

        Next

        For i As Integer = 8 To 11
            board(4, i) = 1
            board(16, i) = 1
        Next

        board(7, 8) = 1
        board(7, 9) = 1
        board(8, 8) = 1
        board(8, 9) = 1

        board(12, 8) = 1
        board(12, 9) = 1
        board(13, 8) = 1
        board(13, 9) = 1

        For i As Integer = 1 To 4
            board(i, 11) = 1
            board(i, 13) = 1

        Next

        For i As Integer = 16 To 19
            board(i, 11) = 1
            board(i, 13) = 1

        Next

        board(9, 11) = 1
        board(11, 11) = 1

        For i As Integer = 11 To 14
            board(8, i) = 1
            board(12, i) = 1

        Next

        For i As Integer = 8 To 12
            board(i, 14) = 1

        Next

        For i As Integer = 1 To 4
            board(i, 11) = 1
        Next

        For i As Integer = 16 To 19
            board(i, 11) = 1

        Next

        For i As Integer = 13 To 16
            board(14, i) = 1
            board(6, i) = 1
        Next

        For i As Integer = 8 To 12
            board(i, 16) = 1
            board(i, 21) = 1

        Next

        For i As Integer = 13 To 16
            board(4, i) = 1
            board(16, i) = 1
        Next

        For i As Integer = 16 To 19
            board(10, i) = 1
        Next

        For i As Integer = 6 To 8
            board(i, 18) = 1
        Next
        board(8, 19) = 1
        board(12, 19) = 1

        For i As Integer = 12 To 14
            board(i, 18) = 1
        Next

        For i As Integer = 18 To 21
            board(4, i) = 1
            board(16, i) = 1
        Next

        For i As Integer = 3 To 8
            board(i, 23) = 1

        Next

        For i As Integer = 12 To 17
            board(i, 23) = 1

        Next

        For i As Integer = 0 To 4
            board(i, 16) = 1
        Next

        For i As Integer = 16 To 19
            board(i, 16) = 1
        Next

        board(3, 18) = 1
        board(17, 18) = 1

        board(2, 20) = 1
        board(2, 21) = 1
        board(18, 20) = 1
        board(18, 21) = 1

        For i As Integer = 20 To 23
            board(6, i) = 1
            board(14, i) = 1
        Next

        For i As Integer = 21 To 23
            board(10, i) = 1
        Next
        board(10, 11) = 2
        For i As Integer = 1 To 3
            board(i, 9) = 2
            board(i, 10) = 2
            board(i, 14) = 2
            board(i, 15) = 2
        Next
        For i As Integer = 17 To 19
            board(i, 9) = 2
            board(i, 10) = 2
            board(i, 14) = 2
            board(i, 15) = 2
        Next
        For i As Integer = 9 To 11
            board(i, 12) = 2
            board(i, 13) = 2
        Next
        For j As Integer = 0 To 20
            For i As Integer = 0 To 25
                dots(j, i) = New PictureBox ' Make picture boxes
            Next
        Next
        'Place dots 
        For j As Integer = 1 To 19
            For i As Integer = 1 To 25
                If board(j, i) < 1 Then
                    dots(j, i).BackColor = Color.White
                    dots(j, i).Visible = True
                    dots(j, i).Height = 4
                    dots(j, i).Width = 4
                    dots(j, i).Location = New Point(10 + ((j - 1) * 25), 10 + ((i - 1) * 25))
                    Me.Controls.Add(dots(j, i))
                    dots(j, i).BringToFront()
                End If
            Next
        Next
        'Power Pill Positions
        With dots(2, 2)
            .Height = 10
            .Width = 10
            .BackColor = Color.Yellow
            .Tag = 5
        End With
        With dots(18, 2)
            .Height = 10
            .Width = 10
            .BackColor = Color.Yellow
            .Tag = 5
        End With
        With dots(2, 24)
            .Height = 10
            .Width = 10
            .BackColor = Color.Yellow
            .Tag = 5
        End With
        With dots(18, 24)
            .Height = 10
            .Width = 10
            .BackColor = Color.Yellow
            .Tag = 5
        End With
        'Bring characters to front, board to back
        picBlinky.BringToFront()
        picPinky.BringToFront()
        picPacMan.BringToFront()
        picClyde.BringToFront()
        picInky.BringToFront()
        picBoard.SendToBack()
    End Sub
#End Region
#Region "PAC-MAN"

    Private Sub frmPacMan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Keypress Moving Pacman
        Select Case e.KeyCode
            Case Keys.Up
                dirTry = 3
                timUp.Enabled = True
                timDown.Enabled = False
                timLeft.Enabled = False
                timRight.Enabled = False
                If board(x, y - 1) = 1 Then
                    timUp.Enabled = False
                    If currentDir = 1 Then
                        If board(x - 1, y) < 1 Then
                            timLeft.Enabled = True
                        End If
                    ElseIf currentDir = 2 Then
                        If board(x + 1, y) < 1 Then
                            timRight.Enabled = True
                        End If
                    End If
                Else
                    currentDir = 3
                End If
            Case Keys.Down
                dirTry = 4
                timUp.Enabled = False
                timDown.Enabled = True
                timLeft.Enabled = False
                timRight.Enabled = False
                If board(x, y + 1) = 1 Then
                    timDown.Enabled = False
                    If currentDir = 1 Then
                        If board(x - 1, y) < 1 Then
                            timLeft.Enabled = True
                        End If
                    ElseIf currentDir = 2 Then
                        If board(x + 1, y) < 1 Then
                            timRight.Enabled = True
                        End If
                    End If
                Else
                    currentDir = 4
                End If

            Case Keys.Left
                dirTry = 1
                timUp.Enabled = False
                timDown.Enabled = False
                timLeft.Enabled = True
                timRight.Enabled = False
                If board(x - 1, y) = 1 Then
                    timLeft.Enabled = False
                    If currentDir = 3 Then
                        If board(x, y - 1) < 1 Then
                            timUp.Enabled = True
                        End If
                    ElseIf currentDir = 4 Then
                        If board(x, y + 1) < 1 Then
                            timDown.Enabled = True
                        End If
                    End If
                Else
                    currentDir = 1
                End If

            Case Keys.Right
                dirTry = 2
                timUp.Enabled = False
                timDown.Enabled = False
                timLeft.Enabled = False
                timRight.Enabled = True
                If board(x + 1, y) = 1 Then
                    timRight.Enabled = False
                    If currentDir = 3 Then
                        If board(x, y - 1) < 1 Then
                            timUp.Enabled = True
                        End If
                    ElseIf currentDir = 4 Then
                        If board(x, y + 1) < 1 Then
                            timDown.Enabled = True
                        End If
                    End If
                Else
                    currentDir = 2
                End If

        End Select
    End Sub

    Private Sub timLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timLeft.Tick
        picPacMan.Image = My.Resources.Left2
        If board(x - 1, y) < 1 Then 'Move through board
            picPacMan.Left = picPacMan.Left - 25
            x = x - 1
            'Collect dots
            If picPacMan.Bounds.IntersectsWith(dots(x, y).Bounds) And dots(x, y).Visible = True Then
                If dots(x, y).Tag = 5 Then 'Collect power pills
                    countEat = 0
                    timEatBadGuys.Interval = 1000
                    powerPill = True
                    score += 50
                    lblScore.Text = score
                    timEatBadGuys.Enabled = True
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picInky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
                Else
                    score += 10
                    lblScore.Text = score
                End If
                dots(x, y).Visible = False
                dotsLeft -= 1
                If dotsLeft = 0 Then 'check for level complete
                    Call win()
                End If
            End If
        End If
        If picPacMan.Left < 25 Then 'Exit left side, enter right
            If dots(19, 12).Visible = True Then
                score += 10
                lblScore.Text = score
                dotsLeft -= 1
                dots(19, 12).Visible = False
            End If
            picPacMan.Left = 455
            x = 19
            y = 12
        End If
        If picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) Then 'eat blinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picBlinky.Image = My.Resources.eyesRight
                If timBlinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timBlinkyBack.Enabled = True
                timBlinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picPinky.Bounds) Then 'eat pinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picPinky.Image = My.Resources.eyesRight
                If timPinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timPinkyBack.Enabled = True
                timPinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picInky.Bounds) Then 'eat inky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picInky.Image = My.Resources.eyesRight
                If timInkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timInkyBack.Enabled = True
                timInky.Enabled = False
            End If
        End If

        If picPacMan.Bounds.IntersectsWith(picClyde.Bounds) Then 'eat clyde
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picClyde.Image = My.Resources.eyesRight
                If timClydeBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timClydeBack.Enabled = True
                timClyde.Enabled = False
            End If
        End If

        If picPacMan.Bounds.IntersectsWith(picFruit.Bounds) And picFruit.Visible = True Then
            My.Computer.Audio.Play(My.Resources.pacman_eatfruit, AudioPlayMode.Background)
            If fruitCase = 1 Then
                score += 100
                picFruit.Visible = False
            ElseIf fruitCase = 2 Then
                score += 500
                picFruit.Visible = False
            ElseIf fruitCase = 3 Then
                score += 1000
                picFruit.Visible = False
            ElseIf fruitCase = 4 Then
                score += 3000
                picFruit.Visible = False
            End If
        End If
        'Go around corners when key pressed early
        If board(x, y - 1) < 1 And dirTry = 3 Then
            timLeft.Enabled = False
            timUp.Enabled = True
        ElseIf board(x, y + 1) < 1 And dirTry = 4 Then
            timLeft.Enabled = False
            timDown.Enabled = True
        End If
    End Sub

    Private Sub timUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timUp.Tick
        picPacMan.Image = My.Resources.Up2
        If board(x, y - 1) < 1 Then 'Move through board
            picPacMan.Top = picPacMan.Top - 25
            y = y - 1
            'Collect dots
            If picPacMan.Bounds.IntersectsWith(dots(x, y).Bounds) And dots(x, y).Visible = True Then
                If dots(x, y).Tag = 5 Then 'Power pills
                    countEat = 0
                    timEatBadGuys.Interval = 1000
                    powerPill = True
                    score += 50
                    lblScore.Text = score
                    timEatBadGuys.Enabled = True
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picInky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
                Else
                    score += 10
                    lblScore.Text = score
                End If
                dots(x, y).Visible = False
                dotsLeft -= 1
                If dotsLeft = 0 Then 'Check for end of level
                    Call win()
                End If
            End If
        End If
        If picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) Then 'eat blinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picBlinky.Image = My.Resources.eyesRight
                If timBlinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timBlinkyBack.Enabled = True
                timBlinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picPinky.Bounds) Then 'eat pinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picPinky.Image = My.Resources.eyesRight
                If timPinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timPinkyBack.Enabled = True
                timPinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picInky.Bounds) Then 'eat inky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picInky.Image = My.Resources.eyesRight
                If timInkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timInkyBack.Enabled = True
                timInky.Enabled = False
            End If
        End If

        If picPacMan.Bounds.IntersectsWith(picClyde.Bounds) Then 'eat clyde
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picClyde.Image = My.Resources.eyesRight
                If timClydeBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timClydeBack.Enabled = True
                timClyde.Enabled = False
            End If
        End If
        'Go around corners when key pressed early
        If board(x - 1, y) < 1 And dirTry = 1 Then
            timLeft.Enabled = True
            timUp.Enabled = False
        ElseIf board(x + 1, y) < 1 And dirTry = 2 Then
            timRight.Enabled = True
            timUp.Enabled = False
        End If
    End Sub

    Private Sub timRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timRight.Tick
        picPacMan.Image = My.Resources.Right2
        If board(x + 1, y) < 1 Then 'Move through board
            picPacMan.Left = picPacMan.Left + 25
            x = x + 1
            'collect dots
            If picPacMan.Bounds.IntersectsWith(dots(x, y).Bounds) And dots(x, y).Visible = True Then
                If dots(x, y).Tag = 5 Then 'power pills
                    countEat = 0
                    timEatBadGuys.Interval = 1000
                    powerPill = True
                    score += 50
                    lblScore.Text = score
                    timEatBadGuys.Enabled = True
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picInky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
                Else
                    score += 10
                    lblScore.Text = score
                End If
                dots(x, y).Visible = False
                dotsLeft -= 1
                If dotsLeft = 0 Then 'Check for level end
                    Call win()
                End If
            End If
        End If
        If picPacMan.Left > 456 Then 'Exit right, enter left
            If dots(1, 12).Visible = True Then
                score += 10
                lblScore.Text = score
                dotsLeft -= 1
                dots(1, 12).Visible = False
            End If
            picPacMan.Left = 5
            x = 1
            y = 12
        End If
        If picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) Then 'eat blinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picBlinky.Image = My.Resources.eyesRight
                If timBlinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timBlinkyBack.Enabled = True
                timBlinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picPinky.Bounds) Then 'eat pinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picPinky.Image = My.Resources.eyesRight
                If timPinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timPinkyBack.Enabled = True
                timPinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picInky.Bounds) Then 'eat inky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picInky.Image = My.Resources.eyesRight
                If timInkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timInkyBack.Enabled = True
                timInky.Enabled = False
            End If
        End If

        If picPacMan.Bounds.IntersectsWith(picClyde.Bounds) Then 'eat clyde
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picClyde.Image = My.Resources.eyesRight
                If timClydeBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timClydeBack.Enabled = True
                timClyde.Enabled = False
            End If
        End If
        If picPacMan.Bounds.IntersectsWith(picFruit.Bounds) And picFruit.Visible = True Then
            My.Computer.Audio.Play(My.Resources.pacman_eatfruit, AudioPlayMode.Background)
            If fruitCase = 1 Then
                score += 100
                picFruit.Visible = False
            ElseIf fruitCase = 2 Then
                score += 500
                picFruit.Visible = False
            ElseIf fruitCase = 3 Then
                score += 1000
                picFruit.Visible = False
            ElseIf fruitCase = 4 Then
                score += 3000
                picFruit.Visible = False
            End If
        End If
        'Go around corners when key pressed early
        If board(x, y - 1) < 1 And dirTry = 3 Then
            timRight.Enabled = False
            timUp.Enabled = True
        ElseIf board(x, y + 1) < 1 And dirTry = 4 Then
            timRight.Enabled = False
            timDown.Enabled = True
        End If
    End Sub

    Private Sub timDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDown.Tick
        picPacMan.Image = My.Resources.Down_2
        If board(x, y + 1) < 1 Then 'move through board
            picPacMan.Top = picPacMan.Top + 25
            y = y + 1
            'collect dots
            If picPacMan.Bounds.IntersectsWith(dots(x, y).Bounds) And dots(x, y).Visible = True Then
                If dots(x, y).Tag = 5 Then 'power pills
                    countEat = 0
                    timEatBadGuys.Interval = 1000
                    powerPill = True
                    score += 50
                    lblScore.Text = score
                    timEatBadGuys.Enabled = True
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picInky.Image = My.Resources.BadGuyGoingtoDieBlue
                    picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
                Else
                    score += 10
                    lblScore.Text = score
                End If
                dots(x, y).Visible = False
                dotsLeft -= 1
                If dotsLeft = 0 Then 'Check for end
                    Call win()
                End If
            End If
        End If
        If picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) Then 'eat blinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picBlinky.Image = My.Resources.eyesRight
                If timBlinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timBlinkyBack.Enabled = True
                timBlinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picPinky.Bounds) Then 'eat pinky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picPinky.Image = My.Resources.eyesRight
                If timPinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timPinkyBack.Enabled = True
                timPinky.Enabled = False
            End If

        End If
        If picPacMan.Bounds.IntersectsWith(picInky.Bounds) Then 'eat inky
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picInky.Image = My.Resources.eyesRight
                If timInkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timInkyBack.Enabled = True
                timInky.Enabled = False
            End If
        End If

        If picPacMan.Bounds.IntersectsWith(picClyde.Bounds) Then 'eat clyde
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picClyde.Image = My.Resources.eyesRight
                If timClydeBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timClydeBack.Enabled = True
                timClyde.Enabled = False
            End If
        End If
        'Go around corners when key pressed early
        If board(x - 1, y) < 1 And dirTry = 1 Then
            timLeft.Enabled = True
            timDown.Enabled = False
        ElseIf board(x + 1, y) < 1 And dirTry = 2 Then
            timRight.Enabled = True
            timDown.Enabled = False
        End If
    End Sub

#End Region
#Region "Release Ghosts"
    Private Sub timCount_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timCount.Tick
        count += 1
        Select Case count
            Case 3 'Relase pinky
                timPinky.Enabled = True
            Case 6 'Release Inky
                timInky.Enabled = True
                picInky.Left += 25
                inkyX += 1
            Case 9 'Release Clyde
                timClyde.Enabled = True
                picClyde.Left -= 25
                clydeX -= 1

        End Select
    End Sub
#End Region
#Region "BLINKY"

    Private Sub timBlinky_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timBlinky.Tick
        Static count As Integer = 0
        If count = 0 Then 'Play sound only at start
            My.Computer.Audio.Play(My.Resources.pacman_beginning, AudioPlayMode.WaitToComplete)
            count += 1
        End If
        If x < blinkyX And board(blinkyX - 1, blinkyY) < 1 Then 'blinky moves left
            blinkyLeft = True
            blinkyRight = False
            blinkyUp = False
            blinkyDown = False
            If powerPill = False Then
                picBlinky.Image = My.Resources.BayGuyRedLeft_copy
            End If
        ElseIf x > blinkyX And board(blinkyX + 1, blinkyY) < 1 Then 'blinky moves right
            blinkyRight = True
            blinkyLeft = False
            blinkyUp = False
            blinkyDown = False
            If powerPill = False Then
                picBlinky.Image = My.Resources.BadGuyRedRight
            End If

        ElseIf y > blinkyY And board(blinkyX, blinkyY + 1) < 1 Then 'blinky moves down
            blinkyRight = False
            blinkyLeft = False
            blinkyUp = False
            blinkyDown = True
            If powerPill = False Then
                picBlinky.Image = My.Resources.BadGuyRedDown_copy
            End If
        ElseIf y < blinkyY And board(blinkyX, blinkyY - 1) < 1 Then 'blinky moves up
            blinkyRight = False
            blinkyLeft = False
            blinkyUp = True
            blinkyDown = False
            If powerPill = False Then
                picBlinky.Image = My.Resources.BadGuyRedUp
            End If
        End If

        If blinkyLeft = True And board(blinkyX - 1, blinkyY) < 1 Then 'Move left
            picBlinky.Left -= 25
            blinkyX -= 1
            If picBlinky.Left < 25 Then
                picBlinky.Left = 455
                blinkyX = 19
                blinkyY = 12
            End If
        ElseIf blinkyRight = True And board(blinkyX + 1, blinkyY) < 1 Then 'Move right
            picBlinky.Left += 25
            blinkyX += 1
            If picBlinky.Left > 456 Then
                picBlinky.Left = 5
                blinkyX = 1
                blinkyY = 12
            End If
        ElseIf blinkyUp = True And board(blinkyX, blinkyY - 1) < 1 Then 'Move up
            picBlinky.Top -= 25
            blinkyY -= 1
        ElseIf blinkyDown = True And board(blinkyX, blinkyY + 1) < 1 Then 'Move Down
            picBlinky.Top += 25
            blinkyY += 1
        End If
        If picBlinky.Bounds.IntersectsWith(picPacMan.Bounds) Then
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picBlinky.Image = My.Resources.eyesRight
                If timBlinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timBlinkyBack.Enabled = True
                timBlinky.Enabled = False
            End If
        End If
    End Sub

#End Region
#Region "Pinky"
    Private Sub timPinky_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timPinky.Tick
        If x + 2 < pinkyX And board(pinkyX - 1, PinkyY) < 1 Then 'Pinky Moves left
            pinkyLeft = True
            pinkyRight = False
            pinkyUp = False
            pinkyDown = False
            If powerPill = False Then
                picPinky.Image = My.Resources.BadGuyPinkLeft_copy
            End If
        ElseIf x + 2 > pinkyX And board(pinkyX + 1, PinkyY) < 1 Then 'pinky moves right
            pinkyRight = True
            pinkyLeft = False
            pinkyUp = False
            pinkyDown = False
            If powerPill = False Then
                picPinky.Image = My.Resources.BadGuyPinkRight_copy
            End If

        ElseIf y + 2 > PinkyY And board(pinkyX, PinkyY + 1) < 1 Then 'blinky moves down
            pinkyRight = False
            pinkyLeft = False
            pinkyUp = False
            pinkyDown = True
            If powerPill = False Then
                picPinky.Image = My.Resources.BadguyPinkDown_copy
            End If
        ElseIf y + 2 < PinkyY And board(pinkyX, PinkyY - 1) < 1 Or board(pinkyX - 1, PinkyY) = 2 Then 'blinky moves up
            pinkyRight = False
            pinkyLeft = False
            pinkyUp = True
            pinkyDown = False
            If powerPill = False Then
                picPinky.Image = My.Resources.BadGuyPinkUp_copy
            End If
        End If

        If pinkyLeft = True And board(pinkyX - 1, PinkyY) < 1 Then 'Move left
            picPinky.Left -= 25
            pinkyX -= 1
            If picPinky.Left < 25 Then
                picPinky.Left = 455
                pinkyX = 19
                PinkyY = 12
            End If
        ElseIf pinkyRight = True And board(pinkyX + 1, PinkyY) < 1 Then 'Move right
            picPinky.Left += 25
            pinkyX += 1
            If picPinky.Left > 456 Then
                picPinky.Left = 5
                pinkyX = 1
                PinkyY = 12
            End If
        ElseIf pinkyUp = True And board(pinkyX, PinkyY - 1) < 1 Or board(pinkyX - 1, PinkyY) = 2 Then 'Move up
            picPinky.Top -= 25
            PinkyY -= 1
        ElseIf pinkyDown = True And board(pinkyX, PinkyY + 1) < 1 Then 'Move Down
            picPinky.Top += 25
            PinkyY += 1
        End If
        If picPinky.Bounds.IntersectsWith(picPacMan.Bounds) Then
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picPinky.Image = My.Resources.eyesRight
                If timPinkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timPinkyBack.Enabled = True
                timPinky.Enabled = False
            End If
        End If
    End Sub
#End Region
#Region "Inky"
    Private Sub timInky_Tick(sender As Object, e As EventArgs) Handles timInky.Tick
        If x - 3 < inkyX And board(inkyX - 1, inkyY) < 1 Then 'inky moves left
            inkyLeft = True
            inkyRight = False
            inkyUp = False
            inkyDown = False
            If powerPill = False Then
                picInky.Image = My.Resources.BadGuyCyanLeft_copy
            End If
        ElseIf x - 3 > inkyX And board(inkyX + 1, inkyY) < 1 Then 'inky moves right
            inkyRight = True
            inkyLeft = False
            inkyUp = False
            inkyDown = False
            If powerPill = False Then
                picInky.Image = My.Resources.BadGuyCyanRight_copy
            End If

        ElseIf y - 3 > inkyY And board(inkyX, inkyY + 1) < 1 Then 'inky moves down
            inkyRight = False
            inkyLeft = False
            inkyUp = False
            inkyDown = True
            If powerPill = False Then
                picInky.Image = My.Resources.BadGuyCyanDown_copy
            End If

        ElseIf y - 3 < inkyY And board(inkyX, inkyY - 1) < 1 Or board(inkyX - 1, inkyY) = 2 Then 'inky moves up
            inkyRight = False
            inkyLeft = False
            inkyUp = True
            inkyDown = False
            If powerPill = False Then
                picInky.Image = My.Resources.BadGuyCyanUp_copy
            End If
        End If

        If inkyLeft = True And board(inkyX - 1, inkyY) < 1 Then 'Move left
            picInky.Left -= 25
            inkyX -= 1
            If picInky.Left < 25 Then
                picInky.Left = 455
                inkyX = 19
                inkyY = 12
            End If
        ElseIf inkyRight = True And board(inkyX + 1, inkyY) < 1 Then 'Move right
            picInky.Left += 25
            inkyX += 1
            If picInky.Left > 456 Then
                picInky.Left = 5
                inkyX = 1
                inkyY = 12
            End If
        ElseIf inkyUp = True And board(inkyX, inkyY - 1) < 1 Or board(inkyX - 1, inkyY) = 2 Then 'Move up
            picInky.Top -= 25
            inkyY -= 1
        ElseIf inkyDown = True And board(inkyX, inkyY + 1) < 1 Then 'Move Down
            picInky.Top += 25
            inkyY += 1
        End If
        If picInky.Bounds.IntersectsWith(picPacMan.Bounds) Then
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picInky.Image = My.Resources.eyesRight
                If timInkyBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timInkyBack.Enabled = True
                timInky.Enabled = False
            End If
        End If
    End Sub
#End Region
#Region "Clyde"
    Private Sub timClyde_Tick(sender As Object, e As EventArgs) Handles timClyde.Tick

        If x + 5 < clydeX And board(clydeX - 1, clydeY) < 1 Then 'clyde moves left
            clydeLeft = True
            clydeRight = False
            clydeUp = False
            clydeDown = False
            If powerPill = False Then
                picClyde.Image = My.Resources.BadGuyOrangeLeft_copy
            End If
        ElseIf x + 5 > clydeX And board(clydeX + 1, clydeY) < 1 Then 'clyde moves right
            clydeRight = True
            clydeLeft = False
            clydeUp = False
            clydeDown = False
            If powerPill = False Then
                picClyde.Image = My.Resources.BadGuyOrangeRight_copy
            End If

        ElseIf y + 5 > clydeY And board(clydeX, clydeY + 1) < 1 Then 'clyde moves down
            clydeRight = False
            clydeLeft = False
            clydeUp = False
            clydeDown = True
            If powerPill = False Then
                picClyde.Image = My.Resources.BadGuyOrangeDown_copy
            End If
        ElseIf y + 5 < clydeY And board(clydeX, clydeY - 1) < 1 Or board(clydeX - 1, clydeY) = 2 Then 'clyde moves up
            clydeRight = False
            clydeLeft = False
            clydeUp = True
            clydeDown = False
            If powerPill = False Then
                picClyde.Image = My.Resources.BadGuyOrangeUp_copy
            End If
        End If

        If clydeLeft = True And board(clydeX - 1, clydeY) < 1 Then 'Move left
            picClyde.Left -= 25
            clydeX -= 1
            If picClyde.Left < 25 Then
                picClyde.Left = 455
                clydeX = 19
                clydeY = 12
            End If
        ElseIf clydeRight = True And board(clydeX + 1, clydeY) < 1 Then 'Move right
            picClyde.Left += 25
            clydeX += 1
            If picClyde.Left > 456 Then
                picClyde.Left = 5
                clydeX = 1
                clydeY = 12
            End If
        ElseIf clydeUp = True And board(clydeX, clydeY - 1) < 1 Or board(clydeX - 1, clydeY) = 2 Then 'Move up
            picClyde.Top -= 25
            clydeY -= 1
        ElseIf clydeDown = True And board(clydeX, clydeY + 1) < 1 Then 'Move Down
            picClyde.Top += 25
            clydeY += 1
        End If
        If picClyde.Bounds.IntersectsWith(picPacMan.Bounds) Then
            If powerPill = False Then
                Call death()
            ElseIf powerPill = True Then
                Call eatGhosts()
                picClyde.Image = My.Resources.eyesRight
                If timClydeBack.Enabled = False Then
                    My.Computer.Audio.Play(My.Resources.pacman_eatghost, AudioPlayMode.Background)
                End If
                timClydeBack.Enabled = True
                timClyde.Enabled = False
            End If
        End If
    End Sub
#End Region
#Region "Death"
    Private Sub death()
        lives -= 1 'lose a life
        Select Case lives
            Case 2 'lose third life
                picLive3.Visible = False
            Case 1 'lose 2nd
                picLive2.Visible = False
            Case 0 'game over
                picLive1.Visible = False
                frmLose.Show()
                Me.Close()
        End Select
        powerPill = False
        picPacMan.Location = New Point(228, 478) 'reset pacman location
        x = 10
        y = 20
        picBlinky.Location = New Point(228, 230) 'reset blinky location
        blinkyX = 10
        blinkyY = 10
        picPinky.Location = New Point(228, 304) 'reset pinky location
        pinkyX = 10
        PinkyY = 13
        picInky.Location = New Point(202, 304) 'reset inky location
        inkyX = 9
        inkyY = 13
        picClyde.Location = New Point(253, 304) 'reset clyde location
        clydeX = 11
        clydeY = 13
        count = 0
        timBlinky.Enabled = True
        timPinky.Enabled = False
        timClyde.Enabled = False
        timInky.Enabled = False
    End Sub

#End Region
#Region "Win"
    Private Sub win()
        timEatBadGuys.Enabled = False
        timBlinky.Enabled = False
        timPinky.Enabled = False
        timInky.Enabled = False
        timClyde.Enabled = False
        timBlinkyBack.Enabled = False
        timPinkyBack.Enabled = False
        timInkyBack.Enabled = False
        timClydeBack.Enabled = False
        If level Mod 2 = 0 And lives < 3 Then 'Extra live every 2nd level
            MsgBox("Extra Live")
            lives += 1
            Select Case lives
                Case 2
                    picLive2.Visible = True
                Case 3
                    picLive3.Visible = True
            End Select
        End If
        powerPill = False
        level += 1 'Up a level
        lblLevel.Text = level
        'reset ghosts, pacman and timers
        picBlinky.Image = My.Resources.BadGuyRedRight
        picPinky.Image = My.Resources.BadGuyPinkUp_copy
        picInky.Image = My.Resources.BadGuyCyanRight_copy
        picClyde.Image = My.Resources.BadGuyOrangeLeft_copy
        timEatBadGuys.Enabled = False
        timBlinky.Enabled = False
        timPinky.Enabled = False
        timInky.Enabled = False
        timClyde.Enabled = False
        timBlinkyBack.Enabled = False
        timPinkyBack.Enabled = False
        timInkyBack.Enabled = False
        timClydeBack.Enabled = False
        MsgBox("You win")
        count = 0 'reset release ghost timer
        timCount.Enabled = True
        picPacMan.Location = New Point(228, 478)
        x = 10
        y = 20
        picBlinky.Location = New Point(228, 230)
        blinkyX = 10
        blinkyY = 10
        picPinky.Location = New Point(228, 304)
        pinkyX = 10
        PinkyY = 13
        picInky.Location = New Point(202, 304)
        inkyX = 9
        inkyY = 13
        picClyde.Location = New Point(253, 304)
        clydeX = 11
        clydeY = 13
        If level Mod 5 = 0 Then 'difficulty up every 5 levels
            timBlinky.Interval -= 10
            timPinky.Interval -= 10
            timInky.Interval -= 10
            timClyde.Interval -= 10
            timEatBadGuys.Interval -= 50
        End If
        For j As Integer = 1 To 19 'reset dots
            For i As Integer = 1 To 25
                If board(j, i) < 1 Then
                    dots(j, i).Visible = True
                End If
            Next
        Next
        dotsLeft = 207 'reset dots left
        timBlinky.Enabled = True
    End Sub
#End Region
#Region "Eat Bad Guys"
    Private Sub timEatBadGuys_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timEatBadGuys.Tick
        powerPill = True 'Allow bad guy eating
        If countEat < 5 Then 'solid blue ghosts
            If timBlinkyBack.Enabled = False Then
                picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
            End If
            If timPinkyBack.Enabled = False Then
                picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
            End If
            If timInkyBack.Enabled = False Then
                picInky.Image = My.Resources.BadGuyGoingtoDieBlue
            End If
            If timClydeBack.Enabled = False Then
                picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
            End If
            countEat += 1
        ElseIf countEat < 30 Then 'Flashing ghosts
            timEatBadGuys.Interval = 150
            If countEat Mod 2 = 0 Then
                If timBlinkyBack.Enabled = False Then
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieWhite
                End If
                If timPinkyBack.Enabled = False Then
                    picPinky.Image = My.Resources.BadGuyGoingtoDieWhite
                End If
                If timInkyBack.Enabled = False Then
                    picInky.Image = My.Resources.BadGuyGoingtoDieWhite
                End If
                If timClydeBack.Enabled = False Then
                    picClyde.Image = My.Resources.BadGuyGoingtoDieWhite
                End If
                countEat += 1
            Else 'Flashing ghosts
                If timBlinkyBack.Enabled = False Then
                    picBlinky.Image = My.Resources.BadGuyGoingtoDieBlue
                End If
                If timPinkyBack.Enabled = False Then
                    picPinky.Image = My.Resources.BadGuyGoingtoDieBlue
                End If
                If timInkyBack.Enabled = False Then
                    picInky.Image = My.Resources.BadGuyGoingtoDieBlue
                End If
                If timClydeBack.Enabled = False Then
                    picClyde.Image = My.Resources.BadGuyGoingtoDieBlue
                End If
                countEat += 1
            End If
        ElseIf countEat >= 30 Then 'Back to normal ghosts
            picBlinky.Image = My.Resources.BadGuyRedRight
            picPinky.Image = My.Resources.BadGuyPinkRight_copy
            picInky.Image = My.Resources.BadGuyCyanRight_copy
            picClyde.Image = My.Resources.BadGuyOrangeRight_copy
            powerPill = False
            countEat = 0
            streak = 0
            timEatBadGuys.Interval = 1000
            timEatBadGuys.Enabled = False
            timBlinkyBack.Enabled = False
            timPinkyBack.Enabled = False
            timInkyBack.Enabled = False
            timClydeBack.Enabled = False
            timBlinky.Enabled = True
            timPinky.Enabled = True
            timInky.Enabled = True
            timClyde.Enabled = True
        End If
    End Sub
    Private Sub eatGhosts()
        If picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) And timBlinkyBack.Enabled = False Or picPacMan.Bounds.IntersectsWith(picPinky.Bounds) And timPinkyBack.Enabled = False Or picPacMan.Bounds.IntersectsWith(picInky.Bounds) And timInkyBack.Enabled = False Or timBlinkyBack.Enabled = False Or picPacMan.Bounds.IntersectsWith(picBlinky.Bounds) And timBlinkyBack.Enabled = False Or picPacMan.Bounds.IntersectsWith(picClyde.Bounds) And timClydeBack.Enabled = False Then
            Select Case streak 'Bonus points for eating multiple ghosts
                Case 0
                    score += 200
                    lblScore.Text = score
                    streak += 1
                Case 1
                    score += 400
                    lblScore.Text = score
                    streak += 1
                Case 2
                    score += 800
                    lblScore.Text = score
                    streak += 1
                Case 3
                    score += 1600
                    lblScore.Text = score
                    streak = 0
            End Select
        End If
    End Sub
    Private Sub timBlinkyBack_Tick(sender As Object, e As EventArgs) Handles timBlinkyBack.Tick
        'Blinky try to go back to ghost start
        If blinkyX > 10 And board(blinkyX - 1, blinkyY) < 1 Then 'left
            blinkyLeft = True
            blinkyRight = False
            blinkyUp = False
            blinkyDown = False
            picBlinky.Image = My.Resources.eyesLeft
        ElseIf blinkyX < 10 And board(blinkyX + 1, blinkyY) < 1 Then 'right
            blinkyRight = True
            blinkyLeft = False
            blinkyUp = False
            blinkyDown = False
            picBlinky.Image = My.Resources.eyesRight

        ElseIf blinkyY < 10 And board(blinkyX, blinkyY + 1) < 1 Then 'down
            blinkyRight = False
            blinkyLeft = False
            blinkyUp = False
            blinkyDown = True
            picBlinky.Image = My.Resources.eyesDown
        ElseIf blinkyY > 10 And board(blinkyX, blinkyY - 1) < 1 Then 'up
            blinkyRight = False
            blinkyLeft = False
            blinkyUp = True
            blinkyDown = False
            picBlinky.Image = My.Resources.eyesUp
        End If

        If blinkyLeft = True And board(blinkyX - 1, blinkyY) < 1 Then 'Move left
            picBlinky.Left -= 25
            blinkyX -= 1
            If picBlinky.Left < 25 Then
                picBlinky.Left = 455
                blinkyX = 19
                blinkyY = 12
            End If
        ElseIf blinkyRight = True And board(blinkyX + 1, blinkyY) < 1 Then 'Move right
            picBlinky.Left += 25
            blinkyX += 1
            If picBlinky.Left > 456 Then
                picBlinky.Left = 5
                blinkyX = 1
                blinkyY = 12
            End If
        ElseIf blinkyUp = True And board(blinkyX, blinkyY - 1) < 1 Then 'Move up
            picBlinky.Top -= 25
            blinkyY -= 1
        ElseIf blinkyDown = True And board(blinkyX, blinkyY + 1) < 1 Then 'Move Down
            picBlinky.Top += 25
            blinkyY += 1
        End If
    End Sub

    Private Sub timPinkyBack_Tick(sender As Object, e As EventArgs) Handles timPinkyBack.Tick
        'Pinky try to go back to ghost start
        If pinkyX > 10 And board(pinkyX - 1, PinkyY) < 1 Then 'left
            pinkyLeft = True
            pinkyRight = False
            pinkyUp = False
            pinkyDown = False
            picPinky.Image = My.Resources.eyesLeft
        ElseIf pinkyX < 10 And board(pinkyX + 1, PinkyY) < 1 Then 'right
            pinkyRight = True
            pinkyLeft = False
            pinkyUp = False
            pinkyDown = False
            picPinky.Image = My.Resources.eyesRight

        ElseIf PinkyY < 10 And board(pinkyX, PinkyY + 1) < 1 Then 'down 
            pinkyRight = False
            pinkyLeft = False
            pinkyUp = False
            pinkyDown = True
            picPinky.Image = My.Resources.eyesDown
        ElseIf PinkyY > 10 And board(pinkyX, PinkyY - 1) < 1 Then 'up
            pinkyRight = False
            pinkyLeft = False
            pinkyUp = True
            pinkyDown = False
            picPinky.Image = My.Resources.eyesUp
        End If

        If pinkyLeft = True And board(pinkyX - 1, PinkyY) < 1 Then 'Move left
            picPinky.Left -= 25
            pinkyX -= 1
            If picPinky.Left < 25 Then
                picPinky.Left = 455
                pinkyX = 19
                PinkyY = 12
            End If
        ElseIf pinkyRight = True And board(pinkyX + 1, PinkyY) < 1 Then 'Move right
            picPinky.Left += 25
            pinkyX += 1
            If picPinky.Left > 456 Then
                picPinky.Left = 5
                pinkyX = 1
                PinkyY = 12
            End If
        ElseIf pinkyUp = True And board(pinkyX, PinkyY - 1) < 1 Then 'Move up
            picPinky.Top -= 25
            PinkyY -= 1
        ElseIf pinkyDown = True And board(pinkyX, PinkyY + 1) < 1 Then 'Move Down
            picPinky.Top += 25
            PinkyY += 1
        End If
    End Sub

    Private Sub timInkyBack_Tick(sender As Object, e As EventArgs) Handles timInkyBack.Tick
        'Inky try to go back to ghost start
        If inkyX > 10 And board(inkyX - 1, inkyY) < 1 Then 'left
            inkyLeft = True
            inkyRight = False
            inkyUp = False
            inkyDown = False
            picInky.Image = My.Resources.eyesLeft
        ElseIf inkyX < 10 And board(inkyX + 1, inkyY) < 1 Then 'right
            inkyRight = True
            inkyLeft = False
            inkyUp = False
            inkyDown = False
            picInky.Image = My.Resources.eyesRight

        ElseIf inkyY < 10 And board(inkyX, inkyY + 1) < 1 Then 'down
            inkyRight = False
            inkyLeft = False
            inkyUp = False
            inkyDown = True
            picInky.Image = My.Resources.eyesDown
        ElseIf inkyY > 10 And board(inkyX, inkyY - 1) < 1 Then 'up
            inkyRight = False
            inkyLeft = False
            inkyUp = True
            inkyDown = False
            picInky.Image = My.Resources.eyesUp
        End If

        If inkyLeft = True And board(inkyX - 1, inkyY) < 1 Then 'Move left
            picInky.Left -= 25
            inkyX -= 1
            If picInky.Left < 25 Then
                picInky.Left = 455
                inkyX = 19
                inkyY = 12
            End If
        ElseIf inkyRight = True And board(inkyX + 1, inkyY) < 1 Then 'Move right
            picInky.Left += 25
            inkyX += 1
            If picInky.Left > 456 Then
                picInky.Left = 5
                inkyX = 1
                inkyY = 12
            End If
        ElseIf inkyUp = True And board(inkyX, inkyY - 1) < 1 Then 'Move up
            picInky.Top -= 25
            inkyY -= 1
        ElseIf inkyDown = True And board(inkyX, inkyY + 1) < 1 Then 'Move Down
            picInky.Top += 25
            inkyY += 1
        End If
    End Sub

    Private Sub timClydeBack_Tick(sender As Object, e As EventArgs) Handles timClydeBack.Tick
        'clyde try to go back to ghost start
        If clydeX > 10 And board(clydeX - 1, clydeY) < 1 Then 'left
            clydeLeft = True
            clydeRight = False
            clydeUp = False
            clydeDown = False
            picClyde.Image = My.Resources.eyesLeft
        ElseIf clydeX < 10 And board(clydeX + 1, clydeY) < 1 Then 'right
            clydeRight = True
            clydeLeft = False
            clydeUp = False
            clydeDown = False
            picClyde.Image = My.Resources.eyesRight

        ElseIf clydeY < 10 And board(clydeX, clydeY + 1) < 1 Then ' down
            clydeRight = False
            clydeLeft = False
            clydeUp = False
            clydeDown = True
            picClyde.Image = My.Resources.eyesDown
        ElseIf clydeY > 10 And board(clydeX, clydeY - 1) < 1 Then 'up
            clydeRight = False
            clydeLeft = False
            clydeUp = True
            clydeDown = False
            picClyde.Image = My.Resources.eyesUp
        End If

        If clydeLeft = True And board(clydeX - 1, clydeY) < 1 Then 'Move left
            picClyde.Left -= 25
            clydeX -= 1
            If picClyde.Left < 25 Then
                picClyde.Left = 455
                clydeX = 19
                clydeY = 12
            End If
        ElseIf clydeRight = True And board(clydeX + 1, clydeY) < 1 Then 'Move right
            picClyde.Left += 25
            clydeX += 1
            If picClyde.Left > 456 Then
                picClyde.Left = 5
                clydeX = 1
                clydeY = 12
            End If
        ElseIf clydeUp = True And board(clydeX, clydeY - 1) < 1 Then 'Move up
            picClyde.Top -= 25
            clydeY -= 1
        ElseIf clydeDown = True And board(clydeX, clydeY + 1) < 1 Then 'Move Down
            picClyde.Top += 25
            clydeY += 1
        End If
    End Sub
#End Region
#Region "Fruit"
    Private Sub timFruit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timFruit.Tick
        Static fruitCount As Integer = 0
        fruitCount += 1
        If fruitCount = 10 Then
            picFruit.Image = My.Resources.cherries
            picFruit.Visible = True
            fruitCase = 1
        ElseIf fruitCount = 15 Then
            picFruit.Visible = False
        ElseIf fruitCount = 30 Then
            picFruit.Image = My.Resources.strawberry
            picFruit.Visible = True
            fruitCase = 2
        ElseIf fruitCount = 35 Then
            picFruit.Visible = False
        ElseIf fruitCount = 50 Then
            picFruit.Image = My.Resources.orange
            picFruit.Visible = True
            fruitCase = 3
        ElseIf fruitCount = 57 Then
            picFruit.Visible = False
        ElseIf fruitCount = 75 Then
            picFruit.Image = My.Resources.keypac
            picFruit.Visible = True
            fruitCase = 4
        ElseIf fruitCount = 85 Then
            picFruit.Visible = False
            fruitCount = 0
        End If
    End Sub
#End Region

End Class
