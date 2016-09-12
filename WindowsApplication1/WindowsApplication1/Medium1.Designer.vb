<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medium1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.clpPaddlePlayer = New System.Windows.Forms.PictureBox()
        Me.clpPaddleComputer = New System.Windows.Forms.PictureBox()
        Me.clpBall = New System.Windows.Forms.PictureBox()
        Me.lblScorePlayer = New System.Windows.Forms.Label()
        Me.lblScoreComputer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        CType(Me.clpPaddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpPaddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timGameTimer
        '
        Me.timGameTimer.Interval = 20
        '
        'clpPaddlePlayer
        '
        Me.clpPaddlePlayer.BackColor = System.Drawing.Color.White
        Me.clpPaddlePlayer.Location = New System.Drawing.Point(12, 138)
        Me.clpPaddlePlayer.Name = "clpPaddlePlayer"
        Me.clpPaddlePlayer.Size = New System.Drawing.Size(16, 128)
        Me.clpPaddlePlayer.TabIndex = 0
        Me.clpPaddlePlayer.TabStop = False
        '
        'clpPaddleComputer
        '
        Me.clpPaddleComputer.BackColor = System.Drawing.Color.White
        Me.clpPaddleComputer.Location = New System.Drawing.Point(592, 138)
        Me.clpPaddleComputer.Name = "clpPaddleComputer"
        Me.clpPaddleComputer.Size = New System.Drawing.Size(16, 128)
        Me.clpPaddleComputer.TabIndex = 1
        Me.clpPaddleComputer.TabStop = False
        '
        'clpBall
        '
        Me.clpBall.BackColor = System.Drawing.Color.White
        Me.clpBall.Location = New System.Drawing.Point(308, 168)
        Me.clpBall.Name = "clpBall"
        Me.clpBall.Size = New System.Drawing.Size(20, 20)
        Me.clpBall.TabIndex = 2
        Me.clpBall.TabStop = False
        Me.clpBall.Visible = False
        '
        'lblScorePlayer
        '
        Me.lblScorePlayer.AutoSize = True
        Me.lblScorePlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScorePlayer.ForeColor = System.Drawing.Color.White
        Me.lblScorePlayer.Location = New System.Drawing.Point(296, 12)
        Me.lblScorePlayer.Name = "lblScorePlayer"
        Me.lblScorePlayer.Size = New System.Drawing.Size(15, 16)
        Me.lblScorePlayer.TabIndex = 3
        Me.lblScorePlayer.Text = "0"
        '
        'lblScoreComputer
        '
        Me.lblScoreComputer.AutoSize = True
        Me.lblScoreComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreComputer.ForeColor = System.Drawing.Color.White
        Me.lblScoreComputer.Location = New System.Drawing.Point(325, 12)
        Me.lblScoreComputer.Name = "lblScoreComputer"
        Me.lblScoreComputer.Size = New System.Drawing.Size(15, 16)
        Me.lblScoreComputer.TabIndex = 4
        Me.lblScoreComputer.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(317, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1, 300)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnNextLevel
        '
        Me.btnNextLevel.Location = New System.Drawing.Point(496, 388)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(116, 42)
        Me.btnNextLevel.TabIndex = 6
        Me.btnNextLevel.Text = "Go to Next Level!"
        Me.btnNextLevel.UseVisualStyleBackColor = True
        Me.btnNextLevel.Visible = False
        '
        'btnEndGame
        '
        Me.btnEndGame.Location = New System.Drawing.Point(12, 388)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(116, 42)
        Me.btnEndGame.TabIndex = 7
        Me.btnEndGame.Text = "End Game"
        Me.btnEndGame.UseVisualStyleBackColor = True
        Me.btnEndGame.Visible = False
        '
        'btnRetry
        '
        Me.btnRetry.Location = New System.Drawing.Point(496, 388)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(116, 42)
        Me.btnRetry.TabIndex = 8
        Me.btnRetry.Text = "Retry"
        Me.btnRetry.UseVisualStyleBackColor = True
        Me.btnRetry.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(259, 168)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(116, 42)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Medium1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.btnEndGame)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblScoreComputer)
        Me.Controls.Add(Me.lblScorePlayer)
        Me.Controls.Add(Me.clpBall)
        Me.Controls.Add(Me.clpPaddleComputer)
        Me.Controls.Add(Me.clpPaddlePlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Medium1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 1 - Game"
        CType(Me.clpPaddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpPaddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timGameTimer As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents clpPaddlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents clpPaddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents clpBall As System.Windows.Forms.PictureBox
    Friend WithEvents lblScorePlayer As System.Windows.Forms.Label
    Friend WithEvents lblScoreComputer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNextLevel As System.Windows.Forms.Button
    Friend WithEvents btnEndGame As System.Windows.Forms.Button
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
End Class
