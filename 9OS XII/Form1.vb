Public Class Form1
    Dim BootScreenTick = 0 ' Set the Tick of the Timer to 0.
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BootScreenTick = BootScreenTick + 1 ' Increase the Tick
        System.Diagnostics.Debug.WriteLine("BootScreen Tick Occured. " + CStr(BootScreenTick))
        If BootScreenTick = 2 Then
            System.Diagnostics.Debug.WriteLine("Got Success! - Booting System!")
            PreUserArena.Show()
            System.Diagnostics.Debug.WriteLine("PreUserArena - Loading!")
            Me.Hide()
            System.Diagnostics.Debug.WriteLine("We are done here. Hiding Boot Image!")
        Else
            ' Do Nothing
        End If
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True ' Start the BootScreen Timer
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
