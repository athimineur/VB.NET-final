<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Easy5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Easy5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.clpRedCircle = New System.Windows.Forms.PictureBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.clpRedSquare = New System.Windows.Forms.PictureBox()
        Me.clpBlueCircle = New System.Windows.Forms.PictureBox()
        Me.clpRedTrapezoid = New System.Windows.Forms.PictureBox()
        Me.clpGreenTriangle = New System.Windows.Forms.PictureBox()
        Me.clpPurpleCircle = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.clpRedCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpRedSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpBlueCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpRedTrapezoid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpGreenTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpPurpleCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level 5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(419, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(454, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(13, 13)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Only Click the Red Shapes"
        '
        'clpRedCircle
        '
        Me.clpRedCircle.Image = CType(resources.GetObject("clpRedCircle.Image"), System.Drawing.Image)
        Me.clpRedCircle.Location = New System.Drawing.Point(197, 142)
        Me.clpRedCircle.Name = "clpRedCircle"
        Me.clpRedCircle.Size = New System.Drawing.Size(116, 99)
        Me.clpRedCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpRedCircle.TabIndex = 4
        Me.clpRedCircle.TabStop = False
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(12, 287)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(116, 42)
        Me.btnEnd.TabIndex = 9
        Me.btnEnd.Text = "End Game"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnNextLevel
        '
        Me.btnNextLevel.Location = New System.Drawing.Point(351, 287)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(116, 42)
        Me.btnNextLevel.TabIndex = 10
        Me.btnNextLevel.Text = "Go to Next Level!"
        Me.btnNextLevel.UseVisualStyleBackColor = True
        Me.btnNextLevel.Visible = False
        '
        'clpRedSquare
        '
        Me.clpRedSquare.Image = CType(resources.GetObject("clpRedSquare.Image"), System.Drawing.Image)
        Me.clpRedSquare.Location = New System.Drawing.Point(370, 142)
        Me.clpRedSquare.Name = "clpRedSquare"
        Me.clpRedSquare.Size = New System.Drawing.Size(87, 81)
        Me.clpRedSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpRedSquare.TabIndex = 11
        Me.clpRedSquare.TabStop = False
        Me.clpRedSquare.Visible = False
        '
        'clpBlueCircle
        '
        Me.clpBlueCircle.Image = CType(resources.GetObject("clpBlueCircle.Image"), System.Drawing.Image)
        Me.clpBlueCircle.Location = New System.Drawing.Point(13, 128)
        Me.clpBlueCircle.Name = "clpBlueCircle"
        Me.clpBlueCircle.Size = New System.Drawing.Size(132, 124)
        Me.clpBlueCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpBlueCircle.TabIndex = 12
        Me.clpBlueCircle.TabStop = False
        Me.clpBlueCircle.Visible = False
        '
        'clpRedTrapezoid
        '
        Me.clpRedTrapezoid.Image = CType(resources.GetObject("clpRedTrapezoid.Image"), System.Drawing.Image)
        Me.clpRedTrapezoid.Location = New System.Drawing.Point(13, 25)
        Me.clpRedTrapezoid.Name = "clpRedTrapezoid"
        Me.clpRedTrapezoid.Size = New System.Drawing.Size(100, 68)
        Me.clpRedTrapezoid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpRedTrapezoid.TabIndex = 13
        Me.clpRedTrapezoid.TabStop = False
        Me.clpRedTrapezoid.Visible = False
        '
        'clpGreenTriangle
        '
        Me.clpGreenTriangle.Image = CType(resources.GetObject("clpGreenTriangle.Image"), System.Drawing.Image)
        Me.clpGreenTriangle.Location = New System.Drawing.Point(215, 146)
        Me.clpGreenTriangle.Name = "clpGreenTriangle"
        Me.clpGreenTriangle.Size = New System.Drawing.Size(73, 77)
        Me.clpGreenTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpGreenTriangle.TabIndex = 14
        Me.clpGreenTriangle.TabStop = False
        Me.clpGreenTriangle.Visible = False
        '
        'clpPurpleCircle
        '
        Me.clpPurpleCircle.Image = CType(resources.GetObject("clpPurpleCircle.Image"), System.Drawing.Image)
        Me.clpPurpleCircle.Location = New System.Drawing.Point(358, 163)
        Me.clpPurpleCircle.Name = "clpPurpleCircle"
        Me.clpPurpleCircle.Size = New System.Drawing.Size(99, 101)
        Me.clpPurpleCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpPurpleCircle.TabIndex = 15
        Me.clpPurpleCircle.TabStop = False
        Me.clpPurpleCircle.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Worth: 1 Point"
        '
        'Easy5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 341)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clpPurpleCircle)
        Me.Controls.Add(Me.clpGreenTriangle)
        Me.Controls.Add(Me.clpRedTrapezoid)
        Me.Controls.Add(Me.clpBlueCircle)
        Me.Controls.Add(Me.clpRedSquare)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.clpRedCircle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Easy5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 5 - Game"
        CType(Me.clpRedCircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpRedSquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpBlueCircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpRedTrapezoid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpGreenTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpPurpleCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clpRedCircle As System.Windows.Forms.PictureBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnNextLevel As System.Windows.Forms.Button
    Friend WithEvents clpRedSquare As System.Windows.Forms.PictureBox
    Friend WithEvents clpBlueCircle As System.Windows.Forms.PictureBox
    Friend WithEvents clpRedTrapezoid As System.Windows.Forms.PictureBox
    Friend WithEvents clpGreenTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents clpPurpleCircle As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
