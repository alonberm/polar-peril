<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.Shield0 = New System.Windows.Forms.PictureBox()
        Me.Nansen = New System.Windows.Forms.PictureBox()
        Me.Help = New System.Windows.Forms.PictureBox()
        Me.Penguin = New System.Windows.Forms.PictureBox()
        Me.Stack = New System.Windows.Forms.PictureBox()
        Me.Bob = New System.Windows.Forms.PictureBox()
        Me.Ball3 = New System.Windows.Forms.PictureBox()
        Me.Ball2 = New System.Windows.Forms.PictureBox()
        Me.Ball1 = New System.Windows.Forms.PictureBox()
        Me.Ball0 = New System.Windows.Forms.PictureBox()
        Me.Ladder5 = New System.Windows.Forms.PictureBox()
        Me.Ladder4 = New System.Windows.Forms.PictureBox()
        Me.Ladder3 = New System.Windows.Forms.PictureBox()
        Me.Ladder2 = New System.Windows.Forms.PictureBox()
        Me.Ladder1 = New System.Windows.Forms.PictureBox()
        Me.Ladder0 = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Shield1 = New System.Windows.Forms.PictureBox()
        Me.Shield2 = New System.Windows.Forms.PictureBox()
        Me.shieldIndication = New System.Windows.Forms.PictureBox()
        Me.GamePanel.SuspendLayout()
        CType(Me.Shield0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nansen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Penguin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ladder0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shield1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shield2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shieldIndication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GamePanel
        '
        Me.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GamePanel.Controls.Add(Me.shieldIndication)
        Me.GamePanel.Controls.Add(Me.Shield2)
        Me.GamePanel.Controls.Add(Me.Shield1)
        Me.GamePanel.Controls.Add(Me.Shield0)
        Me.GamePanel.Controls.Add(Me.Nansen)
        Me.GamePanel.Controls.Add(Me.Help)
        Me.GamePanel.Controls.Add(Me.Penguin)
        Me.GamePanel.Controls.Add(Me.Stack)
        Me.GamePanel.Controls.Add(Me.Bob)
        Me.GamePanel.Controls.Add(Me.Ball3)
        Me.GamePanel.Controls.Add(Me.Ball2)
        Me.GamePanel.Controls.Add(Me.Ball1)
        Me.GamePanel.Controls.Add(Me.Ball0)
        Me.GamePanel.Controls.Add(Me.Ladder5)
        Me.GamePanel.Controls.Add(Me.Ladder4)
        Me.GamePanel.Controls.Add(Me.Ladder3)
        Me.GamePanel.Controls.Add(Me.Ladder2)
        Me.GamePanel.Controls.Add(Me.Ladder1)
        Me.GamePanel.Controls.Add(Me.Ladder0)
        Me.GamePanel.Controls.Add(Me.Background)
        Me.GamePanel.Location = New System.Drawing.Point(0, 0)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(644, 483)
        Me.GamePanel.TabIndex = 0
        '
        'Shield0
        '
        Me.Shield0.BackColor = System.Drawing.Color.White
        Me.Shield0.Image = CType(resources.GetObject("Shield0.Image"), System.Drawing.Image)
        Me.Shield0.Location = New System.Drawing.Point(282, 435)
        Me.Shield0.Name = "Shield0"
        Me.Shield0.Size = New System.Drawing.Size(17, 19)
        Me.Shield0.TabIndex = 16
        Me.Shield0.TabStop = False
        '
        'Nansen
        '
        Me.Nansen.BackColor = System.Drawing.Color.Transparent
        Me.Nansen.Image = CType(resources.GetObject("Nansen.Image"), System.Drawing.Image)
        Me.Nansen.Location = New System.Drawing.Point(84, 435)
        Me.Nansen.Name = "Nansen"
        Me.Nansen.Size = New System.Drawing.Size(24, 34)
        Me.Nansen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Nansen.TabIndex = 0
        Me.Nansen.TabStop = False
        '
        'Help
        '
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.Location = New System.Drawing.Point(237, 0)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(51, 21)
        Me.Help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Help.TabIndex = 15
        Me.Help.TabStop = False
        '
        'Penguin
        '
        Me.Penguin.Image = CType(resources.GetObject("Penguin.Image"), System.Drawing.Image)
        Me.Penguin.Location = New System.Drawing.Point(204, 0)
        Me.Penguin.Name = "Penguin"
        Me.Penguin.Size = New System.Drawing.Size(30, 44)
        Me.Penguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Penguin.TabIndex = 14
        Me.Penguin.TabStop = False
        '
        'Stack
        '
        Me.Stack.Image = CType(resources.GetObject("Stack.Image"), System.Drawing.Image)
        Me.Stack.Location = New System.Drawing.Point(77, 29)
        Me.Stack.Name = "Stack"
        Me.Stack.Size = New System.Drawing.Size(40, 64)
        Me.Stack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Stack.TabIndex = 13
        Me.Stack.TabStop = False
        '
        'Bob
        '
        Me.Bob.Image = CType(resources.GetObject("Bob.Image"), System.Drawing.Image)
        Me.Bob.Location = New System.Drawing.Point(118, 29)
        Me.Bob.Name = "Bob"
        Me.Bob.Size = New System.Drawing.Size(80, 64)
        Me.Bob.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Bob.TabIndex = 12
        Me.Bob.TabStop = False
        '
        'Ball3
        '
        Me.Ball3.Image = CType(resources.GetObject("Ball3.Image"), System.Drawing.Image)
        Me.Ball3.Location = New System.Drawing.Point(230, 70)
        Me.Ball3.Name = "Ball3"
        Me.Ball3.Size = New System.Drawing.Size(24, 20)
        Me.Ball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball3.TabIndex = 11
        Me.Ball3.TabStop = False
        '
        'Ball2
        '
        Me.Ball2.Image = CType(resources.GetObject("Ball2.Image"), System.Drawing.Image)
        Me.Ball2.Location = New System.Drawing.Point(230, 70)
        Me.Ball2.Name = "Ball2"
        Me.Ball2.Size = New System.Drawing.Size(24, 20)
        Me.Ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball2.TabIndex = 10
        Me.Ball2.TabStop = False
        '
        'Ball1
        '
        Me.Ball1.Image = CType(resources.GetObject("Ball1.Image"), System.Drawing.Image)
        Me.Ball1.Location = New System.Drawing.Point(230, 70)
        Me.Ball1.Name = "Ball1"
        Me.Ball1.Size = New System.Drawing.Size(24, 20)
        Me.Ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball1.TabIndex = 9
        Me.Ball1.TabStop = False
        '
        'Ball0
        '
        Me.Ball0.BackColor = System.Drawing.SystemColors.Control
        Me.Ball0.Image = CType(resources.GetObject("Ball0.Image"), System.Drawing.Image)
        Me.Ball0.Location = New System.Drawing.Point(230, 70)
        Me.Ball0.Name = "Ball0"
        Me.Ball0.Size = New System.Drawing.Size(24, 20)
        Me.Ball0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Ball0.TabIndex = 8
        Me.Ball0.TabStop = False
        '
        'Ladder5
        '
        Me.Ladder5.Image = CType(resources.GetObject("Ladder5.Image"), System.Drawing.Image)
        Me.Ladder5.Location = New System.Drawing.Point(216, 42)
        Me.Ladder5.Name = "Ladder5"
        Me.Ladder5.Size = New System.Drawing.Size(40, 53)
        Me.Ladder5.TabIndex = 7
        Me.Ladder5.TabStop = False
        '
        'Ladder4
        '
        Me.Ladder4.Image = CType(resources.GetObject("Ladder4.Image"), System.Drawing.Image)
        Me.Ladder4.Location = New System.Drawing.Point(420, 92)
        Me.Ladder4.Name = "Ladder4"
        Me.Ladder4.Size = New System.Drawing.Size(40, 66)
        Me.Ladder4.TabIndex = 6
        Me.Ladder4.TabStop = False
        '
        'Ladder3
        '
        Me.Ladder3.Image = CType(resources.GetObject("Ladder3.Image"), System.Drawing.Image)
        Me.Ladder3.Location = New System.Drawing.Point(167, 172)
        Me.Ladder3.Name = "Ladder3"
        Me.Ladder3.Size = New System.Drawing.Size(40, 62)
        Me.Ladder3.TabIndex = 5
        Me.Ladder3.TabStop = False
        '
        'Ladder2
        '
        Me.Ladder2.Image = CType(resources.GetObject("Ladder2.Image"), System.Drawing.Image)
        Me.Ladder2.Location = New System.Drawing.Point(372, 240)
        Me.Ladder2.Name = "Ladder2"
        Me.Ladder2.Size = New System.Drawing.Size(40, 72)
        Me.Ladder2.TabIndex = 4
        Me.Ladder2.TabStop = False
        '
        'Ladder1
        '
        Me.Ladder1.Image = CType(resources.GetObject("Ladder1.Image"), System.Drawing.Image)
        Me.Ladder1.Location = New System.Drawing.Point(143, 325)
        Me.Ladder1.Name = "Ladder1"
        Me.Ladder1.Size = New System.Drawing.Size(40, 58)
        Me.Ladder1.TabIndex = 3
        Me.Ladder1.TabStop = False
        '
        'Ladder0
        '
        Me.Ladder0.Image = CType(resources.GetObject("Ladder0.Image"), System.Drawing.Image)
        Me.Ladder0.Location = New System.Drawing.Point(452, 400)
        Me.Ladder0.Name = "Ladder0"
        Me.Ladder0.Size = New System.Drawing.Size(40, 65)
        Me.Ladder0.TabIndex = 2
        Me.Ladder0.TabStop = False
        '
        'Background
        '
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(640, 480)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Background.TabIndex = 1
        Me.Background.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Shield1
        '
        Me.Shield1.BackColor = System.Drawing.Color.White
        Me.Shield1.Image = CType(resources.GetObject("Shield1.Image"), System.Drawing.Image)
        Me.Shield1.Location = New System.Drawing.Point(306, 139)
        Me.Shield1.Name = "Shield1"
        Me.Shield1.Size = New System.Drawing.Size(17, 19)
        Me.Shield1.TabIndex = 17
        Me.Shield1.TabStop = False
        '
        'Shield2
        '
        Me.Shield2.BackColor = System.Drawing.Color.White
        Me.Shield2.Image = CType(resources.GetObject("Shield2.Image"), System.Drawing.Image)
        Me.Shield2.Location = New System.Drawing.Point(317, 293)
        Me.Shield2.Name = "Shield2"
        Me.Shield2.Size = New System.Drawing.Size(17, 19)
        Me.Shield2.TabIndex = 18
        Me.Shield2.TabStop = False
        '
        'shieldIndication
        '
        Me.shieldIndication.Location = New System.Drawing.Point(581, 10)
        Me.shieldIndication.Name = "shieldIndication"
        Me.shieldIndication.Size = New System.Drawing.Size(46, 37)
        Me.shieldIndication.TabIndex = 1
        Me.shieldIndication.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.GamePanel)
        Me.Name = "MainForm"
        Me.Text = "PolarPeril"
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.Shield0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nansen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Penguin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ladder0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shield1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shield2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shieldIndication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GamePanel As Panel
    Friend WithEvents Background As PictureBox
    Friend WithEvents Nansen As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Ladder5 As PictureBox
    Friend WithEvents Ladder4 As PictureBox
    Friend WithEvents Ladder3 As PictureBox
    Friend WithEvents Ladder2 As PictureBox
    Friend WithEvents Ladder1 As PictureBox
    Friend WithEvents Ladder0 As PictureBox
    Friend WithEvents Ball3 As PictureBox
    Friend WithEvents Ball2 As PictureBox
    Friend WithEvents Ball1 As PictureBox
    Friend WithEvents Ball0 As PictureBox
    Friend WithEvents Bob As PictureBox
    Friend WithEvents Stack As PictureBox
    Friend WithEvents Help As PictureBox
    Friend WithEvents Penguin As PictureBox
    Friend WithEvents Shield0 As PictureBox
    Friend WithEvents Shield2 As PictureBox
    Friend WithEvents Shield1 As PictureBox
    Friend WithEvents shieldIndication As PictureBox
End Class
