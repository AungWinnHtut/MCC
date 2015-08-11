Imports System.IO
Public Class frmGame
    Dim iPos As Integer = 1
    Dim iBiteCouter As Integer = 0
    Dim iLadderCounter As Integer = 0
    Dim sPath As String = Directory.GetCurrentDirectory
    Private Sub btnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        Dim Generator As System.Random = New System.Random()
        Dim dice As Integer = Generator.Next(1, 7)

        picDice.Image = Image.FromFile(sPath + "\dice\" + dice.ToString() + ".png")


        If (iPos + dice) <= 30 Then
            iPos = iPos + dice
        ElseIf (iPos + dice) > 30 Then
            iPos = 30 - (iPos + dice - 30)
        End If

        subShowPlayer(iPos)


        If iPos = 30 Then
            MessageBox.Show("You won!!!!  LEVEL UP ")
        End If

        If (iPos = 20) Then
            subShowPlayer(iPos)
            PictureBox20.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox20.Visible = True
            Timer8.Enabled = True
            iLadderCounter = iLadderCounter + 1
        End If


        If (iPos = 11) Then
            subShowPlayer(iPos)
            PictureBox11.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox11.Visible = True
            Timer2.Enabled = True
            iBiteCouter = iBiteCouter + 1
        End If

        If (iPos = 17) Then
            subShowPlayer(iPos)
            PictureBox17.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox17.Visible = True
            Timer2.Enabled = True
            iBiteCouter = iBiteCouter + 1
        End If

        If (iPos = 5) Then
            subShowPlayer(iPos)
            PictureBox5.Image = Image.FromFile(sPath + "\dice|Char1.GIF")
            PictureBox5.Visible = True
            Timer6.Enabled = True
            iLadderCounter = iLadderCounter + 1
        End If




        If (iPos = 19) Then
            subShowPlayer(iPos)
            PictureBox19.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox19.Visible = True
            Timer1.Enabled = True
            iBiteCouter = iBiteCouter + 1
        End If

        If (iPos = 3) Then
            subShowPlayer(iPos)
            PictureBox3.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox3.Visible = True
            Timer5.Enabled = True
            iLadderCounter = iLadderCounter + 1

        End If
        If (iPos = 21) Then
            subShowPlayer(iPos)
            PictureBox21.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox21.Visible = True
            Timer3.Enabled = True
            iBiteCouter = iBiteCouter + 1

        End If


        If (iPos = 27) Then
            subShowPlayer(iPos)
            PictureBox27.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
            PictureBox27.Visible = True
            Timer4.Enabled = True
            iBiteCouter = iBiteCouter + 1

        End If

        txtBite.Text = iBiteCouter.ToString()
        txtLadder.Text = iLadderCounter.ToString()

    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
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
                PictureBox1.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox1.Visible = True
            Case 2
                PictureBox2.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox2.Visible = True
            Case 3
                PictureBox3.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox3.Visible = True
            Case 4
                PictureBox4.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox4.Visible = True
            Case 5
                PictureBox5.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox5.Visible = True
            Case 6
                PictureBox6.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox6.Visible = True
            Case 7
                PictureBox7.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox7.Visible = True
            Case 8
                PictureBox8.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox8.Visible = True
            Case 9
                PictureBox9.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox9.Visible = True
            Case 10
                PictureBox10.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox10.Visible = True
            Case 11
                PictureBox11.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox11.Visible = True
            Case 12
                PictureBox12.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox12.Visible = True
            Case 13
                PictureBox13.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox13.Visible = True
            Case 14
                PictureBox14.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox14.Visible = True
            Case 15
                PictureBox15.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox15.Visible = True
            Case 16
                PictureBox16.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox16.Visible = True
            Case 17
                PictureBox17.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox17.Visible = True
            Case 18
                PictureBox18.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox18.Visible = True
            Case 19
                PictureBox19.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox19.Visible = True
            Case 20
                PictureBox20.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox20.Visible = True
            Case 21
                PictureBox21.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox21.Visible = True
            Case 22
                PictureBox22.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox22.Visible = True
            Case 23
                PictureBox23.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox23.Visible = True
            Case 24
                PictureBox24.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox24.Visible = True
            Case 25
                PictureBox25.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox25.Visible = True
            Case 26
                PictureBox26.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox26.Visible = True
            Case 27
                PictureBox27.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox27.Visible = True
            Case 28
                PictureBox28.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox28.Visible = True
            Case 29
                PictureBox29.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox29.Visible = True
            Case 30
                PictureBox30.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
                PictureBox30.Visible = True
            Case Else


        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox7.Image = Image.FromFile(sPath + "\dice\Char1.GIF")
        subHide()
        PictureBox7.Visible = True
        Timer1.Enabled = False
        iPos = 7
        subShowPlayer(iPos)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        subHide()
        iPos = 1
        subShowPlayer(iPos)
        txtLadder.Text = "0"
        txtBite.Text = "0"
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        subHide()
        PictureBox4.Visible = True
        Timer2.Enabled = False
        iPos = 4
        subShowPlayer(iPos)

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        subHide()
        PictureBox1.Visible = True
        Timer4.Enabled = False
        iPos = 1
        subShowPlayer(iPos)

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        subHide()
        PictureBox9.Visible = True
        Timer3.Enabled = False
        iPos = 9
        subShowPlayer(iPos)


    End Sub


    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        subHide()
        PictureBox22.Visible = True
        Timer5.Enabled = False
        iPos = 22
        subShowPlayer(iPos)
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        subHide()
        PictureBox8.Visible = True
        Timer6.Enabled = False
        iPos = 8
        subShowPlayer(iPos)

    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        subHide()
        PictureBox26.Visible = True
        Timer6.Enabled = False
        iPos = 26
        subShowPlayer(iPos)


    End Sub



    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        subHide()
        PictureBox29.Visible = True
        Timer8.Enabled = False
        iPos = 29
        subShowPlayer(iPos)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        txtBite.Text = "0"
        txtLadder.Text = "0"
    End Sub
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Thanks You. Play My Game <3 <3 <3 ")
        Application.Exit()

    End Sub

End Class