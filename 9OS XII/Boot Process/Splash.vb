Public Class Splash
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
            Timer1.Enabled = False
            System.Diagnostics.Debug.WriteLine("Killing timer.")
        Else
            System.Diagnostics.Debug.WriteLine("Not ready for boot image, returning to loop!")
        End If
        System.Diagnostics.Debug.WriteLine("tick session over. waiting for next?")
    End Sub

    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("Splash Screen loaded.")
        System.Diagnostics.Debug.WriteLine("Boot Timer loaded.")
        Timer1.Enabled = True ' Start the BootScreen Timer
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Debug.WriteLine("stop clicking ya doinK!")
    End Sub
End Class
