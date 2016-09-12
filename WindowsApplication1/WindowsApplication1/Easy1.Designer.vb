<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Easy1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Easy1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clpElephant = New System.Windows.Forms.PictureBox()
        Me.clpLion = New System.Windows.Forms.PictureBox()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.clpElephant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpLion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Which of these animals is an elephant?"
        '
        'clpElephant
        '
        Me.clpElephant.Image = CType(resources.GetObject("clpElephant.Image"), System.Drawing.Image)
        Me.clpElephant.Location = New System.Drawing.Point(39, 139)
        Me.clpElephant.Name = "clpElephant"
        Me.clpElephant.Size = New System.Drawing.Size(184, 132)
        Me.clpElephant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpElephant.TabIndex = 2
        Me.clpElephant.TabStop = False
        '
        'clpLion
        '
        Me.clpLion.Image = CType(resources.GetObject("clpLion.Image"), System.Drawing.Image)
        Me.clpLion.Location = New System.Drawing.Point(250, 139)
        Me.clpLion.Name = "clpLion"
        Me.clpLion.Size = New System.Drawing.Size(207, 132)
        Me.clpLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpLion.TabIndex = 3
        Me.clpLion.TabStop = False
        '
        'btnNextLevel
        '
        Me.btnNextLevel.Location = New System.Drawing.Point(351, 287)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(116, 42)
        Me.btnNextLevel.TabIndex = 4
        Me.btnNextLevel.Text = "Go to Next Level!"
        Me.btnNextLevel.UseVisualStyleBackColor = True
        Me.btnNextLevel.Visible = False
        '
        'btnEnd
        '
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.Location = New System.Drawing.Point(12, 287)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(116, 42)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "End Game"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(454, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(13, 13)
        Me.lblScore.TabIndex = 7
        Me.lblScore.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Worth: 1 Point"
        '
        'Easy1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(479, 341)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.clpLion)
        Me.Controls.Add(Me.clpElephant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Easy1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 1 - Game"
        CType(Me.clpElephant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpLion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clpElephant As System.Windows.Forms.PictureBox
    Friend WithEvents clpLion As System.Windows.Forms.PictureBox
    Friend WithEvents btnNextLevel As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
