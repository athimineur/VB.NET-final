Public Class StartScreen

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes program
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ' Open up EnterName window
        Dim oEnterName As EnterName
        oEnterName = New EnterName()
        oEnterName.Show()
        oEnterName = Nothing
        Me.Close() ' Close Start Screen window
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        ' Open up HighScores window
        Dim oHighScores As HighScores
        oHighScores = New HighScores()
        oHighScores.Show()
        oHighScores = Nothing
        Me.Close() ' Close Start Screen window
    End Sub
End Class