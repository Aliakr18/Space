Imports System.Drawing
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Media
Imports System.Runtime.InteropServices

Public Class level1
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    ' Movement
    Dim hotkey As Boolean
    Dim hotkey2 As Boolean
    Dim hotkey3 As Boolean
    Dim hotkey4 As Boolean
    Dim Loc As Point

    ' Pause Menu
    Dim hotkey5 As Boolean
    

    Private c1 As Rectangle
    Private c2 As Rectangle
    Private c3 As Rectangle
    Private c4 As Rectangle

    Dim AC As Integer
    Dim winv As Boolean

    ' Graphics
    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap

    ' Game Running?
    Public IsGameRunning As Boolean

    ' FPS Counter
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 0
    Dim MaxTicks As Integer = 0

    Private Shared ReadOnly RNG As New Random()

    Private Sub level1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Show()
        Me.Focus()

        'Windows.Forms.Cursor.Hide()

        IsGameRunning = True

        picPlayer.BringToFront()
        picEn.BringToFront()


        picAmmo.Hide()
        picAmmo2.Hide()
        picAmmo3.Hide()
        picAmmo4.Hide()
        picEnAm.Hide()

        picPointer.Hide()
        picPointer2.Hide()
        picPointer3.Hide()
        picPointer4.Hide()

        lbnehp.Text = ("500")
        eHP = 500
        lbnphp.Text = ("1000")
        pHP = 1000



        ' Initilaze Graphics Objects
        G = Me.CreateGraphics
        BB = New Bitmap(Me.Height, Me.Width)


        StartGameLoop()
    End Sub

    Private Sub StartGameLoop()
        Do While IsGameRunning = True

            ' Keep APP Responsive
            Application.DoEvents()

            ' Update Tick Counter
            TickCounter()

            ' Movement
            MovePlayer.Enabled = True

            ' Events
            RunGameEvents()

            ' Draw Graphics
            'DrawGraphics()

            ' Time
            Back.Time.Enabled = True
            timech.Text = timem

        Loop
    End Sub

    Private Sub TickCounter()
        If tSec = TimeOfDay.Second And IsGameRunning = True Then
            tTicks = tTicks + 1
        Else
            MaxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
        lblFPS.Text = MaxTicks
    End Sub

    Private Sub DrawGraphics()
        G.DrawString("Ticks: " & tTicks & vbCrLf & _
                     "TPS: " & MaxTicks, Me.Font, Brushes.White, 1808, 12)


        ' Copy BackBuffer To Graphics Object
        G = Graphics.FromImage(BB)

        ' Draw BackBuffer To Screen
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, Me.Height, Me.Width)

        ' Fix Overflow
        G.Clear(Color.Black)
    End Sub

    Private Sub RunGameEvents()

        If pHP <= 0 Then
            IsGameRunning = False
            winv = True
            MovePlayer.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            tmEnAm.Enabled = False
            Back.Time.Enabled = False
            picPlayer.Image = My.Resources.explosion
            Me.Refresh()
            MsgBox("You Lost.")
            logedin.Refresh()
            logedin.Show()
            logedin.BringToFront()
            logedin.Focus()
            Me.Close()
            Me.Refresh()
            Me.Close()
        End If

        If eHP <= 0 Then
            IsGameRunning = False
            winv = True
            MovePlayer.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            picEn.Image = My.Resources.explosion
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            Me.Refresh()
            System.Threading.Thread.Sleep(300)
            level2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MovePlayer_Tick(sender As Object, e As EventArgs) Handles MovePlayer.Tick
        hotkey = GetAsyncKeyState(Keys.W)
        hotkey2 = GetAsyncKeyState(Keys.A)
        hotkey3 = GetAsyncKeyState(Keys.S)
        hotkey4 = GetAsyncKeyState(Keys.D)
        hotkey5 = GetAsyncKeyState(Keys.Escape)

        If hotkey5 = True Then
            Dim m As New Menu1
            IsGameRunning = False
            openform = "level1"
            MovePlayer.Enabled = False
            Timer2.Enabled = False
            Back.Time.Enabled = False
            Timer3.Enabled = False
            Timer4.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            tmEnAm.Enabled = False
            Back.Time.Enabled = False
            m.Show()
            m.Refresh()
        End If

        If hotkey = True Then
            If piccheck <> 1 Then
                picPlayer.Image = My.Resources.playerU
            End If
            piccheck = 1
            If Not picPlayer.Location.Y - 5 < 0 Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
        End If

        If hotkey2 = True Then
            If piccheck <> 2 Then
                picPlayer.Image = My.Resources.playerL
            End If
            piccheck = 2
        If Not picPlayer.Location.X - 5 < 0 Then
            Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
            picPlayer.Location = Loc
            End If
        End If

        If hotkey3 = True Then
            If piccheck <> 3 Then
                picPlayer.Image = My.Resources.player
            End If
            piccheck = 3
        If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
            picPlayer.Location = Loc
            End If
        End If

        If hotkey4 = True Then
            If piccheck <> 4 Then
                picPlayer.Image = My.Resources.playerR
            End If
            piccheck = 4
        If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
            Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
            picPlayer.Location = Loc
            End If
        End If

        'picPointer.Location = MousePosition
        'picPointer.BringToFront()

    End Sub


    Private Sub level1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim amSize As Integer
        Dim afx As Integer
        Dim afy As Integer

        Dim x As Integer
        Dim y As Integer
        Dim xf As Integer
        Dim yf As Integer
        Dim asSize As Integer

        pSize = 240
        eSize = 200
        aSize = 20
        asSize = 35

        amSize = 750


        px = picPlayer.Location.X
        py = picPlayer.Location.Y
        ex = picEn.Location.X
        ey = picEn.Location.Y
        x = picAmmo.Location.X
        y = picAmmo.Location.Y

        pfx = px - 73
        pfy = py - 73
        efx = ex - 53
        efy = ey - 53
        xf = x - 9
        yf = y - 9

        ax = picEn.Location.X
        ay = picEn.Location.Y

        afx = ax - 330
        afy = ay - 300


        c1 = New Rectangle(pfx, pfy, pSize, pSize)
        c2 = New Rectangle(efx, efy, eSize, eSize)
        c3 = New Rectangle(xf, yf, asSize, asSize)
        c4 = New Rectangle(afx, afy, amSize, amSize)

        e.Graphics.DrawRectangle(Pens.Black, c1)
        e.Graphics.DrawRectangle(Pens.Black, c2)
        e.Graphics.DrawRectangle(Pens.Black, c3)
        e.Graphics.DrawRectangle(Pens.Black, c4)


        If winv = False Then
            If c1.IntersectsWith(c4) Then
                Timer2.Enabled = True
            Else
                Timer2.Enabled = False
            End If
        End If

        If c1.IntersectsWith(c2) Then
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If picPlayer.Location.X < picEn.Location.X Then
            picEn.Left = picEn.Left - 4
        End If
        If picPlayer.Location.X > picEn.Location.X Then
            picEn.Left = picEn.Left + 4
        End If
        If picPlayer.Location.Y < picEn.Location.Y Then
            picEn.Top = picEn.Top - 4
        End If
        If picPlayer.Location.Y > picEn.Location.Y Then
            picEn.Top = picEn.Top + 4
        End If

        'If picEn.Bounds.IntersectsWith(picPlayer.Bounds) Then
        '    pHP = pHP - 5
        '    lbnphp.Text = pHP
        '    Me.Refresh()
        'End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim mx As Integer = picPointer.Location.X
        Dim myl As Integer = picPointer.Location.Y



        AC = 1

        'Dim mx As Integer
        'Dim myl As Integer

        'mx = picEn.Location.X
        'myl = picEn.Location.Y

        If mx < picAmmo.Location.X Then
            picAmmo.Left = picAmmo.Left - 6
        End If
        If mx > picAmmo.Location.X Then
            picAmmo.Left = picAmmo.Left + 6
        End If
        If myl < picAmmo.Location.Y Then
            picAmmo.Top = picAmmo.Top - 6
        End If
        If myl > picAmmo.Location.Y Then
            picAmmo.Top = picAmmo.Top + 6
        End If

        If picAmmo.Bounds.IntersectsWith(picEn.Bounds) Then
            picAmmo.Hide()
            Dim loc As Point
            picAmmo.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo.Location = loc
            eHP = eHP - 5
            lbnehp.Text = eHP
            Timer3.Enabled = False
        End If

        'If picAmmo.Bounds.IntersectsWith(picPointer.Bounds) Then
        '    picAmmo.Hide()
        '    Dim loc As Point
        '    picAmmo.Enabled = True
        '    loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
        '    picAmmo.Location = loc
        '    eHP = eHP - 5
        '    lbnehp.Text = eHP
        '    Timer3.Enabled = False
        'End If

        If picAmmo.Bounds.IntersectsWith(picPointer.Bounds) Then
            picAmmo.Hide()
            Dim loc As Point
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo.Location = loc
            Timer3.Enabled = False
        End If

        If picAmmo.Bounds.Location = MousePosition Then
            picAmmo.Hide()
            Dim loc As Point
            picAmmo.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo.Location = loc
            Timer3.Enabled = False
        End If


        picAmmo.BringToFront()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        AC = 2

        Dim mx As Integer = picPointer2.Location.X
        Dim myl As Integer = picPointer2.Location.Y

        'Dim mx As Integer
        'Dim myl As Integer

        'mx = picEn.Location.X
        'myl = picEn.Location.Y

        If mx < picAmmo2.Location.X Then
            picAmmo2.Left = picAmmo2.Left - 6
        End If
        If mx > picAmmo2.Location.X Then
            picAmmo2.Left = picAmmo2.Left + 6
        End If
        If myl < picAmmo2.Location.Y Then
            picAmmo2.Top = picAmmo2.Top - 6
        End If
        If myl > picAmmo2.Location.Y Then
            picAmmo2.Top = picAmmo2.Top + 6
        End If

        If picAmmo2.Bounds.IntersectsWith(picEn.Bounds) Then
            picAmmo2.Hide()
            Dim loc As Point
            picAmmo2.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo2.Location = loc
            eHP = eHP - 5
            lbnehp.Text = eHP
            Timer5.Enabled = False
        End If

        If picAmmo2.Bounds.IntersectsWith(picPointer2.Bounds) Then
            picAmmo2.Hide()
            Dim loc As Point
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo2.Location = loc
            Timer5.Enabled = False
        End If

        If picAmmo2.Bounds.Location = MousePosition Then
            picAmmo2.Hide()
            Dim loc As Point
            picAmmo2.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo2.Location = loc
            Timer5.Enabled = False
        End If


        picAmmo2.BringToFront()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick

        AC = 3

        Dim mx As Integer = picPointer3.Location.X
        Dim myl As Integer = picPointer3.Location.Y

        'Dim mx As Integer
        'Dim myl As Integer

        'mx = picEn.Location.X
        'myl = picEn.Location.Y

        If mx < picAmmo3.Location.X Then
            picAmmo3.Left = picAmmo3.Left - 6
        End If
        If mx > picAmmo3.Location.X Then
            picAmmo3.Left = picAmmo3.Left + 6
        End If
        If myl < picAmmo3.Location.Y Then
            picAmmo3.Top = picAmmo3.Top - 6
        End If
        If myl > picAmmo3.Location.Y Then
            picAmmo3.Top = picAmmo3.Top + 6
        End If

        If picAmmo3.Bounds.IntersectsWith(picEn.Bounds) Then
            picAmmo3.Hide()
            Dim loc As Point
            picAmmo3.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo3.Location = loc
            eHP = eHP - 5
            lbnehp.Text = eHP
            Timer6.Enabled = False
        End If

        If picAmmo3.Bounds.IntersectsWith(picPointer3.Bounds) Then
            picAmmo3.Hide()
            Dim loc As Point
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo3.Location = loc
            Timer6.Enabled = False
        End If

        If picAmmo3.Bounds.Location = MousePosition Then
            picAmmo3.Hide()
            Dim loc As Point
            picAmmo3.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo3.Location = loc
            Timer6.Enabled = False
        End If


        picAmmo3.BringToFront()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        AC = 0

        Dim mx As Integer = picPointer4.Location.X
        Dim myl As Integer = picPointer4.Location.Y

        'Dim mx As Integer
        'Dim myl As Integer

        'mx = picEn.Location.X
        'myl = picEn.Location.Y

        If mx < picAmmo4.Location.X Then
            picAmmo4.Left = picAmmo4.Left - 6
        End If
        If mx > picAmmo4.Location.X Then
            picAmmo4.Left = picAmmo4.Left + 6
        End If
        If myl < picAmmo4.Location.Y Then
            picAmmo4.Top = picAmmo4.Top - 6
        End If
        If myl > picAmmo4.Location.Y Then
            picAmmo4.Top = picAmmo4.Top + 6
        End If

        If picAmmo4.Bounds.IntersectsWith(picEn.Bounds) Then
            picAmmo4.Hide()
            Dim loc As Point
            picAmmo4.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo4.Location = loc
            eHP = eHP - 5
            lbnehp.Text = eHP
            Timer7.Enabled = False
        End If

        If picAmmo4.Bounds.IntersectsWith(picPointer4.Bounds) Then
            picAmmo4.Hide()
            Dim loc As Point
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo4.Location = loc
            Timer7.Enabled = False
        End If

        If picAmmo4.Bounds.Location = MousePosition Then
            picAmmo4.Hide()
            Dim loc As Point
            picAmmo4.Enabled = True
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo4.Location = loc
            Timer7.Enabled = False
        End If


        picAmmo4.BringToFront()
    End Sub

    Private Sub tmEnAm_Tick(sender As Object, e As EventArgs) Handles tmEnAm.Tick
        Dim mx As Integer
        Dim myl As Integer

        mx = picPlayer.Location.X
        myl = picPlayer.Location.Y

        picEnAm.Show()

        If mx < picEnAm.Location.X Then
            picEnAm.Left = picEnAm.Left - 6
        End If
        If mx > picEnAm.Location.X Then
            picEnAm.Left = picEnAm.Left + 6
        End If
        If myl < picEnAm.Location.Y Then
            picEnAm.Top = picEnAm.Top - 6
        End If
        If myl > picEnAm.Location.Y Then
            picEnAm.Top = picEnAm.Top + 6
        End If

        If picEnAm.Bounds.IntersectsWith(picPlayer.Bounds) Then
            picEnAm.Hide()
            Dim loc As Point
            loc = New Point(picEn.Location.X, picEn.Location.Y)
            picEnAm.Location = loc
            pHP = pHP - 15
            lbnphp.Text = pHP
            tmEnAm.Enabled = False
            Timer4.Enabled = True
        End If

        picEnAm.BringToFront()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim loc As Point
        loc = New Point(picEn.Location.X, picEn.Location.Y)
        picEnAm.Location = loc

        If winv = False Then
            tmEnAm.Enabled = True
            Timer4.Enabled = False
        End If

    End Sub

    Private Sub level1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim loc As Point

        If AC = 0 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo.Location = loc
            picAmmo.Show()
            Timer3.Enabled = True
            picPointer.Location = MousePosition
        ElseIf AC = 1 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo2.Location = loc
            picAmmo2.Show()
            Timer5.Enabled = True
            picPointer2.Location = MousePosition
        ElseIf AC = 2 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo3.Location = loc
            picAmmo3.Show()
            Timer6.Enabled = True
            picPointer3.Location = MousePosition
        ElseIf AC = 3 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo4.Location = loc
            picAmmo4.Show()
            Timer7.Enabled = True
            picPointer4.Location = MousePosition
        End If

    End Sub

    Private Sub picEn_Click(sender As Object, e As EventArgs) Handles picEn.Click
        Dim loc As Point

        If AC = 0 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo.Location = loc
            picAmmo.Show()
            Timer3.Enabled = True
            picPointer.Location = MousePosition
        ElseIf AC = 1 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo2.Location = loc
            picAmmo2.Show()
            Timer5.Enabled = True
            picPointer2.Location = MousePosition
        ElseIf AC = 2 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo3.Location = loc
            picAmmo3.Show()
            Timer6.Enabled = True
            picPointer3.Location = MousePosition
        ElseIf AC = 3 Then
            loc = New Point(picPlayer.Location.X, picPlayer.Location.Y)
            picAmmo4.Location = loc
            picAmmo4.Show()
            Timer7.Enabled = True
            picPointer4.Location = MousePosition
        End If

    End Sub
End Class