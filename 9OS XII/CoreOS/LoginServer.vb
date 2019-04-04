Public Class LoginServer
    Public authUSR = "boot" ' temp passwords.
    Public authPWD = "boot"

    Private Sub LoginServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Diagnostics.Debug.WriteLine("loading login server.")
        Me.Visible = False ' login server shouldn't be seen, but should exist.
        ' not wanting to use classes / other non-recallable code paths.
        Dim passReader As String
        Dim userReader As String
        Try
            passReader = My.Computer.FileSystem.ReadAllText("U:\9osxi\fpw.k")
            userReader = My.Computer.FileSystem.ReadAllText("U:\9osxi\fur.k")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("failed to get login data.")
            MsgBox("OS Critical Error: Cannot find login database. Caller: module_coreos\loginserver.")
        End Try
        
    End Sub
End Class