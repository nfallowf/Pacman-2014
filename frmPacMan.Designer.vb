<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacMan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacMan))
        Me.timLeft = New System.Windows.Forms.Timer(Me.components)
        Me.timUp = New System.Windows.Forms.Timer(Me.components)
        Me.timRight = New System.Windows.Forms.Timer(Me.components)
        Me.timDown = New System.Windows.Forms.Timer(Me.components)
        Me.timCount = New System.Windows.Forms.Timer(Me.components)
        Me.timBlinky = New System.Windows.Forms.Timer(Me.components)
        Me.timInky = New System.Windows.Forms.Timer(Me.components)
        Me.timClyde = New System.Windows.Forms.Timer(Me.components)
        Me.timPinky = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.timEatBadGuys = New System.Windows.Forms.Timer(Me.components)
        Me.timBlinkyBack = New System.Windows.Forms.Timer(Me.components)
        Me.timPinkyBack = New System.Windows.Forms.Timer(Me.components)
        Me.timInkyBack = New System.Windows.Forms.Timer(Me.components)
        Me.timClydeBack = New System.Windows.Forms.Timer(Me.components)
        Me.lblYourScore = New System.Windows.Forms.Label()
        Me.lblYourLevel = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.picLive2 = New System.Windows.Forms.PictureBox()
        Me.picLive3 = New System.Windows.Forms.PictureBox()
        Me.picLive1 = New System.Windows.Forms.PictureBox()
        Me.picBlinky = New System.Windows.Forms.PictureBox()
        Me.picPinky = New System.Windows.Forms.PictureBox()
        Me.picClyde = New System.Windows.Forms.PictureBox()
        Me.picInky = New System.Windows.Forms.PictureBox()
        Me.picPacMan = New System.Windows.Forms.PictureBox()
        Me.picBoard = New System.Windows.Forms.PictureBox()
        Me.picFruit = New System.Windows.Forms.PictureBox()
        Me.timFruit = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLive2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLive3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLive1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClyde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPacMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timLeft
        '
        Me.timLeft.Interval = 140
        '
        'timUp
        '
        Me.timUp.Interval = 140
        '
        'timRight
        '
        Me.timRight.Interval = 140
        '
        'timDown
        '
        Me.timDown.Interval = 140
        '
        'timCount
        '
        Me.timCount.Enabled = True
        Me.timCount.Interval = 1000
        '
        'timBlinky
        '
        Me.timBlinky.Enabled = True
        Me.timBlinky.Interval = 250
        '
        'timInky
        '
        Me.timInky.Interval = 250
        '
        'timClyde
        '
        Me.timClyde.Interval = 300
        '
        'timPinky
        '
        Me.timPinky.Interval = 280
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(482, 44)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(158, 24)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.White
        Me.lblLives.Location = New System.Drawing.Point(482, 590)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(58, 24)
        Me.lblLives.TabIndex = 7
        Me.lblLives.Text = "Lives:"
        '
        'timEatBadGuys
        '
        Me.timEatBadGuys.Interval = 1000
        '
        'timBlinkyBack
        '
        Me.timBlinkyBack.Interval = 150
        '
        'timPinkyBack
        '
        Me.timPinkyBack.Interval = 150
        '
        'timInkyBack
        '
        Me.timInkyBack.Interval = 150
        '
        'timClydeBack
        '
        Me.timClydeBack.Interval = 150
        '
        'lblYourScore
        '
        Me.lblYourScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourScore.ForeColor = System.Drawing.Color.White
        Me.lblYourScore.Location = New System.Drawing.Point(482, 9)
        Me.lblYourScore.Name = "lblYourScore"
        Me.lblYourScore.Size = New System.Drawing.Size(158, 23)
        Me.lblYourScore.TabIndex = 11
        Me.lblYourScore.Text = "Your Score:"
        Me.lblYourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYourLevel
        '
        Me.lblYourLevel.AutoSize = True
        Me.lblYourLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourLevel.ForeColor = System.Drawing.Color.White
        Me.lblYourLevel.Location = New System.Drawing.Point(510, 98)
        Me.lblYourLevel.Name = "lblYourLevel"
        Me.lblYourLevel.Size = New System.Drawing.Size(70, 26)
        Me.lblYourLevel.TabIndex = 12
        Me.lblYourLevel.Text = "Level:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(586, 98)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(24, 26)
        Me.lblLevel.TabIndex = 13
        Me.lblLevel.Text = "1"
        '
        'picLive2
        '
        Me.picLive2.Image = Global.PacMan.My.Resources.Resources.piepacman
        Me.picLive2.Location = New System.Drawing.Point(574, 590)
        Me.picLive2.Name = "picLive2"
        Me.picLive2.Size = New System.Drawing.Size(30, 24)
        Me.picLive2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLive2.TabIndex = 10
        Me.picLive2.TabStop = False
        '
        'picLive3
        '
        Me.picLive3.Image = Global.PacMan.My.Resources.Resources.piepacman
        Me.picLive3.Location = New System.Drawing.Point(610, 590)
        Me.picLive3.Name = "picLive3"
        Me.picLive3.Size = New System.Drawing.Size(30, 24)
        Me.picLive3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLive3.TabIndex = 9
        Me.picLive3.TabStop = False
        '
        'picLive1
        '
        Me.picLive1.Image = Global.PacMan.My.Resources.Resources.piepacman
        Me.picLive1.Location = New System.Drawing.Point(538, 590)
        Me.picLive1.Name = "picLive1"
        Me.picLive1.Size = New System.Drawing.Size(30, 24)
        Me.picLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLive1.TabIndex = 8
        Me.picLive1.TabStop = False
        '
        'picBlinky
        '
        Me.picBlinky.BackColor = System.Drawing.Color.Black
        Me.picBlinky.Image = CType(resources.GetObject("picBlinky.Image"), System.Drawing.Image)
        Me.picBlinky.Location = New System.Drawing.Point(228, 230)
        Me.picBlinky.Name = "picBlinky"
        Me.picBlinky.Size = New System.Drawing.Size(20, 20)
        Me.picBlinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlinky.TabIndex = 5
        Me.picBlinky.TabStop = False
        '
        'picPinky
        '
        Me.picPinky.BackColor = System.Drawing.Color.Black
        Me.picPinky.Image = CType(resources.GetObject("picPinky.Image"), System.Drawing.Image)
        Me.picPinky.Location = New System.Drawing.Point(228, 304)
        Me.picPinky.Name = "picPinky"
        Me.picPinky.Size = New System.Drawing.Size(20, 20)
        Me.picPinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPinky.TabIndex = 4
        Me.picPinky.TabStop = False
        '
        'picClyde
        '
        Me.picClyde.BackColor = System.Drawing.Color.Black
        Me.picClyde.Image = CType(resources.GetObject("picClyde.Image"), System.Drawing.Image)
        Me.picClyde.Location = New System.Drawing.Point(253, 304)
        Me.picClyde.Name = "picClyde"
        Me.picClyde.Size = New System.Drawing.Size(20, 20)
        Me.picClyde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClyde.TabIndex = 3
        Me.picClyde.TabStop = False
        '
        'picInky
        '
        Me.picInky.BackColor = System.Drawing.Color.Black
        Me.picInky.Image = CType(resources.GetObject("picInky.Image"), System.Drawing.Image)
        Me.picInky.Location = New System.Drawing.Point(202, 304)
        Me.picInky.Name = "picInky"
        Me.picInky.Size = New System.Drawing.Size(20, 20)
        Me.picInky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInky.TabIndex = 2
        Me.picInky.TabStop = False
        '
        'picPacMan
        '
        Me.picPacMan.BackColor = System.Drawing.Color.Black
        Me.picPacMan.Image = Global.PacMan.My.Resources.Resources.Right2
        Me.picPacMan.Location = New System.Drawing.Point(228, 478)
        Me.picPacMan.Name = "picPacMan"
        Me.picPacMan.Size = New System.Drawing.Size(20, 20)
        Me.picPacMan.TabIndex = 1
        Me.picPacMan.TabStop = False
        '
        'picBoard
        '
        Me.picBoard.BackColor = System.Drawing.Color.Black
        Me.picBoard.Image = Global.PacMan.My.Resources.Resources.WhiteBoardV2Done_copy
        Me.picBoard.Location = New System.Drawing.Point(1, 1)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(475, 625)
        Me.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard.TabIndex = 0
        Me.picBoard.TabStop = False
        '
        'picFruit
        '
        Me.picFruit.Location = New System.Drawing.Point(227, 353)
        Me.picFruit.Name = "picFruit"
        Me.picFruit.Size = New System.Drawing.Size(20, 20)
        Me.picFruit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruit.TabIndex = 14
        Me.picFruit.TabStop = False
        Me.picFruit.Visible = False
        '
        'timFruit
        '
        Me.timFruit.Enabled = True
        Me.timFruit.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(226, 259)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 10)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmPacMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(642, 623)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picFruit)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblYourLevel)
        Me.Controls.Add(Me.lblYourScore)
        Me.Controls.Add(Me.picLive2)
        Me.Controls.Add(Me.picLive3)
        Me.Controls.Add(Me.picLive1)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picBlinky)
        Me.Controls.Add(Me.picPinky)
        Me.Controls.Add(Me.picClyde)
        Me.Controls.Add(Me.picInky)
        Me.Controls.Add(Me.picPacMan)
        Me.Controls.Add(Me.picBoard)
        Me.Name = "frmPacMan"
        Me.Text = " "
        CType(Me.picLive2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLive3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLive1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClyde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPacMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFruit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBoard As System.Windows.Forms.PictureBox
    Friend WithEvents timLeft As System.Windows.Forms.Timer
    Friend WithEvents timUp As System.Windows.Forms.Timer
    Friend WithEvents timRight As System.Windows.Forms.Timer
    Friend WithEvents timDown As System.Windows.Forms.Timer
    Friend WithEvents picPacMan As System.Windows.Forms.PictureBox
    Friend WithEvents picInky As System.Windows.Forms.PictureBox
    Friend WithEvents picClyde As System.Windows.Forms.PictureBox
    Friend WithEvents picPinky As System.Windows.Forms.PictureBox
    Friend WithEvents picBlinky As System.Windows.Forms.PictureBox
    Friend WithEvents timCount As System.Windows.Forms.Timer
    Friend WithEvents timBlinky As System.Windows.Forms.Timer
    Friend WithEvents timInky As System.Windows.Forms.Timer
    Friend WithEvents timClyde As System.Windows.Forms.Timer
    Friend WithEvents timPinky As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents picLive1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLive3 As System.Windows.Forms.PictureBox
    Friend WithEvents picLive2 As System.Windows.Forms.PictureBox
    Friend WithEvents timEatBadGuys As System.Windows.Forms.Timer
    Friend WithEvents timBlinkyBack As System.Windows.Forms.Timer
    Friend WithEvents timPinkyBack As System.Windows.Forms.Timer
    Friend WithEvents timInkyBack As System.Windows.Forms.Timer
    Friend WithEvents timClydeBack As System.Windows.Forms.Timer
    Friend WithEvents lblYourScore As System.Windows.Forms.Label
    Friend WithEvents lblYourLevel As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents picFruit As System.Windows.Forms.PictureBox
    Friend WithEvents timFruit As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
