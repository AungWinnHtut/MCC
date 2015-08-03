Imports System.IO
Public Class frmGame
    Dim iPos As Integer = 1
    Dim sPath As String = Directory.GetCurrentDirectory
    Private Sub btnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        Dim Generator As System.Random = New System.Random()
        Dim dice As Integer = Generator.Next(1, 7)

        picDice.Image = Image.FromFile(sPath + "\dice\" + dice.ToString() + ".png")
        iPos = iPos + dice
        subShowPlayer(iPos)
    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(sPath + "\dice\player.png")
        PictureBox1.Visible = True
    End Sub


    Public Sub subHide()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False
        PictureBox25.Visible = False
        PictureBox26.Visible = False
        PictureBox27.Visible = False
        PictureBox28.Visible = False
        PictureBox29.Visible = False
        PictureBox30.Visible = False
    End Sub

    Public Sub subShowPlayer(ByVal loc As Integer)
        subHide()
        Select Case loc
            Case 1
                PictureBox1.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox1.Visible = True
            Case 2
                PictureBox2.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox2.Visible = True
            Case 3
                PictureBox3.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox3.Visible = True
            Case 4
                PictureBox4.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox4.Visible = True
            Case 5
                PictureBox5.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox5.Visible = True
            Case 6
                PictureBox6.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox6.Visible = True
            Case 7
                PictureBox7.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox7.Visible = True
            Case 8
                PictureBox8.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox8.Visible = True
            Case 9
                PictureBox9.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox9.Visible = True
            Case 10
                PictureBox10.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox10.Visible = True
            Case 11
                PictureBox11.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox11.Visible = True
            Case 12
                PictureBox12.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox12.Visible = True
            Case 13
                PictureBox13.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox13.Visible = True
            Case 14
                PictureBox14.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox14.Visible = True
            Case 15
                PictureBox15.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox15.Visible = True
            Case 16
                PictureBox16.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox16.Visible = True
            Case 17
                PictureBox17.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox17.Visible = True
            Case 18
                PictureBox18.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox18.Visible = True
            Case 19
                PictureBox19.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox19.Visible = True
            Case 20
                PictureBox20.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox20.Visible = True
            Case 21
                PictureBox21.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox21.Visible = True
            Case 22
                PictureBox22.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox22.Visible = True
            Case 23
                PictureBox23.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox23.Visible = True
            Case 24
                PictureBox24.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox24.Visible = True
            Case 25
                PictureBox25.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox25.Visible = True
            Case 26
                PictureBox26.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox26.Visible = True
            Case 27
                PictureBox27.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox27.Visible = True
            Case 28
                PictureBox28.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox28.Visible = True
            Case 29
                PictureBox29.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox29.Visible = True
            Case 30
                PictureBox30.Image = Image.FromFile(sPath + "\dice\player.png")
                PictureBox30.Visible = True
            Case Else

        End Select
    End Sub

End Class
