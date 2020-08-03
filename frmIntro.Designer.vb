<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.timGhosts = New System.Windows.Forms.Timer(Me.components)
        Me.picBlinky = New System.Windows.Forms.PictureBox()
        Me.picPinky = New System.Windows.Forms.PictureBox()
        Me.picClyde = New System.Windows.Forms.PictureBox()
        Me.picInky = New System.Windows.Forms.PictureBox()
        Me.lblBlinky = New System.Windows.Forms.Label()
        Me.lblPinky = New System.Windows.Forms.Label()
        Me.lblInky = New System.Windows.Forms.Label()
        Me.lblClyde = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPinky, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClyde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInky, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(27, 290)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(241, 106)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PacMan.My.Resources.Resources.pacman_title
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(577, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnInstructions
        '
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.Color.White
        Me.btnInstructions.Location = New System.Drawing.Point(325, 290)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(249, 106)
        Me.btnInstructions.TabIndex = 2
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'timGhosts
        '
        Me.timGhosts.Enabled = True
        Me.timGhosts.Interval = 1
        '
        'picBlinky
        '
        Me.picBlinky.BackColor = System.Drawing.Color.Black
        Me.picBlinky.Image = CType(resources.GetObject("picBlinky.Image"), System.Drawing.Image)
        Me.picBlinky.Location = New System.Drawing.Point(291, 157)
        Me.picBlinky.Name = "picBlinky"
        Me.picBlinky.Size = New System.Drawing.Size(25, 25)
        Me.picBlinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlinky.TabIndex = 9
        Me.picBlinky.TabStop = False
        '
        'picPinky
        '
        Me.picPinky.BackColor = System.Drawing.Color.Black
        Me.picPinky.Image = CType(resources.GetObject("picPinky.Image"), System.Drawing.Image)
        Me.picPinky.Location = New System.Drawing.Point(291, 231)
        Me.picPinky.Name = "picPinky"
        Me.picPinky.Size = New System.Drawing.Size(25, 25)
        Me.picPinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPinky.TabIndex = 8
        Me.picPinky.TabStop = False
        '
        'picClyde
        '
        Me.picClyde.BackColor = System.Drawing.Color.Black
        Me.picClyde.Image = CType(resources.GetObject("picClyde.Image"), System.Drawing.Image)
        Me.picClyde.Location = New System.Drawing.Point(316, 231)
        Me.picClyde.Name = "picClyde"
        Me.picClyde.Size = New System.Drawing.Size(25, 25)
        Me.picClyde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClyde.TabIndex = 7
        Me.picClyde.TabStop = False
        '
        'picInky
        '
        Me.picInky.BackColor = System.Drawing.Color.Black
        Me.picInky.Image = CType(resources.GetObject("picInky.Image"), System.Drawing.Image)
        Me.picInky.Location = New System.Drawing.Point(265, 231)
        Me.picInky.Name = "picInky"
        Me.picInky.Size = New System.Drawing.Size(25, 25)
        Me.picInky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInky.TabIndex = 6
        Me.picInky.TabStop = False
        '
        'lblBlinky
        '
        Me.lblBlinky.AutoSize = True
        Me.lblBlinky.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlinky.ForeColor = System.Drawing.Color.White
        Me.lblBlinky.Location = New System.Drawing.Point(483, 143)
        Me.lblBlinky.Name = "lblBlinky"
        Me.lblBlinky.Size = New System.Drawing.Size(59, 24)
        Me.lblBlinky.TabIndex = 10
        Me.lblBlinky.Text = "Blinky"
        Me.lblBlinky.Visible = False
        '
        'lblPinky
        '
        Me.lblPinky.AutoSize = True
        Me.lblPinky.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPinky.ForeColor = System.Drawing.Color.White
        Me.lblPinky.Location = New System.Drawing.Point(483, 180)
        Me.lblPinky.Name = "lblPinky"
        Me.lblPinky.Size = New System.Drawing.Size(55, 24)
        Me.lblPinky.TabIndex = 11
        Me.lblPinky.Text = "Pinky"
        Me.lblPinky.Visible = False
        '
        'lblInky
        '
        Me.lblInky.AutoSize = True
        Me.lblInky.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInky.ForeColor = System.Drawing.Color.White
        Me.lblInky.Location = New System.Drawing.Point(483, 221)
        Me.lblInky.Name = "lblInky"
        Me.lblInky.Size = New System.Drawing.Size(43, 24)
        Me.lblInky.TabIndex = 12
        Me.lblInky.Text = "Inky"
        Me.lblInky.Visible = False
        '
        'lblClyde
        '
        Me.lblClyde.AutoSize = True
        Me.lblClyde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClyde.ForeColor = System.Drawing.Color.White
        Me.lblClyde.Location = New System.Drawing.Point(483, 254)
        Me.lblClyde.Name = "lblClyde"
        Me.lblClyde.Size = New System.Drawing.Size(58, 24)
        Me.lblClyde.TabIndex = 13
        Me.lblClyde.Text = "Clyde"
        Me.lblClyde.Visible = False
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(601, 408)
        Me.Controls.Add(Me.lblClyde)
        Me.Controls.Add(Me.lblInky)
        Me.Controls.Add(Me.lblPinky)
        Me.Controls.Add(Me.lblBlinky)
        Me.Controls.Add(Me.picBlinky)
        Me.Controls.Add(Me.picPinky)
        Me.Controls.Add(Me.picClyde)
        Me.Controls.Add(Me.picInky)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmIntro"
        Me.Text = "frmIntro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPinky, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClyde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInky, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents timGhosts As System.Windows.Forms.Timer
    Friend WithEvents picBlinky As System.Windows.Forms.PictureBox
    Friend WithEvents picPinky As System.Windows.Forms.PictureBox
    Friend WithEvents picClyde As System.Windows.Forms.PictureBox
    Friend WithEvents picInky As System.Windows.Forms.PictureBox
    Friend WithEvents lblBlinky As System.Windows.Forms.Label
    Friend WithEvents lblPinky As System.Windows.Forms.Label
    Friend WithEvents lblInky As System.Windows.Forms.Label
    Friend WithEvents lblClyde As System.Windows.Forms.Label
End Class
