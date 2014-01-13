Public Class login
    Dim inupdate As IO.StreamReader
    Dim outuser As IO.StreamWriter
    Dim inuser As IO.StreamReader
    Dim inuser2 As IO.StreamReader
    Dim inuser3 As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String
    Public strname As String
    Private load1, load2, load3 As String
    Private loged As IO.StreamWriter

    'Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs)

    '    Dim inuser As IO.StreamReader
    '    Dim inpass As IO.StreamReader
    '    Dim loged As IO.StreamWriter
    '    Dim strpass As String
    '    Dim strshow As String

    '    Dim users(1, 0) As String
    '    Dim check(1, 0) As String

    '    check(0, 0) = txtName.Text
    '    check(1, 0) = txtPass.Text

    '    If check(0, 0) = String.Empty Or check(1, 0) = String.Empty Then
    '        MsgBox("Username or password can't be empty")
    '    Else
    '        If IO.File.Exists("usernames") = True And IO.File.Exists("passwords") = True Then
    '            inuser = IO.File.OpenText("usernames")
    '            inpass = IO.File.OpenText("passwords")
    '            Do Until inuser.Peek = -1 And inpass.Peek = -1
    '                ' read a name
    '                strname = inuser.ReadLine
    '                users(0, 0) = strname
    '                strpass = inpass.ReadLine
    '                users(1, 0) = strpass
    '                If users(0, 0) = check(0, 0) And users(1, 0) = check(1, 0) Then
    '                    loged = IO.File.CreateText("logedin")
    '                    loged.WriteLine(strname)
    '                    loged.Close()
    '                    logedin.Show()
    '                    Me.Close()
    '                End If
    '            Loop
    '            ' close the file
    '            inuser.Close()
    '            inpass.Close()
    '        Else
    '            MsgBox("Username or Password dosn't exist")
    '        End If


    '        If IO.File.Exists(strname) = True Then
    '            If IO.File.Exists("logedin") = True Then
    '                inupdate = IO.File.OpenText("logedin")

    '                strread = inupdate.ReadLine

    '                inupdate.Close()

    '                inupdate = IO.File.OpenText(strread)

    '                strshow = inupdate.ReadLine

    '                inupdate.Close()

    '                logedin.lblupdate.Text = strshow
    '                Me.Refresh()
    '            Else
    '                logedin.lblupdate.Text = 0
    '                Me.Refresh()
    '            End If
    '        Else
    '            logedin.lblupdate.Text = 0
    '            Me.Refresh()
    '        End If
    '    End If



    'txtName.Text = String.Empty
    'txtPass.Text = String.Empty
    'txtName.Focus()

    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        Dim write As String
        If btn1.Text = "New Game" Then
            write = InputBox("Enter name")
            If write = String.Empty Then
                MsgBox("Name can't be empty")
            Else
                If write = load2 Or write = load3 Then
                    MsgBox("Username already exists.")
                Else
                    outuser = IO.File.AppendText("username1")
                    outuser.WriteLine(write.ToString)
                    btn1.Text = write
                    outuser.Close()
                    load1 = write
                    outuser.Close()
                    Me.Refresh()
                End If
            End If
            
        Else
            inuser = IO.File.OpenText("username1")
            Do Until inuser.Peek = -1
                load1 = inuser.ReadLine
            Loop
            inuser.Close()
            loged = IO.File.CreateText("logedin")
            loged.WriteLine(load1)
            loged.Close()
            logedin.Show()
            Me.Close()
        End If
        Me.Refresh()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        load1 = String.Empty
        load2 = String.Empty
        load3 = String.Empty

        If IO.File.Exists("username1") = True Then
            inuser = IO.File.OpenText("username1")
            Do Until inuser.Peek = -1
                load1 = inuser.ReadLine
            Loop
            inuser.Close()
            btn1.Text = load1
        End If
        If IO.File.Exists("username2") = True Then
            inuser2 = IO.File.OpenText("username2")
            Do Until inuser2.Peek = -1
                load2 = inuser2.ReadLine
            Loop
            inuser2.Close()
            btn2.Text = load2
        End If
        If IO.File.Exists("username3") = True Then
            inuser3 = IO.File.OpenText("username3")
            Do Until inuser3.Peek = -1
                load3 = inuser3.ReadLine
            Loop
            inuser3.Close()
            btn3.Text = load3
        End If
        Me.Refresh()
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        Dim write2 As String
        If btn2.Text = "New Game" Then
            write2 = InputBox("Enter name")
            If write2 = String.Empty Then
                MsgBox("Name can't be empty")
            Else
                If write2 = load1 Or write2 = load3 Then
                    MsgBox("Username already exists.")
                Else
                    outuser = IO.File.AppendText("username2")
                    outuser.WriteLine(write2.ToString)
                    btn2.Text = write2
                    load2 = write2
                    outuser.Close()
                    Me.Refresh()
                End If
            End If
            
        Else
            inuser = IO.File.OpenText("username2")
            Do Until inuser.Peek = -1
                load2 = inuser.ReadLine
            Loop
            inuser.Close()
            loged = IO.File.CreateText("logedin")
            loged.WriteLine(load2)
            loged.Close()
            logedin.Show()
            Me.Close()
        End If
        Me.Refresh()
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        Dim write3 As String
        If btn3.Text = "New Game" Then
            write3 = InputBox("Enter name")
            If write3 = String.Empty Then
                MsgBox("Name can't be empty")
            Else
                If write3 = load1 Or write3 = load2 Then
                    MsgBox("Username already exists.")
                Else
                    outuser = IO.File.AppendText("username3")
                    outuser.WriteLine(write3.ToString)
                    btn3.Text = write3
                    outuser.Close()
                    load3 = write3
                    outuser.Close()
                    Me.Refresh()
                End If
            End If

        Else
            inuser = IO.File.OpenText("username3")
            Do Until inuser.Peek = -1
                load3 = inuser.ReadLine
            Loop
            inuser.Close()
            loged = IO.File.CreateText("logedin")
            loged.WriteLine(load3)
            loged.Close()
            logedin.Show()
            Me.Close()
        End If
        Me.Refresh()
    End Sub
End Class
