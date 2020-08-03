<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picArrowKeys = New System.Windows.Forms.PictureBox()
        Me.lblKeys = New System.Windows.Forms.Label()
        Me.picDot = New System.Windows.Forms.PictureBox()
        Me.lblDots = New System.Windows.Forms.Label()
        Me.picGhost = New System.Windows.Forms.PictureBox()
        Me.lblGhosts = New System.Windows.Forms.Label()
        Me.picPowerPills = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFriut = New System.Windows.Forms.PictureBox()
        Me.lblFruit = New System.Windows.Forms.Label()
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGhost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPowerPills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFriut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(12, 486)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(176, 73)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(297, 486)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(176, 73)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'picArrowKeys
        '
        Me.picArrowKeys.Image = Global.PacMan.My.Resources.Resources.arrow_keys
        Me.picArrowKeys.Location = New System.Drawing.Point(24, 24)
        Me.picArrowKeys.Name = "picArrowKeys"
        Me.picArrowKeys.Size = New System.Drawing.Size(127, 86)
        Me.picArrowKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrowKeys.TabIndex = 3
        Me.picArrowKeys.TabStop = False
        '
        'lblKeys
        '
        Me.lblKeys.AutoSize = True
        Me.lblKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeys.ForeColor = System.Drawing.Color.White
        Me.lblKeys.Location = New System.Drawing.Point(177, 33)
        Me.lblKeys.Name = "lblKeys"
        Me.lblKeys.Size = New System.Drawing.Size(204, 52)
        Me.lblKeys.TabIndex = 4
        Me.lblKeys.Text = "Use the arrow keys " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to control Pacman"
        '
        'picDot
        '
        Me.picDot.BackColor = System.Drawing.Color.White
        Me.picDot.Location = New System.Drawing.Point(81, 140)
        Me.picDot.Name = "picDot"
        Me.picDot.Size = New System.Drawing.Size(30, 34)
        Me.picDot.TabIndex = 5
        Me.picDot.TabStop = False
        '
        'lblDots
        '
        Me.lblDots.AutoSize = True
        Me.lblDots.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDots.ForeColor = System.Drawing.Color.White
        Me.lblDots.Location = New System.Drawing.Point(177, 131)
        Me.lblDots.Name = "lblDots"
        Me.lblDots.Size = New System.Drawing.Size(196, 52)
        Me.lblDots.TabIndex = 6
        Me.lblDots.Text = "Collect all the dots " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to pass the level" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picGhost
        '
        Me.picGhost.BackColor = System.Drawing.Color.Black
        Me.picGhost.Image = CType(resources.GetObject("picGhost.Image"), System.Drawing.Image)
        Me.picGhost.Location = New System.Drawing.Point(63, 212)
        Me.picGhost.Name = "picGhost"
        Me.picGhost.Size = New System.Drawing.Size(65, 67)
        Me.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGhost.TabIndex = 7
        Me.picGhost.TabStop = False
        '
        'lblGhosts
        '
        Me.lblGhosts.AutoSize = True
        Me.lblGhosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGhosts.ForeColor = System.Drawing.Color.White
        Me.lblGhosts.Location = New System.Drawing.Point(177, 218)
        Me.lblGhosts.Name = "lblGhosts"
        Me.lblGhosts.Size = New System.Drawing.Size(155, 52)
        Me.lblGhosts.TabIndex = 8
        Me.lblGhosts.Text = "Avoid touching" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ghosts"
        '
        'picPowerPills
        '
        Me.picPowerPills.BackColor = System.Drawing.Color.Yellow
        Me.picPowerPills.Location = New System.Drawing.Point(63, 303)
        Me.picPowerPills.Name = "picPowerPills"
        Me.picPowerPills.Size = New System.Drawing.Size(65, 65)
        Me.picPowerPills.TabIndex = 9
        Me.picPowerPills.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 52)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Collect Power Pills " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to eat the ghosts"
        '
        'picFriut
        '
        Me.picFriut.BackColor = System.Drawing.Color.Transparent
        Me.picFriut.Image = Global.PacMan.My.Resources.Resources.strawberry
        Me.picFriut.Location = New System.Drawing.Point(63, 406)
        Me.picFriut.Name = "picFriut"
        Me.picFriut.Size = New System.Drawing.Size(65, 65)
        Me.picFriut.TabIndex = 11
        Me.picFriut.TabStop = False
        '
        'lblFruit
        '
        Me.lblFruit.AutoSize = True
        Me.lblFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFruit.ForeColor = System.Drawing.Color.White
        Me.lblFruit.Location = New System.Drawing.Point(177, 410)
        Me.lblFruit.Name = "lblFruit"
        Me.lblFruit.Size = New System.Drawing.Size(158, 52)
        Me.lblFruit.TabIndex = 12
        Me.lblFruit.Text = "Collect fruit for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bonus points"
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(484, 568)
        Me.Controls.Add(Me.lblFruit)
        Me.Controls.Add(Me.picFriut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPowerPills)
        Me.Controls.Add(Me.lblGhosts)
        Me.Controls.Add(Me.picGhost)
        Me.Controls.Add(Me.lblDots)
        Me.Controls.Add(Me.picDot)
        Me.Controls.Add(Me.lblKeys)
        Me.Controls.Add(Me.picArrowKeys)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmInstructions"
        Me.Text = "frmInstructions"
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGhost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPowerPills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFriut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents picArrowKeys As System.Windows.Forms.PictureBox
    Friend WithEvents lblKeys As System.Windows.Forms.Label
    Friend WithEvents picDot As System.Windows.Forms.PictureBox
    Friend WithEvents lblDots As System.Windows.Forms.Label
    Friend WithEvents picGhost As System.Windows.Forms.PictureBox
    Friend WithEvents lblGhosts As System.Windows.Forms.Label
    Friend WithEvents picPowerPills As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picFriut As System.Windows.Forms.PictureBox
    Friend WithEvents lblFruit As System.Windows.Forms.Label
End Class
