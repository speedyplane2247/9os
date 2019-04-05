Public Class LoginServer
    Public authUSR = "boot" ' temp passwords.
    Public authPWD = "boot"
    ' above words are for if the login tables fail to load.
    Public passReader = My.Computer.FileSystem.ReadAllText("U:\9osxil\lt\fpw.k").Trim()
    Public userReader = My.Computer.FileSystem.ReadAllText("U:\9osxil\lt\fur.k").Trim()
    Private Sub LoginServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("loading login server.")
        Me.Visible = False ' login server shouldn't be seen, but should exist.
        ' not wanting to use classes / other non-recallable code paths.
        '   Dim passReader As String

        ' ; ' Dim userReader As String
        
        Login.Show()
    End Sub
    Public Function resetLoginTables()
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
    Public Function isAuth(ByVal username As String, ByVal password As String)
        System.Diagnostics.Debug.WriteLine(username)
        System.Diagnostics.Debug.WriteLine(password)
        System.Diagnostics.Debug.WriteLine("c")
        System.Diagnostics.Debug.WriteLine(userReader)
        System.Diagnostics.Debug.WriteLine(passReader)
        If username = userReader And password = passReader Then
            Return "true"
        Else
            Return "false"
        End If

        'End If
    End Function
End Class