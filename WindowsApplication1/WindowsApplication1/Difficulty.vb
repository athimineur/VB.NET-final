Public Class Difficulty

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        ' Opens up Easy1 window
        Dim oEasy1 As Easy1
        oEasy1 = New Easy1()
        oEasy1.Show()
        oEasy1 = Nothing
        Me.Close() ' Closes Difficulty window
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        ' Opens up Medium1 window
        Dim oMedium1 As Medium1
        oMedium1 = New Medium1()
        oMedium1.Show()
        oMedium1 = Nothing
        Me.Close() ' Closes Difficulty window
    End Sub
End Class