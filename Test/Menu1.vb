Public Class Menu1

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles b2.Click
        Call Msgboxclose()
    End Sub

    Private Sub b3_Click(sender As System.Object, e As System.EventArgs) Handles b3.Click


        If openform = "level1" Then
            level1.MovePlayer.Enabled = True
            level1.Timer2.Enabled = True
            level1.Timer3.Enabled = True
            level1.Timer4.Enabled = True
            level1.Timer5.Enabled = True
            level1.Timer6.Enabled = True
            level1.Timer7.Enabled = True
            level1.tmEnAm.Enabled = True
            level1.Refresh()
        End If

        If openform = "level2" Then
            level2.Timer1.Enabled = True
            level2.Timer2.Enabled = True
            level2.Timer3.Enabled = True
            level2.Timer4.Enabled = True
            level2.Timer5.Enabled = True
            level2.Timer6.Enabled = True
            level2.Timer7.Enabled = True
            level2.tmEnAm.Enabled = True
            level2.Refresh()
        End If

        If openform = "level3" Then
            level3.Timer1.Enabled = True
            level3.Timer2.Enabled = True
            level3.Timer3.Enabled = True
            level3.Timer4.Enabled = True
            level3.Timer5.Enabled = True
            level3.Timer6.Enabled = True
            level3.Timer7.Enabled = True
            level3.tmEnAm.Enabled = True
            level3.Refresh()
        End If

        Back.Time.Enabled = True

        Call closeme()

    End Sub

    Private Sub closeme()
        Menu2.Hide()
        Menu2.Close()
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub Menu1_KeyPress(KeyAscii As Integer)
        KeyAscii = 0
    End Sub

    Private Sub GMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Menu2.Show()
        'Windows.Forms.Cursor.Show()
        'Windows.Forms.Cursor.Show()
        Me.BringToFront()
        Me.Refresh()
    End Sub

    Private Sub Msgboxclose()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Are you sure you want to quit?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then
            level1.IsGameRunning = False
            Application.Exit()
        Else
            ' The no button was selected.
            Me.Refresh()
        End If

    End Sub

    Private Sub Msgboxmenu()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Are you sure you want to go to the menu?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then

            If IO.File.Exists(strname & "gold") = True Then
                inupdate2 = IO.File.OpenText(strname & "gold")

                strread2 = inupdate2.ReadLine

                intread2 = strread2.ToString

                strshow2 = intread2

                inupdate2.Close()
            Else
                strshow2 = ("0")
            End If

            logedin.lblscore.Text = strshow


            If openform = "level1" Then
                level1.MovePlayer.Enabled = False
                level1.Timer2.Enabled = False
                level1.Timer3.Enabled = False
                level1.Timer4.Enabled = False
                level1.Timer5.Enabled = False
                level1.Timer6.Enabled = False
                level1.Timer7.Enabled = False
                level1.tmEnAm.Enabled = False
                level1.Refresh()
                level1.Close()
            End If

            If openform = "level2" Then
                level2.Timer1.Enabled = False
                level2.Timer2.Enabled = False
                level2.Timer3.Enabled = False
                level2.Timer4.Enabled = False
                level2.Timer5.Enabled = False
                level2.Timer6.Enabled = False
                level2.Timer7.Enabled = False
                level2.tmEnAm.Enabled = False
                level2.Refresh()
                level2.Close()
            End If

            If openform = "level3" Then
                level3.Timer1.Enabled = False
                level3.Timer2.Enabled = False
                level3.Timer3.Enabled = False
                level3.Timer4.Enabled = False
                level3.Timer5.Enabled = False
                level3.Timer6.Enabled = False
                level3.Timer7.Enabled = False
                level3.tmEnAm.Enabled = False
                level3.Refresh()
                level3.Close()
            End If

            Back.Time.Enabled = False

            Menu2.Close()


            logedin.Refresh()
            logedin.Show()

            Me.Close()

            Me.Refresh()
            Me.Close()

        Else
            ' The no button was selected.
            Me.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeUp), 0, 0, 0)
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeDown), 0, 0, 0)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeMute), 0, 0, 0)
    End Sub

    Private Sub b1_Click(sender As System.Object, e As System.EventArgs) Handles b1.Click
        Call Msgboxmenu()
    End Sub
End Class