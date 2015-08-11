Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loc As Integer = 1
        Dim gen As System.Random = New System.Random()
        Randomize()
        Dim dice As Integer = gen.Next(1, 7)

        TextBox1.Text = dice.ToString()
        Dim sPath As String = Directory.GetCurrentDirectory()
        TextBox2.Text = "i am " + dice.ToString() + " aung win htut"
        pic1.Image = Image.FromFile(sPath + "\pic\" + dice.ToString() + ".png")
        loc = loc + dice
        hide()
        Select Case loc
            Case 1 : PictureBox1.Visible = True
                PictureBox1.Image = Image.FromFile(sPath + "\pic\1.png")
            Case 2
                PictureBox2.Visible = True
                PictureBox2.Image = Image.FromFile(sPath + "\pic\1.png")
            Case 3
                PictureBox3.Visible = True
                PictureBox3.Image = Image.FromFile(sPath + "\pic\1.png")
            Case 4
                PictureBox4.Visible = True
                PictureBox4.Image = Image.FromFile(sPath + "\pic\1.png")



            Case Else

        End Select
    End Sub

    Sub hide()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub


End Class
