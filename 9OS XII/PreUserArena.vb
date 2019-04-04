Imports System.Windows.Forms

Public Class PreUserArena
    Private Sub PreUserArena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Welcome to the PreUserArena - the Area where nothing but the Login Window should run.
        SystemEventsTimer.Enabled = True ' Enable the SystemEvents Timer
        PreUserChangelog.MdiParent = Me
        PreUserChangelog.Show()
    End Sub

    Private Sub SystemEventsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemEventsTimer.Tick
        ' Do something to check here!
    End Sub
End Class
