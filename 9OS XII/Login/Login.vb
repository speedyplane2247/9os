Public Class Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        System.Diagnostics.Debug.WriteLine("sent token to auth server")
        If LoginServer.isAuth(UsernameTextBox.Text, PasswordTextBox.Text).Equals("true") = True Then
            MsgBox("login success")
        Else
            MsgBox("login failed")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Hide()

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' todo: add a usuable image~ 
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginServer.resetLoginTables()
    End Sub
End Class
