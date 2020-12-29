Public Class MainForm
    Const numLadders As Integer = 5
    Const numFloors As Integer = 6
    Const numBall As Integer = 3
    Dim nstuff As SpriteType
    Dim ladder(numLadders) As PictureBox
    Dim fStuff(numFloors) As floorType
    Dim ball(numBall) As PictureBox
    Dim bStuff(numBall) As SpriteType
    Dim randInt As Integer
    Dim throwTimer As Integer = 31
    Dim bobDancing As Boolean
    Dim lives As Integer = 3
    Dim shieldOn As Boolean
    Dim powerUps(2) As PictureBox

    Public Shared YouDiedForm As New YouDie
    Public Shared YouWonForm As New YouWon

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            If Nansen.Left > 77 Then
                nstuff.Speed.X = -5
            Else
                nstuff.Speed.X = 0
            End If
            nstuff.facingRight = False
            nstuff.facingLeft = True
        End If
        If e.KeyCode = Keys.Right Then
            If Nansen.Left < 540 Then
                nstuff.Speed.X = 5
            Else
                nstuff.Speed.X = 0
            End If
            nstuff.facingRight = True
            nstuff.facingLeft = False
        End If
        If e.KeyCode = Keys.Up And nstuff.floating = False Then
            nstuff.Speed.Y = -5
        End If
        If e.KeyCode = Keys.Down And nstuff.floating = False Then
            nstuff.Speed.Y = 5
        End If
        If e.KeyCode = Keys.Space And nstuff.floating = False And nstuff.onFloor = True Then
            nstuff.Speed.Y = -5
            nstuff.floatTime = 0
            nstuff.floating = True
            nstuff.onFloor = False
        End If
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            nstuff.Speed.X = 0
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
            nstuff.Speed.Y = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call moveNansen()
        Call animateNansen()
        Call throwBall()
        Call animateBob()
        Call flashHelp()
        Dim index As Integer
        For index = 0 To numBall
            If ball(index).Visible = True Then
                Call moveBall(index)
                Call animateBall(index)
                If touching(Nansen, ball(index)) = True And shieldOn = False And ball(index).Visible = True Then
                    If lives = 1 Then
                        Timer1.Stop()
                        YouDie.ShowDialog()
                        Call resetLevel()
                        Timer1.Start()
                        lives = 3
                    Else
                        lives -= 1
                        Call resetLevel()
                    End If
                ElseIf touching(Nansen, ball(index)) = True And shieldOn = True Then
                    shieldOn = False
                    ball(index).Visible = False
                    shieldIndication.Visible = False
                End If
            End If
        Next index
        If quit = True Then
            Me.Close()
        End If
        If touching(Nansen, Penguin) = True Then
            Timer1.Stop()
            YouWon.ShowDialog()
            Call resetLevel()
            Timer1.Start()
        End If
        For index = 0 To 2
            If touching(Nansen, powerUps(index)) = True And powerUps(index).Visible = True Then
                shieldOn = True
                shieldIndication.Visible = True
                powerUps(index).Visible = False
            End If
        Next
    End Sub

    Private Sub moveNansen()
        nstuff.floorNumber = getFloorNumber(Nansen.Top)
        If nstuff.floating = True Then
            Call jumping(nstuff, 10)
        Else
            nstuff.onLadder = CheckLadder()
            If nstuff.onLadder = False Then
                Call moveAlongFloor(nstuff, Nansen)
            Else
                nstuff.Speed.X = 0
            End If
        End If
        If (Nansen.Left < 77 And nstuff.Speed.X < 0) Or (Nansen.Left > 540 And nstuff.Speed.X > 0) Then
            nstuff.Speed.X = 0
        End If
        Nansen.Left = Nansen.Left + nstuff.Speed.X
        Nansen.Top = Nansen.Top + nstuff.Speed.Y
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Call resetLevel()
        quit = False
        powerUps(0) = Shield0
        powerUps(1) = Shield1
        powerUps(2) = Shield2
    End Sub

    Private Sub animateNansen()
        If nstuff.Speed.Y <> 0 Then
            If nstuff.floating = True Then
                Call animateJump()
            Else
                Call animateClimb()
            End If
        ElseIf nstuff.onLadder = False Then
            If nstuff.Speed.X > 0 Then
                Call animateMoveRight()
            ElseIf nstuff.Speed.X < 0 Then
                Call animateMoveLeft()
            Else
                Call animateStand()
            End If
        End If
    End Sub

    Private Sub animateMoveRight()
        If nstuff.picNum = 1 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightMove1.jpg")
            nstuff.picNum = 2
        ElseIf nstuff.picNum = 2 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightMove2.jpg")
            nstuff.picNum = 3
        ElseIf nstuff.picNum = 3 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightMove3.jpg")
            nstuff.picNum = 1
        End If
    End Sub

    Private Sub animateMoveLeft()
        If nstuff.picNum = 1 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenLeftMove1.jpg")
            nstuff.picNum = 2
        ElseIf nstuff.picNum = 2 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenLeftMove2.jpg")
            nstuff.picNum = 3
        ElseIf nstuff.picNum = 3 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenLeftMove3.jpg")
            nstuff.picNum = 1
        End If
    End Sub

    Private Sub animateJump()
        If nstuff.Speed.X > 0 And nstuff.facingRight = True Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightFloat.jpg")
        ElseIf nstuff.Speed.X < 0 And nstuff.facingRight = False Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenLeftFloat.jpg")
        End If
    End Sub

    Private Sub animateStand()
        If nstuff.facingRight = True Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightMove1.jpg")
        ElseIf nstuff.facingLeft = True Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenLeftMove1.jpg")
        End If
    End Sub

    Private Sub animateClimb()
        If nstuff.picNum = 1 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenClimb1.jpg")
            nstuff.picNum = 2
        ElseIf nstuff.picNum = 2 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenClimb2.jpg")
            nstuff.picNum = 3
        ElseIf nstuff.picNum = 3 Then
            Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenClimb3.jpg")
            nstuff.picNum = 1
        End If
    End Sub

    Private Function CheckLadder()
        Dim ladderOffSet As Integer
        Dim index As Integer
        ladderOffSet = 15
        For index = 0 To numLadders
            If nstuff.Speed.Y < 0 Then
                If Nansen.Left > ladder(index).Left - ladderOffSet And Nansen.Right < ladder(index).Right + ladderOffSet Then
                    If Nansen.Top < ladder(index).Bottom And Nansen.Bottom > ladder(index).Top Then
                        Return True
                    End If
                End If
            ElseIf nstuff.Speed.Y > 0 Then
                If Nansen.Left > ladder(index).Left - ladderOffSet And Nansen.Right < ladder(index).Right + ladderOffSet Then
                    If Nansen.Bottom < ladder(index).Bottom And Nansen.Bottom > ladder(index).Top - ladderOffSet Then
                        Return True
                    End If
                End If
            ElseIf nstuff.Speed.Y = 0 Then
                If Nansen.Left > ladder(index).Left - ladderOffSet And Nansen.Right < ladder(index).Right + ladderOffSet Then
                    If Nansen.Bottom < ladder(index).Bottom - ladderOffSet And Nansen.Bottom > ladder(index).Top + ladderOffSet Then
                        Return True
                    End If
                End If
            End If
        Next index
        Return False
    End Function

    Public Sub floorSet()
        fStuff(0).x = 137
        fStuff(1).x = 137
        fStuff(2).x = 137
        fStuff(3).x = 137
        fStuff(4).x = 137
        fStuff(5).x = 137
        fStuff(6).x = 137

        fStuff(0).y = 465
        fStuff(1).y = 377
        fStuff(2).y = 327
        fStuff(3).y = 226
        fStuff(4).y = 176
        fStuff(5).y = 92
        fStuff(6).y = 42

        fStuff(0).slope = -0.000000001
        fStuff(1).slope = 0.078
        fStuff(2).slope = -0.078
        fStuff(3).slope = 0.078
        fStuff(4).slope = -0.078
        fStuff(5).slope = 0
        fStuff(6).slope = 0

        fStuff(0).leftEdge = 0
        fStuff(1).leftEdge = 0
        fStuff(2).leftEdge = 133
        fStuff(3).leftEdge = 0
        fStuff(4).leftEdge = 133
        fStuff(5).leftEdge = 0
        fStuff(6).leftEdge = 200

        fStuff(0).rightEdge = 570
        fStuff(1).rightEdge = 507
        fStuff(2).rightEdge = 570
        fStuff(3).rightEdge = 507
        fStuff(4).rightEdge = 570
        fStuff(5).rightEdge = 507
        fStuff(6).rightEdge = 312
    End Sub

    Private Function getFloorNumber(ByVal thingTop As Integer)
        If thingTop < 20 Then
            Return 6
        ElseIf thingTop < 73 Then
            Return 5
        ElseIf thingTop < 160 Then
            Return 4
        ElseIf thingTop < 240 Then
            Return 3
        ElseIf thingTop < 320 Then
            Return 2
        ElseIf thingTop < 393 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub jumping(ByRef sprite As SpriteType, ByVal height As Integer)
        If sprite.floatTime = height Then
            If sprite.Speed.Y = -5 Then
                sprite.Speed.Y = 5
            Else
                sprite.Speed.Y = 0
                sprite.floating = False
            End If
            sprite.floatTime = 1
        Else
            sprite.floatTime = sprite.floatTime + 1
        End If
    End Sub

    Private Sub moveAlongFloor(ByRef sprite As SpriteType, ByRef thing As PictureBox)
        sprite.Speed.Y = 0
        sprite.onFloor = True
        thing.Top = fStuff(sprite.floorNumber).slope * (thing.Left - fStuff(sprite.floorNumber).x) + fStuff(sprite.floorNumber).y - thing.Height
        If thing.Left > fStuff(sprite.floorNumber).rightEdge Then
            sprite.floating = True
            sprite.floatTime = 1
            sprite.Speed.Y = 5
        ElseIf thing.Right < fStuff(sprite.floorNumber).leftEdge Then
            sprite.floating = True
            sprite.floatTime = 1
            sprite.Speed.Y = 5
        End If
    End Sub

    Private Sub ballSet()
        ball(0) = Ball0
        ball(1) = Ball1
        ball(2) = Ball2
        ball(3) = Ball3
        Dim index As Integer
        For index = 0 To numBall
            bStuff(index).floating = False
            bStuff(index).onLadder = False
            bStuff(index).picNum = 1
            bStuff(index).Speed.X = 10
            bStuff(index).Speed.Y = 0
            ball(index).Top = 70
            ball(index).Left = 203
            ball(index).Visible = False
        Next index
    End Sub

    Private Sub moveBall(ByVal ball_index As Integer)
        bStuff(ball_index).floorNumber = getFloorNumber(ball(ball_index).Top)
        If bStuff(ball_index).floating = True Then
            Call jumping(bStuff(ball_index), 5)
        Else
            bStuff(ball_index).onLadder = ballCheckLadder(ball_index)
            If bStuff(ball_index).onLadder = False Then
                If fStuff(bStuff(ball_index).floorNumber).slope < 0 Then
                    bStuff(ball_index).Speed.X = -5
                Else
                    bStuff(ball_index).Speed.X = 5
                End If
                Call moveAlongFloor(bStuff(ball_index), ball(ball_index))
            Else
                bStuff(ball_index).Speed.X = 0
                bStuff(ball_index).Speed.Y = 10
                bStuff(ball_index).floating = True
            End If
        End If
        If (ball(ball_index).Left < 77 And bStuff(ball_index).Speed.X < 0) Or (ball(ball_index).Left > 540 And bStuff(ball_index).Speed.X > 0) Then
            bStuff(ball_index).Speed.X = 0
        End If

        If bStuff(ball_index).floorNumber = 0 And ball(ball_index).Left < 77 Then
            ball(ball_index).Visible = False
            If bobDancing = True Then
                bobDancing = False
                throwTimer = 0
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobStanding.jpg")
            End If
        End If

        ball(ball_index).Left = ball(ball_index).Left + bStuff(ball_index).Speed.X
        ball(ball_index).Top = ball(ball_index).Top + bStuff(ball_index).Speed.Y
    End Sub

    Private Function ballCheckLadder(ByVal bIndex As Integer)
        Dim index As Integer
        Dim ballLadderOffset As Integer
        ballLadderOffset = 13
        Randomize()
        randInt = Int(100 * Rnd())
        If randInt > 50 Then
            For index = 0 To numLadders
                If ball(bIndex).Left > ladder(index).Left And ball(bIndex).Right < ladder(index).Right Then
                    If ball(bIndex).Bottom + ballLadderOffset > ladder(index).Top And ball(bIndex).Bottom - ballLadderOffset < ladder(index).Top Then
                        Return True
                    End If
                End If
                Randomize()
            Next index
        End If
        Return False
    End Function

    Private Sub animateBall(ByVal ball_pic_index As Integer)
        If bStuff(ball_pic_index).picNum = 1 Then
            ball(ball_pic_index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\ball1.jpg")
            bStuff(ball_pic_index).picNum = 2
        ElseIf bStuff(ball_pic_index).picNum = 2 Then
            ball(ball_pic_index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\ball2.jpg")
            bStuff(ball_pic_index).picNum = 3
        ElseIf bStuff(ball_pic_index).picNum = 3 Then
            ball(ball_pic_index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\ball3.jpg")
            bStuff(ball_pic_index).picNum = 4
        ElseIf bStuff(ball_pic_index).picNum = 4 Then
            ball(ball_pic_index).Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\ball4.jpg")
            bStuff(ball_pic_index).picNum = 1
        End If
    End Sub

    Private Function touching(ByVal obj1 As PictureBox, ByVal obj2 As PictureBox)
        If obj1.Right > obj2.Left And obj1.Left < obj2.Right Then
            If obj1.Top < obj2.Bottom And obj1.Bottom > obj2.Top Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub resetLevel()
        Call floorSet()
        Call ladderSet()
        Call nansenSet()
        Call ballSet()
        bobDancing = False
    End Sub

    Private Sub nansenSet()
        nstuff.picNum = 1
        Nansen.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\nansenRightMove1.jpg")
        Nansen.Left = 84
        Nansen.Top = 435
        shieldOn = False
        Shield0.Visible = True
        Shield1.Visible = True
        Shield2.Visible = True
        shieldIndication.Visible = False
        nstuff.Speed.X = 0
        nstuff.Speed.Y = 0
        nstuff.onFloor = True
        nstuff.facingRight = True
    End Sub

    Private Sub ladderSet()
        nstuff.picNum = 1
        bStuff(0).picNum = 1
        ladder(0) = Ladder0
        ladder(1) = Ladder1
        ladder(2) = Ladder2
        ladder(3) = Ladder3
        ladder(4) = Ladder4
        ladder(5) = Ladder5
        Call floorSet()
        Call ballSet()
    End Sub

    Private Sub throwBall()
        Dim index As Integer
        Dim index2 As Integer
        Dim done As Boolean
        throwTimer += 1
        If throwTimer = 32 Then
            throwTimer = 0
            done = False
            Do While done = False
                If ball(index).Visible = False Then
                    done = True
                    ball(index).Visible = True
                    ball(index).Top = 70
                    ball(index).Left = 203
                    ball(index).Visible = True
                    bStuff(index).floating = False
                    bStuff(index).onLadder = False
                    bStuff(index).picNum = 1
                    bStuff(index).Speed.X = 10
                    bStuff(index).Speed.Y = 0
                    bobDancing = True
                    For index2 = 0 To 3
                        If ball(index2).Visible = False Then
                            bobDancing = False
                        End If
                    Next index2
                End If
                index += 1
                If index = 4 Then
                    done = True
                End If
            Loop
        End If
    End Sub

    Private Sub animateBob()
        If bobDancing = False Then
            If throwTimer > 30 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobRollingBall.jpg")
            ElseIf throwTimer > 15 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobHoldingBall.jpg")
            ElseIf throwTimer > 7 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobGettingBall.jpg")
            End If
        Else
            If throwTimer > 30 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobSmiling.jpg")
            ElseIf throwTimer > 22 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobDancing2.jpg")
            ElseIf throwTimer > 14 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobDancing.jpg")
            ElseIf throwTimer > 14 Then
                Bob.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\BobStanding.jpg")
            End If
        End If
    End Sub

    Private Sub flashHelp()
        If throwTimer = 30 Then
            If Help.Visible = True Then
                Help.Visible = False
            Else
                Help.Visible = True
            End If
        End If
    End Sub
End Class