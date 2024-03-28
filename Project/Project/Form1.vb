Public Class Form1
    Dim total As Integer
    Private Sub totalTB_TextChanged(sender As Object, e As EventArgs) Handles totalTB.TextChanged
        total = totalTB.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles septumBuy.Click
        septumPB1.Visible = False
        septumPB2.Visible = True
        totalTB.Text = (total + 20)
        '$20
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles noseBuy.Click
        nosePB1.Visible = False
        nosePB2.Visible = True
        totalTB.Text = (total + 20)
        '$20
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles tongueBuy.Click
        tonguePB1.Visible = False
        tonguePB2.Visible = True
        totalTB.Text = (total + 80)
        '$80
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles earBuy.Click
        earPB1.Visible = False
        earPB2.Visible = True
        totalTB.Text = (total + 35)
        '$35
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bridgeBuy.Click
        bridgePB1.Visible = False
        bridgePB2.Visible = True
        totalTB.Text = (total + 65)
        '$65
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles lipBuy.Click
        lipPB1.Visible = False
        lipPB2.Visible = True
        totalTB.Text = (total + 80)
        '$80
    End Sub
    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        septumPB1.Visible = True
        nosePB1.Visible = True
        tonguePB1.Visible = True
        earPB1.Visible = True
        bridgePB1.Visible = True
        lipPB1.Visible = True
        totalTB.Text = "0"
        septumPB2.Visible = False
        nosePB2.Visible = False
        tonguePB2.Visible = False
        earPB2.Visible = False
        bridgePB2.Visible = False
        lipPB2.Visible = False
    End Sub
End Class
'form2.showdialoge
