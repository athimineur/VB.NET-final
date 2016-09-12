Public Class EasyFinal

    Private Sub EasyFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = intScore ' updates score
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
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
                strDifficulty1 = "Easy"
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
                strDifficulty2 = "Easy"
                intScore2 = intScore
            ElseIf intScore > intScore3 Then
                strName3 = strName
                strDifficulty3 = "Easy"
                intScore3 = intScore
            End If
            ' brings back to start menu
            StartScreen.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Checks to see if you selected the right check boxes, shows message
        If boxQuarter.Checked = True And boxNickel.Checked = True Then
            MessageBox.Show("Good job!", "Correct")
            ' disable check boxes
            boxDime.Enabled = False
            boxQuarter.Enabled = False
            boxNickel.Enabled = False
            boxDime.Enabled = False
            btnEnter.Enabled = False
            ' enables button so you can go on
            btnNext.Visible = True
            ' if wrong answer was selected first, do not add to score
            If bolFail = False Then
                intScore = intScore + 2
                lblScore.Text = intScore
            End If
        Else
            ' if it's the wrong answer..
            MessageBox.Show("Sorry, that is incorrect.", "Incorrect")
            bolFail = True
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bolFail = False ' open next level, close current level
        Dim oEasyCongrats As EasyCongrats
        oEasyCongrats = New EasyCongrats()
        oEasyCongrats.Show()
        oEasyCongrats = Nothing
        Me.Close()
    End Sub
End Class