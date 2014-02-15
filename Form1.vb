Public Class Form1
    'Delclarations
    Dim Key As Integer
    Dim Logs(SIZEOFLOGS) As PictureBox
    Const SIZEOFLOGS As Integer = 6
    Dim Cars(SIZEOFCARS) As PictureBox
    Const SIZEOFCARS As Integer = 14
    Dim onlog As Boolean
    Dim onslot As Boolean
    Dim CARSPEEDS(SIZEOFCARS) As Integer
    Dim LOGSPEEDS(SIZEOFLOGS) As Integer
    Public Shared loseForm As New DieForm
    Dim onlognbr As Integer
    Dim Slots(SIZEOFSLOTS) As PictureBox
    Const SIZEOFSLOTS = 5
    Dim flytimeout As Integer
    Dim SlotsFilled As Integer = 0
    Dim WinForm As New WinForm
    Dim Lives(8) As PictureBox
    Dim SIZEOFLIVES = 3
    Dim LivesAvailable As Integer = 2
    Dim froggerDead As Boolean = False ' global variable 
    Dim delay As Integer = 0
    Dim level As Integer = 1
    'Riding The Log Function
    Private Sub RideLog(ByVal index As Integer)
        Frogger.Left = Frogger.Left + LOGSPEEDS(index)
        Frogger.Top = Logs(index).Top + 10
    End Sub
    'Initialize Slots
    Private Sub Initlives()
        Lives(0) = life0
        Lives(1) = life1
        Lives(2) = life2
        Lives(3) = life3
        Lives(4) = life4
        Lives(5) = life5
        Lives(6) = life6
        Lives(7) = life7

    End Sub
    Private Sub CheckSlots()
        For uniquenameforslots = 0 To SIZEOFSLOTS - 1
            If Check(Frogger, Slots(uniquenameforslots)) And Slots(uniquenameforslots).Visible = False Then
                SlotsFilled += 1
                If SlotsFilled = SIZEOFSLOTS And level = 5 Then
                    WinForm.ShowDialog()
                    ResetLevel()
                    Slots(0).Visible = False
                    Slots(1).Visible = False
                    Slots(2).Visible = False
                    Slots(3).Visible = False
                    Slots(4).Visible = False
                    level = 1
                    Lvl.Text = 1
                    LOGSPEEDS(0) = -3
                    LOGSPEEDS(1) = -3
                    LOGSPEEDS(2) = 3
                    LOGSPEEDS(3) = 3
                    LOGSPEEDS(4) = 3
                    LOGSPEEDS(5) = 3
                    CARSPEEDS(0) = -2
                    CARSPEEDS(1) = -2
                    CARSPEEDS(2) = -2
                    CARSPEEDS(3) = 2
                    CARSPEEDS(4) = -2
                    CARSPEEDS(5) = -2
                    CARSPEEDS(6) = -2
                    CARSPEEDS(7) = -2
                    CARSPEEDS(8) = 2
                    CARSPEEDS(9) = 2
                    CARSPEEDS(10) = 2
                    CARSPEEDS(11) = 2
                    CARSPEEDS(12) = 2
                    LivesAvailable = 3
                    Lives(0).Visible = True
                    Lives(1).Visible = True
                    Lives(2).Visible = True
                    Lives(3).Visible = False
                    Lives(4).Visible = False
                    Lives(5).Visible = False
                    Lives(6).Visible = False
                    Lives(7).Visible = False


                ElseIf SlotsFilled = SIZEOFSLOTS Then
                    SlotsFilled = 0
                    'Resetting frogger
                    ResetLevel()
                    'resetting the slots
                    Slots(0).Visible = False
                    Slots(1).Visible = False
                    Slots(2).Visible = False
                    Slots(3).Visible = False
                    Slots(4).Visible = False
                    'increasing level
                    level += 1
                    Lvl.Text = level
                    'increase logspeed
                    LOGSPEEDS(0) += -2
                    LOGSPEEDS(1) += -2
                    LOGSPEEDS(2) += 2
                    LOGSPEEDS(3) += 2
                    LOGSPEEDS(4) += 2
                    LOGSPEEDS(5) += 2
                    'increase carspeed
                    CARSPEEDS(0) += -1
                    CARSPEEDS(1) += -1
                    CARSPEEDS(2) += -1
                    CARSPEEDS(3) += 1
                    CARSPEEDS(4) += -1
                    CARSPEEDS(5) += -1
                    CARSPEEDS(6) += -1
                    CARSPEEDS(7) += -1
                    CARSPEEDS(8) += 1
                    CARSPEEDS(9) += 1
                    CARSPEEDS(10) += 1
                    CARSPEEDS(11) += 1
                    CARSPEEDS(12) += 1
                Else
                    onslot = True
                    Slots(uniquenameforslots).Visible = True
                    ResetLevel()
                End If
            End If
        Next
    End Sub
    Private Sub InitSlots()
        Slots(0) = Slot0
        Slots(1) = slot1
        Slots(2) = slot2
        Slots(3) = slot3
        Slots(4) = slot4
    End Sub
    'Initialize logs
    Private Sub InitLogs()
        'log names
        Logs(0) = log
        Logs(1) = log1
        Logs(2) = log2
        Logs(3) = log3
        Logs(4) = log4
        Logs(5) = log5
        'log speeds
        LOGSPEEDS(0) = -3
        LOGSPEEDS(1) = -3
        LOGSPEEDS(2) = 3
        LOGSPEEDS(3) = 3
        LOGSPEEDS(4) = 3
        LOGSPEEDS(5) = 3
    End Sub
    'initialize cars
    Private Sub InitCars()
        'cars
        Cars(0) = car
        Cars(1) = car2
        Cars(2) = car3
        Cars(3) = car5
        Cars(4) = car6
        Cars(5) = car7
        Cars(6) = car8
        Cars(7) = car9
        Cars(8) = car10
        Cars(9) = car11
        Cars(10) = car13
        Cars(11) = car14
        Cars(12) = car15
        Cars(13) = car
        'carspeeds
        CARSPEEDS(0) = -2
        CARSPEEDS(1) = -2
        CARSPEEDS(2) = -2
        CARSPEEDS(3) = 2
        CARSPEEDS(4) = -2
        CARSPEEDS(5) = -2
        CARSPEEDS(6) = -2
        CARSPEEDS(7) = -2
        CARSPEEDS(8) = 2
        CARSPEEDS(9) = 2
        CARSPEEDS(10) = 2
        CARSPEEDS(11) = 2
        CARSPEEDS(12) = 2

    End Sub
    'killing frogger
    Private Sub KillFrogger()
        My.Computer.Audio.Play(My.Resources.Die, AudioPlayMode.Background)
        froggerDead = True
        Lives(LivesAvailable).Visible = False
        LivesAvailable -= 1
        ResetLevel()

        If LivesAvailable < 0 Then
            LivesAvailable = 2
            Lives(0).Visible = True
            Lives(1).Visible = True
            Lives(2).Visible = True
            Timer.Stop()
            ResetLevel()
            Hide()
            loseForm.ShowDialog()
            If loseForm.continueFlag Then
                loseForm.continueFlag = False
                ResetLevel()
                Timer.Start()
                LivesAvailable = 3
                Lives(0).Visible = True
                Lives(1).Visible = True
                Lives(2).Visible = True
                Lives(3).Visible = False
                Lives(4).Visible = False
                Lives(5).Visible = False
                Lives(6).Visible = False
                Lives(7).Visible = False
                Show()
                My.Computer.Audio.Play(My.Resources.frogger, AudioPlayMode.BackgroundLoop)
            ElseIf loseForm.quitFlag Then
                loseForm.quitFlag = False
                Close()
            End If
        End If

    End Sub
    Private Sub ResetLevel()
        Frogger.Left = 352
        Frogger.Top = 535
        If froggerDead = True Then
            Slots(0).Visible = False
            Slots(1).Visible = False
            Slots(2).Visible = False
            Slots(3).Visible = False
            Slots(4).Visible = False
        End If

        If delay > 5 Then
            My.Computer.Audio.Play(My.Resources.frogger, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Private Sub AnimateGrassFrogger()
        If Key = 39 Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2GrassRight.bmp")
        ElseIf Key = 37 Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2GrassLeft.bmp")
        ElseIf Key = 40 Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2GrassDown.bmp")
        ElseIf Key = 38 Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2GrassUp.bmp")
        End If
    End Sub
    Private Sub AnimateRoadFrogger()
        If Key = Keys.Right Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2RoadRight.bmp")
        ElseIf Key = Keys.Left Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2RoadLeft.bmp")
        ElseIf Key = Keys.Down Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2RoadDown.bmp")
        ElseIf Key = Keys.Up Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2RoadUp.bmp")
        End If
    End Sub
    Private Sub AnimateLogFrogger()
        If Key = Keys.Right Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2LogRight.bmp")
        ElseIf Key = Keys.Left Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2LogLeft.bmp")
        ElseIf Key = Keys.Down Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2LogDown.bmp")
        ElseIf Key = Keys.Up Then
            Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2LogUp.bmp")
        End If
    End Sub
    Private Function Check(ByVal anobject As PictureBox, ByVal anotherObj As PictureBox)
        Return (anobject.Right > anotherObj.Left And anotherObj.Right > anobject.Left) And (anotherObj.Bottom > anobject.Top And anotherObj.Top < anobject.Bottom)
    End Function
    Private Sub movelogs(ByVal logmoving As Integer)
        If Logs(logmoving).Left < -200 Then
            Logs(logmoving).Left = 800
        ElseIf Logs(logmoving).Left > 800 Then
            Logs(logmoving).Left = -200
        Else
            Logs(logmoving).Left += LOGSPEEDS(logmoving)
        End If
    End Sub
    Private Sub moveCars(ByVal carmoving As Integer)
        If Cars(carmoving).Left < -200 Then
            Cars(carmoving).Left = 800
        ElseIf Cars(carmoving).Left > 800 Then
            Cars(carmoving).Left = -200
        Else
            Cars(carmoving).Left += CARSPEEDS(carmoving)
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If flytimeout = 350 Then
            MoveFly()
            flytimeout = 0
        End If
        Something()
        flytimeout += 1
        onlog = False
        onslot = False
        AnimateFrogger()
        CheckSlots()
        'logs and cars
        For index = 0 To SIZEOFCARS - 1
            moveCars(index)
            If Check(Frogger, Cars(index)) Then
                Frogger.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\pics\frog2WaterRight.bmp")
                KillFrogger()
            End If
        Next
        For index = 0 To SIZEOFLOGS - 1
            If Check(Frogger, Logs(index)) Then
                onlog = True
                RideLog(index)
                AnimateLogFrogger()
            End If
            movelogs(index)
        Next
        If Frogger.Top < 200 And onlog = False And onslot = False Then
            KillFrogger()
        End If

        If froggerDead Then
            delay += 1
            If delay > 300 Then
                froggerDead = False
                delay = 0
                My.Computer.Audio.Play(My.Resources.frogger, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub
    Private Sub AnimateFrogger()
        If Frogger.Top > 487 Then
            AnimateGrassFrogger()
        ElseIf Frogger.Top < 487 And Frogger.Top > 392 Then
            AnimateRoadFrogger()
        ElseIf Frogger.Top < 392 And Frogger.Top > 336 Then
            AnimateGrassFrogger()
        ElseIf Frogger.Top < 336 And Frogger.Top > 238 Then
            AnimateRoadFrogger()
        ElseIf Frogger.Top < 238 And Frogger.Top > 184 Then
            AnimateGrassFrogger()
        End If
    End Sub
    'Init Actions
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        onlog = False
        Initlives()
        InitLogs()
        InitCars()
        InitSlots()
        Timer.Start()
        PlayAudio()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            Frogger.Top = Frogger.Top - 45
            Key = 38
        ElseIf e.KeyCode = Keys.Right Then
        If Frogger.Left < 780 Then
            Frogger.Left = Frogger.Left + 45
            Key = 39
        End If
        ElseIf e.KeyCode = Keys.Left Then
        If Frogger.Left > 0 Then
            Frogger.Left = Frogger.Left - 45
        End If
        Key = 37
        ElseIf e.KeyCode = Keys.Down Then
        If Frogger.Top < 600 Then
            Frogger.Top = Frogger.Top + 45
            Key = 40
        End If
            End If
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    'play the music
    Private Sub PlayAudio()
        My.Computer.Audio.Play(My.Resources.frogger, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MoveFly()
        If Not (fly.Visible) Then
            fly.Visible = True
        End If

        Dim x As Integer = Int(Rnd() * 765) + 1
        Dim y As Integer = Int(Rnd() * 582) + 1
        Dim location As New Point(x, y)
        fly.Location = location
    End Sub
    Private Sub Something()
        If Check(Frogger, fly) And fly.Visible = True And LivesAvailable < 7 Then
            LivesAvailable += 1
            Lives(LivesAvailable).Visible = True
            fly.Visible = False
        End If
    End Sub
End Class