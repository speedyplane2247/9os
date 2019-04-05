Public Class BootServer
    ' build string syntax:
    ' ; 9os12 : Current OS Branch
    ' ; _alpha-build- : Current Mass Version Scale
    ' ; 214 : Current Build Number
    ' ; 04042019 : MON/DATE/YEAR
    ' ; 0802PMEST : 12 hour time w/ PM/AM selector + timezone
    Public BuildString = "9os12_alpha-build-217@04042019/0821PMEST"

    Private Sub BootServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide() ' get rekt #2, i'm new #1 and too lazy to remove previous commetn!
        Me.Visible = False ' first command to be executed, besides decs including buildstirng
        System.Diagnostics.Debug.WriteLine("System has started.")
        System.Diagnostics.Debug.WriteLine("System Version / Build : " + BuildString)
        Me.Visible = False ' does this work???
        Me.Hide()
        CoreOSKernel.Show()
        CoreOSKernel.Hide()
        ' don't want to have killing the kernel actually kill the os, this is a simple passthrough.

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class