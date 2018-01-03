Public Class Mainform
    Dim mstuff As mariotype
    Dim animationdelay As Integer
    Dim ladder(5) As PictureBox
    Dim barrel(3) As PictureBox
    Dim fstuff(6) As Floortype
    Dim bstuff(3) As mariotype
    Dim throwtimer As Integer
    Dim dkdancing As Boolean
    Dim flashTimer As Integer
    Dim lightning As Boolean = False

    Private Sub barrelset()
        Dim index As Integer
        For index = 0 To 3
            barrel(index).Visible = False
            bstuff(index).floating = False
            bstuff(index).onladder = False
            bstuff(index).picnum = 1
            bstuff(index).speed.X = 10
            bstuff(index).speed.Y = 0
            barrel(index).Top = 70
            barrel(index).Left = 203
        Next
    End Sub



    Private Sub Mainform_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            If Mario.Left > 77 Then
                mstuff.speed.X = -6
            Else
                mstuff.speed.X = 0
            End If
            mstuff.facingright = False
        End If

        If e.KeyCode = Keys.Right Then
            If Mario.Left < 540 Then
                mstuff.speed.X = 6
            Else
                mstuff.speed.X = 0
            End If
            mstuff.facingright = True
        End If
        If e.KeyCode = Keys.Space And mstuff.speed.Y = 0 And mstuff.onfloor = True Then
            mstuff.speed.Y = -5
            mstuff.floattime = 0
            mstuff.floating = True
            mstuff.onfloor = False
        End If
        If e.KeyCode = Keys.Up Then
            If mstuff.floating = False Then
                mstuff.speed.Y = -5
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If mstuff.floating = False Then
                mstuff.speed.Y = 5
            End If
        End If
        If e.KeyCode = Keys.ShiftKey And lightning = True Then
            thunderjolt.Location = Mario.Location
            thunderjolt.Visible = True
        End If
    End Sub
    Private Sub movebarrel(ByVal index As Integer)
        Dim floornumber As Integer
        floornumber = getfloornumber(barrel(index).Top)
        If bstuff(index).floating = True Then
            If bstuff(index).floattime = 5 Then
                If bstuff(index).speed.Y = -5 Then
                    bstuff(index).speed.Y = 5
                Else
                    bstuff(index).speed.Y = 0
                    bstuff(index).floating = False
                    If fstuff(floornumber).slope < 0 Then
                        bstuff(index).speed.X = -10
                    Else
                        bstuff(index).speed.X = 10

                    End If
                End If
                bstuff(index).floattime = 1
            Else
                bstuff(index).floattime = bstuff(index).floattime + 1
            End If
        Else
            bstuff(index).onladder = barrelcheckladder(index)
            If bstuff(index).onladder = False Then
                bstuff(index).speed.Y = 0
                bstuff(index).onfloor = True
                barrel(index).Top = fstuff(floornumber).slope * (barrel(index).Left - fstuff(floornumber).x) + fstuff(floornumber).y - barrel(index).Height
                If barrel(index).Left > fstuff(floornumber).rightedge Then
                    bstuff(index).floating = True
                    bstuff(index).floattime = 1
                    bstuff(index).speed.Y = 5
                ElseIf barrel(index).Left + barrel(index).Width <
                    fstuff(floornumber).leftedge Then
                    bstuff(index).floating = True
                    bstuff(index).floattime = 1
                    bstuff(index).speed.Y = 5
                End If

            Else
                bstuff(index).speed.X = 0
                bstuff(index).speed.Y = 10
                bstuff(index).floating = True
            End If
        End If

        If bstuff(index).speed.X < 0 And barrel(index).Left < 77 Then
            bstuff(index).speed.X = 0

        End If
        If bstuff(index).speed.X > 0 And barrel(index).Left > 540 Then
            bstuff(index).speed.X = 0
        End If

        barrel(index).Left = barrel(index).Left + bstuff(index).speed.X
        barrel(index).Top = barrel(index).Top + bstuff(index).speed.Y
        If floornumber = 0 And barrel(index).Left < 88 Then
            barrel(index).Visible = False
            dkdancing = False
            throwtimer = 0
            donkeykong.Image =
                Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\meowthstanding.png")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'play("play Pok_mon_Theme_Song_.wav")
        Dim index As Integer
        Call movemario()
        animationdelay += 1
        If animationdelay > 3 Then
            Call animatemario()
            Call animatedonkeykong()
            Call checkpowerup()
            Call throwbarrel()
            Call animateHelp()
            Call moveghost()

            animationdelay = 0
            For index = 0 To 3
                If barrel(index).Visible = True Then
                    Call movebarrel(index)
                    Call animatebarrel1(index)
                    If touching(barrel(index), Mario) = True Then
                        Timer1.Stop()
                        youdieform.ShowDialog()
                        resetlevel()
                        tm.Visible = True
                        lightning = False
                        thunderjolt.Visible = False
                        Thunder.Visible = False
                        Timer1.Start()
                    End If
                End If
            Next index
        End If
        If touching(Ghost, Mario) = True And Ghost.Visible = True Then
            Timer1.Stop()
            youdieform.ShowDialog()
            resetlevel()
            tm.Visible = True
            lightning = False
            thunderjolt.Visible = False
            Thunder.Visible = False
            Timer1.Start()
            Ghost.Visible = False
        End If

        If touching(thunderjolt, barrel0) And thunderjolt.Visible = True Then
            Thunder.Visible = False
            barrel0.Visible = False
            thunderjolt.Visible = False
        End If
        If touching(thunderjolt, barrel1) And thunderjolt.Visible = True Then
            Thunder.Visible = False
            barrel1.Visible = False

            thunderjolt.Visible = False
        End If
        If touching(thunderjolt, barrel2) And thunderjolt.Visible = True Then
            Thunder.Visible = False
            barrel2.Visible = False

            thunderjolt.Visible = False
        End If
        If touching(thunderjolt, barrel3) And thunderjolt.Visible = True Then
            Thunder.Visible = False
            barrel3.Visible = False

            thunderjolt.Visible = False
        End If
        If touching(barrel0, Wall) Then
            Ghost.Visible = True
        End If


        If touching(Mario, peach) = True Then
            Timer1.Stop()
            youwinForm.ShowDialog()
            resetlevel()
            Timer1.Start()
            Thunder.Visible = False
            lightning = False
            Ghost.Visible = False
            thunderjolt.Visible = False
            tm.Visible = True
        End If
        If touching(Ghost, thunderjolt) Then
            Ghost.Visible = False
        End If

    End Sub

    Private Sub movemario()
        Dim floornumber As Integer
        floornumber = getfloornumber(Mario.Top)
        If mstuff.floating = True Then
            If mstuff.floattime = 13 Then
                If mstuff.speed.Y = -5 Then
                    mstuff.speed.Y = 5
                Else
                    mstuff.speed.Y = False
                    mstuff.floating = 0
                End If
                mstuff.floattime = 1
            Else
                mstuff.floattime = mstuff.floattime + 1
            End If
        Else
            mstuff.onladder = checkladder()
            If mstuff.onladder = False Then
                mstuff.speed.Y = 0
                mstuff.onfloor = True
                Mario.Top = fstuff(floornumber).slope * (Mario.Left - fstuff(floornumber).x) + fstuff(floornumber).y - Mario.Height
                If Mario.Left > fstuff(floornumber).rightedge Then
                    mstuff.floating = True
                    mstuff.floattime = 1
                    mstuff.speed.Y = 5
                ElseIf Mario.Left + Mario.Width <
                    fstuff(floornumber).leftedge Then
                    mstuff.floating = True
                    mstuff.floattime = 1
                    mstuff.speed.Y = 5
                End If

            Else
                mstuff.speed.X = 0
            End If
        End If

        If mstuff.speed.X < 0 And Mario.Left < 77 Then
            mstuff.speed.X = 0

        End If
        If mstuff.speed.X > 0 And Mario.Left > 540 Then
            mstuff.speed.X = 0
        End If

        Mario.Left = Mario.Left + mstuff.speed.X
        Mario.Top = Mario.Top + mstuff.speed.Y
    End Sub

    Private Sub Mainform_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            mstuff.speed.X = 0
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            If mstuff.floating = False Then
                mstuff.speed.Y = 0
            End If

        End If

        If e.KeyCode = Keys.B Then
            thunderjolt.Visible = False
        End If
    End Sub

    Private Sub animatemario()
        If mstuff.speed.Y <> 0 Then
            If mstuff.floating = False Then
                If mstuff.picnum = 1 Then
                    mstuff.picnum = 2
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuclimb1.png")
                ElseIf mstuff.picnum = 2 Then
                    mstuff.picnum = 3
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuclimb3.png")
                ElseIf mstuff.picnum = 3 Then
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuclimb2.png")
                End If
            Else
                If mstuff.facingright = True Then
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachurightmove2.png")
                Else
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuleftmove2.png")
                End If
            End If
        Else
            If mstuff.speed.X > 0 Then
                If mstuff.picnum = 1 Then
                    mstuff.picnum = 2
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachurightmove2.png")
                ElseIf mstuff.picnum = 2 Then
                    mstuff.picnum = 3
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachurightmove3.png")
                Else
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachurightmove1.png")
                End If
            ElseIf mstuff.speed.X < 0 Then
                If mstuff.picnum = 1 Then
                    mstuff.picnum = 2
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuleftmove2.png")
                ElseIf mstuff.picnum = 2 Then
                    mstuff.picnum = 3
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuleftmove3.png")
                Else
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuleftmove1.png")
                End If
            ElseIf mstuff.speed.X = 0 Then
                If mstuff.facingright = True Then
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachurightmove2.png")
                Else
                    mstuff.picnum = 1
                    Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pikachuleftmove2.png")
                End If

            End If
        End If
    End Sub

    Private Sub animateHelp()
        flashTimer += 1

        If flashTimer > 10 Then

            flashTimer = 0

            If help.Visible = True Then
                help.Visible = False
            Else
                help.Visible = True
            End If
        End If
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call loadbarrels()
        resetlevel()
    End Sub

    Private Sub resetlevel()
        marioset()
        ladderset()
        Call floorset()
        Call barrelset()
    End Sub

    Private Sub marioset()
        mstuff.picnum = 1
        animationdelay = 0
        Mario.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\mariorightmove1.jpg")
        mstuff.speed.X = 0
        mstuff.speed.Y = 0
        mstuff.facingright = True
        Mario.Left = 80
        Mario.Top = 430
    End Sub

    Private Sub ladderset()
        ladder(0) = ladder0
        ladder(1) = ladder1
        ladder(2) = ladder2
        ladder(3) = ladder3
        ladder(4) = ladder4
        ladder(5) = ladder5
    End Sub
    Private Sub throwbarrel()
        Dim index As Integer
        Dim index2 As Integer
        Dim done As Boolean
        throwtimer = throwtimer + 1
        If throwtimer = 32 Then
            throwtimer = 0
            done = False
            Do While done = False
                If barrel(index).Visible = False Then
                    done = True
                    barrel(index).Visible = True
                    barrel(index).Top = 70
                    barrel(index).Left = 203
                    bstuff(index).floating = False
                    bstuff(index).onladder = False
                    bstuff(index).picnum = 1
                    bstuff(index).speed.X = 10
                    bstuff(index).speed.Y = 0
                    dkdancing = True
                    For index2 = 0 To 3
                        If barrel(index2).Visible = False Then
                            dkdancing = False
                        End If
                    Next index2
                End If
                index = index + 1
                If index = 4 Then
                    done = True
                End If
            Loop
        End If
    End Sub


    Private Function checkladder()
        Dim index As Integer
        Dim ladderoffset As Integer
        ladderoffset = 15
        For index = 0 To 5
            If mstuff.speed.Y < 0 Then


                If Mario.Left > ladder(index).Left - ladderoffset And Mario.Right < ladder(index).Right + ladderoffset Then
                    If Mario.Top < ladder(index).Bottom And Mario.Bottom >
                        ladder(index).Top Then
                        Return True
                    End If
                End If
            ElseIf mstuff.speed.Y > 0 Then
                If Mario.Left > ladder(index).Left - ladderoffset And Mario.Right < ladder(index).Right + ladderoffset Then
                    If Mario.Bottom < ladder(index).Bottom And Mario.Bottom >
                        ladder(index).Top - ladderoffset Then
                        Return True

                    End If
                End If
            ElseIf mstuff.speed.Y = 0 Then
                If Mario.Left > ladder(index).Left - ladderoffset And Mario.Right < ladder(index).Right + ladderoffset Then
                    If Mario.Bottom < ladder(index).Bottom - ladderoffset And
                        Mario.Bottom > ladder(index).Top + ladderoffset Then
                        Return True
                    End If
                End If

            End If
        Next index
        Return False
    End Function
    Private Function barrelcheckladder(ByVal index As Integer)
        Dim ladderindex As Integer
        Dim ladderoffset As Integer
        ladderoffset = 13
        If Int(Rnd() * 2) = 0 Then
            For ladderindex = 0 To 5

                If barrel(index).Left > ladder(ladderindex).Left And barrel(index).Right < ladder(ladderindex).Right Then
                    If barrel(index).Bottom + ladderoffset > ladder(ladderindex).Top And barrel(index).Bottom - ladderoffset < ladder(ladderindex).Top Then
                        Return True
                    End If
                End If

            Next ladderindex
        End If
        Return False
    End Function

    Public Sub floorset()
        fstuff(0).slope = -0.0000000001
        fstuff(1).slope = 0.078
        fstuff(2).slope = -0.078
        fstuff(3).slope = 0.078
        fstuff(4).slope = -0.078
        fstuff(5).slope = 0
        fstuff(6).slope = 0

        fstuff(0).x = 137
        fstuff(1).x = 137
        fstuff(2).x = 137
        fstuff(3).x = 137
        fstuff(4).x = 137
        fstuff(5).x = 137
        fstuff(6).x = 137

        fstuff(0).y = 465
        fstuff(1).y = 377
        fstuff(2).y = 327
        fstuff(3).y = 226
        fstuff(4).y = 176
        fstuff(5).y = 92
        fstuff(6).y = 42

        fstuff(0).leftedge = 0
        fstuff(1).leftedge = 0
        fstuff(2).leftedge = 133
        fstuff(3).leftedge = 0
        fstuff(4).leftedge = 133
        fstuff(5).leftedge = 0
        fstuff(6).leftedge = 200

        fstuff(0).rightedge = 570
        fstuff(1).rightedge = 507
        fstuff(2).rightedge = 570
        fstuff(3).rightedge = 507
        fstuff(4).rightedge = 570
        fstuff(5).rightedge = 507
        fstuff(6).rightedge = 312
    End Sub
    Private Function getfloornumber(ByVal thingtop As Integer)
        If thingtop < 20 Then
            Return 6
        ElseIf thingtop < 73 Then
            Return 5
        ElseIf thingtop < 160 Then
            Return 4
        ElseIf thingtop < 240 Then
            Return 3
        ElseIf thingtop < 320 Then
            Return 2
        ElseIf thingtop < 393 Then
            Return 1
        Else
            Return 0

        End If
    End Function
    Private Function touching(ByVal pic1 As PictureBox, ByVal pic2 As PictureBox)
        If pic1.Left < pic2.Right And pic1.Right > pic2.Left Then
            If pic1.Bottom > pic2.Top And pic1.Top < pic2.Bottom Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Sub loadbarrels()
        barrel(0) = barrel0
        barrel(1) = barrel1
        barrel(2) = barrel2
        barrel(3) = barrel3
    End Sub

    Private Sub animatebarrel1(ByVal index As Integer)
        If bstuff(index).picnum = 1 Then
            bstuff(index).picnum = 2
            barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pokeball1.png")
        ElseIf bstuff(index).picnum = 2 Then
            bstuff(index).picnum = 3
            barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pokeball2.png")
        ElseIf bstuff(index).picnum = 3 Then
            bstuff(index).picnum = 4
            barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pokeball3.png")
        ElseIf bstuff(index).picnum = 4 Then
            bstuff(index).picnum = 1
            barrel(index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\pokeball4.png")
        End If

    End Sub
    Private Sub animatedonkeykong()
        If dkdancing = False Then
            If throwtimer > 30 Then
                donkeykong.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\meowthgrab1.png")
            ElseIf throwtimer > 15 Then
                donkeykong.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\meowthgrab3.png")
            ElseIf throwtimer > 7 Then
                donkeykong.Image =
                    Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\meowthgrab2.png")
            End If
        Else
            If throwtimer > 30 Then
                donkeykong.Image =
                    Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\Meowthstanding.png")
            End If
        End If


    End Sub
    Public Sub checkpowerup()
        If touching(Mario, tm) Then
            lightning = True
            tm.Visible = False
            Thunder.Visible = True
        End If
    End Sub
    Public Sub moveghost()
        If Mario.Left > Ghost.Left Then
            Ghost.Left = Ghost.Left + 1
        Else
            Ghost.Left = Ghost.Left - 1
        End If
        If Mario.Top > Ghost.Top Then
            Ghost.Top = Ghost.Top + 1
        Else
            Ghost.Top = Ghost.Top - 1
        End If
    End Sub
End Class



