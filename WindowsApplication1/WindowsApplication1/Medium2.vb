Public Class Medium2
    Dim bolStopMoving As Boolean = False
    Dim intStar As Integer
    Dim bolLost As Boolean = False
    Dim bolLose As Boolean = False
    Dim intLives As Integer = 5
    Dim bol70Right As Boolean = True
    Dim bol61Right As Boolean = True
    Dim bol64Right As Boolean = False
    Dim bol65Right As Boolean = False
    Dim bol62Right As Boolean = True
    Dim Bol87Down As Boolean = False
    Dim bol88Down As Boolean = True
    Dim bol89Down As Boolean = True
    Dim bol58Down As Boolean = False
    Dim bol67Down As Boolean = False
    Dim bol68Right As Boolean = True
    Dim bol73Right As Boolean = False
    Dim bol75Right As Boolean = False
    Dim bol76Down As Boolean = False
    Dim bol74Down As Boolean = True
    Dim bol71Right As Boolean = False
    Dim bol86Down As Boolean = True
    Dim bol85Right As Boolean = True
    Dim bol72Down As Boolean = True
    Dim bol60Down As Boolean = False
    Dim bol57Down As Boolean = True
    Dim bol69Right As Boolean = True
    Dim bol63Right As Boolean = False
    Dim bol66Right As Boolean = False

    Private Sub Medium2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        ' FOR PRESENTATION SKIP LEVEL IF P IS PRESSED
        If e.KeyCode = Keys.P Then
            Dim oMediumCongrats As MediumCongrats
            oMediumCongrats = New MediumCongrats()
            oMediumCongrats.Show()
            oMediumCongrats = Nothing
            Me.Close()
        End If

        ' all movement for the green box (long code, but it's really just checks so it doesn't go through walls of maze
        If bolLose = False Then
            If e.KeyCode = Keys.D Then
                clpPlayer.Left += 10
                If clpPlayer.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox25.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox27.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox28.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox29.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox30.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox31.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox32.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox33.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox34.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox35.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox36.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox42.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox43.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox41.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox40.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox39.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox38.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox37.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox12.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox47.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox49.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox50.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox52.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox48.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox51.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox53.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox54.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox55.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox56.Bounds) Then
                    clpPlayer.Left -= 10
                End If
            End If

            If e.KeyCode = Keys.A Then
                clpPlayer.Left -= 10
                If clpPlayer.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox25.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox27.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox28.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox29.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox30.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox31.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox32.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox33.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox34.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox35.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox36.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox42.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox43.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox41.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox40.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox39.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox38.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox37.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox12.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox47.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox49.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox50.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox52.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox48.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox51.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox53.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox54.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox55.Bounds) Then
                    clpPlayer.Left += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox56.Bounds) Then
                    clpPlayer.Left += 10
                End If
            End If

            If e.KeyCode = Keys.W Then
                clpPlayer.Top -= 10
                If clpPlayer.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox25.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox27.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox28.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox29.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox30.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox31.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox32.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox33.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox34.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox35.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox36.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox42.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox43.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox41.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox40.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox39.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox38.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox37.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox12.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox47.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox49.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox50.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox52.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox48.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox51.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox53.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox54.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox55.Bounds) Then
                    clpPlayer.Top += 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox56.Bounds) Then
                    clpPlayer.Top += 10
                End If
            End If

            If e.KeyCode = Keys.S Then
                clpPlayer.Top += 10
                If clpPlayer.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox25.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox27.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox28.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox29.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox30.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox31.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox32.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox33.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox34.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox35.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox36.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox42.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox43.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox41.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox40.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox39.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox38.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox37.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox12.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox47.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox49.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox50.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox52.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox48.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox51.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox53.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox54.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox55.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox56.Bounds) Then
                    clpPlayer.Top -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox8.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox25.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox27.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox28.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox29.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox30.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox31.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox32.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox33.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox34.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox35.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox36.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox42.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox43.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox44.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox45.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox46.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox41.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox40.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox39.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox38.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox37.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox18.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox19.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox15.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox21.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox22.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox24.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox13.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox16.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox12.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox10.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox11.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox9.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox47.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox49.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox50.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox52.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox48.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox51.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox53.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox54.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox55.Bounds) Then
                    clpPlayer.Left -= 10
                ElseIf clpPlayer.Bounds.IntersectsWith(PictureBox56.Bounds) Then
                    clpPlayer.Left -= 10
                End If
            End If
        End If
    End Sub

    Private Sub Medium2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScore.Text = intScore
        lblLives.Text = intLives
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' makes red squares move. The picturebox number corresponds with each red box
        ' adds 1 to score whenever a star is collected
        lblScore.Text = intScore

        If bolStopMoving = False Then ' if the game is not over, move red boxes

            ' picturebox 70
            If bol70Right = True Then
                PictureBox70.Left += 3
                If PictureBox70.Location.X > 78 Then
                    PictureBox70.Left = 78
                    bol70Right = False
                End If
            End If

            If bol70Right = False Then
                PictureBox70.Left -= 3
                If PictureBox70.Location.X < 22 Then
                    PictureBox70.Left = 22
                    bol70Right = True
                End If
            End If

            ' picturebox 61
            If bol61Right = True Then
                PictureBox61.Left += 5
                If PictureBox61.Location.X > 238 Then
                    PictureBox61.Left = 238
                    bol61Right = False
                End If
            End If

            If bol61Right = False Then
                PictureBox61.Left -= 5
                If PictureBox61.Location.X < 22 Then
                    PictureBox61.Left = 22
                    bol61Right = True
                End If
            End If

            ' picturebox 64
            If bol64Right = True Then
                PictureBox64.Left += 7
                If PictureBox64.Location.X > 167 Then
                    PictureBox64.Left = 167
                    bol64Right = False
                End If
            End If

            If bol64Right = False Then
                PictureBox64.Left -= 7
                If PictureBox64.Location.X < 22 Then
                    PictureBox64.Left = 22
                    bol64Right = True
                End If
            End If

            'picturebox 65
            If bol65Right = True Then
                PictureBox65.Left += 4
                If PictureBox65.Location.X > 239 Then
                    PictureBox65.Left = 239
                    bol65Right = False
                End If
            End If

            If bol65Right = False Then
                PictureBox65.Left -= 4
                If PictureBox65.Location.X < 22 Then
                    PictureBox65.Left = 22
                    bol65Right = True
                End If
            End If

            ' picturebox 62
            If bol62Right = True Then
                PictureBox62.Left += 5
                If PictureBox62.Location.X > 497 Then
                    PictureBox62.Left = 497
                    bol62Right = False
                End If
            End If

            If bol62Right = False Then
                PictureBox62.Left -= 5
                If PictureBox62.Location.X < 239 Then
                    PictureBox62.Left = 239
                    bol62Right = True
                End If
            End If

            ' picturebox 87
            If Bol87Down = True Then
                PictureBox87.Top += 4
                If PictureBox87.Location.Y > 164 Then
                    PictureBox87.Top = 164
                    Bol87Down = False
                End If
            End If

            If Bol87Down = False Then
                PictureBox87.Top -= 4
                If PictureBox87.Location.Y < 56 Then
                    PictureBox87.Top = 56
                    Bol87Down = True
                End If
            End If

            ' picturebox 88
            If bol88Down = True Then
                PictureBox88.Top += 4
                If PictureBox88.Location.Y > 114 Then
                    PictureBox88.Top = 114
                    bol88Down = False
                End If
            End If

            If bol88Down = False Then
                PictureBox88.Top -= 4
                If PictureBox88.Location.Y < 26 Then
                    PictureBox88.Top = 26
                    bol88Down = True
                End If
            End If

            ' picturebox 89
            If bol89Down = True Then
                PictureBox89.Top += 4
                If PictureBox89.Location.Y > 114 Then
                    PictureBox89.Top = 114
                    bol89Down = False
                End If
            End If

            If bol89Down = False Then
                PictureBox89.Top -= 4
                If PictureBox89.Location.Y < 26 Then
                    PictureBox89.Top = 26
                    bol89Down = True
                End If
            End If

            ' picturebox 58
            If bol58Down = True Then
                PictureBox58.Top += 4
                If PictureBox58.Location.Y > 389 Then
                    PictureBox58.Top = 389
                    bol58Down = False
                End If
            End If

            If bol58Down = False Then
                PictureBox58.Top -= 4
                If PictureBox58.Location.Y < 330 Then
                    PictureBox58.Top = 330
                    bol58Down = True
                End If
            End If

            ' picturebox 68
            If bol68Right = True Then
                PictureBox68.Left += 5
                If PictureBox68.Location.X > 271 Then
                    PictureBox68.Left = 271
                    bol68Right = False
                End If
            End If

            If bol68Right = False Then
                PictureBox68.Left -= 5
                If PictureBox68.Location.X < 120 Then
                    PictureBox68.Left = 120
                    bol68Right = True
                End If
            End If


            ' picturebox 67
            If bol67Down = True Then
                PictureBox67.Top += 4
                If PictureBox67.Location.Y > 475 Then
                    PictureBox67.Top = 475
                    bol67Down = False
                End If
            End If

            If bol67Down = False Then
                PictureBox67.Top -= 4
                If PictureBox67.Location.Y < 345 Then
                    PictureBox67.Top = 345
                    bol67Down = True
                End If
            End If

            ' picturebox 73
            If bol73Right = True Then
                PictureBox73.Left += 5
                If PictureBox73.Location.X > 370 Then
                    PictureBox73.Left = 370
                    bol73Right = False
                End If
            End If

            If bol73Right = False Then
                PictureBox73.Left -= 5
                If PictureBox73.Location.X < 160 Then
                    PictureBox73.Left = 160
                    bol73Right = True
                End If
            End If

            ' picturebox 75
            If bol75Right = True Then
                PictureBox75.Left += 3
                If PictureBox75.Location.X > 655 Then
                    PictureBox75.Left = 655
                    bol75Right = False
                End If
            End If

            If bol75Right = False Then
                PictureBox75.Left -= 3
                If PictureBox75.Location.X < 473 Then
                    PictureBox75.Left = 473
                    bol75Right = True
                End If
            End If

            ' picturebox 76
            If bol76Down = True Then
                PictureBox76.Top += 4
                If PictureBox76.Location.Y > 504 Then
                    PictureBox76.Top = 504
                    bol76Down = False
                End If
            End If

            If bol76Down = False Then
                PictureBox76.Top -= 4
                If PictureBox76.Location.Y < 434 Then
                    PictureBox76.Top = 434
                    bol76Down = True
                End If
            End If

            ' picturebox 74
            If bol74Down = True Then
                PictureBox74.Top += 4
                If PictureBox74.Location.Y > 504 Then
                    PictureBox74.Top = 504
                    bol74Down = False
                End If
            End If

            If bol74Down = False Then
                PictureBox74.Top -= 4
                If PictureBox74.Location.Y < 376 Then
                    PictureBox74.Top = 376
                    bol74Down = True
                End If
            End If

            ' picturebox 71
            If bol71Right = True Then
                PictureBox71.Left += 5
                If PictureBox71.Location.X > 670 Then
                    PictureBox71.Left = 670
                    bol71Right = False
                End If
            End If

            If bol71Right = False Then
                PictureBox71.Left -= 5
                If PictureBox71.Location.X < 557 Then
                    PictureBox71.Left = 557
                    bol71Right = True
                End If
            End If

            ' picturebox 86
            If bol86Down = True Then
                PictureBox86.Top += 4
                If PictureBox86.Location.Y > 356 Then
                    PictureBox86.Top = 356
                    bol86Down = False
                End If
            End If

            If bol86Down = False Then
                PictureBox86.Top -= 4
                If PictureBox86.Location.Y < 283 Then
                    PictureBox86.Top = 283
                    bol86Down = True
                End If
            End If

            ' picturebox 85
            If bol85Right = True Then
                PictureBox85.Left += 5
                If PictureBox85.Location.X > 670 Then
                    PictureBox85.Left = 670
                    bol85Right = False
                End If
            End If

            If bol85Right = False Then
                PictureBox85.Left -= 5
                If PictureBox85.Location.X < 557 Then
                    PictureBox85.Left = 557
                    bol85Right = True
                End If
            End If

            ' picturebox 72
            If bol72Down = True Then
                PictureBox72.Top += 5
                If PictureBox72.Location.Y > 403 Then
                    PictureBox72.Top = 403
                    bol72Down = False
                End If
            End If

            If bol72Down = False Then
                PictureBox72.Top -= 5
                If PictureBox72.Location.Y < 206 Then
                    PictureBox72.Top = 206
                    bol72Down = True
                End If
            End If

            ' picturebox 60
            If bol60Down = True Then
                PictureBox60.Top += 6
                If PictureBox60.Location.Y > 137 Then
                    PictureBox60.Top = 137
                    bol60Down = False
                End If
            End If

            If bol60Down = False Then
                PictureBox60.Top -= 5
                If PictureBox60.Location.Y < 70 Then
                    PictureBox60.Top = 70
                    bol60Down = True
                End If
            End If

            ' picturebox 57
            If bol57Down = True Then
                PictureBox57.Top += 6
                If PictureBox57.Location.Y > 206 Then
                    PictureBox57.Top = 206
                    bol57Down = False
                End If
            End If

            If bol57Down = False Then
                PictureBox57.Top -= 5
                If PictureBox57.Location.Y < 130 Then
                    PictureBox57.Top = 130
                    bol57Down = True
                End If
            End If

            ' picturebox 69
            If bol69Right = True Then
                PictureBox69.Left += 5
                If PictureBox69.Location.X > 621 Then
                    PictureBox69.Left = 621
                    bol69Right = False
                End If
            End If

            If bol69Right = False Then
                PictureBox69.Left -= 5
                If PictureBox69.Location.X < 530 Then
                    PictureBox69.Left = 530
                    bol69Right = True
                End If
            End If

            ' picturebox 63
            If bol63Right = True Then
                PictureBox63.Left += 5
                If PictureBox63.Location.X > 469 Then
                    PictureBox63.Left = 469
                    bol63Right = False
                End If
            End If

            If bol63Right = False Then
                PictureBox63.Left -= 5
                If PictureBox63.Location.X < 427 Then
                    PictureBox63.Left = 427
                    bol63Right = True
                End If
            End If

            ' picturebox 66
            If bol66Right = True Then
                PictureBox66.Left += 5
                If PictureBox66.Location.X > 548 Then
                    PictureBox66.Left = 548
                    bol66Right = False
                End If
            End If

            If bol66Right = False Then
                PictureBox66.Left -= 5
                If PictureBox66.Location.X < 428 Then
                    PictureBox66.Left = 428
                    bol66Right = True
                End If
            End If
        End If

        ' *** If red square is touched, lose a life, reset player back to start position
        ' x and y values where the player starts
        Dim intX As Integer = 51
        Dim intY As Integer = 32

        If PictureBox70.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox61.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox64.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox65.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox62.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox87.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox88.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox89.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox58.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox67.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox68.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox73.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox75.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox76.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox74.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox71.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox86.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox85.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox72.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox60.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox57.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox69.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox63.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If
        If PictureBox66.Bounds.IntersectsWith(clpPlayer.Bounds) Then
            clpPlayer.Location = New Point(51, 32) ' return player back
            intLives -= 1
            lblLives.Text = intLives
            If intLives = 0 Then
                MessageBox.Show("You lose!" & vbNewLine & "Click the screen to try again.", "Lose")
                bolLose = True
            End If
        End If

        ' *** if player intersects with stars, add 1 to score and make star dissapear
        If clpPlayer.Bounds.IntersectsWith(clpStar1.Bounds) And clpStar1.Visible = True Then
            clpStar1.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar2.Bounds) And clpStar2.Visible = True Then
            clpStar2.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar3.Bounds) And clpStar3.Visible = True Then
            clpStar3.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar4.Bounds) And clpStar4.Visible = True Then
            clpStar4.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar5.Bounds) And clpStar5.Visible = True Then
            clpStar5.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar6.Bounds) And clpStar6.Visible = True Then
            clpStar6.Visible = False
            intStar += 1
        End If
        If clpPlayer.Bounds.IntersectsWith(clpStar7.Bounds) And clpStar7.Visible = True Then
            clpStar7.Visible = False
            intStar += 1
        End If

        ' if player gets all stars and finishes level
        If clpPlayer.Bounds.IntersectsWith(clpFinish.Bounds) And intStar = 7 Then
            MessageBox.Show("You win!")
            btnEndGame.Visible = True
            btnContinue.Visible = True
            bolStopMoving = True
            If bolLost = False Then
                intScore = intScore + (intStar * 2)
            Else
                intScore = intScore + intStar
            End If
        End If
    End Sub

    Private Sub Medium2_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ' click to reset, gives 5 lives back, and allows you to move again. Sets bolLost to true
        If bolLose = True Then
            intLives = 5
            lblLives.Text = intLives
            bolLose = False
            bolLost = True
        End If
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

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' open next level, close this level
        Dim oMediumCongrats As MediumCongrats
        oMediumCongrats = New MediumCongrats
        oMediumCongrats.Show()
        oMediumCongrats = Nothing
        Me.Close()
    End Sub
End Class