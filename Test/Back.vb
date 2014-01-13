Public Class Back
    Private Sub Back_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        Me.Enabled = False
    End Sub

    Public Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        timem = timem + 1
    End Sub
End Class