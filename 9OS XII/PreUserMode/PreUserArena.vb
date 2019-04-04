Imports System.Windows.Forms

Public Class PreUserArena
    Dim isDebugBuild = 1
    Private Sub PreUserArena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Welcome to the PreUserArena - the Area where nothing but the Login Window should run.
        System.Diagnostics.Debug.WriteLine("Loaded PUA mode.")
        SystemEventsTimer.Enabled = True ' Enable the SystemEvents Timer
        System.Diagnostics.Debug.WriteLine("Enabled SET timer.")
        PreUserChangelog.MdiParent = Me ' set the window style to child of this
        PreUserChangelog.Show() ' show this window!
        System.Diagnostics.Debug.WriteLine("Created Changelog object")
        ' lets create the DebugController window.
        If isDebugBuild = 1 Then
            System.Diagnostics.Debug.WriteLine("Debug Build true")
            System.Diagnostics.Debug.WriteLine("Loading Debug Controller.")
            DebugController.MdiParent = Me
            DebugController.Show()
        Else
            System.Diagnostics.Debug.WriteLine("debug build false; not dropping debug console.")
            ' do literally nothing
        End If
    End Sub

    Private Sub SystemEventsTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemEventsTimer.Tick
        ' Do something to check here!
    End Sub
End Class
