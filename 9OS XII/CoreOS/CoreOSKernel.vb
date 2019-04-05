Public Class CoreOSKernel
    Public isServerUp = 1
    Private Sub CoreOSKernel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False ' doubt this works
        Me.Hide()
        System.Diagnostics.Debug.WriteLine("Kernel Loaded. I am now waiting.")
        System.Diagnostics.Debug.WriteLine("About to launch splash!")
        Splash.Show()

    End Sub
    Public Function killKernel()
        System.Diagnostics.Debug.WriteLine("Attempt to kill kernel recieved.")
        If isServerUp = 1 Then
            isServerUp = 0
            System.Diagnostics.Debug.WriteLine("System is going down.")
            System.Diagnostics.Debug.WriteLine("Notice: Killing the kernel WILL NOT cause any visible damage, but applications will fail! (if they need kernel access, that is)")
            Me.Close()
        Else
            System.Diagnostics.Debug.WriteLine("Can't run kernel function while kernel is down!")
        End If
        Return "done>"
    End Function
    Public Function shutdown()
        System.Diagnostics.Debug.WriteLine("Attempt to kill system recieved.")
        If isServerUp = 1 Then
        System.Diagnostics.Debug.WriteLine("System is going down hard.")
        BootServer.Close() ' needs updated if core boot server is changed.
        Else
            System.Diagnostics.Debug.WriteLine("Can't run kernel function while kernel is down!")
        End If
        Return "done>"
    End Function
    Public Function altreset()
        ' reset in case of can't find / doesn't exist.
        System.Diagnostics.Debug.WriteLine("reseting tables.")
        MsgBox("You are trying to reset Login Tables. Doing this requires an at least 64 MB U:\ drive that is empty. Ensure this exists before continueing.")
        System.Diagnostics.Debug.WriteLine("user allows continue.")
        Shell("C:\Windows\System32\cmd.exe /k mkdir U:\9osxil")
        Shell("C:\Windows\System32\cmd.exe /k mkdir U:\9osxil\lt")
        Shell("C:\Windows\System32\cmd.exe /k echo boot > U:\9osxil\lt\fpw.k")
        Shell("C:\Windows\System32\cmd.exe /k echo boot > U:\9osxil\lt\fur.k")
        MsgBox("Login tables rebuilt. Username & password is 'boot'.")
        Return "done>"
    End Function
End Class