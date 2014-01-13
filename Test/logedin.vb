Public Class logedin

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Call Msgbox_Yes_No()

    End Sub

    'Sub Play()
    '    My.Computer.Audio.Play(My.Resources.Lost,
    '          AudioPlayMode.BackgroundLoop)
    '    Me.Close()
    'End Sub

    Private Sub Msgbox_Yes_No()
        Dim Response As Integer

        level1.Show()
        Back.Time.Enabled = True
        Me.Close()

        '' Displays a message box with the yes and no options.
        'Response = MsgBox(Prompt:="Do you want to see the tutorial?", Buttons:=vbYesNo)

        '' If statement to check if the yes button was selected.
        'If Response = vbYes Then
        '    'tut.Show()
        '    Me.Close()
        'Else
        '    ' The no button was selected.
        '    'worldselect.Show()
        '    Me.Close()
        'End If

    End Sub

    Private Sub Msgbox_newg()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="If you erase your file you will loose your progress, are you sure you want to erase your file?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then


            If IO.File.Exists("username1") = True Then
                inuser = IO.File.OpenText("username1")
                Do Until inuser.Peek = -1
                    load1 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load1 Then
                    strLogedin = "username1"
                End If
            End If
            If IO.File.Exists("username2") = True Then
                inuser = IO.File.OpenText("username2")
                Do Until inuser.Peek = -1
                    load2 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load2 Then
                    strLogedin = "username2"
                End If
            End If
            If IO.File.Exists("username3") = True Then
                inuser = IO.File.OpenText("username3")
                Do Until inuser.Peek = -1
                    load3 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load3 Then
                    strLogedin = "username3"
                End If
            End If

            My.Computer.FileSystem.DeleteFile(strLogedin)

            If IO.File.Exists(strname) = True Then
                My.Computer.FileSystem.DeleteFile(strname)
            End If


            If IO.File.Exists(strname & "level") = True Then
                My.Computer.FileSystem.DeleteFile(strname & "level")
            End If

            If IO.File.Exists(strname & "player") = True Then
                My.Computer.FileSystem.DeleteFile(strname & "player")
            End If

            If IO.File.Exists("logedin") = True Then
                My.Computer.FileSystem.DeleteFile("logedin")
            End If

            Form1.Show()
            Me.Close()

        Else
            ' The no button was selected.
            Me.Refresh()
        End If

    End Sub

    Private Sub logedin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        intread2 = 0

        If IO.File.Exists("logedin") = True Then
            inuser = IO.File.OpenText("logedin")
            Do Until inuser.Peek = -1
                ' read a name
                strname = inuser.ReadLine
                If IO.File.Exists(strname) = True Then
                    inupdate = IO.File.OpenText(strname)

                    strread = inupdate.ReadLine

                    intread = strread.ToString

                    strshow = intread

                    inupdate.Close()
                Else
                    strshow = ("0")
                End If
            Loop
            inuser.Close()
        End If


        If IO.File.Exists(strname & "time") = True Then
            inupdate2 = IO.File.OpenText(strname & "time")

            strread2 = inupdate2.ReadLine

            intread2 = strread2.ToString

            strshow2 = intread2

            inupdate2.Close()
        End If

        lblscore.Text = strshow2 & " " & "Seconds"
        Me.Refresh()

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Msgbox_newg()

    End Sub
End Class