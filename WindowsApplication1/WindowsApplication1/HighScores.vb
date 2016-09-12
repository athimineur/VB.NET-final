Public Class HighScores

    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update highscores on load

        'Only display scores if they aren't null
        If intScore1 <> 0 Then
            lblName1.Text = strName1
            lblName1.Visible = True
            lblDifficulty1.Text = strDifficulty1
            lblDifficulty1.Visible = True
            lblScore1.Text = intScore1
            lblScore1.Visible = True
        End If

        If intScore2 <> 0 Then
            lblName2.Text = strName2
            lblName2.Visible = True
            lblDifficulty2.Text = strDifficulty2
            lblDifficulty2.Visible = True
            lblScore2.Text = intScore2
            lblScore2.Visible = True
        End If

        If intScore3 <> 0 Then
            lblName3.Text = strName3
            lblName3.Visible = True
            lblDifficulty3.Text = strDifficulty3
            lblDifficulty3.Visible = True
            lblScore3.Text = intScore3
            lblScore3.Visible = True
        End If

    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        StartScreen.Show()
        Me.Close()
    End Sub
End Class