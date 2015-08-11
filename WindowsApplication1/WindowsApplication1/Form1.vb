Imports System.IO
Public Class Snake Game
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Generator As System.Random = New System.Random()
        Dim dice As Integer = Generator.Next(1, 6)
        Dim sPath As String = vbDirectory.GetCurrentDirectory
        picDice.Image = Image.FromFile(sPath + "\dice\" + dice.ToString() + ".png")
    End Sub
End Class
