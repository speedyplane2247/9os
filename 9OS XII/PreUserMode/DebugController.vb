Public Class DebugController

    Private Sub DebugController_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("Loaded debugcontroller succesfully.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "show login" Then
            System.Diagnostics.Debug.WriteLine("Showing login prompt.")
            System.Diagnostics.Debug.WriteLine("Executed command : 'show login'")
            LoginServer.Show()
            LoginServer.Hide() ' should do this, but for compatibility here it is.
            Login.Show()
        End If
        If TextBox1.Text = "disable debug" Then
            System.Diagnostics.Debug.WriteLine("Disabling debug mode. (this session)")
            System.Diagnostics.Debug.WriteLine("Set isDebugBuild to 0.")
            PreUserArena.isDebugBuild = 0
            MsgBox("Critical Error: An application is attempting to apply the Debug Controller to a non-debug system.", vbCritical) ' placeholder until real kernel implementation next build!
            ' this string will be part of the system once the larger plan I'm working on is fully ready.
            Me.Close() ' actually kill the program.
        End If
    End Sub
End Class