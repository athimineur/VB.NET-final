Public Class Medium1
    Dim sngBallXSpeed As Single
    Dim sngBallYSpeed As Single
    Dim rndRandom As New Random
    Dim intMovement As Integer
    Dim intScorePlayer As Integer
    Dim intScoreComputer As Integer
    Dim intWin As Integer
    Dim intLost As Integer
    Dim bolMoveMouse As Boolean = False
    Dim bolDisableBall As Boolean = False
    Dim bolStart As Boolean = False
    Dim bolFail As Boolean = False

    Private Sub Medium1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ' click the mouse to start the game
        If bolStart = True Then
            ' enables timer, all ball properties enabled, scores are set to 0, ball speed is reset
            timGameTimer.Enabled = True
            clpBall.Visible = True
            bolMoveMouse = True
            bolStart = False
            sngBallXSpeed = -5
            sngBallYSpeed = 0
            clpBall.Visible = True
            bolDisableBall = False
            intScoreComputer = 0
            intScorePlayer = 0
            lblScoreComputer.Text = 0
            lblScorePlayer.Text = 0
            intWin = 0
            intLost = 0
        End If

    End Sub

    Private Sub Medium1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        ' move YOUR paddle where you move mouse
        If bolMoveMouse = True Then
            ' if y position of mouse (up and down) is greater than 5 and less than the height of the form minus the height of the paddle (and minus 40..it looks weird if I leave that out) then...
            If e.Y > 5 And e.Y < Me.Height - 40 - clpPaddlePlayer.Height Then
                ' set the location of the paddle to the same x position (so it never moves foward or backward) and keep it on that y point, so it follows the mouse perfectly
                clpPaddlePlayer.Location = New Point(clpPaddlePlayer.Location.X, e.Y)

                ' Note: if mouse moves off the form, the paddle will not move
            End If
        End If
    End Sub

    Private Sub timGameTimer_Tick(sender As Object, e As EventArgs) Handles timGameTimer.Tick

        ' ball location is equal to it's location plus the ball speed
        If bolDisableBall = False Then
            clpBall.Location = New Point(clpBall.Location.X + Math.Round(sngBallXSpeed), clpBall.Location.Y + Math.Round(sngBallYSpeed))
        End If


        'Checks if ball intersects with player paddle
        If clpBall.Bounds.IntersectsWith(clpPaddlePlayer.Bounds) Then
            sngBallXSpeed = 5
            sngBallYSpeed = rndRandom.Next(-8, 9)
        End If

        ' Checks if ball intersects with computer paddle
        If clpBall.Bounds.IntersectsWith(clpPaddleComputer.Bounds) Then
            sngBallXSpeed = -5
            sngBallYSpeed = rndRandom.Next(-8, 9)
        End If

        ' checks if ball interacts with walls - makes it "bounce" off so it doesn't go off screen
        If clpBall.Location.Y > 415 Then
            sngBallYSpeed = -5
        End If
        If clpBall.Location.Y < 5 Then
            sngBallYSpeed = 5
        End If


        'Set the computer player to move according to the ball's position.
        If clpPaddleComputer.Location.Y < 305 And clpPaddleComputer.Location.Y > 10 And clpBall.Location.Y < 390 And clpBall.Location.Y > 5 And clpBall.Location.X > 250 And clpBall.Location.X < 600 Then
            clpPaddleComputer.Location = New Point(clpPaddleComputer.Location.X, clpPaddleComputer.Location.Y + sngBallYSpeed)
            ' if paddle goes too far down then keep it in the screen
        ElseIf clpPaddleComputer.Location.Y >= 305 Then
            clpPaddleComputer.Location = New Point(clpPaddleComputer.Location.X, clpPaddleComputer.Location.Y - 1)
            ' if paddle goes too far up then keep it in the screen
        ElseIf clpPaddleComputer.Location.Y <= 10 Then
            clpPaddleComputer.Location = New Point(clpPaddleComputer.Location.X, clpPaddleComputer.Location.Y + 1)
        End If

        ' adds to computer score if ball goes past player paddle
        If clpBall.Location.X <= -15 Then
            intScoreComputer = intScoreComputer + 1
            lblScoreComputer.Text = intScoreComputer
            If intScoreComputer = 3 Then
                intLost = 1
            End If
            If intLost = 0 Then ' if score isn't 3
                sngBallYSpeed = rndRandom.Next(-8, 8)
                sngBallXSpeed = 5
                clpPaddleComputer.Location = New Point(clpPaddleComputer.Location.X, clpPaddleComputer.Location.Y + sngBallYSpeed)
                clpBall.Location = New Point(clpBall.Location.X + 330, clpBall.Location.Y)
            End If
            If intLost = 1 Then ' if score is 3
                intLost = 2 ' this will only happen once
                bolDisableBall = True
                bolMoveMouse = False ' stop allowing movement of the paddle with the mouse
                clpBall.Visible = False ' ball dissapear
                sngBallYSpeed = 0 ' ball speed is 0 so it won't move up or down
                clpBall.Location = New Point(clpBall.Location.X + 330, clpBall.Location.Y) ' keep the ball in place while invisible
                MessageBox.Show("You lose!", "Lose") ' display message
                btnRetry.Visible = True ' show buttons
                btnEndGame.Visible = True ' show buttons
                bolFail = True
            End If
        End If

        ' adds to player score if ball goes past computer paddle
        If clpBall.Location.X >= 600 Then
            intScorePlayer = intScorePlayer + 1
            lblScorePlayer.Text = intScorePlayer
            If intScorePlayer = 3 Then
                intWin = 1
            End If
            If intWin = 0 Then ' if score isn't 3
                sngBallYSpeed = rndRandom.Next(-8, 8)
                sngBallXSpeed = -5
                ' reset ball to the middle and keep playing
                clpPaddleComputer.Location = New Point(clpPaddleComputer.Location.X, clpPaddleComputer.Location.Y + sngBallYSpeed)
                clpBall.Location = New Point(clpBall.Location.X - 300, clpBall.Location.Y)
            End If
            If intWin = 1 Then ' if score is 3
                intWin = 2 ' this will only happen once
                bolDisableBall = True
                bolMoveMouse = False ' stop allowing movement of the paddle with the mouse
                clpBall.Visible = False ' ball dissapear
                sngBallYSpeed = 0 ' ball speed is 0 so it won't move up or down
                clpBall.Location = New Point(clpBall.Location.X - 300, clpBall.Location.Y) ' keep the ball in place while invisible
                MessageBox.Show("You win!", "Win") ' display message
                btnNextLevel.Visible = True ' show buttons
                btnEndGame.Visible = True ' show buttons
                If bolFail = False Then ' if you never lost the level, add 3 to your score
                    intScore = 3
                End If
            End If
        End If
    End Sub

    Private Sub Medium1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ball speed variables
        sngBallXSpeed = -5
        sngBallYSpeed = 0
    End Sub

    Private Sub btnEndGame_Click(sender As Object, e As EventArgs) Handles btnEndGame.Click
        ' asks to make sure if you want to quit the game
        ' checks and puts highscore
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to end your game?", MsgBoxStyle.YesNoCancel, "Are you sure?")
        If ask = MsgBoxResult.Yes Then

            ' Puts scores in right order (highest to lowest)
            If intScore > intScore1 Then

                'variables to store scores in so they can be switched if someone gets a higher score
                Dim strTempName2 As String
                Dim strTempDifficulty2 As String
                Dim intTempScore2 As Integer

                Dim strTempName3 As String
                Dim strTempDifficulty3 As String
                Dim intTempScore3 As Integer

                strTempName2 = strName1
                strTempDifficulty2 = strDifficulty1
                intTempScore2 = intScore1

                strTempName3 = strName2
                strTempDifficulty3 = strDifficulty2
                intTempScore3 = intScore2

                strName2 = strTempName2
                strDifficulty2 = strTempDifficulty2
                intScore2 = intTempScore2

                strName3 = strTempName3
                strDifficulty3 = strTempDifficulty3
                intScore3 = intTempScore3


                ' Updates high score
                strName1 = strName
                strDifficulty1 = "Medium"
                intScore1 = intScore


            ElseIf intScore > intScore2 Then

                'variables to store scores in so they can be switched if someone gets a higher score
                Dim strTempName3 As String
                Dim strTempDifficulty3 As String
                Dim intTempScore3 As Integer

                strTempName3 = strName2
                strTempDifficulty3 = strDifficulty2
                intTempScore3 = intScore2

                strName3 = strTempName3
                strDifficulty3 = strTempDifficulty3
                intScore3 = intTempScore3

                strName2 = strName
                strDifficulty2 = "Medium"
                intScore2 = intScore
            ElseIf intScore > intScore3 Then
                strName3 = strName
                strDifficulty3 = "Medium"
                intScore3 = intScore
            End If
            ' brings back to start menu
            StartScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        MessageBox.Show("Welcome to Pong!" & vbNewLine & "Click the mouse when you are ready to begin." & vbNewLine & "First to 3 points wins!", "Start")
        btnStart.Visible = False
        bolStart = True
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        btnEndGame.Visible = False
        btnRetry.Visible = False
        MessageBox.Show("Click when you are ready to begin.", "Retry")
        bolStart = True
    End Sub

    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        Dim oMedium2 As Medium2
        oMedium2 = New Medium2()
        oMedium2.Show()
        oMedium2 = Nothing
        Me.Close()
    End Sub
End Class