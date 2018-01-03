<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.Ghost = New System.Windows.Forms.PictureBox()
        Me.thunderjolt = New System.Windows.Forms.PictureBox()
        Me.Thunder = New System.Windows.Forms.PictureBox()
        Me.tm = New System.Windows.Forms.PictureBox()
        Me.Mario = New System.Windows.Forms.PictureBox()
        Me.barrel3 = New System.Windows.Forms.PictureBox()
        Me.barrel2 = New System.Windows.Forms.PictureBox()
        Me.barrel1 = New System.Windows.Forms.PictureBox()
        Me.barrel0 = New System.Windows.Forms.PictureBox()
        Me.dkbarrels = New System.Windows.Forms.PictureBox()
        Me.help = New System.Windows.Forms.PictureBox()
        Me.peach = New System.Windows.Forms.PictureBox()
        Me.donkeykong = New System.Windows.Forms.PictureBox()
        Me.ladder5 = New System.Windows.Forms.PictureBox()
        Me.ladder4 = New System.Windows.Forms.PictureBox()
        Me.ladder3 = New System.Windows.Forms.PictureBox()
        Me.ladder2 = New System.Windows.Forms.PictureBox()
        Me.ladder1 = New System.Windows.Forms.PictureBox()
        Me.ladder0 = New System.Windows.Forms.PictureBox()
        Me.Backround = New System.Windows.Forms.PictureBox()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thunderjolt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thunder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrel0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dkbarrels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.donkeykong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ladder0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Backround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'wall
        '
        Me.wall.Image = Global.DonkeykongRT.My.Resources.Resources.Wall
        Me.wall.Location = New System.Drawing.Point(91, 402)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(12, 64)
        Me.wall.TabIndex = 20
        Me.wall.TabStop = False
        '
        'Ghost
        '
        Me.Ghost.Image = Global.DonkeykongRT.My.Resources.Resources.WOBBUFFET
        Me.Ghost.Location = New System.Drawing.Point(524, 0)
        Me.Ghost.Name = "Ghost"
        Me.Ghost.Size = New System.Drawing.Size(67, 63)
        Me.Ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost.TabIndex = 19
        Me.Ghost.TabStop = False
        Me.Ghost.Visible = False
        '
        'thunderjolt
        '
        Me.thunderjolt.Image = CType(resources.GetObject("thunderjolt.Image"), System.Drawing.Image)
        Me.thunderjolt.Location = New System.Drawing.Point(210, 424)
        Me.thunderjolt.Name = "thunderjolt"
        Me.thunderjolt.Size = New System.Drawing.Size(43, 42)
        Me.thunderjolt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.thunderjolt.TabIndex = 18
        Me.thunderjolt.TabStop = False
        Me.thunderjolt.Visible = False
        '
        'Thunder
        '
        Me.Thunder.Image = CType(resources.GetObject("Thunder.Image"), System.Drawing.Image)
        Me.Thunder.Location = New System.Drawing.Point(596, 0)
        Me.Thunder.Name = "Thunder"
        Me.Thunder.Size = New System.Drawing.Size(56, 59)
        Me.Thunder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Thunder.TabIndex = 17
        Me.Thunder.TabStop = False
        Me.Thunder.Visible = False
        '
        'tm
        '
        Me.tm.Image = CType(resources.GetObject("tm.Image"), System.Drawing.Image)
        Me.tm.Location = New System.Drawing.Point(188, 99)
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(24, 24)
        Me.tm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.tm.TabIndex = 16
        Me.tm.TabStop = False
        '
        'Mario
        '
        Me.Mario.Image = Global.DonkeykongRT.My.Resources.Resources.marioSpin
        Me.Mario.Location = New System.Drawing.Point(132, 432)
        Me.Mario.Name = "Mario"
        Me.Mario.Size = New System.Drawing.Size(35, 34)
        Me.Mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Mario.TabIndex = 0
        Me.Mario.TabStop = False
        '
        'barrel3
        '
        Me.barrel3.Image = CType(resources.GetObject("barrel3.Image"), System.Drawing.Image)
        Me.barrel3.Location = New System.Drawing.Point(271, 73)
        Me.barrel3.Name = "barrel3"
        Me.barrel3.Size = New System.Drawing.Size(24, 20)
        Me.barrel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barrel3.TabIndex = 15
        Me.barrel3.TabStop = False
        '
        'barrel2
        '
        Me.barrel2.Image = CType(resources.GetObject("barrel2.Image"), System.Drawing.Image)
        Me.barrel2.Location = New System.Drawing.Point(250, 73)
        Me.barrel2.Name = "barrel2"
        Me.barrel2.Size = New System.Drawing.Size(24, 20)
        Me.barrel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barrel2.TabIndex = 14
        Me.barrel2.TabStop = False
        '
        'barrel1
        '
        Me.barrel1.Image = CType(resources.GetObject("barrel1.Image"), System.Drawing.Image)
        Me.barrel1.Location = New System.Drawing.Point(229, 73)
        Me.barrel1.Name = "barrel1"
        Me.barrel1.Size = New System.Drawing.Size(24, 20)
        Me.barrel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barrel1.TabIndex = 13
        Me.barrel1.TabStop = False
        '
        'barrel0
        '
        Me.barrel0.Image = CType(resources.GetObject("barrel0.Image"), System.Drawing.Image)
        Me.barrel0.Location = New System.Drawing.Point(201, 73)
        Me.barrel0.Name = "barrel0"
        Me.barrel0.Size = New System.Drawing.Size(24, 20)
        Me.barrel0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.barrel0.TabIndex = 12
        Me.barrel0.TabStop = False
        '
        'dkbarrels
        '
        Me.dkbarrels.Image = CType(resources.GetObject("dkbarrels.Image"), System.Drawing.Image)
        Me.dkbarrels.Location = New System.Drawing.Point(50, 27)
        Me.dkbarrels.Name = "dkbarrels"
        Me.dkbarrels.Size = New System.Drawing.Size(69, 68)
        Me.dkbarrels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dkbarrels.TabIndex = 11
        Me.dkbarrels.TabStop = False
        '
        'help
        '
        Me.help.Image = CType(resources.GetObject("help.Image"), System.Drawing.Image)
        Me.help.Location = New System.Drawing.Point(242, 10)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(53, 20)
        Me.help.TabIndex = 10
        Me.help.TabStop = False
        '
        'peach
        '
        Me.peach.Image = CType(resources.GetObject("peach.Image"), System.Drawing.Image)
        Me.peach.Location = New System.Drawing.Point(207, 0)
        Me.peach.Name = "peach"
        Me.peach.Size = New System.Drawing.Size(29, 52)
        Me.peach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.peach.TabIndex = 9
        Me.peach.TabStop = False
        '
        'donkeykong
        '
        Me.donkeykong.Image = CType(resources.GetObject("donkeykong.Image"), System.Drawing.Image)
        Me.donkeykong.Location = New System.Drawing.Point(125, 43)
        Me.donkeykong.Name = "donkeykong"
        Me.donkeykong.Size = New System.Drawing.Size(42, 50)
        Me.donkeykong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.donkeykong.TabIndex = 8
        Me.donkeykong.TabStop = False
        '
        'ladder5
        '
        Me.ladder5.Image = CType(resources.GetObject("ladder5.Image"), System.Drawing.Image)
        Me.ladder5.Location = New System.Drawing.Point(289, 36)
        Me.ladder5.Name = "ladder5"
        Me.ladder5.Size = New System.Drawing.Size(41, 59)
        Me.ladder5.TabIndex = 7
        Me.ladder5.TabStop = False
        '
        'ladder4
        '
        Me.ladder4.Image = CType(resources.GetObject("ladder4.Image"), System.Drawing.Image)
        Me.ladder4.Location = New System.Drawing.Point(453, 249)
        Me.ladder4.Name = "ladder4"
        Me.ladder4.Size = New System.Drawing.Size(39, 59)
        Me.ladder4.TabIndex = 6
        Me.ladder4.TabStop = False
        '
        'ladder3
        '
        Me.ladder3.Image = CType(resources.GetObject("ladder3.Image"), System.Drawing.Image)
        Me.ladder3.Location = New System.Drawing.Point(481, 398)
        Me.ladder3.Name = "ladder3"
        Me.ladder3.Size = New System.Drawing.Size(40, 68)
        Me.ladder3.TabIndex = 5
        Me.ladder3.TabStop = False
        '
        'ladder2
        '
        Me.ladder2.Image = CType(resources.GetObject("ladder2.Image"), System.Drawing.Image)
        Me.ladder2.Location = New System.Drawing.Point(463, 95)
        Me.ladder2.Name = "ladder2"
        Me.ladder2.Size = New System.Drawing.Size(38, 61)
        Me.ladder2.TabIndex = 4
        Me.ladder2.TabStop = False
        '
        'ladder1
        '
        Me.ladder1.Image = CType(resources.GetObject("ladder1.Image"), System.Drawing.Image)
        Me.ladder1.Location = New System.Drawing.Point(250, 168)
        Me.ladder1.Name = "ladder1"
        Me.ladder1.Size = New System.Drawing.Size(38, 67)
        Me.ladder1.TabIndex = 3
        Me.ladder1.TabStop = False
        '
        'ladder0
        '
        Me.ladder0.Image = CType(resources.GetObject("ladder0.Image"), System.Drawing.Image)
        Me.ladder0.Location = New System.Drawing.Point(188, 326)
        Me.ladder0.Name = "ladder0"
        Me.ladder0.Size = New System.Drawing.Size(37, 57)
        Me.ladder0.TabIndex = 2
        Me.ladder0.TabStop = False
        '
        'Backround
        '
        Me.Backround.Image = Global.DonkeykongRT.My.Resources.Resources.level1_background
        Me.Backround.Location = New System.Drawing.Point(12, 0)
        Me.Backround.Name = "Backround"
        Me.Backround.Size = New System.Drawing.Size(640, 480)
        Me.Backround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Backround.TabIndex = 1
        Me.Backround.TabStop = False
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 664)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.Ghost)
        Me.Controls.Add(Me.thunderjolt)
        Me.Controls.Add(Me.Thunder)
        Me.Controls.Add(Me.tm)
        Me.Controls.Add(Me.Mario)
        Me.Controls.Add(Me.barrel3)
        Me.Controls.Add(Me.barrel2)
        Me.Controls.Add(Me.barrel1)
        Me.Controls.Add(Me.barrel0)
        Me.Controls.Add(Me.dkbarrels)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.peach)
        Me.Controls.Add(Me.donkeykong)
        Me.Controls.Add(Me.ladder5)
        Me.Controls.Add(Me.ladder4)
        Me.Controls.Add(Me.ladder3)
        Me.Controls.Add(Me.ladder2)
        Me.Controls.Add(Me.ladder1)
        Me.Controls.Add(Me.ladder0)
        Me.Controls.Add(Me.Backround)
        Me.Name = "Mainform"
        Me.Text = "Donkeykong"
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thunderjolt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thunder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrel0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dkbarrels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.donkeykong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ladder0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Backround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mario As System.Windows.Forms.PictureBox
    Friend WithEvents Backround As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ladder0 As System.Windows.Forms.PictureBox
    Friend WithEvents ladder1 As System.Windows.Forms.PictureBox
    Friend WithEvents ladder2 As System.Windows.Forms.PictureBox
    Friend WithEvents ladder3 As System.Windows.Forms.PictureBox
    Friend WithEvents ladder4 As System.Windows.Forms.PictureBox
    Friend WithEvents ladder5 As System.Windows.Forms.PictureBox
    Friend WithEvents donkeykong As System.Windows.Forms.PictureBox
    Friend WithEvents peach As System.Windows.Forms.PictureBox
    Friend WithEvents help As System.Windows.Forms.PictureBox
    Friend WithEvents dkbarrels As System.Windows.Forms.PictureBox
    Friend WithEvents barrel0 As System.Windows.Forms.PictureBox
    Friend WithEvents barrel1 As System.Windows.Forms.PictureBox
    Friend WithEvents barrel2 As System.Windows.Forms.PictureBox
    Friend WithEvents barrel3 As System.Windows.Forms.PictureBox
    Friend WithEvents tm As System.Windows.Forms.PictureBox
    Friend WithEvents Thunder As System.Windows.Forms.PictureBox
    Friend WithEvents thunderjolt As System.Windows.Forms.PictureBox
    Friend WithEvents Ghost As System.Windows.Forms.PictureBox
    Friend WithEvents wall As System.Windows.Forms.PictureBox

End Class
