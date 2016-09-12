Public Class EnterName

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Make sure a name is entered and not nothing
        If txtName.Text = "" Then
            MessageBox.Show("No Name has been entered." & vbNewLine & "Please enter your name.", "Error")
            txtName.Focus()
            ' Open up Difficulty window
        Else
            ' Store name in global variable
            strName = txtName.Text ' Put name in variable
            intScore = 0 ' Resets score for when second player plays
            Dim oDifficulty As Difficulty
            oDifficulty = New Difficulty()
            oDifficulty.Show()
            oDifficulty = Nothing
            Me.Close() ' Close EnterName window
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        StartScreen.Show()
        Me.Close()
    End Sub
End Class