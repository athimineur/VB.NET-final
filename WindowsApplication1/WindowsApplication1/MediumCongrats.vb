Public Class MediumCongrats

    Private Sub MediumCongrats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = intScore ' updates score
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
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
    End Sub
End Class